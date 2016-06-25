using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.model.ca;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.utilities.module.Components;
using mz.betainteractive.utilities.module.General;
using mz.betainteractive.sigeas.utilities;

namespace mz.betainteractive.sigeas.Views.Empresas {
    public partial class FrmFeriados : Form, AuthorizableComponent {
        private Feriado SelectedFeriado;
        private SigeasDatabaseContext context;

        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }

        public FrmFeriados() {
            InitializeComponent();
        }

        private void Initialize() {
            CleanAll();
            LoadFeriados();            
        }

        private void DisposeContext() {
            if (context != null) {
                context.Dispose();
                context = null;
                SelectedFeriado = null;
                CleanAll();
            }
        }

        private void LoadContext() {
            if (context == null) {
                context = new SigeasDatabaseContext();
            }

            SelectedFeriado = null;            
        }

        private void FrmFeriados_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
            DisposeContext();
        }

        private void FrmFeriados_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {                
                LoadContext();
                Initialize();
            }
        }

        private void btLimpar_Click(object sender, EventArgs e) {
            Limpar();
        }

        private void Limpar() {
            SelectedFeriado = null;
            txtNome.Text = "";
            dtpData.Value = DateTime.Today;
            btUpdate.Enabled = false;
            btRemover.Enabled = false;
        }

        private void CleanAll() {
            Limpar();
            listViewFeriados.Items.Clear();
        }

        private void txtNome_TextChanged(object sender, EventArgs e) {
            if (SelectedFeriado == null) {
                btGravar.Enabled = txtNome.Text.Length > 0;
            } else {
                btUpdate.Enabled = txtNome.Text.Length > 0;
            }
        }
                
        private void LoadFeriados() {
            List<Feriado> frs = context.Feriado.ToList();

            listViewFeriados.Items.Clear();

            foreach (Feriado fe in frs){
                ListViewItemFeriado item = new ListViewItemFeriado(fe);
                listViewFeriados.Items.Add(item);
            }
        }

        private void listViewFeriados_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                if (listViewFeriados.SelectedItems.Count == 1) {
                    ListViewItemFeriado item = (ListViewItemFeriado)listViewFeriados.SelectedItems[0];
                    EditFeriado(item.Value);
                }
            }
        }

        private void EditFeriado(Feriado feriado) {
            btGravar.Enabled = false;
            btUpdate.Enabled = true;
            btRemover.Enabled = true;

            SelectedFeriado = feriado;
            txtNome.Text = feriado.Nome;
            dtpData.Value = feriado.Data;
        }

        private void btGravar_Click(object sender, EventArgs e) {
            GravarFeriado();
        }

        private void GravarFeriado() {

            if (feriadoExists(dtpData.Value)) {
                MessageBox.Show("Já existe um feriado registado nesta data");
                return;
            }

            DialogResult dr = MessageBox.Show("Tem certeza que deseja registar este feriado", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }
                        

            Feriado feriado = new Feriado();
            feriado.Nome = txtNome.Text;
            feriado.Data = dtpData.Value;

            try{    
                context.Feriado.Add(feriado);
                context.SaveChanges();

                MessageBox.Show(this, "Feriado foi registado com sucesso!");
                Limpar();
                LoadFeriados();

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar registar o feriado na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar registar o feriado na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
        }

        private bool feriadoExists(DateTime data) {
            
            int d = data.Day;
            int m = data.Month;
            int y = data.Year;

            var feriado = context.Feriado.Where(t => t.Data.Month == m && t.Data.Day == d).FirstOrDefault();

            if (feriado != null) {
                return true;
            }

            return false;
        }

        private void btUpdate_Click(object sender, EventArgs e) {
            UpdateFeriado();
        }

        private void RemoverFeriado() {
            if (SelectedFeriado == null) {
                MessageBox.Show("Selecione o feriado primeiro");
                return;
            }

            DialogResult dr = MessageBox.Show("Tem certeza que deseja remover este feriado", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }                        

            Feriado feriado = SelectedFeriado;

            context.Feriado.Remove(feriado);

            try {
                context.SaveChanges();

                MessageBox.Show(this, "O feriado foi actualizado com sucesso!");
                Limpar();
                LoadFeriados();
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar remover o feriado da base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar remover o feriado da base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateFeriado() {
            if (SelectedFeriado == null) {
                MessageBox.Show(this, "Selecione o feriado primeiro");
                return;
            }

            DialogResult dr = MessageBox.Show("Tem certeza que deseja actualizar este feriado", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }                      

            Feriado feriado = SelectedFeriado;

            feriado.Nome = txtNome.Text;
            feriado.Data = dtpData.Value;

            try{
                
                context.SaveChanges();

                MessageBox.Show("O feriado foi actualizado com sucesso");
                Limpar();
                LoadFeriados();

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar atualizar o feriado na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar atualizar o feriado na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
        }

        private void btFechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btRemover_Click(object sender, EventArgs e) {
            RemoverFeriado();
        }

        
                
    }
}
