namespace mz.betainteractive.sigeas {
    partial class FrmPeriodosAno {
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Fevereiro",
            "01 Fevereiro á 29 Fevereiro",
            "2012"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "1ª",
            "01 Janeiro á 01 Janeiro",
            "2012"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.nudAnos = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btGenerateWeeks = new System.Windows.Forms.Button();
            this.btGravarSemanas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabMesesSemanas = new System.Windows.Forms.TabControl();
            this.tabPageMeses = new System.Windows.Forms.TabPage();
            this.listViewMeses = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageSemanas = new System.Windows.Forms.TabPage();
            this.listViewSemanas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listAnos = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.btGravarMeses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabMesesSemanas.SuspendLayout();
            this.tabPageMeses.SuspendLayout();
            this.tabPageSemanas.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ano";
            // 
            // nudAnos
            // 
            this.nudAnos.Location = new System.Drawing.Point(54, 21);
            this.nudAnos.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudAnos.Minimum = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            this.nudAnos.Name = "nudAnos";
            this.nudAnos.Size = new System.Drawing.Size(120, 22);
            this.nudAnos.TabIndex = 1;
            this.nudAnos.Value = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudAnos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btGenerateWeeks);
            this.groupBox1.Location = new System.Drawing.Point(125, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 56);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btGenerateWeeks
            // 
            this.btGenerateWeeks.Location = new System.Drawing.Point(246, 20);
            this.btGenerateWeeks.Name = "btGenerateWeeks";
            this.btGenerateWeeks.Size = new System.Drawing.Size(142, 23);
            this.btGenerateWeeks.TabIndex = 5;
            this.btGenerateWeeks.Text = "Gerar Meses e Semanas";
            this.btGenerateWeeks.UseVisualStyleBackColor = true;
            this.btGenerateWeeks.Click += new System.EventHandler(this.btGenerateWeeks_Click);
            // 
            // btGravarSemanas
            // 
            this.btGravarSemanas.Enabled = false;
            this.btGravarSemanas.Location = new System.Drawing.Point(249, 352);
            this.btGravarSemanas.Name = "btGravarSemanas";
            this.btGravarSemanas.Size = new System.Drawing.Size(102, 23);
            this.btGravarSemanas.TabIndex = 6;
            this.btGravarSemanas.Text = "Gravar Semanas";
            this.btGravarSemanas.UseVisualStyleBackColor = true;
            this.btGravarSemanas.Click += new System.EventHandler(this.btGravarSemanas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabMesesSemanas);
            this.groupBox2.Location = new System.Drawing.Point(125, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 272);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // tabMesesSemanas
            // 
            this.tabMesesSemanas.Controls.Add(this.tabPageMeses);
            this.tabMesesSemanas.Controls.Add(this.tabPageSemanas);
            this.tabMesesSemanas.Location = new System.Drawing.Point(6, 13);
            this.tabMesesSemanas.Name = "tabMesesSemanas";
            this.tabMesesSemanas.SelectedIndex = 0;
            this.tabMesesSemanas.Size = new System.Drawing.Size(445, 253);
            this.tabMesesSemanas.TabIndex = 12;
            // 
            // tabPageMeses
            // 
            this.tabPageMeses.Controls.Add(this.listViewMeses);
            this.tabPageMeses.Location = new System.Drawing.Point(4, 22);
            this.tabPageMeses.Name = "tabPageMeses";
            this.tabPageMeses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMeses.Size = new System.Drawing.Size(437, 227);
            this.tabPageMeses.TabIndex = 0;
            this.tabPageMeses.Text = "Lista de meses";
            this.tabPageMeses.UseVisualStyleBackColor = true;
            // 
            // listViewMeses
            // 
            this.listViewMeses.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewMeses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewMeses.FullRowSelect = true;
            this.listViewMeses.GridLines = true;
            this.listViewMeses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMeses.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listViewMeses.Location = new System.Drawing.Point(3, 5);
            this.listViewMeses.MultiSelect = false;
            this.listViewMeses.Name = "listViewMeses";
            this.listViewMeses.Size = new System.Drawing.Size(429, 213);
            this.listViewMeses.TabIndex = 6;
            this.listViewMeses.UseCompatibleStateImageBehavior = false;
            this.listViewMeses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nº";
            this.columnHeader7.Width = 31;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mês";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Período";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 212;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ano";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 53;
            // 
            // tabPageSemanas
            // 
            this.tabPageSemanas.Controls.Add(this.listViewSemanas);
            this.tabPageSemanas.Location = new System.Drawing.Point(4, 22);
            this.tabPageSemanas.Name = "tabPageSemanas";
            this.tabPageSemanas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSemanas.Size = new System.Drawing.Size(437, 227);
            this.tabPageSemanas.TabIndex = 1;
            this.tabPageSemanas.Text = "Lista de semanas";
            this.tabPageSemanas.UseVisualStyleBackColor = true;
            // 
            // listViewSemanas
            // 
            this.listViewSemanas.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewSemanas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewSemanas.FullRowSelect = true;
            this.listViewSemanas.GridLines = true;
            this.listViewSemanas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSemanas.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.listViewSemanas.Location = new System.Drawing.Point(3, 5);
            this.listViewSemanas.MultiSelect = false;
            this.listViewSemanas.Name = "listViewSemanas";
            this.listViewSemanas.Size = new System.Drawing.Size(429, 213);
            this.listViewSemanas.TabIndex = 5;
            this.listViewSemanas.UseCompatibleStateImageBehavior = false;
            this.listViewSemanas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Semana";
            this.columnHeader1.Width = 52;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Período";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 282;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ano";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 67;
            // 
            // listAnos
            // 
            this.listAnos.FormattingEnabled = true;
            this.listAnos.Location = new System.Drawing.Point(12, 23);
            this.listAnos.Name = "listAnos";
            this.listAnos.Size = new System.Drawing.Size(85, 290);
            this.listAnos.TabIndex = 8;
            this.listAnos.SelectedIndexChanged += new System.EventHandler(this.listAnos_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listAnos);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(107, 334);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Anos Registados";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(357, 352);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(102, 23);
            this.btLimpar.TabIndex = 10;
            this.btLimpar.Text = "Limpar lista";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(465, 352);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(102, 23);
            this.btFechar.TabIndex = 11;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btGravarMeses
            // 
            this.btGravarMeses.Location = new System.Drawing.Point(138, 352);
            this.btGravarMeses.Name = "btGravarMeses";
            this.btGravarMeses.Size = new System.Drawing.Size(105, 23);
            this.btGravarMeses.TabIndex = 12;
            this.btGravarMeses.Text = "Gravar Meses";
            this.btGravarMeses.UseVisualStyleBackColor = true;
            this.btGravarMeses.Click += new System.EventHandler(this.btGravarMeses_Click);
            // 
            // FrmPeriodosAno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 387);
            this.Controls.Add(this.btGravarMeses);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btGravarSemanas);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmPeriodosAno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Periodos do Ano";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSemanasAno_FormClosing);
            this.Load += new System.EventHandler(this.FrmSemanasAno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabMesesSemanas.ResumeLayout(false);
            this.tabPageMeses.ResumeLayout(false);
            this.tabPageSemanas.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAnos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btGenerateWeeks;
        private System.Windows.Forms.Button btGravarSemanas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listAnos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.TabControl tabMesesSemanas;
        private System.Windows.Forms.TabPage tabPageMeses;
        private System.Windows.Forms.TabPage tabPageSemanas;
        private System.Windows.Forms.ListView listViewSemanas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listViewMeses;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btGravarMeses;
    }
}