using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mz.betainteractive.sigeas.Utilities;
using System.Windows.Forms;
using System.Data.Entity;
using mz.betainteractive.sigeas.Migrations;
using mz.betainteractive.encoding.encryptation;
using mz.betainteractive.sigeas.Views;
using mz.betainteractive.sigeas.Models.Entities;

using System.ComponentModel;
using mz.betainteractive.sigeas.zdbx;
using mz.betainteractive.sigeas.zdbx.models;
using System.Resources;
using System.Globalization;
using System.IO;

namespace mz.betainteractive.sigeas.Models {
    /*
     * Using Entity Framework 4.3.1
     * This Class is where everything starts 
     * The Database is initialized here
     * The Splash Screen is Loaded Here
     * The Login is Loaded Here
     */ 
    public class SystemManager {
        public static int CurrentUserId;
        public static int CurrentEmpresaId;
        public static int CHECK_IN_OUT_MINUTES = 10;
        private static SystemManager systemManager;
        private List<SystemManagerListener> listeners;

        private SystemManager() {
            listeners = new List<SystemManagerListener>();
        }

        public static SystemManager getManager() {
            if (systemManager == null) {
                systemManager = new SystemManager();
            }

            return systemManager;
        }

        public void addSystemManagerListener(SystemManagerListener sml) {
            this.listeners.Add(sml);
        }

        private void fireOnLoadingDatabase(int progress) {
            foreach (SystemManagerListener sml in listeners) {
                sml.LoadingDatabase(progress);
            }
        }

        private void fireOnFinishedLoading() {
            foreach (SystemManagerListener sml in listeners) {
                sml.FinishedLoading();
            }
        }

        public void Initialize(){
            BeginDatabase();
        }
        
        private void BeginDatabase() {
                                    
            try {

                SigeasDatabaseContext dbTeste = new SigeasDatabaseContext();
                dbTeste.Database.Initialize(true);
                //dbTeste.Database.CreateIfNotExists();
                
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Error");
                MessageBox.Show("Ocorreu erro ao iniciar o sistema.\nErro: " + ex.Message + "\nContacte o desenvolvedor para resolver este problema!", "Erro Grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //db.Database.Delete();
                System.Environment.Exit(System.Environment.ExitCode);
            }

            InsertDefaultData();

            UpdateData();
        }

        private void UpdateData() {
            //Attendance Calculations Tests
        }

        private void InsertDefaultData() {
            fireOnLoadingDatabase(0);
            
            InsertLocalizationData();
            fireOnLoadingDatabase(20);            

            InsertBasicModelData();
            fireOnLoadingDatabase(40);
                        
            InsertUserManagerData();
            fireOnLoadingDatabase(60);
                        
            InsertAccessControlData();
            fireOnLoadingDatabase(80);
                        
            InsertAccountSystemData();
            fireOnLoadingDatabase(100);
            fireOnFinishedLoading();
        }

        /*
         * Check this, our default data are in development mode
         */ 
        private void InsertUserManagerData() {
            SigeasDatabaseContext db = new SigeasDatabaseContext();


            if (db.RolePermission.Count()==0){
				//This is a special permission, esta opcao nao aparece no UserManager
                db.RolePermission.Add(new RolePermission { FormCode = 0x0047, Name = "DO_EVERYTHING" });                                              

				//this.UserManagement.FormCode = 0x0101;
				db.RolePermission.Add(new RolePermission { FormCode = 0x0101, ActionCode = 1, Name = "Visualizar dados do Gestor de Usuários" });
				db.RolePermission.Add(new RolePermission { FormCode = 0x0101, ActionCode = 2, Name = "Atualizar dados do Gestor de Usuários" });
				db.RolePermission.Add(new RolePermission { FormCode = 0x0101, ActionCode = 3, Name = "Apagar dados do Gestor de Usuários" });
				db.RolePermission.Add(new RolePermission { FormCode = 0x0101, ActionCode = 4, Name = "Adicionar dados do Gestor de Usuários" });

                //this.DeviceManager.FormCode = 0x0102;
				db.RolePermission.Add(new RolePermission { FormCode = 0x0102, ActionCode = 1, Name = "Visualizar dados do Gestor de Dispositivos Biométricos" });
				db.RolePermission.Add(new RolePermission { FormCode = 0x0102, ActionCode = 2, Name = "Atualizar dados do Gestor de Dispositivos Biométricos" });
				db.RolePermission.Add(new RolePermission { FormCode = 0x0102, ActionCode = 3, Name = "Apagar dados do Gestor de Dispositivos Biométricos" });
				db.RolePermission.Add(new RolePermission { FormCode = 0x0102, ActionCode = 4, Name = "Adicionar dados do Gestor de Dispositivos Biométricos" });

                //this.DeviceActivation.FormCode = 0x0103;
                db.RolePermission.Add(new RolePermission { FormCode = 0x0103, ActionCode = 1, Name = "Activar Biométricos para utilização no sistema" });

                //this.EmpresaForm.FormCode = 0x0104;
                db.RolePermission.Add(new RolePermission { FormCode = 0x0104, ActionCode = 1, Name = "Visualizar dados das Definições da Empresa" });
				db.RolePermission.Add(new RolePermission { FormCode = 0x0104, ActionCode = 2, Name = "Atualizar dados das Definições da Empresa" });
				db.RolePermission.Add(new RolePermission { FormCode = 0x0104, ActionCode = 3, Name = "Apagar dados das Definições da Empresa" });
				db.RolePermission.Add(new RolePermission { FormCode = 0x0104, ActionCode = 4, Name = "Adicionar dados das Definições da Empresa" });
				
				//this.FuncionarioForm.FormCode = 0x0105;
				db.RolePermission.Add(new RolePermission { FormCode = 0x0105, ActionCode = 1, Name = "Visualizar dados dos Funcionários" });
				db.RolePermission.Add(new RolePermission { FormCode = 0x0105, ActionCode = 2, Name = "Atualizar dados dos Funcionários" });
				db.RolePermission.Add(new RolePermission { FormCode = 0x0105, ActionCode = 3, Name = "Apagar dados dos Funcionários" });
				db.RolePermission.Add(new RolePermission { FormCode = 0x0105, ActionCode = 4, Name = "Adicionar dados dos Funcionários" });
				
				//this.HorarioSemanalForm.FormCode = 0x0106;				
				db.RolePermission.Add(new RolePermission { FormCode = 0x0106, ActionCode = 1, Name = "Visualizar Perfis de Horários Semanais" });				
                db.RolePermission.Add(new RolePermission { FormCode = 0x0106, ActionCode = 2, Name = "Atualizar Perfis de Horários Semanais" });				
                db.RolePermission.Add(new RolePermission { FormCode = 0x0106, ActionCode = 3, Name = "Apagar Perfis de Horários Semanais" });				
				db.RolePermission.Add(new RolePermission { FormCode = 0x0106, ActionCode = 4, Name = "Adicionar Perfis de Horários Semanais" });				
				
				//this.PlanificacaoHorarioForm.FormCode = 0x0107;
				db.RolePermission.Add(new RolePermission { FormCode = 0x0107, ActionCode = 1, Name = "Visualizar Planificação de Horários" });
                db.RolePermission.Add(new RolePermission { FormCode = 0x0107, ActionCode = 2, Name = "Planificar(Adicionar/Alterar) Horários" });
				
				//this.FeriadosForm.FormCode = 0x0108;
				db.RolePermission.Add(new RolePermission { FormCode = 0x0108, ActionCode = 1, Name = "Visualizar Feriados" });
				db.RolePermission.Add(new RolePermission { FormCode = 0x0108, ActionCode = 4, Name = "Adicionar Feriados" });
								
				//this.FeriasForm.FormCode = 0x0109;
				db.RolePermission.Add(new RolePermission { FormCode = 0x0109, ActionCode = 1, Name = "Visualizar Planificação de Férias" });
				db.RolePermission.Add(new RolePermission { FormCode = 0x0109, ActionCode = 2, Name = "Atualizar Plano de Férias" });				
				
				//this.UserClockViewerForm.FormCode = 0x0110;
				db.RolePermission.Add(new RolePermission { FormCode = 0x0110, ActionCode = 1, Name = "Visualizar Registos de Picagens" });
				db.RolePermission.Add(new RolePermission { FormCode = 0x0110, ActionCode = 2, Name = "Atualizar Registos de Picagens" });
				db.RolePermission.Add(new RolePermission { FormCode = 0x0110, ActionCode = 3, Name = "Apagar Registos de Picagens" });
				db.RolePermission.Add(new RolePermission { FormCode = 0x0110, ActionCode = 4, Name = "Adicionar Registos de Picagens" });
				
				//this.AttendanceCalcsForm.FormCode = 0x0111;
				db.RolePermission.Add(new RolePermission { FormCode = 0x0111, ActionCode = 1, Name = "Aceder ao formulário de Cálculos de Asseduidades" });				
				db.RolePermission.Add(new RolePermission { FormCode = 0x0111, ActionCode = 2, Name = "Efectuar Calculos de Asseduidade" });
				
                //this.tableFuncionarioDeviceView.FormCode = 0x0112;
                db.RolePermission.Add(new RolePermission { FormCode = 0x0112, ActionCode = 1, Name = "Planificar Nivel de acesso as portas/biométricos, pelos Funcionarios" });

                //this.deviceDataUpdateView.FormCode = 0x0113;
                db.RolePermission.Add(new RolePermission { FormCode = 0x0113, ActionCode = 1, Name = "Atualizar Dados dos Dispositivos Biométricos" });				
                
                //this.importExportView.FormCode = 0x0114; 


                db.SaveChanges();
            }

            if (db.Role.Count()==0) {

                db.Role.Add(new Role { Name = "System Developers"});
                db.SaveChanges();
				
				db.Role.Add(new Role { Name = "Administrador"});
                db.SaveChanges();

				//Defining System Developer
                Role role = db.Role.FirstOrDefault(r => r.Name == "System Developers");
                RolePermission permDoEverything = db.RolePermission.FirstOrDefault(rp => rp.Name == "DO_EVERYTHING");                
                role.RolePermissions.Add(permDoEverything);
                db.SaveChanges();
								
								
				//Defining Administrator
				Role roleAdmin = db.Role.FirstOrDefault(r => r.Name == "Administrador");				

				List<RolePermission> permissions1 = db.RolePermission.Where(t => t.FormCode == 0x0101).ToList();
                //List<RolePermission> permissions2 = db.RolePermission.Where(t => t.FormCode == 0x0103).ToList();
                List<RolePermission> permissions = new List<RolePermission>();

                permissions.AddRange(permissions1);
                //permissions.AddRange(permissions2);
                

				foreach (var permission in permissions){
					roleAdmin.RolePermissions.Add(permission);
				}
				db.SaveChanges();
				
            }

            if (db.ApplicationUser.Count() == 0) {
                BetaEncryptation encoder = new BetaEncryptation();

                //Set Developer
                ApplicationUser user = new ApplicationUser();
                user.Firstname = ".NET";
                user.Lastname = "Developer";
                user.Username = "developer";
                user.Password = encoder.EncodePassword("developer");
                user.Email = "paulphilimone@yahoo.com.br";
                user.Enabled = true;
                
                db.ApplicationUser.Add(user);
                db.SaveChanges();

                Role role = db.Role.FirstOrDefault(r => r.Name == "System Developers");

                user.Roles.Add(role);
                db.SaveChanges();


                //Set Administrator
                ApplicationUser userAdmin = new ApplicationUser();
                userAdmin.Firstname = "Administrador";
                userAdmin.Lastname = "Geral";
                userAdmin.Username = "administrator";
                userAdmin.Password = encoder.EncodePassword("administrator");
                userAdmin.Email = "";
                userAdmin.Enabled = true;

                db.ApplicationUser.Add(userAdmin);
                db.SaveChanges();

                Role roleAdmin = db.Role.FirstOrDefault(r => r.Name == "Administrador");
                userAdmin.Roles.Add(roleAdmin);
                db.SaveChanges();

                /*
                Empresa empresa = new Empresa();
                empresa.Nome = "Beta Interactive Lda";
                empresa.Email = "betainteractive@gmail.com";
                empresa.CreatedBy = userAdmin;
                empresa.CreationDate = DateTime.Now;

                db.Empresa.Add(empresa);
                db.SaveChanges();


                Departamento dep1 = new Departamento { Nome = "Direcção Geral", Descricao = "sss" };
                Departamento dep2 = new Departamento { Nome = "Engenharia", Descricao = "sss" };
                Categoria cat1 = new Categoria { Nome = "CEO", Funcoes = "Administrativas" };
                Categoria cat2 = new Categoria { Nome = "Programador", Funcoes = "Programador" };

                empresa.Departamentos.Add(dep1);
                empresa.Departamentos.Add(dep2);
                empresa.Categorias.Add(cat1);
                empresa.Categorias.Add(cat2);

                db.SaveChanges();
                 */
            }
            
        }

        private void InsertAccountSystemData() {
            SigeasDatabaseContext db = new SigeasDatabaseContext();

            /*
             * Dados a serem confirmados
             */
            
            if (db.PeriodoTempo.Count() == 0) {
                db.PeriodoTempo.Add(new PeriodoTempo { Descricao = PeriodoTempo.DIARIO});
                db.PeriodoTempo.Add(new PeriodoTempo { Descricao = PeriodoTempo.SEMANAL });
                db.PeriodoTempo.Add(new PeriodoTempo { Descricao = PeriodoTempo.MENSAL });
                db.PeriodoTempo.Add(new PeriodoTempo { Descricao = PeriodoTempo.TRIMESTRAL });
                db.PeriodoTempo.Add(new PeriodoTempo { Descricao = PeriodoTempo.SEMESTRAL });
                db.PeriodoTempo.Add(new PeriodoTempo { Descricao = PeriodoTempo.ANUAL });

                db.SaveChanges();
            }

            /*
            if (db.ServicoCartao.Count() == 0) {


                db.ServicoCartao.Add(new ServicoCartao { Nome = "X-BUS", Taxa = 5, ValorPorTransacao = 30, Descricao = "Serviço X-BUS, .......... [a descrever]", TaxaPeriodo = db.PeriodoTempo.FirstOrDefault(t => t.Descricao == PeriodoTempo.MENSAL) });
                db.ServicoCartao.Add(new ServicoCartao { Nome = "X-LUNCH", Taxa = 5, ValorPorTransacao = 100, Descricao = "Serviço X-LUNCH, Comidas ...........[a descrever]", TaxaPeriodo = db.PeriodoTempo.FirstOrDefault(t => t.Descricao == PeriodoTempo.MENSAL) });
                db.ServicoCartao.Add(new ServicoCartao { Nome = "X-CLINC", Taxa = 5, ValorPorTransacao = 250, Descricao = "Serviço X-CLINC, .......... [a descrever]", TaxaPeriodo = db.PeriodoTempo.FirstOrDefault(t => t.Descricao == PeriodoTempo.MENSAL) });
                db.ServicoCartao.Add(new ServicoCartao { Nome = "Cesta Básica", Taxa = 5, ValorPorTransacao = 50, Descricao = "Serviço de Cesta Basica, .......... [a descrever]", TaxaPeriodo = db.PeriodoTempo.FirstOrDefault(t => t.Descricao == PeriodoTempo.MENSAL) });
                db.ServicoCartao.Add(new ServicoCartao { Nome = "Despesas de Representação", Taxa = 5, ValorPorTransacao = 100, Descricao = "Serviço de Despesas de Representação, .......... [a descrever]", TaxaPeriodo = db.PeriodoTempo.FirstOrDefault(t => t.Descricao == PeriodoTempo.MENSAL) });
                db.ServicoCartao.Add(new ServicoCartao { Nome = "Alojamento", Taxa = 5, ValorPorTransacao = 100, Descricao = "Serviço de Alojamento, .......... [a descrever]", TaxaPeriodo = db.PeriodoTempo.FirstOrDefault(t => t.Descricao == PeriodoTempo.MENSAL) });
                db.ServicoCartao.Add(new ServicoCartao { Nome = "Despesas Escolares", Taxa = 5, ValorPorTransacao = 50, Descricao = "Serviço de Despesas Escolares, .......... [a descrever]", TaxaPeriodo = db.PeriodoTempo.FirstOrDefault(t => t.Descricao == PeriodoTempo.MENSAL) });
                db.ServicoCartao.Add(new ServicoCartao { Nome = "Shopping", Taxa = 5, ValorPorTransacao = 20, Descricao = "Serviço de Shopping, .......... [a descrever]", TaxaPeriodo = db.PeriodoTempo.FirstOrDefault(t => t.Descricao == PeriodoTempo.MENSAL) });

                db.SaveChanges();
            }

            if (db.TipoCartao.Count()==0) {
                db.TipoCartao.Add(new TipoCartao { Nome = "Cartão X-Day", Descricao = "Cartão Executive Day, adquirido ao abrir o contrato Corporate" });
                db.TipoCartao.Add(new TipoCartao { Nome = "Cartão +Jovem", Descricao = "Cartão Mais Jovem, adquirido ao abrir o contrato Familia e/ou Escola" });
                db.SaveChanges();

                TipoCartao cartaoXday = db.TipoCartao.FirstOrDefault(tc => tc.Nome == "Cartão X-Day");
                TipoCartao cartaoMjovem = db.TipoCartao.FirstOrDefault(tc => tc.Nome == "Cartão +Jovem");

                ServicoCartao servXBUS = db.ServicoCartao.FirstOrDefault(sc => sc.Nome == "X-BUS");
                ServicoCartao servXLUNCH = db.ServicoCartao.FirstOrDefault(sc => sc.Nome == "X-LUNCH");
                ServicoCartao servXCLINC = db.ServicoCartao.FirstOrDefault(sc => sc.Nome == "X-CLINC");

                cartaoXday.ServicosBasicos.Add(servXBUS);
                cartaoXday.ServicosBasicos.Add(servXLUNCH);
                cartaoXday.ServicosBasicos.Add(servXCLINC);

                cartaoMjovem.ServicosBasicos.Add(servXBUS);
                cartaoMjovem.ServicosBasicos.Add(servXLUNCH);

                db.SaveChanges();
            }

            if (db.TipoContrato.Count() == 0) {
                TipoCartao cartaoXday = db.TipoCartao.FirstOrDefault(tc => tc.Nome == "Cartão X-Day");
                TipoCartao cartaoMjovem = db.TipoCartao.FirstOrDefault(tc => tc.Nome == "Cartão +Jovem");

                db.TipoContrato.Add(new TipoContrato { Nome = "Contrato Corporate", TipoCartao = cartaoXday, Descricao = "Contrato exclusivo para empresas"});
                db.TipoContrato.Add(new TipoContrato { Nome = "Contrato Familia", TipoCartao = cartaoMjovem, Descricao = "Contrato destinado para familias ou singulares" });
                db.SaveChanges();

                db.TipoContrato.Add(new TipoContrato { Nome = "Contrato Escola", TipoCartao = cartaoMjovem, Descricao = "Contrato destinado para Instituições de ensino" });
                db.SaveChanges();
            }

            if (db.ContaActivationOperation.Count() == 0) {
                db.ContaActivationOperation.Add(new ContaActivation { Descricao = ContaActivation.CONTA_LOCK });
                db.ContaActivationOperation.Add(new ContaActivation { Descricao = ContaActivation.CONTA_UNLOCK });
                db.SaveChanges();
            }

            if (db.ContratoActivationOperation.Count() == 0) {
                db.ContratoActivationOperation.Add(new ContratoActivation { Descricao = ContratoActivation.CONTRATO_ACTIVATION });
                db.ContratoActivationOperation.Add(new ContratoActivation { Descricao = ContratoActivation.CONTRATO_DEACTIVATION });
                db.ContratoActivationOperation.Add(new ContratoActivation { Descricao = ContratoActivation.CONTRATO_LOCK });
                db.ContratoActivationOperation.Add(new ContratoActivation { Descricao = ContratoActivation.CONTRATO_UNLOCK });
                db.ContratoActivationOperation.Add(new ContratoActivation { Descricao = ContratoActivation.CONTRATO_RENOVATION });
                db.ContratoActivationOperation.Add(new ContratoActivation { Descricao = ContratoActivation.CONTRATO_EXPIRED });
                db.SaveChanges();
            }

            if (db.LocalCategoria.Count() == 0) {
                db.LocalCategoria.Add(new LocalCategoria { Nome = LocalCategoria.CANTINA });
                db.LocalCategoria.Add(new LocalCategoria { Nome = LocalCategoria.CINEMA });
                db.LocalCategoria.Add(new LocalCategoria { Nome = LocalCategoria.CLINICA });
                db.LocalCategoria.Add(new LocalCategoria { Nome = LocalCategoria.CLUBE });
                db.LocalCategoria.Add(new LocalCategoria { Nome = LocalCategoria.ESCOLA });
                db.LocalCategoria.Add(new LocalCategoria { Nome = LocalCategoria.FARMACIA });
                db.LocalCategoria.Add(new LocalCategoria { Nome = LocalCategoria.HOSPITAL });
                db.LocalCategoria.Add(new LocalCategoria { Nome = LocalCategoria.INTERNET_CAFE });
                db.LocalCategoria.Add(new LocalCategoria { Nome = LocalCategoria.LOJA });
                db.LocalCategoria.Add(new LocalCategoria { Nome = LocalCategoria.PASTELARIA });
                db.LocalCategoria.Add(new LocalCategoria { Nome = LocalCategoria.REFEITORIO });
                db.LocalCategoria.Add(new LocalCategoria { Nome = LocalCategoria.RESTAURANTE });
                db.LocalCategoria.Add(new LocalCategoria { Nome = LocalCategoria.SUPERMERCADO});
                db.LocalCategoria.Add(new LocalCategoria { Nome = LocalCategoria.UNIVERSIDADE });
                db.SaveChanges();
            }

            */

        }

        private void InsertAccessControlData() {

            SigeasDatabaseContext db = new SigeasDatabaseContext();

            if (db.InOutMode.Count() == 0) {
                db.InOutMode.Add(new InOutMode { Number = InOutMode.CHECK_IN_NUMBER,      Name = InOutMode.CHECK_IN_NAME});
                db.InOutMode.Add(new InOutMode { Number = InOutMode.CHECK_OUT_NUMBER,     Name = InOutMode.CHECK_OUT_NAME });
                db.InOutMode.Add(new InOutMode { Number = InOutMode.BREAK_OUT_NUMBER,     Name = InOutMode.BREAK_OUT_NAME });
                db.InOutMode.Add(new InOutMode { Number = InOutMode.BREAK_IN_NUMBER,      Name = InOutMode.BREAK_IN_NAME });
                db.InOutMode.Add(new InOutMode { Number = InOutMode.OVERTIME_IN_NUMBER,   Name = InOutMode.OVERTIME_IN_NAME });
                db.InOutMode.Add(new InOutMode { Number = InOutMode.OVERTIME_OUT_NUMBER,  Name = InOutMode.OVERTIME_OUT_NAME });
                db.SaveChanges();                                                         
            }                                                                              

            if (db.VerifyMode.Count() == 0) {
                db.VerifyMode.Add(new VerifyMode { Number = VerifyMode.PASSWORD_NUMBER,    Name = VerifyMode.PASSWORD_NAME});
                db.VerifyMode.Add(new VerifyMode { Number = VerifyMode.FINGERPRINT_NUMBER, Name = VerifyMode.FINGERPRINT_NAME });
                db.VerifyMode.Add(new VerifyMode { Number = VerifyMode.CARD_NUMBER,        Name = VerifyMode.CARD_NAME });
                db.SaveChanges();
            }


            
            if (db.DeviceType.Count() == 0) {
                db.DeviceType.Add(new DeviceType { TypeNumber = DeviceType.TYPE_IN,     Name = DeviceType.IN});
                db.DeviceType.Add(new DeviceType { TypeNumber = DeviceType.TYPE_OUT,    Name = DeviceType.OUT});
                db.DeviceType.Add(new DeviceType { TypeNumber = DeviceType.TYPE_IN_OUT, Name = DeviceType.IN_OUT});
                db.SaveChanges();
            }
            
            if (db.DoorType.Count() == 0) {
                db.DoorType.Add(new DoorType { Nome = DoorType.GENERAL_ACCESS_CONTROL, Descricao = "Usado para calculos de asseduidade"});
                db.DoorType.Add(new DoorType { Nome = DoorType.PRIVATE_ACCESS_CONTROL, Descricao = "Usado para controle de acesso aos departamentos" });
                db.SaveChanges();
            }

            if (db.TipoAusencia.Count() == 0) {
                db.TipoAusencia.Add(new TipoAusencia { Nome = TipoAusencia.DOENCA });
                db.TipoAusencia.Add(new TipoAusencia { Nome = TipoAusencia.EM_FERIAS });
                db.TipoAusencia.Add(new TipoAusencia { Nome = TipoAusencia.TRABALHO });
                db.TipoAusencia.Add(new TipoAusencia { Nome = TipoAusencia.OUTRO });
                db.SaveChanges();
            }
            /*
            if (db.AccessControlSettings.Count() == 0) {

                AccessControlSettings accessControl = new AccessControlSettings();

                accessControl.CheckOutAfterMinutes = 10;
                accessControl.TempoMinimoContrato = 90; //90 Dias
                accessControl.Perc_MinimaRenovar = 75.0; //75%

                db.AccessControlSettings.Add(accessControl);
                db.SaveChanges();
            }
            */
            //DeviceType
        }

        private void InsertBasicModelData() {
            
            SigeasDatabaseContext db = new SigeasDatabaseContext();

            /* - WE DONT NEED ANYMORE, IS PREFERED TO USE STRING INSTEAD OF OBJS
            if (db.Sexo.Count() == 0) {                
                db.Sexo.Add(new Sexo{ Nome = Sexo.MASCULINO });
                db.Sexo.Add(new Sexo{ Nome = Sexo.FEMENINO });
                db.SaveChanges();
            }

            if (db.EstadoCivil.Count() == 0) {
                db.EstadoCivil.Add(new EstadoCivil { Nome = EstadoCivil.SOLTEIRO   });
                db.EstadoCivil.Add(new EstadoCivil { Nome = EstadoCivil.CASADO     });
                db.EstadoCivil.Add(new EstadoCivil { Nome = EstadoCivil.DIVORCIADO });
                db.EstadoCivil.Add(new EstadoCivil { Nome = EstadoCivil.VIUVO      });
                db.SaveChanges();
            }

            if (db.DocumentoIdentificacao.Count() == 0) {
                db.DocumentoIdentificacao.Add(new DocumentoIdentificacao { Nome = DocumentoIdentificacao.BI, ExpressaoPadrao = "" });
                db.DocumentoIdentificacao.Add(new DocumentoIdentificacao { Nome = DocumentoIdentificacao.PASSAPORTE, ExpressaoPadrao = "" });
                db.DocumentoIdentificacao.Add(new DocumentoIdentificacao { Nome = DocumentoIdentificacao.CEDULA_PESSOAL, ExpressaoPadrao = "" });
                db.DocumentoIdentificacao.Add(new DocumentoIdentificacao { Nome = DocumentoIdentificacao.CERTIDAO_DE_NASCIMENTO, ExpressaoPadrao = "" });
                db.SaveChanges();
            }
            */

        }

        private void InsertLocalizationData() {
                        
            SigeasDatabaseContext db = new SigeasDatabaseContext();
            
            //Insert Countries
            if (db.Continente.Count() == 0 || db.Countries.Count() == 0) {

                //try {

                    ResourceManager rm = mz.betainteractive.sigeas.Properties.Resources.ResourceManager;

                    byte[] bytes = (byte[])rm.GetObject("countries", CultureInfo.CurrentCulture);
                    Stream stream = new MemoryStream(bytes, false);
                    CSVReader reader = new CSVReader(stream, true);

                    while (reader.ReadNextRow()) {
                        string continent = reader.getField("Continent");
                        string country = reader.getField("Country");
                        string capital = reader.getField("Capital");

                        Continente continente = db.Continente.FirstOrDefault(t => t.Nome == continent);

                        if (continente == null) {
                            continente = new Continente { Nome = continent };

                            db.Continente.Add(continente);
                        }

                        Pais pais = new Pais { Nome = country, Capital = capital };
                        continente.Paises.Add(pais);

                        db.SaveChanges();
                    }
                /*
                } catch (Exception ex) {
                    LogErrors.AddErrorLog(ex, "Não foi possivel ler os dados dos ficheiros de localização mundial!");
                    MessageBox.Show("Não foi possivel ler os dados dos ficheiros de localização mundial");
                }*/
            }

            //Insert Mozambique Localization
            //Insert Countries
            if (db.Provincia.Count() == 0 || db.Localidade.Count() == 0) {

                //try {

                    ResourceManager rm = mz.betainteractive.sigeas.Properties.Resources.ResourceManager;

                    byte[] bytes = (byte[])rm.GetObject("mozambique", CultureInfo.CurrentCulture);
                    Stream stream = new MemoryStream(bytes, false);
                    CSVReader reader = new CSVReader(stream, true);

                    while (reader.ReadNextRow()) { //Provincia;Distrito;PostoAdministrativo;Localidade
                        string provincia_nome = reader.getField("Provincia");
                        string distrito_nome = reader.getField("Distrito");
                        string postoAdm_nome = reader.getField("PostoAdministrativo");
                        string localidade_nome = reader.getField("Localidade");

                        Provincia provincia = null;
                        Distrito distrito = null;
                        PostoAdministrativo postoAdministrativo = null;
                        Localidade localidade = null;

                        provincia = db.Provincia.FirstOrDefault(t => t.Nome == provincia_nome);
                        distrito = db.Distrito.FirstOrDefault(t => t.Nome == distrito_nome);
                        postoAdministrativo = db.PostoAdministrativo.FirstOrDefault(t => t.Nome == postoAdm_nome);
                        localidade = db.Localidade.FirstOrDefault(t => t.Nome == localidade_nome);

                        if (provincia == null) {
                            provincia = new Provincia { Nome = provincia_nome };

                            db.Provincia.Add(provincia);
                        }

                        if (distrito == null) {
                            distrito = new Distrito { Nome = distrito_nome };

                            provincia.Distritos.Add(distrito);
                        }

                        if (postoAdministrativo == null) {
                            postoAdministrativo = new PostoAdministrativo { Nome = postoAdm_nome };

                            distrito.PostoAdministrativos.Add(postoAdministrativo);
                        }

                        if (localidade == null) {
                            localidade = new Localidade { Nome = localidade_nome };

                            postoAdministrativo.Localidades.Add(localidade);
                        }

                        db.SaveChanges();
                    }
                /*
                } catch (Exception ex) {
                    LogErrors.AddErrorLog(ex, "Não foi possivel ler os dados dos ficheiros de localização de Moçambique!");
                    MessageBox.Show("Não foi possivel ler os dados dos ficheiros de localização de Moçambique");
                }*/
            }

        }

        public void Tests() {
            SigeasDatabaseContext db = new SigeasDatabaseContext();

            db.Database.CreateIfNotExists();

            if (db.Continente.Count() > 0) {
                var all = from c in db.Continente select c;

                foreach (Continente cont in all) {
                    Console.WriteLine("Continente: " + cont.Nome);
                }

            } else {

                Continente africa = new Continente();
                africa.Code = 1;
                africa.Nome = "Africa";
                db.Continente.Add(africa);
                db.SaveChanges();
            }

            ApplicationUser firstUser = null;

            if (db.ApplicationUser.Count() == 0) {

                ApplicationUser user = new ApplicationUser();
                user.Firstname = "Paulo";
                user.Lastname = "Filimone";
                user.Username = "paulo";
                user.Password = "paulox";
                user.CreationDate = DateTime.Now;
                db.ApplicationUser.Add(user);
                db.SaveChanges();

                user = db.ApplicationUser.First();
                user.CreatedBy = user;
                db.SaveChanges();


            }

            firstUser = db.ApplicationUser.First();

            if (db.ApplicationUser.Count() == 2) {

                var users = db.ApplicationUser.ToList();

                foreach (ApplicationUser user in users) {
                    Console.WriteLine("User: " + user.Id + ", CreatedBy: " + user.CreatedBy + ", roles: " + user.Roles.Count);
                }

                return;
            }

            if (firstUser != null) {
                Role role = new Role();
                role.Name = "Administrator";
                firstUser.Roles.Add(role);
                db.SaveChanges();

                ApplicationUser user = new ApplicationUser();
                user.Firstname = "X-47";
                user.Lastname = "Panelas";
                user.Username = "x47";
                user.Password = "paulox";
                user.CreationDate = DateTime.Now;
                user.CreatedBy = firstUser;
                db.ApplicationUser.Add(user);
                db.SaveChanges();
            }
        }
                
        public static ApplicationUser GetCurrentUser(SigeasDatabaseContext db) {
            return db.ApplicationUser.FirstOrDefault(t => t.Id == CurrentUserId);
        }

        public static Empresa GetCurrentEmpresa(SigeasDatabaseContext db) {
            return db.Empresa.FirstOrDefault(t => t.Id == CurrentEmpresaId);
        }               
    }

    public interface SystemManagerListener {
        void LoadingDatabase(int progressPercentage);

        void FinishedLoading();
    }
}
