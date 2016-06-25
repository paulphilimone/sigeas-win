using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.utilities.module.BackgroundFeatures;
using mz.betainteractive.utilities.module.Collections;
using mz.betainteractive.sigeas.Utilities;
using mz.betainteractive.utilities.module.General;

namespace mz.betainteractive.sigeas.Views.FuncionarioDevices {
    public partial class TableFuncionarioDeviceView : Form, mz.betainteractive.utilities.module.Components.AuthorizableComponent {

        private const string MENU_SELECT_ALL = "Selecionar Todos";
        private const string MENU_UNSELECT_ALL = "Desmarcar Todos";
        private const string MENU_CANCEL = "Cancelar";


        private SigeasDatabaseContext context;
        private List<DataGridViewColumn> GridColumns = new List<DataGridViewColumn>();
        private List<Funcionario> lastListOfFuncionarios { get; set; }
        private DeviceDataUpdateView deviceDataUpdate { get; set; }

        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }


        public TableFuncionarioDeviceView() {
            InitializeComponent();
        }

        private void DisposeContext() {
            if (context != null) {
                context.Dispose();
                context = null;         
            }

            this.deviceDataUpdate.Dispose();
            this.deviceDataUpdate = null;
        }

        private void LoadContext() {
            if (context == null) {
                context = new SigeasDatabaseContext();                
            }
        }

        private void Initialize() {
            this.deviceDataUpdate = new DeviceDataUpdateView();
            
            CleanAll();
            LoadColumnsToGrid();
            LoadDepartamentosToComboBox();
            LoadCategoriasToComboBox();
            BtnSaveAll.Enabled = AllowUpdate;
        }

        private void CleanAll() {
            CBoxDepartamentos.Items.Clear();
            CBoxFuncionarios.Items.Clear();
            CBoxDepartamentos.ResetText();
            CBoxFuncionarios.ResetText();

            DGViewFuncDevices.Rows.Clear();
        }

        private void LoadColumnsToGrid() {
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

            GridColumns.Clear();

            GridColumns.AddRange(new DataGridViewColumn[] { colDepartamento, colCategoria ,colFuncionarioCode, colFuncionarioNome });
            
            var devices = context.Device.Where(d => d.Door != null).OrderBy(d => d.Id).ToList();

            foreach (Device device in devices){
                DataGridViewCheckBoxColumnGeneric<Device> column = new DataGridViewCheckBoxColumnGeneric<Device>(device);
                column.HeaderText = device.Door.ToString() + ": " + device.Name;
                column.TrueValue = true;
                column.FalseValue = false;
                column.ReadOnly = false;

                column.CellTemplate = new DataGridViewCheckBoxCellGeneric<DeviceUser>();

                column.HeaderCell.ContextMenuStrip = CreateDeviceMenuStrip(column);

                GridColumns.Add(column);
            }

            DGViewFuncDevices.Rows.Clear();
            DGViewFuncDevices.Columns.Clear();

            foreach (var col in GridColumns) {
                DGViewFuncDevices.Columns.Add(col);
            }
                        

        }

        private void LoadDepartamentosToComboBox() {

            Empresa empresa = SystemManager.GetCurrentEmpresa(context);

            var depts = context.Departamento.AsNoTracking().Where(t => t.Empresa.Id == empresa.Id).ToList();

            CBoxFuncionarios.Items.Clear();
            CBoxDepartamentos.Items.Clear();

            foreach (var dpt in depts) {
                CBoxDepartamentos.Items.Add(dpt);
            }

            CBoxDepartamentos.Items.Insert(0, "Todos");
        }

        private void LoadCategoriasToComboBox() {

            Empresa empresa = SystemManager.GetCurrentEmpresa(context);

            var catgs = context.Categoria.AsNoTracking().Where(t => t.Empresa.Id == empresa.Id).ToList();

            CBoxFuncionarios.Items.Clear();
            CBoxCategorias.Items.Clear();

            foreach (var cat in catgs) {
                CBoxCategorias.Items.Add(cat);
            }

            CBoxCategorias.Items.Insert(0, "Todos");
        }

        private void LoadFuncionarios(Departamento departamento, Categoria categoria) {
            CBoxFuncionarios.Items.Clear();

            List<Funcionario> funcionarios = new List<Funcionario>();

            if (categoria == null && departamento == null ){
                funcionarios = context.Funcionario.ToList();
            }

            if (categoria == null && departamento != null) {
                funcionarios.AddRange(departamento.Funcionarios);
            }

            if (departamento == null && categoria!=null) {
                funcionarios.AddRange(categoria.Funcionarios);
            }
            
            foreach (Funcionario funcionario in funcionarios) {
                if (funcionario.CompleteRegistered == true) {
                    CBoxFuncionarios.Items.Add(funcionario);
                }
            }

            CBoxFuncionarios.Items.Insert(0, "Todos");
        }

        private ContextMenuStrip CreateDeviceMenuStrip(DataGridViewCheckBoxColumnGeneric<Device> device) {
            var menu = new ContextMenuStripGeneric<DataGridViewCheckBoxColumnGeneric<Device>>(device);

            ToolStripMenuItem ppdItemSelectAll = new ToolStripMenuItem(MENU_SELECT_ALL);
            ToolStripSeparator separator1 = new ToolStripSeparator();
            ToolStripSeparator separator2 = new ToolStripSeparator();
            ToolStripMenuItem ppdItemCancelar = new ToolStripMenuItem(MENU_CANCEL);
            ToolStripMenuItem ppdItemUnselectAll = new ToolStripMenuItem(MENU_UNSELECT_ALL);

            //ppdItemUnselectAll.Enabled = false;

            menu.Items.AddRange(new ToolStripItem[] { ppdItemSelectAll, separator1, ppdItemUnselectAll, separator2, ppdItemCancelar });

            ppdItemSelectAll.Click += PopupMenuDevicesAction;
            ppdItemUnselectAll.Click += PopupMenuDevicesAction;

            return menu;
        }

        private void PopupMenuDevicesAction(object sender, EventArgs e) {

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            var contextMenu = item.Owner as ContextMenuStripGeneric<DataGridViewCheckBoxColumnGeneric<Device>>;
            var column = contextMenu.Value;


            Console.WriteLine("assigned to : " + item.Owner);

            if (item.Text == MENU_SELECT_ALL) {
                SetCellSelected(column, true);
            }

            if (item.Text == MENU_UNSELECT_ALL) {
                SetCellSelected(column, false);
            }

        }

        private void SetCellSelected(DataGridViewCheckBoxColumnGeneric<Device> column, bool value) {
            foreach (DataGridViewRow row in DGViewFuncDevices.Rows) {
                var cell = row.Cells[column.Index] as DataGridViewCheckBoxCell;
                cell.Value = value;
            }
        }


        private void TableFuncionarioDeviceView_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible == true) {
                LoadContext();
                Initialize();
            }
        }        

        private void TableFuncionarioDeviceView_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
            this.DisposeContext();
        }

        private void CBoxDepartamentos_SelectedIndexChanged(object sender, EventArgs e) {
            OnSelectDepartamentoOrCategoria();            
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

        private void BtnPesquisar_Click(object sender, EventArgs e) {
            Pesquisar();
        }

        private void Pesquisar() {
            Departamento selectedDepartamento = null;
            Categoria selectedCategoria = null;
            Funcionario selectedFuncionario = null;
            List<Funcionario> funcionarios = new List<Funcionario>();

            if (CBoxDepartamentos.SelectedItem is Departamento) {
                selectedDepartamento = CBoxDepartamentos.SelectedItem as Departamento;
            }
            if (CBoxCategorias.SelectedItem is Categoria) {
                selectedCategoria = CBoxCategorias.SelectedItem as Categoria;
            }
            if (CBoxFuncionarios.SelectedItem is Funcionario) {
                selectedFuncionario = CBoxFuncionarios.SelectedItem as Funcionario;
            }

            //Search On One Funcionario
            if (selectedFuncionario != null) {
                funcionarios.Add(selectedFuncionario);
            }

            //Search On One Departamento
            if (selectedFuncionario == null && selectedCategoria == null && selectedDepartamento != null) {
                funcionarios = context.Funcionario.Where(b => b.Departamento.Id == selectedDepartamento.Id).ToList();
            }

            //Search On One Categoria
            if (selectedFuncionario == null && selectedCategoria != null && selectedDepartamento == null) {
                funcionarios = context.Funcionario.Where(b => b.Categoria.Id == selectedCategoria.Id).ToList();
            }

            //Search On All Empresa
            if (selectedDepartamento == null && selectedCategoria == null && selectedFuncionario == null) {
                funcionarios = context.Funcionario.ToList();
            }

            LoadFuncionariosToGridView(funcionarios);
        }

        private void LoadFuncionariosToGridView(List<Funcionario> funcionarios) {
            lastListOfFuncionarios = funcionarios;

            DGViewFuncDevices.Rows.Clear();

            foreach (Funcionario funcionario in funcionarios) {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(DGViewFuncDevices);

                row.Cells[0].Value = (funcionario.Departamento!=null) ? funcionario.Departamento.ToString() : "";
                row.Cells[1].Value = (funcionario.Categoria!=null) ? funcionario.Categoria.ToString() : "";
                row.Cells[2].Value = funcionario.Code;
                row.Cells[3].Value = funcionario.ToString();

                for (int i = 4; i < row.Cells.Count; i++) { //I=4 - first device column
                    DataGridViewCheckBoxColumnGeneric<Device> column = DGViewFuncDevices.Columns[i] as DataGridViewCheckBoxColumnGeneric<Device>;

                    DeviceUser duser = funcionario.DeviceUsers.Where(du => du.Device.Id == column.Value.Id).FirstOrDefault();

                    //Console.WriteLine("duser: " + duser + ", did: " + column.Value.Id);

                    DataGridViewCheckBoxCellGeneric<DeviceUser> cell = row.Cells[i] as DataGridViewCheckBoxCellGeneric<DeviceUser>;

                    cell.ReadOnly = false;

                    if (duser == null) {
                        cell.DefaultValue = false;
                        cell.Value = false;//column.FalseValue;

                        DeviceUser deviceUser = new DeviceUser {
                            Funcionario = funcionario,
                            Device = column.Value,
                            CardNumber = funcionario.Cardnumber
                        };

                        if (funcionario.EnrollNumber.HasValue) { //This field is not empty if emploeyes were imported by xls (from previous system with enrollNumber)
                            deviceUser.EnrollNumber = funcionario.EnrollNumber.Value;
                        }

                        cell.GenericValue = deviceUser;

                    } else {
                        cell.DefaultValue = true;
                        cell.Value = true;//column.TrueValue;

                        cell.GenericValue = duser;
                    }
                }

                DGViewFuncDevices.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void DGViewBenDevices_CellEndEdit(object sender, DataGridViewCellEventArgs e) {

            DataGridViewCheckBoxCellGeneric<DeviceUser> cell = null;

            try {
                cell = (DataGridViewCheckBoxCellGeneric<DeviceUser>) DGViewFuncDevices.Rows[e.RowIndex].Cells[e.ColumnIndex];
                OnCellEndEdit(cell);
            } catch (Exception ex) { }
        }

        private void OnCellEndEdit(DataGridViewCheckBoxCellGeneric<DeviceUser> cell) {
            if (!cell.DefaultValue.Equals(cell.Value)) {
                cell.Style.BackColor = Color.SpringGreen;
            } else { 
                DataGridViewColumn column = DGViewFuncDevices.Columns[cell.ColumnIndex];
                cell.Style.BackColor = column.DefaultCellStyle.BackColor;
            }
        }

        private void BtnSaveAll_Click(object sender, EventArgs e) {
            SaveAll();            
        }

        private void SaveAll(){
            OnExecuteDialog background = new OnExecuteDialog("Guardar associações...", "Guardando associações de funcionarios e dispositivos...");
            bool result = true;

            //take data from controls

            background.OnExecute += delegate() {

                //Execute inner job - without using controls
                try {
                    UpdateDeviceUsers();                   
                } catch (Exception ex) {
                    LogErrors.AddErrorLog(ex, "Erro Gravar associações");                    
                    result = false;
                }
            };

            background.OnPostExecute += delegate() {
                //output result
                if (result) {
                    MessageBox.Show(this, "As alterações nas associações (Beneficiário => Dispositivo) foram registadas com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFuncionariosToGridView(lastListOfFuncionarios);
                } else {
                    MessageBox.Show(this, "Não foi possivel registar as alterações (Beneficiário => Dispositivo) na base de dados");
                }
            };

            background.StartExecute();                       
        }

        private void UpdateDeviceUsers() {
            List<DeviceUser> devicesToAdd = null;
            List<DeviceUser> devicesToRemove = null;

            GetChangedStateDevices(out devicesToAdd, out devicesToRemove);

            if (devicesToAdd.Count == 0 && devicesToRemove.Count == 0) {
                MessageBox.Show(this, "Não existem alterações feitas nas associações, Beneficiário => Dispositivo!");
                return;
            }

            foreach (var dev in devicesToRemove) {
                context.DeviceUser.Remove(dev);
            }

            foreach (var dev in devicesToAdd) {
                context.DeviceUser.Add(dev);
            }
                      
            context.SaveChanges();
          
        }

        private void GetChangedStateDevices(out List<DeviceUser> listOfDevicesToAdd, out List<DeviceUser> listOfDevicesToRemove) {
            listOfDevicesToAdd = new List<DeviceUser>();
            listOfDevicesToRemove = new List<DeviceUser>();

            foreach (DataGridViewRow row in DGViewFuncDevices.Rows){

                for (int i = 4; i < row.Cells.Count; i++) { //I=3 - first device column
                    DataGridViewCheckBoxColumnGeneric<Device> column = DGViewFuncDevices.Columns[i] as DataGridViewCheckBoxColumnGeneric<Device>;
                    DataGridViewCheckBoxCellGeneric<DeviceUser> cell = row.Cells[i] as DataGridViewCheckBoxCellGeneric<DeviceUser>;

                    DeviceUser duser = cell.GenericValue;

                    if (cell.DefaultValue.Equals(false) && cell.Value.Equals(true) ) { 
                        // false -> true, adding
                        listOfDevicesToAdd.Add(duser);
                        continue;
                    }

                    if (cell.DefaultValue.Equals(true) && cell.Value.Equals(false)) {
                        // true -> false, removing
                        listOfDevicesToRemove.Add(duser);
                        continue;
                    }

                }

            }
                        
        }

        private void BtnSaveOnDevices_Click(object sender, EventArgs e) {
            this.deviceDataUpdate.Visible = true;
        }

        

                
    }
}
