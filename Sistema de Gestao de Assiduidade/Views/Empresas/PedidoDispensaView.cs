using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.utilities.module.Components;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.settings;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.utilities.module.General;
using mz.betainteractive.utilities.module.Collections;

namespace mz.betainteractive.sigeas.Views.Empresas {
    public partial class PedidoDispensaView : Form, AuthorizableComponent {

        private SigeasDatabaseContext context;
                       
        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }

        private Ausencia selectedAusencia;
        
        public PedidoDispensaView() {
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

        private void Initialize() {
            CleanAll();
            LoadFuncionariosToComboBox(cboFuncionarios);
            LoadFuncionariosToComboBox(cboSearchFuncionarios);
            LoadTipoAusencias();
            lvAusencias.Items.Clear();
            selectedAusencia = null;
        }

        private void CleanAll() {
            CleanFormPDispensa();
        }        

        private void LoadFuncionariosToComboBox(ComboBox comboBox) {
            comboBox.Items.Clear();
            var funcionarios = context.Funcionario.ToList();
            comboBox.Items.AddRange(funcionarios.ToArray());
        }

        private void LoadTipoAusencias() {
            cboTipoAusencias.Items.Clear();
            var ausencias = context.TipoAusencia.ToList();
            cboTipoAusencias.Items.AddRange(ausencias.ToArray());
        }

        private void LoadListAusencias(List<Ausencia> ausencias) {            
            lvAusencias.Items.Clear();
            
            foreach (var a in ausencias){
                ListViewGenericItem<Ausencia> item = new ListViewGenericItem<Ausencia>(a);
                item.Text = a.ToString();
                item.ImageIndex = 0;
                lvAusencias.Items.Add(item);
            }

        }

        private void SelectAusencia(Ausencia ausencia) {
            if (ausencia == null) return;

            CleanFormPDispensa();

            this.selectedAusencia = ausencia;
                        
            cboFuncionarios.SelectedItem = selectedAusencia.Funcionario;
            cboTipoAusencias.SelectedItem = selectedAusencia.Tipo;
            dtpFromDate.Value = selectedAusencia.DataInicial;
            dtpFromTime.Value = selectedAusencia.DataInicial;
            dtpToDate.Value = selectedAusencia.DataFinal;
            dtpToTime.Value = selectedAusencia.DataFinal;
            txtMotivo.Text = selectedAusencia.Motivo;
            chkJustificada.Checked = selectedAusencia.Justificada;
                        
            btSave.Text = "Atualizar";
            cboFuncionarios.Enabled = false;
        }

        private void CleanFormPDispensa() {
            cboFuncionarios.SelectedIndex = -1;
            cboTipoAusencias.SelectedIndex = -1;
            dtpFromDate.Value = DateTime.Now;
            dtpToDate.Value = DateTime.Now;
            dtpFromTime.Value = Constants.GetMinTime();
            dtpToTime.Value = Constants.GetMaxTime();
            txtMotivo.Text = "";
            chkJustificada.Checked = false;
                        
            btSave.Text = "Registar";
            cboFuncionarios.Enabled = true;

            this.selectedAusencia = null;
        }

        private bool ValidatePedidoDispensa() {
            if (cboFuncionarios.SelectedIndex == -1) {
                MessageBox.Show("Selecione um funcionario primeiro!");
                cboFuncionarios.Focus();
                return false;
            }
            if (cboTipoAusencias.SelectedIndex == -1) {
                MessageBox.Show("Selecione o tipo de falta/ausencia!");
                cboTipoAusencias.Focus();
                return false;
            }
            if (dtpToDate.Value < dtpFromDate.Value) {
                MessageBox.Show("A data final não pode ser menor que a data inicial");
                dtpFromDate.Focus();
                return false;
            }
            if (dtpFromDate.Value.Date == dtpToDate.Value.Date && dtpToTime.Value < dtpFromTime.Value) {
                MessageBox.Show("A data final não pode ser menor que a data inicial, altere as horas");
                dtpFromTime.Focus();
                return false;
            }
            if (txtMotivo.Text.Length == 0) {
                MessageBox.Show("Descreva o motivo da falta a ser registada");
                txtMotivo.Focus();
                return false;
            }

            return true;
        }

        private bool CanSaveAusencia(Funcionario funcionario, DateTime fromDate, DateTime toDate) {

            //deve ter horario nas datas definidas

            //nao pode estar de ferias nas datas definadas

            return true;
        }

        private void SaveAusencia() {

            if (!ValidatePedidoDispensa()) {
                return;
            }

            Funcionario funcionario = cboFuncionarios.SelectedItem as Funcionario;
            TipoAusencia tipo = cboTipoAusencias.SelectedItem as TipoAusencia;
            string motivo = txtMotivo.Text;
            bool justificada = chkJustificada.Checked;
            DateTime fromDate = Constants.GetTime(dtpFromDate.Value, dtpFromTime.Value);
            DateTime toDate = Constants.GetTime(dtpToDate.Value, dtpToTime.Value);

            if (fromDate != toDate) {
                fromDate = fromDate.Date;
                toDate = toDate.Date;
            }

            DateTime frDt = Constants.GetTime(fromDate, 0, 0, 0);
            DateTime toDt = Constants.GetTime(toDate, 23, 59, 59);

            var exists = context.Ausencia.Where(t => t.Funcionario.Id == funcionario.Id && (t.DataInicial >= frDt && t.DataInicial <= toDt) || (t.DataFinal >= frDt && t.DataFinal <= toDt)).FirstOrDefault();

            if (exists != null) {
                MessageBox.Show("Ja existe um pedido de dispensa/ausencia registado entre as datas introduzidas");
                return;
            }


            DialogResult dr = MessageBox.Show("Tem certeza que deseja registar o pedido de dispensa  para(" + funcionario.ToString() + " )?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }


            Ausencia ausencia = new Ausencia();
            ausencia.Funcionario = funcionario;
            ausencia.Tipo = tipo;
            ausencia.DataInicial = fromDate;
            ausencia.DataFinal = toDate;
            ausencia.Motivo = motivo;
            ausencia.Justificada = justificada;

            context.Ausencia.Add(ausencia);

            try {
                context.SaveChanges();

                MessageBox.Show("O pedido de dispensa foi registado com sucesso");
                LoadListAusencias(new List<Ausencia>() { ausencia });
                CleanFormPDispensa();
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar registar o pedido de dispensa");
                MessageBox.Show(this, "Ocorreu erro ao tentar registar o pedido de dispensa.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateAusencia() {

            if (!ValidatePedidoDispensa()) {
                return;
            }
                        
            TipoAusencia tipo = cboTipoAusencias.SelectedItem as TipoAusencia;
            string motivo = txtMotivo.Text;
            bool justificada = chkJustificada.Checked;
            DateTime fromDate = Constants.GetTime(dtpFromDate.Value, dtpFromTime.Value);
            DateTime toDate = Constants.GetTime(dtpToDate.Value, dtpToTime.Value);

            if (fromDate != toDate) {
                fromDate = fromDate.Date;
                toDate = toDate.Date;
            }
            
            DialogResult dr = MessageBox.Show("Tem certeza que deseja atualizar o pedido de dispensa do/a (" + selectedAusencia.ToString() + " )?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }


            Ausencia ausencia = selectedAusencia;            
            ausencia.Tipo = tipo;
            ausencia.DataInicial = fromDate;
            ausencia.DataFinal = toDate;
            ausencia.Motivo = motivo;
            ausencia.Justificada = justificada;                       

            try {
                context.SaveChanges();

                MessageBox.Show("O pedido de dispensa foi atualizado com sucesso");
                LoadListAusencias(new List<Ausencia>() { ausencia });
                CleanFormPDispensa();
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar atualizar o pedido de dispensa");
                MessageBox.Show(this, "Ocorreu erro ao tentar atualizar o pedido de dispensa.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void OnTipoAusenciaChanged() {
            var tipoAusencia = cboTipoAusencias.SelectedItem as TipoAusencia;

            if (tipoAusencia != null) { 
                string m = tipoAusencia.Nome;
                if (m.Equals(TipoAusencia.CASAMENTO) || m.Equals(TipoAusencia.DOENCA_ACIDENTE) || m.Equals(TipoAusencia.FALECIMENTO) || m.Equals(TipoAusencia.FALECIMENTO_2)) {
                    chkJustificada.Checked = true;
                }
            }
        }

        private void SearchAusencias() {
            var funcionario = cboSearchFuncionarios.SelectedItem as Funcionario;
            var fromDate = dtpSearchFromDate.Value.Date;
            var toDate = dtpSearchToDate.Value.Date;

            List<Ausencia> ausencias = new List<Ausencia>();

            if (funcionario == null) {
                ausencias = context.Ausencia.Where(t => (t.DataInicial >= fromDate && t.DataInicial <= toDate) || (t.DataFinal >= fromDate && t.DataFinal <= toDate)).ToList();
            } else {
                ausencias = context.Ausencia.Where(t => t.Funcionario.Id == funcionario.Id && (t.DataInicial >= fromDate && t.DataInicial <= toDate) || (t.DataFinal >= fromDate && t.DataFinal <= toDate)).ToList();
            }

            LoadListAusencias(ausencias);
            
        }   

        private void PedidoDispensaView_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                Console.WriteLine("Running");
                LoadContext();
                Initialize();
            }
        }

        private void PedidoDispensaView_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
            DisposeContext();
        }

        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e) {
            if (selectedAusencia == null) {
                SaveAusencia();
            } else {
                UpdateAusencia();
            }
        }

        private void cboTipoAusencias_SelectedIndexChanged(object sender, EventArgs e) {
            OnTipoAusenciaChanged();
        }

        private void btSearch_Click(object sender, EventArgs e) {
            SearchAusencias();
        }

        private void btClean_Click(object sender, EventArgs e) {
            CleanFormPDispensa();
        }

        private void lvAusencias_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left && lvAusencias.SelectedIndices.Count > 0) {
                if (lvAusencias.HitTest(e.Location).Item == lvAusencias.SelectedItems[0]) {
                    var item = lvAusencias.SelectedItems[0] as ListViewGenericItem<Ausencia>;
                    SelectAusencia(item.Value);
                }
            }
        }                     
                
    }
}
