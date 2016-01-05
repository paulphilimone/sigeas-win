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
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.sigeas.Utilities.Components;

namespace mz.betainteractive.sigeas.Views.Horarios {
    public partial class FrmPlanificacaoHorario : Form, AuthorizableComponent {
                
        private SigeasDatabaseContext context;

        private Dictionary<DataGridViewGenericRow<DateBounds>, FuncionarioHorario> backupGridHorarios;

        private Funcionario SelectedFuncionario;
        private bool SelectedHorarioSemanal;

        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }

        public FrmPlanificacaoHorario() {
            InitializeComponent();
            colHorario.DisplayMember = "Descricao";
            colHorario.ValueMember = "This";
        }

        private void Initialize() {
            Limpar();
            LoadDepartamentos();
            LoadCategorias();
            LoadHorarios();
        }

        private void DisposeContext() {
            if (context != null) {
                context.Dispose();
                context = null;
                SelectedFuncionario = null;
                backupGridHorarios = null;
                //Limpar();
            }
        }

        private void LoadContext() {
            if (context == null) {
                context = new SigeasDatabaseContext();
            }

            SelectedFuncionario = null;
            backupGridHorarios = new Dictionary<DataGridViewGenericRow<DateBounds>, FuncionarioHorario>();
        }


        private void FrmPlanificacaoHorario_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
            DisposeContext();
        }

        private void FrmPlanificacaoHorario_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                LoadContext();
                Initialize();
            }
        }

        private void btFechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        public void LoadCategorias() {
            DBSearch.FillCategoria(context, CBoxCategoria, false);
        }

        public void LoadDepartamentos() {
            DBSearch.FillDepartamento(context, CBoxDepartamento, false);
        }

        public void LoadHorarios() {
            List<HorarioSemana> list = context.HorarioSemana.AsNoTracking().ToList();
            colHorario.Items.Clear();
            colHorario.Items.AddRange(list.ToArray());
            colHorario.Items.Add("Sem horário");
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e) {
            FindFuncionario();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e) {
            FindFuncionario();
        }

        private void FindFuncionario() {
            Departamento depart = null;
            Categoria categoria = null;

            if (CBoxDepartamento.SelectedIndex != -1) {
                depart = (Departamento)CBoxDepartamento.SelectedItem;
            }
            if (CBoxCategoria.SelectedIndex != -1) {
                categoria = (Categoria)CBoxCategoria.SelectedItem;
            }

            CBoxFuncionario.Items.Clear();
            CBoxFuncionario.ResetText();

            if (depart == null && categoria == null) {
                return;
            }

            if (depart == null) {
                List<Funcionario> funs = context.Funcionario.Where(t => t.Categoria.Id == categoria.Id).ToList();
                FillFuncionario(funs);
                return;
            }
            if (categoria == null) {
                List<Funcionario> funs = context.Funcionario.Where(t => t.Departamento.Id == depart.Id).ToList();
                FillFuncionario(funs);
                return;
            }

            List<Funcionario> funcs = context.Funcionario.Where(t => t.Departamento.Id == depart.Id && t.Categoria.Id == categoria.Id).ToList();
            FillFuncionario(funcs);

        }

        private void FillFuncionario(List<Funcionario> funs) {
            CBoxFuncionario.Items.Clear();
            CBoxFuncionario.ResetText();
            CBoxFuncionario.Items.AddRange(funs.ToArray());
        }

        private void btViewAssociacoes_Click(object sender, EventArgs e) {
            VisualizarAssociacoes();
        }

        private void VisualizarAssociacoes() {

            if (CBoxFuncionario.SelectedIndex == -1) {
                MessageBox.Show("Selecione o funcionário primeiro");
                return;
            }
            if (!(CBoxFuncionario.SelectedItem is Funcionario)) {
                MessageBox.Show("Selecione o funcionário primeiro");
                return;
            }

            int ano = (int)NudAnos.Value;
            Funcionario funcionario = (Funcionario)CBoxFuncionario.SelectedItem;

            Limpar();

            TxtFuncionario.Text = funcionario.ToString();

            if (RBtnPeriodoSemanal.Checked) {
                PeriodoTempo periodo = context.PeriodoTempo.FirstOrDefault(t => t.Descricao == PeriodoTempo.SEMANAL);
                ViewAssociacaoPeriodo(funcionario, ano, periodo);
                return;
            }

            if (RBtnPeriodoMensal.Checked) {
                PeriodoTempo periodo = context.PeriodoTempo.FirstOrDefault(t => t.Descricao == PeriodoTempo.MENSAL);
                ViewAssociacaoPeriodo(funcionario, ano, periodo);
                return;
            }

            if (RBtnPeriodoTrimestral.Checked) {
                PeriodoTempo periodo = context.PeriodoTempo.FirstOrDefault(t => t.Descricao == PeriodoTempo.TRIMESTRAL);
                ViewAssociacaoPeriodo(funcionario, ano, periodo);
                return;
            }
        }

        private HorarioSemana GetHorario(List<FuncionarioHorario> funcHorarios, Funcionario funcionario, DateBounds dateBound) {
            var fhorario = funcHorarios.Where(t => t.Ordem == dateBound.Order).FirstOrDefault();

            if (fhorario != null) {
                return fhorario.Horario;
            }

            return null;
        }

        private FuncionarioHorario GetFuncionarioHorario(List<FuncionarioHorario> funcHorarios, Funcionario funcionario, DateBounds dateBound) {
            var fhorario = funcHorarios.Where(t => t.Ordem == dateBound.Order).FirstOrDefault();
            return fhorario;
        }

        private bool CheckIfExistsSemanal(Funcionario funcionario, int ano) {
            //check if already exists Semanal
            FuncionarioHorario funcHor = context.FuncionarioHorario.FirstOrDefault(t => t.Funcionario.Id == funcionario.Id && t.Ano == ano && t.Periodo.Descricao == PeriodoTempo.SEMANAL);
            if (funcHor != null) {
                MessageBox.Show("Este funcionário já possui horarios semanais associados!\nNB: Se quiser mudar de horário apague todos os horários semanais que já estão associados");
                return true;
            }

            return false;
        }

        private bool CheckIfExistsMensal(Funcionario funcionario, int ano) {
            //check if already exists Mensal
            FuncionarioHorario funcHor = context.FuncionarioHorario.FirstOrDefault(t => t.Funcionario.Id == funcionario.Id && t.Ano == ano && t.Periodo.Descricao == PeriodoTempo.MENSAL);
            if (funcHor != null) {
                MessageBox.Show("Este funcionário já possui horarios mensais associados!\nNB: Se quiser mudar de horário apague todos os horários mensais que já estão associados");
                return true;
            }

            return false;
        }

        private bool CheckIfExistsTrimestral(Funcionario funcionario, int ano) {
            //check if already exists Trimestral
            FuncionarioHorario funcHor = context.FuncionarioHorario.FirstOrDefault(t => t.Funcionario.Id == funcionario.Id && t.Ano == ano && t.Periodo.Descricao == PeriodoTempo.TRIMESTRAL);
            if (funcHor != null) {
                MessageBox.Show("Este funcionário já possui horarios trimestrais associados!\nNB: Se quiser mudar de horário apague todos os horários trimestrais que já estão associados");
                return true;
            }

            return false;
        }

        private void ViewAssociacaoPeriodo(Funcionario funcionario, int ano, PeriodoTempo periodo) {
            //Semanal, Mensal, Trimestral            
            DateUtilities dateUtil = new DateUtilities(ano);
            string suffix = "";

            List<DateBounds> periodos = null;

            if (periodo.Descricao == PeriodoTempo.SEMANAL) {
                //check if already exists Mensal                
                if (CheckIfExistsMensal(funcionario, ano)) {
                    return;
                }
                //check if already exists Trimestral
                if (CheckIfExistsTrimestral(funcionario, ano)) {
                    return;
                }

                periodos = dateUtil.Weeks.ToList<DateBounds>();
                suffix = "ª";
            }

            if (periodo.Descricao == PeriodoTempo.MENSAL) {
                //check if already exists Semanal                
                if (CheckIfExistsSemanal(funcionario, ano)) {
                    return;
                }
                //check if already exists Trimestral
                if (CheckIfExistsTrimestral(funcionario, ano)) {
                    return;
                }

                periodos = dateUtil.Months.ToList<DateBounds>();
                suffix = "º";
            }

            if (periodo.Descricao == PeriodoTempo.TRIMESTRAL) {
                //check if already exists Semanal                
                if (CheckIfExistsSemanal(funcionario, ano)) {
                    return;
                }
                //check if already exists Mensal                
                if (CheckIfExistsMensal(funcionario, ano)) {
                    return;
                }

                periodos = dateUtil.Quarters.ToList<DateBounds>();
                suffix = "º";
            }

            DGViewFuncionarioHorario.Rows.Clear();
            SelectedFuncionario = funcionario;
            List<FuncionarioHorario> funcHorarios = context.FuncionarioHorario.Where(t => t.Funcionario.Id == funcionario.Id && t.Ano == ano).ToList();

            foreach (DateBounds dateBound in periodos) {

                DataGridViewGenericRow<DateBounds> row = new DataGridViewGenericRow<DateBounds>(dateBound);

                bool associated = false;

                FuncionarioHorario funcionarioHorario = GetFuncionarioHorario(funcHorarios, funcionario, dateBound);
                HorarioSemana horario = funcionarioHorario == null ? null : funcionarioHorario.Horario;

                associated = horario != null;

                row.CreateCells(DGViewFuncionarioHorario);
                row.Cells[0].Value = dateBound.Order + suffix;
                row.Cells[1].Value = (associated) ? horario : null;
                row.Cells[2].Value = DateUtilities.GetPeriodo(dateBound);
                row.Cells[3].Value = associated;

                if (horario != null) {
                    backupGridHorarios.Add(row, funcionarioHorario);
                }

                DGViewFuncionarioHorario.Rows.Add(row);
            }


        }

        private void cboFuncionario_SelectedIndexChanged(object sender, EventArgs e) {
            BtnViewAssociacoes.Enabled = CBoxFuncionario.SelectedIndex != -1;
        }

        private void btLimpar_Click(object sender, EventArgs e) {
            Limpar();
        }

        private void Limpar() {
            DGViewFuncionarioHorario.Rows.Clear();
            NudAnos.Value = 2012;
            TxtFuncionario.Text = "";
            chkSelectAll.Checked = false;
            backupGridHorarios.Clear();
            SelectedFuncionario = null;
            SelectedHorarioSemanal = true;
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e) {
            SelectAll();
        }

        private void SelectAll() {
            bool select = chkSelectAll.Checked;

            foreach (DataGridViewRow rowx in DGViewFuncionarioHorario.Rows) {
                rowx.Cells[3].Value = select;
            }
        }

        private PeriodoTempo GetSelectedPeriodo() {
            if (RBtnPeriodoSemanal.Checked) {
                PeriodoTempo periodo = context.PeriodoTempo.FirstOrDefault(t => t.Descricao == PeriodoTempo.SEMANAL);
                return periodo;
            }

            if (RBtnPeriodoMensal.Checked) {
                PeriodoTempo periodo = context.PeriodoTempo.FirstOrDefault(t => t.Descricao == PeriodoTempo.MENSAL);
                return periodo;
            }

            if (RBtnPeriodoTrimestral.Checked) {
                PeriodoTempo periodo = context.PeriodoTempo.FirstOrDefault(t => t.Descricao == PeriodoTempo.TRIMESTRAL);
                return periodo;
            }

            return null;
        }

        private void btGravar_Click(object sender, EventArgs e) {
            GravarAssociacoes();
        }

        private void GravarAssociacoes() {

            List<DataGridViewGenericRow<DateBounds>> changedGrids = new List<DataGridViewGenericRow<DateBounds>>();
            List<DataGridViewGenericRow<DateBounds>> removeGrids = new List<DataGridViewGenericRow<DateBounds>>();
            List<DataGridViewGenericRow<DateBounds>> newGrids = new List<DataGridViewGenericRow<DateBounds>>();

            foreach (DataGridViewRow rowx in DGViewFuncionarioHorario.Rows) {

                if (rowx is DataGridViewGenericRow<DateBounds>) {
                    DataGridViewGenericRow<DateBounds> row = (DataGridViewGenericRow<DateBounds>)rowx;

                    bool chked = (bool)row.Cells[3].Value;

                    //ChangedGrids & RemoveGrids
                    if (backupGridHorarios.ContainsKey(row)) {
                        FuncionarioHorario fhorario = null;
                        backupGridHorarios.TryGetValue(row, out fhorario);

                        if (chked == false) {
                            removeGrids.Add(row);
                            continue;
                        }

                        if (row.Cells[1].Value is HorarioSemana) {
                            HorarioSemana horario = (HorarioSemana)row.Cells[1].Value;
                            if (!fhorario.Horario.Equals(horario)) {
                                changedGrids.Add(row);
                                continue;
                            }
                        }
                    } else {
                        if (chked == true && row.Cells[1].Value is HorarioSemana) {
                            newGrids.Add(row);
                        }
                    }

                }

            }

            Console.WriteLine("New Grids: " + newGrids.Count());
            Console.WriteLine("Chg Grids: " + changedGrids.Count());
            Console.WriteLine("Rem Grids: " + removeGrids.Count());

            int count = newGrids.Count + removeGrids.Count + changedGrids.Count;

            if (count == 0) {
                MessageBox.Show("Não há horários a serem associados ou actualizados");
                return;
            }

            PeriodoTempo periodo = GetSelectedPeriodo();

            //rec new grids
            foreach (DataGridViewGenericRow<DateBounds> row in newGrids) {

                FuncionarioHorario fhorario = new FuncionarioHorario();
                HorarioSemana horario = (HorarioSemana)row.Cells[1].Value;

                fhorario.Funcionario = SelectedFuncionario;
                fhorario.Ano = row.Value.First.Year;
                fhorario.Ordem = row.Value.Order;
                fhorario.Inicio = row.Value.First;
                fhorario.Fim = row.Value.Last;
                fhorario.Periodo = periodo;
                fhorario.Horario = horario;

                context.FuncionarioHorario.Add(fhorario);
            }

            //changes grids
            foreach (DataGridViewGenericRow<DateBounds> row in changedGrids) {

                FuncionarioHorario fhorario = null;
                backupGridHorarios.TryGetValue(row, out fhorario);

                HorarioSemana horario = (HorarioSemana)row.Cells[1].Value;
                fhorario.Horario = horario;
            }

            //remove grids
            foreach (DataGridViewGenericRow<DateBounds> row in removeGrids) {

                FuncionarioHorario fhorario = null;
                backupGridHorarios.TryGetValue(row, out fhorario);

                context.FuncionarioHorario.Remove(fhorario);
            }

            try {
                context.SaveChanges();

                string message = "";

                if (newGrids.Count > 0) {
                    message += newGrids.Count + " horários foram adicionados!";
                }
                if (changedGrids.Count > 0) {
                    message += "\n" + changedGrids.Count + " horários foram modificados!";
                }
                if (removeGrids.Count > 0) {
                    message += "\n" + removeGrids.Count + " horarios foram removidos";
                }

                MessageBox.Show(message, "Horário Semanal");

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar atualizar os horários dos funcionários na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar atualizar os horários dos funcionários na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
