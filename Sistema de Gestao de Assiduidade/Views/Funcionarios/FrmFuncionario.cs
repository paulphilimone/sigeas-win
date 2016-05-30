using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mz.betainteractive.sigeas.model.ca;
using mz.betainteractive.sigeas.settings;
using mz.betainteractive.sigeas.utilities;
using System.Drawing.Imaging;
using System.IO;
using mz.betainteractive.sigeas;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.Models;
using mz.betainteractive.sigeas.Views.Funcionarios;
using mz.betainteractive.sigeas.Utilities.Components;

namespace mz.betainteractive.sigeas.Views.Funcionarios {
    public partial class FrmFuncionario : Form, AuthorizableComponent {

        private TreeNode rootNode;
        private Funcionario selectedFuncionario;
        private Empresa selectedEmpresa;
        private SigeasDatabaseContext context;

        /*Form Authorization*/
        public int FormCode { get; set; }
        public bool AllowView { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowAdd { get; set; }

        public FrmFuncionario() {
            InitializeComponent();
            
            rootNode = new TreeNode();
            TViewFuncionarios.Nodes.Clear();
            TViewFuncionarios.Nodes.Add(rootNode);
        }

        private void DisposeContext() {
            if (context != null) {
                context.Dispose();
                context = null;
                selectedFuncionario = null;
                LimparForm();
            }
        }

        private void LoadContext() {
            if (context == null) {
                context = new SigeasDatabaseContext();
            }

            selectedFuncionario = null;
            LimparForm();
        }

        private void FrmFuncionario_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
            DisposeContext();
        }

        private void FrmFuncionario_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                Console.WriteLine("Running");
                LoadContext();
                Initialize();
            }
        }

        private void Initialize() {
            InitData();
            LimparForm();
            LoadEmpresasToComboBox();
        }

        private void LoadEmpresasToComboBox() {
            
            Empresa empresa = SystemManager.GetCurrentEmpresa(context);
            CBoxEmpresas.Items.Clear();
            CBoxEmpresas.Items.Add(empresa);
            CBoxEmpresas.SelectedIndex = 0;
        }

        public void InitData() {
        
        }

        private void btLimpar_Click(object sender, EventArgs e) {
            LimparForm();
        }

        private void LimparForm() {
            selectedFuncionario = null;

            TxtNome.Text = "";
            //TxtApelido.Text = "";
            CBoxSexo.SelectedIndex = -1;
            CBoxEstadoCivil.SelectedIndex = -1;
            DtpDataNasc.Value = DateTime.Today;
            CBoxTipoDocumento.SelectedIndex = -1;
            TxtNumeroID.Text = "";
            
            CboxDepartamento.SelectedIndex = -1;
            CboxCategoria.SelectedIndex = -1;
            
            picBoxFoto.BackgroundImage = null;

            CBoxNacionalidade.SelectedIndex = -1;
            CBoxProvincia.SelectedIndex = -1;
            CBoxDistrito.SelectedIndex = -1;
            CBoxPostoAdministrativo.SelectedIndex = -1;
            CBoxLocalidade.SelectedIndex = -1;

            TxtBairro.Text = "";
            TxtAvenidaRua.Text = "";
            TxtNumero.Text = "";
            TxtEmail.Text = "";
            TxtTelefone.Text = "";

            TxtUserId.Text = "";
            TxtUserName.Text = "";
            TxtPassword.Text = "";            
            CboxPrevilege.SelectedIndex = 0;
            
            BtnRemover.Enabled = false;
            BtnChange.Enabled = false;
            BtnAddFuncionario.Enabled = true;

            GBoxFuncionario.Enabled = false;
        }


        private void LoadFuncionariosToTree(Empresa empresa) {                        
            if (empresa == null){
                return;
            }


            LimparForm();
            selectedEmpresa = empresa;
            
            rootNode.Nodes.Clear();
            rootNode.Text = "Não há funcionários cadastrados";
                        
            rootNode.Text = empresa.Nome;                       
                        
            foreach (Departamento dep in empresa.Departamentos) {                                
                                 
                TreeNodeDepartamento nodeDep = new TreeNodeDepartamento(dep);

                foreach (var func in dep.Funcionarios) {             
                    TreeNodeFuncionario nodeFunc = new TreeNodeFuncionario(func);                    
                    nodeDep.Nodes.Add(nodeFunc);
                }

                rootNode.Nodes.Add(nodeDep);
            }

            
            TViewFuncionarios.ExpandAll();
        }
        
        private void btFechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btRemover_Click(object sender, EventArgs e) {
            RemoverFuncionario();
        }

        private void RemoverFuncionario() {
            
            Funcionario funcionarioSelected = selectedFuncionario;

            if (funcionarioSelected == null) {
                MessageBox.Show("Selecione o funcionário primeiro");
                return;
            }

            DialogResult dr = MessageBox.Show("Tem certeza que deseja remover o funcionário(" + (TxtNome.Text + " " + TxtApelido.Text) + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) {
                return;
            }

            try {

                context.Funcionario.Remove(funcionarioSelected);
                context.SaveChanges();
                MessageBox.Show("O funcionário foi apagado com sucesso");

                LoadFuncionariosToTree(selectedEmpresa);

            } catch (Exception ex) {
                MessageBox.Show(this, "" + ex.Message, "Erro:");
            }

        }                

        private void btNovoFuncionario_Click(object sender, EventArgs e) {
            OpenAddFuncionario();
        }

        private void OpenAddFuncionario() {

            if (selectedEmpresa == null) {
                MessageBox.Show("Selecione uma empresa primeiro!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CBoxEmpresas.Focus();
                return;
            }

            FuncionarioAddView funcAddView = new FuncionarioAddView(context, selectedEmpresa);
            funcAddView.ShowDialog(this);

            LoadFuncionariosToTree(selectedEmpresa);
        }

        private void OpenEditFuncionario() {

            if (selectedEmpresa == null) {
                MessageBox.Show("Selecione uma empresa primeiro!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CBoxEmpresas.Focus();
                return;
            }

            if (selectedFuncionario == null) {
                MessageBox.Show("Selecione um funcionario primeiro!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TViewFuncionarios.Focus();
                return;
            }

            FuncionarioEditView funcEditView = new FuncionarioEditView(context, selectedEmpresa, selectedFuncionario);

            funcEditView.ShowDialog(this);

            LoadFuncionariosToTree(selectedEmpresa);
        }               

        private void treeViewFuncionarios_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            if (e.Node is TreeNodeFuncionario) {                
                TreeNodeFuncionario tnode = (TreeNodeFuncionario)e.Node;
                ViewFuncionario(tnode.Value);
            }
        }

        private void ViewFuncionario(Funcionario funcionario) {
            selectedFuncionario = funcionario;

            GBoxFuncionario.Enabled = true;
                        
            BtnRemover.Enabled = true;            
            BtnChange.Enabled = true;

            CBoxSexo.Items.Clear();
            CBoxEstadoCivil.Items.Clear();
            CBoxTipoDocumento.Items.Clear();
            CboxDepartamento.Items.Clear();
            CboxCategoria.Items.Clear();
            CBoxNacionalidade.Items.Clear();
            CBoxProvincia.Items.Clear();
            CBoxDistrito.Items.Clear();
            CBoxPostoAdministrativo.Items.Clear();
            CBoxLocalidade.Items.Clear();

            if (funcionario.Nome.Length > 0) { 
                TxtNome.Text = funcionario.Nome;
            }
            
            /*
            if (funcionario.Apelido.Length > 0) { 
                TxtApelido.Text = funcionario.Apelido;
            }*/
            
            if (funcionario.Sexo != null) { 
                CBoxSexo.Items.Add(funcionario.Sexo);
                CBoxSexo.SelectedIndex = 0;
            }

            if (funcionario.EstadoCivil != null) {
                CBoxEstadoCivil.Items.Add(funcionario.EstadoCivil);
                CBoxEstadoCivil.SelectedIndex = 0;
            }

            if (funcionario.DataDeNascimento.HasValue) {
                DtpDataNasc.Value = funcionario.DataDeNascimento.Value;
            }

            if (funcionario.DocumentoIdentificacao != null) {
                CBoxTipoDocumento.Items.Add(funcionario.DocumentoIdentificacao);
                CBoxTipoDocumento.SelectedIndex = 0;
            }

            if (funcionario.NumeroDI != null) {
                TxtNumeroID.Text = funcionario.NumeroDI;
            }

            if (funcionario.Departamento != null) {             
                CboxDepartamento.Items.Add(funcionario.Departamento);
                CboxDepartamento.SelectedIndex = 0;
            }

            if (funcionario.Categoria != null) {
                CboxCategoria.Items.Add(funcionario.Categoria);
                CboxCategoria.SelectedIndex = 0;
            }
            
            if (funcionario.Photo != null){
                if (funcionario.Photo.Length > 0) {
                    picBoxFoto.BackgroundImage = GetPictureFromArray(funcionario.Photo);
                }                
            }
            
            if (funcionario.Nacionalidade != null) {
                CBoxNacionalidade.Items.Add(funcionario.Nacionalidade);
                CBoxNacionalidade.SelectedIndex = 0;
            }            
            
            if (funcionario.Provincia != null) {
                CBoxProvincia.Items.Add(funcionario.Provincia);
                CBoxProvincia.SelectedIndex = 0;
            }            
            
            if (funcionario.Distrito != null){
                CBoxDistrito.Items.Add(funcionario.Distrito);
                CBoxDistrito.SelectedIndex = 0;
            }
            
            if (funcionario.PostoAdministrativo != null){
                CBoxPostoAdministrativo.Items.Add(funcionario.PostoAdministrativo);
                CBoxPostoAdministrativo.SelectedIndex = 0;
            }
            
            if (funcionario.Localidade != null){
                CBoxLocalidade.Items.Add(funcionario.Localidade);
                CBoxLocalidade.SelectedIndex = 0;
            }

            if (funcionario.Bairro != null) {
                TxtBairro.Text = funcionario.Bairro;
            }

            if (funcionario.AvenidaRua != null) {
                TxtAvenidaRua.Text = funcionario.AvenidaRua;
            }

            if (funcionario.NumeroCasa.HasValue) {
                TxtNumero.Text = funcionario.NumeroCasa.ToString();
            }

            if (funcionario.Email != null) {
                TxtEmail.Text = funcionario.Email;
            }

            if (funcionario.Telefone != null) {
                TxtTelefone.Text = funcionario.Telefone;
            }

            if (funcionario.EnrollNumber.HasValue) {
                TxtUserId.Text = funcionario.EnrollNumber.ToString();
            }

            if (funcionario.UserName.Length > 0) {
                TxtUserName.Text = funcionario.UserName;
            }

            if (funcionario.Password.Length > 0) {
                TxtPassword.Text = funcionario.Password;
            }

            if (funcionario.Privilege.HasValue) {
                CboxPrevilege.SelectedIndex = funcionario.Privilege.Value;
            }

            if (funcionario.Enabled.HasValue) {
                ChkEnabled.Checked = funcionario.Enabled.Value;
            }
            
        }

        private Image GetPictureFromArray(byte[] p) {
            try {
                MemoryStream ms = new MemoryStream(p);
                Image img = Image.FromStream(ms);
                return img;
            } catch (Exception ex) {
                MessageBox.Show("Não foi possivel ler a foto apartir da base de dados");
                return null;
            }
        }

        private void CBoxEmpresas_SelectedIndexChanged(object sender, EventArgs e) {
            OnSelectedEmpresa();
        }

        private void OnSelectedEmpresa() {
            if (CBoxEmpresas.SelectedIndex == -1) {
                LimparForm();
            }

            Empresa empresa = CBoxEmpresas.SelectedItem as Empresa;
            LoadFuncionariosToTree(empresa);
        }

        private void BtnChange_Click(object sender, EventArgs e) {
            OpenEditFuncionario();
        }        
        
    }
}
