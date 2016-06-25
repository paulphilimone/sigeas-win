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
    public partial class DepartamentoAdd : Form {
        private SigeasDatabaseContext context;
        private Empresa empresa;

        public DepartamentoAdd(SigeasDatabaseContext context, Empresa empresa) {
            InitializeComponent();
            this.context = context;
            this.empresa = empresa;
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            AddDepartamento();
        }

        private void AddDepartamento() {
            if (!Validar()) {
                return;
            }

            string nome = TxtNome.Text;
            string descricao = TxtDescricao.Text;

            var depts = context.Departamento.Where(d => d.Nome == nome).FirstOrDefault();

            if (depts != null) {
                MessageBox.Show(this, "Ja existe um departamento com a mesmo (Nome) do departamento a ser adicionado.", "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNome.Focus();
                return;
            }

            
            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja adicionar o Departamento(" + nome + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            Departamento departamento = new Departamento { Nome = nome, Descricao = descricao };
            
            departamento.CreatedBy = SystemManager.GetCurrentUser(context);
            departamento.CreationDate = DateTime.Now;

            try {
                empresa.Departamentos.Add(departamento);


                context.SaveChanges();
                MessageBox.Show(this, "O departamento foi adicionado com sucesso");
                this.Close();

            }catch(Exception ex){
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar adicionar a departamento na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar adicionar a departamento na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);                
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

            if (TxtDescricao.Text == "") {
                MessageBox.Show(this, "Introduza a descrição deste departamento, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDescricao.Focus();
                return false;
            }                                                

            return true;
        }


        private void DepartamentoAdd_Load(object sender, EventArgs e) {            
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
            TxtDescricao.Text = "";
            CBoxEmpresa.Items.Clear();           
        }               
        
    }
}
