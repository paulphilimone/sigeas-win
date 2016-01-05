using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.zdbx;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.sigeas.BackgroundFeatures;
using mz.betainteractive.sigeas.Views.Calculations;
using mz.betainteractive.sigeas.DeviceSystem;
using mz.betainteractive.sigeas.zdbx.models;
using mz.betainteractive.sigeas.Utilities.Components;

namespace mz.betainteractive.sigeas.Views.ImportExport {
    public partial class ImportExportView : Form, AuthorizableComponent {
        private SigeasDatabaseContext context;
        private ZDBxDatabase importedDatabase;

        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }

        public ImportExportView() {
            InitializeComponent();
        }

        private void DisposeContext() {
            if (context != null) {
                context.Dispose();
                context = null;
                CleanImport();
                CleanExport();
                CleanImportUsers();
                CleanExportUsers();

                importedDatabase = null;
            }
        }

        private void LoadContext() {
            if (context == null) {
                context = new SigeasDatabaseContext();
                Initialize();
            }
        }

        private void Initialize() {
            CleanImport();
            CleanExport();
            CleanImportUsers();
            CleanExportUsers();
        }

        private void CleanImport() {
            TxtImportedFile.Text = "";
            LViewImportedData.Items.Clear();
            TxtNumberUserClocks.Text = "";
            BtnSaveImportedData.Enabled = false;
            importedDatabase = null;

            BtnImportFile.Enabled = AllowAdd;
        }

        private void CleanExport() {
            LViewExportData.Items.Clear();
            UnselectAll(LViewExportData);

            LoadDevicesToExportDataView();

            BtnExportToFile.Enabled = AllowDelete;
        }

        private void CleanImportUsers() {
            TxtImportedUsersFile.Text = "";
            LViewCollectDataUsers.Items.Clear();

            BtnSaveCollectedUserInfo.Enabled = false;
            importedDatabase = null;

            BtnImportUserInfo.Enabled = AllowAdd;
        }


        private void CleanExportUsers() {
            LViewExportUserDevices.Items.Clear();
            UnselectAll(LViewExportUserDevices);

            LoadDevicesToExportUsersView();

            LoadContratosToComboBox();

            LViewContratoBeneficiarios.Items.Clear();
            LViewExportBeneficiarios.Items.Clear();

            BtnExportUsers.Enabled = AllowDelete;
        }

        private void LoadContratosToComboBox() {

            CBoxContratos.Items.Clear();

            if (context == null) return;

            var contratos = context.ContratoCliente.ToList();

            foreach (ContratoCliente cc in contratos) {
                CBoxContratos.Items.Add(cc);
            }
        }


        private void UnselectAll(ListView lView) {
            foreach (ListViewItem item in lView.Items) {
                item.Checked = false;
            }
        }

        private void LoadDevicesToExportDataView() {

            LViewExportData.Items.Clear();

            if (context == null) return;

            var devices = context.Device.ToList();

            foreach (var device in devices) {
                ListViewGenericItem<Device> item = new ListViewGenericItem<Device>(device);
                item.Text = "";
                item.SubItems.AddRange(new string[] { device.Name, device.SerialNumber, device.DeviceUsers.Count.ToString() });

                LViewExportData.Items.Add(item);
            }
        }

        private void LoadDevicesToExportUsersView() {
            LViewExportUserDevices.Items.Clear();

            if (context == null) return;

            var devices = context.Device.Where(t => t.RegisteredAutoCarro == null && t.RegisteredLocal == null).ToList();

            foreach (var device in devices) {
                ListViewGenericItem<Device> item = new ListViewGenericItem<Device>(device);
                item.Text = "";
                item.SubItems.AddRange(new string[] { device.Name, device.SerialNumber });

                LViewExportUserDevices.Items.Add(item);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnImportFile_Click(object sender, EventArgs e) {
            ImportFile();
        }

        private void ImportFile() {
            CleanImport();

            DatabaseIO io = new DatabaseIO();

            io.Read(out importedDatabase);

            if (importedDatabase != null) {

                foreach (var device in importedDatabase.Devices) {
                    ListViewItem item = new ListViewItem();
                    item.Text = device.SerialNumber;
                    item.SubItems.Add(device.Name);
                    item.SubItems.Add(device.DeviceUsers.Count.ToString());

                    LViewImportedData.Items.Add(item);
                }

                TxtImportedFile.Text = io.GetOpenedFileName();
                TxtNumberUserClocks.Text = importedDatabase.Clocks.Count.ToString();
                BtnSaveImportedData.Enabled = (importedDatabase.Devices.Count > 0) && AllowAdd;
            }
        }

        private void BtnExportToFile_Click(object sender, EventArgs e) {
            ExportDataToFile();
        }

        private void ExportDataToFile() {
            if (LViewExportData.CheckedItems.Count == 0) {
                MessageBox.Show(this, "Selecione os dispositivos biométricos por favor!");
                return;
            }

            ZDBxDatabase database = null;
            List<Device> selectedDevices = GetSelectedDevicesToExportData();

            DeviceDataConvertions convertions = new DeviceDataConvertions();

            convertions.GetZDBxDatabase(selectedDevices, out database);

            string filename = "Multiple Devices-";

            if (selectedDevices.Count == 1) {
                filename = selectedDevices[0].Name + "-";
            }

            DateTime date = DateTime.Now;

            filename += date.Day.ToString("D2") + "_" +
                        date.Month.ToString("D2") + "_" +
                        date.Year + "_" +
                        date.Hour.ToString("D2") + "." +
                        date.Minute.ToString("D2") + "." +
                        date.Second.ToString("D2");

            if (database != null) {
                DatabaseIO io = new DatabaseIO();

                io.SavedFileName = filename + "_FS";

                if (io.Write(database)) {
                    MessageBox.Show(this, "O ficheiro com backup dos dados foi criado com sucesso!");
                }
            }
        }

        private List<Device> GetSelectedDevicesToExportData() {
            List<Device> devices = new List<Device>();

            foreach (ListViewGenericItem<Device> item in LViewExportData.Items) {
                if (item.Checked == true) {
                    devices.Add(item.Value);
                }
            }

            return devices;
        }

        private List<Device> GetSelectedDevicesToExportUsers() {
            List<Device> devices = new List<Device>();

            foreach (ListViewGenericItem<Device> item in LViewExportUserDevices.Items) {
                if (item.Checked == true) {
                    devices.Add(item.Value);
                }
            }

            return devices;
        }

        private List<Beneficiario> GetSelectedContratoBeneficiarios() {
            List<Beneficiario> benefs = new List<Beneficiario>();

            foreach (ListViewGenericItem<Beneficiario> item in LViewContratoBeneficiarios.Items) {
                if (item.Checked == true) {
                    benefs.Add(item.Value);
                }
            }

            return benefs;
        }                

        private List<Beneficiario> GetAllContratoBeneficiarios() {
            List<Beneficiario> benefs = new List<Beneficiario>();

            foreach (ListViewGenericItem<Beneficiario> item in LViewContratoBeneficiarios.Items) {
                benefs.Add(item.Value);
            }

            return benefs;
        }

        private List<Beneficiario> GetBeneficiariosToExport() {
            List<Beneficiario> benefs = new List<Beneficiario>();

            foreach (ListViewGenericItem<Beneficiario> item in LViewExportBeneficiarios.Items) {
                benefs.Add(item.Value);
            }

            return benefs;
        }

        private void BtnSaveImportedData_Click(object sender, EventArgs e) {
            SaveImportedData();
        }

        private void SaveImportedData() {
            if (importedDatabase == null) {
                MessageBox.Show(this, "Não existem dados importados para serem guardados no sistema");
                return;
            }

            //when we are in UpdateDeviceModule - atualizar EnrollNumber

            UpdateUserAndDownloadClocks();

        }

        private void UpdateDeviceUsers() {
            foreach (var zdev in importedDatabase.Devices) {
                Device device = context.Device.FirstOrDefault(t => t.SerialNumber == zdev.SerialNumber);

                if (device != null) {
                    foreach (var zdevUser in zdev.DeviceUsers) {
                        //DeviceUser devUser = device.DeviceUsers.FirstOrDefault(t => t.Beneficiario.iCardNumber==zdevUser.User.CardNumber);
                        DeviceUser devUser = device.DeviceUsers.FirstOrDefault(t => t.Beneficiario.Id == zdevUser.User.Id);

                        if (devUser != null) {
                            Beneficiario ben = devUser.Beneficiario;
                            ZUser user = zdevUser.User;

                            devUser.EnrollNumber = zdevUser.EnrollNumber;
                            devUser.CardNumber = zdevUser.User.CardNumber;

                            //Update card number and fingerprints

                            ben.CardNumber = zdevUser.User.CardNumber;

                            //update fingerprints
                            if (user.HasNewFingerprints) {
                                ben.UserFingerprints.RemoveAll(t => t.User.Id == user.Id);

                                foreach (ZUserFingerprint zfinger in user.UserFingerprints) {
                                    UserFingerprint finger = new UserFingerprint {
                                        User = ben,
                                        FingerIndex = zfinger.FingerIndex,
                                        TemplateData = zfinger.TemplateData
                                    };

                                    ben.UserFingerprints.Add(finger);
                                }
                            }

                        }
                    }
                }
            }

        }

        private void UpdateUserAndDownloadClocks() {
            OnExecuteDialog background = new OnExecuteDialog("Atualização de dados....", "Descarregando registos de picagens do biométrico...");
            bool result = false;

            List<UserClock> clocks = null;

            background.OnExecute += delegate() {

                AccessControlCalculations calc = new AccessControlCalculations(context);
                DeviceDataConvertions convertions = new DeviceDataConvertions();

                UpdateDeviceUsers();

                result = convertions.ConvertAttendanceDataToDatabase(context, importedDatabase.Clocks, out clocks);

                calc.CorrectAllUserClock(clocks);
                calc.CalculateMovimentoPorTransacao(clocks);
                calc.UpdateAllContratos();

                context.SaveChanges();
            };

            background.OnPostExecute += delegate() {
                if (result == true) {
                    MessageBox.Show(this, "Os Dados foram atualizados com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show(this, "Não foi possivel gravar os registos de picagens", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            background.StartExecute();
        }

        private void ImportExportView_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
            DisposeContext();
        }

        private void ImportExportView_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible == true) {
                this.LoadContext();
            }
        }

        private void CBoxContratos_SelectedIndexChanged(object sender, EventArgs e) {
            if (CBoxContratos.SelectedIndex != -1) {
                OnSelectContrato();
            } else {
                LViewContratoBeneficiarios.Items.Clear();
            }
        }

        private void OnSelectContrato() {
            ContratoCliente contrato = (ContratoCliente)CBoxContratos.SelectedItem;
            LoadBeneficiariosToListView(contrato);
        }

        private void LoadBeneficiariosToListView(ContratoCliente contrato) {
            LViewContratoBeneficiarios.Items.Clear();

            foreach (Beneficiario beneficiario in contrato.Beneficiarios) {

                if (!beneficiario.CompleteRegistered) {

                    ListViewGenericItem<Beneficiario> item = new ListViewGenericItem<Beneficiario>(beneficiario);
                    item.ImageIndex = 0;
                    item.Text = beneficiario.ToString();
                    LViewContratoBeneficiarios.Items.Add(item);

                    //item.ForeColor = Color.Red;
                }

            }
        }

        private void BtnAddBeneficiario_Click(object sender, EventArgs e) {
            AddBeneficiarioToListExport();
        }

        private void AddBeneficiarioToListExport() {
            List<Beneficiario> list = GetSelectedContratoBeneficiarios();

            if (list.Count == 0) {
                MessageBox.Show(this, "Para adicionar os beneficiarios selecione-os primeiro!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LViewContratoBeneficiarios.Focus();
                return;
            }

            List<Beneficiario> listExisting = GetBeneficiariosToExport();

            foreach (Beneficiario ben in list) {
                if (!listExisting.Contains(ben)) {
                    ListViewGenericItem<Beneficiario> item = new ListViewGenericItem<Beneficiario>(ben);
                    item.ImageIndex = 0;
                    item.Text = ben.ToString();
                    LViewExportBeneficiarios.Items.Add(item);
                }
            }
        }

        private void RemoveBeneficiarioFromListExport() {
            
            if (LViewExportBeneficiarios.SelectedItems.Count == 0) {
                MessageBox.Show(this, "Para remover os beneficiarios selecione-os primeiro!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LViewExportBeneficiarios.Focus();
                return;
            }

            var list = LViewExportBeneficiarios.SelectedItems;

            foreach (ListViewItem item in list) {                    
                LViewExportBeneficiarios.Items.Remove(item);                
            }
        }

        

        private void BtnAddAllBeneficiarios_Click(object sender, EventArgs e) {
            AddAllBeneficiarioToListExport();
        }

        private void AddAllBeneficiarioToListExport() {
            List<Beneficiario> list = GetAllContratoBeneficiarios();

            if (list.Count == 0) {
                MessageBox.Show(this, "Não existem beneficiarios para adicionar!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LViewContratoBeneficiarios.Focus();
                return;
            }

            List<Beneficiario> listExisting = GetBeneficiariosToExport();

            foreach (Beneficiario ben in list) {
                if (!listExisting.Contains(ben)) {
                    ListViewGenericItem<Beneficiario> item = new ListViewGenericItem<Beneficiario>(ben);
                    item.ImageIndex = 0;
                    item.Text = ben.ToString();
                    LViewExportBeneficiarios.Items.Add(item);
                }
            }
        }

        private void BtnRemoveBeneficiario_Click(object sender, EventArgs e) {
            RemoveBeneficiarioFromListExport();
        }

        private void BtnRemoveAllBeneficiarios_Click(object sender, EventArgs e) {
            LViewExportBeneficiarios.Items.Clear();
        }

        private void BtnExportUsers_Click(object sender, EventArgs e) {
            ExportUsersToFile();
        }

        private void ExportUsersToFile() {
            if (LViewExportUserDevices.CheckedItems.Count == 0) {
                MessageBox.Show(this, "Selecione os dispositivos biométricos por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (LViewExportBeneficiarios.Items.Count == 0) {
                MessageBox.Show(this, "Não existem beneficiarios para serem exportados. Adicione-os!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnAddAllBeneficiarios.Focus();
                return;
            }

            ZDBxDatabase database = new ZDBxDatabase();
            List<Device> selectedDevices = GetSelectedDevicesToExportUsers();
            List<Beneficiario> beneficiarios = GetBeneficiariosToExport();

            DeviceDataConvertions convertions = new DeviceDataConvertions();

            foreach (var dev in selectedDevices) {
                ZDevice zdevice = null;
                convertions.GetZDevice(dev, out zdevice);
                database.Devices.Add(zdevice);
            }

            foreach (var ben in beneficiarios) {
                ZUser zuser = convertions.GetZUserOnly(ben);
                database.Users.Add(zuser);
            }

            string filename = "Colecta de Usuários-";

            DateTime date = DateTime.Now;

            filename += date.Day.ToString("D2") + "_" +
                        date.Month.ToString("D2") + "_" +
                        date.Year + "_" +
                        date.Hour.ToString("D2") + "." +
                        date.Minute.ToString("D2") + "." +
                        date.Second.ToString("D2");

            if (database != null) {
                DatabaseIO io = new DatabaseIO();

                io.SavedFileName = filename + "_FS";

                if (io.Write(database)) {
                    MessageBox.Show(this, "O ficheiro com backup dos dados foi criado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void LViewCollectDataUsers_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void BtnImportUserInfo_Click(object sender, EventArgs e) {
            ImportUserInfo();
        }

        private void ImportUserInfo() {
            CleanImportUsers();

            DatabaseIO io = new DatabaseIO();

            ZDBxDatabase importedDb = null;

            io.Read(out importedDb);

            if (importedDb != null) {

                if (importedDb.Users.Count == 0) {
                    MessageBox.Show(this, "Não foi possivel importar usuários", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int index = 0;

                foreach (var user in importedDb.Users) {
                    index++;

                    var beneficiario = context.Beneficiario.FirstOrDefault(t => t.Id == user.Id);

                    ItemZUserBeneficiario zitem = new ItemZUserBeneficiario { Beneficiario = beneficiario, User = user };

                    ListViewGenericItem<ItemZUserBeneficiario> item = new ListViewGenericItem<ItemZUserBeneficiario>(zitem);

                    if (beneficiario == null) {
                        item.Text = user.Id.ToString();
                    } else {
                        item.Text = beneficiario.GetCode();
                    }

                    item.SubItems.Add(user.FullName);
                    item.SubItems.Add(user.CardNumber);
                    item.SubItems.Add(user.UserFingerprints.Count.ToString());

                    if (beneficiario == null) {
                        item.SubItems.Add("Inválido");
                        item.BackColor = Color.Lime;
                    } else {
                        item.SubItems.Add("OK");
                    }

                    LViewCollectDataUsers.Items.Add(item);
                }

                TxtImportedUsersFile.Text = io.GetOpenedFileName();
                BtnSaveCollectedUserInfo.Enabled = AllowAdd;

            } else {
                MessageBox.Show(this, "Não foi possivel importar usuários", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private List<ItemZUserBeneficiario> GetValidColletecdUserData() {
            List<ItemZUserBeneficiario> list = new List<ItemZUserBeneficiario>();

            foreach (ListViewGenericItem<ItemZUserBeneficiario> item in LViewCollectDataUsers.Items) {
                if (item.Value.Beneficiario != null) {
                    list.Add(item.Value);
                }
            }

            return list;
        }

        private void BtnSaveCollectedUserInfo_Click(object sender, EventArgs e) {
            SaveCollectedUserData();
        }

        private void SaveCollectedUserData() {
            if (LViewCollectDataUsers.Items.Count == 0) {
                MessageBox.Show(this, "Não existem dados importados para serem guardados no sistema");
                return;
            }

            //when we are in UpdateDeviceModule - atualizar EnrollNumber

            List<ItemZUserBeneficiario> listUsers = GetValidColletecdUserData();

            if (listUsers.Count == 0) {
                MessageBox.Show(this, "Não existem usuários com dados válidos importados! (Os usuários não foram encontrados no sistema)", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UpdateCollectedUserDataToSystem(listUsers);
        }

        private void UpdateCollectedUserDataToSystem(List<ItemZUserBeneficiario> listUsers) {
            OnExecuteDialog background = new OnExecuteDialog("Atualização de dados....", "Atualizando dados colectados dos usuários...");
            bool result = false;
            
            background.OnExecute += delegate() {
                result = UpdateCollectedUsers(listUsers);
                context.SaveChanges();
            };

            background.OnPostExecute += delegate() {
                if (result == true) {
                    MessageBox.Show(this, "Os Dados foram atualizados com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show(this, "Não foi possivel atualizar os dados colectados!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            background.StartExecute();
        }

        private bool UpdateCollectedUsers(List<ItemZUserBeneficiario> listUsers) {

            try {                                 

                foreach (var item in listUsers) {

                    if (item.Beneficiario != null) {
                        Beneficiario ben = item.Beneficiario;
                        ZUser user = item.User;

                        //Update card number and fingerprints
                        ben.CardNumber = user.CardNumber;

                        //update fingerprints
                        if (user.HasNewFingerprints) {

                            ben.UserFingerprints.RemoveAll(t => t.User.Id == user.Id);

                            foreach (ZUserFingerprint zfinger in user.UserFingerprints) {
                                UserFingerprint finger = new UserFingerprint {
                                    User = ben,
                                    FingerIndex = zfinger.FingerIndex,
                                    TemplateData = zfinger.TemplateData
                                };
                                ben.UserFingerprints.Add(finger);
                            }
                        }

                    }
                }

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Error");
                return false;
            }

            return true;
        }



    }

    class ItemZUserBeneficiario {
        public ZUser User;
        public Beneficiario Beneficiario;
    }
}
