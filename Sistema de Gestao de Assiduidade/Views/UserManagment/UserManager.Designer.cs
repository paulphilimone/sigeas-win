namespace mz.betainteractive.sigeas.Views.UserManagment {
    partial class UserManager {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManager));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Sisga Programmers", 2);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Paulo Filimone", 2);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Developers", 3);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Administrators", 3);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnAppUser_CleanForm = new System.Windows.Forms.Button();
            this.BtnAppUser_Remove = new System.Windows.Forms.Button();
            this.BtnAppUser_Save = new System.Windows.Forms.Button();
            this.GBoxUsers = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBoxAppUser_ChangePassword = new System.Windows.Forms.CheckBox();
            this.TxtAppUser_ConfirmPassword = new System.Windows.Forms.MaskedTextBox();
            this.TxtAppUser_NewPassword = new System.Windows.Forms.MaskedTextBox();
            this.LabelAppUser_ConfirmPassword = new System.Windows.Forms.Label();
            this.LabelAppUser_NewPassword = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CBoxAppUser_Enabled = new System.Windows.Forms.CheckBox();
            this.TxtAppUser_Password = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAppUser_UserName = new System.Windows.Forms.TextBox();
            this.LabelAppUser_Password = new System.Windows.Forms.Label();
            this.LBoxAppUser_Perfis = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAppUser_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAppUser_Apelido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAppUser_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ToolStripAppUser = new System.Windows.Forms.ToolStrip();
            this.BtnAppUser_NewUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnAppUser_ChangeUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TxtAppUser_Title = new System.Windows.Forms.ToolStripLabel();
            this.ListViewAppUsers = new System.Windows.Forms.ListView();
            this.listUsersImageList = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GBoxRoleAdd = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DGViewPermissions = new System.Windows.Forms.DataGridView();
            this.ColSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColFormCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColActionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtRole_Name = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnRole_NewRole = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.TxtRole_Title = new System.Windows.Forms.ToolStripLabel();
            this.BtnRole_Limpar = new System.Windows.Forms.Button();
            this.BtnRole_Remove = new System.Windows.Forms.Button();
            this.BtnRole_Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ListViewRoles = new System.Windows.Forms.ListView();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GBoxUsers.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ToolStripAppUser.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.GBoxRoleAdd.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewPermissions)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 508);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnAppUser_CleanForm);
            this.tabPage1.Controls.Add(this.BtnAppUser_Remove);
            this.tabPage1.Controls.Add(this.BtnAppUser_Save);
            this.tabPage1.Controls.Add(this.GBoxUsers);
            this.tabPage1.Controls.Add(this.ToolStripAppUser);
            this.tabPage1.Controls.Add(this.ListViewAppUsers);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(844, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuários";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnAppUser_CleanForm
            // 
            this.BtnAppUser_CleanForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAppUser_CleanForm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAppUser_CleanForm.Location = new System.Drawing.Point(692, 440);
            this.BtnAppUser_CleanForm.Name = "BtnAppUser_CleanForm";
            this.BtnAppUser_CleanForm.Size = new System.Drawing.Size(143, 24);
            this.BtnAppUser_CleanForm.TabIndex = 13;
            this.BtnAppUser_CleanForm.Text = "Limpar";
            this.BtnAppUser_CleanForm.UseVisualStyleBackColor = true;
            this.BtnAppUser_CleanForm.Click += new System.EventHandler(this.BtnAppUser_CleanForm_Click);
            // 
            // BtnAppUser_Remove
            // 
            this.BtnAppUser_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAppUser_Remove.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAppUser_Remove.Location = new System.Drawing.Point(541, 441);
            this.BtnAppUser_Remove.Name = "BtnAppUser_Remove";
            this.BtnAppUser_Remove.Size = new System.Drawing.Size(146, 24);
            this.BtnAppUser_Remove.TabIndex = 12;
            this.BtnAppUser_Remove.Text = "Remover Usuario";
            this.BtnAppUser_Remove.UseVisualStyleBackColor = true;
            this.BtnAppUser_Remove.Click += new System.EventHandler(this.BtnAppUser_Remove_Click);
            // 
            // BtnAppUser_Save
            // 
            this.BtnAppUser_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAppUser_Save.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAppUser_Save.Location = new System.Drawing.Point(405, 441);
            this.BtnAppUser_Save.Name = "BtnAppUser_Save";
            this.BtnAppUser_Save.Size = new System.Drawing.Size(130, 24);
            this.BtnAppUser_Save.TabIndex = 11;
            this.BtnAppUser_Save.Text = "Atualizar";
            this.BtnAppUser_Save.UseVisualStyleBackColor = true;
            this.BtnAppUser_Save.Click += new System.EventHandler(this.BtnAppUser_Save_Click);
            // 
            // GBoxUsers
            // 
            this.GBoxUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBoxUsers.Controls.Add(this.groupBox2);
            this.GBoxUsers.Controls.Add(this.LBoxAppUser_Perfis);
            this.GBoxUsers.Controls.Add(this.label4);
            this.GBoxUsers.Controls.Add(this.TxtAppUser_Email);
            this.GBoxUsers.Controls.Add(this.label3);
            this.GBoxUsers.Controls.Add(this.TxtAppUser_Apelido);
            this.GBoxUsers.Controls.Add(this.label2);
            this.GBoxUsers.Controls.Add(this.TxtAppUser_Nome);
            this.GBoxUsers.Controls.Add(this.label1);
            this.GBoxUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoxUsers.Location = new System.Drawing.Point(238, 31);
            this.GBoxUsers.Name = "GBoxUsers";
            this.GBoxUsers.Size = new System.Drawing.Size(597, 401);
            this.GBoxUsers.TabIndex = 10;
            this.GBoxUsers.TabStop = false;
            this.GBoxUsers.Text = "Dados do usuário";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBoxAppUser_ChangePassword);
            this.groupBox2.Controls.Add(this.TxtAppUser_ConfirmPassword);
            this.groupBox2.Controls.Add(this.TxtAppUser_NewPassword);
            this.groupBox2.Controls.Add(this.LabelAppUser_ConfirmPassword);
            this.groupBox2.Controls.Add(this.LabelAppUser_NewPassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CBoxAppUser_Enabled);
            this.groupBox2.Controls.Add(this.TxtAppUser_Password);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtAppUser_UserName);
            this.groupBox2.Controls.Add(this.LabelAppUser_Password);
            this.groupBox2.Location = new System.Drawing.Point(37, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 193);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // CBoxAppUser_ChangePassword
            // 
            this.CBoxAppUser_ChangePassword.AutoSize = true;
            this.CBoxAppUser_ChangePassword.Location = new System.Drawing.Point(387, 88);
            this.CBoxAppUser_ChangePassword.Name = "CBoxAppUser_ChangePassword";
            this.CBoxAppUser_ChangePassword.Size = new System.Drawing.Size(97, 19);
            this.CBoxAppUser_ChangePassword.TabIndex = 20;
            this.CBoxAppUser_ChangePassword.Text = "Alterar Senha";
            this.CBoxAppUser_ChangePassword.UseVisualStyleBackColor = true;
            this.CBoxAppUser_ChangePassword.CheckedChanged += new System.EventHandler(this.CBoxAppUser_ChangePassword_CheckedChanged);
            // 
            // TxtAppUser_ConfirmPassword
            // 
            this.TxtAppUser_ConfirmPassword.Location = new System.Drawing.Point(136, 151);
            this.TxtAppUser_ConfirmPassword.Name = "TxtAppUser_ConfirmPassword";
            this.TxtAppUser_ConfirmPassword.Size = new System.Drawing.Size(234, 23);
            this.TxtAppUser_ConfirmPassword.TabIndex = 19;
            this.TxtAppUser_ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // TxtAppUser_NewPassword
            // 
            this.TxtAppUser_NewPassword.Location = new System.Drawing.Point(136, 119);
            this.TxtAppUser_NewPassword.Name = "TxtAppUser_NewPassword";
            this.TxtAppUser_NewPassword.Size = new System.Drawing.Size(234, 23);
            this.TxtAppUser_NewPassword.TabIndex = 18;
            this.TxtAppUser_NewPassword.UseSystemPasswordChar = true;
            // 
            // LabelAppUser_ConfirmPassword
            // 
            this.LabelAppUser_ConfirmPassword.AutoSize = true;
            this.LabelAppUser_ConfirmPassword.Location = new System.Drawing.Point(29, 154);
            this.LabelAppUser_ConfirmPassword.Name = "LabelAppUser_ConfirmPassword";
            this.LabelAppUser_ConfirmPassword.Size = new System.Drawing.Size(96, 15);
            this.LabelAppUser_ConfirmPassword.TabIndex = 17;
            this.LabelAppUser_ConfirmPassword.Text = "Confirmar Senha";
            // 
            // LabelAppUser_NewPassword
            // 
            this.LabelAppUser_NewPassword.AutoSize = true;
            this.LabelAppUser_NewPassword.Location = new System.Drawing.Point(29, 122);
            this.LabelAppUser_NewPassword.Name = "LabelAppUser_NewPassword";
            this.LabelAppUser_NewPassword.Size = new System.Drawing.Size(71, 15);
            this.LabelAppUser_NewPassword.TabIndex = 16;
            this.LabelAppUser_NewPassword.Text = "Nova Senha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Usuário Activo";
            // 
            // CBoxAppUser_Enabled
            // 
            this.CBoxAppUser_Enabled.AutoSize = true;
            this.CBoxAppUser_Enabled.Location = new System.Drawing.Point(136, 22);
            this.CBoxAppUser_Enabled.Name = "CBoxAppUser_Enabled";
            this.CBoxAppUser_Enabled.Size = new System.Drawing.Size(15, 14);
            this.CBoxAppUser_Enabled.TabIndex = 13;
            this.CBoxAppUser_Enabled.UseVisualStyleBackColor = true;
            // 
            // TxtAppUser_Password
            // 
            this.TxtAppUser_Password.Location = new System.Drawing.Point(136, 85);
            this.TxtAppUser_Password.Name = "TxtAppUser_Password";
            this.TxtAppUser_Password.Size = new System.Drawing.Size(234, 23);
            this.TxtAppUser_Password.TabIndex = 11;
            this.TxtAppUser_Password.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome do usuário";
            // 
            // TxtAppUser_UserName
            // 
            this.TxtAppUser_UserName.Location = new System.Drawing.Point(136, 51);
            this.TxtAppUser_UserName.Name = "TxtAppUser_UserName";
            this.TxtAppUser_UserName.Size = new System.Drawing.Size(235, 23);
            this.TxtAppUser_UserName.TabIndex = 10;
            // 
            // LabelAppUser_Password
            // 
            this.LabelAppUser_Password.AutoSize = true;
            this.LabelAppUser_Password.Location = new System.Drawing.Point(29, 88);
            this.LabelAppUser_Password.Name = "LabelAppUser_Password";
            this.LabelAppUser_Password.Size = new System.Drawing.Size(100, 15);
            this.LabelAppUser_Password.TabIndex = 9;
            this.LabelAppUser_Password.Text = "Senha do Usuário";
            // 
            // LBoxAppUser_Perfis
            // 
            this.LBoxAppUser_Perfis.FormattingEnabled = true;
            this.LBoxAppUser_Perfis.Location = new System.Drawing.Point(78, 95);
            this.LBoxAppUser_Perfis.Name = "LBoxAppUser_Perfis";
            this.LBoxAppUser_Perfis.Size = new System.Drawing.Size(471, 76);
            this.LBoxAppUser_Perfis.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Perfis";
            // 
            // TxtAppUser_Email
            // 
            this.TxtAppUser_Email.Location = new System.Drawing.Point(78, 63);
            this.TxtAppUser_Email.Name = "TxtAppUser_Email";
            this.TxtAppUser_Email.Size = new System.Drawing.Size(471, 23);
            this.TxtAppUser_Email.TabIndex = 5;
            this.TxtAppUser_Email.Text = "@";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // TxtAppUser_Apelido
            // 
            this.TxtAppUser_Apelido.Location = new System.Drawing.Point(340, 34);
            this.TxtAppUser_Apelido.Name = "TxtAppUser_Apelido";
            this.TxtAppUser_Apelido.Size = new System.Drawing.Size(209, 23);
            this.TxtAppUser_Apelido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apelido";
            // 
            // TxtAppUser_Nome
            // 
            this.TxtAppUser_Nome.Location = new System.Drawing.Point(78, 34);
            this.TxtAppUser_Nome.Name = "TxtAppUser_Nome";
            this.TxtAppUser_Nome.Size = new System.Drawing.Size(180, 23);
            this.TxtAppUser_Nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // ToolStripAppUser
            // 
            this.ToolStripAppUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAppUser_NewUser,
            this.toolStripSeparator1,
            this.BtnAppUser_ChangeUser,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.TxtAppUser_Title});
            this.ToolStripAppUser.Location = new System.Drawing.Point(3, 3);
            this.ToolStripAppUser.Name = "ToolStripAppUser";
            this.ToolStripAppUser.Size = new System.Drawing.Size(838, 25);
            this.ToolStripAppUser.TabIndex = 9;
            this.ToolStripAppUser.Text = "toolStrip1";
            // 
            // BtnAppUser_NewUser
            // 
            this.BtnAppUser_NewUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAppUser_NewUser.Image = ((System.Drawing.Image)(resources.GetObject("BtnAppUser_NewUser.Image")));
            this.BtnAppUser_NewUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAppUser_NewUser.Name = "BtnAppUser_NewUser";
            this.BtnAppUser_NewUser.Size = new System.Drawing.Size(99, 22);
            this.BtnAppUser_NewUser.Text = "Novo Usuário";
            this.BtnAppUser_NewUser.Click += new System.EventHandler(this.BtnAppUser_NewUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnAppUser_ChangeUser
            // 
            this.BtnAppUser_ChangeUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAppUser_ChangeUser.Image = ((System.Drawing.Image)(resources.GetObject("BtnAppUser_ChangeUser.Image")));
            this.BtnAppUser_ChangeUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAppUser_ChangeUser.Name = "BtnAppUser_ChangeUser";
            this.BtnAppUser_ChangeUser.Size = new System.Drawing.Size(105, 22);
            this.BtnAppUser_ChangeUser.Text = "Alterar Usuário";
            this.BtnAppUser_ChangeUser.Click += new System.EventHandler(this.BtnAppUser_ChangeUser_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // TxtAppUser_Title
            // 
            this.TxtAppUser_Title.AutoSize = false;
            this.TxtAppUser_Title.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TxtAppUser_Title.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAppUser_Title.ForeColor = System.Drawing.Color.Black;
            this.TxtAppUser_Title.Name = "TxtAppUser_Title";
            this.TxtAppUser_Title.Size = new System.Drawing.Size(580, 22);
            // 
            // ListViewAppUsers
            // 
            this.ListViewAppUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListViewAppUsers.BackgroundImageTiled = true;
            this.ListViewAppUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewAppUsers.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ListViewAppUsers.FullRowSelect = true;
            this.ListViewAppUsers.HideSelection = false;
            this.ListViewAppUsers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.ListViewAppUsers.LargeImageList = this.listUsersImageList;
            this.ListViewAppUsers.Location = new System.Drawing.Point(7, 41);
            this.ListViewAppUsers.MultiSelect = false;
            this.ListViewAppUsers.Name = "ListViewAppUsers";
            this.ListViewAppUsers.Size = new System.Drawing.Size(225, 430);
            this.ListViewAppUsers.TabIndex = 8;
            this.ListViewAppUsers.UseCompatibleStateImageBehavior = false;
            this.ListViewAppUsers.View = System.Windows.Forms.View.Tile;
            this.ListViewAppUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewAppUsers_MouseDoubleClick);
            // 
            // listUsersImageList
            // 
            this.listUsersImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listUsersImageList.ImageStream")));
            this.listUsersImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.listUsersImageList.Images.SetKeyName(0, "users-icon.png");
            this.listUsersImageList.Images.SetKeyName(1, "globe.png");
            this.listUsersImageList.Images.SetKeyName(2, "users-icon2.png");
            this.listUsersImageList.Images.SetKeyName(3, "role_icon2.png");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GBoxRoleAdd);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Controls.Add(this.BtnRole_Limpar);
            this.tabPage2.Controls.Add(this.BtnRole_Remove);
            this.tabPage2.Controls.Add(this.BtnRole_Save);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.ListViewRoles);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(844, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Perfis e Permissões";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GBoxRoleAdd
            // 
            this.GBoxRoleAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBoxRoleAdd.Controls.Add(this.groupBox4);
            this.GBoxRoleAdd.Controls.Add(this.groupBox3);
            this.GBoxRoleAdd.Location = new System.Drawing.Point(237, 57);
            this.GBoxRoleAdd.Name = "GBoxRoleAdd";
            this.GBoxRoleAdd.Size = new System.Drawing.Size(601, 374);
            this.GBoxRoleAdd.TabIndex = 21;
            this.GBoxRoleAdd.TabStop = false;
            this.GBoxRoleAdd.Text = "Dados do perfil de usuário";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.DGViewPermissions);
            this.groupBox4.Location = new System.Drawing.Point(10, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(582, 280);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Permissões";
            // 
            // DGViewPermissions
            // 
            this.DGViewPermissions.AllowUserToAddRows = false;
            this.DGViewPermissions.AllowUserToDeleteRows = false;
            this.DGViewPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGViewPermissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGViewPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGViewPermissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelect,
            this.ColFormCode,
            this.ColActionCode,
            this.ColName});
            this.DGViewPermissions.EnableHeadersVisualStyles = false;
            this.DGViewPermissions.Location = new System.Drawing.Point(6, 22);
            this.DGViewPermissions.Name = "DGViewPermissions";
            this.DGViewPermissions.RowHeadersVisible = false;
            this.DGViewPermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGViewPermissions.Size = new System.Drawing.Size(570, 252);
            this.DGViewPermissions.TabIndex = 21;
            // 
            // ColSelect
            // 
            this.ColSelect.FalseValue = "false";
            this.ColSelect.HeaderText = "";
            this.ColSelect.Name = "ColSelect";
            this.ColSelect.TrueValue = "true";
            this.ColSelect.Width = 30;
            // 
            // ColFormCode
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColFormCode.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColFormCode.HeaderText = "Código";
            this.ColFormCode.Name = "ColFormCode";
            // 
            // ColActionCode
            // 
            this.ColActionCode.HeaderText = "Acção";
            this.ColActionCode.Name = "ColActionCode";
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Nome";
            this.ColName.Name = "ColName";
            this.ColName.Width = 340;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TxtRole_Name);
            this.groupBox3.Location = new System.Drawing.Point(10, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 60);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nome do perfil";
            // 
            // TxtRole_Name
            // 
            this.TxtRole_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRole_Name.Location = new System.Drawing.Point(114, 22);
            this.TxtRole_Name.Name = "TxtRole_Name";
            this.TxtRole_Name.Size = new System.Drawing.Size(296, 23);
            this.TxtRole_Name.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnRole_NewRole,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.TxtRole_Title});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(838, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnRole_NewRole
            // 
            this.BtnRole_NewRole.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRole_NewRole.Image = ((System.Drawing.Image)(resources.GetObject("BtnRole_NewRole.Image")));
            this.BtnRole_NewRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRole_NewRole.Name = "BtnRole_NewRole";
            this.BtnRole_NewRole.Size = new System.Drawing.Size(86, 22);
            this.BtnRole_NewRole.Text = "Novo Perfil";
            this.BtnRole_NewRole.Click += new System.EventHandler(this.BtnRole_NewRole_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // TxtRole_Title
            // 
            this.TxtRole_Title.AutoSize = false;
            this.TxtRole_Title.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TxtRole_Title.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRole_Title.ForeColor = System.Drawing.Color.Black;
            this.TxtRole_Title.Name = "TxtRole_Title";
            this.TxtRole_Title.Size = new System.Drawing.Size(695, 22);
            // 
            // BtnRole_Limpar
            // 
            this.BtnRole_Limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRole_Limpar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRole_Limpar.Location = new System.Drawing.Point(681, 437);
            this.BtnRole_Limpar.Name = "BtnRole_Limpar";
            this.BtnRole_Limpar.Size = new System.Drawing.Size(143, 24);
            this.BtnRole_Limpar.TabIndex = 18;
            this.BtnRole_Limpar.Text = "Limpar";
            this.BtnRole_Limpar.UseVisualStyleBackColor = true;
            this.BtnRole_Limpar.Click += new System.EventHandler(this.BtnRole_Limpar_Click);
            // 
            // BtnRole_Remove
            // 
            this.BtnRole_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRole_Remove.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRole_Remove.Location = new System.Drawing.Point(530, 438);
            this.BtnRole_Remove.Name = "BtnRole_Remove";
            this.BtnRole_Remove.Size = new System.Drawing.Size(146, 24);
            this.BtnRole_Remove.TabIndex = 17;
            this.BtnRole_Remove.Text = "Remover Perfil";
            this.BtnRole_Remove.UseVisualStyleBackColor = true;
            this.BtnRole_Remove.Click += new System.EventHandler(this.BtnRole_Remove_Click);
            // 
            // BtnRole_Save
            // 
            this.BtnRole_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRole_Save.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRole_Save.Location = new System.Drawing.Point(394, 438);
            this.BtnRole_Save.Name = "BtnRole_Save";
            this.BtnRole_Save.Size = new System.Drawing.Size(130, 24);
            this.BtnRole_Save.TabIndex = 16;
            this.BtnRole_Save.Text = "Atualizar";
            this.BtnRole_Save.UseVisualStyleBackColor = true;
            this.BtnRole_Save.Click += new System.EventHandler(this.BtnRole_Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Perfis de usuários";
            // 
            // ListViewRoles
            // 
            this.ListViewRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListViewRoles.BackgroundImageTiled = true;
            this.ListViewRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewRoles.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ListViewRoles.FullRowSelect = true;
            this.ListViewRoles.HideSelection = false;
            this.ListViewRoles.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.ListViewRoles.LargeImageList = this.listUsersImageList;
            this.ListViewRoles.Location = new System.Drawing.Point(20, 65);
            this.ListViewRoles.MultiSelect = false;
            this.ListViewRoles.Name = "ListViewRoles";
            this.ListViewRoles.Size = new System.Drawing.Size(212, 366);
            this.ListViewRoles.TabIndex = 9;
            this.ListViewRoles.UseCompatibleStateImageBehavior = false;
            this.ListViewRoles.View = System.Windows.Forms.View.Tile;
            this.ListViewRoles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewRoles_MouseDoubleClick);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(667, 539);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(174, 25);
            this.Btn_Close.TabIndex = 1;
            this.Btn_Close.Text = "Fechar";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 570);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(868, 609);
            this.Name = "UserManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Usuarios do Sistema";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserManagment_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.UserManagment_VisibleChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GBoxUsers.ResumeLayout(false);
            this.GBoxUsers.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ToolStripAppUser.ResumeLayout(false);
            this.ToolStripAppUser.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.GBoxRoleAdd.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewPermissions)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.ListView ListViewAppUsers;
        private System.Windows.Forms.ImageList listUsersImageList;
        private System.Windows.Forms.ToolStrip ToolStripAppUser;
        private System.Windows.Forms.ToolStripButton BtnAppUser_NewUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox GBoxUsers;
        private System.Windows.Forms.TextBox TxtAppUser_Apelido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAppUser_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAppUser_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox LBoxAppUser_Perfis;
        private System.Windows.Forms.MaskedTextBox TxtAppUser_Password;
        private System.Windows.Forms.TextBox TxtAppUser_UserName;
        private System.Windows.Forms.Label LabelAppUser_Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CBoxAppUser_Enabled;
        private System.Windows.Forms.MaskedTextBox TxtAppUser_NewPassword;
        private System.Windows.Forms.Label LabelAppUser_ConfirmPassword;
        private System.Windows.Forms.Label LabelAppUser_NewPassword;
        private System.Windows.Forms.MaskedTextBox TxtAppUser_ConfirmPassword;
        private System.Windows.Forms.ToolStripButton BtnAppUser_ChangeUser;
        private System.Windows.Forms.Button BtnAppUser_Save;
        internal System.Windows.Forms.ListView ListViewRoles;
        private System.Windows.Forms.Button BtnAppUser_Remove;
        private System.Windows.Forms.Button BtnAppUser_CleanForm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.TextBox TxtRole_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnRole_Limpar;
        private System.Windows.Forms.Button BtnRole_Remove;
        private System.Windows.Forms.Button BtnRole_Save;
        private System.Windows.Forms.ToolStripLabel TxtAppUser_Title;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnRole_NewRole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel TxtRole_Title;
        private System.Windows.Forms.CheckBox CBoxAppUser_ChangePassword;
        private System.Windows.Forms.GroupBox GBoxRoleAdd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGViewPermissions;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFormCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColActionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
    }
}