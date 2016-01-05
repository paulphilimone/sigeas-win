using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.settings;
using mz.betainteractive.sigeas.model.ca;
using mz.betainteractive.sigeas.utilities;

namespace mz.betainteractive.sigeas.Views.AccessControl {
    public partial class FrmRegistosBiometrico : Form {

        private SystemDatabases SDB;
        private AttendanceCalculations calculations;
        private List<UserClock> searchedClocks;
        private FrmEditUserClock EditClockForm;

        public FrmRegistosBiometrico() {
            InitializeComponent();
            SDB = MainView.SystemDatabase;
            calculations = new AttendanceCalculations();
            searchedClocks = new List<UserClock>();
            EditClockForm = new FrmEditUserClock();
        }

        private void FrmRegistosBiometrico_Load(object sender, EventArgs e) {
            LoadDepartamentos();
            LoadCategorias();
            LimparLista();
        }

        private void LimparLista() {
            listLogData.Items.Clear();
        }

        public void LoadCategorias() {
            DBSearch.FillCategoria(cboCategoria);
            cboCategoria.Items.Insert(0, "Todos");
            cboCategoria.SelectedIndex = 0;            
        }

        public void LoadDepartamentos() {
            DBSearch.FillDepartamento(cboDepartamento);
            cboDepartamento.Items.Insert(0, "Todos");
            cboDepartamento.SelectedIndex = 0;
        }

        private void FindFuncionario() {
            Departamento depart = null;
            Categoria categoria = null;
            bool allDepart = false;
            bool allCategr = false;


            if (cboDepartamento.SelectedIndex != -1) {
                if (cboDepartamento.SelectedItem is Departamento) {
                    depart = (Departamento)cboDepartamento.SelectedItem;
                } else {
                    allDepart = true;
                }                
            }
            if (cboCategoria.SelectedIndex != -1) {
                if (cboCategoria.SelectedItem is Categoria) {
                    categoria = (Categoria)cboCategoria.SelectedItem;
                } else {
                    allCategr = true;
                }
            }

            cboFuncionario.Items.Clear();
            cboFuncionario.ResetText();

            if (allDepart == true && allCategr == true) {
                List<Funcionario> funs = DBSearch.FindAllFuncionario();
                FillFuncionario(funs);
                return;
            }

            if (allDepart == true && categoria != null) {
                List<Funcionario> funs = DBSearch.FindAllFuncionarioBy(categoria);
                FillFuncionario(funs);
                return;
            }

            if (allCategr == true && depart != null) {
                List<Funcionario> funs = DBSearch.FindAllFuncionarioBy(depart);
                FillFuncionario(funs);
                return;
            }

            if (depart == null && categoria == null) {
                return;
            }

            if (depart == null) {
                List<Funcionario> funs = DBSearch.FindAllFuncionarioBy(categoria);
                FillFuncionario(funs);
                return;
            }
            if (categoria == null) {
                List<Funcionario> funs = DBSearch.FindAllFuncionarioBy(depart);
                FillFuncionario(funs);
                return;
            }

            List<Funcionario> funcs = DBSearch.FindAllFuncionarioBy(depart, categoria);
            FillFuncionario(funcs);

        }

        private void FillFuncionario(List<Funcionario> funs) {
            cboFuncionario.Items.Clear();
            cboFuncionario.ResetText();
            cboFuncionario.Items.AddRange(funs.ToArray());
        }               

        private MainView getMain() {
            return MainView.MainProgram;
        }

        private void btDownloadDevToDB_Click(object sender, EventArgs e) {
            Downloads();
        }

        private void Downloads() {
            if (SDB.ConnectedDevices.Count == 0) {
                MessageBox.Show("Não existem dispositivos conectados ao sistema!\nConecte um/mais dispositivo(s) primeiro");
                return;
            }

            MainView.tssGeralSystemStatus.Text = "Descarregando dados...";
            bgwDownloadAll.RunWorkerAsync();
            getMain().BackgroundPopup.LabelText.Text = "Descarregando dados...";
            getMain().BackgroundPopup.ShowDialog();
        }

        private void bgwDownloadAll_DoWork(object sender, DoWorkEventArgs e) {
            DownloadClocksFromDevices();
        }

        private void DownloadClocksFromDevices() {
            foreach (Device device in SDB.ConnectedDevices) {
                device.Download.AttendanceDataToDatabase();
            }
        }

        private void bgwDownloadAll_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            MainView.tssGeralSystemStatus.Text = "Descarregamento concluido";
            getMain().BackgroundPopup.Hide();
            SearchUserClocks();
        }

        private void FrmRegistosBiometrico_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
        }

        private void btPesquisar_Click(object sender, EventArgs e) {            
            Pesquisar();            
        }

        private void Pesquisar() { 
            MainView.tssGeralSystemStatus.Text = "Pesquisar registos de entrada/saidas...";            
            getMain().BackgroundPopup.LabelText.Text = "Pesquisar registos de entrada/saidas...";
            bgwSearchClocks.RunWorkerAsync();
            getMain().BackgroundPopup.ShowDialog();
        }                

        private void SearchUserClocks() {
            searchedClocks.Clear();

            DateTime frd = dtpFromDate.Value;
            DateTime tod = dtpToDate.Value;
            DateTime frt = dtpFromTime.Value;
            DateTime tot = dtpToTime.Value;

            DateTime fromDate = new DateTime(frd.Year, frd.Month, frd.Day, frt.Hour, frt.Minute, 0);
            DateTime toDate = new DateTime(tod.Year, tod.Month, tod.Day, tot.Hour, tot.Minute, 0);

            List<Funcionario> funcionarios = new List<Funcionario>();

            funcionarios.AddRange(cboFuncionario.Items.OfType<Funcionario>());

            List<UserClock> clocks = DBSearch.FindAllUserClockFromTo(funcionarios, fromDate, toDate);

            searchedClocks.AddRange(clocks);

            //Console.WriteLine("FUNC: "+funcionarios.Count);
            Console.WriteLine("clocks: " + clocks.Count);                                                         
        }

        private void ViewSearchedClocks() {
            FillListaUserClocks(searchedClocks);
        }

        private void FillListaUserClocks(List<UserClock> clocks) {
                        
            listLogData.Items.Clear();
            
            if (clocks.Count == 0) {
                MessageBox.Show("Não foram encontrados registos de entradas e saidas. \nNB: Tente descarregar os dados do biométrico primeiro!");
                return;
            }
            
            foreach (UserClock uc in clocks){
                ListViewItemUserClock item = new ListViewItemUserClock(uc);
                listLogData.Items.Add(item);
                item.UpdateColumns();
            }
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e) {
            FindFuncionario();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e) {
            FindFuncionario();
        }

        private void btFechar_Click(object sender, EventArgs e) {
            this.Close();

        }

        private void StartCorrectData() {
            
            MainView.tssGeralSystemStatus.Text = "Corrigindo entrada/saidas...";            
            getMain().BackgroundPopup.LabelText.Text = "Corrigindo entrada/saidas...";
            bgwCorrectData.RunWorkerAsync();
            getMain().BackgroundPopup.ShowDialog();
            
        }

        private void bgwCorrectData_DoWork(object sender, DoWorkEventArgs e) {
            CorrectData();
        }

        private void CorrectData() {
            searchedClocks.Clear();

            calculations.Funcionarios.Clear();
            List<Funcionario> funcionarios = new List<Funcionario>();
            funcionarios.AddRange(cboFuncionario.Items.OfType<Funcionario>());

            DateTime frd = dtpFromDate.Value;
            DateTime tod = dtpToDate.Value;
            DateTime frt = dtpFromTime.Value;
            DateTime tot = dtpToTime.Value;

            DateTime fromDate = new DateTime(frd.Year, frd.Month, frd.Day, frt.Hour, frt.Minute, 0);
            DateTime toDate = new DateTime(tod.Year, tod.Month, tod.Day, tot.Hour, tot.Minute, 0);
            
            calculations.StartCorrectAttendanceData(funcionarios);

            List<UserClock> list = calculations.GetCorrectedData(fromDate, toDate);
            searchedClocks.AddRange(list);
            //The rest is 
        }

        private void ViewCorrectedData() {            
            FillListaUserClocks(searchedClocks);
        }

        private void bgwCorrectData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            MainView.tssGeralSystemStatus.Text = "Registos de ent/sai corrigidos";
            getMain().BackgroundPopup.Hide();

            ViewCorrectedData();        
        }

        private void bgwSearchClocks_DoWork(object sender, DoWorkEventArgs e) {
            SearchUserClocks();
        }

        private void bgwSearchClocks_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            MainView.tssGeralSystemStatus.Text = "Pesquisa concluida";
            getMain().BackgroundPopup.Hide();
            ViewSearchedClocks();
        }

        private void btSearchAndCorrect_Click(object sender, EventArgs e) {
            StartCorrectData();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e) {
            if (listLogData.SelectedIndices.Count > 0) {
                if (listLogData.SelectedItems[0] is ListViewItemUserClock) {
                    ListViewItemUserClock item = (ListViewItemUserClock)listLogData.SelectedItems[0];
                    AlterarUserClock(item.Value);
                }
                
            }
            
        }

        private void AlterarUserClock(UserClock userClock) {
            EditClockForm.Edit(userClock);
            EditClockForm.ShowDialog();
        }

        private void menuStripUserClock_Opening(object sender, CancelEventArgs e) {
            alterarToolStripMenuItem.Enabled = listLogData.SelectedIndices.Count > 0;            
        }

        private void btInsertClock_Click(object sender, EventArgs e) {
            InsertUserClock();
        }

        private void InsertUserClock() {
            if (cboFuncionario.SelectedIndex == -1 || !(cboFuncionario.SelectedItem is Funcionario)){
                MessageBox.Show("Selecione o funcionário primeiro");
                cboFuncionario.Focus();
                return;
            }

            Funcionario func = (Funcionario) cboFuncionario.SelectedItem;

            EditClockForm.New(func);
            EditClockForm.ShowDialog();            
        }
              

       
    }
}
