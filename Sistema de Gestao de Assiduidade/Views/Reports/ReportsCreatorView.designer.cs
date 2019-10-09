namespace mz.betainteractive.sigeas.Views.Reports {
    partial class ReportsCreatorView {
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxDepartamentos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBoxFuncionarios = new System.Windows.Forms.ComboBox();
            this.CBoxCategorias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btExportReport = new System.Windows.Forms.Button();
            this.btCleanFilters = new System.Windows.Forms.Button();
            this.btCreateReport = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboReports = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMonthWorks = new System.Windows.Forms.ComboBox();
            this.MenuStripDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verRegistosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registarPedidoDeDispensaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.crptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.MenuStripDGV.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CBoxDepartamentos);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CBoxFuncionarios);
            this.groupBox2.Controls.Add(this.CBoxCategorias);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(508, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 135);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departamento";
            // 
            // CBoxDepartamentos
            // 
            this.CBoxDepartamentos.FormattingEnabled = true;
            this.CBoxDepartamentos.Location = new System.Drawing.Point(122, 25);
            this.CBoxDepartamentos.Name = "CBoxDepartamentos";
            this.CBoxDepartamentos.Size = new System.Drawing.Size(223, 23);
            this.CBoxDepartamentos.TabIndex = 0;
            this.CBoxDepartamentos.SelectedIndexChanged += new System.EventHandler(this.CBoxDepartamentos_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Categoria";
            // 
            // CBoxFuncionarios
            // 
            this.CBoxFuncionarios.FormattingEnabled = true;
            this.CBoxFuncionarios.Location = new System.Drawing.Point(122, 87);
            this.CBoxFuncionarios.Name = "CBoxFuncionarios";
            this.CBoxFuncionarios.Size = new System.Drawing.Size(223, 23);
            this.CBoxFuncionarios.TabIndex = 1;
            // 
            // CBoxCategorias
            // 
            this.CBoxCategorias.FormattingEnabled = true;
            this.CBoxCategorias.Location = new System.Drawing.Point(122, 56);
            this.CBoxCategorias.Name = "CBoxCategorias";
            this.CBoxCategorias.Size = new System.Drawing.Size(223, 23);
            this.CBoxCategorias.TabIndex = 12;
            this.CBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.CBoxCategorias_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funcionario";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(7, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 156);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btExportReport);
            this.groupBox5.Controls.Add(this.btCleanFilters);
            this.groupBox5.Controls.Add(this.btCreateReport);
            this.groupBox5.Location = new System.Drawing.Point(889, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(208, 135);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            // 
            // btExportReport
            // 
            this.btExportReport.Location = new System.Drawing.Point(25, 91);
            this.btExportReport.Name = "btExportReport";
            this.btExportReport.Size = new System.Drawing.Size(158, 23);
            this.btExportReport.TabIndex = 28;
            this.btExportReport.Text = "Exportar Relatório";
            this.btExportReport.UseVisualStyleBackColor = true;
            this.btExportReport.Click += new System.EventHandler(this.btExportReport_Click);
            // 
            // btCleanFilters
            // 
            this.btCleanFilters.Location = new System.Drawing.Point(25, 59);
            this.btCleanFilters.Name = "btCleanFilters";
            this.btCleanFilters.Size = new System.Drawing.Size(158, 23);
            this.btCleanFilters.TabIndex = 27;
            this.btCleanFilters.Text = "Limpar Filtros";
            this.btCleanFilters.UseVisualStyleBackColor = true;
            this.btCleanFilters.Click += new System.EventHandler(this.btCleanFilters_Click);
            // 
            // btCreateReport
            // 
            this.btCreateReport.Location = new System.Drawing.Point(25, 28);
            this.btCreateReport.Name = "btCreateReport";
            this.btCreateReport.Size = new System.Drawing.Size(158, 23);
            this.btCreateReport.TabIndex = 26;
            this.btCreateReport.Text = "Gerar Relatório";
            this.btCreateReport.UseVisualStyleBackColor = true;
            this.btCreateReport.Click += new System.EventHandler(this.btCreateReport_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtToDate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtFromDate);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cboReports);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cboMonthWorks);
            this.groupBox3.Location = new System.Drawing.Point(10, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 135);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Relatórios";
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(365, 88);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.ReadOnly = true;
            this.txtToDate.Size = new System.Drawing.Size(100, 23);
            this.txtToDate.TabIndex = 24;
            this.txtToDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "De";
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(229, 88);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.ReadOnly = true;
            this.txtFromDate.Size = new System.Drawing.Size(100, 23);
            this.txtFromDate.TabIndex = 23;
            this.txtFromDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Até";
            // 
            // cboReports
            // 
            this.cboReports.FormattingEnabled = true;
            this.cboReports.Items.AddRange(new object[] {
            "Assiduidade por Funcionario no Mês",
            "Assiduidade Mensal por Departamentos",
            "Assiduidade Mensal por Categorias",
            "Estatisticas de Assiduidade Geral",
            "Estatisticas de Assiduidade por Departamentos",
            "Estatisticas de Assiduidade por Categorias"});
            this.cboReports.Location = new System.Drawing.Point(25, 37);
            this.cboReports.Name = "cboReports";
            this.cboReports.Size = new System.Drawing.Size(440, 23);
            this.cboReports.TabIndex = 15;
            this.cboReports.SelectedIndexChanged += new System.EventHandler(this.cboReports_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Relatório do Mês";
            // 
            // cboMonthWorks
            // 
            this.cboMonthWorks.FormattingEnabled = true;
            this.cboMonthWorks.Location = new System.Drawing.Point(25, 88);
            this.cboMonthWorks.Name = "cboMonthWorks";
            this.cboMonthWorks.Size = new System.Drawing.Size(170, 23);
            this.cboMonthWorks.TabIndex = 13;
            this.cboMonthWorks.SelectedIndexChanged += new System.EventHandler(this.CBoxMonthWorks_SelectedIndexChanged);
            // 
            // MenuStripDGV
            // 
            this.MenuStripDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verRegistosToolStripMenuItem,
            this.registarPedidoDeDispensaToolStripMenuItem,
            this.apagarToolStripMenuItem,
            this.toolStripSeparator1,
            this.cancelarToolStripMenuItem});
            this.MenuStripDGV.Name = "MenuStripDGV";
            this.MenuStripDGV.Size = new System.Drawing.Size(223, 98);
            // 
            // verRegistosToolStripMenuItem
            // 
            this.verRegistosToolStripMenuItem.Name = "verRegistosToolStripMenuItem";
            this.verRegistosToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.verRegistosToolStripMenuItem.Text = "Ver registos";
            // 
            // registarPedidoDeDispensaToolStripMenuItem
            // 
            this.registarPedidoDeDispensaToolStripMenuItem.Enabled = false;
            this.registarPedidoDeDispensaToolStripMenuItem.Name = "registarPedidoDeDispensaToolStripMenuItem";
            this.registarPedidoDeDispensaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.registarPedidoDeDispensaToolStripMenuItem.Text = "Registar Pedido de Dispensa";
            // 
            // apagarToolStripMenuItem
            // 
            this.apagarToolStripMenuItem.Enabled = false;
            this.apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            this.apagarToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.apagarToolStripMenuItem.Text = "Apagar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.Location = new System.Drawing.Point(1007, 680);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(131, 27);
            this.BtnFechar.TabIndex = 27;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // crptViewer
            // 
            this.crptViewer.ActiveViewIndex = -1;
            this.crptViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptViewer.Location = new System.Drawing.Point(10, 22);
            this.crptViewer.Name = "crptViewer";
            this.crptViewer.Size = new System.Drawing.Size(1115, 478);
            this.crptViewer.TabIndex = 29;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.crptViewer);
            this.groupBox4.Location = new System.Drawing.Point(7, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1131, 514);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Visualizador de Relatórios";
            // 
            // ReportsCreatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 721);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "ReportsCreatorView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios de Assiduidade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalculoAsseduidade_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.FrmCalculoAsseduidade_VisibleChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.MenuStripDGV.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxDepartamentos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBoxFuncionarios;
        private System.Windows.Forms.ComboBox CBoxCategorias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.ContextMenuStrip MenuStripDGV;
        private System.Windows.Forms.ToolStripMenuItem verRegistosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMonthWorks;
        private System.Windows.Forms.ToolStripMenuItem registarPedidoDeDispensaToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboReports;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btCreateReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptViewer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btCleanFilters;
        private System.Windows.Forms.Button btExportReport;
    }
}