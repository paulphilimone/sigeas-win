using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Utilities;
using System.Globalization;

namespace mz.betainteractive.sigeas.Views.UserManagment {
    public partial class RoleAdd : Form {
        private SigeasDatabaseContext context;

        public RoleAdd(SigeasDatabaseContext context) {
            InitializeComponent();

            this.context = context;

            Initialize();
        }

        private void Initialize() {        
            LoadPermissionsToGridView();
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
                row.Cells[1].Value = "0x0"+role.FormCode.ToString("X", ci);

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
                                
                if (row.Cells[0].Value == ColSelect.TrueValue){
                    roles.Add( row.Value );
                }
            }

            return roles;
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

        private void BtnRole_Add_Click(object sender, EventArgs e) {            
            SaveRole();
        }

        private void SaveRole() {

            if (!ValidarRole()) {
                return;
            }

            Role role = context.Role.FirstOrDefault(u => u.Name == TxtRole_Name.Text);
            List<RolePermission> permissions = GetSelectedRolesPermissions();

            if (role != null) {
                MessageBox.Show(this, "Já existe um perfil de usuário com o nome (" + TxtRole_Name.Text + "), introduza outro por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtRole_Name.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja adicionar o perfil(" + TxtRole_Name.Text + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            try {

                role = new Role { Name = TxtRole_Name.Text };

                foreach (RolePermission rolePermission in permissions){
                    role.RolePermissions.Add(rolePermission);
                }
                
                context.Role.Add(role);

                context.SaveChanges();
                
                MessageBox.Show(this, "O perfil de usuário foi registado com sucesso");

                this.Close();

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Error");
                MessageBox.Show(this, "Não foi possivel gravar o perfil de usuário na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
