using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using mz.betainteractive.sigeas.utilities;
using System.Collections;
using mz.betainteractive.sigeas.model.ca;

namespace mz.betainteractive.sigeas {
    public partial class FrmPeriodosAno : Form {
        public FrmPeriodosAno() {
            InitializeComponent();
        }

        private void btLimpar_Click(object sender, EventArgs e) {
            LimparLista();
        }

        private void LimparLista() {
            listViewMeses.Items.Clear();
            listViewSemanas.Items.Clear();
            listViewMeses.Refresh();
            listViewSemanas.Refresh();
            btGravarMeses.Enabled = false;
            btGravarSemanas.Enabled = false;            
        }

        private void btFechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btGenerateWeeks_Click(object sender, EventArgs e) {
            LimparLista();
            GenerateMonths();
            GenerateWeeks();
        }

        private void GenerateMonths() {
            int ano = (int)nudAnos.Value;

            List<MesAno> meses = Mathematics.GenerateMonthsOfYear(ano);

            foreach (MesAno mes in meses) {
                ListViewItemMesAno item = new ListViewItemMesAno(mes);
                listViewMeses.Items.Add(item);
            }

            listViewMeses.Refresh();

            if (listViewMeses.Items.Count > 0) {
                btGravarMeses.Enabled = true;
            }
        }

        private void GenerateWeeks() {
            int ano = (int) nudAnos.Value;

            List<SemanaAno> semanas = Mathematics.GenerateWeeksOfYear(ano);                     

            foreach(SemanaAno sem in semanas){
                ListViewItemSemanaAno item = new ListViewItemSemanaAno(sem);
                listViewSemanas.Items.Add(item);
            }
            
            listViewSemanas.Refresh();

            if (listViewSemanas.Items.Count > 0) {
                btGravarSemanas.Enabled = true;
            }
        }

        private void listAnos_SelectedIndexChanged(object sender, EventArgs e) {
            SelectAno();
        }
        /*
        private void LoadAnosBySemanas() {
            var DB = new BetaInteractiveSisga();

            var anos = (from sem in DB.SemanaAno
                       select sem.Ano).Distinct();

            listAnos.Items.Clear();

            foreach (int ano in anos) {
                listAnos.Items.Add(ano);
            }

            listAnos.Refresh();
        }


        private void LoadAnosByMes() {
            var DB = new BetaInteractiveSisga();

            var anos = (from mes in DB.MesAno
                       select mes.Ano).Distinct();

            listAnos.Items.Clear();

            foreach (int ano in anos) {
                listAnos.Items.Add(ano);
            }

            listAnos.Refresh();
        }*/

        private void LoadAnos() {
            var DB = new SisgaDatabaseContext();

            var anos1 = (from mes in DB.MesAno
                        select mes.Ano).Distinct();

            var anos2 = (from sem in DB.SemanaAno
                        select sem.Ano).Distinct();


            List<int> anos = new List<int>();
            
            anos.AddRange(anos1.ToList<int>());
            anos.AddRange(anos2.ToList<int>());                        

            listAnos.Items.Clear();

            foreach (int ano in anos.Distinct()) {
                listAnos.Items.Add(ano);
            }

            listAnos.Refresh();
        }


        private void SelectAno() {
            if (listAnos.SelectedItem is int) {
                int ano = (int) listAnos.SelectedItem;
                List<MesAno> meses = DBSearch.GetMesesByAno(ano);
                List<SemanaAno> semanas = DBSearch.GetSemanasByAno(ano);

                listViewMeses.Items.Clear();
                listViewSemanas.Items.Clear();

                foreach (MesAno mes in meses) {
                    ListViewItemMesAno item = new ListViewItemMesAno(mes);
                    listViewMeses.Items.Add(item);
                }

                foreach (SemanaAno sem in semanas) {
                    ListViewItemSemanaAno item = new ListViewItemSemanaAno(sem);
                    listViewSemanas.Items.Add(item);
                }

                listViewMeses.Refresh();
                listViewSemanas.Refresh();
                btGravarMeses.Enabled = false;
                btGravarSemanas.Enabled = false;
            }
        }

        private void FrmSemanasAno_Load(object sender, EventArgs e) {
            LoadAnos();
            LimparLista();
        }

        private void btGravarSemanas_Click(object sender, EventArgs e) {
            GravarSemanaAnos();
        }

        private void GravarSemanaAnos() {

            if (listViewSemanas.Items.Count == 0) {
                MessageBox.Show("Não existem semanas para gravar");
                return;
            }

            using (var DBX = new SisgaDatabaseContext()) {
                int ano = 0;

                foreach (ListViewItem item in listViewSemanas.Items) {
                    if (item is ListViewItemSemanaAno) {
                        ListViewItemSemanaAno itemSem = (ListViewItemSemanaAno)item;
                        ano = itemSem.Value.Ano;
                        break;
                    }
                }

                var anos = from a in DBX.SemanaAno
                           where a.Ano == ano
                           select a;

                if (anos.Count() > 0) {
                    MessageBox.Show("As semanas do ano (" + ano + ") já foram registadas no sistema");
                    return;
                }
            }

            DialogResult dr = MessageBox.Show("Tem certeza que deseja gravar as semanas que estão na lista?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            List<SemanaAno> semanas = new List<SemanaAno>();

            foreach (ListViewItem item in listViewSemanas.Items) {
                if (item is ListViewItemSemanaAno) {
                    ListViewItemSemanaAno itemSem = (ListViewItemSemanaAno)item;
                    semanas.Add(itemSem.Value);
                }
            }

            var DB = new SisgaDatabaseContext();

            DB.SemanaAno.InsertAllOnSubmit(semanas);
            DB.SubmitChanges();
            LoadAnos();
            MessageBox.Show("As semanas foram gravadas com sucesso");
        }

        private void GravarMesesAno() {

            if (listViewMeses.Items.Count == 0) {
                MessageBox.Show("Não existem meses para gravar");
                return;
            }

            using (var DBX = new SisgaDatabaseContext()) {
                int ano = 0;

                foreach (ListViewItem item in listViewMeses.Items) {
                    if (item is ListViewItemMesAno) {
                        ListViewItemMesAno itemMes = (ListViewItemMesAno)item;
                        ano = itemMes.Value.Ano;
                        break;
                    }
                }

                var anos = from a in DBX.MesAno
                           where a.Ano == ano
                           select a;

                if (anos.Count() > 0) {
                    MessageBox.Show("Os meses do ano (" + ano + ") já foram registados no sistema");
                    return;
                }
            }

            DialogResult dr = MessageBox.Show("Tem certeza que deseja gravar os meses que estão na lista?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            List<MesAno> meses = new List<MesAno>();

            foreach (ListViewItem item in listViewMeses.Items) {
                if (item is ListViewItemMesAno) {
                    ListViewItemMesAno itemMes = (ListViewItemMesAno)item;
                    meses.Add(itemMes.Value);
                }
            }

            var DB = new SisgaDatabaseContext();

            DB.MesAno.InsertAllOnSubmit(meses);
            DB.SubmitChanges();
            LoadAnos();

            MessageBox.Show("Os meses foram gravados com sucesso");
        }

        private void FrmSemanasAno_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
        }

        private void btGravarMeses_Click(object sender, EventArgs e) {
            GravarMesesAno();
        }
    }
}
