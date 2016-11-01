namespace mz.betainteractive.sigeas.Views.AccessControl {
    partial class UserClocksViewer {
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "B000-001"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "MICHELE"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Device #1"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "DEDO (I.D)"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "29-12-2011 10:19"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Saida"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Entrada", System.Drawing.SystemColors.WindowText, System.Drawing.Color.Aqua, new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "OK")}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "15",
            "RAYMOND ROLAND",
            "Device #2",
            "CARTÃO",
            "28-10-2011 10:20",
            "Entrada",
            "",
            "Invalido"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Lime, null);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBoxCategorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxDepartamentos = new System.Windows.Forms.ComboBox();
            this.CBoxFuncionarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CBoxMonthWorks = new System.Windows.Forms.ComboBox();
            this.DtpToTime = new System.Windows.Forms.DateTimePicker();
            this.DtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpFromTime = new System.Windows.Forms.DateTimePicker();
            this.DtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnInsertClock = new System.Windows.Forms.Button();
            this.BtnSearchAndCorrect = new System.Windows.Forms.Button();
            this.BtnDownloadUserClocks = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelDeviceConnected = new System.Windows.Forms.Label();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CBoxDevices = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LViewUserClocks = new System.Windows.Forms.ListView();
            this.ColNumbering = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDeviceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColVerifyMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColCorrectState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColClockValid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripUserClock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStripUserClock.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CBoxCategorias);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CBoxDepartamentos);
            this.groupBox2.Controls.Add(this.CBoxFuncionarios);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(11, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 109);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionários";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Categoria";
            // 
            // CBoxCategorias
            // 
            this.CBoxCategorias.FormattingEnabled = true;
            this.CBoxCategorias.Location = new System.Drawing.Point(115, 50);
            this.CBoxCategorias.Name = "CBoxCategorias";
            this.CBoxCategorias.Size = new System.Drawing.Size(213, 21);
            this.CBoxCategorias.TabIndex = 7;
            this.CBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.CBoxCategorias_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departamento";
            // 
            // CBoxDepartamentos
            // 
            this.CBoxDepartamentos.FormattingEnabled = true;
            this.CBoxDepartamentos.Location = new System.Drawing.Point(115, 22);
            this.CBoxDepartamentos.Name = "CBoxDepartamentos";
            this.CBoxDepartamentos.Size = new System.Drawing.Size(213, 21);
            this.CBoxDepartamentos.TabIndex = 4;
            this.CBoxDepartamentos.SelectedIndexChanged += new System.EventHandler(this.CBoxDepartamentos_SelectedIndexChanged);
            // 
            // CBoxFuncionarios
            // 
            this.CBoxFuncionarios.FormattingEnabled = true;
            this.CBoxFuncionarios.Location = new System.Drawing.Point(115, 78);
            this.CBoxFuncionarios.Name = "CBoxFuncionarios";
            this.CBoxFuncionarios.Size = new System.Drawing.Size(213, 21);
            this.CBoxFuncionarios.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funcionário";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CBoxMonthWorks);
            this.groupBox1.Controls.Add(this.DtpToTime);
            this.groupBox1.Controls.Add(this.DtpToDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DtpFromTime);
            this.groupBox1.Controls.Add(this.DtpFromDate);
            this.groupBox1.Location = new System.Drawing.Point(375, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 109);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodo a pesquisar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mês";
            // 
            // CBoxMonthWorks
            // 
            this.CBoxMonthWorks.FormattingEnabled = true;
            this.CBoxMonthWorks.Location = new System.Drawing.Point(60, 20);
            this.CBoxMonthWorks.Name = "CBoxMonthWorks";
            this.CBoxMonthWorks.Size = new System.Drawing.Size(169, 21);
            this.CBoxMonthWorks.TabIndex = 10;
            this.CBoxMonthWorks.SelectedIndexChanged += new System.EventHandler(this.CBoxMonthWorks_SelectedIndexChanged);
            // 
            // DtpToTime
            // 
            this.DtpToTime.Enabled = false;
            this.DtpToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpToTime.Location = new System.Drawing.Point(157, 77);
            this.DtpToTime.Name = "DtpToTime";
            this.DtpToTime.ShowUpDown = true;
            this.DtpToTime.Size = new System.Drawing.Size(70, 22);
            this.DtpToTime.TabIndex = 9;
            this.DtpToTime.Value = new System.DateTime(2012, 9, 8, 23, 59, 0, 0);
            // 
            // DtpToDate
            // 
            this.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpToDate.Location = new System.Drawing.Point(60, 77);
            this.DtpToDate.Name = "DtpToDate";
            this.DtpToDate.Size = new System.Drawing.Size(91, 22);
            this.DtpToDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Até";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "De";
            // 
            // DtpFromTime
            // 
            this.DtpFromTime.Enabled = false;
            this.DtpFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpFromTime.Location = new System.Drawing.Point(157, 50);
            this.DtpFromTime.Name = "DtpFromTime";
            this.DtpFromTime.ShowUpDown = true;
            this.DtpFromTime.Size = new System.Drawing.Size(70, 22);
            this.DtpFromTime.TabIndex = 7;
            this.DtpFromTime.Value = new System.DateTime(2012, 9, 8, 0, 0, 0, 0);
            // 
            // DtpFromDate
            // 
            this.DtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFromDate.Location = new System.Drawing.Point(60, 50);
            this.DtpFromDate.Name = "DtpFromDate";
            this.DtpFromDate.Size = new System.Drawing.Size(91, 22);
            this.DtpFromDate.TabIndex = 6;
            this.DtpFromDate.Value = new System.DateTime(2016, 6, 22, 0, 0, 0, 0);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(37, 17);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(169, 24);
            this.BtnPesquisar.TabIndex = 10;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnInsertClock);
            this.groupBox3.Controls.Add(this.BtnSearchAndCorrect);
            this.groupBox3.Controls.Add(this.BtnPesquisar);
            this.groupBox3.Location = new System.Drawing.Point(655, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 109);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // BtnInsertClock
            // 
            this.BtnInsertClock.Location = new System.Drawing.Point(37, 75);
            this.BtnInsertClock.Name = "BtnInsertClock";
            this.BtnInsertClock.Size = new System.Drawing.Size(169, 24);
            this.BtnInsertClock.TabIndex = 12;
            this.BtnInsertClock.Text = "Inserir Registo E/S";
            this.BtnInsertClock.UseVisualStyleBackColor = true;
            this.BtnInsertClock.Click += new System.EventHandler(this.BtnInsertClock_Click);
            // 
            // BtnSearchAndCorrect
            // 
            this.BtnSearchAndCorrect.Location = new System.Drawing.Point(37, 46);
            this.BtnSearchAndCorrect.Name = "BtnSearchAndCorrect";
            this.BtnSearchAndCorrect.Size = new System.Drawing.Size(169, 24);
            this.BtnSearchAndCorrect.TabIndex = 11;
            this.BtnSearchAndCorrect.Text = "Pesquisar e Corrigir E/S";
            this.BtnSearchAndCorrect.UseVisualStyleBackColor = true;
            this.BtnSearchAndCorrect.Click += new System.EventHandler(this.BtnSearchAndCorrect_Click);
            // 
            // BtnDownloadUserClocks
            // 
            this.BtnDownloadUserClocks.Enabled = false;
            this.BtnDownloadUserClocks.Location = new System.Drawing.Point(635, 24);
            this.BtnDownloadUserClocks.Name = "BtnDownloadUserClocks";
            this.BtnDownloadUserClocks.Size = new System.Drawing.Size(244, 27);
            this.BtnDownloadUserClocks.TabIndex = 3;
            this.BtnDownloadUserClocks.Text = "Descarregar registos de Entrada/Saida";
            this.BtnDownloadUserClocks.UseVisualStyleBackColor = true;
            this.BtnDownloadUserClocks.Click += new System.EventHandler(this.BtnDownloadUserClocks_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.BtnDownloadUserClocks);
            this.groupBox4.Controls.Add(this.BtnConnect);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.CBoxDevices);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(7, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(911, 67);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Descarregar Informação nos biométricos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LabelDeviceConnected);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(481, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 26);
            this.panel1.TabIndex = 32;
            // 
            // LabelDeviceConnected
            // 
            this.LabelDeviceConnected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDeviceConnected.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeviceConnected.ForeColor = System.Drawing.Color.BlueViolet;
            this.LabelDeviceConnected.Location = new System.Drawing.Point(0, 0);
            this.LabelDeviceConnected.Name = "LabelDeviceConnected";
            this.LabelDeviceConnected.Size = new System.Drawing.Size(119, 22);
            this.LabelDeviceConnected.TabIndex = 0;
            this.LabelDeviceConnected.Text = "Desconectado";
            this.LabelDeviceConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Enabled = false;
            this.BtnConnect.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnect.Location = new System.Drawing.Point(333, 25);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(142, 27);
            this.BtnConnect.TabIndex = 2;
            this.BtnConnect.Text = "Conectar Dispositivo";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Biométrico";
            // 
            // CBoxDevices
            // 
            this.CBoxDevices.FormattingEnabled = true;
            this.CBoxDevices.ItemHeight = 13;
            this.CBoxDevices.Location = new System.Drawing.Point(84, 28);
            this.CBoxDevices.Name = "CBoxDevices";
            this.CBoxDevices.Size = new System.Drawing.Size(231, 21);
            this.CBoxDevices.TabIndex = 1;
            this.CBoxDevices.SelectedIndexChanged += new System.EventHandler(this.CBoxDevices_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Location = new System.Drawing.Point(7, 130);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(911, 130);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // LViewUserClocks
            // 
            this.LViewUserClocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LViewUserClocks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColNumbering,
            this.ColUserId,
            this.ColName,
            this.ColDeviceName,
            this.ColVerifyMode,
            this.ColDate,
            this.ColState,
            this.ColCorrectState,
            this.ColClockValid});
            this.LViewUserClocks.FullRowSelect = true;
            this.LViewUserClocks.GridLines = true;
            this.LViewUserClocks.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.LViewUserClocks.Location = new System.Drawing.Point(11, 22);
            this.LViewUserClocks.MultiSelect = false;
            this.LViewUserClocks.Name = "LViewUserClocks";
            this.LViewUserClocks.Size = new System.Drawing.Size(891, 266);
            this.LViewUserClocks.TabIndex = 13;
            this.LViewUserClocks.UseCompatibleStateImageBehavior = false;
            this.LViewUserClocks.View = System.Windows.Forms.View.Details;
            this.LViewUserClocks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LViewUserClocks_MouseDoubleClick);
            // 
            // ColNumbering
            // 
            this.ColNumbering.Text = "";
            this.ColNumbering.Width = 37;
            // 
            // ColUserId
            // 
            this.ColUserId.Text = "Código";
            this.ColUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColUserId.Width = 70;
            // 
            // ColName
            // 
            this.ColName.Text = "Nome";
            this.ColName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColName.Width = 200;
            // 
            // ColDeviceName
            // 
            this.ColDeviceName.Text = "Biométrico";
            this.ColDeviceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColDeviceName.Width = 106;
            // 
            // ColVerifyMode
            // 
            this.ColVerifyMode.Text = "Verificação p/";
            this.ColVerifyMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColVerifyMode.Width = 97;
            // 
            // ColDate
            // 
            this.ColDate.Text = "Data";
            this.ColDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColDate.Width = 119;
            // 
            // ColState
            // 
            this.ColState.Text = "Estado";
            this.ColState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColState.Width = 82;
            // 
            // ColCorrectState
            // 
            this.ColCorrectState.Text = "Novo Estado";
            this.ColCorrectState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColCorrectState.Width = 89;
            // 
            // ColClockValid
            // 
            this.ColClockValid.Text = "Valido";
            this.ColClockValid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStripUserClock
            // 
            this.menuStripUserClock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarToolStripMenuItem,
            this.toolStripSeparator1,
            this.cancelarToolStripMenuItem});
            this.menuStripUserClock.Name = "menuStripUserClock";
            this.menuStripUserClock.Size = new System.Drawing.Size(152, 54);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.alterarToolStripMenuItem.Text = "Alterar Registo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Location = new System.Drawing.Point(768, 573);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(141, 23);
            this.BtnClose.TabIndex = 26;
            this.BtnClose.Text = "Fechar";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.LViewUserClocks);
            this.groupBox6.Location = new System.Drawing.Point(7, 264);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(911, 303);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Registos de entradas e saidas";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Location = new System.Drawing.Point(228, 77);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(460, 48);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Dicas";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(62, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(376, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Conecte todos os dispositivos biométricos no sistema para obter todos \r\nos regist" +
    "os de entradas e saidas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserClocksViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(921, 600);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BtnClose);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "UserClocksViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registos de Picagens de Ponto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserClocksViewer_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.UserClocksViewer_VisibleChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.menuStripUserClock.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxDepartamentos;
        private System.Windows.Forms.ComboBox CBoxFuncionarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DtpFromTime;
        private System.Windows.Forms.DateTimePicker DtpFromDate;
        private System.Windows.Forms.DateTimePicker DtpToTime;
        private System.Windows.Forms.DateTimePicker DtpToDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnDownloadUserClocks;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView LViewUserClocks;
        private System.Windows.Forms.ColumnHeader ColUserId;
        private System.Windows.Forms.ColumnHeader ColName;
        private System.Windows.Forms.ColumnHeader ColDeviceName;
        private System.Windows.Forms.ColumnHeader ColDate;
        private System.Windows.Forms.ColumnHeader ColCorrectState;
        private System.Windows.Forms.ColumnHeader ColState;
        private System.Windows.Forms.ColumnHeader ColClockValid;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSearchAndCorrect;
        private System.Windows.Forms.ColumnHeader ColNumbering;
        private System.Windows.Forms.ContextMenuStrip menuStripUserClock;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button BtnInsertClock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelDeviceConnected;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBoxDevices;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBoxCategorias;
        private System.Windows.Forms.ColumnHeader ColVerifyMode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBoxMonthWorks;
    }
}