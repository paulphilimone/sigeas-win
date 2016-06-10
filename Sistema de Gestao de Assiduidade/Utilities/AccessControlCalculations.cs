using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.sigeas.model.ca;
using mz.betainteractive.sigeas.settings;

namespace mz.betainteractive.sigeas.Utilities {

    /*
     * Verificar bem se estou conectando com o meu context ou o context da classe
     */ 
    public class AccessControlCalculations {

        private SigeasDatabaseContext context;
        private AttendanceRules rules;
        private DeviceType DEVICE_TYPE_IN;
        private DeviceType DEVICE_TYPE_OUT;
        private DeviceType DEVICE_TYPE_IN_OUT;
        private TipoAusencia AUSENCIA_DOENCAS;
        private TipoAusencia AUSENCIA_FERIAS;
        private TipoAusencia AUSENCIA_TRABALHO;
        private TipoAusencia AUSENCIA_OUTROS;
        private bool FUNCIONARIO_DISABLED_EFECTUA_CALCULOS = true;

        public AccessControlCalculations() {
            context = new SigeasDatabaseContext();
            Initialize();
        }                

        public AccessControlCalculations(SigeasDatabaseContext context) {
            this.context = context;
            Initialize();
        }

        private void Initialize() {
            Empresa empresa = SystemManager.GetCurrentEmpresa(context);

            this.rules = empresa.AttendanceRules;
            this.DEVICE_TYPE_IN = context.DeviceType.FirstOrDefault(t => t.TypeNumber == DeviceType.TYPE_IN);
            this.DEVICE_TYPE_OUT = context.DeviceType.FirstOrDefault(t => t.TypeNumber == DeviceType.TYPE_OUT);
            this.DEVICE_TYPE_IN_OUT = context.DeviceType.FirstOrDefault(t => t.TypeNumber == DeviceType.TYPE_IN_OUT);

            this.AUSENCIA_DOENCAS = context.TipoAusencia.FirstOrDefault(t => t.Nome == TipoAusencia.DOENCA);
            this.AUSENCIA_FERIAS = context.TipoAusencia.FirstOrDefault(t => t.Nome == TipoAusencia.EM_FERIAS);
            this.AUSENCIA_TRABALHO = context.TipoAusencia.FirstOrDefault(t => t.Nome == TipoAusencia.TRABALHO);
            this.AUSENCIA_OUTROS = context.TipoAusencia.FirstOrDefault(t => t.Nome == TipoAusencia.OUTRO);
        }

        #region Correction Of UserClocks

        public void CorrectAllUserClock() {
            var clocks = context.UserClock.ToList();
            CorrectAllUserClock(clocks);
        }

        public void ClearResults(List<UserClock> listUserClocks) {
            foreach (var uclock in listUserClocks) {
                uclock.Result = "";
                uclock.CorrectState = "";
            }
        }

        public void CorrectAllUserClock(List<UserClock> listUserClocks){
            //Download All UserClocks
            //Organize All UserClocks - Funcionario, <date, clock>
            //Não testaremos os segundos apena D/M/A hh:mm
            if (listUserClocks == null) {
                return;
            }

            List<UserClock> clocks = listUserClocks.OrderBy(uc => uc.DateAndTime).ToList();

            Dictionary<Funcionario, Dictionary<DateTime, List<UserClock>>> organizedMapClocks = new Dictionary<Funcionario, Dictionary<DateTime, List<UserClock>>>();
            
            foreach (UserClock uclock in clocks) {
                Funcionario funcionario = uclock.Funcionario;                
                DateTime date = uclock.DateAndTime.Date;
                Dictionary<DateTime, List<UserClock>> mapDateClocks = null;
                List<UserClock> listClocks = null;

                //Se o funcionario esta desativado não corrigir clocks - 
                if (!FUNCIONARIO_DISABLED_EFECTUA_CALCULOS) {
                    if (funcionario.Enabled == false) {
                        continue;
                    }
                }

                if (organizedMapClocks.TryGetValue(funcionario, out mapDateClocks)) {
                                        
                    if (mapDateClocks.TryGetValue(date, out listClocks)) {                                               
                        listClocks.Add(uclock);
                    } else {
                        listClocks = new List<UserClock>();
                        listClocks.Add(uclock);

                        mapDateClocks.Add(date, listClocks);
                    }

                } else {

                    mapDateClocks = new Dictionary<DateTime, List<UserClock>>();
                    listClocks = new List<UserClock>();
                    listClocks.Add(uclock);
                    mapDateClocks.Add(date, listClocks);

                    organizedMapClocks.Add(funcionario, mapDateClocks);
                }

            }

            //contas disabled não entram - a confirmar
            //map2       - <DateTime, List<UserClock>> of a Funcionario
            //map2.Value - <List<UserClock>> of a certain day of a certain Funcionario
            foreach (var map1 in organizedMapClocks) {             
                foreach (var map2 in map1.Value) {

                    CorrectListClocks(map2.Value);
                }
            }

            //After Organize and invalidate
            //testPrint(organizedMapClocks);
                        
            
        }

        /**
         *  Corrigir clocks para um sistema de 1 biometrico e 2 biometricos
         *  Considerar entrada e saida intercaladarmente para 1 biométrico
         *  Considerar entrada ou saida conforme o tipo de biométrico (2bios)
         */
        private void CorrectListClocks(List<UserClock> luc) {
            //How it works!
            //Estamos numa dada porta, num certo dia, para um usuario
            //Funcionario(Paulo Filimone)
            //  ->Porta(Entrada ou Saida) NB: duas portas diferentes ou é IN ou é OUT
            //    ->Dia(Segunda 12/01/2012) 
            //luc os clocks do dia 12/01/2012, para porta(IN/OUT) do usuario Paulo Filimone

            if (luc == null) {
                return;
            }

            int i = 0;

            List<UserClock> corrects = new List<UserClock>();
            Dictionary<string, List<UserClock>> timeClock = new Dictionary<string, List<UserClock>>();

            //Separa por repeticao de data e hora e coloca em timeClock
            foreach (UserClock uc in luc) {
                //Não testaremos os segundos apenas D/M/A hh:mm
                string dt = uc.DateAndTime.ToString("g", DateTimeFormatInfo.InvariantInfo);

                if (timeClock.ContainsKey(dt)) {
                    List<UserClock> lc = null;
                    if (timeClock.TryGetValue(dt, out lc)) {
                        lc.Add(uc);
                    }
                } else {
                    List<UserClock> lc = new List<UserClock>();
                    lc.Add(uc);
                    timeClock.Add(dt, lc);
                }

                //Console.WriteLine("  UC: " + uc.FuncionarioID + ", " + dt);
                i++;
            }

            //acertar os validos dos invalidos, ATRAVES DAS REPETICOES
            foreach (List<UserClock> lc in timeClock.Values) {

                UserClock[] uca = lc.ToArray();

                if (lc.Count % 2 == 1) { //IMPAR
                    for (int x = 0; x < uca.Length - 1; x++) {
                        uca[x].Result = "Invalido";
                    }

                    uca[uca.Length - 1].Result = "OK";
                    corrects.Add(uca[uca.Length - 1]);
                } else {//PAR - can generate error
                    foreach (UserClock u in lc) {
                        u.Result = "Invalido";
                    }

                    UserClock uc = uca[uca.Length - 1];
                    uc.Result = "OK";
                    corrects.Add(uc);
                    //Console.WriteLine(""+uc.Funcionario.Code +", "+uc.DateAndTime.ToString("u")+", "+uc.Result);
                }
            }


            //Depende do tipo de dispositivo
            //Se for TYPE_INOUT é só Intercalar C/In e C/Out
            //O 1º é sempre C/In
            //-------------------
            //Se for TYPE_IN/TYPE_OUT será conforme o tipo IN ou OUT
            //Não permite repetição de IN ou OUT

            i = 0;
            string lastState = "";

            foreach (UserClock uc in corrects) {
                if (uc.Device.DeviceType.Equals(DEVICE_TYPE_IN_OUT)) {
                    if (i % 2 == 0) {
                        uc.CorrectState = "Entrada";//"C/In";
                    } else {
                        uc.CorrectState = "Saida";//"C/Out";
                    }
                } else {

                    if (uc.Device.DeviceType.Equals(DEVICE_TYPE_IN)) { //IN
                        //Não permite repetições
                        if (lastState == "Entrada") {
                            uc.Result = "Invalido";
                        }

                        uc.CorrectState = "Entrada";
                        lastState = "Entrada";
                        //continue;
                    }

                    if (uc.Device.DeviceType.Equals(DEVICE_TYPE_OUT)) { //out
                        //Não permite repetições
                        if (lastState == "Saida") {
                            uc.Result = "Invalido";
                        }
                        uc.CorrectState = "Saida";
                        lastState = "Saida";
                        //continue;
                    }

                }

                //Check the doortype
                DoorType dtype = uc.Device.Door.Type;
                uc.IsControleGeral = (dtype.Nome == DoorType.GENERAL_ACCESS_CONTROL);

                i++;
            }
        }

        public void testPrint(Dictionary<Funcionario, Dictionary<DateTime, List<UserClock>>> organizedMapClocks) {
            //Test Print
            foreach (var map1 in organizedMapClocks) {
                Console.WriteLine("" + map1.Key.ToString());
                foreach (var map2 in map1.Value) {
                    Console.WriteLine("    " + map2.Key.ToShortDateString());
                    foreach (var list in map2.Value) {
                        Console.WriteLine("        " + list.DateAndTime.ToString() + " - "+list.Result);
                    }
                }
            }
        }

        #endregion


        #region Calculations Of AttendanceData

        private void OrganizeByDate(List<UserClock> clocks, out Dictionary<DateTime, List<UserClock>> mapDateClocks) {

            mapDateClocks = new Dictionary<DateTime, List<UserClock>>();
            List<UserClock> listClocks = null;

            foreach (UserClock uclock in clocks) {
                                
                DateTime date = uclock.DateAndTime.Date;                

                //Se o funcionario esta desativado não corrigir clocks - 
                if (!FUNCIONARIO_DISABLED_EFECTUA_CALCULOS) {
                    if (uclock.Funcionario.Enabled == false) {
                        continue;
                    }
                }

                if (mapDateClocks.TryGetValue(date, out listClocks)) {
                    listClocks.Add(uclock);
                } else {
                    listClocks = new List<UserClock>();
                    listClocks.Add(uclock);

                    mapDateClocks.Add(date, listClocks);
                }

            }

        }

        private void OrganizeByDate(List<UserClock> clocks, out Dictionary<DateTime, List<UserClock>> mapDateClocks, DateTime fromDate, DateTime toDate) {

            mapDateClocks = new Dictionary<DateTime, List<UserClock>>();
            List<UserClock> listClocks = null;

            for (var day = fromDate.Date; day <= toDate.Date; day = day.AddDays(1) ) {
                mapDateClocks.Add(day, new List<UserClock>());
            }

            foreach (UserClock uclock in clocks) {

                DateTime date = uclock.DateAndTime.Date;

                //Se o funcionario esta desativado não corrigir clocks - 
                if (!FUNCIONARIO_DISABLED_EFECTUA_CALCULOS) {
                    if (uclock.Funcionario.Enabled == false) {
                        continue;
                    }
                }

                if (mapDateClocks.TryGetValue(date, out listClocks)) {
                    listClocks.Add(uclock);
                } else {
                    listClocks = new List<UserClock>();
                    listClocks.Add(uclock);

                    mapDateClocks.Add(date, listClocks);
                }

            }

        }

        public void CalculateAttendanceData() { 
            //1 - Get UserClocks
            //2 - Organize by Funcionario <Date, List<UserClock>>
            //3 -                        

            var funcionarios = context.Funcionario.ToList();

            foreach (var funcionario in funcionarios) {
                

                var clocks = context.UserClock.Where(uc => uc.Result == "OK" && uc.Funcionario.Id==funcionario.Id).OrderBy(t => t.DateAndTime).ToList();
                //var clocks = funcionario.UserClocks.Where(uc => uc.Result == "OK").OrderBy(t => t.DateAndTime).ToList();

                Dictionary<DateTime, List<UserClock>> dateClocks = null;

                OrganizeByDate(clocks, out dateClocks);

                foreach (var date in dateClocks.Keys) {
                    List<UserClock> luc = null;
                    dateClocks.TryGetValue(date, out luc);
                    CalculateAttCalcs(funcionario, date, luc);
                }
            }

        }
                
        public void CalculateAttendanceData(DateTime fromDate, DateTime toDate) {                        
            //NEW
            var funcionarios = context.Funcionario.ToList();

            foreach (var funcionario in funcionarios) {

                
                var clocks = context.UserClock.Where(t => t.Result == "OK" &&
                                                          t.Funcionario.Id == funcionario.Id && 
                                                         (t.DateAndTime >= fromDate && t.DateAndTime <= toDate)).OrderBy(t => t.DateAndTime).ToList();
                
                /*
                var clocks = funcionario.UserClocks.Where(t => t.Result == "OK" &&                                                          
                                                         (t.DateAndTime >= fromDate && t.DateAndTime <= toDate)).OrderBy(t => t.DateAndTime).ToList();
                */

                Dictionary<DateTime, List<UserClock>> dateClocks = null;

                OrganizeByDate(clocks, out dateClocks, fromDate, toDate);

                foreach (var date in dateClocks.Keys) {
                    List<UserClock> luc = null;
                    dateClocks.TryGetValue(date, out luc);
                    CalculateAttCalcs(funcionario, date, luc);
                }
            }


        }

        public void CalculateAttendanceData(List<Funcionario> funcionarios, DateTime fromDate, DateTime toDate) {
                        
            Console.WriteLine("Start the Calcs");
            //NEW
            
            foreach (var funcionario in funcionarios) {

                
                var clocks = context.UserClock.Include("Funcionario").Where(t => t.Result == "OK" &&
                                                                            t.Funcionario.Id == funcionario.Id &&
                                                                            (t.DateAndTime >= fromDate && t.DateAndTime <= toDate)).OrderBy(t => t.DateAndTime).ToList();
                
                /*
                var clocks = funcionario.UserClocks.Where(t => t.Result == "OK" &&
                                                              (t.DateAndTime >= fromDate && t.DateAndTime <= toDate)).OrderBy(t => t.DateAndTime).ToList();
                */


                Dictionary<DateTime, List<UserClock>> dateClocks = null;

                OrganizeByDate(clocks, out dateClocks, fromDate, toDate);

                foreach (var date in dateClocks.Keys) {
                    List<UserClock> luc = null;
                    dateClocks.TryGetValue(date, out luc);
                    CalculateAttCalcs(funcionario, date, luc);
                }
            }

            Console.WriteLine("End Start the Calcs");
        }

        public List<UserClock> GetCalculatedClocks(Funcionario funcionario, DateTime dia) {
            List<UserClock> list = new List<UserClock>();

            /*
            List<UserClock> clocks = funcionario.UserClocks.Where(uc => uc.Result == "OK" &&                                                            
                                                                        uc.DateAndTime.Date == dia.Date)
                                                                        .OrderBy(t => t.DateAndTime).ToList();*/

            List<UserClock> clocks = context.UserClock.Where(uc => uc.Result == "OK" && uc.Funcionario.Id == funcionario.Id &&
                                                                   uc.DateAndTime.Date == dia.Date).OrderBy(t => t.DateAndTime).ToList();

            FuncionarioHorario fhorario = DBSearch.GetFuncionarioHorario(context, funcionario, dia);
            HorarioSemana semana = null;
            HorarioDia horarioDia = null;

            if (fhorario == null) {
                return list;
            }

            semana = fhorario.Horario;
            horarioDia = semana.GetHorarioDia(dia);

            //1º - se não tem horario não grava nada
            if (horarioDia == null) {
                return list;
            }

            bool hasIntervalo = horarioDia.HasIntervalo;

            clocks = CleanAndShiftClocks(clocks, horarioDia);
            List<UserClock>[] sepClocks = CorrectByRulesAndSeparate(clocks, horarioDia, this.rules);

            foreach (List<UserClock> lcs in sepClocks) {
                list.AddRange(lcs);
            }

            return list;
        }

        private void CalculateAttCalcs(Funcionario funcionario, DateTime dia, List<UserClock> clocks) {

            FuncionarioHorario fhorario = DBSearch.GetFuncionarioHorario(context, funcionario, dia);
            HorarioSemana semana = null;
            HorarioDia horarioDia = null;
            AttCalcs calculado = null;

            calculado = GetExistenceAttOrDelete(funcionario, dia, horarioDia == null);
            bool isNew = calculado == null;

            if (fhorario == null) {
                return;
            }

            semana = fhorario.Horario;
            horarioDia = semana.GetHorarioDia(dia);

            //1º - se não tem horario não grava nada
            if (horarioDia == null) {
                return;
            }

            bool hasIntervalo = horarioDia.HasIntervalo;

            if (isNew) {
                calculado = new AttCalcs();
            }

            calculado.Funcionario = funcionario;
            calculado.Data = dia.Date;
            calculado.HorarioDia = horarioDia;


            //2º se horario não esta ativado, não é dia de trabalho
            if (horarioDia.Enabled == false) {
                calculado.IsDayWork = false;
                calculado.IsPresente = false;

                if (isNew) {
                    context.AttCalcs.Add(calculado);
                }

                context.SaveChanges();
                return;
            }

            //3º se horario existe e está ativado, mas é feriado e é permitido
            //No feriado pode-se ter horas extras (not done yet)
            if (semana.HasFeriados && DBSearch.IsFeriado(context, dia)) {
                calculado.IsDayWork = true;
                calculado.IsFeriado = true;
                calculado.TipoAusencia = AUSENCIA_OUTROS;
                calculado.IsAusenciaAutorizada = true;

                //podemos optar por remover isto, só pra horas extras
                //if (semana.HasHorasExtras){ //calcular horas extras}

                if (isNew) {
                    context.AttCalcs.Add(calculado);
                }

                context.SaveChanges();
                return;
            }

            //4º se horario existe e está ativado, mas esta de férias
            if (DBSearch.OnVacation(context, funcionario, dia)) {
                calculado.IsDayWork = true;
                calculado.IsEmFerias = true;
                calculado.TipoAusencia = AUSENCIA_FERIAS;
                calculado.IsAusenciaAutorizada = true;

                //podemos optar por remover isto, só pra horas extras
                //if (semana.HasHorasExtras){ //calcular horas extras}

                if (isNew) {
                    context.AttCalcs.Add(calculado);
                }

                context.SaveChanges();
                return;
            }

            /*
            Console.WriteLine("Normal Clocks");
            foreach (UserClock uc in clocks) {
                Console.WriteLine("UC: " + uc.Date.ToShortDateString() + ", " + uc.Time.ToLongTimeString());
            }
            Console.WriteLine();
            */

            //The clocks
            //using uc.Time
            //corrects again, insert clocks, shift clocks
            clocks = CleanAndShiftClocks(clocks, horarioDia);
            List<UserClock>[] sepClocks = CorrectByRulesAndSeparate(clocks, horarioDia, this.rules);

            /*
            Console.WriteLine("Shifted Clocks");
            foreach(UserClock uc in clocks){
                Console.WriteLine("UC: "+uc.Date.ToShortDateString()+", "+uc.Time.ToLongTimeString());
            }
            Console.WriteLine();
            */

            //Calcular as horas de trabalho e o resto
            //NB: Agora temos os clocks separados pelos horarios
            //    Ex: Se houver intervalo no horario do dia
            //        Temos Clocks das 08:00 ás 12:00 - sepClocks[0] 
            //                   e das 13:00 ás 17:00 - sepClocks[1]
            //        Se não houver intervalo no horario do dia
            //        Temos Clocks das 08:00 ás 17:00 - sepClocks[0]
            //        No sepClocks[0] or sepClocks[1]
            //        Se não tiver clocks .Count == 0
            //        Ou temos pares clock in e clock out
            //           -IOIOIO
            //           -IOIO
            //           -IO

            calculado.IsDayWork = true;
            calculado.IsPresente = (sepClocks[0].Count > 0) || (sepClocks[1].Count > 0);

            //calculado.IsAusenciaAutorizada
            if (calculado.IsPresente == false) {
                calculado.TipoAusencia = AUSENCIA_OUTROS;
            }


            //Determinar - Entrada/Saida
            if (horarioDia.HasIntervalo) {
                if (sepClocks[0].Count > 0) {

                    calculado.Entrada = sepClocks[0].First().DateAndTime;

                    if (sepClocks[1].Count == 0) {
                        calculado.Saida = sepClocks[1].Last().DateAndTime;
                    }
                } else {
                    if (sepClocks[1].Count > 0) {
                        calculado.Entrada = sepClocks[1].First().DateAndTime;
                    }
                }
                if (sepClocks[1].Count > 0) {
                    calculado.Saida = sepClocks[1].Last().DateAndTime;
                }
            } else {
                if (sepClocks[0].Count > 0) {
                    calculado.Entrada = sepClocks[0].First().DateAndTime;
                    calculado.Saida = sepClocks[0].Last().DateAndTime;
                }
            }

            //Atrasado/Adiantado
            if (calculado.IsPresente) {
                TimeSpan atraso = (calculado.Entrada.TimeOfDay - horarioDia.Entrada1.TimeOfDay);
                TimeSpan adiantamento = (horarioDia.Saida2.TimeOfDay - calculado.Saida.TimeOfDay);

                calculado.EntradaAtrasada = Constants.GetTime(atraso);
                calculado.SaidaAdiantada = Constants.GetTime(adiantamento);
            }


            TimeSpan hTrabDiario = new TimeSpan(horarioDia.HorasTrabalho, horarioDia.MinsTrabalho, 0);

            //Horas Extras e Horas de trabalho
            if (horarioDia.HasIntervalo) {
                TimeSpan hrExtr1 = GetHorasExtras(sepClocks[0], semana, this.rules);
                TimeSpan hrExtr2 = GetHorasExtras(sepClocks[1], semana, this.rules);
                TimeSpan hrExtras = hrExtr1.Add(hrExtr2);

                calculado.HrExtrasHoras = hrExtras.Hours;
                calculado.HrExtrasMins = hrExtras.Minutes;

                TimeSpan hTrabs1 = GetHorasTrabalhadas(sepClocks[0]);
                TimeSpan hTrabs2 = GetHorasTrabalhadas(sepClocks[1]);
                TimeSpan hTrabs = hTrabs1.Add(hTrabs2);
                
                calculado.TrabalhouHoras = hTrabs.Hours;
                calculado.TrabalhouMins = hTrabs.Minutes;

            } else {
                TimeSpan hrExtras = GetHorasExtras(sepClocks[0], semana, this.rules);
                calculado.HrExtrasHoras = hrExtras.Hours;
                calculado.HrExtrasMins = hrExtras.Minutes;

                TimeSpan hTrabs = GetHorasTrabalhadas(sepClocks[0]);
                calculado.TrabalhouHoras = hTrabs.Hours;
                calculado.TrabalhouMins = hTrabs.Minutes;
            }

            //Horas sem trabalho
            TimeSpan tsHorasTrabalho = new TimeSpan(calculado.TrabalhouHoras, calculado.TrabalhouMins, 0);
            TimeSpan tsHA = hTrabDiario - tsHorasTrabalho;
            
            calculado.AusenteHoras = tsHA.Hours;
            calculado.AusenteMins = tsHA.Minutes;

            if (isNew) {
                context.AttCalcs.Add(calculado);
            }

            context.SaveChanges();

        }

        private TimeSpan GetHorasTrabalhadas(List<UserClock> list) {
            TimeSpan time = new TimeSpan(0, 0, 0);

            for (int i = 0; i < list.Count; i += 2) {
                UserClock ucIn = list.ElementAt(i);
                UserClock ucOut = list.ElementAt(i + 1);

                TimeSpan ts = ucOut.DateAndTime.TimeOfDay - ucIn.DateAndTime.TimeOfDay;
                time = time.Add(ts);
            }

            return time;
        }

        private TimeSpan GetHorasExtras(List<UserClock> clocks, HorarioSemana semana, AttendanceRules rules) {
            TimeSpan horasExtras = new TimeSpan(0, 0, 0);

            if (semana.HasHorasExtras) {

                foreach (UserClock uc in clocks) {
                    if (uc.isHoraExtra) {
                        TimeSpan hex = uc.HoraExtra.TimeOfDay;
                        if (hex.TotalMinutes >= rules.CountHorasExtrasAfter) {
                            horasExtras = horasExtras.Add(hex);
                        }
                    }
                }
                return horasExtras;
            } else {
                return horasExtras;
            }
        }

        private List<UserClock> CleanAndShiftClocks(List<UserClock> clocks, HorarioDia horarioDia) {
            DateTime hIn1 = horarioDia.Entrada1;
            DateTime hOut1 = horarioDia.Saida1;
            DateTime hIn2 = horarioDia.Entrada2;
            DateTime hOut2 = horarioDia.Saida2;

            List<UserClock> toDelete = new List<UserClock>();

            var wrongClks1 = clocks.Where(t => t.DateAndTime.TimeOfDay < hIn1.TimeOfDay).ToList();

            var wrongClks2 = clocks.Where(t => (t.DateAndTime.TimeOfDay > hOut1.TimeOfDay) && (t.DateAndTime.TimeOfDay < hIn2.TimeOfDay)).ToList();

            var wrongClks3 = clocks.Where(t => t.DateAndTime.TimeOfDay > hOut2.TimeOfDay).ToList();

            //Clean antes do horario de entrada1
            UserClock last = null;
            if (wrongClks1.Count() > 0) {
                last = wrongClks1.Last();
                toDelete.AddRange(wrongClks1);
            }

            if (last != null) {
                if (last.CorrectState == "Entrada") {
                    last.DateAndTime = Constants.GetTime(last.DateAndTime, hIn1);
                    toDelete.Remove(last);
                }
            }
            foreach (UserClock uc in toDelete) {
                clocks.Remove(uc);
            }
            toDelete.Clear();


            //Clean no periodo de intervalo  
            if (horarioDia.HasIntervalo) {

                if (wrongClks2.Count() > 0) {
                    toDelete.AddRange(wrongClks2);
                    UserClock fst = wrongClks2.First();
                    UserClock lst = wrongClks2.Last();

                    if (fst != null) {
                        if (fst.CorrectState == "Saida") {
                            fst.isHoraExtra = true;
                            TimeSpan ts = (fst.DateAndTime.TimeOfDay - hOut1.TimeOfDay);
                            fst.HoraExtra = Constants.GetTime(ts);
                            fst.DateAndTime = Constants.GetTime(fst.DateAndTime, hOut1);
                            toDelete.Remove(fst);
                        }
                    }
                    if (lst != null) {
                        if (lst.CorrectState == "Entrada") {
                            lst.DateAndTime = Constants.GetTime(lst.DateAndTime, hIn2);
                            toDelete.Remove(lst);
                        }
                    }
                }
                foreach (UserClock uc in toDelete) {
                    clocks.Remove(uc);
                }
                toDelete.Clear();
            }

            //Clean depois do horario de saida2
            UserClock first = null;
            if (wrongClks3.Count() > 0) {
                first = wrongClks3.First();
                toDelete.AddRange(wrongClks3);
            }

            if (first != null) {
                if (first.CorrectState == "Saida") {//check depois para entradas depois do horario                    
                    first.isHoraExtra = true;
                    TimeSpan ts = (first.DateAndTime.TimeOfDay - hOut2.TimeOfDay);
                    first.HoraExtra = Constants.GetTime(ts);
                    first.DateAndTime = Constants.GetTime(first.DateAndTime, hOut2);
                    toDelete.Remove(first);
                }
            }
            foreach (UserClock uc in toDelete) {
                clocks.Remove(uc);
            }
            toDelete.Clear();

            return clocks;
        }

        private List<UserClock>[] CorrectByRulesAndSeparate(List<UserClock> clocks, HorarioDia horarioDia, AttendanceRules rules) {
            List<UserClock>[] arrClocks = new List<UserClock>[2];
            arrClocks[0] = new List<UserClock>();
            arrClocks[1] = new List<UserClock>();

            DateTime hIn1 = horarioDia.Entrada1;
            DateTime hOut1 = horarioDia.Saida1;
            DateTime hIn2 = horarioDia.Entrada2;
            DateTime hOut2 = horarioDia.Saida2;
            int tolerEnt = horarioDia.ToleranciaNaEntrada1;
            int tolerSai = horarioDia.ToleranciaNaSaida2;


            if (horarioDia.HasIntervalo) {
                var clocksH1 = clocks.Where(t => t.DateAndTime.TimeOfDay >= hIn1.TimeOfDay && t.DateAndTime.TimeOfDay <= hOut1.TimeOfDay).ToList();
                var clocksH2 = clocks.Where(t => t.DateAndTime.TimeOfDay >= hIn2.TimeOfDay && t.DateAndTime.TimeOfDay <= hOut2.TimeOfDay).ToList();

                arrClocks[0].AddRange(clocksH1);
                arrClocks[1].AddRange(clocksH2);
            } else {
                var clocksH = clocks.Where(t => t.DateAndTime.TimeOfDay >= hIn1.TimeOfDay && t.DateAndTime.TimeOfDay <= hOut2.TimeOfDay).ToList();

                arrClocks[0].AddRange(clocksH);
            }

            //insert clocks and corrects times

            if (horarioDia.HasIntervalo) {
                InsertClockAndCorrectTime(arrClocks[0], horarioDia.Entrada1, horarioDia.Saida1, tolerEnt, tolerSai, rules);
                InsertClockAndCorrectTime(arrClocks[1], horarioDia.Entrada2, horarioDia.Saida2, tolerEnt, tolerSai, rules);
            } else {
                InsertClockAndCorrectTime(arrClocks[0], horarioDia.Entrada1, horarioDia.Saida2, tolerEnt, tolerSai, rules);
            }

            return arrClocks;
        }

        private void InsertClockAndCorrectTime(List<UserClock> clocks, DateTime InTime, DateTime OutTime, int tolerIn, int tolerOut, AttendanceRules rules) {
            if (clocks.Count > 0) {
                UserClock fst = clocks.First();
                UserClock lst = clocks.Last();

                //caso 1º - corrigir conforme a tolerância
                if (fst.CorrectState == "Entrada") {
                    if ((fst.DateAndTime.TimeOfDay - InTime.TimeOfDay).TotalMinutes <= tolerIn) {
                        fst.DateAndTime = Constants.GetTime(fst.DateAndTime, InTime);
                    }
                } else {
                    if ((OutTime.TimeOfDay - fst.DateAndTime.TimeOfDay).TotalMinutes <= tolerOut) {
                        fst.DateAndTime = Constants.GetTime(fst.DateAndTime, OutTime);
                    }
                }

                if (fst != lst) {
                    if (lst.CorrectState == "Saida") {
                        if ((OutTime.TimeOfDay - lst.DateAndTime.TimeOfDay).TotalMinutes <= tolerOut) {
                            lst.DateAndTime = Constants.GetTime(lst.DateAndTime, OutTime);
                        }
                    }
                }

                //caso 2º - Se houver clock in sem clock out inserir
                if (lst.CorrectState == "Entrada") {
                    UserClock uc = new UserClock();
                                        
                    uc.CorrectState = "Saida";

                    if ((OutTime.TimeOfDay - lst.DateAndTime.TimeOfDay).TotalMinutes <= rules.MinIfNoClockOut) {

                        uc.DateAndTime = Constants.GetTime(lst.DateAndTime, OutTime);

                    } else {
                        int hour = rules.MinIfNoClockOut / 60;
                        int mins = rules.MinIfNoClockOut % 60;
                        TimeSpan ts = new TimeSpan(hour, mins, 0);

                        uc.DateAndTime = Constants.GetTime(lst.DateAndTime, (OutTime.TimeOfDay - ts));
                        
                    }
                    clocks.Add(uc);
                }

                //caso 3º - Se houver clock out sem clock in inserir
                if (fst.CorrectState == "Saida") {
                    UserClock uc = new UserClock();
                                        
                    uc.CorrectState = "Entrada";

                    if ((fst.DateAndTime.TimeOfDay - InTime.TimeOfDay).TotalMinutes <= rules.MinIfNoClockIn) {
                        
                        uc.DateAndTime = Constants.GetTime(fst.DateAndTime, InTime);

                    } else {

                        uc.DateAndTime = Constants.GetTime(fst.DateAndTime, InTime.AddMinutes(rules.MinIfNoClockIn));
                        
                    }

                    clocks.Insert(0, uc);
                }

            }
        }

        private AttCalcs GetExistenceAttOrDelete(Funcionario funcionario, DateTime date, bool delete) {

            AttCalcs attc = DBSearch.GetAttCalcs(context, funcionario, date);

            if (attc != null && delete == true) {
                context.AttCalcs.Remove(attc);
                context.SaveChanges();
                return null;
            }

            return attc;
        }

        private List<UserClock> GetValidClock(List<UserClock> luc) {
            List<UserClock> list = new List<UserClock>();

            if (luc != null)
                foreach (UserClock uc in luc) {
                    if (uc.Result == "OK") {
                        list.Add(uc);
                    }
                }
            return list;
        }            

        #endregion

        public int SaveChanges() {
            return context.SaveChanges();
        }
    }
}
