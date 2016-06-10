namespace mz.betainteractive.sigeas.Views.AccessControl {
    partial class AttendanceCalcsView {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxDepartamentos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBoxFuncionarios = new System.Windows.Forms.ComboBox();
            this.CBoxCategorias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnSearchAndCalculate = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.DGViewAttCalcs = new System.Windows.Forms.DataGridView();
            this.ColFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWeekDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntrada1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaida1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntrada2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaida2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColClockIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColClockOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntradaAtrasada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaidaAdiantada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPreste = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColHorasTrabalho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHorasAusente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHorasExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFeriado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColEmFerias = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MenuStripDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verRegistosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewAttCalcs)).BeginInit();
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
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 109);
            this.groupBox2.TabIndex = 22;
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
            // CBoxDepartamentos
            // 
            this.CBoxDepartamentos.FormattingEnabled = true;
            this.CBoxDepartamentos.Location = new System.Drawing.Point(101, 18);
            this.CBoxDepartamentos.Name = "CBoxDepartamentos";
            this.CBoxDepartamentos.Size = new System.Drawing.Size(192, 21);
            this.CBoxDepartamentos.TabIndex = 0;
            this.CBoxDepartamentos.SelectedIndexChanged += new System.EventHandler(this.CBoxDepartamentos_SelectedIndexChanged);
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
            // CBoxFuncionarios
            // 
            this.CBoxFuncionarios.FormattingEnabled = true;
            this.CBoxFuncionarios.Location = new System.Drawing.Point(101, 72);
            this.CBoxFuncionarios.Name = "CBoxFuncionarios";
            this.CBoxFuncionarios.Size = new System.Drawing.Size(192, 21);
            this.CBoxFuncionarios.TabIndex = 1;
            // 
            // CBoxCategorias
            // 
            this.CBoxCategorias.FormattingEnabled = true;
            this.CBoxCategorias.Location = new System.Drawing.Point(101, 45);
            this.CBoxCategorias.Name = "CBoxCategorias";
            this.CBoxCategorias.Size = new System.Drawing.Size(192, 21);
            this.CBoxCategorias.TabIndex = 12;
            this.CBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.CBoxCategorias_SelectedIndexChanged);
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
            this.groupBox1.Controls.Add(this.DtpToDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DtpFromDate);
            this.groupBox1.Location = new System.Drawing.Point(336, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 109);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodo a pesquisar";
            // 
            // DtpToDate
            // 
            this.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpToDate.Location = new System.Drawing.Point(84, 59);
            this.DtpToDate.Name = "DtpToDate";
            this.DtpToDate.Size = new System.Drawing.Size(91, 22);
            this.DtpToDate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Até";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "De";
            // 
            // DtpFromDate
            // 
            this.DtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFromDate.Location = new System.Drawing.Point(84, 32);
            this.DtpFromDate.Name = "DtpFromDate";
            this.DtpFromDate.Size = new System.Drawing.Size(91, 22);
            this.DtpFromDate.TabIndex = 0;
            this.DtpFromDate.Value = new System.DateTime(2012, 1, 1, 10, 7, 0, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnSearchAndCalculate);
            this.groupBox3.Controls.Add(this.BtnPesquisar);
            this.groupBox3.Location = new System.Drawing.Point(629, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 109);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // BtnSearchAndCalculate
            // 
            this.BtnSearchAndCalculate.Location = new System.Drawing.Point(25, 46);
            this.BtnSearchAndCalculate.Name = "BtnSearchAndCalculate";
            this.BtnSearchAndCalculate.Size = new System.Drawing.Size(169, 23);
            this.BtnSearchAndCalculate.TabIndex = 21;
            this.BtnSearchAndCalculate.Text = "Pesquisar e Calcular";
            this.BtnSearchAndCalculate.UseVisualStyleBackColor = true;
            this.BtnSearchAndCalculate.Click += new System.EventHandler(this.btSearchAndCalculate_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(25, 17);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(169, 23);
            this.BtnPesquisar.TabIndex = 20;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // DGViewAttCalcs
            // 
            this.DGViewAttCalcs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGViewAttCalcs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGViewAttCalcs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGViewAttCalcs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGViewAttCalcs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGViewAttCalcs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFuncionario,
            this.ColDay,
            this.ColWeekDay,
            this.ColEntrada1,
            this.ColSaida1,
            this.ColEntrada2,
            this.ColSaida2,
            this.ColClockIn,
            this.ColClockOut,
            this.ColEntradaAtrasada,
            this.ColSaidaAdiantada,
            this.ColPreste,
            this.ColHorasTrabalho,
            this.ColHorasAusente,
            this.ColHorasExtras,
            this.ColFeriado,
            this.ColEmFerias});
            this.DGViewAttCalcs.ContextMenuStrip = this.MenuStripDGV;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGViewAttCalcs.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGViewAttCalcs.EnableHeadersVisualStyles = false;
            this.DGViewAttCalcs.Location = new System.Drawing.Point(6, 19);
            this.DGViewAttCalcs.MultiSelect = false;
            this.DGViewAttCalcs.Name = "DGViewAttCalcs";
            this.DGViewAttCalcs.ReadOnly = true;
            this.DGViewAttCalcs.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGViewAttCalcs.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGViewAttCalcs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGViewAttCalcs.ShowEditingIcon = false;
            this.DGViewAttCalcs.Size = new System.Drawing.Size(825, 318);
            this.DGViewAttCalcs.TabIndex = 25;
            this.DGViewAttCalcs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvAttCalcs_MouseDoubleClick);
            // 
            // ColFuncionario
            // 
            this.ColFuncionario.HeaderText = "Nome";
            this.ColFuncionario.Name = "ColFuncionario";
            this.ColFuncionario.ReadOnly = true;
            // 
            // ColDay
            // 
            this.ColDay.HeaderText = "Data";
            this.ColDay.Name = "ColDay";
            this.ColDay.ReadOnly = true;
            this.ColDay.Width = 70;
            // 
            // ColWeekDay
            // 
            this.ColWeekDay.HeaderText = "Dia. Semana";
            this.ColWeekDay.Name = "ColWeekDay";
            this.ColWeekDay.ReadOnly = true;
            // 
            // ColEntrada1
            // 
            this.ColEntrada1.HeaderText = "1ª Entrada";
            this.ColEntrada1.Name = "ColEntrada1";
            this.ColEntrada1.ReadOnly = true;
            // 
            // ColSaida1
            // 
            this.ColSaida1.HeaderText = "1ª Saida";
            this.ColSaida1.Name = "ColSaida1";
            this.ColSaida1.ReadOnly = true;
            // 
            // ColEntrada2
            // 
            this.ColEntrada2.HeaderText = "2ª Entrada";
            this.ColEntrada2.Name = "ColEntrada2";
            this.ColEntrada2.ReadOnly = true;
            // 
            // ColSaida2
            // 
            this.ColSaida2.HeaderText = "2ª Saida";
            this.ColSaida2.Name = "ColSaida2";
            this.ColSaida2.ReadOnly = true;
            // 
            // ColClockIn
            // 
            this.ColClockIn.HeaderText = "Entrou ás";
            this.ColClockIn.Name = "ColClockIn";
            this.ColClockIn.ReadOnly = true;
            // 
            // ColClockOut
            // 
            this.ColClockOut.HeaderText = "Saiu ás";
            this.ColClockOut.Name = "ColClockOut";
            this.ColClockOut.ReadOnly = true;
            // 
            // ColEntradaAtrasada
            // 
            this.ColEntradaAtrasada.HeaderText = "Atraso";
            this.ColEntradaAtrasada.Name = "ColEntradaAtrasada";
            this.ColEntradaAtrasada.ReadOnly = true;
            // 
            // ColSaidaAdiantada
            // 
            this.ColSaidaAdiantada.HeaderText = "S. Adiantada";
            this.ColSaidaAdiantada.Name = "ColSaidaAdiantada";
            this.ColSaidaAdiantada.ReadOnly = true;
            // 
            // ColPreste
            // 
            this.ColPreste.HeaderText = "Presente";
            this.ColPreste.Name = "ColPreste";
            this.ColPreste.ReadOnly = true;
            this.ColPreste.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColPreste.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColHorasTrabalho
            // 
            this.ColHorasTrabalho.HeaderText = "H. Trabalho";
            this.ColHorasTrabalho.Name = "ColHorasTrabalho";
            this.ColHorasTrabalho.ReadOnly = true;
            // 
            // ColHorasAusente
            // 
            this.ColHorasAusente.HeaderText = "H. Ausente";
            this.ColHorasAusente.Name = "ColHorasAusente";
            this.ColHorasAusente.ReadOnly = true;
            // 
            // ColHorasExtras
            // 
            this.ColHorasExtras.HeaderText = "H. Extras";
            this.ColHorasExtras.Name = "ColHorasExtras";
            this.ColHorasExtras.ReadOnly = true;
            // 
            // ColFeriado
            // 
            this.ColFeriado.HeaderText = "Feriado";
            this.ColFeriado.Name = "ColFeriado";
            this.ColFeriado.ReadOnly = true;
            this.ColFeriado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColFeriado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColEmFerias
            // 
            this.ColEmFerias.HeaderText = "De férias";
            this.ColEmFerias.Name = "ColEmFerias";
            this.ColEmFerias.ReadOnly = true;
            this.ColEmFerias.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColEmFerias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MenuStripDGV
            // 
            this.MenuStripDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verRegistosToolStripMenuItem,
            this.apagarToolStripMenuItem,
            this.toolStripSeparator1,
            this.cancelarToolStripMenuItem});
            this.MenuStripDGV.Name = "MenuStripDGV";
            this.MenuStripDGV.Size = new System.Drawing.Size(135, 76);
            this.MenuStripDGV.Opening += new System.ComponentModel.CancelEventHandler(this.MenuStripDGV_Opening);
            // 
            // verRegistosToolStripMenuItem
            // 
            this.verRegistosToolStripMenuItem.Name = "verRegistosToolStripMenuItem";
            this.verRegistosToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.verRegistosToolStripMenuItem.Text = "Ver registos";
            this.verRegistosToolStripMenuItem.Click += new System.EventHandler(this.verRegistosToolStripMenuItem_Click);
            // 
            // apagarToolStripMenuItem
            // 
            this.apagarToolStripMenuItem.Enabled = false;
            this.apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            this.apagarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.apagarToolStripMenuItem.Text = "Apagar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.DGViewAttCalcs);
            this.groupBox4.Location = new System.Drawing.Point(12, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(839, 343);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados calculados";
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(737, 476);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(112, 23);
            this.BtnFechar.TabIndex = 27;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(622, 477);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(109, 23);
            this.BtnLimpar.TabIndex = 28;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // AttendanceCalcsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(863, 512);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "AttendanceCalcsView";
            this.Text = "Calculo de Assiduidade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalculoAsseduidade_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.FrmCalculoAsseduidade_VisibleChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewAttCalcs)).EndInit();
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
        private System.Windows.Forms.DateTimePicker DtpToDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpFromDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnSearchAndCalculate;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.DataGridView DGViewAttCalcs;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.ContextMenuStrip MenuStripDGV;
        private System.Windows.Forms.ToolStripMenuItem verRegistosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWeekDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntrada1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaida1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntrada2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaida2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClockIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClockOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntradaAtrasada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaidaAdiantada;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColPreste;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHorasTrabalho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHorasAusente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHorasExtras;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColFeriado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColEmFerias;
    }
}