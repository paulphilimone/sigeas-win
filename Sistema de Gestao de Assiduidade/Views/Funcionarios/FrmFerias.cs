using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.model.ca;
using mz.betainteractive.sigeas.utilities;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.sigeas.Utilities.Components;

namespace mz.betainteractive.sigeas.Views.Funcionarios {
    public partial class FrmFerias : Form, AuthorizableComponent {
        private SigeasDatabaseContext context;

        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }

        public FrmFerias() {
            InitializeComponent();
        }

        private void Initialize() {            
            LoadDepartamentos();
            LoadCategorias();
            LimparLista();
        }

        private void DisposeContext() {
            if (context != null) {
                context.Dispose();
                context = null;                
                CleanAll();
            }
        }                

        private void LoadContext() {
            if (context == null) {
                context = new SigeasDatabaseContext();
            }                        
        }

        private void FrmFerias_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                LoadContext();
                Initialize();
            }
        }

        private void FrmFerias_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
            DisposeContext();
        }

        private void btFechar_Click(object sender, EventArgs e) {
            this.Close();
        }
        
        public void LoadCategorias() {
            DBSearch.FillCategoria(context, CBoxCategoria, false);
        }

        public void LoadDepartamentos() {
            DBSearch.FillDepartamento(context, CBoxDepartamento, false);
        }

        private void FindFuncionario() {
            Departamento depart = null;
            Categoria categoria = null;

            if (CBoxDepartamento.SelectedIndex != -1) {
                depart = (Departamento)CBoxDepartamento.SelectedItem;
            }
            if (CBoxCategoria.SelectedIndex != -1) {
                categoria = (Categoria)CBoxCategoria.SelectedItem;
            }

            CBoxFuncionario.Items.Clear();
            CBoxFuncionario.ResetText();

            if (depart == null && categoria == null) {
                return;
            }

            if (depart == null) {
                List<Funcionario> funs = context.Funcionario.Where(t => t.Categoria.Id == categoria.Id).ToList();
                FillFuncionario(funs);
                return;
            }
            if (categoria == null) {
                List<Funcionario> funs = context.Funcionario.Where(t => t.Departamento.Id == depart.Id).ToList();
                FillFuncionario(funs);
                return;
            }

            List<Funcionario> funcs = DBSearch.FindAllFuncionarioBy(context, depart, categoria);
            FillFuncionario(funcs);

        }

        private void FillFuncionario(List<Funcionario> funs) {
            CBoxFuncionario.Items.Clear();
            CBoxFuncionario.ResetText();
            CBoxFuncionario.Items.AddRange(funs.ToArray());
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e) {
            FindFuncionario();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e) {
            FindFuncionario();
        }

        private void cboFuncionario_SelectedIndexChanged(object sender, EventArgs e) {
            if (CBoxFuncionario.SelectedIndex != -1) {
                if (CBoxFuncionario.SelectedItem is Funcionario) {
                    btViewList.Enabled = true;
                }
            } else {
                btViewList.Enabled = false;
            }
        }

        private void btLimpar_Click(object sender, EventArgs e) {
            LimparLista();
        }

        private void CleanAll() {
            LimparLista();
        }

        private void LimparLista() {
            txtFuncionario.Text = "";
            listViewFerias.Items.Clear();
        }

        private void btViewList_Click(object sender, EventArgs e) {
            LoadFerias();
        }

        private void LoadFerias() {
            if (CBoxFuncionario.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o funcionário primeiro");
                return;
            }

            if (CBoxFuncionario.SelectedItem is Funcionario) {
                Funcionario func = (Funcionario) CBoxFuncionario.SelectedItem;

                List<Ferias> ferias = context.Ferias.Where(t => t.Funcionario.Id == func.Id).ToList();

                txtFuncionario.Text = func.ToString();
                listViewFerias.Items.Clear();

                foreach (Ferias f in ferias) {
                    ListViewItemFerias item = new ListViewItemFerias(f);
                    listViewFerias.Items.Add(item);
                }

            }
        }

        private void btGravar_Click(object sender, EventArgs e) {
            GravarFerias();
        }

        private void GravarFerias() {
            if (!ValidarFerias()) {
                return;
            }

            DialogResult dr = MessageBox.Show("Tem certeza que deseja atribuir férias a este funcionário", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }
                                    
            Funcionario funcionario = (Funcionario)CBoxFuncionario.SelectedItem;

            Ferias ferias = new Ferias();

            ferias.Funcionario = funcionario;
            ferias.DataInicial = dtpInicio.Value;
            ferias.DataFinal = dtpFim.Value;

            try{
                context.Ferias.Add(ferias);
                context.SaveChanges();
                MessageBox.Show("As férias foram atribuidas com sucesso");
                LoadFerias();

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar registar as férias na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar registar as férias na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidarFerias() {
            if (CBoxFuncionario.SelectedIndex == -1) {
                MessageBox.Show("Selecione o funcionario primeiro");
                return false;
            }

            DateTime dti = dtpInicio.Value;
            DateTime dtf = dtpFim.Value;

            DateTime dtInicial = new DateTime(dti.Year, dti.Month, dti.Day);
            DateTime dtFinal = new DateTime(dtf.Year, dtf.Month, dtf.Day);

            if (dtInicial.CompareTo(dtFinal) >= 0) {
                MessageBox.Show("A data do inicio das férias não pode ser maior ou igual a data do fim");
                return false;
            }

            Funcionario funcionario = (Funcionario)CBoxFuncionario.SelectedItem;                        
            
            if (DBSearch.OnVacation(context, funcionario, dtInicial)) {
                MessageBox.Show("Já existe um periodo de férias em que a data inicial está abrangida!\nNB: Introduza periodos de férias diferentes dos existentes", "Data inicial incorrecta");
                return true;
            }
            if (DBSearch.OnVacation(context, funcionario, dtFinal)) {
                MessageBox.Show("Já existe um periodo de férias em que a data final está abrangida!\nNB: Introduza periodos de férias diferentes dos existentes", "Data final incorrecta");
                return true;
            }

            return true;
        }

        private void btRemover_Click(object sender, EventArgs e) {
            RemoverFerias();
        }

        private void RemoverFerias() {
            if (listViewFerias.SelectedIndices.Count == 0) {
                MessageBox.Show(this, "Selecione as férias");
                return;
            }

            Ferias ferias = null;
            
            if (listViewFerias.SelectedItems[0] is ListViewItemFerias) {
                ListViewItemFerias item = (ListViewItemFerias)listViewFerias.SelectedItems[0];
                ferias = item.Value;
            }

            if (ferias == null) {
                MessageBox.Show(this, "Selecione as férias!");
                return;
            }

            DialogResult dr = MessageBox.Show("Tem certeza que deseja remover o periodo de férias selecionado", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            try{
                context.Ferias.Remove(ferias);
                context.SaveChanges();
                MessageBox.Show("O periodo de férias foi removido com sucesso!");
                LoadFerias();
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar remover o periodo de férias na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar remover o periodo de férias na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
