using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.utilities.module.General;

namespace mz.betainteractive.sigeas.Views.Empresas {
    public partial class CategoriaAdd : Form {
        private SigeasDatabaseContext context;
        private Empresa empresa;

        public CategoriaAdd(SigeasDatabaseContext context, Empresa empresa) {
            InitializeComponent();
            this.context = context;
            this.empresa = empresa;
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            AddCategoria();
        }

        private void AddCategoria() {
            if (!Validar()) {
                return;
            }

            string nome = TxtNome.Text;
            string funcoes = TxtFuncoes.Text;

            var depts = context.Categoria.Where(d => d.Nome == nome).FirstOrDefault();

            if (depts != null) {
                MessageBox.Show(this, "Ja existe uma Categoria com a mesmo (Nome) da Categoria a ser adicionado.", "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNome.Focus();
                return;
            }


            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja adicionar a Categoria(" + nome + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            Categoria categoria = new Categoria { Nome = nome, Funcoes = funcoes };
            
            categoria.CreatedBy = SystemManager.GetCurrentUser(context);
            categoria.CreationDate = DateTime.Now;

            try {
                empresa.Categorias.Add(categoria);
                context.SaveChanges();
                MessageBox.Show(this, "O Categoria foi adicionado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }catch(Exception ex){
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar adicionar a Categoria na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar adicionar a Categoria na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

        }
                       
        private bool Validar() {
            
            if (CBoxEmpresa.SelectedIndex == -1) {
                MessageBox.Show(this, "Não foi selecionada uma empresa, selecione por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBoxEmpresa.Focus();
                return false;
            }

            if (TxtNome.Text == "") {
                MessageBox.Show(this, "Introduza o nome, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
                return false;
            }

            if (TxtFuncoes.Text == "") {
                MessageBox.Show(this, "Introduza a descrição das funções desta Categoria, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtFuncoes.Focus();
                return false;
            }                                                

            return true;
        }


        private void CategoriaAdd_Load(object sender, EventArgs e) {            
            CleanAll();
            LoadEmpresa();            
        }

        private void LoadEmpresa() {
            CBoxEmpresa.Items.Clear();
            
            if (empresa != null) {
                CBoxEmpresa.Items.Add(empresa);
                CBoxEmpresa.SelectedIndex = 0;
            }
        }

        private void CleanAll() {
            TxtNome.Text = "";
            TxtFuncoes.Text = "";
            CBoxEmpresa.Items.Clear();           
        }               
        
    }
}
