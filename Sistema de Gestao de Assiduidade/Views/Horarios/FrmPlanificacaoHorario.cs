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
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.utilities.module.Components;
using mz.betainteractive.utilities.module.Collections;
using mz.betainteractive.utilities.module.General;

namespace mz.betainteractive.sigeas.Views.Horarios {
    public partial class FrmPlanificacaoHorario : Form, AuthorizableComponent {
                
        private SigeasDatabaseContext context;

        private Dictionary<DataGridViewTextBoxCellGeneric<HorarioSemana>, HorarioSemana> backupGridHorarios;         
        private Cursor ExcelCursorCross;
        private ContextMenuStripGeneric<DataGridViewTextBoxCellGeneric<HorarioSemana>> menuStripHorario;

        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }

        public static string MENU_HORARIO_REMOVER = "Remover Horário";
        public static string MENU_HORARIO_REMOVE_SELECTED = "Remover Horários Selecionados";
        public static string MENU_HORARIO_CANCELAR = "Cancelar";

        private bool startedMove = false;
        private List<DataGridViewTextBoxCellGeneric<HorarioSemana>> selectedCells = new List<DataGridViewTextBoxCellGeneric<HorarioSemana>>();
        private HorarioSemana selectedHorario;   
        private bool popMenuItemClicked = false;

        public FrmPlanificacaoHorario() {
            InitializeComponent();
            //colHorario.DisplayMember = "Descricao";
            //colHorario.ValueMember = "This";
        }

        private void Initialize() {
            Limpar();
            LoadDepartamentos();
            LoadCategorias();
            
            ExcelCursorCross = new Cursor(Properties.Resources.cross_pointer.GetHicon());

            DGViewFuncionarioHorario.Cursor = ExcelCursorCross;

        }

        private void DisposeContext() {
            if (context != null) {
                context.Dispose();
                context = null;                
                backupGridHorarios = null;
                //Limpar();
            }
        }

        private void LoadContext() {
            if (context == null) {
                context = new SigeasDatabaseContext();
            }

            backupGridHorarios = new Dictionary<DataGridViewTextBoxCellGeneric<HorarioSemana>, HorarioSemana>();

            InitializeMenus();
        }

        private void InitializeMenus() {
            this.menuStripHorario = CreateHorarioMenuStrip();

            popMenuSelectionDecision.ItemClicked += new ToolStripItemClickedEventHandler(popMenuSelectionDecision_ItemClicked);
            
            DGViewFuncionarioHorario.CellMouseDoubleClick += HorarioCellMouseDoubleClick;
            DGViewFuncionarioHorario.SelectionChanged += HorarioCellSelectionChanged;
            DGViewFuncionarioHorario.CellMouseDown += HorarioCellMouseDown;
            DGViewFuncionarioHorario.CellMouseUp += HorarioCellMouseUp;
        }                

        private ContextMenuStripGeneric<DataGridViewTextBoxCellGeneric<HorarioSemana>> CreateHorarioMenuStrip() {
            var menu = new ContextMenuStripGeneric<DataGridViewTextBoxCellGeneric<HorarioSemana>>();

            ToolStripSeparator separator1 = new ToolStripSeparator();
            ToolStripSeparator separator2 = new ToolStripSeparator();
            ToolStripMenuItem ppdItemRemove = new ToolStripMenuItem(MENU_HORARIO_REMOVER);
            ToolStripMenuItem ppdItemRemoveSel = new ToolStripMenuItem(MENU_HORARIO_REMOVE_SELECTED);
            ToolStripMenuItem ppdItemCancelar = new ToolStripMenuItem(MENU_HORARIO_CANCELAR);

            foreach (var horario in context.HorarioSemana.ToList()) {
                menu.Items.Add(new ToolStripMenuItemGeneric<HorarioSemana>(horario));
            }

            menu.Items.AddRange(new ToolStripItem[] { separator1, ppdItemRemove, ppdItemRemoveSel, separator2, ppdItemCancelar });
            menu.ItemClicked += PopupMenuHorariosAction;
            menu.Closed += new ToolStripDropDownClosedEventHandler(HorarioMenuClosed);

            return menu;
        }

        private void HorarioMenuClosed(object sender, ToolStripDropDownClosedEventArgs e) {
            if (!popMenuItemClicked) {
                RemoveCurrentSelection(true, false);
            }
        }

        private DataGridViewTextBoxCellGeneric<HorarioSemana> GetHorarioCell(int rowIndex, int columnIndex) {
            try {
                var cell = this.DGViewFuncionarioHorario.Rows[rowIndex].Cells[columnIndex] as DataGridViewTextBoxCellGeneric<HorarioSemana>;
                return cell;
            } catch (Exception ex) {
                return null;
            }
        }

        private void popMenuSelectionDecision_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            popMenuItemClicked = true;

            if (e.ClickedItem == popMenSelOverwriteAll) {
                RemoveCurrentSelection(false, true);
            }
            if (e.ClickedItem == popMenSelOverwriteSome) {
                RemoveCurrentSelection(false, false);
            }
            if (e.ClickedItem == popMenSelCancelar) {
                RemoveCurrentSelection(true, false);
            }
        }
                
        private void PopupMenuHorariosAction(object sender, ToolStripItemClickedEventArgs e) {

            ToolStripMenuItem item = e.ClickedItem as ToolStripMenuItem;
            var contextMenu = item.Owner as ContextMenuStripGeneric<DataGridViewTextBoxCellGeneric<HorarioSemana>>;

            if (item is ToolStripMenuItemGeneric<HorarioSemana>) {
                var horario = (item as ToolStripMenuItemGeneric<HorarioSemana>).Value;
                var cell = contextMenu.Value;

                cell.GenericValue = horario;
                cell.Value = horario;
            }

            if (item.Text==MENU_HORARIO_REMOVER){
                var cell = contextMenu.Value;

                cell.GenericValue = null;
                cell.SetTextUsingValue();
            }

            if (item.Text == MENU_HORARIO_REMOVE_SELECTED) {
                
                foreach (var objCell in contextMenu.Value.DataGridView.SelectedCells) {
                    if (objCell is DataGridViewTextBoxCellGeneric<HorarioSemana>) {
                        var cell = objCell as DataGridViewTextBoxCellGeneric<HorarioSemana>;
                        cell.GenericValue = null;
                        cell.SetTextUsingValue();
                    }
                }
            }

            //var column = contextMenu.Value;

            Console.WriteLine("sender " + sender);
            Console.WriteLine("assigned to : " + item.Owner);

        }
                
        private void HorarioCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            var cell = GetHorarioCell(e.RowIndex, e.ColumnIndex);

            if (cell == null) return;

            var rect = this.DGViewFuncionarioHorario.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

            var itemRemove = this.menuStripHorario.Items[this.menuStripHorario.Items.Count - 4] as ToolStripMenuItem;
            var itemRemoveSel = this.menuStripHorario.Items[this.menuStripHorario.Items.Count - 3] as ToolStripMenuItem;

            itemRemove.Enabled = cell.GenericValue != null;
            itemRemoveSel.Enabled = cell.DataGridView.SelectedCells.Count > 1;

            this.menuStripHorario.Value = cell;
            this.menuStripHorario.Show(cell.DataGridView, new Point(rect.X, rect.Y + rect.Height));
        }

        private void HorarioCellSelectionChanged(object sender, EventArgs e) {            
            if (startedMove)
                foreach (var xcell in DGViewFuncionarioHorario.SelectedCells.Cast<DataGridViewCell>()) {
                    if (xcell is DataGridViewTextBoxCellGeneric<HorarioSemana>) {
                        var cell = xcell as DataGridViewTextBoxCellGeneric<HorarioSemana>;

                        if (!selectedCells.Contains(cell)) {
                            cell.Value = selectedHorario.ToString();
                            selectedCells.Add(cell);
                        }

                    }
                }
        }

        private void HorarioCellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            var cell = GetHorarioCell(e.RowIndex, e.ColumnIndex);
            if (cell != null && cell.GenericValue != null && e.Button==MouseButtons.Left) {
                DGViewFuncionarioHorario.Cursor = Cursors.PanSE;
                selectedHorario = cell.GenericValue;
                startedMove = true;
                selectedCells.Clear();
                selectedCells.Add(cell);
            }
        }

        private void HorarioCellMouseUp(object sender, DataGridViewCellMouseEventArgs e) {
            DGViewFuncionarioHorario.Cursor = ExcelCursorCross;

            if (startedMove && selectedCells.Count > 1) {
                startedMove = false;
                popMenuItemClicked = false;
                var cell = GetHorarioCell(e.RowIndex, e.ColumnIndex);
                var rect = this.DGViewFuncionarioHorario.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                popMenuSelectionDecision.Show(cell.DataGridView, rect.X + e.X, rect.Y + e.Y);
                return;
            }

            //right click event
            
            if (e.Button == MouseButtons.Right) {
                var cell = GetHorarioCell(e.RowIndex, e.ColumnIndex);
                if (cell == null) return;

                cell.Selected = true;

                startedMove = false;

                var rect = this.DGViewFuncionarioHorario.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                var itemRemove = this.menuStripHorario.Items[this.menuStripHorario.Items.Count - 4] as ToolStripMenuItem;
                var itemRemoveSel = this.menuStripHorario.Items[this.menuStripHorario.Items.Count - 3] as ToolStripMenuItem;
                
                if (itemRemoveSel != null){
                    itemRemoveSel.Enabled = cell.DataGridView.SelectedCells.Count > 1;
                }
                if (itemRemove != null){
                    itemRemove.Enabled = cell.GenericValue != null;
                }

                this.menuStripHorario.Value = cell;
                this.menuStripHorario.Show(cell.DataGridView, new Point(rect.X, rect.Y + rect.Height));
            }
            
        }

        private void RemoveCurrentSelection(bool cancelOrIgnore, bool overwrite) {
            foreach (var cell in selectedCells) {
                cell.Style.BackColor = Color.White;
                cell.Style.ForeColor = Color.Black;

                if (!cancelOrIgnore) {
                    cell.GenericValue = overwrite ? selectedHorario : cell.GenericValue == null ? selectedHorario : cell.GenericValue;
                }

                cell.SetTextUsingValue();
            }
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
            
        private List<Funcionario> getFuncionarios() {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Departamento departamento = null;
            Categoria categoria = null;
            Funcionario func = null;

            if (CBoxFuncionario.SelectedItem is Funcionario) {
                func = CBoxFuncionario.SelectedItem as Funcionario;
            }
            if (CBoxCategoria.SelectedItem is Categoria) {
                categoria = CBoxCategoria.SelectedItem as Categoria;
            }
            if (CBoxDepartamento.SelectedItem is Departamento) {
                departamento = CBoxDepartamento.SelectedItem as Departamento;
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
           
            int ano = (int)NudAnos.Value;
            Funcionario funcionario = (Funcionario)CBoxFuncionario.SelectedItem;
                        
            //TxtFuncionario.Text = funcionario.ToString();

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
            var fhorario = funcHorarios.Where(f => f.Funcionario == funcionario && f.Inicio == dateBound.First && f.Fim == dateBound.Last).FirstOrDefault();
            return fhorario;
        }

        private bool CheckIfExistsSemanal(Funcionario funcionario, int ano) {
            //check if already exists Semanal
            FuncionarioHorario funcHor = context.FuncionarioHorario.Where(t => t.Funcionario.Id == funcionario.Id && t.Ano == ano && t.Periodo.Descricao == PeriodoTempo.SEMANAL).FirstOrDefault();
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
                /*
                if (CheckIfExistsSemanal(funcionario, ano)) {
                    return;
                }
                //check if already exists Trimestral
                if (CheckIfExistsTrimestral(funcionario, ano)) {
                    return;
                }*/
                
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
            NudAnos.ReadOnly = true;
            LoadColumnsToGrid(periodos);
                        
            var funcionarios = getFuncionarios();
            var funcIds = funcionarios.Select(f => f.Id).ToList();

            List<FuncionarioHorario> funcHorarios = context.FuncionarioHorario.Where(t => funcIds.Contains(t.Funcionario.Id) && t.Ano == ano).ToList();                    

            foreach (var func in funcionarios) {

                DataGridViewGenericRow<Funcionario> row = new DataGridViewGenericRow<Funcionario>(func);
                                
                row.CreateCells(DGViewFuncionarioHorario);
                row.Cells[0].Value = func.Code;
                row.Cells[1].Value = func.Nome;

                int i=2;
                foreach (var dateBound in periodos){
                    FuncionarioHorario funcionarioHorario = GetFuncionarioHorario(funcHorarios, func, dateBound);
                    HorarioSemana horario = funcionarioHorario == null ? null : funcionarioHorario.Horario;

                    DataGridViewTextBoxCellGeneric<HorarioSemana> cell = row.Cells[i] as DataGridViewTextBoxCellGeneric<HorarioSemana>;

                    if (horario != null) {
                        backupGridHorarios.Add(cell, horario);
                        cell.GenericValue = horario;
                        cell.SetTextUsingValue();
                    }                                       

                    
                    i++;
                }

                DGViewFuncionarioHorario.Rows.Add(row);
            }

        }
        
        private void LoadColumnsToGrid(List<DateBounds> dateBounds) {

            List<DataGridViewColumn> GridColumns = new List<DataGridViewColumn>();

            DataGridViewTextBoxColumn colDepartamento = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn colCategoria = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn colFuncionarioCode = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn colFuncionarioNome = new DataGridViewTextBoxColumn();

            colDepartamento.HeaderText = "Departamento";
            colCategoria.HeaderText = "Categoria";
            colFuncionarioCode.HeaderText = "Código";
            colFuncionarioNome.HeaderText = "Funcionário";

            colDepartamento.ReadOnly = true;
            colCategoria.ReadOnly = true;
            colFuncionarioCode.ReadOnly = true;
            colFuncionarioNome.ReadOnly = true;
            colFuncionarioNome.Width = 180;

            colFuncionarioCode.DefaultCellStyle.SelectionBackColor = Color.White;
            colFuncionarioCode.DefaultCellStyle.SelectionForeColor = Color.Black;
            colFuncionarioNome.DefaultCellStyle.SelectionBackColor = Color.White;
            colFuncionarioNome.DefaultCellStyle.SelectionForeColor = Color.Black;

            GridColumns.Clear();

            GridColumns.AddRange(new DataGridViewColumn[] { /*colDepartamento, colCategoria,*/ colFuncionarioCode, colFuncionarioNome });                      
            
            foreach (var bound in dateBounds) {
                DataGridViewTextBoxColumnGeneric<DateBounds> column = new DataGridViewTextBoxColumnGeneric<DateBounds>(bound);
                
                column.HeaderText = DateUtilities.GetPeriodoShort(bound);
                column.Width = 120;

                column.CellTemplate = new DataGridViewTextBoxCellGeneric<HorarioSemana>();

                GridColumns.Add(column);
            }

            DGViewFuncionarioHorario.Rows.Clear();
            DGViewFuncionarioHorario.Columns.Clear();

            foreach (var col in GridColumns) {
                DGViewFuncionarioHorario.Columns.Add(col);
            }


        }
                
        private void cboFuncionario_SelectedIndexChanged(object sender, EventArgs e) {
            //BtnViewAssociacoes.Enabled = CBoxFuncionario.SelectedIndex != -1;
        }

        private void btLimpar_Click(object sender, EventArgs e) {
            Limpar();
        }

        private void Limpar() {
            DGViewFuncionarioHorario.Rows.Clear();
            NudAnos.Value = DateTime.Now.Year;
            NudAnos.ReadOnly = false;
            TxtFuncionario.Text = "";            
            backupGridHorarios.Clear();            
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

            List<DataGridViewTextBoxCellGeneric<HorarioSemana>> changedGrids = new List<DataGridViewTextBoxCellGeneric<HorarioSemana>>();
            List<DataGridViewTextBoxCellGeneric<HorarioSemana>> removeGrids = new List<DataGridViewTextBoxCellGeneric<HorarioSemana>>();
            List<DataGridViewTextBoxCellGeneric<HorarioSemana>> newGrids = new List<DataGridViewTextBoxCellGeneric<HorarioSemana>>();

            int ano = (int)NudAnos.Value;

            foreach (var row in DGViewFuncionarioHorario.Rows.OfType<DataGridViewGenericRow<Funcionario>>()) {                
                for (int i = 2; i < row.Cells.Count; i++) {
                    var cell = row.Cells[i] as DataGridViewTextBoxCellGeneric<HorarioSemana>;
                    var horario = cell.GenericValue;

                    //ChangedGrids & RemoveGrids
                    if (backupGridHorarios.ContainsKey(cell)) {
                        HorarioSemana oldHorario = null;
                        backupGridHorarios.TryGetValue(cell, out oldHorario);

                        if (horario == null) {
                            removeGrids.Add(cell);
                            continue;
                        }

                        if (!oldHorario.Equals(horario)) {                           
                            changedGrids.Add(cell);
                            continue;                            
                        }
                    } else {
                        if (horario != null) {
                            newGrids.Add(cell);
                            Console.WriteLine(row.Value.Code+", "+horario+", r:"+cell.RowIndex+",c:"+cell.ColumnIndex+", i:"+i);
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
            foreach (var cell in newGrids) {
                var row = cell.OwningRow as DataGridViewGenericRow<Funcionario>;
                var col = cell.OwningColumn as DataGridViewTextBoxColumnGeneric<DateBounds>;

                FuncionarioHorario fhorario = new FuncionarioHorario();
                
                fhorario.Funcionario = row.Value;
                fhorario.Ano = ano;
                fhorario.Ordem = col.Value.Order;
                fhorario.Inicio = col.Value.First;
                fhorario.Fim = col.Value.Last;
                fhorario.Periodo = periodo;                              

                context.FuncionarioHorario.Add(fhorario);
                context.HorarioSemana.Attach(cell.GenericValue); //to not be reinserted
                fhorario.Horario = cell.GenericValue;            //to not be reinserted
            }

            //changes grids
            foreach (var cell in changedGrids) {
                FuncionarioHorario fhorario = null;
                HorarioSemana oldHorario = null;
                var row = cell.OwningRow as DataGridViewGenericRow<Funcionario>;
                var col = cell.OwningColumn as DataGridViewTextBoxColumnGeneric<DateBounds>;                               
                
                backupGridHorarios.TryGetValue(cell, out oldHorario);

                fhorario = context.FuncionarioHorario.Where(f => f.Funcionario.Id==row.Value.Id && f.Horario.Id==oldHorario.Id && f.Inicio==col.Value.First && f.Fim==col.Value.Last).FirstOrDefault();
                                
                context.HorarioSemana.Attach(cell.GenericValue);
                fhorario.Horario = cell.GenericValue;
            }

            //remove grids
            foreach (var cell in removeGrids) {

                FuncionarioHorario fhorario = null;
                HorarioSemana oldHorario = null;
                var row = cell.OwningRow as DataGridViewGenericRow<Funcionario>;
                var col = cell.OwningColumn as DataGridViewTextBoxColumnGeneric<DateBounds>;

                backupGridHorarios.TryGetValue(cell, out oldHorario);

                fhorario = context.FuncionarioHorario.Where(f => f.Funcionario.Id == row.Value.Id && f.Horario.Id == oldHorario.Id && f.Inicio == col.Value.First && f.Fim == col.Value.Last).FirstOrDefault();

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

        private void btWeeklySchedule_Click(object sender, EventArgs e) {
            var form = new FrmHorarioSemanal();
            form.ShowDialog(this);
        }        

    }
}
