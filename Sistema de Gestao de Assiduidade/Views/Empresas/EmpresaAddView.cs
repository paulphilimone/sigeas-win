using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.model.ca;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Utilities;

namespace mz.betainteractive.sigeas.Views.Empresas {

    public partial class EmpresaAddView : Form {
        private SigeasDatabaseContext context;

        public EmpresaAddView() {
            InitializeComponent();
        }

        private void DisposeContext() {
            if (context != null) {
                context.Dispose();
                context = null;
                LimparForm();
            }
        }

        private void LoadContext() {
            if (context == null) {
                context = new SigeasDatabaseContext();
            }
                     
        }

        private void Initialize() {
            LimparForm();
            FillCombos();            
        }

        private void LimparForm() {
            txtNomeEmpresa.Text = "";
            cboProvincia.Items.Clear();
            cboProvincia.ResetText();
            cboDistrito.Items.Clear();
            cboDistrito.ResetText();
            cboPostoAdministrativo.Items.Clear();
            cboPostoAdministrativo.ResetText();
            cboLocalidade.Items.Clear();
            cboLocalidade.ResetText();
            txtAvenidaRua.Text = "";
            txtNumero.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtFax.Text = "";
        }

        private void EmpresaAddView_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                Console.WriteLine("Running");
                LoadContext();
                Initialize();
            }
        }

        private void EmpresaAddView_FormClosing(object sender, FormClosingEventArgs e) {
            //e.Cancel = true;
            //this.Hide();
            DisposeContext();
        }
                
        private void FillCombos() {
            cboProvincia.Items.Clear();
            cboDistrito.Items.Clear();
            cboPostoAdministrativo.Items.Clear();
            cboLocalidade.Items.Clear();
            DBSearch.FillProvincia(context, cboProvincia);
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e) {
            DBSearch.OnSelectedProvincia(cboProvincia, cboDistrito, cboPostoAdministrativo, cboLocalidade);
        }

        private void cboDistrito_SelectedIndexChanged(object sender, EventArgs e) {
            DBSearch.OnSelectedDistrito(cboDistrito, cboPostoAdministrativo, cboLocalidade);
        }

        private void cboPostoAdministrativo_SelectedIndexChanged(object sender, EventArgs e) {
            DBSearch.OnSelectedPostoAdministrativo(cboPostoAdministrativo, cboLocalidade);
        }

        private void btGravar_Click(object sender, EventArgs e) {
            if (Validar()) {
                Gravar();
            }
        }

        private bool Validar() {
            if (txtNomeEmpresa.Text == "") {
                MessageBox.Show("Introduza o nome da empresa primeiro!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeEmpresa.Focus();
                return false;
            }

            if (txtNumero.Text.Length > 0) {
                try {
                    Convert.ToInt32(txtNumero.Text);
                } catch (Exception ex) {
                    MessageBox.Show("Introduza o número da casa correctamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumero.Focus();
                    return false;
                }
            }

            return true;
        }

        private void Gravar() {
            
            Empresa empresa = null;
            bool firstTime = true;

            if (context != null) {
                empresa = context.Empresa.FirstOrDefault();
                firstTime = false;
            }

            DialogResult dr = MessageBox.Show("Tem certeza que deseja gravar os dados da empresa?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            if (empresa == null) {
                empresa = new Empresa();
                empresa.CreatedBy = SystemManager.GetCurrentUser(context);
                empresa.CreationDate = DateTime.Now;
            }

            //get rules

            empresa.Nome = txtNomeEmpresa.Text;

            if (cboProvincia.SelectedIndex != -1) {
                Provincia prov = (Provincia)cboProvincia.SelectedItem;
                empresa.Provincia = prov;
            }
            if (cboDistrito.SelectedIndex != -1) {
                Distrito dist = (Distrito)cboDistrito.SelectedItem;
                empresa.Distrito = dist;
            }
            if (cboPostoAdministrativo.SelectedIndex != -1) {
                PostoAdministrativo posto = (PostoAdministrativo)cboPostoAdministrativo.SelectedItem;
                empresa.PostoAdministrativo = posto;
            }
            if (cboLocalidade.SelectedIndex != -1) {
                Localidade local = (Localidade)cboLocalidade.SelectedItem;
                empresa.Localidade = local;
            }

            empresa.AvenidaRua = txtAvenidaRua.Text;

            if (txtNumero.Text.Length != 0) {
                empresa.Numero = Convert.ToInt32(txtNumero.Text);
            }


            empresa.Email = txtEmail.Text;
            empresa.Telefone = txtTelefone.Text;
            empresa.Fax = txtFax.Text;
            empresa.UpdatedBy = SystemManager.GetCurrentUser(context);
            empresa.UpdatedDate = DateTime.Now;

            empresa.AttendanceRules = DefaulRules();
            

            try {

                context.Empresa.Add(empresa);
                context.SaveChanges();
                MessageBox.Show("Os dados da empresa foram registrados com sucesso");
                LimparForm();
                this.Close();
                            
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar registrar os dados da empresa na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar registrar os dados da empresa na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private AttendanceRules DefaulRules() {
            AttendanceRules rules = new AttendanceRules();
            rules.CountHorasExtrasAfter = 20;
            rules.CountAtrasoAfter = 15;
            rules.MinIfNoClockIn = 60;
            rules.MinIfNoClockOut = 60;
            rules.IsClockingOverHorarioDia = false;

            return rules;
        }

        private void btFechar_Click(object sender, EventArgs e) {
            this.Close();
        }
        
    }
}
