namespace mz.betainteractive.sigeas.Views.AccessControl {
    partial class FrmRegistosBiometrico {
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "99999",
            "MICHELE",
            "DEDO",
            "29-12-2011 10:19",
            "Saida",
            "",
            "OK"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "15",
            "MACHADO",
            "FINGERPRINT",
            "28-10-2011 10:20",
            "Entrada",
            "Entrada",
            "Invalido"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Lime, null);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpToTime = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFromTime = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btInsertClock = new System.Windows.Forms.Button();
            this.btSearchAndCorrect = new System.Windows.Forms.Button();
            this.btDownloadDevToDB = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listLogData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVerifyMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClockState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNewClockState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClockValid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripUserClock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btFechar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bgwDownloadAll = new System.ComponentModel.BackgroundWorker();
            this.bgwSearchClocks = new System.ComponentModel.BackgroundWorker();
            this.bgwCorrectData = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStripUserClock.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboDepartamento);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboFuncionario);
            this.groupBox2.Controls.Add(this.cboCategoria);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 109);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionários";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departamento";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(101, 18);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(146, 21);
            this.cboDepartamento.TabIndex = 0;
            this.cboDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Categoria";
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(101, 72);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(146, 21);
            this.cboFuncionario.TabIndex = 1;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(101, 45);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(146, 21);
            this.cboCategoria.TabIndex = 12;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funcionario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpToTime);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFromTime);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Location = new System.Drawing.Point(290, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 109);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodo a pesquisar";
            // 
            // dtpToTime
            // 
            this.dtpToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpToTime.Location = new System.Drawing.Point(138, 58);
            this.dtpToTime.Name = "dtpToTime";
            this.dtpToTime.ShowUpDown = true;
            this.dtpToTime.Size = new System.Drawing.Size(70, 22);
            this.dtpToTime.TabIndex = 5;
            this.dtpToTime.Value = new System.DateTime(2012, 9, 8, 23, 59, 0, 0);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(41, 58);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(91, 22);
            this.dtpToDate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Até";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "De";
            // 
            // dtpFromTime
            // 
            this.dtpFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFromTime.Location = new System.Drawing.Point(138, 31);
            this.dtpFromTime.Name = "dtpFromTime";
            this.dtpFromTime.ShowUpDown = true;
            this.dtpFromTime.Size = new System.Drawing.Size(70, 22);
            this.dtpFromTime.TabIndex = 1;
            this.dtpFromTime.Value = new System.DateTime(2012, 9, 8, 0, 0, 0, 0);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(41, 31);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(91, 22);
            this.dtpFromDate.TabIndex = 0;
            this.dtpFromDate.Value = new System.DateTime(2012, 1, 1, 10, 7, 0, 0);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(25, 17);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(169, 23);
            this.btPesquisar.TabIndex = 20;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btInsertClock);
            this.groupBox3.Controls.Add(this.btSearchAndCorrect);
            this.groupBox3.Controls.Add(this.btPesquisar);
            this.groupBox3.Location = new System.Drawing.Point(520, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 109);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // btInsertClock
            // 
            this.btInsertClock.Location = new System.Drawing.Point(25, 75);
            this.btInsertClock.Name = "btInsertClock";
            this.btInsertClock.Size = new System.Drawing.Size(169, 23);
            this.btInsertClock.TabIndex = 22;
            this.btInsertClock.Text = "Inserir Registo E/S";
            this.btInsertClock.UseVisualStyleBackColor = true;
            this.btInsertClock.Click += new System.EventHandler(this.btInsertClock_Click);
            // 
            // btSearchAndCorrect
            // 
            this.btSearchAndCorrect.Location = new System.Drawing.Point(25, 46);
            this.btSearchAndCorrect.Name = "btSearchAndCorrect";
            this.btSearchAndCorrect.Size = new System.Drawing.Size(169, 23);
            this.btSearchAndCorrect.TabIndex = 21;
            this.btSearchAndCorrect.Text = "Pesquisar e Corrigir E/S";
            this.btSearchAndCorrect.UseVisualStyleBackColor = true;
            this.btSearchAndCorrect.Click += new System.EventHandler(this.btSearchAndCorrect_Click);
            // 
            // btDownloadDevToDB
            // 
            this.btDownloadDevToDB.Location = new System.Drawing.Point(14, 19);
            this.btDownloadDevToDB.Name = "btDownloadDevToDB";
            this.btDownloadDevToDB.Size = new System.Drawing.Size(227, 23);
            this.btDownloadDevToDB.TabIndex = 22;
            this.btDownloadDevToDB.Text = "Descarregar registos de Entrada/Saida";
            this.btDownloadDevToDB.UseVisualStyleBackColor = true;
            this.btDownloadDevToDB.Click += new System.EventHandler(this.btDownloadDevToDB_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btDownloadDevToDB);
            this.groupBox4.Location = new System.Drawing.Point(7, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 51);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informação no biométrico";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Location = new System.Drawing.Point(-6, 55);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(787, 130);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            // 
            // listLogData
            // 
            this.listLogData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colUserId,
            this.colName,
            this.colVerifyMode,
            this.colDate,
            this.colClockState,
            this.colNewClockState,
            this.colClockValid});
            this.listLogData.ContextMenuStrip = this.menuStripUserClock;
            this.listLogData.FullRowSelect = true;
            this.listLogData.GridLines = true;
            this.listLogData.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listLogData.Location = new System.Drawing.Point(6, 19);
            this.listLogData.MultiSelect = false;
            this.listLogData.Name = "listLogData";
            this.listLogData.Size = new System.Drawing.Size(715, 208);
            this.listLogData.TabIndex = 25;
            this.listLogData.UseCompatibleStateImageBehavior = false;
            this.listLogData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 37;
            // 
            // colUserId
            // 
            this.colUserId.Text = "Cód.";
            this.colUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colUserId.Width = 43;
            // 
            // colName
            // 
            this.colName.Text = "Nome";
            this.colName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colName.Width = 150;
            // 
            // colVerifyMode
            // 
            this.colVerifyMode.Text = "Modo de verificação";
            this.colVerifyMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colVerifyMode.Width = 114;
            // 
            // colDate
            // 
            this.colDate.Text = "Data";
            this.colDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDate.Width = 119;
            // 
            // colClockState
            // 
            this.colClockState.Text = "Estado";
            this.colClockState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colClockState.Width = 80;
            // 
            // colNewClockState
            // 
            this.colNewClockState.Text = "Novo Estado";
            this.colNewClockState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNewClockState.Width = 75;
            // 
            // colClockValid
            // 
            this.colClockValid.Text = "Valido";
            this.colClockValid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStripUserClock
            // 
            this.menuStripUserClock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarToolStripMenuItem,
            this.toolStripSeparator1,
            this.cancelarToolStripMenuItem});
            this.menuStripUserClock.Name = "menuStripUserClock";
            this.menuStripUserClock.Size = new System.Drawing.Size(152, 54);
            this.menuStripUserClock.Opening += new System.ComponentModel.CancelEventHandler(this.menuStripUserClock_Opening);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.alterarToolStripMenuItem.Text = "Alterar Registo";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
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
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(634, 441);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(94, 23);
            this.btFechar.TabIndex = 26;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listLogData);
            this.groupBox6.Location = new System.Drawing.Point(7, 191);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(727, 240);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Registos de entradas e saidas";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Location = new System.Drawing.Point(274, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(460, 48);
            this.groupBox7.TabIndex = 28;
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
            // bgwDownloadAll
            // 
            this.bgwDownloadAll.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDownloadAll_DoWork);
            this.bgwDownloadAll.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDownloadAll_RunWorkerCompleted);
            // 
            // bgwSearchClocks
            // 
            this.bgwSearchClocks.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSearchClocks_DoWork);
            this.bgwSearchClocks.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSearchClocks_RunWorkerCompleted);
            // 
            // bgwCorrectData
            // 
            this.bgwCorrectData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCorrectData_DoWork);
            this.bgwCorrectData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCorrectData_RunWorkerCompleted);
            // 
            // FrmRegistosBiometrico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 476);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmRegistosBiometrico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registos Biométricos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRegistosBiometrico_FormClosing);
            this.Load += new System.EventHandler(this.FrmRegistosBiometrico_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFromTime;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToTime;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btDownloadDevToDB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView listLogData;
        private System.Windows.Forms.ColumnHeader colUserId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colVerifyMode;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colClockState;
        private System.Windows.Forms.ColumnHeader colNewClockState;
        private System.Windows.Forms.ColumnHeader colClockValid;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker bgwDownloadAll;
        private System.ComponentModel.BackgroundWorker bgwSearchClocks;
        private System.ComponentModel.BackgroundWorker bgwCorrectData;
        private System.Windows.Forms.Button btSearchAndCorrect;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ContextMenuStrip menuStripUserClock;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btInsertClock;
    }
}