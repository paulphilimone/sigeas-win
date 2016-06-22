using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.model.ca;
using mz.betainteractive.sigeas.utilities;
using System.Threading;
using System.Globalization;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.sigeas.BackgroundFeatures;
using mz.betainteractive.sigeas.model.basic;
using mz.betainteractive.sigeas.Utilities.Components;

namespace mz.betainteractive.sigeas.Views.AccessControl {
    public partial class AttendanceCalcsView : Form, AuthorizableComponent {

        private SigeasDatabaseContext context;

        private AccessControlCalculations calculations;
        private List<AttCalcs> SearchedAttCalcs;
        private List<AttCalcs> SearchedAndCalculatedAttCalcs;
        private FrmViewFuncionarioAtt FuncionarioAttForm;

        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }

        public AttendanceCalcsView() {
            InitializeComponent();
            
            SearchedAttCalcs = new List<AttCalcs>();
            SearchedAndCalculatedAttCalcs = new List<AttCalcs>();
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
            LimparLista();
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
            FillListaAttCalcs(SearchedAttCalcs);
        }

        private void FillListaAttCalcs(List<AttCalcs> list) {

            DGViewAttCalcs.Rows.Clear();

            if (list.Count == 0) {
                MessageBox.Show("Não existem dados calculados para a pesquisa efectuda");
                return;
            }

            int i = 1;
            foreach (AttCalcs att in list) {

                DataGridViewGenericRow<AttCalcs> row = new DataGridViewGenericRow<AttCalcs>(att);

                row.CreateCells(DGViewAttCalcs);
                row.Cells[0].Value = att.Funcionario.ToString();
                row.Cells[1].Value = att.Data.Value.ToShortDateString();
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

            if (row is DataGridViewGenericRow<AttCalcs>) {
                DataGridViewGenericRow<AttCalcs> grow = (DataGridViewGenericRow<AttCalcs>)row;
                FuncionarioAttForm.ViewData(context, grow.Value);
                FuncionarioAttForm.ShowDialog();
            }
        }

        private void verRegistosToolStripMenuItem_Click(object sender, EventArgs e) {
            if (DGViewAttCalcs.SelectedRows.Count == 1) {
                ViewFuncionarioRegs();
            }
        }
                

        
    }
}
