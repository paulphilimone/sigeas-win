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
using mz.betainteractive.sigeas.Views.Empresas;

namespace mz.betainteractive.sigeas.Views.Main {
    public partial class SelectEmpresaView : Form {
        private SigeasDatabaseContext context;
        private bool hasUsedSelectButton;
        public bool LOG_OFF_USER = false;
        public bool autoChoose = true;

        public SelectEmpresaView() {
            InitializeComponent();
        }

        private void LoadContext() {
            if (context == null) {
                context = new SigeasDatabaseContext();
            }

            hasUsedSelectButton = false;
        }

        private void DisposeContext() {
            if (context != null) {
                context.Dispose();
                context = null;
                hasUsedSelectButton = false;
                this.CBoxEmpresas.Items.Clear();
            }
        } 

        private void Initialize() {
            LoadEmpresasToComboBox();

            if (autoChoose) {
                OnSelectEmpresa();
            }
        }

        private void LoadEmpresasToComboBox() {
            var empresas = context.Empresa.ToList();

            this.CBoxEmpresas.Items.Clear();
            this.BtnAddEmpresa.Enabled = (empresas.Count == 0);

            foreach (var emp in empresas) {
                this.CBoxEmpresas.Items.Add(emp);
            }

            if (empresas.Count > 0) {
                this.CBoxEmpresas.SelectedIndex = 0;
            }
        }

        private void SelectEmpresaView_Load(object sender, EventArgs e) {
            LoadContext();
            Initialize();
        }

        private void BtnSelect_Click(object sender, EventArgs e) {
            OnSelectEmpresa();
        }

        private void OnSelectEmpresa() {

            if (CBoxEmpresas.SelectedIndex == -1) {
                MessageBox.Show("Selecione a empresa primeiro!","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBoxEmpresas.Focus();
                return;
            }

            Empresa empresa = CBoxEmpresas.SelectedItem as Empresa;

            if (empresa == null) {
                MessageBox.Show("Selecione a empresa primeiro!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBoxEmpresas.Focus();
                return;
            }

            SystemManager.CurrentEmpresaId = empresa.Id;
            hasUsedSelectButton = true;
            LOG_OFF_USER = false;
            this.Close();
        }

        private void SelectEmpresaView_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                hasUsedSelectButton = false;
            }
        }

        private void SelectEmpresaView_FormClosing(object sender, FormClosingEventArgs e) {

            if (hasUsedSelectButton == false) {
                e.Cancel = true;                
                return;
            }
            
            DisposeContext();
            //this.Dispose();            
        }

        private void BtnAddEmpresa_Click(object sender, EventArgs e) {
            AddEmpresa();
        }

        private void AddEmpresa() {
            if (CBoxEmpresas.Items.Count > 0) {
                MessageBox.Show("Já existem empresas registadas no sistema, selecione uma, por favor!","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BtnAddEmpresa.Enabled = false;
                return;
            }

            EmpresaAddView empresaAdd = new EmpresaAddView();
            empresaAdd.ShowDialog();
            Initialize();
        }

        private void BtnExit_Click(object sender, EventArgs e) {
            LOG_OFF_USER = true;
            this.Dispose();
        }

    }
}
