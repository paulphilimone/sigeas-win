using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.model.ca;
using mz.betainteractive.sigeas.Utilities;
using System.Threading;
using System.Globalization;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.utilities.module.BackgroundFeatures;
using mz.betainteractive.sigeas.model.basic;
using mz.betainteractive.utilities.module.Components;
using mz.betainteractive.utilities.module.Collections;

namespace mz.betainteractive.sigeas.Views.AccessControl {
    public partial class AttendanceCalcsView : Form, AuthorizableComponent {

        private SigeasDatabaseContext context;

        private AccessControlCalculations calculations;
        private List<DailyAttCalcs> SearchedAttCalcs;
        private List<DailyAttCalcs> SearchedAndCalculatedAttCalcs;
        private List<MonthlyAttCalcs> SearchedMonthlyAttCalcs;
        private List<MonthlyAttCalcs> SearchedMonthlyAndCalculatedAttCalcs;
        private FrmViewFuncionarioAtt FuncionarioAttForm;

        private List<DataGridViewColumn> monthlyAttCalcsColumns;
        private List<DataGridViewColumn> dailyAttCalcsColumns;

        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }

        public AttendanceCalcsView() {
            InitializeComponent();
            
            SearchedAttCalcs = new List<DailyAttCalcs>();
            SearchedAndCalculatedAttCalcs = new List<DailyAttCalcs>();
            SearchedMonthlyAttCalcs = new List<MonthlyAttCalcs>();
            SearchedMonthlyAndCalculatedAttCalcs = new List<MonthlyAttCalcs>();
            FuncionarioAttForm = new FrmViewFuncionarioAtt();
        }
        
        private void DisposeContext() {
            if (context != null) {
                context.Dispose();
                context = null;
                calculations = null;
            }
        }

        private void LoadContext() {
            if (context == null) {
                context = new SigeasDatabaseContext();
                calculations = new AccessControlCalculations(context);
            }
        }

        private void FrmCalculoAsseduidade_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
            DisposeContext();
        }

        private void FrmCalculoAsseduidade_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                LoadContext();
                Initialize();
            }
        }

        private void Initialize() {
            DtpToDate.Value = DateTime.Now;
            DtpFromDate.Value = DtpToDate.Value.AddMonths(-1);
            LoadDepartamentosToComboBox();
            LoadCategoriasToComboBox();
            LoadMonthWorksToComboBox();
            LimparLista();
            CreateColumnsForDailyAttCalcs();
            CreateColumnsForMonthlyAttCalcs();

            this.DGViewAttCalcs.Columns.AddRange(dailyAttCalcsColumns.ToArray());
        }

        private void CreateColumnsForDailyAttCalcs() {
            this.dailyAttCalcsColumns = new List<DataGridViewColumn>();

            var ColFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColWeekDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColEntrada1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColSaida1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColEntrada2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColSaida2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColClockIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColClockOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColEntradaAtrasada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColSaidaAdiantada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColPreste = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            var ColHorasTrabalho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColHorasAusente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColHorasExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColFeriado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            var ColEmFerias = new System.Windows.Forms.DataGridViewCheckBoxColumn();

            // 
            // ColFuncionario
            ColFuncionario.HeaderText = "Nome";
            ColFuncionario.Name = "ColFuncionario";
            ColFuncionario.ReadOnly = true;
            // 
            // ColDay
            ColDay.HeaderText = "Data";
            ColDay.Name = "ColDay";
            ColDay.ReadOnly = true;
            ColDay.Width = 70;
            // 
            // ColWeekDay
            ColWeekDay.HeaderText = "Dia. Semana";
            ColWeekDay.Name = "ColWeekDay";
            ColWeekDay.ReadOnly = true;
            // 
            // ColEntrada1
            ColEntrada1.HeaderText = "1ª Entrada";
            ColEntrada1.Name = "ColEntrada1";
            ColEntrada1.ReadOnly = true;
            // 
            // ColSaida1
            ColSaida1.HeaderText = "1ª Saida";
            ColSaida1.Name = "ColSaida1";
            ColSaida1.ReadOnly = true;
            // 
            // ColEntrada2
            ColEntrada2.HeaderText = "2ª Entrada";
            ColEntrada2.Name = "ColEntrada2";
            ColEntrada2.ReadOnly = true;
            // 
            // ColSaida2
            ColSaida2.HeaderText = "2ª Saida";
            ColSaida2.Name = "ColSaida2";
            ColSaida2.ReadOnly = true;
            // 
            // ColClockIn
            ColClockIn.HeaderText = "Entrou ás";
            ColClockIn.Name = "ColClockIn";
            ColClockIn.ReadOnly = true;
            // 
            // ColClockOut
            ColClockOut.HeaderText = "Saiu ás";
            ColClockOut.Name = "ColClockOut";
            ColClockOut.ReadOnly = true;
            // 
            // ColEntradaAtrasada
            ColEntradaAtrasada.HeaderText = "Atraso";
            ColEntradaAtrasada.Name = "ColEntradaAtrasada";
            ColEntradaAtrasada.ReadOnly = true;
            // 
            // ColSaidaAdiantada
            ColSaidaAdiantada.HeaderText = "S. Adiantada";
            ColSaidaAdiantada.Name = "ColSaidaAdiantada";
            ColSaidaAdiantada.ReadOnly = true;
            // 
            // ColPreste
            ColPreste.HeaderText = "Presente";
            ColPreste.Name = "ColPreste";
            ColPreste.ReadOnly = true;
            ColPreste.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ColPreste.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColHorasTrabalho
            ColHorasTrabalho.HeaderText = "H. Trabalho";
            ColHorasTrabalho.Name = "ColHorasTrabalho";
            ColHorasTrabalho.ReadOnly = true;
            // 
            // ColHorasAusente
            ColHorasAusente.HeaderText = "H. Ausente";
            ColHorasAusente.Name = "ColHorasAusente";
            ColHorasAusente.ReadOnly = true;
            // 
            // ColHorasExtras
            ColHorasExtras.HeaderText = "H. Extras";
            ColHorasExtras.Name = "ColHorasExtras";
            ColHorasExtras.ReadOnly = true;
            // 
            // ColFeriado
            ColFeriado.HeaderText = "Feriado";
            ColFeriado.Name = "ColFeriado";
            ColFeriado.ReadOnly = true;
            ColFeriado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ColFeriado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColEmFerias
            ColEmFerias.HeaderText = "De férias";
            ColEmFerias.Name = "ColEmFerias";
            ColEmFerias.ReadOnly = true;
            ColEmFerias.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ColEmFerias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;

            this.dailyAttCalcsColumns.AddRange(new DataGridViewColumn[] {
                                    ColFuncionario, ColDay, ColWeekDay, ColEntrada1, ColSaida1, ColEntrada2, ColSaida2, ColClockIn, ColClockOut, ColEntradaAtrasada, 
                                    ColSaidaAdiantada, ColPreste, ColHorasTrabalho, ColHorasAusente, ColHorasExtras, ColFeriado, ColEmFerias});
        }

        private void CreateColumnsForMonthlyAttCalcs() {
            this.monthlyAttCalcsColumns = new List<DataGridViewColumn>();

            var ColFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColFromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColTotalWorkTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColWorkedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColAbsentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColTotalHorasExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();            
            var ColHolidays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            var ColOnVacation = new System.Windows.Forms.DataGridViewCheckBoxColumn();


            ColFuncionario.HeaderText = "Funcionário";
            ColMonth.HeaderText = "Mês";
            ColYear.HeaderText = "Ano";
            ColFromDate.HeaderText = "Data Inicial";
            ColToDate.HeaderText = "Data Final";
            ColTotalWorkTime.HeaderText = "Total de H. por Trabalhar";
            ColWorkedTime.HeaderText = "Horas Trabalhadas";
            ColAbsentTime.HeaderText = "Horas Ausentes";
            ColTotalHorasExtras.HeaderText = "Total H. Extras";
            ColHolidays.HeaderText = "Feriados";
            ColOnVacation.HeaderText = "Em férias";

            this.monthlyAttCalcsColumns.AddRange(new DataGridViewColumn[] {ColFuncionario, ColMonth, ColYear, ColFromDate, ColToDate, ColTotalWorkTime,
                                                 ColWorkedTime, ColAbsentTime, ColTotalHorasExtras, ColHolidays, ColOnVacation} );
        }

        private void LimparLista() {
            SearchedAttCalcs.Clear();
            SearchedAndCalculatedAttCalcs.Clear();
            DGViewAttCalcs.Rows.Clear();
        }

        private void LoadDepartamentosToComboBox() {
            Empresa empresa = SystemManager.GetCurrentEmpresa(context);

            var depts = context.Departamento.AsNoTracking().Where(t => t.Empresa.Id == empresa.Id).ToList();

            CBoxFuncionarios.Items.Clear();
            CBoxDepartamentos.Items.Clear();

            foreach (var dept in depts) {
                CBoxDepartamentos.Items.Add(dept);
            }

            CBoxDepartamentos.Items.Insert(0, "Todos");
        }

        private void LoadCategoriasToComboBox() {
            Empresa empresa = SystemManager.GetCurrentEmpresa(context);

            var categs = context.Categoria.AsNoTracking().Where(t => t.Empresa.Id == empresa.Id).ToList();

            CBoxFuncionarios.Items.Clear();
            CBoxCategorias.Items.Clear();

            foreach (var catg in categs) {
                CBoxCategorias.Items.Add(catg);
            }

            CBoxCategorias.Items.Insert(0, "Todos");
        }

        private void CBoxDepartamentos_SelectedIndexChanged(object sender, EventArgs e) {
            if (CBoxDepartamentos.SelectedIndex != -1) {
                OnSelectDepartamentoOrCategoria();
            }
        }

        private void CBoxCategorias_SelectedIndexChanged(object sender, EventArgs e) {
            OnSelectDepartamentoOrCategoria();
        }

        private void OnSelectDepartamentoOrCategoria() {
            Departamento departamento = null;
            Categoria categoria = null;


            if (CBoxDepartamentos.SelectedItem is Departamento) {
                departamento = CBoxDepartamentos.SelectedItem as Departamento;
            }
            if (CBoxCategorias.SelectedItem is Categoria) {
                categoria = CBoxCategorias.SelectedItem as Categoria;
            }

            CBoxFuncionarios.Items.Clear();
            CBoxFuncionarios.ResetText();

            LoadFuncionarios(departamento, categoria);

        }

        private void LoadFuncionarios(Departamento departamento, Categoria categoria) {
            CBoxFuncionarios.Items.Clear();

            List<Funcionario> funcionarios = new List<Funcionario>();

            if (context.Funcionario.Count() == 0) return;

            if (categoria == null && departamento == null) {
                funcionarios = context.Funcionario.ToList();
            }

            if (categoria == null) {
                funcionarios.AddRange(context.Funcionario.Where(f => f.Departamento.Id == departamento.Id).ToList());
            }

            if (departamento == null) {
                funcionarios.AddRange(context.Funcionario.Where(f => f.Categoria.Id == categoria.Id).ToList());
            }

            foreach (Funcionario funcionario in funcionarios) {
                //if (funcionario.CompleteRegistered == true) {
                    CBoxFuncionarios.Items.Add(funcionario);
                //}
            }

            CBoxFuncionarios.Items.Insert(0, "Todos");
        }                

        private void btPesquisar_Click(object sender, EventArgs e) {
            SearchAttendanceData();
        }

        private List<Funcionario> getFuncionarios() {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Departamento departamento = null;
            Categoria categoria = null;
            Funcionario func = null;

            if (CBoxFuncionarios.SelectedItem is Funcionario) {
                func = CBoxFuncionarios.SelectedItem as Funcionario;
            }
            if (CBoxCategorias.SelectedItem is Categoria) {
                categoria = CBoxCategorias.SelectedItem as Categoria;
            }
            if (CBoxDepartamentos.SelectedItem is Departamento) {
                departamento = CBoxDepartamentos.SelectedItem as Departamento;
            }

            if (func != null) {
                funcionarios.Add(func);
            } else if (categoria == null && departamento == null) {
                funcionarios.AddRange(context.Funcionario.ToList());
            } else if (categoria == null) {
                funcionarios.AddRange(context.Funcionario.Where(f => f.Departamento.Id == departamento.Id).ToList());
            } else if (departamento == null) {
                funcionarios.AddRange(context.Funcionario.Where(f => f.Categoria.Id == categoria.Id).ToList());
            }

            return funcionarios;
        }

        private void SearchAttendanceData() {
            
            OnExecuteDialog background = new OnExecuteDialog("Pesquisa de Dados....", "Pesquisando registos calculados no sistema...");
            bool result = false;

            List<Funcionario> funcionarios = getFuncionarios();

            background.OnExecute += delegate() {
                SearchedAttCalcs.Clear();

                DateTime fromDate = DtpFromDate.Value.Date;
                DateTime toDate = DtpToDate.Value.Date;
                                
                SearchedAttCalcs.AddRange(DBSearch.FindAllAttendanceCalcs(context, funcionarios, fromDate, toDate, false));

                result = SearchedAttCalcs.Count > 0;
            };

            background.OnPostExecute += delegate() {
                ViewSearchedAttendanceCalcs();
            };

            background.StartExecute();
        }
        
        private void ViewSearchedAttendanceCalcs() {
            DGViewAttCalcs.Columns.Clear();
            DGViewAttCalcs.Columns.AddRange(dailyAttCalcsColumns.ToArray());
            FillListaAttCalcs(SearchedAttCalcs);
        }

        private void FillListaAttCalcs(List<DailyAttCalcs> list) {

            DGViewAttCalcs.Rows.Clear();

            if (list.Count == 0) {
                MessageBox.Show("Não existem dados calculados para a pesquisa efectuada");
                return;
            }

            int i = 1;
            foreach (DailyAttCalcs att in list) {

                DataGridViewGenericRow<DailyAttCalcs> row = new DataGridViewGenericRow<DailyAttCalcs>(att);

                row.CreateCells(DGViewAttCalcs);
                row.Cells[0].Value = att.Funcionario.ToString();
                row.Cells[1].Value = att.Data.Value.ToString("yyyy-MM-dd");
                row.Cells[2].Value = att.Data.Value.ToString("dddd");
                row.Cells[3].Value = att.HorarioDia.Entrada1.ToShortTimeString(); //1ª In
                row.Cells[4].Value = att.HorarioDia.Saida1.ToShortTimeString(); //1ª Out
                row.Cells[5].Value = att.HorarioDia.Entrada2.ToShortTimeString(); //2ª In
                row.Cells[6].Value = att.HorarioDia.Saida2.ToShortTimeString(); //2ª Out
                row.Cells[7].Value = att.Entrada.ToShortTimeString(); //In
                row.Cells[8].Value = att.Saida.ToShortTimeString(); //Out
                row.Cells[9].Value = att.EntradaAtrasada.ToShortTimeString(); //Atraso
                row.Cells[10].Value = att.SaidaAdiantada.ToShortTimeString(); //Adianto
                row.Cells[11].Value = att.IsPresente; //Presente
                row.Cells[12].Value = new Hora(att.TrabalhouHoras, att.TrabalhouMins).ToString(); //H.Trabalhou
                row.Cells[13].Value = new Hora(att.AusenteHoras, att.AusenteMins).ToString(); //H.Ausente
                row.Cells[14].Value = new Hora(att.HrExtrasHoras, att.HrExtrasMins).ToString(); //H. Extras
                row.Cells[15].Value = att.IsFeriado; //Feriado  - bool
                row.Cells[16].Value = att.IsEmFerias; //EmFerias - bool

                if (!att.IsDayWork){
                    row.DefaultCellStyle.BackColor = Color.DarkGray;
                }

                DGViewAttCalcs.Rows.Add(row);
                i++;
            }

        }
        
        private void PesquisarAndCalculate() {

            if (context.FuncionarioHorario.Count()==0) {
                MessageBox.Show("Não existem horarios associados ha funcionarios");
                return;
            }

            OnExecuteDialog background = new OnExecuteDialog("Calculos de asseduidade....", "Efectuando calculos de asseduidade...");
            //bool result = false;

            List<Funcionario> funcionarios = getFuncionarios();

            background.OnExecute += delegate() {
                SearchedAttCalcs.Clear();

                DateTime fromDate = DtpFromDate.Value.Date;
                DateTime toDate = DtpToDate.Value.Date;
                                
                Console.WriteLine("Started calcs");
                                
                calculations.CalculateAttendanceData(funcionarios, fromDate, toDate);

                SearchedAndCalculatedAttCalcs.AddRange(DBSearch.FindAllAttendanceCalcs(context, funcionarios, fromDate, toDate, false));
                Console.WriteLine("Ended Started calcs");
                                
            };

            background.OnPostExecute += delegate() {
                ViewCalculatedAttendanceCalcs();
            };

            background.StartExecute();
        }

        private void ViewCalculatedAttendanceCalcs() {
            DGViewAttCalcs.Columns.Clear();
            DGViewAttCalcs.Columns.AddRange(dailyAttCalcsColumns.ToArray());
            FillListaAttCalcs(SearchedAndCalculatedAttCalcs);
        }
        
        private void btFechar_Click(object sender, EventArgs e) {
            this.Close();
        }                

        private void btLimpar_Click(object sender, EventArgs e) {
            LimparLista();
        }

        private void btSearchAndCalculate_Click(object sender, EventArgs e) {
            PesquisarAndCalculate();
        }

        private void MenuStripDGV_Opening(object sender, CancelEventArgs e) {
            if (DGViewAttCalcs.SelectedRows.Count==0){
                e.Cancel = true;
            }
        }

        private void dgvAttCalcs_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (DGViewAttCalcs.SelectedRows.Count == 1) {
                ViewFuncionarioRegs();
            }
            
        }

        private void ViewFuncionarioRegs() {
            DataGridViewRow row = DGViewAttCalcs.SelectedRows[0];

            if (row is DataGridViewGenericRow<DailyAttCalcs>) {
                DataGridViewGenericRow<DailyAttCalcs> grow = (DataGridViewGenericRow<DailyAttCalcs>)row;
                FuncionarioAttForm.ViewData(context, grow.Value);
                FuncionarioAttForm.ShowDialog();
            }
        }

        private void verRegistosToolStripMenuItem_Click(object sender, EventArgs e) {
            if (DGViewAttCalcs.SelectedRows.Count == 1) {
                ViewFuncionarioRegs();
            }
        }

        private void CBoxMonthWorks_SelectedIndexChanged(object sender, EventArgs e) {
            OnMonthWorkSelected();
        }

        private void LoadMonthWorksToComboBox() {
            var months = context.MonthWork.Where(t => t.Enabled == true).ToList();

            CBoxMonthWorks.Items.Clear();

            foreach (var month in months) {
                CBoxMonthWorks.Items.Add(month);
            }
        }

        private void OnMonthWorkSelected() {
            MonthWork monthWork = CBoxMonthWorks.SelectedItem as MonthWork;

            if (monthWork == null) return;

            DtpFromDate.Value = monthWork.First;
            DtpToDate.Value = monthWork.Last;
        }

        private void BtnMonthSearch_Click(object sender, EventArgs e) {
            SearchMonthlyAttendanceData();
        }

        private void SearchMonthlyAttendanceData() {

            OnExecuteDialog background = new OnExecuteDialog("Pesquisa de Dados....", "Pesquisando registos de calculos mensais no sistema...");
            bool result = false;

            List<Funcionario> funcionarios = getFuncionarios();
            
            background.OnExecute += delegate() {
                SearchedMonthlyAttCalcs.Clear();

                DateTime fromDate = DtpFromDate.Value.Date;
                DateTime toDate = DtpToDate.Value.Date;

                SearchedMonthlyAttCalcs.AddRange(DBSearch.FindAllMonthlyAttendanceCalcs(context, funcionarios, fromDate, toDate, false));

                result = SearchedMonthlyAttCalcs.Count > 0;
            };

            background.OnPostExecute += delegate() {
                ViewSearchedMonthlyAttendanceCalcs();
            };

            background.StartExecute();
        }

        private void ViewSearchedMonthlyAttendanceCalcs() {
            DGViewAttCalcs.Columns.Clear();
            DGViewAttCalcs.Columns.AddRange(monthlyAttCalcsColumns.ToArray());
            FillMonthlyAttCalcsList(SearchedMonthlyAttCalcs);
        }

        private void FillMonthlyAttCalcsList(List<MonthlyAttCalcs> list) {

            DGViewAttCalcs.Rows.Clear();

            if (list.Count == 0) {
                MessageBox.Show("Não existem dados calculados para a pesquisa efectuada");
                return;
            }

            int i = 1;
            foreach (MonthlyAttCalcs att in list) {

                DataGridViewGenericRow<MonthlyAttCalcs> row = new DataGridViewGenericRow<MonthlyAttCalcs>(att);

                row.CreateCells(DGViewAttCalcs);
                row.Cells[0].Value = att.Funcionario.ToString();
                row.Cells[1].Value = att.Month.ToString();
                row.Cells[2].Value = att.Ano.ToString();
                row.Cells[3].Value = att.First.ToString("yyyy-MM-dd");
                row.Cells[4].Value = att.Last.ToString("yyyy-MM-dd");
                row.Cells[5].Value = att.TotalWorkDaysText(); //WorkTime
                row.Cells[6].Value = att.WorkedDaysText(); //WorkedTime
                row.Cells[7].Value = att.AbsentDaysText(); //AbsentTime                
                row.Cells[8].Value = new Hora(att.TotalOvertimeHours, att.TotalOvertimeMins).ToString();
                row.Cells[9].Value = att.Holidays.ToString();
                row.Cells[10].Value = att.OnVacation;

                if (att.OnVacation) {
                    row.DefaultCellStyle.BackColor = Color.DarkGray;
                }

                DGViewAttCalcs.Rows.Add(row);
                i++;
            }

        }

        private void BtnMonthSearchCalc_Click(object sender, EventArgs e) {
            SearchAndCalculateMonthlyAtt();
        }

        private void SearchAndCalculateMonthlyAtt() {

            if (context.FuncionarioHorario.Count() == 0) {
                MessageBox.Show("Não existem horarios associados ha funcionarios");
                return;
            }

            OnExecuteDialog background = new OnExecuteDialog("Calculos de asseduidade....", "Efectuando calculos de asseduidade mensais...");
            //bool result = false;

            List<Funcionario> funcionarios = getFuncionarios();

            background.OnExecute += delegate() {
                SearchedMonthlyAndCalculatedAttCalcs.Clear();

                DateTime fromDate = DtpFromDate.Value.Date;
                DateTime toDate = DtpToDate.Value.Date;

                Console.WriteLine("Started calcs");

                calculations.CalculateMonthlyAttendanceData(funcionarios, fromDate, toDate);

                SearchedMonthlyAndCalculatedAttCalcs.AddRange(DBSearch.FindAllMonthlyAttendanceCalcs(context, funcionarios, fromDate, toDate, false));
                Console.WriteLine("Ended Started calcs");

            };

            background.OnPostExecute += delegate() {
                ViewCalculatedMonthlyAttendanceCalcs();
            };

            background.StartExecute();
        }

        private void ViewCalculatedMonthlyAttendanceCalcs() {
            DGViewAttCalcs.Columns.Clear();
            DGViewAttCalcs.Columns.AddRange(monthlyAttCalcsColumns.ToArray());
            FillMonthlyAttCalcsList(SearchedMonthlyAndCalculatedAttCalcs);
        }
    }
}
