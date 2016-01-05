using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using mz.betainteractive.sigeas.DeviceSystem;
using mz.betainteractive.encoding.encryptation;

namespace mz.betainteractive.sigeas.bpkgenerator.Views {
    public partial class FrmGenerateKey : Form {

        private string SerialNumber;
        private string CreationDate;
        private string ProductName;

        private BetaEncryptation BetaEncrypt;
               

        public FrmGenerateKey() {
            InitializeComponent();
                    
            BetaEncrypt = new BetaEncryptation();
        }
                
        private void btEditBio_TestConnection1_Click(object sender, EventArgs e) {
            TestConnection1();
        }

        private void TestConnection1() {
            if (validateConnection1()) {
                connectTest1();               
            }
        }

        private bool validateConnection1() {

            string regxIp = "^[0-9]+\\.[0-9]+\\.[0-9]+\\.[0-9]+$";
            string regxNum = "^[0-9]+$";

            if (RbTCP.Checked) {
                if (!Regex.IsMatch(TxtIPAddress.Text, regxIp)) {
                    MessageBox.Show("O endereço IP introduzido é inválido, introduza correctamente");                    
                    TxtIPAddress.Focus();
                    return false;
                }
                if (!Regex.IsMatch(TxtIpPort.Text, regxNum)) {
                    MessageBox.Show("O numero da porta introduzido é inválido, introduza correctamente");                    
                    TxtIpPort.Focus();
                    return false;
                }
            }

            if (RbRS.Checked) {
                if (CBoxComPort.SelectedIndex == -1) {
                    MessageBox.Show("Selecione a porta COM");                    
                    CBoxComPort.Focus();
                    return false;
                }
                if (CBoxBaudRate.SelectedIndex == -1) {
                    MessageBox.Show("Selecione a taxa de transferência(Baud Rate)");                    
                    CBoxBaudRate.Focus();
                    return false;
                }
            }

            return true;
        }

        private void connectTest1() {

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
               
                labelConState.Text = "Conectado";

                connector.GetSerialNumber(out SerialNumber);
                connector.GetDeviceStatusStr(1, out CreationDate);
                connector.GetProductCode(out ProductName);

                TxtSerialNumber.Text = SerialNumber;
            }

            connector.Disconnect();

        }

        private void button1_Click(object sender, EventArgs e) {
            gBConnections.Enabled = true;
            gBCommunication.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
            TxtSerialNumber.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) {
            gBConnections.Enabled = false;
            gBCommunication.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;
            TxtSerialNumber.Text = "";
        }

        private void txtEditBio_SN1_TextChanged(object sender, EventArgs e) {
            btGenerate.Enabled = (TxtSerialNumber.Text.Length > 0);
        }

        private void btCreateFile_Click(object sender, EventArgs e) {
            //MessageBox.Show("Not yet implemented");                
            createFile();
        }

        private void btGenerate_Click(object sender, EventArgs e) {
            string encrypted = "";
            string productKey = "";
            BetaEncrypt.Encrypt(SerialNumber, CreationDate, out encrypted, out productKey);

            txtMKey.Text = productKey;
            txtEncrypted.Text = encrypted;
        }

        private void txtMKey_TextChanged(object sender, EventArgs e) {
            btCreateFile.Enabled = (txtMKey.Text.Length > 0);
        }

        private void createFile() {
            string comp = txtCompany.Text;
            string encr = txtEncrypted.Text;
            string pkey = txtMKey.Text;                       
            //F7_2011-01-10_10-9-9.btskey

            string dt = DateTime.Now.ToString();
            dt = dt.Replace(" ", "_").Replace(":", "-");

            string file = ProductName + "_" + dt +".btskey";

            FormSaveFile.FileName = file;

            DialogResult dr = FormSaveFile.ShowDialog();

            if (dr == DialogResult.OK) {
                Stream st = FormSaveFile.OpenFile();

                BTSKey filekey = new BTSKey(comp, encr, pkey);                                

                BinaryFormatter bf = new BinaryFormatter();
                bf.Binder = new BTSKeyBindChanger();

                bf.Serialize(st, filekey);
                
                st.Close();
                
                MessageBox.Show("Ficheiro criado com sucesso!!!");

                Console.WriteLine("dir: ");
            }
            
        }

        private void FrmGenerateKey_Load(object sender, EventArgs e) {
            string dt = DateTime.Now.ToString();
            dt = dt.Replace(" ", "_").Replace(":", "-");

            Console.WriteLine("DATE: "+dt);
        }

        private void button3_Click(object sender, EventArgs e) {
            DialogResult dr = FormOpenFile.ShowDialog();
            
            if (dr == DialogResult.OK){
                Stream st = FormOpenFile.OpenFile();

                BinaryReader br = new BinaryReader(st);

                Console.WriteLine("Company Name : " + br.ReadString());
                Console.WriteLine("Encrypted    : " + br.ReadString());
                Console.WriteLine("Product Key  : " + br.ReadString());

                br.Close();
            }
        }
    }

    
 
}
