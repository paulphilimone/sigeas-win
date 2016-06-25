using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
using mz.betainteractive.sigeas;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.encoding.encryptation;
using mz.betainteractive.utilities.module.Components;

namespace mz.betainteractive.sigeas.Views.DeviceManagement {
    public partial class FrmDeviceActivaction : Form, AuthorizableComponent {

        private string Company = "";
        private string Encrypted = "";
        private string ProductKey = "";

        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }

        public FrmDeviceActivaction() {
            InitializeComponent();
            linkLabel.Links.Add(linkLabel.LinkArea.Start, linkLabel.LinkArea.Length, "www.betainteractive.co.mz/products?=bisigeas");
        }

        private void btOpenFile_Click(object sender, EventArgs e) {
            OpenFile();
        }

        private void OpenFile() {
            DialogResult dr = FormOpenFile.ShowDialog();

            if (dr == DialogResult.OK) {
                try {

                    Console.WriteLine("path: "+FormOpenFile.InitialDirectory);
                    Console.WriteLine("file: " + FormOpenFile.FileName);

                    Company = "";
                    Encrypted = "";
                    ProductKey = "";
                    txtCompany.Text = "";
                    txtMKey.Text = "";

                    Stream st = FormOpenFile.OpenFile();
                    //BinaryReader br = new BinaryReader(st);

                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Binder = new BTSKeyBindChanger();

                    BTSKey bkey = (BTSKey) bf.Deserialize(st);
                                        
                    Company = bkey.Company;
                    Encrypted = bkey.EncryptedKey;
                    ProductKey = bkey.ProductKey;

                    if (bkey.Used) {
                        MessageBox.Show("Está chave ja foi usada","Não é possivel registrar!");
                        return;
                    }

                    Console.WriteLine("Company Name : " + Company);
                    Console.WriteLine("Encrypted    : " + Encrypted);
                    Console.WriteLine("Product Key  : " + ProductKey);

                    st.Close();                               

                }catch(Exception ex){
                    MessageBox.Show("Erro de leitura do ficheiro, não foi possivel ler esse ficheiro!\nErro: "+ex.Message, "Erro de leitura");
                    Company = "";
                    Encrypted = "";
                    ProductKey = "";
                    return;
                }
                
                BetaEncryptation Enk = new BetaEncryptation();

                string SN = "";
                string CD = "";

                bool isDecrypted = Enk.Decrypt(Encrypted, out SN, out CD);

                if (isDecrypted) {
                    txtCompany.Text = Company;
                    txtMKey.Text = ProductKey;
                    btRegister.Enabled = true;
                } else {
                    MessageBox.Show("O ficheiro de registro está corrompido, não será possivel efectuar o registro");
                }

            }
        }

        private void FrmDeviceActivaction_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
        }

        private void btRegister_Click(object sender, EventArgs e) {

            //Find the file
            
            if (!File.Exists(FormOpenFile.FileName)) {
                MessageBox.Show("O ficheiro ("+FormOpenFile.FileName+") não foi encontrado!\nRepita novamente","Não será possivel registrar");
                btOpenFile.Enabled = true;
                btRegister.Enabled = false;
                return;
            }

            Console.WriteLine("Registering");
            Console.WriteLine("Company Name : " + Company);
            Console.WriteLine("Encrypted    : " + Encrypted);
            Console.WriteLine("Product Key  : " + ProductKey);

            string SN = "";
            string CD = "";

            BetaEncryptation Enk = new BetaEncryptation();

            bool isDecrypted = Enk.Decrypt(Encrypted, out SN, out CD);

            if (!isDecrypted) {
                MessageBox.Show("Chave invalida! tente novamente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ddDdd\\
            try {
                var context = new SigeasDatabaseContext();

                DeviceActivation auth = new DeviceActivation();
                auth.Company = Company;
                auth.ProductKey = Encrypted;

                context.DeviceActivation.Add(auth);
                context.SaveChanges();

                btRegister.Enabled = false;
                DisableKeyFile();
                MessageBox.Show("A chave foi registrada com sucesso","", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                

            } catch (Exception ex) {
                MessageBox.Show("Não foi possivel registrar os dados, tente novamente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisableKeyFile() {
            
            string file = FormOpenFile.FileName;

            FileStream fs = new FileStream(file, FileMode.Create);
            
            BTSKey bkey = new BTSKey(Company, Encrypted, ProductKey);
            bkey.Used = true;

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, bkey);

            fs.Close();
        }

        private void FrmDeviceActivaction_Load(object sender, EventArgs e) {
            
        }
    }
        
    class BindChanger : System.Runtime.Serialization.SerializationBinder {
        public override Type BindToType(string assemblyName, string typeName) {
            // Define the new type to bind to 
            Type typeToDeserialize = null;
            // Get the assembly names
            string currentAssembly = Assembly.GetExecutingAssembly().FullName;
            // Create the new type and return it 
            typeToDeserialize = Type.GetType(string.Format("{0}, {1}", typeName, currentAssembly));
            return typeToDeserialize;
        }    
    }
}
