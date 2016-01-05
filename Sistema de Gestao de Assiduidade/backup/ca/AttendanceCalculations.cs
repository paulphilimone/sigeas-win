/*
 * Backup para a versão que controlará as portas(portas de departamentos entradas e saidas)
 * A estrutura do Funcionario.Clocks é que importa
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mz.betainteractive.sisga.settings;
using System.Globalization;

namespace mz.betainteractive.sisga.model.ca {
    public class AttendanceCalculations {
        public SortedDictionary<int, Funcionario> Funcionarios;
        
        public AttendanceCalculations() {
            this.Funcionarios = new SortedDictionary<int, Funcionario>();
        }

        //Separar Clocks por portas
        //    -Funcionario
        //       Porta(INT)
        //        |- Clocks
        //

        #region Correct Attendance Data               
        
        public void ClearAll() {
            this.Funcionarios.Clear();
        }

        public bool isClockCorrected() {
            if (Funcionarios.Count > 0) {
                return true;
            }

            return false;
        }

        public List<UserClock> GetCorrectedData() {
            List<UserClock> list = new List<UserClock>();

            foreach (Funcionario fc in Funcionarios.Values) {
                list.AddRange(fc.GetClocks());
            }

            return list;
        }

        public List<UserClock> GetValidCorrectedData() {
            List<UserClock> list = new List<UserClock>();

            foreach (Funcionario fc in Funcionarios.Values) {
                list.AddRange(fc.GetValidClocks());
            }

            return list;
        }

        public List<UserClock> GetCorrectedData(DateTime fromDate, DateTime toDate) {
            List<UserClock> list = new List<UserClock>();

            DateTime timeFrom = new DateTime(2012, 1, 1, fromDate.Hour, fromDate.Minute, 0);
            DateTime timeTo = new DateTime(2012, 1, 1, toDate.Hour, toDate.Minute, 0);

            foreach (Funcionario fc in Funcionarios.Values) {

                foreach (UserClock uc in fc.GetClocks()) {
                    DateTime ucDate = uc.DateAndTime.Value;
                    DateTime ucTime = new DateTime(2012, 1, 1, ucDate.Hour, ucDate.Minute, 0);

                    if (ucDate.CompareTo(fromDate) >= 0 && ucDate.CompareTo(toDate) <= 0) {
                        if (ucTime.CompareTo(timeFrom) >= 0 && ucTime.CompareTo(timeTo) <= 0) {
                            list.Add(uc);
                        }
                    }
                }
            }

            return list;
        }

        public List<UserClock> GetValidCorrectedData(DateTime fromDate, DateTime toDate) {
            List<UserClock> list = new List<UserClock>();

            DateTime timeFrom = new DateTime(2012, 1, 1, fromDate.Hour, fromDate.Minute, 0);
            DateTime timeTo = new DateTime(2012, 1, 1, toDate.Hour, toDate.Minute, 0);

            foreach (Funcionario fc in Funcionarios.Values) {

                foreach (UserClock uc in fc.GetValidClocks()) {
                    DateTime ucDate = uc.DateAndTime.Value;
                    DateTime ucTime = new DateTime(2012, 1, 1, ucDate.Hour, ucDate.Minute, 0);

                    if (ucDate.CompareTo(fromDate) >= 0 && ucDate.CompareTo(toDate) <= 0) {
                        if (ucTime.CompareTo(timeFrom) >= 0 && ucTime.CompareTo(timeTo) <= 0) {
                            list.Add(uc);
                        }
                    }
                }
            }

            return list;
        }

        private Funcionario GetFuncionario(int id){
            Funcionario user = null;

            if (this.Funcionarios.TryGetValue(id, out user)) {
                return user;
            } else {
                return null;
            }
        }         
                
        public void StartCorrectAttendanceData() {
            //read from db Funcionario <-to-> Users with Download.FindAllFuncionario
            //read from db UserClock <to>  Users Clocks with f.DownloadUserClocks()
            //call CorrectAttendanceData()
            //retrivie info from the usersclocks

            Funcionarios.Clear();

            List<Funcionario> lui = Download.FindAllFuncionario();

            //Read UserClocks
            foreach (Funcionario f in lui) {
                f.DownloadUserClocks();
                Funcionarios.Add(f.FpUserID, f);
            }

            CorrectAttendanceData();
        }

        public void StartCorrectAttendanceData(List<Funcionario> funcionarios) {
            //read from db Funcionario <-to-> Users with Download.FindAllFuncionario
            //read from db UserClock <to>  Users Clocks with f.DownloadUserClocks()
            //call CorrectAttendanceData()
            //retrivie info from the usersclocks

            Funcionarios.Clear();                        

            //Read UserClocks
            foreach (Funcionario f in funcionarios) {
                f.DownloadUserClocks();
                Funcionarios.Add(f.FpUserID, f);
            }

            CorrectAttendanceData();
        }
            
        //Correct user clock
        //string Data - 10/10/2010
        //private Dictionary<string, List<UserClock>> clockGrp = new Dictionary<string,List<UserClock>>();               
        private void CorrectAttendanceData() {
            
            //Trabalha-se um unico usuario
            foreach (Funcionario ui in Funcionarios.Values)  {
                //Numa unica porta
                foreach (Door door in ui.Clocks.Keys) {
                    
                    Dictionary<DateTime, List<UserClock>> dluc = null;
                    ui.Clocks.TryGetValue(door, out dluc);

                    //Trabalha-se numa unica data de um unico usuario
                    foreach (DateTime dt in dluc.Keys) {
                        
                        List<UserClock> luc = null;
                        dluc.TryGetValue(dt, out luc);

                        //Console.WriteLine("Data: " + dt);

                        if (door.TypeID == Constants.DOOR_TYPE_ONEFP.ID) { //one biometric
                            correctLUC_OneDevice(luc);
                        }else{
                            correctLUC_TwoDevices(luc);
                        }
                    }
                }

            }
        }
        
        /**
         *  Corrigir clocks para um sistema de 1 biometrico
         *  Considera entrada e saida intercaladarmente
         */        
        private void correctLUC_OneDevice(List<UserClock> luc) {

            //First Clock
            int i = 0;

            List<UserClock> corrects = new List<UserClock>();
            Dictionary<string, List<UserClock>> timeClock = new Dictionary<string, List<UserClock>>();

            //Separa por repeticao de data e hora e coloca em timeClock
            foreach (UserClock uc in luc)  {
                //Não testaremos os segundos apena D/M/A hh:mm
                string dt = uc.DateAndTime.Value.ToString("g", DateTimeFormatInfo.InvariantInfo);

                if (timeClock.ContainsKey(dt)) {
                    List<UserClock> lc = null;
                    if (timeClock.TryGetValue(dt, out lc)) {
                        lc.Add(uc);
                    }
                }else {
                    List<UserClock> lc = new List<UserClock>();
                    lc.Add(uc);
                    timeClock.Add(dt, lc);
                }

                //Console.WriteLine("  UC: " + uc.FuncionarioID + ", " + dt);
                i++;
            }

            //acertar os validos dos invalidos, ATRAVES DAS REPETICOES(dos k tiverem mesma data)
            foreach (List<UserClock> lc in timeClock.Values) {

                UserClock[] uca = lc.ToArray();

                if (lc.Count % 2 == 1){ //IMPAR
                    for (int x = 0; x < uca.Length - 1; x++) {
                        uca[x].Result = "Invalido";
                    }

                    uca[uca.Length - 1].Result = "OK";
                    corrects.Add(uca[uca.Length - 1]);
                } else {//PAR
                    foreach (UserClock u in lc)  {
                        u.Result = "Invalido";
                    }
                }
            }


            //Intercalar C/In e C/Out
            //O 1º é sempre C/In
            i = 0;
            foreach (UserClock uc in corrects) {
                if (i % 2 == 0){
                    uc.CorrectState = "Entrada";//"C/In";
                }else {
                    uc.CorrectState = "Saida";//"C/Out";
                }
                i++;
            }


        }

        private void correctLUC_TwoDevices(List<UserClock> luc){
            //How it works!
            //Estamos numa dada porta, num certo dia, para um usuario
            //Funcionario(Paulo Filimone)
            //  ->Porta(Entrada ou Saida) NB: duas portas diferentes ou é IN ou é OUT
            //    ->Dia(Segunda 12/01/2012) 
            //luc os clocks do dia 12/01/2012, para porta(IN/OUT) do usuario Paulo Filimone

            int i = 0;

            List<UserClock> corrects = new List<UserClock>();
            Dictionary<string, List<UserClock>> timeClock = new Dictionary<string, List<UserClock>>();

            //Separa por repeticao de data e hora e coloca em timeClock
            foreach (UserClock uc in luc)  {
                //Não testaremos os segundos apena D/M/A hh:mm
                string dt = uc.DateAndTime.Value.ToString("g", DateTimeFormatInfo.InvariantInfo);

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

                Console.WriteLine("2D UC: " + uc.FuncionarioID + ", " + dt);
                i++;
            }

            //acertar os validos dos invalidos, ATRAVES DAS REPETICOES
            foreach (List<UserClock> lc in timeClock.Values){

                UserClock[] uca = lc.ToArray();

                if (lc.Count % 2 == 1){ //IMPAR
                    for (int x = 0; x < uca.Length - 1; x++) {
                        uca[x].Result = "Invalido";
                    }

                    uca[uca.Length - 1].Result = "OK";
                    corrects.Add(uca[uca.Length - 1]);
                } else {//PAR
                    foreach (UserClock u in lc) {
                        u.Result = "Invalido";
                    }
                }
            }


            //Depende do tipo de dispositivo
            i = 0;
            foreach (UserClock uc in corrects) {
                if (uc.Device.TypeID == Constants.DEVICE_TYPE_IN.ID) { //IN
                    uc.CorrectState = "Entrada";
                }
                if (uc.Device.TypeID == Constants.DEVICE_TYPE_OUT.ID) { //out
                    uc.CorrectState = "Saida";
                }
                i++;
            }
        }
        
        #endregion

        #region Calculations Of AttendanceData

        //CalculateAttendanceData

        //CalculateAttendanceData(DateTime fromDate, DateTime toDate)

        public void CalculateAttendanceData(DateTime fromDate, DateTime toDate) {
            if (!isClockCorrected()) {
                StartCorrectAttendanceData();
            }                       

            foreach (Funcionario funcionario in Funcionarios.Values){

                //Trabalha-se numa unica data de um unico usuario
                for (DateTime date = fromDate.Date; toDate.CompareTo(date) >= 0; date.AddDays(1)) {

                    List<UserClock> luc = null;
                    dluc.TryGetValue(dt, out luc);

                    CalculateAttCalcs(funcionario, date, GetValidClock(luc));
                }

                foreach (Door door in funcionario.Clocks.Keys) {
                    Dictionary<DateTime, List<UserClock>> dluc = null;
                    func.Clocks.TryGetValue(door, out dluc);                    
                }
            }

        }                

        private List<UserClock> GetValidClock(List<UserClock> luc){
            List<UserClock> list = new List<UserClock>();

            if(luc != null)
            foreach (UserClock uc in luc) {
                if (uc.Result == "OK") {
                    list.Add(uc);
                }
            }
            return list;
        }
               

        #endregion
    }


}
