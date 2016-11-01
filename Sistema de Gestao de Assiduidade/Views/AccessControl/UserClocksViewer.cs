using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.DeviceSystem;
using mz.betainteractive.utilities.module.BackgroundFeatures;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.utilities.module.Components;
using mz.betainteractive.sigeas.settings;
using mz.betainteractive.utilities.module.Collections;
using mz.betainteractive.utilities.module.General;

namespace mz.betainteractive.sigeas.Views.AccessControl {
    public partial class UserClocksViewer : Form, AuthorizableComponent
    {

        private SigeasDatabaseContext context;

        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }


        public UserClocksViewer() {
            InitializeComponent();
        }

        private void DisposeContext() {
            if (context != null) {
                context.Dispose();
                context = null;
            }
            DisconnectDevice();
        }

        private void LoadContext() {
            if (context == null) {
                context = new SigeasDatabaseContext();
            }
        }

        private void UserClocksViewer_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
            DisposeContext();
        }

        private void UserClocksViewer_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                LoadContext();
                Initialize();
            }
        }

        private void Initialize() {

            DtpToDate.Value = DateTime.Now;
            DtpFromDate.Value = DtpToDate.Value.AddMonths(-1);

            LoadDevicesToComboBox();
            LoadDepartamentosToComboBox();
            LoadCategoriasToComboBox();
            LoadMonthWorksToComboBox();
            LimparLista();
        }
                
        private void LoadDevicesToComboBox() {
            //No futuro não sera assim
            var devices = context.Device.AsNoTracking().Where(t => t.Door != null).ToList();

            CBoxDevices.Items.Clear();

            foreach (Device dev in devices) {
                CBoxDevices.Items.Add(dev);
            }
        }

        private void LoadDepartamentosToComboBox() {
            Empresa empresa = SystemManager.GetCurrentEmpresa(context);

            var depts = context.Departamento.AsNoTracking().Where(t => t.Empresa.Id == empresa.Id).ToList();

            CBoxFuncionarios.Items.Clear();
            CBoxDepartamentos.Items.Clear();

            foreach (var dept in depts) {
                CBoxDepartamentos.Items.Add(dept);
            }

            CBoxDepartamentos.Items.Insert(0, "Todos");
        }

        private void LoadCategoriasToComboBox() {
            Empresa empresa = SystemManager.GetCurrentEmpresa(context);

            var categs = context.Categoria.AsNoTracking().Where(t => t.Empresa.Id == empresa.Id).ToList();

            CBoxFuncionarios.Items.Clear();
            CBoxCategorias.Items.Clear();

            foreach (var catg in categs) {
                CBoxCategorias.Items.Add(catg);
            }

            CBoxCategorias.Items.Insert(0, "Todos");
        }              

        private void LimparLista() {
            LViewUserClocks.Items.Clear();
        }       

        private void CBoxDepartamentos_SelectedIndexChanged(object sender, EventArgs e) {
            if (CBoxDepartamentos.SelectedIndex != -1) {
                OnSelectDepartamentoOrCategoria();
            }
        }

        private void CBoxCategorias_SelectedIndexChanged(object sender, EventArgs e) {
            OnSelectDepartamentoOrCategoria();
        }

        private void OnSelectDepartamentoOrCategoria() {
            Departamento departamento = null;
            Categoria categoria = null;


            if (CBoxDepartamentos.SelectedItem is Departamento) {
                departamento = CBoxDepartamentos.SelectedItem as Departamento;
            }
            if (CBoxCategorias.SelectedItem is Categoria) {
                categoria = CBoxCategorias.SelectedItem as Categoria;
            }

            CBoxFuncionarios.Items.Clear();
            CBoxFuncionarios.ResetText();

            LoadFuncionarios(departamento, categoria);

        }

        private void LoadFuncionarios(Departamento departamento, Categoria categoria) {
            CBoxFuncionarios.Items.Clear();

            List<Funcionario> funcionarios = new List<Funcionario>();

            if (context.Funcionario.Count() == 0) return;

            if (categoria == null && departamento == null) {
                funcionarios = context.Funcionario.ToList();
            } else if (categoria == null) {
                funcionarios.AddRange(context.Funcionario.Where(f=>f.Departamento.Id==departamento.Id).ToList());
            } else if (departamento == null) {
                funcionarios.AddRange(context.Funcionario.Where(f=>f.Categoria.Id==categoria.Id).ToList());
            }

            foreach (Funcionario funcionario in funcionarios) {
                //if (funcionario.CompleteRegistered == true) {
                    CBoxFuncionarios.Items.Add(funcionario);
                //}
            }

            CBoxFuncionarios.Items.Insert(0, "Todos");
        }
        
        private void BtnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e) {
            SearchUserClocks();
        }

        private List<UserClock> getUserClocksByFilters() {
            DateTime fromDate = DtpFromDate.Value.Date;
            DateTime toDate = DtpToDate.Value.Date;
            Departamento selectedDepartamento = null;
            Categoria selectedCategoria = null;
            Funcionario selectedfuncionario = null;
            List<UserClock> clocks = new List<UserClock>();

            toDate = toDate.AddHours(23);
            toDate = toDate.AddMinutes(59);
            toDate = toDate.AddSeconds(59);

            if (CBoxDepartamentos.SelectedItem is Departamento) {
                selectedDepartamento = CBoxDepartamentos.SelectedItem as Departamento;
            }
            if (CBoxCategorias.SelectedItem is Categoria) {
                selectedCategoria = CBoxCategorias.SelectedItem as Categoria;
            }
            if (CBoxFuncionarios.SelectedItem is Funcionario) {
                selectedfuncionario = CBoxFuncionarios.SelectedItem as Funcionario;
            }

            //Search On One funcionario
            if (selectedfuncionario != null) {
                clocks = context.UserClock.Where(uc => uc.DateAndTime >= fromDate && uc.DateAndTime <= toDate && uc.Funcionario.Id == selectedfuncionario.Id).ToList();
            }

            //Search On One Departamento
            if (selectedfuncionario == null && selectedDepartamento != null && selectedCategoria == null) {
                clocks = context.UserClock.Where(uc => uc.DateAndTime >= fromDate && uc.DateAndTime <= toDate && uc.Funcionario.Departamento.Id == selectedDepartamento.Id).ToList();
            }
            //Search On One Categoria
            if (selectedfuncionario == null && selectedDepartamento == null && selectedCategoria != null) {
                clocks = context.UserClock.Where(uc => uc.DateAndTime >= fromDate && uc.DateAndTime <= toDate && uc.Funcionario.Categoria.Id == selectedCategoria.Id).ToList();
            }

            //Search On All enterprise
            if (selectedDepartamento == null && selectedfuncionario == null && selectedCategoria == null) {
                clocks = context.UserClock.Where(uc => uc.DateAndTime >= fromDate && uc.DateAndTime <= toDate).ToList();
            }

            return clocks;
        }

        private void SearchUserClocks() {

            var clocks = getUserClocksByFilters();

            ShowUserClocks(clocks);
        }

        private void ShowUserClocks(List<UserClock> clocks) {

            LViewUserClocks.Items.Clear();
            int index = 0;

            foreach (UserClock userClock in clocks) {
                index++;
                ListViewGenericItem<UserClock> item = new ListViewGenericItem<UserClock>(userClock);

                Funcionario funcionario = userClock.Funcionario;
                Device device = userClock.Device;
                Door door = device.Door;

                item.Text = index.ToString();
                item.SubItems.Add(funcionario.Code);
                item.SubItems.Add(funcionario.ToString());
                item.SubItems.Add(device.ToString());
                item.SubItems.Add(userClock.VerifyMode.ToString());
                item.SubItems.Add(userClock.DateAndTime.ToString(Constants.LONG_DATETIME_FORMAT));
                item.SubItems.Add(userClock.InOutMode.ToString());
                item.SubItems.Add(userClock.CorrectState);
                item.SubItems.Add(userClock.Result);

                if (userClock.Result == "Invalido") {
                    item.BackColor = Color.Lime;
                }

                LViewUserClocks.Items.Add(item);
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e) {
            if (CBoxDevices.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o dispositivo por favor");
                return;
            }

            if (BtnConnect.Text == "Desconectar Dispositivo") {
                DisconnectDevice();
                return;
            }

            if (BtnConnect.Text == "Conectar Dispositivo") {
                ConnectDevice();
                return;
            }
        }

        private void ConnectDevice() {
            Device device = (Device)CBoxDevices.SelectedItem;

            DeviceConnector connector = DeviceConnector.GetDeviceConnector(device);

            connector.StartConnection();

            if (device.Connected) {
                BtnConnect.Text = "Desconectar Dispositivo";
                CBoxDevices.Enabled = false;
                BtnDownloadUserClocks.Enabled = AllowAdd;//true;
                LabelDeviceConnected.Text = "Conectado";
            } else {
                BtnConnect.Text = "Conectar Dispositivo";
                CBoxDevices.Enabled = true;
                BtnDownloadUserClocks.Enabled = false;
                LabelDeviceConnected.Text = "Desconectado";
            }
        }

        private void DisconnectDevice() {
            if ((CBoxDevices.SelectedItem as Device) == null) return;
            
            Device device = (Device)CBoxDevices.SelectedItem;
            DeviceIO deviceIO = new DeviceIO(device);

            

            if (device.Connected) {
                deviceIO.StartIdentify();
                device.Disconnect();                
            }

            if (device.Connected) {
                BtnConnect.Text = "Desconectar Dispositivo";
                CBoxDevices.Enabled = false;
                BtnDownloadUserClocks.Enabled = AllowAdd;//true;
                LabelDeviceConnected.Text = "Conectado";
            } else {
                BtnConnect.Text = "Conectar Dispositivo";
                CBoxDevices.Enabled = true;
                BtnDownloadUserClocks.Enabled = false;
                LabelDeviceConnected.Text = "Desconectado";
            }
        }

        private void BtnDownloadUserClocks_Click(object sender, EventArgs e) {
            DownloadUserClocks();
        }

        /*
         * Download and calculate data
         * 1 - Get the new user-clocks from device
         * 2 - Get the downloaded user-clock list
         * 3 - Correct the downloaded user-clock list
         * 4 - Calculate History & descounts of the corrected downloaded user-clock list
         */
        private void DownloadUserClocks() {
            Device device = (Device)CBoxDevices.SelectedItem;
            DeviceIO io = new DeviceIO(device);

            var deviceUsers = context.DeviceUser.Count();

            if (deviceUsers == 0) {
                MessageBox.Show(this, "Nao existem funcionários registados nos dispositivos. Associe primeiro funcionários à um determinado biometrico", "Não é possivel descarregar", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                return;
            }

            OnExecuteDialog background = new OnExecuteDialog("Descarregamento....", "Descarregando registos de picagens do biométrico...");
            bool result = false;

            List<UserClock> clocks = null;
            
            background.OnExecute += delegate() {                
                AccessControlCalculations calc = new AccessControlCalculations(context);
                DeviceDataConvertions convertions = new DeviceDataConvertions();

                try {

                    //Pass 1 & 2
                    List<RawUserClock> rawClocks = null;
                    //Pass 1
                    io.DownloadAttendanceData(out rawClocks);
                    //Pass 2
                    result = convertions.ConvertAttendanceDataToDatabase(context, rawClocks, out clocks);
                    //Pass 3
                    calc.CorrectAllUserClock(clocks);

                    context.SaveChanges();

                    result = true;
                } catch (Exception ex) {
                    LogErrors.AddErrorLog(ex, "Error on UserClocksViewer - Dwnld Ucs");
                }
            };

            background.OnPostExecute += delegate() {
                if (result == true) {                    
                    MessageBox.Show(this, "Os registos de picagens foram registados com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DeleteAllUserClocksOnDevice(io);
                } else {
                    MessageBox.Show(this, "Não foi possivel gravar os registos de picagens", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            background.StartExecute();
        }

        /*
         * Search and calculate data
         * 1 - Get the user-clocks from database         
         * 2 - Correct the downloaded user-clock list
         * 3 - Calculate History & descounts of the corrected downloaded user-clock list
         */
        private void SearchAndCorrectUserClocks() {
           
            var deviceUsers = context.DeviceUser.Count();

            if (deviceUsers == 0) {
                MessageBox.Show(this, "Nao existem funcionários registados nos dispositivos. Associe primeiro funcionários à um determinado biometrico", "Não é possivel descarregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OnExecuteDialog background = new OnExecuteDialog("Descarregamento....", "Descarregando registos de picagens do biométrico...");
            bool result = false;

            List<UserClock> clocks = getUserClocksByFilters();

            background.OnExecute += delegate() {

                try{
                    AccessControlCalculations calc = new AccessControlCalculations(context);
                    DeviceDataConvertions convertions = new DeviceDataConvertions();
                               
                
                    //Pass 2 - confirm this code if we gonna use it
                    calc.ClearResults(clocks);

                    //Pass 3
                    calc.CorrectAllUserClock(clocks);

                    context.SaveChanges();

                    result = true;

                } catch (Exception ex) {
                    LogErrors.AddErrorLog(ex, "Error on UserClocksViewer - Srch & Crrt Ucs");
                }

            };

            background.OnPostExecute += delegate() {
                if (result == true) {
                    ShowUserClocks(clocks);
                    MessageBox.Show(this, "Os registos de picagens foram registados com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                } else {
                    MessageBox.Show(this, "Não foi possivel gravar os registos de picagens", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            background.StartExecute();
        }

        private void DeleteAllUserClocksOnDevice(DeviceIO io) {
            DialogResult result = MessageBox.Show(this, "Deseja apagar os registos de picagens que estão no biométrico?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.No) {
                return;
            }

            OnExecuteDialog background = new OnExecuteDialog("Apagar registos...", "Apagando registos de picagens do biométrico...");
            bool erased = false;
            
            background.OnExecute += delegate() {
                erased = io.DeleteAllAttendaceData();
            };

            background.OnPostExecute += delegate() {
                if (erased == true) {
                    MessageBox.Show(this, "Os registos de picagens foram apagados com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                } else {
                    MessageBox.Show(this, "Não foi possivel apagar os registos de picagens", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            background.StartExecute();
        }

        private void CBoxDevices_SelectedIndexChanged(object sender, EventArgs e) {
            if (CBoxDevices.SelectedIndex == -1) {
                BtnConnect.Enabled = false;
            } else {
                BtnConnect.Enabled = true;
            }
        }

        private void BtnInsertClock_Click(object sender, EventArgs e) {
            InsertUserClock();
        }

        private void InsertUserClock() {
            if (CBoxFuncionarios.SelectedIndex == -1 || !(CBoxFuncionarios.SelectedItem is Funcionario)) {
                MessageBox.Show(this, "Selecione o funcionário primeiro");
                CBoxFuncionarios.Focus();
                return;
            }

            Funcionario funcionario = CBoxFuncionarios.SelectedItem as Funcionario;

            EditUserClockView editClockView = new EditUserClockView(context);
            editClockView.New(funcionario);
            editClockView.ShowDialog();
        }

        private void LViewUserClocks_MouseDoubleClick(object sender, MouseEventArgs e) {
            
            if (e.Button == System.Windows.Forms.MouseButtons.Left && LViewUserClocks.SelectedItems.Count == 1) {                
                ListViewGenericItem<UserClock> item = LViewUserClocks.SelectedItems[0] as ListViewGenericItem<UserClock>;
                OnSelectedUserClock(item);                
            }
        }

        private void OnSelectedUserClock(ListViewGenericItem<UserClock> item) {
            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja alterar os dados do registo de entrada/saida selecionado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            EditUserClockView editClockView = new EditUserClockView(context);
            editClockView.Edit(item.Value);
            editClockView.ShowDialog();
        }

        private void BtnSearchAndCorrect_Click(object sender, EventArgs e) {
            SearchAndCorrectUserClocks();
        }

        private void CBoxMonthWorks_SelectedIndexChanged(object sender, EventArgs e) {
            OnMonthWorkSelected();
        }

        private void LoadMonthWorksToComboBox() {
            var months = context.MonthWork.Where(t => t.Enabled == true).ToList();

            CBoxMonthWorks.Items.Clear();

            foreach (var month in months) {
                CBoxMonthWorks.Items.Add(month);
            }
        }

        private void OnMonthWorkSelected() {
            MonthWork monthWork = CBoxMonthWorks.SelectedItem as MonthWork;

            if (monthWork == null) return;

            DtpFromDate.Value = monthWork.First;
            DtpToDate.Value = monthWork.Last;
        }

               
    }
}
