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
        public FrmDeviceActivaction DeviceActivation;

        public DeviceManager DeviceManager;  
        public FrmEmpresa EmpresaForm;
        public FrmFuncionario FuncionarioForm;
        public FrmHorarioSemanal HorarioSemanalForm;        
        public FrmPlanificacaoHorario PlanificacaoHorarioForm;
        public FrmFeriados FeriadosForm;
        public FrmFerias FeriasForm;
        public UserClocksViewer UserClockViewerForm;
        public AttendanceCalcsView AttendanceCalcsForm;
        public UserManager UserManagement { get; set; }
        public FuncionarioDevicesView FuncionarioDevicesView { get; set; }
        public DeviceDataUpdateView DeviceDataUpdateView { get; set; }
        public ImportHrData ImportHrData { get; set; }
        public ImportExportView ImportExportView { get; set; }
        public PedidoDispensaView PedidoDispensaView { get; set; }
        public ReportsCreatorView ReportsCreatorView { get; set; }

        public static ToolStripLabel TssGeralSystemStatus;

        private Dictionary<int, AuthorizableComponent> _securedComponents;

        /*
         * My variables Ends
         */
        public MainView()      {
            InitializeComponent();

            //MainProgram = this;

            TssGeralSystemStatus = tssSystemStatus;            
                        
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
            FuncionarioDevicesView = new FuncionarioDevicesView();
            DeviceDataUpdateView = new DeviceDataUpdateView();
            ImportHrData = new ImportHrData();
            ImportExportView = new ImportExportView();
            PedidoDispensaView = new PedidoDispensaView();
            ReportsCreatorView = new ReportsCreatorView();

            DeviceManager.MdiParent = this;
            FuncionarioForm.MdiParent = this;
            UserManagement.MdiParent = this;
            AttendanceCalcsForm.MdiParent = this;
            UserClockViewerForm.MdiParent = this;
            FuncionarioDevicesView.MdiParent = this;
            PlanificacaoHorarioForm.MdiParent = this;
            ReportsCreatorView.MdiParent = this;

            //AboutBox.MdiParent = this;
            InitSecurity();
            InitFormsLayout();
        }

        private void InitFormsLayout() {
            
        }

        private void InitSecurity() {
            this._securedComponents = new Dictionary<int, AuthorizableComponent>();

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
            this.FuncionarioDevicesView.FormCode = 0x0112;
            this.DeviceDataUpdateView.FormCode       = 0x0113;
            this.ImportHrData.FormCode = 0x0114;
            this.ImportExportView.FormCode = 0x0115;
            this.PedidoDispensaView.FormCode = 0x0116;
            this.ReportsCreatorView.FormCode = 0x0117;

            this._securedComponents.Add(this.UserManagement.FormCode, this.UserManagement);
            this._securedComponents.Add(this.DeviceManager.FormCode, this.DeviceManager);
            this._securedComponents.Add(this.DeviceActivation.FormCode, this.DeviceActivation);
            this._securedComponents.Add(this.EmpresaForm.FormCode, this.EmpresaForm);
            this._securedComponents.Add(this.HorarioSemanalForm.FormCode, this.HorarioSemanalForm);
            this._securedComponents.Add(this.PlanificacaoHorarioForm.FormCode, this.PlanificacaoHorarioForm);
            this._securedComponents.Add(this.FeriadosForm.FormCode, this.FeriadosForm);
            this._securedComponents.Add(this.FeriasForm.FormCode, this.FeriasForm);
            this._securedComponents.Add(this.UserClockViewerForm.FormCode, this.UserClockViewerForm);
            this._securedComponents.Add(this.AttendanceCalcsForm.FormCode, this.AttendanceCalcsForm);
            this._securedComponents.Add(this.FuncionarioDevicesView.FormCode, this.FuncionarioDevicesView);
            this._securedComponents.Add(this.DeviceDataUpdateView.FormCode, this.DeviceDataUpdateView);
            this._securedComponents.Add(this.ImportExportView.FormCode, this.ImportExportView);
            this._securedComponents.Add(this.PedidoDispensaView.FormCode, this.PedidoDispensaView);
            this._securedComponents.Add(this.ReportsCreatorView.FormCode, this.ReportsCreatorView);
        }

        public void SettingSecurity() {
            List<RolePermission> permissions = new List<RolePermission>();

            SigeasDatabaseContext context = new SigeasDatabaseContext();
            ApplicationUser user = SystemManager.GetCurrentUser(context);

            foreach (Role role in user.Roles) {
                permissions.AddRange(role.RolePermissions.ToArray());
            }

            //Hack Code (For Developers)
            if (permissions.Count(t => t.FormCode == 0x0047) > 0) {
                AllowAll();
                return;
            }

            BlockAll();

            foreach (RolePermission rolePermission in permissions.Distinct()) {
                int formCode = rolePermission.FormCode;
                int actionCode = rolePermission.ActionCode;

                AuthorizableComponent aComponent = null;

                _securedComponents.TryGetValue(formCode, out aComponent);

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
            mnToolsUserManager.Enabled = this.UserManagement.AllowView;
            tskUserManager.Enabled = this.UserManagement.AllowView;
            
            //this.DeviceManager.FormCode = 0x0102;
            tsbtnDeviceManager.Enabled = this.DeviceManager.AllowView;
            mnToolsDevManager.Enabled = this.DeviceManager.AllowView;
            tskDevManager.Enabled = this.DeviceManager.AllowView;
            
            //this.DeviceActivation.FormCode = 0x0103;
            mnToolsDevActivation.Enabled = this.DeviceActivation.AllowView;
            tskDevActivation.Enabled = this.DeviceManager.AllowView;
            
            //this.EmpresaForm.FormCode = 0x0104;
            mnComSettings.Enabled = this.EmpresaForm.AllowView;
            
            //this.FuncionarioForm.FormCode = 0x0105;
            mnEmpManager.Enabled = this.FuncionarioForm.AllowView;
            tsbtnEmployeeMangaer.Enabled = this.FuncionarioForm.AllowView;
            
            //this.HorarioSemanalForm.FormCode = 0x0106;
            mnAttSchHorSemanal.Enabled = this.HorarioSemanalForm.AllowView;
            
            //this.PlanificacaoHorarioForm.FormCode = 0x0107;
            mnAttSchedulePlan.Enabled = this.PlanificacaoHorarioForm.AllowView;
            tsbtnPlanSchedules.Enabled = this.PlanificacaoHorarioForm.AllowView;
            
            //this.FeriadosForm.FormCode = 0x0108;
            mnComFeriados.Enabled = this.FeriadosForm.AllowView;
            tskFeriados.Enabled = this.FeriadosForm.AllowView;
            
            //this.FeriasForm.FormCode = 0x0109;
            mnComFerias.Enabled = this.FeriasForm.AllowView;
            tskPlanFerias.Enabled = this.FeriasForm.AllowView;

            //this.UserClockViewerForm.FormCode = 0x0110;
            mnAttUserClocks.Enabled = this.UserClockViewerForm.AllowView;
            tskViewUserClocks.Enabled = this.UserClockViewerForm.AllowView;

            //this.AttendanceCalcsForm.FormCode = 0x0111;
            mnAttCalcsViewer.Enabled = this.AttendanceCalcsForm.AllowView;
            tskViewAttCalcs.Enabled = this.AttendanceCalcsForm.AllowView;

            //this.FuncionarioDevicesView.FormCode = 0x0112;
            mnEmpFuncDoors.Enabled = this.FuncionarioDevicesView.AllowView;
            tskFuncsDoors.Enabled = this.FuncionarioDevicesView.AllowView;
            
            //this.deviceDataUpdateView.FormCode = 0x0113;
            mnEmpSaveDevUsers.Enabled = this.DeviceDataUpdateView.AllowView;
            tskFuncsDevices.Enabled = this.DeviceDataUpdateView.AllowView;

            //this.ImportHrData.FormCode = 0x0114;
            mnToolsImportHR.Enabled = this.ImportHrData.AllowView;
            tskImportDataXls.Enabled = this.ImportHrData.AllowView;

            //this.importExportView.FormCode = 0x0115;
            mnToolsImportBioData.Enabled = this.ImportExportView.AllowView;
            tskCollectBioData.Enabled = this.ImportExportView.AllowView;

            //this.pedidoDispensaView.FormCode = 0x0116;
            mnEmpDispensas.Enabled = this.PedidoDispensaView.AllowView;
            tskDispensas.Enabled = this.PedidoDispensaView.AllowView;
                        
            //this.reportsCreatorView.FormCode = 0x0117;
            mmiSchedules.Enabled = this.ReportsCreatorView.AllowView;
            tskReports.Enabled = this.ReportsCreatorView.AllowView;

        }

        private void BlockAll() {
            foreach (AuthorizableComponent aComponent in _securedComponents.Values) {
                aComponent.AllowView = false;
                aComponent.AllowUpdate = false;
                aComponent.AllowDelete = false;
                aComponent.AllowAdd = false;
            }
        }

        private void AllowAll() {
            foreach (AuthorizableComponent aComponent in _securedComponents.Values) {
                aComponent.AllowView = true;
                aComponent.AllowUpdate = true;
                aComponent.AllowDelete = true;
                aComponent.AllowAdd = true;
            }
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
            foreach (var comp in _securedComponents.Values) {
                if (comp is Form) {
                    (comp as Form).Close();
                }
            }
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
        
        public void UpdateMainLayoutComponents() {
            //Collapse expandos
            expAttendance.Collapsed = true;
            expDispensas.Collapsed = true;
            expFuncDevs.Collapsed = true;
            expImportExport.Collapsed = true;
            expTools.Collapsed = true;           
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
            mnViewTime.Checked = !mnViewTime.Checked;
            timerHoras.Enabled = mnViewTime.Checked;
            tssTime.Text = mnViewTime.Checked ? DateTime.Now.ToString("HH:mm:ss") : "";
        }

        public void UpdateUserSettings(ApplicationUser user) {
            tssUserName.Text = user.ToString();
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
            Initialize();
        }

        private void tsbtnDeviceManager_Click(object sender, EventArgs e) {
            SetFormVisible(DeviceManager);
        }

        private void tsbtnEmployeeMangaer_Click(object sender, EventArgs e) {
            SetFormVisible(FuncionarioForm);
        }

        private void tsbtnPlanSchedules_Click(object sender, EventArgs e) {
            SetFormVisible(PlanificacaoHorarioForm);
        }

        private void tsbtnReports_Click(object sender, EventArgs e) {
            SetFormVisible(ReportsCreatorView);
        }

        private void tskFuncsDoors_Click(object sender, EventArgs e) {
            SetFormVisible(FuncionarioDevicesView);
        }

        private void tskFuncsDevices_Click(object sender, EventArgs e) {
            DeviceDataUpdateView.ShowDialog();
        }

        private void tskViewUserClocks_Click(object sender, EventArgs e) {
            SetFormVisible(UserClockViewerForm);
        }

        private void tskViewAttCalcs_Click(object sender, EventArgs e) {
            SetFormVisible(AttendanceCalcsForm);
        }

        private void tskReports_Click(object sender, EventArgs e) {
            SetFormVisible(ReportsCreatorView);
        }

        private void tskFeriados_Click(object sender, EventArgs e) {
            FeriadosForm.ShowDialog();
        }

        private void tskDispensas_Click(object sender, EventArgs e) {
            PedidoDispensaView.ShowDialog();
        }

        private void tskPlanFerias_Click(object sender, EventArgs e) {
            FeriasForm.ShowDialog();
        }

        private void tskUserManager_Click(object sender, EventArgs e) {
            SetFormVisible(UserManagement);
        }

        private void tskDevManager_Click(object sender, EventArgs e) {
            SetFormVisible(DeviceManager);
        }

        private void tskDevActivation_Click(object sender, EventArgs e) {
            DeviceActivation.ShowDialog();
        }

        private void tskImportDataXls_Click(object sender, EventArgs e) {
            ImportHrData.ShowDialog();
        }

        private void tskCollectBioData_Click(object sender, EventArgs e) {
            ImportExportView.ShowDialog();
        }

        private void mnEmpManager_Click(object sender, EventArgs e) {
            SetFormVisible(FuncionarioForm);
        }

        private void mnEmpDispensas_Click(object sender, EventArgs e) {
            PedidoDispensaView.ShowDialog();
        }

        private void mnEmpFuncDoors_Click(object sender, EventArgs e) {
            SetFormVisible(FuncionarioDevicesView);
        }

        private void mnEmpSaveDevUsers_Click(object sender, EventArgs e) {
            DeviceDataUpdateView.ShowDialog();
        }

        private void mnComSettings_Click(object sender, EventArgs e) {
            EmpresaForm.ShowDialog();
        }

        private void mnComFeriados_Click(object sender, EventArgs e) {
            FeriadosForm.ShowDialog();
        }

        private void mnComFerias_Click(object sender, EventArgs e) {
            PedidoDispensaView.ShowDialog();
        }

        private void mnAttSchHorSemanal_Click(object sender, EventArgs e) {
            HorarioSemanalForm.ShowDialog();
        }

        private void mnAttSchedulePlan_Click(object sender, EventArgs e) {
            SetFormVisible(PlanificacaoHorarioForm);
        }

        private void mnAttUserClocks_Click(object sender, EventArgs e) {
            SetFormVisible(UserClockViewerForm);
        }

        private void mnAttCalcsViewer_Click(object sender, EventArgs e) {
            SetFormVisible(AttendanceCalcsForm);
        }

        private void mnReports_Click(object sender, EventArgs e) {
            SetFormVisible(ReportsCreatorView);
        }

        private void mnToolsDevManager_Click(object sender, EventArgs e) {
            SetFormVisible(DeviceManager);
        }

        private void mnToolsUserManager_Click(object sender, EventArgs e) {
            SetFormVisible(UserManagement);
        }

        private void mnToolsDevActivation_Click(object sender, EventArgs e) {
            DeviceActivation.ShowDialog();
        }

        private void mnToolsImportBioData_Click(object sender, EventArgs e) {
            ImportExportView.ShowDialog();
        }

        private void mnToolsImportHR_Click(object sender, EventArgs e) {
            ImportHrData.ShowDialog();
        }

        private void mnHelpHowTo_Click(object sender, EventArgs e) {
            //nothing
        }

        private void mnHelpAbout_Click(object sender, EventArgs e)
        {
            AboutBox.ShowDialog();
        }

        private void mnEmpDispensas_Click_1(object sender, EventArgs e) {
            PedidoDispensaView.ShowDialog();
        }

        private void mnReports_Click_1(object sender, EventArgs e) {
            SetFormVisible(ReportsCreatorView);
        }

        private void mnAttSchHorSemanal_Click_1(object sender, EventArgs e) {
            HorarioSemanalForm.ShowDialog();
        }

        private void mnAttSchedulePlan_Click_1(object sender, EventArgs e) {
            SetFormVisible(PlanificacaoHorarioForm);
        }

        private void mnViewToolBar_Click(object sender, EventArgs e) {
            leftTaskPane.Visible = mnViewToolBar.Checked;
        }

        private void SetFormVisible(Form form) {
            if (form.Visible){
                form.Activate();
            } else {
                form.Visible = true;
            }
        }
    }
}
