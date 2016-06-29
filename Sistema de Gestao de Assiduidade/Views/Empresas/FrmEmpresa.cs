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
using mz.betainteractive.utilities.module.Components;
using mz.betainteractive.utilities.module.General;
using mz.betainteractive.sigeas.utilities;
using System.Globalization;

namespace mz.betainteractive.sigeas.Views.Empresas {
    public partial class FrmEmpresa : Form, AuthorizableComponent {

        private SigeasDatabaseContext context;
        private Empresa currentEmpresa;

        TreeNode nodeRootDepartamento;
        TreeNode nodeRootCategoria;
        Departamento SelectedDepartamento;
        Categoria SelectedCategoria;

        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }

        public FrmEmpresa() {
            InitializeComponent();

            nodeRootDepartamento = new TreeNode("Departamentos");
            nodeRootCategoria = new TreeNode("Categorias");

            nodeRootDepartamento.ImageIndex = 1;
            nodeRootDepartamento.SelectedImageIndex = 1;
            nodeRootCategoria.ImageIndex = 2;
            nodeRootCategoria.SelectedImageIndex = 2;

            treeViewDepartCategs.Nodes.Clear();
            treeViewDepartCategs.Nodes.Add(nodeRootDepartamento);
            treeViewDepartCategs.Nodes.Add(nodeRootCategoria);
        }


        private void DisposeContext() {
            if (context != null) {
                context.Dispose();
                context = null;
                SelectedCategoria = null;
                SelectedDepartamento = null;
                currentEmpresa = null; 
                LimparForm();
                CleanAnoLaboral();
            }
        }

        private void LoadContext() {
            if (context == null) {
                context = new SigeasDatabaseContext();
            }

            SelectedCategoria = null;
            SelectedDepartamento = null;
        }

        private void Initialize() {
            CleanAll();
            FillCombos();
            GetEmpresa();
            LoadDepartamentos();
            LoadCategorias();
            LoadRegras();
            LoadMonthWorkFromDB();
        }


        private void btGravar_Click(object sender, EventArgs e) {
            if (validar()) {
                Gravar();
            }
        }

        private bool validar() {
            if (txtNomeEmpresa.Text == "") {
                MessageBox.Show("Introduza o nome da empresa primeiro");
                txtNomeEmpresa.Focus();
                return false;
            }

            if (txtNumero.Text.Length > 0) {
                try {
                    Convert.ToInt32(txtNumero.Text);
                } catch (Exception ex) {
                    MessageBox.Show("Introduza o número correctamente");
                    txtNumero.Focus();
                    return false;
                }
            }

            return true;
        }

        private void GetEmpresa() {

            this.currentEmpresa = SystemManager.GetCurrentEmpresa(context);

            if (currentEmpresa != null) {
                txtNomeEmpresa.Text = currentEmpresa.Nome;

                if (currentEmpresa.Provincia != null) {
                    cboProvincia.SelectedItem = currentEmpresa.Provincia;
                }
                if (currentEmpresa.Distrito != null) {
                    cboDistrito.SelectedItem = currentEmpresa.Distrito;
                }
                if (currentEmpresa.PostoAdministrativo != null) {
                    cboPostoAdministrativo.SelectedItem = currentEmpresa.PostoAdministrativo;
                }
                if (currentEmpresa.Localidade != null) {
                    cboLocalidade.SelectedItem = currentEmpresa.Localidade;
                }

                txtAvenidaRua.Text = currentEmpresa.AvenidaRua;
                txtNumero.Text = currentEmpresa.Numero + "";
                txtEmail.Text = currentEmpresa.Email;
                txtTelefone.Text = currentEmpresa.Telefone;
                txtFax.Text = currentEmpresa.Fax;

            }

        }

        private void Gravar() {


            Empresa empresa = currentEmpresa;
            bool firstTime = true;


            DialogResult dr = MessageBox.Show("Tem certeza que deseja gravar os dados da empresa?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            if (empresa == null) {
                empresa = new Empresa();
                empresa.CreatedBy = SystemManager.GetCurrentUser(context);
                empresa.CreationDate = DateTime.Now;
            }

            //get rules

            empresa.Nome = txtNomeEmpresa.Text;

            if (cboProvincia.SelectedIndex != -1) {
                Provincia prov = (Provincia)cboProvincia.SelectedItem;
                empresa.Provincia = prov;
            }
            if (cboDistrito.SelectedIndex != -1) {
                Distrito dist = (Distrito)cboDistrito.SelectedItem;
                empresa.Distrito = dist;
            }
            if (cboPostoAdministrativo.SelectedIndex != -1) {
                PostoAdministrativo posto = (PostoAdministrativo)cboPostoAdministrativo.SelectedItem;
                empresa.PostoAdministrativo = posto;
            }
            if (cboLocalidade.SelectedIndex != -1) {
                Localidade local = (Localidade)cboLocalidade.SelectedItem;
                empresa.Localidade = local;
            }

            empresa.AvenidaRua = txtAvenidaRua.Text;

            if (txtNumero.Text.Length != 0) {
                empresa.Numero = Convert.ToInt32(txtNumero.Text);
            }


            empresa.Email = txtEmail.Text;
            empresa.Telefone = txtTelefone.Text;
            empresa.Fax = txtFax.Text;
            empresa.UpdatedBy = SystemManager.GetCurrentUser(context);
            empresa.UpdatedDate = DateTime.Now;

            if (firstTime == true) {
                context.Empresa.Add(empresa);
            }

            if (empresa.AttendanceRules == null) {
                AttendanceRules rule = DefaulRules();
                empresa.AttendanceRules = rule;
            }

            try {

                context.SaveChanges();
                MessageBox.Show("Os dados da empresa foram registrados com sucesso");
                LimparForm();

            } catch (Exception ex) {
                MessageBox.Show("Não foi possivel registrar os dados da empresa!\nErro na base de dados: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void LoadRegras() {
            Empresa emp = currentEmpresa;

            LimparRegras();

            if (emp == null) {
                DisableRegras();
                return;
            }

            AttendanceRules rules = emp.AttendanceRules;

            if (rules != null) {
                FillRules(rules);
            } else {
                DisableRegras();
            }
        }

        private void FillRules(AttendanceRules rules) {
            nudCountHrExAfter.Value = (decimal)rules.CountHorasExtrasAfter;
            nudCountAtrasoAfter.Value = (decimal)rules.CountAtrasoAfter;
            nudIfNoClockIn.Value = (decimal)rules.MinIfNoClockIn;
            nudIfNoClockOut.Value = (decimal)rules.MinIfNoClockOut;
            chkClockingOverHorarioDia.Checked = rules.IsClockingOverHorarioDia;
        }

        private void DisableRegras() {
            LimparRegras();
            grpBoxRegras1.Enabled = false;
            grpBoxRegras2.Enabled = false;
            grpBoxRegras3.Enabled = false;
            grpBoxRegras4.Enabled = false;
            btUpdateRules.Enabled = false;
            btCreateRules.Visible = true;
        }

        private void EnableRegras() {
            grpBoxRegras1.Enabled = true;
            grpBoxRegras2.Enabled = true;
            grpBoxRegras3.Enabled = true;
            grpBoxRegras4.Enabled = true;
            btUpdateRules.Enabled = true;
            btCreateRules.Visible = false;
        }

        private void LimparRegras() {
            nudCountHrExAfter.Value = 0;
            nudCountAtrasoAfter.Value = 0;
            nudIfNoClockIn.Value = 0;
            nudIfNoClockOut.Value = 0;
            chkClockingOverHorarioDia.Checked = false;
        }

        private AttendanceRules DefaulRules() {
            AttendanceRules rules = new AttendanceRules();
            rules.CountHorasExtrasAfter = 20;
            rules.CountAtrasoAfter = 15;
            rules.MinIfNoClockIn = 60;
            rules.MinIfNoClockOut = 60;
            rules.IsClockingOverHorarioDia = false;

            return rules;
        }

        private void LoadDepartamentos() {

            Empresa empresa = currentEmpresa;

            if (empresa != null) {

                var deps = empresa.Departamentos;

                nodeRootDepartamento.Nodes.Clear();
                
                foreach (var dep in deps) {
                    TreeNodeDepartamento node = new TreeNodeDepartamento(dep);
                    nodeRootDepartamento.Nodes.Add(node);
                }
                
                treeViewDepartCategs.ExpandAll();
                treeViewDepartCategs.Refresh();
                                
                DisableDepartamentoForm();
            }

        }

        private void LoadCategorias() {

            Empresa empresa = currentEmpresa;

            if (empresa != null) {

                var cats = empresa.Categorias;
                                
                nodeRootCategoria.Nodes.Clear();
                
                foreach (var ct in cats) {
                    TreeNodeCategoria node = new TreeNodeCategoria(ct);
                    nodeRootCategoria.Nodes.Add(node);
                }

                treeViewDepartCategs.ExpandAll();
                treeViewDepartCategs.Refresh();

                DisableCategoriaForm();                
            }

        }

        private void FillCombos() {
            cboProvincia.Items.Clear();
            cboDistrito.Items.Clear();
            cboPostoAdministrativo.Items.Clear();
            cboLocalidade.Items.Clear();
            DBSearch.FillProvincia(context, cboProvincia);
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e) {
            DBSearch.OnSelectedProvincia(cboProvincia, cboDistrito, cboPostoAdministrativo, cboLocalidade);
        }

        private void cboDistrito_SelectedIndexChanged(object sender, EventArgs e) {
            DBSearch.OnSelectedDistrito(cboDistrito, cboPostoAdministrativo, cboLocalidade);
        }

        private void cboPostoAdministrativo_SelectedIndexChanged(object sender, EventArgs e) {
            DBSearch.OnSelectedPostoAdministrativo(cboPostoAdministrativo, cboLocalidade);
        }

        private void btFechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void CleanAll() {
            LimparForm();
            LimparCategoriaForm();
            LimparDepartamentoForm();
            LimparRegras();
            CleanAnoLaboral();
        }

        private void LimparForm() {
            txtNomeEmpresa.Text = "";
            cboProvincia.Items.Clear();
            cboProvincia.ResetText();
            cboDistrito.Items.Clear();
            cboDistrito.ResetText();
            cboPostoAdministrativo.Items.Clear();
            cboPostoAdministrativo.ResetText();
            cboLocalidade.Items.Clear();
            cboLocalidade.ResetText();
            txtAvenidaRua.Text = "";
            txtNumero.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtFax.Text = "";
        }

        private void CleanAnoLaboral() {
            txtEndDate.Text = "";
            txtMonthDays.Text = "";
            txtMonthName.Text = "";
            listViewMonths.Items.Clear();
        }

        private void btGravarDepartamento_Click(object sender, EventArgs e) {
            UpdateDepartamento();
        }

        private void UpdateDepartamento() {
            
            Empresa empresa = currentEmpresa;

            if (empresa != null) {
                
                Departamento depart = SelectedDepartamento;

                if (depart == null) {
                    MessageBox.Show("Selecione o departamento por favor");
                    return;
                }

                if (txtDepartNome.Text.Length == 0) {
                    MessageBox.Show("Introduza o nome do departamento primeiro");
                    txtDepartNome.Focus();
                    return;
                }

                if (depart.Nome != txtDepartNome.Text) {

                    var dps = context.Departamento.Where(t => t.Nome == txtDepartNome.Text && t.Id != depart.Id).FirstOrDefault();

                    if (dps != null) {
                        MessageBox.Show("Já existe um departamento com este nome");
                        txtDepartNome.Focus();
                        return;
                    }

                }

                DialogResult dr = MessageBox.Show("Tem certeza que deseja atualizar o departamento(" + (txtDepartNome.Text) + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.No) {
                    return;
                }

                String nome = txtDepartNome.Text;
                String desc = txtDepartDescricao.Text;
 
                depart.Nome = nome;
                depart.Descricao = desc;


                try {
                    context.SaveChanges();

                    MessageBox.Show("O departamento foi registado com sucesso!");
                    LimparDepartamentoForm();
                    LoadDepartamentos();
                } catch (Exception ex) {
                    LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar atualizar o Departamento na base de dados");
                    MessageBox.Show(this, "Ocorreu erro ao tentar atualizar o Departamento na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } else {
                MessageBox.Show("A Empresa não está registrada, registe primeiro");
            }
        }

        private void UpdateCategoria() {
            Empresa empresa = currentEmpresa;

            if (empresa != null) {
                                
                Categoria categ = null;

                categ = SelectedCategoria;

                if (categ == null) {
                    MessageBox.Show(this, "Selecione a categoria por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtCategNome.Text.Length == 0) {
                    MessageBox.Show("Introduza o nome da categoria primeiro");
                    txtCategNome.Focus();
                    return;
                }

                if (categ.Nome != txtCategNome.Text) {

                    var dps = context.Categoria.Where(t => t.Nome == txtCategNome.Text && t.Id != categ.Id).FirstOrDefault();

                    if (dps != null) {
                        MessageBox.Show("Já existe uma categoria com este nome");
                        txtDepartNome.Focus();
                        return;
                    }

                }                

                DialogResult dr = MessageBox.Show("Tem certeza que deseja atualizar a categoria(" + (txtCategNome.Text) + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.No) {
                    return;
                }
                
                String nome = txtCategNome.Text;
                String func = txtCategFuncoes.Text;
                                
                categ.Nome = nome;
                categ.Funcoes = func;
                
                try{

                    context.SaveChanges();

                    MessageBox.Show("A categoria foi registada com sucesso!");
                    LimparCategoriaForm();
                    LoadCategorias();
                } catch (Exception ex) {
                    LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar remover a Categoria na base de dados");
                    MessageBox.Show(this, "Ocorreu erro ao tentar remover a Categoria na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            } else {
                MessageBox.Show("A Empresa não está registrada, registe primeiro");
            }
        }

        private bool DepartamentExists(string nome) {
            var dps = context.Departamento.Where(t => t.Nome == nome).FirstOrDefault();
            return dps != null;
        }

        private bool CategoriaExists(string nome) {
            var categ = context.Categoria.Where(t => t.Nome == nome).FirstOrDefault();
            return categ != null;
        }

        private void btGravarCategoria_Click(object sender, EventArgs e) {
            UpdateCategoria();
        }

        private void btFechar2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btLimparDep_Click(object sender, EventArgs e) {
            LimparDepartamentoForm();
            
            BtnAlterarDepart.Enabled = false;
            BtnRemoverDepart.Enabled = false;
            BtnUpdateDepartamento.Enabled = true;            
        }

        private void LimparDepartamentoForm() {
            txtDepartNome.Text = "";
            txtDepartDescricao.Text = "";
            //txtDepartNome.ReadOnly = false;
            //txtDepartDescricao.ReadOnly = false;
            
        }

        private void LimparCategoriaForm() {
            txtCategFuncoes.Text = "";
            txtCategNome.Text = "";
            //txtCategFuncoes.ReadOnly = false;
            //txtCategNome.ReadOnly = false;
            
        }

        private void DisableCategoriaForm() {            
            txtCategFuncoes.ReadOnly = true;
            txtCategNome.ReadOnly = true;
            btAlterarCateg.Enabled = false;
            btRemoverCateg.Enabled = false;
            BtnUpdateCategoria.Enabled = false;
            BtnLimparCateg.Enabled = false;            
        }

        private void DisableDepartamentoForm() {
            
            txtDepartNome.ReadOnly = true;
            txtDepartDescricao.ReadOnly = true;
            BtnAlterarDepart.Enabled = false;
            BtnRemoverDepart.Enabled = false;
            BtnUpdateDepartamento.Enabled = false;
            BtnLimparDep.Enabled = false;            
        }

        private void btLimparCateg_Click(object sender, EventArgs e) {
            LimparCategoriaForm();

            btAlterarCateg.Enabled = false;
            btRemoverCateg.Enabled = false;
            BtnUpdateCategoria.Enabled = true;
            SelectedCategoria = null;
        }

        private void btCreateRules_Click(object sender, EventArgs e) {
            CreateRules();
        }

        private void CreateRules() {
            Empresa emp = currentEmpresa;

            if (emp == null) {
                MessageBox.Show("A Empresa não está registrada, registe primeiro");
                return;
            }

            AttendanceRules rules = DefaulRules();
            FillRules(rules);
            EnableRegras();
        }

        private void btUpdateRules_Click(object sender, EventArgs e) {
            UpdateRules();
        }

        private void UpdateRules() {

            Empresa emp = currentEmpresa;

            if (emp == null) {
                MessageBox.Show("A Empresa não está registrada, registe primeiro");
                return;
            }


            AttendanceRules rules = null;
            bool isNew = false;

            rules = emp.AttendanceRules;

            if (rules == null) {
                rules = new AttendanceRules();
                isNew = true;
            }

            rules.CountHorasExtrasAfter = (int)nudCountHrExAfter.Value;
            rules.CountAtrasoAfter = (int)nudCountAtrasoAfter.Value;
            rules.MinIfNoClockIn = (int)nudIfNoClockIn.Value;
            rules.MinIfNoClockOut = (int)nudIfNoClockOut.Value;
            rules.IsClockingOverHorarioDia = chkClockingOverHorarioDia.Checked;

            if (isNew) {
                emp.AttendanceRules = rules;
            }

            context.SaveChanges();

            MessageBox.Show(this, "As regras de assiduidade foram actualizadas com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void treeViewDepartCategs_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                if (e.Node is TreeNodeDepartamento) {
                    TreeNodeDepartamento node = (TreeNodeDepartamento)e.Node;
                    ViewDepartamento(node.Value);
                }
                if (e.Node is TreeNodeCategoria) {
                    TreeNodeCategoria node = (TreeNodeCategoria)e.Node;
                    ViewCategoria(node.Value);
                }
            }
        }

        private void ViewDepartamento(Departamento departamento) {
            txtDepartNome.ReadOnly = true;
            txtDepartDescricao.ReadOnly = true;
            txtDepartNome.Text = departamento.Nome;
            txtDepartDescricao.Text = departamento.Descricao;

            BtnAlterarDepart.Enabled = true;
            BtnRemoverDepart.Enabled = true;
            BtnLimparDep.Enabled = false;
            BtnUpdateDepartamento.Enabled = false;

            SelectedDepartamento = departamento;
        }

        private void ViewCategoria(Categoria categoria) {
            txtCategNome.ReadOnly = true;
            txtCategFuncoes.ReadOnly = true;
            txtCategNome.Text = categoria.Nome;
            txtCategFuncoes.Text = categoria.Funcoes;
            
            BtnLimparCateg.Enabled = false;
            BtnUpdateCategoria.Enabled = false;
            btAlterarCateg.Enabled = true;
            btRemoverCateg.Enabled = true;
            
            SelectedCategoria = categoria;
        }

        private void btAlterarDepart_Click(object sender, EventArgs e) {
            EnableToChangeDepartamentoForm();
        }

        private void EnableToChangeDepartamentoForm() {
            txtDepartNome.ReadOnly = false;
            txtDepartDescricao.ReadOnly = false;
            
            BtnRemoverDepart.Enabled = false;
            BtnAlterarDepart.Enabled = false;
            BtnUpdateDepartamento.Enabled = true;
            BtnLimparDep.Enabled = true;
        }

        private void EnableToChangeCategoriaForm() {
            txtCategNome.ReadOnly = false;
            txtCategFuncoes.ReadOnly = false;
            
            btRemoverCateg.Enabled = false;
            btAlterarCateg.Enabled = false;
            BtnUpdateCategoria.Enabled = true;
            BtnLimparCateg.Enabled = true;
        }

        private void btAlterarCateg_Click(object sender, EventArgs e) {
            EnableToChangeCategoriaForm();
        }

        private void btRemoverDepart_Click(object sender, EventArgs e) {
            RemoverDepartamento();
        }

        private void RemoverDepartamento() {

            Departamento dep = SelectedDepartamento;

            if (dep == null) {
                MessageBox.Show("Selecione o departamento primeiro");
                return;
            }

            var count = dep.Funcionarios.Count;

            if (count > 0) {
                MessageBox.Show("Exitem funcionários registados neste departamento, se quiser remove-lo, remova os funcionários pertecentes primeiro", "Não é possivel apagar o departamento");
                return;
            }

            DialogResult dr = MessageBox.Show("Tem certeza que deseja remover o departamento(" + (txtDepartNome.Text) + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            try{

                context.Departamento.Remove(dep);
                context.SaveChanges();

                MessageBox.Show(this, "O departamento foi removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparDepartamentoForm();
                LoadDepartamentos();

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar remover o Departamento na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar remover o Departamento na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoverCategoria() {

            Categoria cat = SelectedCategoria;

            if (cat == null) {
                MessageBox.Show("Selecione a categoria primeiro");
                return;
            }
            
            var count = cat.Funcionarios.Count;

            if (count > 0) {
                MessageBox.Show("Exitem funcionários registados nesta categoria, se quiser remove-la, remova os funcionários pertecentes primeiro", "Não é possivel apagar o categoria");
                return;
            }


            DialogResult dr = MessageBox.Show("Tem certeza que deseja remover a categoria(" + (txtCategNome.Text) + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            try{
                context.Categoria.Remove(cat);
                context.SaveChanges();

                MessageBox.Show("A categoria foi removida com sucesso");
                LimparCategoriaForm();
                LoadCategorias();
            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao tentar remover a Categoria na base de dados");
                MessageBox.Show(this, "Ocorreu erro ao tentar remover a Categoria na base de dados.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btRemoverCateg_Click(object sender, EventArgs e) {
            RemoverCategoria();
        }

        private void FrmEmpresa_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                Console.WriteLine("Running");
                LoadContext();
                Initialize();
            }
        }

        private void FrmEmpresa_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
            DisposeContext();
        }

        private void BtnAddDepartamento_Click(object sender, EventArgs e) {
            OpenAddDepartamento();
        }

        private void OpenAddDepartamento() {

            DepartamentoAdd addView = new DepartamentoAdd(context, currentEmpresa);
            addView.ShowDialog();
            LimparDepartamentoForm();
            LimparCategoriaForm();
            LoadDepartamentos();
        }

        private void OpenAddCategoria() {
            CategoriaAdd addView = new CategoriaAdd(context, currentEmpresa);
            addView.ShowDialog();
            LimparDepartamentoForm();
            LimparCategoriaForm();
            LoadCategorias();
        }

        private void BtnAddCategoria_Click(object sender, EventArgs e) {
            OpenAddCategoria();
        }

        private void dtpInitialDay_ValueChanged(object sender, EventArgs e) {
            UpdateDatesCalculations();
        }

        private void UpdateDatesCalculations() {
            CultureInfo ci = new CultureInfo("pt-PT");

            var dateBound = DateUtilities.GetMonthDateBound(dtpStartDate.Value);

            txtEndDate.Text = dateBound.Last.ToString("dd MMMM yyyy", ci);
            txtMonthDays.Text = dateBound.Days + "";
            txtMonthName.Text = dateBound.Name;
        }

        private void btPreviewMonthList_Click(object sender, EventArgs e) {
            var bounds = DateUtilities.GetMonthsList(dtpStartDate.Value, 6);
            ViewMonthsList(bounds);
        }

        private void ViewMonthsList(List<DateBounds> bounds) {
            CultureInfo ci = new CultureInfo("pt-PT");

            listViewMonths.Items.Clear();

            foreach (var dbound in bounds) {
                ListViewItem item = new ListViewItem(dbound.Order+"");
                item.SubItems.AddRange(new string[] { dbound.Year+"", StringUtilities.Capitalize(dbound.Name), StringUtilities.Capitalize(dbound.First.ToString("dd MMMM", ci)), StringUtilities.Capitalize(dbound.Last.ToString("dd MMMM", ci)), dbound.Days.ToString() });
                listViewMonths.Items.Add(item);
            }
        }

        private void LoadMonthWorkFromDB() {
            CultureInfo ci = new CultureInfo("pt-PT");

            GetEmpresa();

            if (currentEmpresa.InitialStartDate != null){
                dtpStartDate.Value = currentEmpresa.InitialStartDate.Value;
                UpdateDatesCalculations();
            }
            var monthWorks = context.MonthWork.ToList();

            listViewMonths.Items.Clear();

            foreach (var dbound in monthWorks) {
                ListViewItem item = new ListViewItem(dbound.Order + "");
                item.SubItems.AddRange(new string[] { dbound.Year + "", StringUtilities.Capitalize(dbound.Name), StringUtilities.Capitalize(dbound.First.ToString("dd MMMM", ci)), StringUtilities.Capitalize(dbound.Last.ToString("dd MMMM", ci)), dbound.TotalDays.ToString() });
                listViewMonths.Items.Add(item);
            }
        }
        
        private void btGenerateMonthsList_Click(object sender, EventArgs e) {
            CreateAndSaveMonthsList();
        }

        private void CreateAndSaveMonthsList() {
            var bounds = DateUtilities.GetMonthsList(dtpStartDate.Value, 20);
            var exists = new List<DateBounds>();
            var monthWorks = new List<MonthWork>();

            foreach (var dBound in bounds) {
                bool recordExists = context.MonthWork.Where(t=>t.Year==dBound.Year && t.Order==dBound.Order).Count()>0;

                if (recordExists) {
                    exists.Add(dBound);
                    continue;
                }

                monthWorks.Add(new MonthWork(dBound));
            }

            if (monthWorks.Count == 0) {
                MessageBox.Show("Não há meses para serem gravados no sistema!");
                return;
            } 

            try {
                this.currentEmpresa.InitialStartDate = dtpStartDate.Value;
                context.MonthWork.AddRange(monthWorks);
                context.SaveChanges();
                MessageBox.Show("Meses de trabalho foram registados com sucesso!");

            } catch (Exception ex) {
                LogErrors.AddErrorLog(ex, "Ocorreu erro ao guardar os meses de trabalho");
                MessageBox.Show(this, "Ocorreu erro ao tentar guardar os meses de trabalho.\nErro: " + ex.Message, "Erro grave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
