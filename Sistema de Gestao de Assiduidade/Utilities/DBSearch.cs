using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.settings;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Models;

namespace mz.betainteractive.sigeas.model.ca
{
    public class DBSearch {

        public static void FillContinente(SigeasDatabaseContext context, ComboBox cbo) {
            var cnts = context.Continente.AsNoTracking().OrderBy(t => t.Nome).ToList();                        

            cbo.Items.Clear();
            cbo.ResetText();

            foreach (var ct in cnts) {
                cbo.Items.Add(ct);
            }
        }

        public static void FillCountry(SigeasDatabaseContext context, ComboBox cbo) {
            var cnts = context.Countries.AsNoTracking().OrderBy(t => t.Nome).ToList();

            cbo.Items.Clear();
            cbo.ResetText();

            foreach (var ct in cnts) {
                cbo.Items.Add(ct);
            }
        }

        public static void FillProvincia(SigeasDatabaseContext context, ComboBox cbo) {

            var provs = context.Provincia.AsNoTracking().OrderBy(t => t.Nome).ToList();

            cbo.Items.Clear();
            cbo.ResetText();

            foreach (var prov in provs) {
                cbo.Items.Add(prov);
            }
        }

        public static void FillDistrito(ComboBox cbo, Provincia provincia) {

            var dists = provincia.Distritos.OrderBy(t => t.Nome).ToList();

            cbo.Items.Clear();
            cbo.ResetText();

            foreach (var dist in dists) {
                cbo.Items.Add(dist);
            }
        }

        public static void FillPostoAdministrativo(ComboBox cbo, Distrito distrito) {
            var postos = distrito.PostoAdministrativos.OrderBy(t => t.Nome).ToList();

            cbo.Items.Clear();
            cbo.ResetText();

            foreach (var posto in postos) {
                cbo.Items.Add(posto);
            }
        }              

        public static void FillLocalidade(ComboBox cbo, PostoAdministrativo postoAdministrativo) {

            var locals = postoAdministrativo.Localidades.OrderBy(t => t.Nome).ToList();

            cbo.Items.Clear();
            cbo.ResetText();

            foreach (var local in locals) {
                cbo.Items.Add(local);
            }
        }

        public static void FillSexo(SigeasDatabaseContext context, ComboBox cbo) {
            var sexos = new string[] {Sexo.MASCULINO, Sexo.FEMENINO};

            cbo.Items.Clear();
            cbo.ResetText();

            foreach (var sx in sexos) {
                cbo.Items.Add(sx);
            }
        }

        public static void FillEstadoCivil(SigeasDatabaseContext context, ComboBox cbo) {

            var objs = EstadoCivil.GetAll();

            cbo.Items.Clear();
            cbo.ResetText();

            foreach (var es in objs) {
                cbo.Items.Add(es);
            }
        }

        public static void FillDocumentoID(SigeasDatabaseContext context, ComboBox cbo) {

            var objs = DocumentoIdentificacao.GetAll();

            cbo.Items.Clear();
            cbo.ResetText();

            foreach (var es in objs) {
                cbo.Items.Add(es);
            }
        }

        public static void FillDepartamento(SigeasDatabaseContext context, ComboBox cbo, bool withTracking) {

            Empresa empresa = SystemManager.GetCurrentEmpresa(context);


            var objs = withTracking ? context.Departamento.Where(t => t.Empresa.Id == empresa.Id).ToList()
                                    : context.Departamento.AsNoTracking().Where(t => t.Empresa.Id == empresa.Id).ToList();

            cbo.Items.Clear();
            cbo.ResetText();

            foreach (var dp in objs) {
                cbo.Items.Add(dp);
            }
        }

        public static void FillCategoria(SigeasDatabaseContext context, ComboBox cbo, bool withTracking) {

            Empresa empresa = SystemManager.GetCurrentEmpresa(context);

            var objs = withTracking ? context.Categoria.Where(t => t.Empresa.Id == empresa.Id).ToList()
                                    : context.Categoria.AsNoTracking().Where(t => t.Empresa.Id == empresa.Id).ToList();

            cbo.Items.Clear();
            cbo.ResetText();

            foreach (var dp in objs) {
                cbo.Items.Add(dp);
            }
        }

        public static void FillFuncionario(SigeasDatabaseContext context, ComboBox cbo) {
            
            var objs = context.Funcionario.ToList();

            cbo.Items.Clear();
            cbo.ResetText();

            foreach (var es in objs) {
                cbo.Items.Add(es);
            }
        }

        internal static void OnSelectedProvincia(ComboBox cboProvincia, ComboBox cboDistrito, ComboBox cboPostoAdministrativo, ComboBox cboLocalidade) {
            if (cboProvincia.SelectedItem is Provincia) {
                Provincia prov = (Provincia)cboProvincia.SelectedItem;
                FillDistrito(cboDistrito, prov);
                cboPostoAdministrativo.Items.Clear();
                cboPostoAdministrativo.ResetText();
                cboLocalidade.Items.Clear();
                cboLocalidade.ResetText();
            }
        }

        internal static void OnSelectedDistrito(ComboBox cboDistrito, ComboBox cboPostoAdministrativo, ComboBox cboLocalidade) {
            if (cboDistrito.SelectedItem is Distrito) {
                Distrito dist = (Distrito)cboDistrito.SelectedItem;
                FillPostoAdministrativo(cboPostoAdministrativo, dist);
                cboLocalidade.Items.Clear();
                cboLocalidade.ResetText();
            }
        }

        internal static void OnSelectedPostoAdministrativo(ComboBox cboPostoAdministrativo, ComboBox cboLocalidade) {
            if (cboPostoAdministrativo.SelectedItem is PostoAdministrativo) {
                PostoAdministrativo posto = (PostoAdministrativo)cboPostoAdministrativo.SelectedItem;
                FillLocalidade(cboLocalidade, posto);
            }
        }

        public static List<Funcionario> FindAllFuncionarioBy(SigeasDatabaseContext context, Departamento depart, Categoria categoria) {

            List<Funcionario> list = new List<Funcionario>();

            var funs = context.Funcionario.Where(t => t.Departamento.Id == depart.Id && t.Categoria.Id == categoria.Id).ToList();

            if (funs.Count() > 0) {
                list.AddRange(funs.ToList<Funcionario>());
            }

            return list;
        }
                
        public static List<FuncionarioHorario> FindFuncionarioHorarioBy(SigeasDatabaseContext context, Funcionario funcionario, int ano) {
            List<FuncionarioHorario> list = new List<FuncionarioHorario>();

            var assocs = context.FuncionarioHorario.Where(t => t.Funcionario.Id == funcionario.Id && t.Ano == ano).ToList();

            if (assocs.Count > 0) {
                list.AddRange(assocs.ToList<FuncionarioHorario>());
            }

            return list;
        }
                
        public static FuncionarioHorario GetFuncionarioHorario(SigeasDatabaseContext context, Funcionario funcionario, DateTime dia) {                                    
            FuncionarioHorario funcHorario = null;

            funcHorario = context.FuncionarioHorario.Where(t => t.Funcionario.Id == funcionario.Id && dia >= t.Inicio && dia <= t.Fim).FirstOrDefault();

            return funcHorario;
        }

        public static HorarioDia GetHorarioDia(SigeasDatabaseContext context, Funcionario funcionario, DateTime dia) {

            FuncionarioHorario funcHorario = GetFuncionarioHorario(context, funcionario, dia);

            if (funcHorario == null) {
                return null;
            }

            return funcHorario.Horario.GetHorarioDia(dia);
        }       

        public static List<UserClock> FindAllUserClock(SigeasDatabaseContext context, Funcionario funcionario, DateTime date) {
            List<UserClock> list = new List<UserClock>();
                        
            DateTime dia = date.Date;

            /*Ordered by date*/
            var clocks = context.UserClock.Where(t => t.Funcionario.Id == funcionario.Id && t.DateAndTime.Date == dia)
                                          .OrderBy(t => t.DateAndTime).ToList();

            if (clocks.Count > 0) {
                list.AddRange(clocks.ToList<UserClock>());
            }

            return list;
        }

        public static List<UserClock> FindAllUserClock(SigeasDatabaseContext context, Funcionario funcionario, DateTime fromDate, DateTime toDate) {
            
            DateTime frDt = Constants.GetTime(fromDate, 0, 0, 0);
            DateTime toDt = Constants.GetTime(toDate, 23, 59, 59);

            var clocks = context.UserClock.Where(t => t.Funcionario.Id == funcionario.Id && t.DateAndTime >= frDt && t.DateAndTime <= toDt)
                                          .OrderBy(t => t.DateAndTime)
                                          .ToList();
        
            return clocks;
        }


        public static List<UserClock> FindAllUserClockFromTo(SigeasDatabaseContext context, DateTime fromDate, DateTime toDate) {
            
            DateTime frDt = Constants.GetTime(fromDate, 0, 0, 0);
            DateTime toDt = Constants.GetTime(toDate, 23, 59, 59);

            var clocks = context.UserClock.Where(uc => uc.DateAndTime >= frDt && uc.DateAndTime <= toDt)
                                          .OrderBy(t => t.DateAndTime)
                                          .ToList();

            return clocks;
        }

        public static List<UserClock> FindAllUserClockFromTo(SigeasDatabaseContext context, List<Funcionario> funcionarios, DateTime fromDate, DateTime toDate) {
            
            DateTime frDt = Constants.GetTime(fromDate, 0, 0, 0);
            DateTime toDt = Constants.GetTime(toDate, 23, 59, 59);

            var list = context.UserClock.Where(t => funcionarios.Contains(t.Funcionario) && t.DateAndTime >= frDt && t.DateAndTime <= toDt)
                                        .OrderBy(t => new { t.Funcionario , t.DateAndTime})
                                        .ToList();
            
            return list;

        }
                

        public static AttCalcs GetAttCalcs(SigeasDatabaseContext context, Funcionario funcionario, DateTime dia) {
            DateTime date = dia.Date;
            AttCalcs atts = context.AttCalcs.Where(t => t.Funcionario.Id == funcionario.Id && t.Data == date).FirstOrDefault();                        
            return atts;
        }                
               
        public static List<AttCalcs> FindAllAttendanceCalcs(SigeasDatabaseContext context, DateTime fromDate, DateTime toDate) {
            
            DateTime frDt = fromDate.Date;
            DateTime toDt = toDate.Date;

            var list = context.AttCalcs.Where(t => t.Data >= frDt && t.Data <= toDt)
                                        .OrderBy(t => t.Funcionario.Id).ThenBy(t => t.Data)
                                        .ToList();
                    
            return list;
        }

        public static List<AttCalcs> FindAllAttendanceCalcs(SigeasDatabaseContext context, List<Funcionario> funcionarios, DateTime fromDate, DateTime toDate, bool withTracking) {
            
            DateTime frDt = Constants.GetTime(fromDate, 0, 0, 0);
            DateTime toDt = Constants.GetTime(toDate, 23, 59, 59);

            var list = withTracking ? context.AttCalcs.Where(t => funcionarios.Contains(t.Funcionario) && t.Data >= frDt && t.Data <= toDt)
                                                      .OrderBy(t => t.Funcionario.Id).ThenBy(t => t.Data)
                                                      .ToList()
                                    : context.AttCalcs.AsNoTracking().Where(t => funcionarios.Contains(t.Funcionario) && t.Data >= frDt && t.Data <= toDt)
                                                                     .OrderBy(t => t.Funcionario.Id).ThenBy(t => t.Data)
                                                                     .ToList();

            
                        
            return list;
        }


        internal static bool IsFeriado(SigeasDatabaseContext context, DateTime dia) {
         
            DateTime date = dia.Date;
            var feriado = context.Feriado.AsNoTracking().Where(t => t.Data == date).FirstOrDefault();
            
            return (feriado != null);
        }

        internal static bool OnVacation(SigeasDatabaseContext context, Funcionario funcionario, DateTime dia) {           
            DateTime date = dia.Date;

            var ferias = funcionario.Ferias.Where(t => date >= t.DataInicial && date <= t.DataFinal).FirstOrDefault();

            return (ferias != null);
        }
    }
}
