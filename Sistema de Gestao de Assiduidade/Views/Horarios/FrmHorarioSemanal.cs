using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.model.basic;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.sigeas.model.ca;
using mz.betainteractive.sigeas.settings;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.utilities.module.Components;
using mz.betainteractive.utilities.module.General;
using mz.betainteractive.sigeas.utilities;

namespace mz.betainteractive.sigeas.Views.Horarios {
    public partial class FrmHorarioSemanal : Form, AuthorizableComponent {

        //long SelectedHorarioID = -1;
        private SigeasDatabaseContext context;
        private HorarioSemana SelectedHorario;

        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }

        public FrmHorarioSemanal() {
            InitializeComponent();            
        }

        private void Initialize() {            
            DisableAll();
            LimparTudo();
            treeViewHorarios.Nodes.Clear();
            LoadHorarios();
        }

        private void DisposeContext() {
            if (context != null) {
                context.Dispose();
                context = null;
                SelectedHorario = null;
                LimparTudo();
                DisableAll();
            }
        }

        private void LoadContext() {
            if (context == null) {
                context = new SigeasDatabaseContext();
            }

            SelectedHorario = null;            
        }

        private void FrmHorarioSemanal_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
            DisposeContext();
        }

        private void FrmHorarioSemanal_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                LoadContext();
                Initialize();
            }
        }

        private void DisableAll() {
            grpDescricao.Enabled = false;
            tabHorariosDia.Enabled = false;
            panelHorarios.Enabled = false;

            btGravar.Enabled = false;
            btUpdate.Enabled = false;
            btRemover.Enabled = false;
            btLimpar.Enabled = false;
        }

        private void EnableForNew() {
            grpDescricao.Enabled = true;
            tabHorariosDia.Enabled = true;
            panelHorarios.Enabled = true;

            btGravar.Enabled = true;
            btUpdate.Enabled = false;
            btRemover.Enabled = false;
            btLimpar.Enabled = true;

            LimparTudo();
        }

        private void EnableForChange() {
            grpDescricao.Enabled = true;
            tabHorariosDia.Enabled = true;
            panelHorarios.Enabled = true;

            btGravar.Enabled = false;
            btUpdate.Enabled = true;
            btRemover.Enabled = true;
            btLimpar.Enabled = false;
        }

        private void LoadHorarios() {

            var hors = context.HorarioSemana.ToList();
                       
            treeViewHorarios.Nodes.Clear();

            foreach (HorarioSemana h in hors) {
                TreeNodeHorarioSemana node = new TreeNodeHorarioSemana(h);
                treeViewHorarios.Nodes.Add(node);
            }
        }

        private void LimparTudo() {
            SelectedHorario = null;

            txtCodigo.Text = "";
            txtDescricao.Text = "";

            chkHasFeriados.Checked = false;
            chkHasHrExtras.Checked = false;

            
            txtTotalHoras.Text = "00:00";
            
            DateTime time = Constants.GetDefaultTime();

            //Segunda
            chkSeg_Enabled.Checked = false;
            dtpSeg_Entrada1.Value = time;
            dtpSeg_Saida1.Value = time;
            chkSeg_Intervalo.Checked = false;
            dtpSeg_Entrada2.Value = time;
            dtpSeg_Saida2.Value = time;
            txtSeg_TotalHoras.Text = "00:00";
            nudSeg_TolerEntrada1.Value = 0;
            nudSeg_TolerSaida2.Value = 0;
            //Terca
            chkTer_Enabled.Checked = false;
            dtpTer_Entrada1.Value = time;
            dtpTer_Saida1.Value = time;
            chkTer_Intervalo.Checked = false;
            dtpTer_Entrada2.Value = time;
            dtpTer_Saida2.Value = time;
            txtTer_TotalHoras.Text = "00:00";
            nudTer_TolerEntrada1.Value = 0;
            nudTer_TolerSaida2.Value = 0;
            //Quarta
            chkQua_Enabled.Checked = false;
            dtpQua_Entrada1.Value = time;
            dtpQua_Saida1.Value = time;
            chkQua_Intervalo.Checked = false;
            dtpQua_Entrada2.Value = time;
            dtpQua_Saida2.Value = time;
            txtQua_TotalHoras.Text = "00:00";
            nudQua_TolerEntrada1.Value = 0;
            nudQua_TolerSaida2.Value = 0;
            //Quinta
            chkQui_Enabled.Checked = false;
            dtpQui_Entrada1.Value = time;
            dtpQui_Saida1.Value = time;
            chkQui_Intervalo.Checked = false;
            dtpQui_Entrada2.Value = time;
            dtpQui_Saida2.Value = time;
            txtQui_TotalHoras.Text = "00:00";
            nudQui_TolerEntrada1.Value = 0;
            nudQui_TolerSaida2.Value = 0;
            //Sexta
            chkSex_Enabled.Checked = false;
            dtpSex_Entrada1.Value = time;
            dtpSex_Saida1.Value = time;
            chkSex_Intervalo.Checked = false;
            dtpSex_Entrada2.Value = time;
            dtpSex_Saida2.Value = time;
            txtSex_TotalHoras.Text = "00:00";
            nudSex_TolerEntrada1.Value = 0;
            nudSex_TolerSaida2.Value = 0;
            //Sabado
            chkSab_Enabled.Checked = false;
            dtpSab_Entrada1.Value = time;
            dtpSab_Saida1.Value = time;
            chkSab_Intervalo.Checked = false;
            dtpSab_Entrada2.Value = time;
            dtpSab_Saida2.Value = time;
            txtSab_TotalHoras.Text = "00:00";
            nudSab_TolerEntrada1.Value = 0;
            nudSab_TolerSaida2.Value = 0;
            //Domingo
            chkDom_Enabled.Checked = false;
            dtpDom_Entrada1.Value = time;
            dtpDom_Saida1.Value = time;
            chkDom_Intervalo.Checked = false;
            dtpDom_Entrada2.Value = time;
            dtpDom_Saida2.Value = time;
            txtDom_TotalHoras.Text = "00:00";
            nudDom_TolerEntrada1.Value = 0;
            nudDom_TolerSaida2.Value = 0;
        }

        

        private void btFechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btLimpar_Click(object sender, EventArgs e) {
            LimparForms();
        }

        private void LimparForms() {
            LimparTudo();
        }

        private void btNovoHorario_Click(object sender, EventArgs e) {
            EnableForNew();
            SelectedHorario = null;
        }

        private void chkSeg_Intervalo_CheckedChanged(object sender, EventArgs e) {
            OnChkSeg_IntervaloChanges();
        }

        private void OnChkSeg_IntervaloChanges() {
            bool chk = chkSeg_Intervalo.Checked;
            dtpSeg_Saida1.Enabled = chk;
            dtpSeg_Entrada2.Enabled = chk;
            panSeg_Saida1.Enabled = chk;
            panSeg_Entrada2.Enabled = chk;

            CalcHoraSegunda();
        }

        private void OnChkTer_IntervaloChanges() {
            bool chk = chkTer_Intervalo.Checked;
            dtpTer_Saida1.Enabled = chk;
            dtpTer_Entrada2.Enabled = chk;
            panTer_Saida1.Enabled = chk;
            panTer_Entrada2.Enabled = chk;
            CalcHoraTerca();
        }

        private void OnChkQua_IntervaloChanges() {
            bool chk = chkQua_Intervalo.Checked;
            dtpQua_Saida1.Enabled = chk;
            dtpQua_Entrada2.Enabled = chk;
            panQua_Saida1.Enabled = chk;
            panQua_Entrada2.Enabled = chk;
            CalcHoraQuarta();
        }

        private void OnChkQui_IntervaloChanges() {
            bool chk = chkQui_Intervalo.Checked;
            dtpQui_Saida1.Enabled = chk;
            dtpQui_Entrada2.Enabled = chk;
            panQui_Saida1.Enabled = chk;
            panQui_Entrada2.Enabled = chk;
            CalcHoraQuinta();
        }

        private void OnChkSex_IntervaloChanges() {
            bool chk = chkSex_Intervalo.Checked;
            dtpSex_Saida1.Enabled = chk;
            dtpSex_Entrada2.Enabled = chk;
            panSex_Saida1.Enabled = chk;
            panSex_Entrada2.Enabled = chk;
            CalcHoraSexta();
        }

        private void OnChkSab_IntervaloChanges() {
            bool chk = chkSab_Intervalo.Checked;
            dtpSab_Saida1.Enabled = chk;
            dtpSab_Entrada2.Enabled = chk;
            panSab_Saida1.Enabled = chk;
            panSab_Entrada2.Enabled = chk;
            CalcHoraSabado();
        }

        private void OnChkDom_IntervaloChanges() {
            bool chk = chkDom_Intervalo.Checked;
            dtpDom_Saida1.Enabled = chk;
            dtpDom_Entrada2.Enabled = chk;
            panDom_Saida1.Enabled = chk;
            panDom_Entrada2.Enabled = chk;
            CalcHoraDomingo();
        }

        private void CalcHoraSegunda() {
            DateTime timeEntrada1 = dtpSeg_Entrada1.Value;
            DateTime timeSaida1 = dtpSeg_Saida1.Value;

            DateTime timeEntrada2 = dtpSeg_Entrada2.Value;            
            DateTime timeSaida2 = dtpSeg_Saida2.Value;

            TimeSpan time1 = timeSaida1.Subtract(timeEntrada1);
            TimeSpan time2 = timeSaida2.Subtract(timeEntrada2);

            TimeSpan time1p2 = time1.Add(time2);
            TimeSpan timeSemIntervalo = timeSaida2.Subtract(timeEntrada1);

            int hora = 0;
            int min = 0;

            if (chkSeg_Intervalo.Checked) {
                hora = time1p2.Hours;
                min = time1p2.Minutes;
            } else {
                hora = timeSemIntervalo.Hours;
                min = timeSemIntervalo.Minutes;
            }

            Hora h = new Hora(hora, min);
            txtSeg_TotalHoras.Text = h.ToString();

            CalcHorasTotal();
        }

        private void CalcHoraTerca() {
            DateTime timeEntrada1 = dtpTer_Entrada1.Value;
            DateTime timeSaida1 = dtpTer_Saida1.Value;

            DateTime timeEntrada2 = dtpTer_Entrada2.Value;
            DateTime timeSaida2 = dtpTer_Saida2.Value;

            TimeSpan time1 = timeSaida1.Subtract(timeEntrada1);
            TimeSpan time2 = timeSaida2.Subtract(timeEntrada2);

            TimeSpan time1p2 = time1.Add(time2);
            TimeSpan timeSemIntervalo = timeSaida2.Subtract(timeEntrada1);

            int hora = 0;
            int min = 0;

            if (chkTer_Intervalo.Checked) {
                hora = time1p2.Hours;
                min = time1p2.Minutes;
            } else {
                hora = timeSemIntervalo.Hours;
                min = timeSemIntervalo.Minutes;
            }

            Hora h = new Hora(hora, min);
            txtTer_TotalHoras.Text = h.ToString();

            CalcHorasTotal();
        }

        private void CalcHoraQuarta() {
            DateTime timeEntrada1 = dtpQua_Entrada1.Value;
            DateTime timeSaida1 = dtpQua_Saida1.Value;

            DateTime timeEntrada2 = dtpQua_Entrada2.Value;
            DateTime timeSaida2 = dtpQua_Saida2.Value;

            TimeSpan time1 = timeSaida1.Subtract(timeEntrada1);
            TimeSpan time2 = timeSaida2.Subtract(timeEntrada2);

            TimeSpan time1p2 = time1.Add(time2);
            TimeSpan timeSemIntervalo = timeSaida2.Subtract(timeEntrada1);

            int hora = 0;
            int min = 0;

            if (chkQua_Intervalo.Checked) {
                hora = time1p2.Hours;
                min = time1p2.Minutes;
            } else {
                hora = timeSemIntervalo.Hours;
                min = timeSemIntervalo.Minutes;
            }

            Hora h = new Hora(hora, min);
            txtQua_TotalHoras.Text = h.ToString();

            CalcHorasTotal();
        }

        private void CalcHoraQuinta() {
            DateTime timeEntrada1 = dtpQui_Entrada1.Value;
            DateTime timeSaida1 = dtpQui_Saida1.Value;

            DateTime timeEntrada2 = dtpQui_Entrada2.Value;
            DateTime timeSaida2 = dtpQui_Saida2.Value;

            TimeSpan time1 = timeSaida1.Subtract(timeEntrada1);
            TimeSpan time2 = timeSaida2.Subtract(timeEntrada2);

            TimeSpan time1p2 = time1.Add(time2);
            TimeSpan timeSemIntervalo = timeSaida2.Subtract(timeEntrada1);

            int hora = 0;
            int min = 0;

            if (chkQui_Intervalo.Checked) {
                hora = time1p2.Hours;
                min = time1p2.Minutes;
            } else {
                hora = timeSemIntervalo.Hours;
                min = timeSemIntervalo.Minutes;
            }

            Hora h = new Hora(hora, min);
            txtQui_TotalHoras.Text = h.ToString();

            CalcHorasTotal();
        }

        private void CalcHoraSexta() {
            DateTime timeEntrada1 = dtpSex_Entrada1.Value;
            DateTime timeSaida1 = dtpSex_Saida1.Value;

            DateTime timeEntrada2 = dtpSex_Entrada2.Value;
            DateTime timeSaida2 = dtpSex_Saida2.Value;

            TimeSpan time1 = timeSaida1.Subtract(timeEntrada1);
            TimeSpan time2 = timeSaida2.Subtract(timeEntrada2);

            TimeSpan time1p2 = time1.Add(time2);
            TimeSpan timeSemIntervalo = timeSaida2.Subtract(timeEntrada1);

            int hora = 0;
            int min = 0;

            if (chkSex_Intervalo.Checked) {
                hora = time1p2.Hours;
                min = time1p2.Minutes;
            } else {
                hora = timeSemIntervalo.Hours;
                min = timeSemIntervalo.Minutes;
            }

            Hora h = new Hora(hora, min);
            txtSex_TotalHoras.Text = h.ToString();

            CalcHorasTotal();
        }

        private void CalcHoraSabado() {
            DateTime timeEntrada1 = dtpSab_Entrada1.Value;
            DateTime timeSaida1 = dtpSab_Saida1.Value;

            DateTime timeEntrada2 = dtpSab_Entrada2.Value;
            DateTime timeSaida2 = dtpSab_Saida2.Value;

            TimeSpan time1 = timeSaida1.Subtract(timeEntrada1);
            TimeSpan time2 = timeSaida2.Subtract(timeEntrada2);

            TimeSpan time1p2 = time1.Add(time2);
            TimeSpan timeSemIntervalo = timeSaida2.Subtract(timeEntrada1);

            int hora = 0;
            int min = 0;

            if (chkSab_Intervalo.Checked) {
                hora = time1p2.Hours;
                min = time1p2.Minutes;
            } else {
                hora = timeSemIntervalo.Hours;
                min = timeSemIntervalo.Minutes;
            }

            Hora h = new Hora(hora, min);
            txtSab_TotalHoras.Text = h.ToString();

            CalcHorasTotal();
        }

        private void CalcHoraDomingo() {
            DateTime timeEntrada1 = dtpDom_Entrada1.Value;
            DateTime timeSaida1 = dtpDom_Saida1.Value;

            DateTime timeEntrada2 = dtpDom_Entrada2.Value;
            DateTime timeSaida2 = dtpDom_Saida2.Value;

            TimeSpan time1 = timeSaida1.Subtract(timeEntrada1);
            TimeSpan time2 = timeSaida2.Subtract(timeEntrada2);

            TimeSpan time1p2 = time1.Add(time2);
            TimeSpan timeSemIntervalo = timeSaida2.Subtract(timeEntrada1);

            int hora = 0;
            int min = 0;

            if (chkDom_Intervalo.Checked) {
                hora = time1p2.Hours;
                min = time1p2.Minutes;
            } else {
                hora = timeSemIntervalo.Hours;
                min = timeSemIntervalo.Minutes;
            }

            Hora h = new Hora(hora, min);
            txtDom_TotalHoras.Text = h.ToString();

            CalcHorasTotal();
        }

        private void CalcHorasTotal() {
            Hora hSeg = Hora.GetFromText(txtSeg_TotalHoras.Text);            
            Hora hTer = Hora.GetFromText(txtTer_TotalHoras.Text);            
            Hora hQua = Hora.GetFromText(txtQua_TotalHoras.Text);            
            Hora hQui = Hora.GetFromText(txtQui_TotalHoras.Text);            
            Hora hSex = Hora.GetFromText(txtSex_TotalHoras.Text);            
            Hora hSab = Hora.GetFromText(txtSab_TotalHoras.Text);            
            Hora hDom = Hora.GetFromText(txtDom_TotalHoras.Text);

            Hora totalHs = new Hora();

            //Hora totalHs = Hora.SumAll(hSeg, hTer, hQua, hQui, hSex, hSab, hDom);

            if (chkSeg_Enabled.Checked) {
                totalHs.Add(hSeg);
            }
            if (chkTer_Enabled.Checked) {
                totalHs.Add(hTer);
            }
            if (chkQua_Enabled.Checked) {
                totalHs.Add(hQua);
            }
            if (chkQui_Enabled.Checked) {
                totalHs.Add(hQui);
            }
            if (chkSex_Enabled.Checked) {
                totalHs.Add(hSex);
            }
            if (chkSab_Enabled.Checked) {
                totalHs.Add(hSab);
            }
            if (chkDom_Enabled.Checked) {
                totalHs.Add(hDom);
            }

            txtTotalHoras.Text = totalHs.ToString();

        }

        private bool ValidarAll() {
            if (txtDescricao.Text.Length == 0) {
                MessageBox.Show("Introduza a descrição, por favor");
                txtDescricao.Focus();
                return false;
            }

            if (!ValidarSegunda()) {
                return false;
            }
            if (!ValidarTerca()) {
                return false;
            }
            if (!ValidarQuarta()) {
                return false;
            }
            if (!ValidarQuinta()) {
                return false;
            }
            if (!ValidarSexta()) {
                return false;
            }
            if (!ValidarSabado()) {
                return false;
            }
            if (!ValidarDomingo()) {
                return false;
            }
                     

            

            return true;            
        }

        private bool ValidarSegunda() {

            if (chkSeg_Intervalo.Checked==false) {
                DateTime ent1 = dtpSeg_Entrada1.Value;
                DateTime sai2 = dtpSeg_Saida2.Value;
                
                if (ent1.CompareTo(sai2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageSegunda;                    
                    MessageBox.Show("A hora da 1ªEntrada não pode ser maior ou igual a hora da 2ªSaída");                    
                    dtpSeg_Saida2.Focus();
                    return false;
                }
            } else {
                DateTime ent1 = dtpSeg_Entrada1.Value;
                DateTime sai1 = dtpSeg_Saida1.Value;
                DateTime ent2 = dtpSeg_Entrada2.Value;
                DateTime sai2 = dtpSeg_Saida2.Value;

                if (ent1.CompareTo(sai1) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageSegunda;
                    MessageBox.Show("A hora da 1ªEntrada não pode ser maior ou igual a hora da 1ªSaída");                    
                    dtpSeg_Saida1.Focus();
                    return false;
                }
                if (sai1.CompareTo(ent2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageSegunda;
                    MessageBox.Show("A hora da 1ªSaida não pode ser maior ou igual a hora da 2ªEntrada");                    
                    dtpSeg_Entrada2.Focus();
                    return false;
                }
                if (ent2.CompareTo(sai2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageSegunda;
                    MessageBox.Show("A hora da 2ªEntrada não pode ser maior ou igual a hora da 2ªSaída");                    
                    dtpSeg_Saida2.Focus();
                    return false;
                }
            }                     
            
            return true;
        }

        private bool ValidarTerca() {

            if (chkTer_Intervalo.Checked == false) {
                DateTime ent1 = dtpTer_Entrada1.Value;
                DateTime sai2 = dtpTer_Saida2.Value;

                if (ent1.CompareTo(sai2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageTerca;
                    MessageBox.Show("A hora da 1ªEntrada não pode ser maior ou igual a hora da 2ªSaída");
                    dtpTer_Saida2.Focus();
                    return false;
                }
            } else {
                DateTime ent1 = dtpTer_Entrada1.Value;
                DateTime sai1 = dtpTer_Saida1.Value;
                DateTime ent2 = dtpTer_Entrada2.Value;
                DateTime sai2 = dtpTer_Saida2.Value;

                if (ent1.CompareTo(sai1) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageTerca;
                    MessageBox.Show("A hora da 1ªEntrada não pode ser maior ou igual a hora da 1ªSaída");
                    dtpTer_Saida1.Focus();
                    return false;
                }
                if (sai1.CompareTo(ent2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageTerca;
                    MessageBox.Show("A hora da 1ªSaida não pode ser maior ou igual a hora da 2ªEntrada");
                    dtpTer_Entrada2.Focus();
                    return false;
                }
                if (ent2.CompareTo(sai2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageTerca;
                    MessageBox.Show("A hora da 2ªEntrada não pode ser maior ou igual a hora da 2ªSaída");
                    dtpTer_Saida2.Focus();
                    return false;
                }
            }
            
            return true;
        }

        private bool ValidarQuarta() {

            if (chkQua_Intervalo.Checked == false) {
                DateTime ent1 = dtpQua_Entrada1.Value;
                DateTime sai2 = dtpQua_Saida2.Value;

                if (ent1.CompareTo(sai2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageQuarta;
                    MessageBox.Show("A hora da 1ªEntrada não pode ser maior ou igual a hora da 2ªSaída");
                    dtpQua_Saida2.Focus();
                    return false;
                }
            } else {
                DateTime ent1 = dtpQua_Entrada1.Value;
                DateTime sai1 = dtpQua_Saida1.Value;
                DateTime ent2 = dtpQua_Entrada2.Value;
                DateTime sai2 = dtpQua_Saida2.Value;

                if (ent1.CompareTo(sai1) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageQuarta;
                    MessageBox.Show("A hora da 1ªEntrada não pode ser maior ou igual a hora da 1ªSaída");
                    dtpQua_Saida1.Focus();
                    return false;
                }
                if (sai1.CompareTo(ent2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageQuarta;
                    MessageBox.Show("A hora da 1ªSaida não pode ser maior ou igual a hora da 2ªEntrada");
                    dtpQua_Entrada2.Focus();
                    return false;
                }
                if (ent2.CompareTo(sai2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageQuarta;
                    MessageBox.Show("A hora da 2ªEntrada não pode ser maior ou igual a hora da 2ªSaída");
                    dtpQua_Saida2.Focus();
                    return false;
                }
            }
            
            return true;
        }

        private bool ValidarQuinta() {

            if (chkQui_Intervalo.Checked == false) {
                DateTime ent1 = dtpQui_Entrada1.Value;
                DateTime sai2 = dtpQui_Saida2.Value;

                if (ent1.CompareTo(sai2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageQuinta;
                    MessageBox.Show("A hora da 1ªEntrada não pode ser maior ou igual a hora da 2ªSaída");
                    dtpQui_Saida2.Focus();
                    return false;
                }
            } else {
                DateTime ent1 = dtpQui_Entrada1.Value;
                DateTime sai1 = dtpQui_Saida1.Value;
                DateTime ent2 = dtpQui_Entrada2.Value;
                DateTime sai2 = dtpQui_Saida2.Value;

                if (ent1.CompareTo(sai1) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageQuinta;
                    MessageBox.Show("A hora da 1ªEntrada não pode ser maior ou igual a hora da 1ªSaída");
                    dtpQui_Saida1.Focus();
                    return false;
                }
                if (sai1.CompareTo(ent2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageQuinta;
                    MessageBox.Show("A hora da 1ªSaida não pode ser maior ou igual a hora da 2ªEntrada");
                    dtpQui_Entrada2.Focus();
                    return false;
                }
                if (ent2.CompareTo(sai2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageQuinta;
                    MessageBox.Show("A hora da 2ªEntrada não pode ser maior ou igual a hora da 2ªSaída");
                    dtpQui_Saida2.Focus();
                    return false;
                }
            }

            return true;
        }

        private bool ValidarSexta() {

            if (chkSex_Intervalo.Checked == false) {
                DateTime ent1 = dtpSex_Entrada1.Value;
                DateTime sai2 = dtpSex_Saida2.Value;

                if (ent1.CompareTo(sai2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageSexta;
                    MessageBox.Show("A hora da 1ªEntrada não pode ser maior ou igual a hora da 2ªSaída");
                    dtpSex_Saida2.Focus();
                    return false;
                }
            } else {
                DateTime ent1 = dtpSex_Entrada1.Value;
                DateTime sai1 = dtpSex_Saida1.Value;
                DateTime ent2 = dtpSex_Entrada2.Value;
                DateTime sai2 = dtpSex_Saida2.Value;

                if (ent1.CompareTo(sai1) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageSexta;
                    MessageBox.Show("A hora da 1ªEntrada não pode ser maior ou igual a hora da 1ªSaída");
                    dtpSex_Saida1.Focus();
                    return false;
                }
                if (sai1.CompareTo(ent2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageSexta;
                    MessageBox.Show("A hora da 1ªSaida não pode ser maior ou igual a hora da 2ªEntrada");
                    dtpSex_Entrada2.Focus();
                    return false;
                }
                if (ent2.CompareTo(sai2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageSexta;
                    MessageBox.Show("A hora da 2ªEntrada não pode ser maior ou igual a hora da 2ªSaída");
                    dtpSex_Saida2.Focus();
                    return false;
                }
            }                       

            return true;
        }

        private bool ValidarSabado() {

            if (chkSab_Intervalo.Checked == false) {
                DateTime ent1 = dtpSab_Entrada1.Value;
                DateTime sai2 = dtpSab_Saida2.Value;

                if (ent1.CompareTo(sai2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageSabado;
                    MessageBox.Show("A hora da 1ªEntrada não pode ser maior ou igual a hora da 2ªSaída");
                    dtpSab_Saida2.Focus();
                    return false;
                }
            } else {
                DateTime ent1 = dtpSab_Entrada1.Value;
                DateTime sai1 = dtpSab_Saida1.Value;
                DateTime ent2 = dtpSab_Entrada2.Value;
                DateTime sai2 = dtpSab_Saida2.Value;

                if (ent1.CompareTo(sai1) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageSabado;
                    MessageBox.Show("A hora da 1ªEntrada não pode ser maior ou igual a hora da 1ªSaída");
                    dtpSab_Saida1.Focus();
                    return false;
                }
                if (sai1.CompareTo(ent2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageSabado;
                    MessageBox.Show("A hora da 1ªSaida não pode ser maior ou igual a hora da 2ªEntrada");
                    dtpSab_Entrada2.Focus();
                    return false;
                }
                if (ent2.CompareTo(sai2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageSabado;
                    MessageBox.Show("A hora da 2ªEntrada não pode ser maior ou igual a hora da 2ªSaída");
                    dtpSab_Saida2.Focus();
                    return false;
                }
            }

            return true;
        }

        private bool ValidarDomingo() {

            if (chkDom_Intervalo.Checked == false) {
                DateTime ent1 = dtpDom_Entrada1.Value;
                DateTime sai2 = dtpDom_Saida2.Value;

                if (ent1.CompareTo(sai2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageDomingo;
                    MessageBox.Show("A hora da 1ªEntrada não pode ser maior ou igual a hora da 2ªSaída");
                    dtpDom_Saida2.Focus();
                    return false;
                }
            } else {
                DateTime ent1 = dtpDom_Entrada1.Value;
                DateTime sai1 = dtpDom_Saida1.Value;
                DateTime ent2 = dtpDom_Entrada2.Value;
                DateTime sai2 = dtpDom_Saida2.Value;

                if (ent1.CompareTo(sai1) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageDomingo;
                    MessageBox.Show("A hora da 1ªEntrada não pode ser maior ou igual a hora da 1ªSaída");
                    dtpDom_Saida1.Focus();
                    return false;
                }
                if (sai1.CompareTo(ent2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageDomingo;
                    MessageBox.Show("A hora da 1ªSaida não pode ser maior ou igual a hora da 2ªEntrada");
                    dtpDom_Entrada2.Focus();
                    return false;
                }
                if (ent2.CompareTo(sai2) >= 0) {
                    tabHorariosDia.SelectedTab = tabPageDomingo;
                    MessageBox.Show("A hora da 2ªEntrada não pode ser maior ou igual a hora da 2ªSaída");
                    dtpDom_Saida2.Focus();
                    return false;
                }
            }                        

            return true;
        }            

        private void chkTer_Intervalo_CheckedChanged(object sender, EventArgs e) {
            OnChkTer_IntervaloChanges();
        }

        private void chkQua_Intervalo_CheckedChanged(object sender, EventArgs e) {
            OnChkQua_IntervaloChanges();
        }

        private void chkQui_Intervalo_CheckedChanged(object sender, EventArgs e) {
            OnChkQui_IntervaloChanges();
        }

        private void chkSex_Intervalo_CheckedChanged(object sender, EventArgs e) {
            OnChkSex_IntervaloChanges();
        }

        private void chkSab_Intervalo_CheckedChanged(object sender, EventArgs e) {
            OnChkSab_IntervaloChanges();
        }

        private void chkDom_Intervalo_CheckedChanged(object sender, EventArgs e) {
            OnChkDom_IntervaloChanges();
        }

        private void dtpSeg_All_ValueChanged(object sender, EventArgs e) {
            CalcHoraSegunda();
        }
        private void dtpTer_All_ValueChanged(object sender, EventArgs e) {
            CalcHoraTerca();
        }
        private void dtpQua_All_ValueChanged(object sender, EventArgs e) {
            CalcHoraQuarta();
        }
        private void dtpQui_All_ValueChanged(object sender, EventArgs e) {
            CalcHoraQuinta();
        }
        private void dtpSex_All_ValueChanged(object sender, EventArgs e) {
            CalcHoraSexta();
        }
        private void dtpSab_All_ValueChanged(object sender, EventArgs e) {
            CalcHoraSabado();
        }
        private void dtpDom_All_ValueChanged(object sender, EventArgs e) {
            CalcHoraDomingo();
        }

        private void btGravar_Click(object sender, EventArgs e) {
            GravarHorario();
        }

        private void GravarHorario() {
            if (!ValidarAll()) {
                return;
            }

            //verificar se já existe nome igual
            if (AlreadyExistsWithDescricao(txtDescricao.Text)) {
                MessageBox.Show("Já existe um perfil de horário com essa descrição");
                txtDescricao.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show("Tem certeza que deseja registar o perfil de horário(" + txtDescricao.Text + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            string descricao = txtDescricao.Text;
            bool hasHorasExtras = chkHasHrExtras.Checked;
            bool hasFeriados = chkHasFeriados.Checked;
            
            Hora totalHoras = Hora.GetFromText(txtTotalHoras.Text);


            HorarioSemana horario = new HorarioSemana();

            HorarioDia segunda = CreateHorarioSegunda();
            HorarioDia terca = CreateHorarioTerca();
            HorarioDia quarta = CreateHorarioQuarta();
            HorarioDia quinta = CreateHorarioQuinta();
            HorarioDia sexta = CreateHorarioSexta();
            HorarioDia sabado = CreateHorarioSabado();
            HorarioDia domingo = CreateHorarioDomingo();

            horario.Codigo = CreateCode();                      
            horario.Descricao = descricao;
            horario.HasFeriados = hasFeriados;
            horario.HasHorasExtras = hasHorasExtras;            
            horario.TotalHoras = totalHoras.Horas;
            horario.TotalMinutos = totalHoras.Minutos;

            /*
            //horario.Segunda = segunda;
            //horario.Terca = terca;
            //horario.Quarta = quarta;
            //horario.Quinta = quinta;
            //horario.Sexta = sexta;
            //horario.Sabado = sabado;
            //horario.Domingo = domingo;
            
            segunda.HorarioSemana = horario;
            terca.HorarioSemana = horario;
            quarta.HorarioSemana = horario;
            quinta.HorarioSemana = horario;
            sexta.HorarioSemana = horario;
            sabado.HorarioSemana = horario;
            domingo.HorarioSemana = horario;
            */
            horario.Dias.Add(domingo);
            horario.Dias.Add(segunda);
            horario.Dias.Add(terca);
            horario.Dias.Add(quarta);
            horario.Dias.Add(quinta);            
            horario.Dias.Add(sexta);
            horario.Dias.Add(sabado);


            horario.CreatedBy = SystemManager.GetCurrentUser(context);
            horario.CreationDate = DateTime.Today;

            try{
                context.HorarioSemana.Add(horario);
                context.SaveChanges();

                MessageBox.Show("O perfil de horário (" + descricao + ") foi gravado com sucesso");
                LimparForms();
                DisableAll();
                LoadHorarios();

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar gravar o perfil de horário na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar gravar o perfil de horário na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                                            
        }

        private string CreateCode() {
            
            int max = context.HorarioSemana.ToList().Count + 1;

            return "H" + max.ToString("X3");
        }

        private void AtualizarHorario() {
                        
            HorarioSemana horario = SelectedHorario;

            if (horario == null) {
                MessageBox.Show("Não foi selecionado horario, selecione primeiro");
                return;
            }

            if (!ValidarAll()) {
                return;
            }                        

            DialogResult dr = MessageBox.Show("Tem certeza que deseja actualizar o Horário(" + (txtDescricao.Text) + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            string descricao = txtDescricao.Text;
            bool hasHorasExtras = chkHasHrExtras.Checked;
            bool hasFeriados = chkHasFeriados.Checked;
            
            Hora totalHoras = Hora.GetFromText(txtTotalHoras.Text);

            HorarioDia segunda = horario.Segunda;
            HorarioDia terca = horario.Terca;
            HorarioDia quarta = horario.Quarta;
            HorarioDia quinta = horario.Quinta;
            HorarioDia sexta = horario.Sexta;
            HorarioDia sabado = horario.Sabado;
            HorarioDia domingo = horario.Domingo;

            horario.Descricao = descricao;
            horario.HasFeriados = hasFeriados;
            horario.HasHorasExtras = hasHorasExtras;
            
            horario.TotalHoras = totalHoras.Horas;
            horario.TotalMinutos = totalHoras.Minutos;

            horario.UpdatedBy = SystemManager.GetCurrentUser(context);
            horario.UpdatedDate = DateTime.Today;

            UpdateSegunda(segunda);
            UpdateTerca(terca);
            UpdateQuarta(quarta);
            UpdateQuinta(quinta);
            UpdateSexta(sexta);
            UpdateSabado(sabado);
            UpdateDomingo(domingo);

            try{
                context.SaveChanges();
                MessageBox.Show("O perfil de horário (" + descricao + ") foi actualizado com sucesso");
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar atualizar o perfil de horário na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar atualizar o perfil de horário na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoverHorario() {
                        
            HorarioSemana horario = SelectedHorario;

            if (horario == null) {
                MessageBox.Show("Não foi selecionado horario, selecione primeiro");
                return;
            }

            DialogResult dr = MessageBox.Show("Tem certeza que deseja remover o Horário(" + (txtDescricao.Text) + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            try{
                context.HorarioSemana.Remove(horario);
                context.SaveChanges();
                LoadHorarios();
                LimparForms();
                MessageBox.Show("O perfil de horário foi removido com sucesso");

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar atualizar o perfil de horário na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar atualizar o perfil de horário na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool AlreadyExistsWithDescricao(string p) {
            var hors = context.HorarioSemana.Where(t => t.Descricao.ToLower() == p.ToLower()).FirstOrDefault();
            return hors != null;
        }

        private void copiarHorariosParaTodosDiasDaSemanaToolStripMenuItem_Click(object sender, EventArgs e) {
            //Console.WriteLine("sender " + sender.GetType());

            if (sender is ToolStripMenuItem) {
                ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
                ContextMenuStrip menu = (ContextMenuStrip)menuItem.Owner;

                if (menu.SourceControl.Equals(tabPageSegunda)) {
                    CopyFromSegundaToAll();
                    return;
                }
                if (menu.SourceControl.Equals(tabPageTerca)) {
                    CopyFromTercaToAll();
                    return;
                }
                if (menu.SourceControl.Equals(tabPageQuarta)) {
                    CopyFromQuartaToAll();
                    return;
                }
                if (menu.SourceControl.Equals(tabPageQuinta)) {
                    CopyFromQuintaToAll();
                    return;
                }
                if (menu.SourceControl.Equals(tabPageSexta)) {
                    CopyFromSextaToAll();
                    return;
                }
                if (menu.SourceControl.Equals(tabPageSabado)) {
                    CopyFromSabadoToAll();
                    return;
                }
                if (menu.SourceControl.Equals(tabPageDomingo)) {
                    CopyFromDomingoToAll();
                    return;
                }

                
                
            }
        }

        private void CopyFromSegundaToAll() {
            bool enabled = chkSeg_Enabled.Checked;
            DateTime entrada1 = dtpSeg_Entrada1.Value;
            DateTime entrada2 = dtpSeg_Entrada2.Value;
            DateTime saida1 = dtpSeg_Saida1.Value;
            DateTime saida2 = dtpSeg_Saida2.Value;
            int tolerEntrada1 = (int) nudSeg_TolerEntrada1.Value;
            int tolerSaida2 = (int) nudSeg_TolerSaida2.Value;
            bool hasIntervalo = chkSeg_Intervalo.Checked;

            FillHorariosWith(enabled, entrada1, entrada2, saida1, saida2, tolerEntrada1, tolerSaida2, hasIntervalo);
        }
        
        private void CopyFromTercaToAll() {
            bool enabled = chkTer_Enabled.Checked;
            DateTime entrada1 = dtpTer_Entrada1.Value;
            DateTime entrada2 = dtpTer_Entrada2.Value;
            DateTime saida1 = dtpTer_Saida1.Value;
            DateTime saida2 = dtpTer_Saida2.Value;
            int tolerEntrada1 = (int) nudTer_TolerEntrada1.Value;
            int tolerSaida2 = (int) nudTer_TolerSaida2.Value;
            bool hasIntervalo = chkTer_Intervalo.Checked;

            FillHorariosWith(enabled, entrada1, entrada2, saida1, saida2, tolerEntrada1, tolerSaida2, hasIntervalo);
        }

        private void CopyFromQuartaToAll() {
            bool enabled = chkQua_Enabled.Checked;
            DateTime entrada1 = dtpQua_Entrada1.Value;
            DateTime entrada2 = dtpQua_Entrada2.Value;
            DateTime saida1 = dtpQua_Saida1.Value;
            DateTime saida2 = dtpQua_Saida2.Value;
            int tolerEntrada1 = (int) nudQua_TolerEntrada1.Value;
            int tolerSaida2 = (int) nudQua_TolerSaida2.Value;
            bool hasIntervalo = chkQua_Intervalo.Checked;

            FillHorariosWith(enabled, entrada1, entrada2, saida1, saida2, tolerEntrada1, tolerSaida2, hasIntervalo);
        }

        private void CopyFromQuintaToAll() {
            bool enabled = chkQui_Enabled.Checked;
            DateTime entrada1 = dtpQui_Entrada1.Value;
            DateTime entrada2 = dtpQui_Entrada2.Value;
            DateTime saida1 = dtpQui_Saida1.Value;
            DateTime saida2 = dtpQui_Saida2.Value;
            int tolerEntrada1 = (int) nudQui_TolerEntrada1.Value;
            int tolerSaida2 = (int) nudQui_TolerSaida2.Value;
            bool hasIntervalo = chkQui_Intervalo.Checked;

            FillHorariosWith(enabled, entrada1, entrada2, saida1, saida2, tolerEntrada1, tolerSaida2, hasIntervalo);
        }

        private void CopyFromSextaToAll() {
            bool enabled = chkSex_Enabled.Checked;
            DateTime entrada1 = dtpSex_Entrada1.Value;
            DateTime entrada2 = dtpSex_Entrada2.Value;
            DateTime saida1 = dtpSex_Saida1.Value;
            DateTime saida2 = dtpSex_Saida2.Value;
            int tolerEntrada1 = (int) nudSex_TolerEntrada1.Value;
            int tolerSaida2 = (int) nudSex_TolerSaida2.Value;
            bool hasIntervalo = chkSex_Intervalo.Checked;

            FillHorariosWith(enabled, entrada1, entrada2, saida1, saida2, tolerEntrada1, tolerSaida2, hasIntervalo);
        }

        private void CopyFromSabadoToAll() {
            bool enabled = chkSab_Enabled.Checked;
            DateTime entrada1 = dtpSab_Entrada1.Value;
            DateTime entrada2 = dtpSab_Entrada2.Value;
            DateTime saida1 = dtpSab_Saida1.Value;
            DateTime saida2 = dtpSab_Saida2.Value;
            int tolerEntrada1 = (int) nudSab_TolerEntrada1.Value;
            int tolerSaida2 = (int) nudSab_TolerSaida2.Value;
            bool hasIntervalo = chkSab_Intervalo.Checked;

            FillHorariosWith(enabled, entrada1, entrada2, saida1, saida2, tolerEntrada1, tolerSaida2, hasIntervalo);
        }

        private void CopyFromDomingoToAll() {
            bool enabled = chkDom_Enabled.Checked;
            DateTime entrada1 = dtpDom_Entrada1.Value;
            DateTime entrada2 = dtpDom_Entrada2.Value;
            DateTime saida1 = dtpDom_Saida1.Value;
            DateTime saida2 = dtpDom_Saida2.Value;
            int tolerEntrada1 = (int) nudDom_TolerEntrada1.Value;
            int tolerSaida2 = (int) nudDom_TolerSaida2.Value;
            bool hasIntervalo = chkSeg_Intervalo.Checked;

            FillHorariosWith(enabled, entrada1, entrada2, saida1, saida2, tolerEntrada1, tolerSaida2, hasIntervalo);
        }

        private void FillHorariosWith(bool enabled, DateTime entrada1, DateTime entrada2, DateTime saida1, DateTime saida2, int tolerEntrada1, int tolerSaida2, bool hasIntervalo) {
            chkSeg_Enabled.Checked = enabled;
            dtpSeg_Entrada1.Value = entrada1;
            dtpSeg_Entrada2.Value = entrada2;
            chkSeg_Intervalo.Checked = hasIntervalo;
            dtpSeg_Saida1.Value = saida1;
            dtpSeg_Saida2.Value = saida2;
            nudSeg_TolerEntrada1.Value = tolerEntrada1;
            nudSeg_TolerSaida2.Value = tolerSaida2;

            chkTer_Enabled.Checked = enabled;
            dtpTer_Entrada1.Value = entrada1;
            dtpTer_Entrada2.Value = entrada2;
            chkTer_Intervalo.Checked = hasIntervalo;
            dtpTer_Saida1.Value = saida1;
            dtpTer_Saida2.Value = saida2;
            nudTer_TolerEntrada1.Value = tolerEntrada1;
            nudTer_TolerSaida2.Value = tolerSaida2;

            chkQua_Enabled.Checked = enabled;
            dtpQua_Entrada1.Value = entrada1;
            dtpQua_Entrada2.Value = entrada2;
            chkQua_Intervalo.Checked = hasIntervalo;
            dtpQua_Saida1.Value = saida1;
            dtpQua_Saida2.Value = saida2;
            nudQua_TolerEntrada1.Value = tolerEntrada1;
            nudQua_TolerSaida2.Value = tolerSaida2;

            chkQui_Enabled.Checked = enabled;
            dtpQui_Entrada1.Value = entrada1;
            dtpQui_Entrada2.Value = entrada2;
            chkQui_Intervalo.Checked = hasIntervalo;
            dtpQui_Saida1.Value = saida1;
            dtpQui_Saida2.Value = saida2;
            nudQui_TolerEntrada1.Value = tolerEntrada1;
            nudQui_TolerSaida2.Value = tolerSaida2;

            chkSex_Enabled.Checked = enabled;
            dtpSex_Entrada1.Value = entrada1;
            dtpSex_Entrada2.Value = entrada2;
            chkSex_Intervalo.Checked = hasIntervalo;
            dtpSex_Saida1.Value = saida1;
            dtpSex_Saida2.Value = saida2;
            nudSex_TolerEntrada1.Value = tolerEntrada1;
            nudSex_TolerSaida2.Value = tolerSaida2;

            chkSab_Enabled.Checked = enabled;
            dtpSab_Entrada1.Value = entrada1;
            dtpSab_Entrada2.Value = entrada2;
            chkSab_Intervalo.Checked = hasIntervalo;
            dtpSab_Saida1.Value = saida1;
            dtpSab_Saida2.Value = saida2;
            nudSab_TolerEntrada1.Value = tolerEntrada1;
            nudSab_TolerSaida2.Value = tolerSaida2;

            chkDom_Enabled.Checked = enabled;
            dtpDom_Entrada1.Value = entrada1;
            dtpDom_Entrada2.Value = entrada2;
            chkDom_Intervalo.Checked = hasIntervalo;
            dtpDom_Saida1.Value = saida1;
            dtpDom_Saida2.Value = saida2;
            nudDom_TolerEntrada1.Value = tolerEntrada1;
            nudDom_TolerSaida2.Value = tolerSaida2;
        }

        private void UpdateSegunda(HorarioDia horario) {
            bool enabled = chkSeg_Enabled.Checked;
            DateTime entrada1 = dtpSeg_Entrada1.Value;
            DateTime entrada2 = dtpSeg_Entrada2.Value;
            DateTime saida1 = dtpSeg_Saida1.Value;
            DateTime saida2 = dtpSeg_Saida2.Value;
            int tolerEntrada1 = Convert.ToInt32(nudSeg_TolerEntrada1.Value);
            int tolerSaida2 = Convert.ToInt32(nudSeg_TolerSaida2.Value);
            Hora horasTrabalho = Hora.GetFromText(txtSeg_TotalHoras.Text);
            bool hasIntervalo = chkSeg_Intervalo.Checked;

            horario.Enabled = enabled;
            horario.Entrada1 = entrada1;
            horario.Entrada2 = entrada2;
            horario.Saida1 = saida1;
            horario.Saida2 = saida2;
            horario.ToleranciaNaEntrada1 = tolerEntrada1;
            horario.ToleranciaNaSaida2 = tolerSaida2;
            horario.HorasTrabalho = horasTrabalho.Horas;
            horario.MinsTrabalho = horasTrabalho.Minutos;
            horario.HasIntervalo = hasIntervalo;
        }

        private void UpdateTerca(HorarioDia horario) {
            bool enabled = chkTer_Enabled.Checked;
            DateTime entrada1 = dtpTer_Entrada1.Value;
            DateTime entrada2 = dtpTer_Entrada2.Value;
            DateTime saida1 = dtpTer_Saida1.Value;
            DateTime saida2 = dtpTer_Saida2.Value;
            int tolerEntrada1 = Convert.ToInt32(nudTer_TolerEntrada1.Value);
            int tolerSaida2 = Convert.ToInt32(nudTer_TolerSaida2.Value);
            Hora horasTrabalho = Hora.GetFromText(txtTer_TotalHoras.Text);
            bool hasIntervalo = chkTer_Intervalo.Checked;

            horario.Enabled = enabled;
            horario.Entrada1 = entrada1;
            horario.Entrada2 = entrada2;
            horario.Saida1 = saida1;
            horario.Saida2 = saida2;
            horario.ToleranciaNaEntrada1 = tolerEntrada1;
            horario.ToleranciaNaSaida2 = tolerSaida2;
            horario.HorasTrabalho = horasTrabalho.Horas;
            horario.MinsTrabalho = horasTrabalho.Minutos;
            horario.HasIntervalo = hasIntervalo;
        }

        private void UpdateQuarta(HorarioDia horario) {
            bool enabled = chkQua_Enabled.Checked;
            DateTime entrada1 = dtpQua_Entrada1.Value;
            DateTime entrada2 = dtpQua_Entrada2.Value;
            DateTime saida1 = dtpQua_Saida1.Value;
            DateTime saida2 = dtpQua_Saida2.Value;
            int tolerEntrada1 = Convert.ToInt32(nudQua_TolerEntrada1.Value);
            int tolerSaida2 = Convert.ToInt32(nudQua_TolerSaida2.Value);
            Hora horasTrabalho = Hora.GetFromText(txtQua_TotalHoras.Text);
            bool hasIntervalo = chkQua_Intervalo.Checked;

            horario.Enabled = enabled;
            horario.Entrada1 = entrada1;
            horario.Entrada2 = entrada2;
            horario.Saida1 = saida1;
            horario.Saida2 = saida2;
            horario.ToleranciaNaEntrada1 = tolerEntrada1;
            horario.ToleranciaNaSaida2 = tolerSaida2;
            horario.HorasTrabalho = horasTrabalho.Horas;
            horario.MinsTrabalho = horasTrabalho.Minutos;
            horario.HasIntervalo = hasIntervalo;
        }

        private void UpdateQuinta(HorarioDia horario) {
            bool enabled = chkQui_Enabled.Checked;
            DateTime entrada1 = dtpQui_Entrada1.Value;
            DateTime entrada2 = dtpQui_Entrada2.Value;
            DateTime saida1 = dtpQui_Saida1.Value;
            DateTime saida2 = dtpQui_Saida2.Value;
            int tolerEntrada1 = Convert.ToInt32(nudQui_TolerEntrada1.Value);
            int tolerSaida2 = Convert.ToInt32(nudQui_TolerSaida2.Value);
            Hora horasTrabalho = Hora.GetFromText(txtQui_TotalHoras.Text);
            bool hasIntervalo = chkQui_Intervalo.Checked;

            horario.Enabled = enabled;
            horario.Entrada1 = entrada1;
            horario.Entrada2 = entrada2;
            horario.Saida1 = saida1;
            horario.Saida2 = saida2;
            horario.ToleranciaNaEntrada1 = tolerEntrada1;
            horario.ToleranciaNaSaida2 = tolerSaida2;
            horario.HorasTrabalho = horasTrabalho.Horas;
            horario.MinsTrabalho = horasTrabalho.Minutos;
            horario.HasIntervalo = hasIntervalo;
        }

        private void UpdateSexta(HorarioDia horario) {
            bool enabled = chkSex_Enabled.Checked;
            DateTime entrada1 = dtpSex_Entrada1.Value;
            DateTime entrada2 = dtpSex_Entrada2.Value;
            DateTime saida1 = dtpSex_Saida1.Value;
            DateTime saida2 = dtpSex_Saida2.Value;
            int tolerEntrada1 = Convert.ToInt32(nudSex_TolerEntrada1.Value);
            int tolerSaida2 = Convert.ToInt32(nudSex_TolerSaida2.Value);
            Hora horasTrabalho = Hora.GetFromText(txtSex_TotalHoras.Text);
            bool hasIntervalo = chkSex_Intervalo.Checked;

            horario.Enabled = enabled;
            horario.Entrada1 = entrada1;
            horario.Entrada2 = entrada2;
            horario.Saida1 = saida1;
            horario.Saida2 = saida2;
            horario.ToleranciaNaEntrada1 = tolerEntrada1;
            horario.ToleranciaNaSaida2 = tolerSaida2;
            horario.HorasTrabalho = horasTrabalho.Horas;
            horario.MinsTrabalho = horasTrabalho.Minutos;
            horario.HasIntervalo = hasIntervalo;
        }

        private void UpdateSabado(HorarioDia horario) {
            bool enabled = chkSab_Enabled.Checked;
            DateTime entrada1 = dtpSab_Entrada1.Value;
            DateTime entrada2 = dtpSab_Entrada2.Value;
            DateTime saida1 = dtpSab_Saida1.Value;
            DateTime saida2 = dtpSab_Saida2.Value;
            int tolerEntrada1 = Convert.ToInt32(nudSab_TolerEntrada1.Value);
            int tolerSaida2 = Convert.ToInt32(nudSab_TolerSaida2.Value);
            Hora horasTrabalho = Hora.GetFromText(txtSab_TotalHoras.Text);
            bool hasIntervalo = chkSab_Intervalo.Checked;

            horario.Enabled = enabled;
            horario.Entrada1 = entrada1;
            horario.Entrada2 = entrada2;
            horario.Saida1 = saida1;
            horario.Saida2 = saida2;
            horario.ToleranciaNaEntrada1 = tolerEntrada1;
            horario.ToleranciaNaSaida2 = tolerSaida2;
            horario.HorasTrabalho = horasTrabalho.Horas;
            horario.MinsTrabalho = horasTrabalho.Minutos;
            horario.HasIntervalo = hasIntervalo;
        }

        private void UpdateDomingo(HorarioDia horario) {
            bool enabled = chkDom_Enabled.Checked;
            DateTime entrada1 = dtpDom_Entrada1.Value;
            DateTime entrada2 = dtpDom_Entrada2.Value;
            DateTime saida1 = dtpDom_Saida1.Value;
            DateTime saida2 = dtpDom_Saida2.Value;
            int tolerEntrada1 = Convert.ToInt32(nudDom_TolerEntrada1.Value);
            int tolerSaida2 = Convert.ToInt32(nudDom_TolerSaida2.Value);
            Hora horasTrabalho = Hora.GetFromText(txtDom_TotalHoras.Text);
            bool hasIntervalo = chkDom_Intervalo.Checked;

            horario.Enabled = enabled;
            horario.Entrada1 = entrada1;
            horario.Entrada2 = entrada2;
            horario.Saida1 = saida1;
            horario.Saida2 = saida2;
            horario.ToleranciaNaEntrada1 = tolerEntrada1;
            horario.ToleranciaNaSaida2 = tolerSaida2;
            horario.HorasTrabalho = horasTrabalho.Horas;
            horario.MinsTrabalho = horasTrabalho.Minutos;
            horario.HasIntervalo = hasIntervalo;
        }

        private HorarioDia CreateHorarioDia(int weekDay, bool enabled, DateTime entrada1, DateTime entrada2, bool hasIntervalo/*, int intervaloMinutos*/, DateTime saida1, DateTime saida2, int tolerEntrada1, int tolerSaida2, Hora horasTrabalho) {

            HorarioDia hr = new HorarioDia();

            hr.WeekDay = weekDay;
            hr.Enabled = enabled;
            hr.Entrada1 = entrada1;
            hr.Saida1 = saida1;            
            hr.Entrada2 = entrada2;
            hr.Saida2 = saida2;
            hr.ToleranciaNaEntrada1 = tolerEntrada1;
            hr.ToleranciaNaSaida2 = tolerSaida2;
            hr.HasIntervalo = hasIntervalo;
            //hr.IntervaloMinutos = intervaloMinutos;
            hr.HorasTrabalho = horasTrabalho.Horas;
            hr.MinsTrabalho = horasTrabalho.Minutos;

            return hr;
        }

        private HorarioDia CreateHorarioSegunda() {
            HorarioDia hr = null;

            bool enabled = chkSeg_Enabled.Checked;
            DateTime entrada1 = dtpSeg_Entrada1.Value;
            DateTime entrada2 = dtpSeg_Entrada2.Value;
            DateTime saida1 = dtpSeg_Saida1.Value;
            DateTime saida2 = dtpSeg_Saida2.Value;
            int tolerEntrada1 = Convert.ToInt32(nudSeg_TolerEntrada1.Value);
            int tolerSaida2 = Convert.ToInt32(nudSeg_TolerSaida2.Value);
            Hora horasTrabalho = Hora.GetFromText(txtSeg_TotalHoras.Text);
            bool hasIntervalo = chkSeg_Intervalo.Checked;

            hr = CreateHorarioDia(HorarioDia.SEGUNDA, enabled, entrada1, entrada2, hasIntervalo, saida1, saida2, tolerEntrada1, tolerSaida2, horasTrabalho);

            return hr;
        }

        private HorarioDia CreateHorarioTerca() {
            HorarioDia hr = null;

            bool enabled = chkTer_Enabled.Checked;
            DateTime entrada1 = dtpTer_Entrada1.Value;
            DateTime entrada2 = dtpTer_Entrada2.Value;
            DateTime saida1 = dtpTer_Saida1.Value;
            DateTime saida2 = dtpTer_Saida2.Value;
            int tolerEntrada1 = Convert.ToInt32(nudTer_TolerEntrada1.Value);
            int tolerSaida2 = Convert.ToInt32(nudTer_TolerSaida2.Value);
            Hora horasTrabalho = Hora.GetFromText(txtTer_TotalHoras.Text);
            bool hasIntervalo = chkTer_Intervalo.Checked;

            hr = CreateHorarioDia(HorarioDia.TERCA, enabled, entrada1, entrada2, hasIntervalo, saida1, saida2, tolerEntrada1, tolerSaida2, horasTrabalho);

            return hr;
        }

        private HorarioDia CreateHorarioQuarta() {
            HorarioDia hr = null;

            bool enabled = chkQua_Enabled.Checked;
            DateTime entrada1 = dtpQua_Entrada1.Value;
            DateTime entrada2 = dtpQua_Entrada2.Value;
            DateTime saida1 = dtpQua_Saida1.Value;
            DateTime saida2 = dtpQua_Saida2.Value;
            int tolerEntrada1 = Convert.ToInt32(nudQua_TolerEntrada1.Value);
            int tolerSaida2 = Convert.ToInt32(nudQua_TolerSaida2.Value);
            Hora horasTrabalho = Hora.GetFromText(txtQua_TotalHoras.Text);
            bool hasIntervalo = chkQua_Intervalo.Checked;

            hr = CreateHorarioDia(HorarioDia.QUARTA,enabled, entrada1, entrada2, hasIntervalo, saida1, saida2, tolerEntrada1, tolerSaida2, horasTrabalho);

            return hr;
        }

        private HorarioDia CreateHorarioQuinta() {
            HorarioDia hr = null;

            bool enabled = chkQui_Enabled.Checked;
            DateTime entrada1 = dtpQui_Entrada1.Value;
            DateTime entrada2 = dtpQui_Entrada2.Value;
            DateTime saida1 = dtpQui_Saida1.Value;
            DateTime saida2 = dtpQui_Saida2.Value;
            int tolerEntrada1 = Convert.ToInt32(nudQui_TolerEntrada1.Value);
            int tolerSaida2 = Convert.ToInt32(nudQui_TolerSaida2.Value);
            Hora horasTrabalho = Hora.GetFromText(txtQui_TotalHoras.Text);
            bool hasIntervalo = chkQui_Intervalo.Checked;

            hr = CreateHorarioDia(HorarioDia.QUINTA, enabled, entrada1, entrada2, hasIntervalo, saida1, saida2, tolerEntrada1, tolerSaida2, horasTrabalho);

            return hr;
        }

        private HorarioDia CreateHorarioSexta() {
            HorarioDia hr = null;

            bool enabled = chkSex_Enabled.Checked;
            DateTime entrada1 = dtpSex_Entrada1.Value;
            DateTime entrada2 = dtpSex_Entrada2.Value;
            DateTime saida1 = dtpSex_Saida1.Value;
            DateTime saida2 = dtpSex_Saida2.Value;
            int tolerEntrada1 = Convert.ToInt32(nudSex_TolerEntrada1.Value);
            int tolerSaida2 = Convert.ToInt32(nudSex_TolerSaida2.Value);
            Hora horasTrabalho = Hora.GetFromText(txtSex_TotalHoras.Text);
            bool hasIntervalo = chkSex_Intervalo.Checked;

            hr = CreateHorarioDia(HorarioDia.SEXTA, enabled, entrada1, entrada2, hasIntervalo, saida1, saida2, tolerEntrada1, tolerSaida2, horasTrabalho);

            return hr;
        }

        private HorarioDia CreateHorarioSabado() {
            HorarioDia hr = null;

            bool enabled = chkSab_Enabled.Checked;
            DateTime entrada1 = dtpSab_Entrada1.Value;
            DateTime entrada2 = dtpSab_Entrada2.Value;
            DateTime saida1 = dtpSab_Saida1.Value;
            DateTime saida2 = dtpSab_Saida2.Value;
            int tolerEntrada1 = Convert.ToInt32(nudSab_TolerEntrada1.Value);
            int tolerSaida2 = Convert.ToInt32(nudSab_TolerSaida2.Value);
            Hora horasTrabalho = Hora.GetFromText(txtSab_TotalHoras.Text);
            bool hasIntervalo = chkSab_Intervalo.Checked;

            hr = CreateHorarioDia(HorarioDia.SABADO, enabled, entrada1, entrada2, hasIntervalo, saida1, saida2, tolerEntrada1, tolerSaida2, horasTrabalho);

            return hr;
        }

        private HorarioDia CreateHorarioDomingo() {
            HorarioDia hr = null;

            bool enabled = chkDom_Enabled.Checked;
            DateTime entrada1 = dtpDom_Entrada1.Value;
            DateTime entrada2 = dtpDom_Entrada2.Value;
            DateTime saida1 = dtpDom_Saida1.Value;
            DateTime saida2 = dtpDom_Saida2.Value;
            int tolerEntrada1 = Convert.ToInt32(nudDom_TolerEntrada1.Value);
            int tolerSaida2 = Convert.ToInt32(nudDom_TolerSaida2.Value);
            Hora horasTrabalho = Hora.GetFromText(txtDom_TotalHoras.Text);
            bool hasIntervalo = chkDom_Intervalo.Checked;

            hr = CreateHorarioDia(HorarioDia.DOMINGO, enabled, entrada1, entrada2, hasIntervalo, saida1, saida2, tolerEntrada1, tolerSaida2, horasTrabalho);

            return hr;
        }

        private void chkAll_Enabled_CheckedChanged(object sender, EventArgs e) {
            CalcHorasTotal();
        }

        private void AlterarHorario(HorarioSemana horario) {
            LimparTudo();
            EnableForChange();
            SelectedHorario = horario;

            txtCodigo.Text = horario.Codigo;
            txtDescricao.Text = horario.Descricao;
            chkHasFeriados.Checked = horario.HasFeriados;
            chkHasHrExtras.Checked = horario.HasHorasExtras;
            
            Hora horasTrabalho = new Hora(horario.TotalHoras, horario.TotalMinutos);

            txtTotalHoras.Text = horasTrabalho.ToString();

            FillSegunda(horario.Segunda);
            FillTerca(horario.Terca);
            FillQuarta(horario.Quarta);
            FillQuinta(horario.Quinta);
            FillSexta(horario.Sexta);
            FillSabado(horario.Sabado);
            FillDomingo(horario.Domingo);
            //horario.            
        }

        private void FillSegunda(HorarioDia horario) {
            chkSeg_Enabled.Checked = horario.Enabled;
            dtpSeg_Entrada1.Value = horario.Entrada1;
            dtpSeg_Entrada2.Value = horario.Entrada2;
            dtpSeg_Saida1.Value = horario.Saida1;
            dtpSeg_Saida2.Value = horario.Saida2;
            nudSeg_TolerEntrada1.Value = (decimal) horario.ToleranciaNaEntrada1;
            nudSeg_TolerSaida2.Value = (decimal) horario.ToleranciaNaSaida2;
            txtSeg_TotalHoras.Text = Hora.Create(horario.HorasTrabalho, horario.MinsTrabalho).ToString();
            chkSeg_Intervalo.Checked = horario.HasIntervalo;
        }

        private void FillTerca(HorarioDia horario) {
            chkTer_Enabled.Checked = horario.Enabled;
            dtpTer_Entrada1.Value = horario.Entrada1;
            dtpTer_Entrada2.Value = horario.Entrada2;
            dtpTer_Saida1.Value = horario.Saida1;
            dtpTer_Saida2.Value = horario.Saida2;
            nudTer_TolerEntrada1.Value = (decimal) horario.ToleranciaNaEntrada1;
            nudTer_TolerSaida2.Value = (decimal) horario.ToleranciaNaSaida2;
            txtTer_TotalHoras.Text = Hora.Create(horario.HorasTrabalho, horario.MinsTrabalho).ToString();
            chkTer_Intervalo.Checked = horario.HasIntervalo;
        }

        private void FillQuarta(HorarioDia horario) {
            chkQua_Enabled.Checked = horario.Enabled;
            dtpQua_Entrada1.Value = horario.Entrada1;
            dtpQua_Entrada2.Value = horario.Entrada2;
            dtpQua_Saida1.Value = horario.Saida1;
            dtpQua_Saida2.Value = horario.Saida2;
            nudQua_TolerEntrada1.Value = (decimal) horario.ToleranciaNaEntrada1;
            nudQua_TolerSaida2.Value = (decimal) horario.ToleranciaNaSaida2;
            txtQua_TotalHoras.Text = Hora.Create(horario.HorasTrabalho, horario.MinsTrabalho).ToString();
            chkQua_Intervalo.Checked = horario.HasIntervalo;
        }

        private void FillQuinta(HorarioDia horario) {
            chkQui_Enabled.Checked = horario.Enabled;
            dtpQui_Entrada1.Value = horario.Entrada1;
            dtpQui_Entrada2.Value = horario.Entrada2;
            dtpQui_Saida1.Value = horario.Saida1;
            dtpQui_Saida2.Value = horario.Saida2;
            nudQui_TolerEntrada1.Value = (decimal) horario.ToleranciaNaEntrada1;
            nudQui_TolerSaida2.Value = (decimal) horario.ToleranciaNaSaida2;
            txtQui_TotalHoras.Text = Hora.Create(horario.HorasTrabalho, horario.MinsTrabalho).ToString();
            chkQui_Intervalo.Checked = horario.HasIntervalo;
        }

        private void FillSexta(HorarioDia horario) {
            chkSex_Enabled.Checked = horario.Enabled;
            dtpSex_Entrada1.Value = horario.Entrada1;
            dtpSex_Entrada2.Value = horario.Entrada2;
            dtpSex_Saida1.Value = horario.Saida1;
            dtpSex_Saida2.Value = horario.Saida2;
            nudSex_TolerEntrada1.Value = (decimal) horario.ToleranciaNaEntrada1;
            nudSex_TolerSaida2.Value = (decimal) horario.ToleranciaNaSaida2;
            txtSex_TotalHoras.Text = Hora.Create(horario.HorasTrabalho, horario.MinsTrabalho).ToString();
            chkSex_Intervalo.Checked = horario.HasIntervalo;
        }

        private void FillSabado(HorarioDia horario) {
            chkSab_Enabled.Checked = horario.Enabled;
            dtpSab_Entrada1.Value = horario.Entrada1;
            dtpSab_Entrada2.Value = horario.Entrada2;
            dtpSab_Saida1.Value = horario.Saida1;
            dtpSab_Saida2.Value = horario.Saida2;
            nudSab_TolerEntrada1.Value = (decimal) horario.ToleranciaNaEntrada1;
            nudSab_TolerSaida2.Value = (decimal) horario.ToleranciaNaSaida2;
            txtSab_TotalHoras.Text = Hora.Create(horario.HorasTrabalho, horario.MinsTrabalho).ToString();
            chkSab_Intervalo.Checked = horario.HasIntervalo;
        }

        private void FillDomingo(HorarioDia horario) {
            chkDom_Enabled.Checked = horario.Enabled;
            dtpDom_Entrada1.Value = horario.Entrada1;
            dtpDom_Entrada2.Value = horario.Entrada2;
            dtpDom_Saida1.Value = horario.Saida1;
            dtpDom_Saida2.Value = horario.Saida2;
            nudDom_TolerEntrada1.Value = (decimal) horario.ToleranciaNaEntrada1;
            nudDom_TolerSaida2.Value = (decimal) horario.ToleranciaNaSaida2;
            txtDom_TotalHoras.Text = Hora.Create(horario.HorasTrabalho, horario.MinsTrabalho).ToString();
            chkDom_Intervalo.Checked = horario.HasIntervalo;
        }

        private void btUpdate_Click(object sender, EventArgs e) {         
            AtualizarHorario();
        }

        private void treeViewHorarios_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (e.Node is TreeNodeHorarioSemana) {
                TreeNodeHorarioSemana tnode = (TreeNodeHorarioSemana)e.Node;
                AlterarHorario(tnode.Value);
            }
        }

        private void btRemover_Click(object sender, EventArgs e) {
            RemoverHorario();
        }

        
                
        
    }
}
