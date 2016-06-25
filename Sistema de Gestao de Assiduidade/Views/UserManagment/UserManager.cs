using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.Utilities;
using System.Text.RegularExpressions;
using mz.betainteractive.encoding.encryptation;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Views.UserManagment;
using mz.betainteractive.utilities.module.Components;
using System.Globalization;
using mz.betainteractive.sigeas.Views.Main;
using mz.betainteractive.utilities.module.General;
using mz.betainteractive.utilities.module.Collections;

namespace mz.betainteractive.sigeas.Views.UserManagment {
    public partial class UserManager : Form, AuthorizableComponent {    
    
        private ApplicationUser SelectedUser;
        private List<Role> SelectedUserRoles = new List<Role>();
        private Role SelectedRole;
        private List<RolePermission> SelectedRolePermissions = new List<RolePermission>();
        private SigeasDatabaseContext context;

        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }


        public UserManager() {
            InitializeComponent();
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

        private void Btn_Close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void UserManagment_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
            DisposeContext();
        }

        private void InitializeAppUser() {
            SelectedUser = null;
            SelectedUserRoles.Clear();

            CleanAppUserForm();

            LBoxAppUser_Perfis.Items.Clear();
            ListViewAppUsers.Items.Clear();

            LoadUsersToListView();
            LoadRolesToListBox();

            BtnAppUser_NewUser.Enabled = AllowAdd;
            BtnAppUser_ChangeUser.Enabled = AllowUpdate;
            BtnRole_NewRole.Enabled = AllowAdd;

            DisableUserForm();
        }

        private void InitializeRole() {
            SelectedRole = null;
            SelectedRolePermissions.Clear();

            CleanRoleForm();

            DGViewPermissions.Rows.Clear();
            ListViewRoles.Items.Clear();

            LoadRolesToListView();            
            LoadPermissionsToGridView();
            LoadRolesToListBox();

            DisableRolesForm();
        }

        private void Initialize() {
            InitializeAppUser();
            InitializeRole();
        }

        private void DisableRolesForm() {
            GBoxRoleAdd.Enabled = false;
            BtnRole_Save.Enabled = false;
            DGViewPermissions.Enabled = false;
            BtnRole_Remove.Enabled = false;
            BtnRole_Limpar.Enabled = false;
        }

        private void DisableUserForm() {
            GBoxUsers.Enabled = false;
            BtnAppUser_Save.Enabled = false;
            BtnAppUser_Remove.Enabled = false;
            BtnAppUser_CleanForm.Enabled = false;
            BtnAppUser_ChangeUser.Enabled = false;
        }

        private void CleanRoleForm() {
            TxtRole_Name.Text = "";
            UnselectAllPermissions();
        }

        private void CleanAppUserForm() {
            TxtAppUser_Nome.Text = "";
            TxtAppUser_Apelido.Text = "";
            TxtAppUser_Email.Text = "";
            UnselectAll(LBoxAppUser_Perfis);
            LBoxAppUser_Perfis.Update();
            CBoxAppUser_Enabled.Checked = false;
            TxtAppUser_UserName.Text = "";
            TxtAppUser_Password.Text = "";
            TxtAppUser_NewPassword.Text = "";
            TxtAppUser_ConfirmPassword.Text = "";

            TxtAppUser_NewPassword.Enabled = false;
            TxtAppUser_ConfirmPassword.Enabled = false;
        }

        private void UnselectAll(CheckedListBox lb) {
            for (int i = 0; i < lb.Items.Count; i++) {
                lb.SetItemCheckState(i, CheckState.Unchecked);
            }
            lb.ClearSelected();
        }

        private void UnselectAllPermissions() {
            foreach (DataGridViewGenericRow<RolePermission> row in DGViewPermissions.Rows) {
                row.Cells[0].Value = ColSelect.FalseValue;
            }
        }

        private List<Role> GetSelectedRoles() {
            List<Role> roles = new List<Role>();

            foreach (object obj in LBoxAppUser_Perfis.CheckedItems) {
                roles.Add((Role)obj);
            }

            return roles;
        }
                
        private void LoadPermissionsToGridView() {

            DGViewPermissions.Rows.Clear();

            var roles = context.RolePermission.Where(t => t.FormCode > 0x0100).ToList();

            CultureInfo ci = new CultureInfo("en-us");


            foreach (RolePermission role in roles) {
                DataGridViewGenericRow<RolePermission> row = new DataGridViewGenericRow<RolePermission>(role);

                row.CreateCells(DGViewPermissions);

                row.Cells[0].ReadOnly = false;
                row.Cells[1].ReadOnly = true;
                row.Cells[2].ReadOnly = true;
                row.Cells[3].ReadOnly = true;

                row.Cells[0].Value = ColSelect.FalseValue;
                row.Cells[1].Value = "0x0" + role.FormCode.ToString("X", ci);

                switch (role.ActionCode) {
                    case 1: row.Cells[2].Value = "Visualizar"; break;
                    case 2: row.Cells[2].Value = "Atualizar"; break;
                    case 3: row.Cells[2].Value = "Apagar/Remover"; break;
                    case 4: row.Cells[2].Value = "Adicionar"; break;
                }

                row.Cells[3].Value = role.Name;

                DGViewPermissions.Rows.Add(row);
            }
        }

        private List<RolePermission> GetSelectedRolesPermissions() {
            List<RolePermission> roles = new List<RolePermission>();

            foreach (DataGridViewGenericRow<RolePermission> row in DGViewPermissions.Rows) {

                if (row.Cells[0].Value == ColSelect.TrueValue) {
                    roles.Add(row.Value);
                }
            }

            return roles;
        }

        private void LoadRolesToListView() {
            ListViewRoles.Clear();

            try {

                List<Role> roles = context.Role.ToList();

                if (roles.Count() == 0) {
                    return;
                }

                foreach (Role role in roles) {
                    ListViewGenericItem<Role> item = new ListViewGenericItem<Role>(role, 3);
                    ListViewRoles.Items.Add(item);
                }

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar ler perfis na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar ler perfis na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void LoadUsersToListView() {
            ListViewAppUsers.Clear();

            try {

                List<ApplicationUser> users = context.ApplicationUser.ToList();

                if (users.Count() == 0) {
                    return;
                }

                foreach (ApplicationUser user in users) {
                    ListViewGenericItem<ApplicationUser> item = new ListViewGenericItem<ApplicationUser>(user, 2);
                    ListViewAppUsers.Items.Add(item);
                }


            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar ler usuários na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar ler usuários na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAppUser_CleanForm_Click(object sender, EventArgs e) {
            CleanAppUserForm();
        }

        private void BtnRole_Limpar_Click(object sender, EventArgs e) {
            CleanRoleForm();
        }

        private void BtnAppUser_NewUser_Click(object sender, EventArgs e) {
            NewUser();
        }

        private void NewUser() {
            CleanAppUserForm();
            SelectedUser = null;
            SelectedUserRoles.Clear();

            UserAdd userAdd = new UserAdd(context);
            userAdd.ShowDialog();

            InitializeAppUser();
        }

        private void BtnRole_NewRole_Click(object sender, EventArgs e) {
            NewRole();
        }

        private void NewRole() {
            CleanRoleForm();            
            SelectedRole = null;
            SelectedRolePermissions.Clear();

            RoleAdd roleAdd = new RoleAdd(context);
            roleAdd.ShowDialog();

            InitializeRole();
        }

        private void OnSelectRole() {
            CleanRoleForm();            
            SelectedRolePermissions.Clear();

            TxtRole_Title.Text = "Visualizar/Alterar Perfil de Usuário";

            GBoxRoleAdd.Enabled = true;
            
            UnselectAllPermissions();
            DGViewPermissions.Enabled = true;

            BtnRole_Remove.Enabled = AllowDelete;
            BtnRole_Save.Enabled = AllowUpdate;

            if (ListViewRoles.SelectedItems.Count != 1) {
                return;
            }

            ListViewGenericItem<Role> item = (ListViewGenericItem<Role>)ListViewRoles.SelectedItems[0];

            Role role = item.Value;

            List<RolePermission> roles = new List<RolePermission>(role.RolePermissions);

            SelectedRole = role;
            SelectedRolePermissions.Clear();
            SelectedRolePermissions.AddRange(roles);

            TxtRole_Name.Text = role.Name;
            SelectRolePermissions(roles);
        }

        private void BtnAppUser_Save_Click(object sender, EventArgs e) {
            UpdateAppUser();
        }

        private void UpdateAppUser() {
            if (!ValidarAppUser()) {
                return;
            }

            //verificar se ja existe um usuario com nome e username igual no sistema
            string nome = TxtAppUser_Nome.Text;
            string apelido = TxtAppUser_Apelido.Text;
            string email = TxtAppUser_Email.Text;
            bool enabled = CBoxAppUser_Enabled.Checked;

            string username = TxtAppUser_UserName.Text;
            string password = BetaEncryptation.getEncryptation().EncodePassword(TxtAppUser_Password.Text);

            if (CBoxAppUser_ChangePassword.Checked) {
                password = BetaEncryptation.getEncryptation().EncodePassword(TxtAppUser_NewPassword.Text);
            }

            List<Role> listBoxSelectedRoles = GetSelectedRoles();
            List<Role> rolesToRemove = new List<Role>();
            List<Role> rolesToAdd = new List<Role>();

            //Roles to remove            
            Console.WriteLine("srs: " + SelectedUserRoles.Count);

            foreach (Role role in SelectedUserRoles) {
                if (!listBoxSelectedRoles.Contains(role)) {
                    Role r = context.Role.Find(role.Id);
                    rolesToRemove.Add(r);
                }
            }

            //Roles to Add            
            foreach (Role role in listBoxSelectedRoles) {
                if (!SelectedUserRoles.Contains(role)) {
                    rolesToAdd.Add(role);
                }
            }

            //Verificar se o UserName não existe gravado
            ApplicationUser user = context.ApplicationUser.FirstOrDefault(u => u.Id != SelectedUser.Id && u.Username == username);

            if (user != null) {
                MessageBox.Show(this, "Já existe um usuário com o nome do usuário (" + username + "), introduza outro por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtAppUser_UserName.Focus();
                return;
            }


            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja atualizar os dados do usuario(" + TxtAppUser_Nome.Text + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }


            user = SelectedUser;

            user.Firstname = nome;
            user.Lastname = apelido;
            user.Email = email;
            user.Enabled = enabled;
            user.Username = username;
            user.Password = password;
            user.UpdatedBy = SystemManager.GetCurrentUser(context);
            user.UpdatedDate = DateTime.Now;

            foreach (Role role in rolesToRemove) {
                user.Roles.Remove(role);
            }

            foreach (Role role in rolesToAdd) {
                user.Roles.Add(role);
            }

            try {
                context.SaveChanges();
                MessageBox.Show(this, "O usuário foi atualizado com sucesso");
                InitializeAppUser();
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Error");
                MessageBox.Show(this, "Não foi possivel atualizar o usuário na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            

            if (CBoxAppUser_ChangePassword.Checked == true) {
                if (TxtAppUser_Password.Text == "") {
                    MessageBox.Show(this, "Introduza a senha antiga, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtAppUser_Password.Focus();
                    return false;
                }
                if (TxtAppUser_NewPassword.Text == "") {
                    MessageBox.Show(this, "Introduza a nova senha, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtAppUser_NewPassword.Focus();
                    return false;
                }
                if (TxtAppUser_ConfirmPassword.Text == "") {
                    MessageBox.Show(this, "Confirme a nova senha, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtAppUser_ConfirmPassword.Focus();
                    return false;
                }
                if (TxtAppUser_NewPassword.Text != TxtAppUser_ConfirmPassword.Text) {
                    MessageBox.Show(this, "As senhas introduzidas são diferentes, introduza novamente", "Erro na nova senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtAppUser_ConfirmPassword.Focus();
                    return false;
                }
            }

            return true;
        }                

        private void ListViewAppUsers_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                OnSelectUser();
            }
        }

        private void OnSelectUser() {
            if (ListViewAppUsers.SelectedItems.Count != 1) {
                return;
            }

            ListViewGenericItem<ApplicationUser> item = (ListViewGenericItem<ApplicationUser>)ListViewAppUsers.SelectedItems[0];
                   
            ApplicationUser user = item.Value;

            List<Role> roles = new List<Role>(user.Roles);

            SelectedUser = user;
            SelectedUserRoles.Clear();
            SelectedUserRoles.AddRange(roles);

            TxtAppUser_Title.Text = "Dados do Usuário [" + user.ToString() + "]";

            TxtAppUser_Nome.Text = user.Firstname;
            TxtAppUser_Apelido.Text = user.Lastname;
            TxtAppUser_Email.Text = user.Email;

            SelectRoles(LBoxAppUser_Perfis, roles);

            CBoxAppUser_Enabled.Checked = user.Enabled;
            TxtAppUser_UserName.Text = user.Username;
            TxtAppUser_Password.Text = BetaEncryptation.getEncryptation().DecodePassword(user.Password);

            GBoxUsers.Enabled = true;
            BtnAppUser_Save.Enabled = false;
            BtnAppUser_Remove.Enabled = AllowDelete;//true; //true - Implementing
            BtnAppUser_CleanForm.Enabled = false;
            BtnAppUser_ChangeUser.Enabled = AllowUpdate;

            TxtAppUser_Nome.ReadOnly = true;
            TxtAppUser_Apelido.ReadOnly = true;
            TxtAppUser_Email.ReadOnly = true;

            LBoxAppUser_Perfis.SelectionMode = SelectionMode.None;

            CBoxAppUser_Enabled.Enabled = false;
            CBoxAppUser_ChangePassword.Enabled = false;
            TxtAppUser_UserName.ReadOnly = true;
            TxtAppUser_Password.ReadOnly = true;

            TxtAppUser_NewPassword.ReadOnly = true;
            TxtAppUser_ConfirmPassword.ReadOnly = true;

        }

        private void SelectRoles(CheckedListBox lbox, ICollection<Role> iCollection) {
            UnselectAll(lbox);
            for (int i = 0; i < lbox.Items.Count; i++) {
                lbox.SetItemCheckState(i, CheckState.Unchecked);

                Role roleOnBox = (Role)lbox.Items[i];

                if (iCollection.Contains(roleOnBox)) {
                    lbox.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }

        private void SelectRolePermissions(ICollection<RolePermission> iCollection) {
            
            foreach (DataGridViewGenericRow<RolePermission> row in DGViewPermissions.Rows) {
                if (iCollection.Contains(row.Value)) {
                    row.Cells[0].Value = ColSelect.TrueValue;
                } else {
                    row.Cells[0].Value = ColSelect.FalseValue;
                }
            }
        }

        private void BtnAppUser_ChangeUser_Click(object sender, EventArgs e) {
            ChangeUser();
        }

        private void ChangeUser() {
            GBoxUsers.Enabled = true;
            BtnAppUser_Save.Enabled = AllowUpdate;//true;
            BtnAppUser_Remove.Enabled = false;
            BtnAppUser_CleanForm.Enabled = false;
            BtnAppUser_ChangeUser.Enabled = false;

            TxtAppUser_Nome.ReadOnly = false;
            TxtAppUser_Apelido.ReadOnly = false;
            TxtAppUser_Email.ReadOnly = false;

            LBoxAppUser_Perfis.SelectionMode = SelectionMode.One;

            CBoxAppUser_Enabled.Enabled = true;
            CBoxAppUser_ChangePassword.Enabled = true;
            TxtAppUser_UserName.ReadOnly = false;
            TxtAppUser_Password.ReadOnly = false;


            TxtAppUser_NewPassword.Enabled = false;
            TxtAppUser_ConfirmPassword.Enabled = false;

            TxtAppUser_NewPassword.ReadOnly = false;
            TxtAppUser_ConfirmPassword.ReadOnly = false;
        }

        private void CBoxAppUser_ChangePassword_CheckedChanged(object sender, EventArgs e) {
            if (CBoxAppUser_ChangePassword.Checked) {
                TxtAppUser_Password.Text = "";
                TxtAppUser_NewPassword.Enabled = true;
                TxtAppUser_ConfirmPassword.Enabled = true;
            } else {

                TxtAppUser_Password.Text = BetaEncryptation.getEncryptation().DecodePassword(SelectedUser.Password);
                TxtAppUser_NewPassword.Text = "";
                TxtAppUser_ConfirmPassword.Text = "";

                TxtAppUser_NewPassword.Enabled = false;
                TxtAppUser_ConfirmPassword.Enabled = false;
            }
        }

        private void ListViewRoles_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                OnSelectRole();
            }
        }

        private void BtnRole_Save_Click(object sender, EventArgs e) {
            UpdateRole();
        }

        private bool ValidarRole() {

            if (TxtRole_Name.Text == "") {
                MessageBox.Show(this, "Introduza o Nome do perfil, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtRole_Name.Focus();
                return false;
            }

            if (GetSelectedRolesPermissions().Count == 0) {
                MessageBox.Show(this, "Selecione as permissões, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DGViewPermissions.Focus();
                return false;
            }

            return true;
        }

        private void UpdateRole() {
            if (!ValidarRole()) {                
                return;
            }

            Role role = context.Role.FirstOrDefault(u => u.Id != SelectedRole.Id && u.Name == TxtAppUser_Nome.Text);

            if (role != null) {
                MessageBox.Show(this, "Já existe um perfil de usuário com o nome (" + TxtRole_Name.Text + "), introduza outro por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtRole_Name.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja atualizar os dados do perfil de usuario (" + TxtRole_Name.Text + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }
            

            List<RolePermission> listBoxSelectedRoles = GetSelectedRolesPermissions();
            List<RolePermission> rolesToRemove = new List<RolePermission>();
            List<RolePermission> rolesToAdd = new List<RolePermission>();

            //Roles to remove                        
            foreach (RolePermission roleP in SelectedRolePermissions) {
                if (!listBoxSelectedRoles.Contains(roleP)) {
                    RolePermission r = context.RolePermission.Find(roleP.Id);
                    rolesToRemove.Add(r);
                }
            }

            //Roles to Add            
            foreach (RolePermission roleP in listBoxSelectedRoles) {
                if (!SelectedRolePermissions.Contains(roleP)) {
                    rolesToAdd.Add(roleP);
                }
            }
            
            role = SelectedRole;

            role.Name = TxtRole_Name.Text;

            foreach (RolePermission rolePer in rolesToRemove) {                
                role.RolePermissions.Remove(rolePer);
            }

            foreach (RolePermission rolePer in rolesToAdd) {                
                role.RolePermissions.Add(rolePer);
            }

            try {
                context.SaveChanges();
                MessageBox.Show(this, "O perfil foi atualizado com sucesso");
                InitializeRole();

                //update MainView
                UpdateMainSecurity();

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Error");
                MessageBox.Show(this, "Não foi possivel atualizar o perfil na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateMainSecurity() {
            if (this.MdiParent is MainView) {
                MainView mainView = (MainView)this.MdiParent;
                mainView.SettingSecurity();
            }
        }

        private void UserManagment_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                LoadContext();
                Initialize();
            }
        }

        private void BtnAppUser_Remove_Click(object sender, EventArgs e) {
            RemoverUser();
        }

        private void RemoverUser() {
            if (SelectedUser == null) {
                MessageBox.Show(this, "Selecione um usuário, por favor!");
                return;
            }

            if (SystemManager.CurrentUserId == SelectedUser.Id) {
                MessageBox.Show(this, "Não será possivel remover o usuário, para remover este usuário acesse o sistema apartir doutro usuário!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja remover o Usuário (" + SelectedUser.ToString() + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            try {
                context.ApplicationUser.Remove(SelectedUser);
                context.SaveChanges();
                MessageBox.Show(this, "O Usuário foi removido com sucesso!");
                InitializeAppUser();
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar remover o Usuário na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar remover o Usuário na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRole_Remove_Click(object sender, EventArgs e) {
            RemoverRoleUser();
        }

        private void RemoverRoleUser() {
            if (SelectedRole == null) {
                MessageBox.Show(this, "Selecione um perfil de usuário, por favor!");
                return;
            }

            /*
            if (SystemManager.CurrentUserId == SelectedUser.Id) {
                MessageBox.Show(this, "Não será possivel remover o usuário, para remover este usuário acesse o sistema apartir doutro usuário!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }*/

            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja remover o Perfil de Usuário (" + SelectedRole.ToString() + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            try {
                context.Role.Remove(SelectedRole);
                context.SaveChanges();
                MessageBox.Show(this, "O Perfil de Usuário foi removido com sucesso!");
                InitializeAppUser();
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar remover o Perfil de Usuário na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar remover o Perfil de Usuário na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
