using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.settings;
using mz.betainteractive.sigeas.model.basic;
using mz.betainteractive.sigeas.model.ca;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.utilities.module.Components;

namespace mz.betainteractive.sigeas.Views.AccessControl {
    public partial class FrmViewFuncionarioAtt : Form {

        private SigeasDatabaseContext context;
        private Funcionario funcionario;
        private HorarioDia horarioDia;
        private DailyAttCalcs Calculos;               

        public FrmViewFuncionarioAtt() {
            InitializeComponent();
        }

        public void ViewData(SigeasDatabaseContext context, DailyAttCalcs att) {
            this.context = context;

            this.Calculos = att;
            this.funcionario = att.Funcionario;
            this.horarioDia = att.HorarioDia;

            LimparTudo();
            
            this.Text = "Data: " + Calculos.Data.Value.ToLongDateString();

            dtpSaida1.Enabled = horarioDia.HasIntervalo;
            dtpEntrada2.Enabled = horarioDia.HasIntervalo;
            panSeg_Saida1.Enabled = horarioDia.HasIntervalo;
            panSeg_Entrada2.Enabled = horarioDia.HasIntervalo;

            txtFuncionario.Text = funcionario.ToString();
            
            dtpEntrada1.Value = horarioDia.Entrada1;
            dtpEntrada2.Value = horarioDia.Entrada2;
            dtpSaida1.Value = horarioDia.Saida1;
            dtpSaida2.Value = horarioDia.Saida2;

            listViewClocks.Items.Clear();

            TimeSpan ts = (horarioDia.Entrada2 - horarioDia.Saida1);
            DateTime intervalo = Constants.GetTime(ts);

            Hora hrTrab = new Hora(horarioDia.HorasTrabalho, horarioDia.MinsTrabalho);
            Hora workedTime = new Hora(Calculos.TrabalhouHoras, Calculos.TrabalhouMins);
            Hora nonWorkedTime = new Hora(Calculos.AusenteHoras, Calculos.AusenteMins);
            Hora horasExtras = new Hora(Calculos.HrExtrasHoras, Calculos.HrExtrasMins);
            
            txtIntervalo.Text = intervalo.ToString("HH:mm");
            txtHorasToWork.Text = hrTrab.ToString();
            txtWorkedTime.Text = workedTime.ToString();
            txtNonWorkedTime.Text = nonWorkedTime.ToString();
            txtExtraTime.Text = horasExtras.ToString();

            LoadUserClocks();
        }

        private void LoadUserClocks() {
            AccessControlCalculations Calcs = new AccessControlCalculations(context);

            List<UserClock> clocks = Calcs.GetCalculatedClocks(this.funcionario, this.Calculos.Data.Value);

            listViewClocks.Items.Clear();

            foreach (UserClock uc in clocks){
                ListViewItem item = new ListViewItem("");
                item.SubItems.Add(uc.InOutMode.ToString());
                item.SubItems.Add(uc.DateAndTime.ToLongTimeString());
                item.SubItems.Add(uc.Observacoes);
                listViewClocks.Items.Add(item);
            }
        }

        private void LimparTudo() {
            txtFuncionario.Text = "";
            DateTime data = Constants.GetDefaultTime();

            dtpEntrada1.Value = data;
            dtpEntrada2.Value = data;
            dtpSaida1.Value = data;
            dtpSaida2.Value = data;

            listViewClocks.Items.Clear();

            txtIntervalo.Text = "00:00";
            txtHorasToWork.Text = "00:00";
            txtWorkedTime.Text = "00:00";
            txtNonWorkedTime.Text = "00:00";
            txtExtraTime.Text = "00:00";
        }

        private void txtFuncionario_TextChanged(object sender, EventArgs e) {

        }

       
    }
}
