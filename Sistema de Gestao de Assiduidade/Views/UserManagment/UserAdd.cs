using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.encoding.encryptation;
using mz.betainteractive.sigeas.Utilities;

namespace mz.betainteractive.sigeas.Views.UserManagment {
    public partial class UserAdd : Form {
        private SigeasDatabaseContext context;

        public UserAdd(SigeasDatabaseContext context) {
            InitializeComponent();

            this.context = context;

            Initialize();
        }

        private void Initialize() {
            LoadRolesToListBox();
        }

        private void LoadRolesToListBox() {
            List<Role> checkedItems = new List<Role>();

            foreach (object obj in LBoxAppUser_Perfis.CheckedItems) {
                checkedItems.Add((Role)obj);
            }

            LBoxAppUser_Perfis.Items.Clear();

            var roles = context.Role.ToList();

            foreach (Role role in roles) {
                LBoxAppUser_Perfis.Items.Add(role, checkedItems.Contains(role));
            }

        }

        private bool ValidarAppUser() {
            if (TxtAppUser_Nome.Text == "") {
                MessageBox.Show(this, "Introduza o nome, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtAppUser_Nome.Focus();
                return false;
            }
            if (TxtAppUser_Apelido.Text == "") {
                MessageBox.Show(this, "Introduza o apelido", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtAppUser_Apelido.Focus();
                return false;
            }
            if (TxtAppUser_Email.Text == "") {
                MessageBox.Show(this, "Introduza o email", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtAppUser_Email.Focus();
                return false;
            }

            if (LBoxAppUser_Perfis.CheckedIndices.Count == 0) {
                MessageBox.Show(this, "Selecione pelo menos um perfil de usuário", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LBoxAppUser_Perfis.Focus();
                return false;
            }

            if (TxtAppUser_UserName.Text == "") {
                MessageBox.Show(this, "Introduza o nome do usuário, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtAppUser_UserName.Focus();
                return false;
            }

            if (TxtAppUser_Password1.Text == "") {
                MessageBox.Show(this, "Introduza a senha, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtAppUser_Password1.Focus();
                return false;
            }

            if (TxtAppUser_Password1.Text != TxtAppUser_Password2.Text) {
                MessageBox.Show(this, "As senhas introduzidas são diferentes, introduza novamente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtAppUser_Password2.Focus();
                return false;
            }
            
            return true;
        }

        private List<Role> GetSelectedRoles() {
            List<Role> roles = new List<Role>();

            foreach (object obj in LBoxAppUser_Perfis.CheckedItems) {
                roles.Add((Role)obj);
            }

            return roles;
        }

        private void BtCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtSave_Click(object sender, EventArgs e) {
            SaveAppUser();
        }

        private void SaveAppUser() {

            if (!ValidarAppUser()) {
                return;
            }

            //verificar se ja existe um usuario com nome e username igual no sistema
            string nome = TxtAppUser_Nome.Text;
            string apelido = TxtAppUser_Apelido.Text;
            string email = TxtAppUser_Email.Text;
            List<Role> roles = GetSelectedRoles();
            bool enabled = CBoxAppUser_Enabled.Checked;
            string username = TxtAppUser_UserName.Text;
            string password = BetaEncryptation.getEncryptation().EncodePassword(TxtAppUser_Password1.Text);

            ApplicationUser user = context.ApplicationUser.FirstOrDefault(u => u.UserName == username);

            if (user != null) {
                MessageBox.Show(this, "Já existe um usuário com o nome do usuário (" + username + "), introduza outro por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtAppUser_UserName.Focus();
                return;
            }

            //context.ApplicationUser.Attach(SystemManager.CurrentUser);

            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja adicionar o usuario(" + nome + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            user = new ApplicationUser();
            user.FirstName = nome;
            user.LastName = apelido;
            user.Email = email;
            user.Enabled = enabled;
            user.UserName = username;
            user.Password = password;
            user.CreatedBy = SystemManager.GetCurrentUser(context);
            user.CreationDate = DateTime.Now;

            try {

                foreach (Role role in roles) {
                    //context.Role.Attach(role);
                    user.Roles.Add(role);
                }

                context.ApplicationUser.Add(user);
                context.SaveChanges();

                MessageBox.Show(this, "O usuário foi registado com sucesso");
                this.Close();

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Error");
                MessageBox.Show(this, "Não foi possivel gravar o usuário na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
