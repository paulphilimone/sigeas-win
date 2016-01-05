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
using mz.betainteractive.sigeas.Utilities.Components;

namespace mz.betainteractive.sigeas.Views.DeviceManagement {
    public partial class LocalAdd : Form {
        private SigeasDatabaseContext context;

        public LocalAdd() {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            AddLocal();
        }

        private void AddLocal() {
            if (!Validar()) {
                return;
            }

            string nome = TxtNome.Text;
            string endereco = TxtEndereco.Text;                        
            string descricao = TxtDescricao.Text;
            Device device = (Device)CBoxDevices.SelectedItem;
            Parceiro parceiro = CBoxParceiros.SelectedItem as Parceiro;
            LocalCategoria categoria = CBoxCategorias.SelectedItem as LocalCategoria;

            DialogResult dr = MessageBox.Show(this, "Tem certeza que deseja adicionar o Local(" + nome + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            Local local = new Local();
            local.Nome = nome;
            local.Endereco = endereco;                        
            local.Descricao = descricao;
            local.RegisteredDevice = device;
            local.Proprietario = parceiro;
            local.Categoria = categoria;
            local.CreatedBy = SystemManager.GetCurrentUser(context);
            local.CreationDate = DateTime.Now;

            try {
                context.Locais.Add(local);
                context.SaveChanges();
                MessageBox.Show(this, "O Local foi adicionado com sucesso");
                this.Close();

            }catch(Exception ex){
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar adicionar o Local base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar adicionar o Local na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

        }

        private void LoadDevices() {
            var devices = context.Device.Where(d => d.RegisteredAutoCarro == null && d.RegisteredLocal == null);

            CBoxDevices.Items.Clear();

            foreach (Device dev in devices) {
                CBoxDevices.Items.Add(dev);
            }
        }

        private void LoadParceiros() {
            var parceiros = context.Parceiros.ToList();

            CBoxParceiros.Items.Clear();

            foreach (var par in parceiros) {
                CBoxParceiros.Items.Add(par);
            }
        }

        private void LoadCategorias() {
            var categorias = context.LocalCategoria.ToList();

            CBoxCategorias.Items.Clear();

            foreach (var categ in categorias) {
                CBoxCategorias.Items.Add(categ);
            }
        }

        private bool Validar() {
            if (CBoxParceiros.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione o proprietário do Local, por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBoxParceiros.Focus();
                return false;
            }

            if (TxtNome.Text == "") {
                MessageBox.Show(this, "Introduza o nome do local, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
                return false;
            }

            if (CBoxCategorias.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione a categoria do Local, por favor!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBoxCategorias.Focus();
                return false;
            }

            if (TxtEndereco.Text == "") {
                MessageBox.Show(this, "Introduza o endereço do local, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEndereco.Focus();
                return false;
            }
            
            /*
            if (TxtDescricao.Text == "") {
                MessageBox.Show(this, "Introduza o nome, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDescricao.Focus();
                return false;
            }*/

            if (CBoxDevices.SelectedIndex == -1) {
                MessageBox.Show(this, "Selecione um dispositivo biométrico ou clique em (Adicionar biometrico) para adicionar um dispositivo!, por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBoxDevices.Focus();
                return false;
            }

            return true;
        }

        private void BtnAddDevice_Click(object sender, EventArgs e) {
            OpenAddDevice();
        }

        private void OpenAddDevice() {
            DeviceAdd deviceAdd = new DeviceAdd();
            deviceAdd.ShowDialog(this);
            LoadDevices();
        }

        private void LocalAdd_Load(object sender, EventArgs e) {
            context = new SigeasDatabaseContext();
            LoadDevices();
            LoadParceiros();
            LoadCategorias();
        }

        private void LocalAdd_FormClosed(object sender, FormClosedEventArgs e) {
            context.Dispose();
            context = null;
        }
        
    }
}
