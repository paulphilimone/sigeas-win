namespace mz.betainteractive.sigeas.Views.Horarios {
    partial class FrmPlanificacaoHorario {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.CBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGViewFuncionarioHorario = new System.Windows.Forms.DataGridView();
            this.colOrdem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHorario = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NudAnos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtFuncionario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.CBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RBtnPeriodoSemanal = new System.Windows.Forms.RadioButton();
            this.RBtnPeriodoMensal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBtnPeriodoTrimestral = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btFechar = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.BtnViewAssociacoes = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewFuncionarioHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnos)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBoxDepartamento
            // 
            this.CBoxDepartamento.FormattingEnabled = true;
            this.CBoxDepartamento.Location = new System.Drawing.Point(101, 18);
            this.CBoxDepartamento.Name = "CBoxDepartamento";
            this.CBoxDepartamento.Size = new System.Drawing.Size(182, 21);
            this.CBoxDepartamento.TabIndex = 0;
            this.CBoxDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            // 
            // CBoxFuncionario
            // 
            this.CBoxFuncionario.FormattingEnabled = true;
            this.CBoxFuncionario.Location = new System.Drawing.Point(101, 72);
            this.CBoxFuncionario.Name = "CBoxFuncionario";
            this.CBoxFuncionario.Size = new System.Drawing.Size(182, 21);
            this.CBoxFuncionario.TabIndex = 1;
            this.CBoxFuncionario.SelectedIndexChanged += new System.EventHandler(this.cboFuncionario_SelectedIndexChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funcionario";
            // 
            // DGViewFuncionarioHorario
            // 
            this.DGViewFuncionarioHorario.AllowUserToAddRows = false;
            this.DGViewFuncionarioHorario.AllowUserToDeleteRows = false;
            this.DGViewFuncionarioHorario.AllowUserToResizeColumns = false;
            this.DGViewFuncionarioHorario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DGViewFuncionarioHorario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGViewFuncionarioHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGViewFuncionarioHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGViewFuncionarioHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGViewFuncionarioHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrdem,
            this.colHorario,
            this.colPeriodo,
            this.colSelected});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGViewFuncionarioHorario.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGViewFuncionarioHorario.Location = new System.Drawing.Point(12, 188);
            this.DGViewFuncionarioHorario.Name = "DGViewFuncionarioHorario";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGViewFuncionarioHorario.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGViewFuncionarioHorario.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGViewFuncionarioHorario.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DGViewFuncionarioHorario.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGViewFuncionarioHorario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGViewFuncionarioHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGViewFuncionarioHorario.ShowCellErrors = false;
            this.DGViewFuncionarioHorario.ShowRowErrors = false;
            this.DGViewFuncionarioHorario.Size = new System.Drawing.Size(612, 168);
            this.DGViewFuncionarioHorario.TabIndex = 5;
            // 
            // colOrdem
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.colOrdem.DefaultCellStyle = dataGridViewCellStyle3;
            this.colOrdem.HeaderText = "Ordem";
            this.colOrdem.Name = "colOrdem";
            this.colOrdem.ReadOnly = true;
            this.colOrdem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colOrdem.Width = 70;
            // 
            // colHorario
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "Sem horário";
            this.colHorario.DefaultCellStyle = dataGridViewCellStyle4;
            this.colHorario.HeaderText = "Horário";
            this.colHorario.Name = "colHorario";
            this.colHorario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colHorario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colHorario.Width = 230;
            // 
            // colPeriodo
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPeriodo.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPeriodo.HeaderText = "Periodo";
            this.colPeriodo.Name = "colPeriodo";
            this.colPeriodo.ReadOnly = true;
            this.colPeriodo.Width = 255;
            // 
            // colSelected
            // 
            this.colSelected.HeaderText = "";
            this.colSelected.Name = "colSelected";
            this.colSelected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSelected.Width = 30;
            // 
            // NudAnos
            // 
            this.NudAnos.Location = new System.Drawing.Point(46, 12);
            this.NudAnos.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.NudAnos.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NudAnos.Name = "NudAnos";
            this.NudAnos.Size = new System.Drawing.Size(49, 22);
            this.NudAnos.TabIndex = 6;
            this.NudAnos.Value = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ano";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TxtFuncionario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.NudAnos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chkSelectAll);
            this.panel1.Location = new System.Drawing.Point(11, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 46);
            this.panel1.TabIndex = 8;
            // 
            // TxtFuncionario
            // 
            this.TxtFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFuncionario.Location = new System.Drawing.Point(198, 12);
            this.TxtFuncionario.Name = "TxtFuncionario";
            this.TxtFuncionario.ReadOnly = true;
            this.TxtFuncionario.Size = new System.Drawing.Size(229, 20);
            this.TxtFuncionario.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Funcionário";
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(462, 13);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSelectAll.Size = new System.Drawing.Size(112, 17);
            this.chkSelectAll.TabIndex = 10;
            this.chkSelectAll.Text = "Selecionar Todos";
            this.chkSelectAll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSelectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // CBoxCategoria
            // 
            this.CBoxCategoria.FormattingEnabled = true;
            this.CBoxCategoria.Location = new System.Drawing.Point(101, 45);
            this.CBoxCategoria.Name = "CBoxCategoria";
            this.CBoxCategoria.Size = new System.Drawing.Size(182, 21);
            this.CBoxCategoria.TabIndex = 12;
            this.CBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
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
            // RBtnPeriodoSemanal
            // 
            this.RBtnPeriodoSemanal.AutoSize = true;
            this.RBtnPeriodoSemanal.Checked = true;
            this.RBtnPeriodoSemanal.Location = new System.Drawing.Point(35, 22);
            this.RBtnPeriodoSemanal.Name = "RBtnPeriodoSemanal";
            this.RBtnPeriodoSemanal.Size = new System.Drawing.Size(68, 17);
            this.RBtnPeriodoSemanal.TabIndex = 14;
            this.RBtnPeriodoSemanal.TabStop = true;
            this.RBtnPeriodoSemanal.Text = "Semanal";
            this.RBtnPeriodoSemanal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBtnPeriodoSemanal.UseVisualStyleBackColor = true;
            // 
            // RBtnPeriodoMensal
            // 
            this.RBtnPeriodoMensal.AutoSize = true;
            this.RBtnPeriodoMensal.Location = new System.Drawing.Point(123, 23);
            this.RBtnPeriodoMensal.Name = "RBtnPeriodoMensal";
            this.RBtnPeriodoMensal.Size = new System.Drawing.Size(61, 17);
            this.RBtnPeriodoMensal.TabIndex = 15;
            this.RBtnPeriodoMensal.Text = "Mensal";
            this.RBtnPeriodoMensal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBtnPeriodoTrimestral);
            this.groupBox1.Controls.Add(this.RBtnPeriodoSemanal);
            this.groupBox1.Controls.Add(this.RBtnPeriodoMensal);
            this.groupBox1.Location = new System.Drawing.Point(317, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 58);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de horário";
            // 
            // RBtnPeriodoTrimestral
            // 
            this.RBtnPeriodoTrimestral.AutoSize = true;
            this.RBtnPeriodoTrimestral.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.RBtnPeriodoTrimestral.Enabled = false;
            this.RBtnPeriodoTrimestral.Location = new System.Drawing.Point(206, 23);
            this.RBtnPeriodoTrimestral.Name = "RBtnPeriodoTrimestral";
            this.RBtnPeriodoTrimestral.Size = new System.Drawing.Size(75, 17);
            this.RBtnPeriodoTrimestral.TabIndex = 16;
            this.RBtnPeriodoTrimestral.Text = "Trimestral";
            this.RBtnPeriodoTrimestral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBtnPeriodoTrimestral.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CBoxDepartamento);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CBoxFuncionario);
            this.groupBox2.Controls.Add(this.CBoxCategoria);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 109);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(523, 375);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(100, 23);
            this.btFechar.TabIndex = 19;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(264, 375);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(146, 23);
            this.btGravar.TabIndex = 20;
            this.btGravar.Text = "Gravar Associações";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // BtnViewAssociacoes
            // 
            this.BtnViewAssociacoes.Enabled = false;
            this.BtnViewAssociacoes.Location = new System.Drawing.Point(56, 18);
            this.BtnViewAssociacoes.Name = "BtnViewAssociacoes";
            this.BtnViewAssociacoes.Size = new System.Drawing.Size(202, 23);
            this.BtnViewAssociacoes.TabIndex = 21;
            this.BtnViewAssociacoes.Text = "Visualisar associações de horários";
            this.BtnViewAssociacoes.UseVisualStyleBackColor = true;
            this.BtnViewAssociacoes.Click += new System.EventHandler(this.btViewAssociacoes_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnViewAssociacoes);
            this.groupBox3.Location = new System.Drawing.Point(317, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 52);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(416, 375);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(101, 23);
            this.btLimpar.TabIndex = 23;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // FrmPlanificacaoHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 410);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGViewFuncionarioHorario);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FrmPlanificacaoHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Planificação de Horários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPlanificacaoHorario_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.FrmPlanificacaoHorario_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewFuncionarioHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBoxDepartamento;
        private System.Windows.Forms.ComboBox CBoxFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGViewFuncionarioHorario;
        private System.Windows.Forms.NumericUpDown NudAnos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.TextBox TxtFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBoxCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RBtnPeriodoSemanal;
        private System.Windows.Forms.RadioButton RBtnPeriodoMensal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button BtnViewAssociacoes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.RadioButton RBtnPeriodoTrimestral;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrdem;
        private System.Windows.Forms.DataGridViewComboBoxColumn colHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriodo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelected;
    }
}