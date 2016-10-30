using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Views.DeviceManagement;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Views.Empresas;
using mz.betainteractive.sigeas.Views.Funcionarios;
using mz.betainteractive.sigeas.Views.Horarios;
using mz.betainteractive.sigeas.Views.AccessControl;
using mz.betainteractive.sigeas.Views.UserManagment;
using mz.betainteractive.utilities.module.Components;
using mz.betainteractive.sigeas.Views.FuncionarioDevices;
using mz.betainteractive.sigeas.Views.ImportExport;
using mz.betainteractive.sigeas.Views.Reports;
using XPExplorerBar;


namespace mz.betainteractive.sigeas.Views.Main {
    public partial class MainView : Form {                
        /*
        * My variables 
        */
        public static bool Connected = false;
        //public static MainView MainProgram;

        public LoginView LoginView { get; set; }
                
        public FrmAboutBox AboutBox;
        public DeviceManager DeviceManager;  
        public FrmDeviceActivaction DeviceActivation;
        
        public FrmEmpresa EmpresaForm;
        public FrmFuncionario FuncionarioForm;
        public FrmHorarioSemanal HorarioSemanalForm;        
        public FrmPlanificacaoHorario PlanificacaoHorarioForm;
        public FrmFeriados FeriadosForm;
        public FrmFerias FeriasForm;
        public UserClocksViewer UserClockViewerForm;
        public AttendanceCalcsView AttendanceCalcsForm;
        public UserManager UserManagement { get; set; }
        public TableFuncionarioDeviceView tableFuncionarioDeviceView { get; set; }
        public DeviceDataUpdateView deviceDataUpdateView { get; set; }
        public ImportHrData importHrData { get; set; }
        public ImportExportView importExportView { get; set; }
        public PedidoDispensaView pedidoDispensaView { get; set; }
        public ReportsCreatorView reportsCreatorView { get; set; }

        public static ToolStripLabel tssGeralSystemStatus;

        private Dictionary<int, AuthorizableComponent> securedComponents;

        /*
         * My variables Ends
         */
        public MainView()      {
            InitializeComponent();

            //MainProgram = this;

            tssGeralSystemStatus = tssSystemStatus;            
                        
            AboutBox = new FrmAboutBox();
            DeviceManager = new DeviceManager();
            DeviceActivation = new FrmDeviceActivaction();
            UserManagement = new UserManager();
            EmpresaForm = new FrmEmpresa();
            FuncionarioForm = new FrmFuncionario();
            HorarioSemanalForm = new FrmHorarioSemanal();            
            PlanificacaoHorarioForm = new FrmPlanificacaoHorario();
            FeriadosForm = new FrmFeriados();
            FeriasForm = new FrmFerias();
            UserClockViewerForm = new UserClocksViewer();
            AttendanceCalcsForm = new AttendanceCalcsView();
            tableFuncionarioDeviceView = new TableFuncionarioDeviceView();
            deviceDataUpdateView = new DeviceDataUpdateView();
            importHrData = new ImportHrData();
            importExportView = new ImportExportView();
            pedidoDispensaView = new PedidoDispensaView();
            reportsCreatorView = new ReportsCreatorView();

            DeviceManager.MdiParent = this;
            FuncionarioForm.MdiParent = this;
            UserManagement.MdiParent = this;
            AboutBox.MdiParent = this;
            InitSecurity();
            InitFormsLayout();
        }

        private void InitFormsLayout() {
            
        }

        private void InitSecurity() {
            this.securedComponents = new Dictionary<int, AuthorizableComponent>();

            this.UserManagement.FormCode             = 0x0101;
            this.DeviceManager.FormCode              = 0x0102;
            this.DeviceActivation.FormCode           = 0x0103;
            this.EmpresaForm.FormCode                = 0x0104;
            this.FuncionarioForm.FormCode            = 0x0105;
            this.HorarioSemanalForm.FormCode         = 0x0106;
            this.PlanificacaoHorarioForm.FormCode    = 0x0107;
            this.FeriadosForm.FormCode               = 0x0108;
            this.FeriasForm.FormCode                 = 0x0109;            
            this.UserClockViewerForm.FormCode     = 0x0110;
            this.AttendanceCalcsForm.FormCode     = 0x0111;            
            this.tableFuncionarioDeviceView.FormCode = 0x0112;
            this.deviceDataUpdateView.FormCode       = 0x0113;
            this.importExportView.FormCode = 0x0114;
            this.pedidoDispensaView.FormCode = 0x0115;
            this.reportsCreatorView.FormCode = 0x0116;

            this.securedComponents.Add(this.UserManagement.FormCode, this.UserManagement);
            this.securedComponents.Add(this.DeviceManager.FormCode, this.DeviceManager);
            this.securedComponents.Add(this.DeviceActivation.FormCode, this.DeviceActivation);
            this.securedComponents.Add(this.EmpresaForm.FormCode, this.EmpresaForm);
            this.securedComponents.Add(this.HorarioSemanalForm.FormCode, this.HorarioSemanalForm);
            this.securedComponents.Add(this.PlanificacaoHorarioForm.FormCode, this.PlanificacaoHorarioForm);
            this.securedComponents.Add(this.FeriadosForm.FormCode, this.FeriadosForm);
            this.securedComponents.Add(this.FeriasForm.FormCode, this.FeriasForm);
            this.securedComponents.Add(this.UserClockViewerForm.FormCode, this.UserClockViewerForm);
            this.securedComponents.Add(this.AttendanceCalcsForm.FormCode, this.AttendanceCalcsForm);
            this.securedComponents.Add(this.tableFuncionarioDeviceView.FormCode, this.tableFuncionarioDeviceView);
            this.securedComponents.Add(this.deviceDataUpdateView.FormCode, this.deviceDataUpdateView);
            this.securedComponents.Add(this.importExportView.FormCode, this.importExportView);
            this.securedComponents.Add(this.pedidoDispensaView.FormCode, this.pedidoDispensaView);
            this.securedComponents.Add(this.reportsCreatorView.FormCode, this.reportsCreatorView);
        }

        public void SettingSecurity() {
            List<RolePermission> permissions = new List<RolePermission>();

            SigeasDatabaseContext context = new SigeasDatabaseContext();
            ApplicationUser user = SystemManager.GetCurrentUser(context);

            foreach (Role role in user.Roles) {
                permissions.AddRange(role.RolePermissions.ToArray());
            }

            //Hack Code (For Developers)
            if (permissions.Where(t => t.FormCode == 0x0047).Count() > 0) {
                AllowAll();
                return;
            }

            BlockAll();

            foreach (RolePermission rolePermission in permissions.Distinct()) {
                int formCode = rolePermission.FormCode;
                int actionCode = rolePermission.ActionCode;

                AuthorizableComponent aComponent = null;

                securedComponents.TryGetValue(formCode, out aComponent);

                if (aComponent == null) continue;


                switch (actionCode) {
                    case 1: aComponent.AllowView = true; break;
                    case 2: aComponent.AllowUpdate = true; break;
                    case 3: aComponent.AllowDelete = true; break;
                    case 4: aComponent.AllowAdd = true; break;
                }
            }

            SecureMenuItemsAndButtons();
        }

        private void SecureMenuItemsAndButtons() {                        
                                    
            //this.UserManagement.FormCode = 0x0101;
            tsbtnEmployeeMangaer.Enabled = this.UserManagement.AllowView;
            menuItemUserManager.Enabled = this.UserManagement.AllowView;
            
            //this.DeviceManager.FormCode = 0x0102;
            tsbtnDeviceManager.Enabled = this.DeviceManager.AllowView;
            menuItemDeviceManager.Enabled = this.DeviceManager.AllowView;
            
            //this.DeviceActivation.FormCode = 0x0103;
            TSMnuItemDeviceActivation.Enabled = this.DeviceActivation.AllowView;
            
            //this.EmpresaForm.FormCode = 0x0104;
            TSMnuItemEmpresaForm.Enabled = this.EmpresaForm.AllowView;
            
            //this.FuncionarioForm.FormCode = 0x0105;
            TSMnuItemFuncionarioView.Enabled = this.FuncionarioForm.AllowView;
            
            //this.HorarioSemanalForm.FormCode = 0x0106;
            TSMnuItemHorarioSemanal.Enabled = this.HorarioSemanalForm.AllowView;
            
            //this.PlanificacaoHorarioForm.FormCode = 0x0107;
            TSMnuItemPlanificacaoHorario.Enabled = this.PlanificacaoHorarioForm.AllowView;
            
            //this.FeriadosForm.FormCode = 0x0108;
            TSMnuItemFeriadosForm.Enabled = this.FeriadosForm.AllowView;
            
            //this.FeriasForm.FormCode = 0x0109;
            TSMnuItemFeriasForm.Enabled = this.FeriasForm.AllowView;

            //this.UserClockViewerForm.FormCode = 0x0110;
            TSMnuItemUserClocksViewer.Enabled = this.UserClockViewerForm.AllowView;

            //this.AttendanceCalcsForm.FormCode = 0x0111;
            TSMnuItemAttCalcsViewer.Enabled = this.AttendanceCalcsForm.AllowView;

            //this.tableFuncionarioDeviceView.FormCode = 0x0112;
            associarFuncionáriosÁsPortasToolStripMenuItem.Enabled = this.tableFuncionarioDeviceView.AllowView;
            
            //this.deviceDataUpdateView.FormCode = 0x0113;
            atualizarFuncionariosNoBiometricoToolStripMenuItem.Enabled = this.deviceDataUpdateView.AllowView;
            
            //this.importExportView.FormCode = 0x0114;
            importarDadosToolStripMenuItem.Enabled = this.importExportView.AllowView;

            //this.pedidoDispensaView.FormCode = 0x0115;
            pedidoDeDispensaAusenciaToolStripMenuItem.Enabled = this.pedidoDispensaView.AllowView;
                        
            //this.reportsCreatorView.FormCode = 0x0116;
            relatoriosToolStripMenuItem.Enabled = this.reportsCreatorView.AllowView;


        }

        private void BlockAll() {
            foreach (AuthorizableComponent aComponent in securedComponents.Values) {
                aComponent.AllowView = false;
                aComponent.AllowUpdate = false;
                aComponent.AllowDelete = false;
                aComponent.AllowAdd = false;
            }
        }

        private void AllowAll() {
            foreach (AuthorizableComponent aComponent in securedComponents.Values) {
                aComponent.AllowView = true;
                aComponent.AllowUpdate = true;
                aComponent.AllowDelete = true;
                aComponent.AllowAdd = true;
            }
        }

        public void InitSystem() {
            //SystemDatabase.Init();            
            //FuncionarioForm.InitData();
        }
                
        private void FormMain_Load(object sender, EventArgs e) {                       
            UpdateMainLayoutComponents();
            //UpdateLayout();
            timerHoras.Start();         
        }                

        private void sairDoProgramaToolStripMenuItem_Click(object sender, EventArgs e){
            this.Close();
        }
                
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e){
            DialogResult answer = MessageBox.Show("Tem certeza que deseja sair?", "Sair do programa", MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes){
                e.Cancel = false;
                CloseAllForms();
                Environment.Exit(0);
            } else {
                e.Cancel = true;
            }            
        }

        private void CloseAllForms() {
            foreach (var comp in securedComponents.Values) {
                if (comp is Form) {
                    (comp as Form).Close();
                }
            }
        }

        public void UpdateUserSettings(ApplicationUser user) {
            tssUserName.Text = user.ToString();
        }


        private void barraDeToolStripMenuItem_Click(object sender, EventArgs e){
            //taskPaneMain.Visible = barraDeToolStripMenuItem.Checked;
        }
        
        private void logOffUserMenuItem_Click(object sender, EventArgs e) {
            LogOffUser();
        }               

        private void toolStripButton1_Click(object sender, EventArgs e) {
            DeviceManager.Visible = true;
        }               

        private void tsMenuList_Atualizar_Click(object sender, EventArgs e) {
            UpdateMainLayoutComponents();
        }

        private void activaçãoDeToolStripMenuItem_Click(object sender, EventArgs e) {
            DeviceActivation.ShowDialog();
        }

        private void timerHoras_Tick(object sender, EventArgs e) {
            SetTime();
        }               

        public void LogOffUser() {
            DialogResult answer = MessageBox.Show("Tem certeza que deseja terminar a sessão?", "Terminar sessão", MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes) {
                ExcecuteLogOff();
            }
        }

        public void LogOffUserWithoutAsk() {
            ExcecuteLogOff();
        }

        private void ExcecuteLogOff() {
            
            this.Dispose();
            LoginView.DestroyMainForm();                                            
            LoginView.ClearForms();
            LoginView.Visible = true;                                    
        }

        public void UpdateMainDevices() {
           
        }

        public void UpdateMainLayoutComponents() {
            //Collapse expandos
            expAttendance.Collapsed = true;
            expDispensas.Collapsed = true;
            expFuncDevs.Collapsed = true;
            expImportExport.Collapsed = true;
            expTools.Collapsed = true;
            
            UpdateMainDevices();                        
        }

        private void SetTime() {
            DateTime now = DateTime.Now;
            tssTime.Text = now.ToString("HH:mm:ss");
        }

        public void SetApplicationUserName(string name) {
            tssUserName.Text = name;
        }

        public void SetApplicationUserLevelAccess(int level) {
            //Teremos os bloqueios para cada tipo de usuário
            // 7 - Full Acess/Hidden Stuff - Programmers
            // X - 
        }

        private void horasToolStripMenuItem_Click(object sender, EventArgs e) {
            horasToolStripMenuItem.Checked = !horasToolStripMenuItem.Checked;
            timerHoras.Enabled = horasToolStripMenuItem.Checked;
            tssTime.Text = horasToolStripMenuItem.Checked ? DateTime.Now.ToString("HH:mm:ss") : "";
        }

        private void expando2_Resize(object sender, EventArgs e) {
            //OnExpandoResize(expando2, expando3);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox.ShowDialog();
        }

        private void gestorDeUtilizadoresToolStripMenuItem_Click(object sender, EventArgs e) {
            UserManagement.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) {
            FuncionarioForm.Visible = true;
        }

        private void dadosDaEmpresToolStripMenuItem_Click(object sender, EventArgs e) {
            EmpresaForm.ShowDialog();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e) {            
            FuncionarioForm.Visible = true;
        }                

        private void definiçãoDeHoráriosToolStripMenuItem_Click(object sender, EventArgs e) {
            HorarioSemanalForm.Show(this);
        }

        private void atribuirHorárioÁFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e) {
            PlanificacaoHorarioForm.Show(this);
        }

        private void definirFeriadosToolStripMenuItem_Click(object sender, EventArgs e) {
            FeriadosForm.Show(this);
        }

        private void defToolStripMenuItem_Click(object sender, EventArgs e) {
            FeriasForm.Show(this);
        }

        private void registosBiométricosToolStripMenuItem_Click(object sender, EventArgs e) {
            UserClockViewerForm.Show(this);
        }

        private void cálculosDeAssiduidadeToolStripMenuItem_Click(object sender, EventArgs e) {
            AttendanceCalcsForm.Show(this);
        }

        private void definirFeriadosToolStripMenuItem_Click_1(object sender, EventArgs e) {
            FeriadosForm.Visible = true;
        }

        private void MainView_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                this.BringToFront();
                this.SettingSecurity();
            }
        }

        private void Initialize() {
            TSLabelEmpresa.Text = "Não registada!";


            if (SystemManager.CurrentEmpresaId == -1) {
                SelectEmpresaView selectEmpresa = new SelectEmpresaView();
                selectEmpresa.ShowDialog();

                if (selectEmpresa.LOG_OFF_USER == true) {
                    LogOffUserWithoutAsk();
                    return;
                }
                
                SigeasDatabaseContext context = new SigeasDatabaseContext();
                Empresa empresa = SystemManager.GetCurrentEmpresa(context);
                TSLabelEmpresa.Text = empresa.Nome;

                empresa = null;
                context.Dispose();
            }


        }

        private void MainView_Shown(object sender, EventArgs e) {
            Console.WriteLine("Shown");
            Initialize();
        }

        private void gestorDeDispositivosToolStripMenuItem_Click(object sender, EventArgs e) {
            DeviceManager.Visible = true;
        }

        private void associarFuncionáriosÁsPortasToolStripMenuItem_Click(object sender, EventArgs e) {
            tableFuncionarioDeviceView.Visible = true;
        }

        private void atualizarFuncionariosNoBiometricoToolStripMenuItem_Click(object sender, EventArgs e) {
            deviceDataUpdateView.Visible = true;
        }

        private void importarDadosToolStripMenuItem_Click(object sender, EventArgs e) {
            importHrData.Visible = true;
        }

        private void importarExportarDadosBiometricosToolStripMenuItem_Click(object sender, EventArgs e) {
            importExportView.Visible = true;
        }

        private void TSMnuItemFeriasForm_Click(object sender, EventArgs e) {
            this.FeriasForm.Visible = true;
        }

        private void TSMnuItemFeriadosForm_Click(object sender, EventArgs e) {
            this.FeriadosForm.Visible = true;
        }

        private void pedidoDeDispensaAusenciaToolStripMenuItem_Click(object sender, EventArgs e) {
            this.pedidoDispensaView.Visible = true;
        }

        private void relátoriosDeAsseduidadeToolStripMenuItem_Click(object sender, EventArgs e) {
            this.reportsCreatorView.Visible = true;
        }

        private void tsbtnPlanSchedules_Click(object sender, EventArgs e) {
            PlanificacaoHorarioForm.Show(this);
        }

        private void tsbtnReports_Click(object sender, EventArgs e) {
            this.reportsCreatorView.Visible = true;
        }

        private void leftTaskPane_MouseMove(object sender, MouseEventArgs e) {
            foreach (Expando exp in leftTaskPane.Expandos)
            {
                //exp.Refresh();
            }
            
        }



     
    }
}
