using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.DeviceSystem;
using mz.betainteractive.sigeas.BackgroundFeatures;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Utilities;

namespace mz.betainteractive.sigeas.Views.FuncionarioDevices {
    public partial class DeviceDataUpdateView : Form, mz.betainteractive.sigeas.Utilities.Components.AuthorizableComponent {
        private SortedSet<int> avaiableIds;
        private SigeasDatabaseContext context;

        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }


        public DeviceDataUpdateView() {
            InitializeComponent();
            avaiableIds = new SortedSet<int>();                        
        }

        private void DisposeContext() {
            if (context != null) {
                context.Dispose();
                context = null;         
            }
        }

        private void LoadContext() {
            if (context == null) {
                context = new SigeasDatabaseContext();                
            }
        }

        private void Initialize() {            
            avaiableIds.Clear();            
            LoadDevicesToComboBox();
        }

        private void LoadDevicesToComboBox() {
            //No futuro não sera assim
            var devices = context.Device.Where(t => t.Door != null).ToList();

            CBoxDevices.Items.Clear();

            foreach (Device dev in devices) {
                CBoxDevices.Items.Add(dev);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e) {
            this.Close();
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
                BtnClearUserClock.Enabled = !false;
                BtnUpdateUsers.Enabled = !false;
                BtnDownloadClocks.Enabled = !false;            
                LabelDeviceConnected.Text = "Conectado";

                GetAvaiableUsersID(device, out avaiableIds);

            } else {
                BtnConnect.Text = "Conectar Dispositivo";
                CBoxDevices.Enabled = true;
                BtnClearUserClock.Enabled = false;
                BtnUpdateUsers.Enabled = false;
                BtnDownloadClocks.Enabled = false;            
                LabelDeviceConnected.Text = "Desconectado";
            }
        }

        private void DisconnectDevice() {
            Device device = (Device)CBoxDevices.SelectedItem;

            if (device.Connected) {
                device.Disconnect();
            }

            if (device.Connected) {
                BtnConnect.Text = "Desconectar Dispositivo";
                CBoxDevices.Enabled = false;
                BtnClearUserClock.Enabled = !false;
                BtnUpdateUsers.Enabled = !false;
                BtnDownloadClocks.Enabled = !false;       
                LabelDeviceConnected.Text = "Conectado";
            } else {
                BtnConnect.Text = "Conectar Dispositivo";
                CBoxDevices.Enabled = true;
                BtnClearUserClock.Enabled = false;
                BtnUpdateUsers.Enabled = false;
                BtnDownloadClocks.Enabled = false;    
                LabelDeviceConnected.Text = "Desconectado";
            }
        }

        private void GetAvaiableUsersID(Device device, out SortedSet<int> avaiables) {

            DeviceIO deviceIO = new DeviceIO(device);

            List<int> users = new List<int>();
            avaiables = new SortedSet<int>();
            int maxUsers=0;

            deviceIO.GetAvaiableUsersID(out avaiables, out maxUsers);

            if (avaiables.Count == 0) {
                MessageBox.Show(this, "O biométrico atingiu número máximo de registos de beneficiarios, não será possivel registar mais beneficiarios");
                DisconnectDevice();
                return;
            }

        }

        private void CBoxDevices_SelectedIndexChanged(object sender, EventArgs e) {
            if (CBoxDevices.SelectedIndex != -1) {
                OnSelectDevice();
            } else {
                BtnConnect.Enabled = false;
                BtnClearUserClock.Enabled = false;
                BtnUpdateUsers.Enabled = false;
                BtnDownloadClocks.Enabled = false;
            }
        }

        private void OnSelectDevice() {
            Device device = (Device)CBoxDevices.SelectedItem;
            
            BtnConnect.Enabled = true;

            TxtSerialNumber.Text = device.SerialNumber;
            TxtDeviceDoor.Text = device.Door.ToString();
        }

        private void BtnUpdateUsers_Click(object sender, EventArgs e) {
            UpdateDeviceUsers();
        }

        private void UpdateDeviceUsers() {
            OnExecuteDialog background = new OnExecuteDialog("Uploading beneficiarios...", "Atualizando dados dos beneficiarios");
            Device device = (Device)CBoxDevices.SelectedItem;

            bool resul = false;

            background.OnExecute += delegate() {                
                resul = PerformUpdateUsers(device);
            };

            background.OnPostExecute += delegate() {
                if (resul == true) {
                    MessageBox.Show(this, "Dados foram atualizados com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show(this, "Não foi possivel atualizar os dados!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            background.StartExecute();                        
        }

        private bool PerformUpdateUsers(Device device) {

            try {
                                
                DeviceIO deviceIO = new DeviceIO(device);

                //get all existing users in device
                List<RawUser> existingUsers = new List<RawUser>();
                SortedSet<int> avaiablesUsersId = new SortedSet<int>();
                int maxUsers = -1;

                deviceIO.GetBasicUserInfo(out existingUsers);
                deviceIO.GetAvaiableUsersID(out avaiablesUsersId, out maxUsers);

                //get list of users to delete
                List<string> usersToDelete = new List<string>();
                foreach (var ruser in existingUsers) {

                    var duser = device.DeviceUsers.Where(du => du.Funcionario.EnrollNumber.ToString() == ruser.EnrollNumber).FirstOrDefault();

                    if (duser == null) { //se o user k esta no biometrico, nao estiver no sistema - delete
                        usersToDelete.Add(ruser.EnrollNumber);
                    } else {
                        duser.EnrollNumber = Int32.Parse(ruser.EnrollNumber);
                    }
                }

                //delete users
                foreach (var userId in usersToDelete) {
                    deviceIO.DeleteUserInfo(userId);
                }

                deviceIO.RefreshData();

                //update users info
                foreach (var devUser in device.DeviceUsers) {
                    Funcionario func = devUser.Funcionario;
                    string enrollNumber = devUser.EnrollNumber.ToString();

                    if (devUser.EnrollNumber == 0) { //Not registered
                        int userId = avaiableIds.First();
                        avaiableIds.Remove(userId);
                        enrollNumber = userId.ToString();
                    }

                    bool fase2 = deviceIO.SetUserInfo(enrollNumber, func.CardNumber, func.UserName, func.Password, func.Privilege.Value, func.Enabled.Value);

                    foreach (UserFingerprint fp in func.UserFingerprints) {
                        bool fase3 = deviceIO.SetUserTmp(enrollNumber, fp.FingerIndex, fp.TemplateData);
                    }

                }

                context.SaveChanges();
                deviceIO.RefreshData();
                deviceIO.StartIdentify();

                return true;

            }catch (Exception ex){
                return false;
            }
        }

        private void BtnClearUserClock_Click(object sender, EventArgs e) {
            EraseAllUserClock();
        }

        private void EraseAllUserClock() {
            if (CBoxDevices.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o dispositivo biométrico primeiro!");
                CBoxDevices.Focus();
                return;
            }

            Device device = (Device) CBoxDevices.SelectedItem;

            if (device.Connected == false) {
                MessageBox.Show(this, "Connecte o dispositivo primeiro!");
                BtnConnect.Focus();
                return;
            }

            DeviceIO io = new DeviceIO(device);

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

        private void BtnDownloadClocks_Click(object sender, EventArgs e) {
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

            OnExecuteDialog background = new OnExecuteDialog("Descarregamento....", "Descarregando registos de picagens do biométrico...");
            bool result = false;

            List<UserClock> clocks = null;

            background.OnExecute += delegate() {
                //Modificar Isto

                AccessControlCalculations calc = new AccessControlCalculations(context);
                DeviceDataConvertions convertions = new DeviceDataConvertions();

                //Pass 1 & 2
                List<RawUserClock> rawClocks = null;
                //Pass 1
                io.DownloadAttendanceData_TFT(out rawClocks);
                //Pass 2
                result = convertions.ConvertAttendanceDataToDatabase(context, rawClocks, out clocks);
                //Pass 3
                calc.CorrectAllUserClock(clocks);
                
                context.SaveChanges();
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

        private void DeviceDataUpdateView_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
            this.DisposeContext();
        }

        private void DeviceDataUpdateView_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible == true) {
                LoadContext();
                Initialize();
            }
        }
    }
}
