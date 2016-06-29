namespace mz.betainteractive.sigeas.Views.Empresas
{
    partial class FrmEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Administração", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Manuntenção", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Marketing", 1, 1);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Financeiro", 1, 1);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Departamentos", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Director Geral", 2, 2);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Secretário", 2, 2);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Engenheiro Mecanico \"A\"", 2, 2);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Categorias", 2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresa));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "2016",
            "Janeiro",
            "01 Janeiro",
            "31 Janeiro"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAvenidaRua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboLocalidade = new System.Windows.Forms.ComboBox();
            this.cboPostoAdministrativo = new System.Windows.Forms.ComboBox();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btGravar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.tabEmpresa = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnAddDepartamento = new System.Windows.Forms.Button();
            this.BtnAddCategoria = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btRemoverCateg = new System.Windows.Forms.Button();
            this.btAlterarCateg = new System.Windows.Forms.Button();
            this.BtnLimparCateg = new System.Windows.Forms.Button();
            this.BtnUpdateCategoria = new System.Windows.Forms.Button();
            this.txtCategFuncoes = new System.Windows.Forms.TextBox();
            this.txtCategNome = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnRemoverDepart = new System.Windows.Forms.Button();
            this.BtnAlterarDepart = new System.Windows.Forms.Button();
            this.BtnLimparDep = new System.Windows.Forms.Button();
            this.BtnUpdateDepartamento = new System.Windows.Forms.Button();
            this.txtDepartDescricao = new System.Windows.Forms.TextBox();
            this.txtDepartNome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.treeViewDepartCategs = new System.Windows.Forms.TreeView();
            this.empresaImageList = new System.Windows.Forms.ImageList(this.components);
            this.tabPageAttendRules = new System.Windows.Forms.TabPage();
            this.btCreateRules = new System.Windows.Forms.Button();
            this.btUpdateRules = new System.Windows.Forms.Button();
            this.grpBoxRegras4 = new System.Windows.Forms.GroupBox();
            this.chkClockingOverHorarioDia = new System.Windows.Forms.CheckBox();
            this.grpBoxRegras3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.nudIfNoClockOut = new System.Windows.Forms.NumericUpDown();
            this.grpBoxRegras2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.nudIfNoClockIn = new System.Windows.Forms.NumericUpDown();
            this.grpBoxRegras1 = new System.Windows.Forms.GroupBox();
            this.nudCountAtrasoAfter = new System.Windows.Forms.NumericUpDown();
            this.nudCountHrExAfter = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtMonthName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtMonthDays = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btPreviewMonthList = new System.Windows.Forms.Button();
            this.btGenerateMonthsList = new System.Windows.Forms.Button();
            this.listViewMonths = new System.Windows.Forms.ListView();
            this.colHeaderOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderMonthName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderFirst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderLast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderDays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.funcionarioImageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabEmpresa.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPageAttendRules.SuspendLayout();
            this.grpBoxRegras4.SuspendLayout();
            this.grpBoxRegras3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIfNoClockOut)).BeginInit();
            this.grpBoxRegras2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIfNoClockIn)).BeginInit();
            this.grpBoxRegras1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountAtrasoAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountHrExAfter)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da empresa";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(141, 17);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(331, 22);
            this.txtNomeEmpresa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Provincia";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtAvenidaRua);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboLocalidade);
            this.groupBox1.Controls.Add(this.cboPostoAdministrativo);
            this.groupBox1.Controls.Add(this.cboDistrito);
            this.groupBox1.Controls.Add(this.cboProvincia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localização";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(389, 134);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(83, 22);
            this.txtNumero.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nº";
            // 
            // txtAvenidaRua
            // 
            this.txtAvenidaRua.Location = new System.Drawing.Point(141, 134);
            this.txtAvenidaRua.Name = "txtAvenidaRua";
            this.txtAvenidaRua.Size = new System.Drawing.Size(217, 22);
            this.txtAvenidaRua.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Av. Rua";
            // 
            // cboLocalidade
            // 
            this.cboLocalidade.FormattingEnabled = true;
            this.cboLocalidade.Location = new System.Drawing.Point(141, 107);
            this.cboLocalidade.Name = "cboLocalidade";
            this.cboLocalidade.Size = new System.Drawing.Size(217, 21);
            this.cboLocalidade.TabIndex = 5;
            // 
            // cboPostoAdministrativo
            // 
            this.cboPostoAdministrativo.FormattingEnabled = true;
            this.cboPostoAdministrativo.Location = new System.Drawing.Point(141, 80);
            this.cboPostoAdministrativo.Name = "cboPostoAdministrativo";
            this.cboPostoAdministrativo.Size = new System.Drawing.Size(217, 21);
            this.cboPostoAdministrativo.TabIndex = 4;
            this.cboPostoAdministrativo.SelectedIndexChanged += new System.EventHandler(this.cboPostoAdministrativo_SelectedIndexChanged);
            // 
            // cboDistrito
            // 
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(141, 53);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(217, 21);
            this.cboDistrito.TabIndex = 3;
            this.cboDistrito.SelectedIndexChanged += new System.EventHandler(this.cboDistrito_SelectedIndexChanged);
            // 
            // cboProvincia
            // 
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(141, 25);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(217, 21);
            this.cboProvincia.TabIndex = 2;
            this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Localidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Posto Administrativo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Distrito";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFax);
            this.groupBox2.Controls.Add(this.txtTelefone);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(14, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 125);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contacto";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(78, 79);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(200, 22);
            this.txtFax.TabIndex = 10;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(78, 52);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(200, 22);
            this.txtTelefone.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(78, 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(318, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Fax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "E-mail";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtNomeEmpresa);
            this.groupBox3.Location = new System.Drawing.Point(14, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 49);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(381, 382);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(122, 23);
            this.btGravar.TabIndex = 4;
            this.btGravar.Text = "Registar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(398, 452);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(122, 23);
            this.btFechar.TabIndex = 5;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // tabEmpresa
            // 
            this.tabEmpresa.Controls.Add(this.tabPage1);
            this.tabEmpresa.Controls.Add(this.tabPage2);
            this.tabEmpresa.Controls.Add(this.tabPageAttendRules);
            this.tabEmpresa.Controls.Add(this.tabPage3);
            this.tabEmpresa.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmpresa.Location = new System.Drawing.Point(2, 2);
            this.tabEmpresa.Name = "tabEmpresa";
            this.tabEmpresa.SelectedIndex = 0;
            this.tabEmpresa.Size = new System.Drawing.Size(529, 444);
            this.tabEmpresa.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btGravar);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(521, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados da empresa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.treeViewDepartCategs);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(521, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Departamentos & Categorias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnAddDepartamento);
            this.groupBox6.Controls.Add(this.BtnAddCategoria);
            this.groupBox6.Location = new System.Drawing.Point(6, 328);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(193, 84);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            // 
            // BtnAddDepartamento
            // 
            this.BtnAddDepartamento.Location = new System.Drawing.Point(16, 18);
            this.BtnAddDepartamento.Name = "BtnAddDepartamento";
            this.BtnAddDepartamento.Size = new System.Drawing.Size(163, 23);
            this.BtnAddDepartamento.TabIndex = 7;
            this.BtnAddDepartamento.Text = "Adicionar Departamento";
            this.BtnAddDepartamento.UseVisualStyleBackColor = true;
            this.BtnAddDepartamento.Click += new System.EventHandler(this.BtnAddDepartamento_Click);
            // 
            // BtnAddCategoria
            // 
            this.BtnAddCategoria.Location = new System.Drawing.Point(16, 47);
            this.BtnAddCategoria.Name = "BtnAddCategoria";
            this.BtnAddCategoria.Size = new System.Drawing.Size(163, 23);
            this.BtnAddCategoria.TabIndex = 8;
            this.BtnAddCategoria.Text = "Adicionar Categoria";
            this.BtnAddCategoria.UseVisualStyleBackColor = true;
            this.BtnAddCategoria.Click += new System.EventHandler(this.BtnAddCategoria_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btRemoverCateg);
            this.groupBox5.Controls.Add(this.btAlterarCateg);
            this.groupBox5.Controls.Add(this.BtnLimparCateg);
            this.groupBox5.Controls.Add(this.BtnUpdateCategoria);
            this.groupBox5.Controls.Add(this.txtCategFuncoes);
            this.groupBox5.Controls.Add(this.txtCategNome);
            this.groupBox5.Controls.Add(this.Label20);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(204, 194);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(310, 178);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Categoria";
            // 
            // btRemoverCateg
            // 
            this.btRemoverCateg.Enabled = false;
            this.btRemoverCateg.Location = new System.Drawing.Point(159, 140);
            this.btRemoverCateg.Name = "btRemoverCateg";
            this.btRemoverCateg.Size = new System.Drawing.Size(66, 23);
            this.btRemoverCateg.TabIndex = 8;
            this.btRemoverCateg.Text = "Remover";
            this.btRemoverCateg.UseVisualStyleBackColor = true;
            this.btRemoverCateg.Click += new System.EventHandler(this.btRemoverCateg_Click);
            // 
            // btAlterarCateg
            // 
            this.btAlterarCateg.Enabled = false;
            this.btAlterarCateg.Location = new System.Drawing.Point(87, 140);
            this.btAlterarCateg.Name = "btAlterarCateg";
            this.btAlterarCateg.Size = new System.Drawing.Size(66, 23);
            this.btAlterarCateg.TabIndex = 7;
            this.btAlterarCateg.Text = "Alterar";
            this.btAlterarCateg.UseVisualStyleBackColor = true;
            this.btAlterarCateg.Click += new System.EventHandler(this.btAlterarCateg_Click);
            // 
            // BtnLimparCateg
            // 
            this.BtnLimparCateg.Location = new System.Drawing.Point(230, 140);
            this.BtnLimparCateg.Name = "BtnLimparCateg";
            this.BtnLimparCateg.Size = new System.Drawing.Size(66, 23);
            this.BtnLimparCateg.TabIndex = 5;
            this.BtnLimparCateg.Text = "Limpar";
            this.BtnLimparCateg.UseVisualStyleBackColor = true;
            this.BtnLimparCateg.Click += new System.EventHandler(this.btLimparCateg_Click);
            // 
            // BtnUpdateCategoria
            // 
            this.BtnUpdateCategoria.Enabled = false;
            this.BtnUpdateCategoria.Location = new System.Drawing.Point(15, 140);
            this.BtnUpdateCategoria.Name = "BtnUpdateCategoria";
            this.BtnUpdateCategoria.Size = new System.Drawing.Size(66, 23);
            this.BtnUpdateCategoria.TabIndex = 4;
            this.BtnUpdateCategoria.Text = "Atualizar";
            this.BtnUpdateCategoria.UseVisualStyleBackColor = true;
            this.BtnUpdateCategoria.Click += new System.EventHandler(this.btGravarCategoria_Click);
            // 
            // txtCategFuncoes
            // 
            this.txtCategFuncoes.Location = new System.Drawing.Point(73, 50);
            this.txtCategFuncoes.Multiline = true;
            this.txtCategFuncoes.Name = "txtCategFuncoes";
            this.txtCategFuncoes.ReadOnly = true;
            this.txtCategFuncoes.Size = new System.Drawing.Size(223, 84);
            this.txtCategFuncoes.TabIndex = 3;
            // 
            // txtCategNome
            // 
            this.txtCategNome.Location = new System.Drawing.Point(73, 22);
            this.txtCategNome.Name = "txtCategNome";
            this.txtCategNome.ReadOnly = true;
            this.txtCategNome.Size = new System.Drawing.Size(223, 22);
            this.txtCategNome.TabIndex = 2;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(12, 71);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(48, 13);
            this.Label20.TabIndex = 1;
            this.Label20.Text = "Funções";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Nome";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnRemoverDepart);
            this.groupBox4.Controls.Add(this.BtnAlterarDepart);
            this.groupBox4.Controls.Add(this.BtnLimparDep);
            this.groupBox4.Controls.Add(this.BtnUpdateDepartamento);
            this.groupBox4.Controls.Add(this.txtDepartDescricao);
            this.groupBox4.Controls.Add(this.txtDepartNome);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(204, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 175);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Departamento";
            // 
            // BtnRemoverDepart
            // 
            this.BtnRemoverDepart.Enabled = false;
            this.BtnRemoverDepart.Location = new System.Drawing.Point(158, 141);
            this.BtnRemoverDepart.Name = "BtnRemoverDepart";
            this.BtnRemoverDepart.Size = new System.Drawing.Size(66, 23);
            this.BtnRemoverDepart.TabIndex = 7;
            this.BtnRemoverDepart.Text = "Remover";
            this.BtnRemoverDepart.UseVisualStyleBackColor = true;
            this.BtnRemoverDepart.Click += new System.EventHandler(this.btRemoverDepart_Click);
            // 
            // BtnAlterarDepart
            // 
            this.BtnAlterarDepart.Enabled = false;
            this.BtnAlterarDepart.Location = new System.Drawing.Point(86, 141);
            this.BtnAlterarDepart.Name = "BtnAlterarDepart";
            this.BtnAlterarDepart.Size = new System.Drawing.Size(66, 23);
            this.BtnAlterarDepart.TabIndex = 6;
            this.BtnAlterarDepart.Text = "Alterar";
            this.BtnAlterarDepart.UseVisualStyleBackColor = true;
            this.BtnAlterarDepart.Click += new System.EventHandler(this.btAlterarDepart_Click);
            // 
            // BtnLimparDep
            // 
            this.BtnLimparDep.Location = new System.Drawing.Point(230, 141);
            this.BtnLimparDep.Name = "BtnLimparDep";
            this.BtnLimparDep.Size = new System.Drawing.Size(66, 23);
            this.BtnLimparDep.TabIndex = 5;
            this.BtnLimparDep.Text = "Limpar";
            this.BtnLimparDep.UseVisualStyleBackColor = true;
            this.BtnLimparDep.Click += new System.EventHandler(this.btLimparDep_Click);
            // 
            // BtnUpdateDepartamento
            // 
            this.BtnUpdateDepartamento.Enabled = false;
            this.BtnUpdateDepartamento.Location = new System.Drawing.Point(15, 141);
            this.BtnUpdateDepartamento.Name = "BtnUpdateDepartamento";
            this.BtnUpdateDepartamento.Size = new System.Drawing.Size(66, 23);
            this.BtnUpdateDepartamento.TabIndex = 4;
            this.BtnUpdateDepartamento.Text = "Atualizar";
            this.BtnUpdateDepartamento.UseVisualStyleBackColor = true;
            this.BtnUpdateDepartamento.Click += new System.EventHandler(this.btGravarDepartamento_Click);
            // 
            // txtDepartDescricao
            // 
            this.txtDepartDescricao.Location = new System.Drawing.Point(73, 50);
            this.txtDepartDescricao.Multiline = true;
            this.txtDepartDescricao.Name = "txtDepartDescricao";
            this.txtDepartDescricao.ReadOnly = true;
            this.txtDepartDescricao.Size = new System.Drawing.Size(223, 84);
            this.txtDepartDescricao.TabIndex = 3;
            // 
            // txtDepartNome
            // 
            this.txtDepartNome.Location = new System.Drawing.Point(73, 22);
            this.txtDepartNome.Name = "txtDepartNome";
            this.txtDepartNome.ReadOnly = true;
            this.txtDepartNome.Size = new System.Drawing.Size(223, 22);
            this.txtDepartNome.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Descrição";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nome";
            // 
            // treeViewDepartCategs
            // 
            this.treeViewDepartCategs.ImageIndex = 0;
            this.treeViewDepartCategs.ImageList = this.empresaImageList;
            this.treeViewDepartCategs.Location = new System.Drawing.Point(6, 17);
            this.treeViewDepartCategs.Name = "treeViewDepartCategs";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Node2";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Administração";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Node3";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Manuntenção";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "Node4";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Marketing";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "Node5";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "Financeiro";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "Node0";
            treeNode5.SelectedImageIndex = 1;
            treeNode5.Text = "Departamentos";
            treeNode6.ImageIndex = 2;
            treeNode6.Name = "Node6";
            treeNode6.SelectedImageIndex = 2;
            treeNode6.Text = "Director Geral";
            treeNode7.ImageIndex = 2;
            treeNode7.Name = "Node7";
            treeNode7.SelectedImageIndex = 2;
            treeNode7.Text = "Secretário";
            treeNode8.ImageIndex = 2;
            treeNode8.Name = "Node8";
            treeNode8.SelectedImageIndex = 2;
            treeNode8.Text = "Engenheiro Mecanico \"A\"";
            treeNode9.ImageIndex = 2;
            treeNode9.Name = "Node1";
            treeNode9.SelectedImageIndex = 2;
            treeNode9.Text = "Categorias";
            this.treeViewDepartCategs.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9});
            this.treeViewDepartCategs.SelectedImageIndex = 0;
            this.treeViewDepartCategs.ShowNodeToolTips = true;
            this.treeViewDepartCategs.ShowPlusMinus = false;
            this.treeViewDepartCategs.ShowRootLines = false;
            this.treeViewDepartCategs.Size = new System.Drawing.Size(193, 311);
            this.treeViewDepartCategs.TabIndex = 0;
            this.treeViewDepartCategs.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewDepartCategs_NodeMouseDoubleClick);
            // 
            // empresaImageList
            // 
            this.empresaImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("empresaImageList.ImageStream")));
            this.empresaImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.empresaImageList.Images.SetKeyName(0, "globe.png");
            this.empresaImageList.Images.SetKeyName(1, "OrganizerHS.png");
            this.empresaImageList.Images.SetKeyName(2, "Journal.png");
            this.empresaImageList.Images.SetKeyName(3, "Team.png");
            // 
            // tabPageAttendRules
            // 
            this.tabPageAttendRules.Controls.Add(this.btCreateRules);
            this.tabPageAttendRules.Controls.Add(this.btUpdateRules);
            this.tabPageAttendRules.Controls.Add(this.grpBoxRegras4);
            this.tabPageAttendRules.Controls.Add(this.grpBoxRegras3);
            this.tabPageAttendRules.Controls.Add(this.grpBoxRegras2);
            this.tabPageAttendRules.Controls.Add(this.grpBoxRegras1);
            this.tabPageAttendRules.Location = new System.Drawing.Point(4, 22);
            this.tabPageAttendRules.Name = "tabPageAttendRules";
            this.tabPageAttendRules.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAttendRules.Size = new System.Drawing.Size(521, 418);
            this.tabPageAttendRules.TabIndex = 2;
            this.tabPageAttendRules.Text = "Regras de assiduidade";
            this.tabPageAttendRules.UseVisualStyleBackColor = true;
            // 
            // btCreateRules
            // 
            this.btCreateRules.Location = new System.Drawing.Point(216, 371);
            this.btCreateRules.Name = "btCreateRules";
            this.btCreateRules.Size = new System.Drawing.Size(161, 23);
            this.btCreateRules.TabIndex = 26;
            this.btCreateRules.Text = "Criar regras de assiduidade";
            this.btCreateRules.UseVisualStyleBackColor = true;
            this.btCreateRules.Visible = false;
            this.btCreateRules.Click += new System.EventHandler(this.btCreateRules_Click);
            // 
            // btUpdateRules
            // 
            this.btUpdateRules.Location = new System.Drawing.Point(383, 371);
            this.btUpdateRules.Name = "btUpdateRules";
            this.btUpdateRules.Size = new System.Drawing.Size(119, 23);
            this.btUpdateRules.TabIndex = 25;
            this.btUpdateRules.Text = "Atualizar";
            this.btUpdateRules.UseVisualStyleBackColor = true;
            this.btUpdateRules.Click += new System.EventHandler(this.btUpdateRules_Click);
            // 
            // grpBoxRegras4
            // 
            this.grpBoxRegras4.Controls.Add(this.chkClockingOverHorarioDia);
            this.grpBoxRegras4.Location = new System.Drawing.Point(19, 270);
            this.grpBoxRegras4.Name = "grpBoxRegras4";
            this.grpBoxRegras4.Size = new System.Drawing.Size(483, 82);
            this.grpBoxRegras4.TabIndex = 24;
            this.grpBoxRegras4.TabStop = false;
            // 
            // chkClockingOverHorarioDia
            // 
            this.chkClockingOverHorarioDia.AutoSize = true;
            this.chkClockingOverHorarioDia.Enabled = false;
            this.chkClockingOverHorarioDia.Location = new System.Drawing.Point(96, 34);
            this.chkClockingOverHorarioDia.Name = "chkClockingOverHorarioDia";
            this.chkClockingOverHorarioDia.Size = new System.Drawing.Size(315, 17);
            this.chkClockingOverHorarioDia.TabIndex = 0;
            this.chkClockingOverHorarioDia.Text = "Permitir registo de entrada/saida fora do horario normal";
            this.chkClockingOverHorarioDia.UseVisualStyleBackColor = true;
            // 
            // grpBoxRegras3
            // 
            this.grpBoxRegras3.Controls.Add(this.label21);
            this.grpBoxRegras3.Controls.Add(this.label22);
            this.grpBoxRegras3.Controls.Add(this.nudIfNoClockOut);
            this.grpBoxRegras3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxRegras3.Location = new System.Drawing.Point(19, 194);
            this.grpBoxRegras3.Name = "grpBoxRegras3";
            this.grpBoxRegras3.Size = new System.Drawing.Size(483, 70);
            this.grpBoxRegras3.TabIndex = 23;
            this.grpBoxRegras3.TabStop = false;
            this.grpBoxRegras3.Text = "Se não houver registo de saída, mas tiver registo de entrada, considerar que:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(129, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(250, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "minutos antes da hora de saída (segundo o horário)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(27, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "Saiu";
            // 
            // nudIfNoClockOut
            // 
            this.nudIfNoClockOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIfNoClockOut.Location = new System.Drawing.Point(71, 25);
            this.nudIfNoClockOut.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudIfNoClockOut.Name = "nudIfNoClockOut";
            this.nudIfNoClockOut.Size = new System.Drawing.Size(52, 20);
            this.nudIfNoClockOut.TabIndex = 3;
            this.nudIfNoClockOut.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // grpBoxRegras2
            // 
            this.grpBoxRegras2.Controls.Add(this.label19);
            this.grpBoxRegras2.Controls.Add(this.label18);
            this.grpBoxRegras2.Controls.Add(this.nudIfNoClockIn);
            this.grpBoxRegras2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxRegras2.Location = new System.Drawing.Point(19, 118);
            this.grpBoxRegras2.Name = "grpBoxRegras2";
            this.grpBoxRegras2.Size = new System.Drawing.Size(483, 70);
            this.grpBoxRegras2.TabIndex = 22;
            this.grpBoxRegras2.TabStop = false;
            this.grpBoxRegras2.Text = "Se não houver registo de entrada, mas tiver registo de saída, considerar que:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(129, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(264, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "minutos depois do hora de entrada (segundo o horário)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(27, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Entrou";
            // 
            // nudIfNoClockIn
            // 
            this.nudIfNoClockIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIfNoClockIn.Location = new System.Drawing.Point(71, 30);
            this.nudIfNoClockIn.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudIfNoClockIn.Name = "nudIfNoClockIn";
            this.nudIfNoClockIn.Size = new System.Drawing.Size(52, 20);
            this.nudIfNoClockIn.TabIndex = 0;
            this.nudIfNoClockIn.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // grpBoxRegras1
            // 
            this.grpBoxRegras1.Controls.Add(this.nudCountAtrasoAfter);
            this.grpBoxRegras1.Controls.Add(this.nudCountHrExAfter);
            this.grpBoxRegras1.Controls.Add(this.label13);
            this.grpBoxRegras1.Controls.Add(this.label15);
            this.grpBoxRegras1.Controls.Add(this.label16);
            this.grpBoxRegras1.Controls.Add(this.label17);
            this.grpBoxRegras1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxRegras1.Location = new System.Drawing.Point(19, 23);
            this.grpBoxRegras1.Name = "grpBoxRegras1";
            this.grpBoxRegras1.Size = new System.Drawing.Size(483, 89);
            this.grpBoxRegras1.TabIndex = 20;
            this.grpBoxRegras1.TabStop = false;
            this.grpBoxRegras1.Text = "Considerar como:";
            // 
            // nudCountAtrasoAfter
            // 
            this.nudCountAtrasoAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCountAtrasoAfter.Location = new System.Drawing.Point(148, 50);
            this.nudCountAtrasoAfter.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudCountAtrasoAfter.Name = "nudCountAtrasoAfter";
            this.nudCountAtrasoAfter.Size = new System.Drawing.Size(40, 20);
            this.nudCountAtrasoAfter.TabIndex = 18;
            this.nudCountAtrasoAfter.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // nudCountHrExAfter
            // 
            this.nudCountHrExAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCountHrExAfter.Location = new System.Drawing.Point(148, 25);
            this.nudCountHrExAfter.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudCountHrExAfter.Name = "nudCountHrExAfter";
            this.nudCountHrExAfter.Size = new System.Drawing.Size(40, 20);
            this.nudCountHrExAfter.TabIndex = 17;
            this.nudCountHrExAfter.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Horas extras depois de";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(56, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Atraso depois de";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(194, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Minutos";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(194, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Minutos";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.btPreviewMonthList);
            this.tabPage3.Controls.Add(this.btGenerateMonthsList);
            this.tabPage3.Controls.Add(this.listViewMonths);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(521, 418);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Ano Laboral";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.dtpStartDate);
            this.groupBox7.Controls.Add(this.txtMonthName);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.txtMonthDays);
            this.groupBox7.Controls.Add(this.txtEndDate);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(498, 96);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ano Laboral da Empresa, para efeitos de fim de balanço";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Data Inicial";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "    dd MMMM yyyy";
            this.dtpStartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(9, 45);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(164, 22);
            this.dtpStartDate.TabIndex = 0;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpInitialDay_ValueChanged);
            // 
            // txtMonthName
            // 
            this.txtMonthName.Location = new System.Drawing.Point(375, 45);
            this.txtMonthName.Name = "txtMonthName";
            this.txtMonthName.ReadOnly = true;
            this.txtMonthName.Size = new System.Drawing.Size(112, 22);
            this.txtMonthName.TabIndex = 8;
            this.txtMonthName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(176, 29);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 13);
            this.label24.TabIndex = 3;
            this.label24.Text = "Data Final";
            // 
            // txtMonthDays
            // 
            this.txtMonthDays.Location = new System.Drawing.Point(339, 45);
            this.txtMonthDays.Name = "txtMonthDays";
            this.txtMonthDays.ReadOnly = true;
            this.txtMonthDays.Size = new System.Drawing.Size(30, 22);
            this.txtMonthDays.TabIndex = 7;
            this.txtMonthDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(179, 46);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(137, 22);
            this.txtEndDate.TabIndex = 4;
            this.txtEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(336, 29);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(105, 13);
            this.label25.TabIndex = 6;
            this.label25.Text = "Total de dias e Mês";
            // 
            // btPreviewMonthList
            // 
            this.btPreviewMonthList.Location = new System.Drawing.Point(15, 108);
            this.btPreviewMonthList.Name = "btPreviewMonthList";
            this.btPreviewMonthList.Size = new System.Drawing.Size(164, 23);
            this.btPreviewMonthList.TabIndex = 9;
            this.btPreviewMonthList.Text = "Preview Months List";
            this.btPreviewMonthList.UseVisualStyleBackColor = true;
            this.btPreviewMonthList.Click += new System.EventHandler(this.btPreviewMonthList_Click);
            // 
            // btGenerateMonthsList
            // 
            this.btGenerateMonthsList.Location = new System.Drawing.Point(185, 108);
            this.btGenerateMonthsList.Name = "btGenerateMonthsList";
            this.btGenerateMonthsList.Size = new System.Drawing.Size(161, 23);
            this.btGenerateMonthsList.TabIndex = 5;
            this.btGenerateMonthsList.Text = "Generate Months List";
            this.btGenerateMonthsList.UseVisualStyleBackColor = true;
            this.btGenerateMonthsList.Click += new System.EventHandler(this.btGenerateMonthsList_Click);
            // 
            // listViewMonths
            // 
            this.listViewMonths.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderOrder,
            this.colHeaderYear,
            this.colHeaderMonthName,
            this.colHeaderFirst,
            this.colHeaderLast,
            this.colHeaderDays});
            this.listViewMonths.FullRowSelect = true;
            this.listViewMonths.GridLines = true;
            this.listViewMonths.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listViewMonths.Location = new System.Drawing.Point(15, 147);
            this.listViewMonths.MultiSelect = false;
            this.listViewMonths.Name = "listViewMonths";
            this.listViewMonths.Size = new System.Drawing.Size(489, 252);
            this.listViewMonths.TabIndex = 2;
            this.listViewMonths.UseCompatibleStateImageBehavior = false;
            this.listViewMonths.View = System.Windows.Forms.View.Details;
            // 
            // colHeaderOrder
            // 
            this.colHeaderOrder.Text = "Ord";
            this.colHeaderOrder.Width = 40;
            // 
            // colHeaderYear
            // 
            this.colHeaderYear.Text = "Ano";
            this.colHeaderYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeaderYear.Width = 51;
            // 
            // colHeaderMonthName
            // 
            this.colHeaderMonthName.Text = "Mês";
            this.colHeaderMonthName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeaderMonthName.Width = 114;
            // 
            // colHeaderFirst
            // 
            this.colHeaderFirst.Text = "Data de inicio";
            this.colHeaderFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeaderFirst.Width = 101;
            // 
            // colHeaderLast
            // 
            this.colHeaderLast.Text = "Data do fim";
            this.colHeaderLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeaderLast.Width = 90;
            // 
            // colHeaderDays
            // 
            this.colHeaderDays.Text = "T. Dias";
            // 
            // funcionarioImageList
            // 
            this.funcionarioImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("funcionarioImageList.ImageStream")));
            this.funcionarioImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.funcionarioImageList.Images.SetKeyName(0, "globe.png");
            this.funcionarioImageList.Images.SetKeyName(1, "OrganizerHS.png");
            this.funcionarioImageList.Images.SetKeyName(2, "Journal.png");
            this.funcionarioImageList.Images.SetKeyName(3, "person01.png");
            this.funcionarioImageList.Images.SetKeyName(4, "Team.png");
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 487);
            this.Controls.Add(this.tabEmpresa);
            this.Controls.Add(this.btFechar);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Definicões da Empresa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEmpresa_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.FrmEmpresa_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabEmpresa.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPageAttendRules.ResumeLayout(false);
            this.grpBoxRegras4.ResumeLayout(false);
            this.grpBoxRegras4.PerformLayout();
            this.grpBoxRegras3.ResumeLayout(false);
            this.grpBoxRegras3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIfNoClockOut)).EndInit();
            this.grpBoxRegras2.ResumeLayout(false);
            this.grpBoxRegras2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIfNoClockIn)).EndInit();
            this.grpBoxRegras1.ResumeLayout(false);
            this.grpBoxRegras1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountAtrasoAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountHrExAfter)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboLocalidade;
        private System.Windows.Forms.ComboBox cboPostoAdministrativo;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.TextBox txtAvenidaRua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.TabControl tabEmpresa;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView treeViewDepartCategs;
        private System.Windows.Forms.ImageList empresaImageList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDepartDescricao;
        private System.Windows.Forms.TextBox txtDepartNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnLimparCateg;
        private System.Windows.Forms.Button BtnUpdateCategoria;
        private System.Windows.Forms.TextBox txtCategFuncoes;
        private System.Windows.Forms.TextBox txtCategNome;
        private System.Windows.Forms.Label Label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnLimparDep;
        private System.Windows.Forms.Button BtnUpdateDepartamento;
        private System.Windows.Forms.ImageList funcionarioImageList;
        private System.Windows.Forms.TabPage tabPageAttendRules;
        private System.Windows.Forms.GroupBox grpBoxRegras1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nudCountHrExAfter;
        private System.Windows.Forms.NumericUpDown nudCountAtrasoAfter;
        private System.Windows.Forms.GroupBox grpBoxRegras2;
        private System.Windows.Forms.NumericUpDown nudIfNoClockIn;
        private System.Windows.Forms.GroupBox grpBoxRegras3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown nudIfNoClockOut;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox grpBoxRegras4;
        private System.Windows.Forms.CheckBox chkClockingOverHorarioDia;
        private System.Windows.Forms.Button btUpdateRules;
        private System.Windows.Forms.Button btCreateRules;
        private System.Windows.Forms.Button BtnAlterarDepart;
        private System.Windows.Forms.Button btAlterarCateg;
        private System.Windows.Forms.Button BtnRemoverDepart;
        private System.Windows.Forms.Button btRemoverCateg;
        private System.Windows.Forms.Button BtnAddDepartamento;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnAddCategoria;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listViewMonths;
        private System.Windows.Forms.ColumnHeader colHeaderOrder;
        private System.Windows.Forms.ColumnHeader colHeaderYear;
        private System.Windows.Forms.ColumnHeader colHeaderMonthName;
        private System.Windows.Forms.ColumnHeader colHeaderFirst;
        private System.Windows.Forms.ColumnHeader colHeaderLast;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtMonthName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtMonthDays;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btPreviewMonthList;
        private System.Windows.Forms.Button btGenerateMonthsList;
        private System.Windows.Forms.ColumnHeader colHeaderDays;
    }
}