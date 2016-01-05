using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas;
using System.Threading;
using System.Globalization;
using mz.betainteractive.sigeas.Views;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.encoding.encryptation;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.BackgroundFeatures;

namespace mz.betainteractive.sigeas.Views.Main {
        
    public partial class LoginView : Form {

        public static MainView MainForm;
        //private bool AutoLogin = false;
        private bool AutoLogin = true;//For Tests purpose only

        public LoginView() {            
            InitializeComponent();
            //CreateMainForm();
                        
        }

        public void DestroyMainForm(){
            MainForm = null;
            System.GC.Collect();
        }

        public void CreateMainForm() {
            MainForm = new MainView();
            MainForm.LoginView = this;
        }

        private void LoginView_Load(object sender, EventArgs e) {                       
            LoadUsersToList();                        
        }

        private void LoadUsersToList() {
            ListViewUsuarios.Clear();
            btOK.Enabled = false;

            try {
                using (var DB = new SigeasDatabaseContext()) {

                    var users = DB.ApplicationUser.Where(u => u.Enabled == true);                                

                    if (users.Count() > 0) {
                        btOK.Enabled = true;
                    }
                    
                    foreach (var user in users) {
                        if (user.Enabled) {
                            ListViewItem item = new ListViewItem(user.ToString());
                            item.Name = user.UserName;
                            item.ImageIndex = 2;
                            ListViewUsuarios.Items.Add(item);
                        }                        
                    }
                }
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Database Error");
                MessageBox.Show(this, "Ocorreu erro ao tentar ler usuários na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
        
        private void ListViewUsuarios_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {                
                ListViewItem item = ListViewUsuarios.SelectedItems[0];
                UsernameTextBox.Text = item.Name;
                PasswordTextBox.Focus();
            }
        }

        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e) {
            ValidateUser();          
        }

        private void ValidateUser() {
            SystemManager.CurrentUserId = -1;
            SystemManager.CurrentEmpresaId = -1;


            if (UsernameTextBox.Text == "") {
                MessageBox.Show(this, "Selecione o usuario primeiro");
                ListViewUsuarios.Focus();
                return;
            }

            if (PasswordTextBox.Text == "") {
                MessageBox.Show(this, "Introduza a password por favor");
                PasswordTextBox.Focus();
                return;
            }

            try {
                using (var DB = new SigeasDatabaseContext()) {
                    string username = UsernameTextBox.Text;

                    ApplicationUser user = DB.ApplicationUser.FirstOrDefault(u => u.UserName==username);
                                        
                    if (user != null) {
                        BetaEncryptation be = new BetaEncryptation();
                        String password = be.EncodePassword(PasswordTextBox.Text);
                                                

                        if (user.Password == password) {
                            SystemManager.CurrentUserId = user.Id;                            
                            OpenMainForm(user);
                        } else {
                            MessageBox.Show(this, "A password introduzida está incorrecta, tente outra vez", "Autenticação de usuário");
                            PasswordTextBox.Focus();
                            return;
                        }
                    } else {
                        MessageBox.Show(this, "A password introduzida está incorrecta, tente outra vez", "Autenticação de usuário");
                        PasswordTextBox.Focus();
                        return;
                    }
                }
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Database Error");
                MessageBox.Show(this, "Ocorreu erro na conexão com a base de dados.\nErro: " + ex.Message, "Autenticação de usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenMainForm(ApplicationUser user) {
            this.Hide();                                                

            OnExecuteDialog background = new OnExecuteDialog("Logging In", "A Configurar sistema...");

            CreateMainForm();

            background.OnExecute += delegate() {
                
                MainForm.UpdateUserSettings(user);
            };

            background.OnPostExecute += delegate() {
                MainForm.Visible = true;
            };

            background.StartExecute();                        
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                ValidateUser();
            }
        }
        
        internal void ClearForms() {
            LoadUsersToList();
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        private void FrmLogin_Shown(object sender, EventArgs e) {
            if (AutoLogin) {
                UsernameTextBox.Text = "developer";
                PasswordTextBox.Text = "developer";
                ValidateUser();
            }
        }

        private void LoginView_FormClosed(object sender, FormClosedEventArgs e) {
            Environment.Exit(Environment.ExitCode);
        }

        private void LoginView_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                SystemManager.CurrentEmpresaId = -1;
                SystemManager.CurrentUserId = -1;
            }
        }
    }
}
