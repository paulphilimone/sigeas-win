using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.sigeas.DeviceSystem;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.encoding.encryptation;
using mz.betainteractive.utilities.module.General;

namespace mz.betainteractive.sigeas.Views.DeviceManagement {
    public partial class DeviceAdd : Form {
        private SigeasDatabaseContext context;
        private int MaxUsers;

        public DeviceAdd() {
            InitializeComponent();
            context = new SigeasDatabaseContext();
            LoadDeviceTypes();
        }

        private void LoadDeviceTypes() {
            CBoxDeviceType.Items.Clear();

            var types = context.DeviceType.ToList();

            foreach (var devType in types) {
                CBoxDeviceType.Items.Add(devType);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            AddDevice();
        }

        private void AddDevice() {
            if (!ValidateDevice()) {
                return;
            }


            var devs = context.Device.Where(d => d.SerialNumber == TxtSerialNumber.Text);

            if (devs.Count() > 0) {
                MessageBox.Show(this, "Ja existe um dispositivo com a mesma (SerialNumber) do dispositivo a ser adicionado.", "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnTestConnection.Focus();
                return;
            }


            //Verificar se os biométricos estão registrados para uso no sistema
            //Hide for Tests
            if (!System.Diagnostics.Debugger.IsAttached)
            if (true) {
                var activations = context.DeviceActivation.ToList();

                List<string> keys = new List<string>();
                BetaEncryptation decoder = new BetaEncryptation();

                foreach (var da in activations) {
                    string sn = "";
                    string cd = "";
                    decoder.Decrypt(da.ProductKey, out sn, out cd);
                    keys.Add(sn);
                }
                if (!keys.Contains(TxtSerialNumber.Text)) {
                    MessageBox.Show("O Biométrico não esta registrado para uso no nosso sistema, contacte o tecnico!");
                    TxtSerialNumber.Focus();
                    return;
                }
            }

            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja adicionar o dispositivo (" + TxtName.Text + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            Device device = new Device();

            device.Name = TxtName.Text;
            device.DeviceType = CBoxDeviceType.SelectedItem as DeviceType;
            device.SerialNumber = TxtSerialNumber.Text;
            device.ConnectionType = (RbTCP.Checked) ? 0 : ((RbRS.Checked) ? 1 : 2);
            device.IpAddress = TxtIPAddress.Text;
            device.Port = Convert.ToInt32(TxtIpPort.Text);
            device.ComPort = this.CBoxComPort.SelectedIndex + 1;
            device.BaudRate = Convert.ToInt32(this.CBoxBaudRate.SelectedItem.ToString());
            device.MaxUsers = MaxUsers;
            device.CreatedBy = SystemManager.GetCurrentUser(context);
            device.CreationDate = DateTime.Now;

            try {
                context.Device.Add(device);
                context.SaveChanges();
                MessageBox.Show(this, "O biomtrico foi adicionado com sucesso!");
                this.Close();

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar adicionar o biometrico na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar adicionar o biometrico na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool ValidateDevice() {
            if (TxtName.Text == "") {
                MessageBox.Show(this, "Introduza o nome do biométrico 1");
                TxtName.Focus();
                return false;
            }

            if (CBoxDeviceType.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o tipo de dispositivo biometrico!");
                CBoxDeviceType.Focus();
                return false;
            }

            if (!ValidateConnection()) {
                return false;
            }

            if (TxtSerialNumber.Text == "") {
                MessageBox.Show(this, "Número de serie invalido!\nPara obter o número de serie, conecte o dispositivo e clique em (Testar conexão).");
                BtnTestConnection.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateConnection() {

            string regxIp = "^[0-9]+\\.[0-9]+\\.[0-9]+\\.[0-9]+$";
            string regxNum = "^[0-9]+$";

            if (RbTCP.Checked) {
                if (!Regex.IsMatch(TxtIPAddress.Text, regxIp)) {
                    MessageBox.Show(this, "O endereço IP introduzido é inválido, introduza correctamente");
                    TxtIPAddress.Focus();
                    return false;
                }
                if (!Regex.IsMatch(TxtIpPort.Text, regxNum)) {
                    MessageBox.Show(this, "O numero da porta introduzido é inválido, introduza correctamente");
                    TxtIpPort.Focus();
                    return false;
                }
            }

            if (RbRS.Checked) {
                if (CBoxComPort.SelectedIndex == -1) {
                    MessageBox.Show(this, "Selecione a porta COM");
                    CBoxComPort.Focus();
                    return false;
                }
                if (CBoxBaudRate.SelectedIndex == -1) {
                    MessageBox.Show(this, "Selecione a taxa de transferência(Baud Rate)");
                    CBoxBaudRate.Focus();
                    return false;
                }
            }

            return true;
        }

        private void BtnTestConnection_Click(object sender, EventArgs e) {
            TestConnection();
        }

        private void TestConnection() {
            DeviceConnector connector = DeviceConnector.GetDeviceConnector();

            if (RbTCP.Checked) {
                connector.SetTCPConnectionMode(TxtIPAddress.Text, Convert.ToInt32(TxtIpPort.Text));
            }
            if (RbRS.Checked) {
                connector.SetCOMConnectionMode(this.CBoxComPort.SelectedIndex + 1, Convert.ToInt32(this.CBoxBaudRate.SelectedItem.ToString()));
            }
            if (RbUSB.Checked) {
                connector.SetUSBConnectionMode();
            }

            connector.StartConnection();

            if (connector.IsConnected()) {
                string sn = "";
                connector.GetSerialNumber(out sn);
                connector.GetDeviceStatus(8, ref MaxUsers);
                TxtSerialNumber.Text = sn;
            }

            connector.Disconnect();
        }

        private void TxtSerialNumber_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (System.Diagnostics.Debugger.IsAttached) {
                TxtSerialNumber.ReadOnly = !TxtSerialNumber.ReadOnly;
            }
        }

        private void DeviceAdd_FormClosing(object sender, FormClosingEventArgs e) {
            context.Dispose();
        }
    }
}
