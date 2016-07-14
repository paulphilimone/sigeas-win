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
using mz.betainteractive.sigeas.DataSets;
using mz.betainteractive.sigeas.ReportFiles;
using CrystalDecisions.CrystalReports.Engine;

namespace mz.betainteractive.sigeas.Views.Reports {
    public partial class ReportsCreatorView : Form, AuthorizableComponent {

        private SigeasDatabaseContext context;               

        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }

        /*
         0. Assiduidade por Funcionario no Mês
         1. Assiduidade Mensal por Departamentos
         2. Assiduidade Mensal por Categorias
         3. Estatisticas de Assiduidade Geral
         4. Estatisticas de Assiduidade por Departamentos
         5. Estatisticas de Assiduidade por Categorias
         */

        private const int REPORT_ATTENDANCE_BY_EMPLOYEE = 0;
        private const int REPORT_ATTENDANCE_BY_DEPARTMENTS = 1;
        private const int REPORT_ATTENDANCE_BY_CATEGORIES = 2;
        private const int REPORT_GENERAL_STATS = 3;
        private const int REPORT_STATS_BY_EMPLOYEE = 4;
        private const int REPORT_STATS_BY_CATEGORIES = 5;
        
        public ReportsCreatorView() {
            InitializeComponent();
        }
        
        private void DisposeContext() {
            if (context != null) {
                context.Dispose();
                context = null;

                CloseReports();
            }
        }

        private void LoadContext() {
            if (context == null) {
                context = new SigeasDatabaseContext();
            }
        }

        private void CloseReports() {

            if (crptViewer.ReportSource is ReportClass) {
                var report = crptViewer.ReportSource as ReportClass;
                report.Close();
            }

            crptViewer.ReportSource = null;
            crptViewer.RefreshReport();
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
            LoadDepartamentosToComboBox();
            LoadCategoriasToComboBox();
            LoadMonthWorksToComboBox();
            CleanFilters();
        }
        
        private void CleanFilters() {
            cboReports.SelectedIndex = -1;
            cboMonthWorks.SelectedIndex = -1;
            txtFromDate.Text = "";
            txtToDate.Text = "";
            CBoxDepartamentos.Text = "";
            CBoxCategorias.Text = "";
            CBoxFuncionarios.Text = "";
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

        private void LoadMonthWorksToComboBox() {
            var months = context.MonthWork.Where(t => t.Enabled == true).ToList();

            cboMonthWorks.Items.Clear();

            foreach (var month in months) {
                cboMonthWorks.Items.Add(month);
            }
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

        private List<Departamento> getDepartamentos() {
            Departamento departamento = CBoxDepartamentos.SelectedItem as Departamento;

            if (departamento == null) {
                return context.Departamento.ToList();
            }

            return new List<Departamento>() { departamento };
        }

        private List<Categoria> getCategorias() {
            Categoria categoria = CBoxCategorias.SelectedItem as Categoria;

            if (categoria == null) {
                return context.Categoria.ToList();
            }

            return new List<Categoria>() { categoria };
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
              
        private void btFechar_Click(object sender, EventArgs e) {
            this.Close();
        }            

        private void CBoxMonthWorks_SelectedIndexChanged(object sender, EventArgs e) {
            OnMonthWorkSelected();
        }        

        private void OnMonthWorkSelected() {
            MonthWork monthWork = cboMonthWorks.SelectedItem as MonthWork;

            if (monthWork == null) return;

            txtFromDate.Text = monthWork.First.ToString("yyyy-MM-dd");
            txtToDate.Text = monthWork.Last.ToString("yyyy-MM-dd");
        }

        private void btCleanFilters_Click(object sender, EventArgs e) {
            CleanFilters();
        }

        private void btCreateReport_Click(object sender, EventArgs e) {
            OnCreateReportClicked();
        }        

        private void btExportReport_Click(object sender, EventArgs e) {

        }

        private void OnCreateReportClicked() {
            //perform checks

            if (cboReports.SelectedIndex == -1) {
                MessageBox.Show("Selecione o relatório que pretende visualizar!");
                cboReports.Focus();
                return;
            }

            if (cboMonthWorks.SelectedIndex == -1) {
                MessageBox.Show("Selecione o mês do relatório que pretende visualizar!");
                cboMonthWorks.Focus();
                return;
            }

            /*
            0. Assiduidade por Funcionario no Mês
            1. Assiduidade Mensal por Departamentos
            2. Assiduidade Mensal por Categorias
            3. Estatisticas de Assiduidade Geral
            4. Estatisticas de Assiduidade por Departamentos
            5. Estatisticas de Assiduidade por Categorias
            */

            List<Departamento> departamentos = getDepartamentos();
            List<Categoria> categorias = getCategorias();
            List<Funcionario> funcionarios = getFuncionarios();

            int selectedReport = cboReports.SelectedIndex;
            MonthWork monthWork = cboMonthWorks.SelectedItem as MonthWork;

            if (selectedReport == REPORT_ATTENDANCE_BY_EMPLOYEE){
                CreateReportAttendanceByEmployee(monthWork, departamentos, categorias, funcionarios);            
            }else{
                MessageBox.Show("Not Implemented yet");
            }
        }

        private void CreateReportAttendanceByEmployee(MonthWork monthWork, List<Departamento> departamentos, List<Categoria> categorias, List<Funcionario> funcionarios) {

            var funcIds = funcionarios.Select(t => t.Id);
            List<MonthlyAttCalcs> monthAttCalcs = context.MonthlyAttCalcs.Where(t => funcIds.Contains(t.Funcionario.Id) && t.Month.Id==monthWork.Id).ToList();
            List<DailyAttCalcs> dailyAttCalcs = context.DailyAttCalcs.Where(t => funcIds.Contains(t.Funcionario.Id) && t.Month.Id == monthWork.Id).ToList();

            ReportsModel dataSet = new ReportsModel();

            var depts = context.Departamento.ToList()[0];

            ReportsModelConverter.AddDepartamento(dataSet, departamentos);
            ReportsModelConverter.AddCategoria(dataSet, categorias);
            ReportsModelConverter.AddFuncionario(dataSet, funcionarios);
            ReportsModelConverter.AddMonthWork(dataSet, new List<MonthWork>() { monthWork });
            ReportsModelConverter.AddMonthlyAttCalcs(dataSet, monthAttCalcs);
            ReportsModelConverter.AddDailyAttCalcs(dataSet, dailyAttCalcs);

            EmployeeMonthlyReport crReport = new EmployeeMonthlyReport();
            
            //CrystalReport1 report1 = new CrystalReport1();
           // report1.SetDataSource(dataSet);
                        
            crReport.SetDataSource(dataSet);

            crptViewer.ReportSource = crReport;
           // crptViewer.ReportSource = report1;
            crptViewer.RefreshReport();
        }
    }
}
