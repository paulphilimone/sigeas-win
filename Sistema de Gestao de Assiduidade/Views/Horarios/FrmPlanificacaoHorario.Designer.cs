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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.CBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGViewFuncionarioHorario = new System.Windows.Forms.DataGridView();
            this.colOrdem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NudAnos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtFuncionario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popMenuSelectionDecision = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.popMenSelOverwriteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.popMenSelOverwriteSome = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.popMenSelCancelar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewFuncionarioHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnos)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.popMenuSelectionDecision.SuspendLayout();
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGViewFuncionarioHorario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DGViewFuncionarioHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGViewFuncionarioHorario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGViewFuncionarioHorario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGViewFuncionarioHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.DGViewFuncionarioHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGViewFuncionarioHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrdem,
            this.ColFName});
            this.DGViewFuncionarioHorario.Cursor = System.Windows.Forms.Cursors.Cross;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGViewFuncionarioHorario.DefaultCellStyle = dataGridViewCellStyle18;
            this.DGViewFuncionarioHorario.Location = new System.Drawing.Point(12, 188);
            this.DGViewFuncionarioHorario.Name = "DGViewFuncionarioHorario";
            this.DGViewFuncionarioHorario.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGViewFuncionarioHorario.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.DGViewFuncionarioHorario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGViewFuncionarioHorario.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.DGViewFuncionarioHorario.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGViewFuncionarioHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGViewFuncionarioHorario.ShowCellErrors = false;
            this.DGViewFuncionarioHorario.ShowRowErrors = false;
            this.DGViewFuncionarioHorario.Size = new System.Drawing.Size(1015, 394);
            this.DGViewFuncionarioHorario.TabIndex = 5;
            // 
            // colOrdem
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.colOrdem.DefaultCellStyle = dataGridViewCellStyle17;
            this.colOrdem.HeaderText = "Código";
            this.colOrdem.Name = "colOrdem";
            this.colOrdem.ReadOnly = true;
            this.colOrdem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colOrdem.Width = 90;
            // 
            // ColFName
            // 
            this.ColFName.HeaderText = "Nome Completo";
            this.ColFName.Name = "ColFName";
            this.ColFName.ReadOnly = true;
            this.ColFName.Width = 200;
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
            this.RBtnPeriodoSemanal.Enabled = false;
            this.RBtnPeriodoSemanal.Location = new System.Drawing.Point(35, 22);
            this.RBtnPeriodoSemanal.Name = "RBtnPeriodoSemanal";
            this.RBtnPeriodoSemanal.Size = new System.Drawing.Size(68, 17);
            this.RBtnPeriodoSemanal.TabIndex = 14;
            this.RBtnPeriodoSemanal.Text = "Semanal";
            this.RBtnPeriodoSemanal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBtnPeriodoSemanal.UseVisualStyleBackColor = true;
            // 
            // RBtnPeriodoMensal
            // 
            this.RBtnPeriodoMensal.AutoSize = true;
            this.RBtnPeriodoMensal.Checked = true;
            this.RBtnPeriodoMensal.Location = new System.Drawing.Point(123, 23);
            this.RBtnPeriodoMensal.Name = "RBtnPeriodoMensal";
            this.RBtnPeriodoMensal.Size = new System.Drawing.Size(61, 17);
            this.RBtnPeriodoMensal.TabIndex = 15;
            this.RBtnPeriodoMensal.TabStop = true;
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
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.Location = new System.Drawing.Point(926, 601);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(100, 23);
            this.btFechar.TabIndex = 19;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btGravar
            // 
            this.btGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGravar.Location = new System.Drawing.Point(667, 601);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(146, 23);
            this.btGravar.TabIndex = 20;
            this.btGravar.Text = "Gravar Associações";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // BtnViewAssociacoes
            // 
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
            this.btLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpar.Location = new System.Drawing.Point(819, 601);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(101, 23);
            this.btLimpar.TabIndex = 23;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Completo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // popMenuSelectionDecision
            // 
            this.popMenuSelectionDecision.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popMenSelOverwriteAll,
            this.popMenSelOverwriteSome,
            this.toolStripSeparator1,
            this.popMenSelCancelar});
            this.popMenuSelectionDecision.Name = "popMenuSelectionDecision";
            this.popMenuSelectionDecision.Size = new System.Drawing.Size(227, 76);
            // 
            // popMenSelOverwriteAll
            // 
            this.popMenSelOverwriteAll.Name = "popMenSelOverwriteAll";
            this.popMenSelOverwriteAll.Size = new System.Drawing.Size(226, 22);
            this.popMenSelOverwriteAll.Text = "Substituir Todos";
            // 
            // popMenSelOverwriteSome
            // 
            this.popMenSelOverwriteSome.Name = "popMenSelOverwriteSome";
            this.popMenSelOverwriteSome.Size = new System.Drawing.Size(226, 22);
            this.popMenSelOverwriteSome.Text = "Adicionar os Novos somente";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // popMenSelCancelar
            // 
            this.popMenSelCancelar.Name = "popMenSelCancelar";
            this.popMenSelCancelar.Size = new System.Drawing.Size(226, 22);
            this.popMenSelCancelar.Text = "Cancelar / Ignorar";
            // 
            // FrmPlanificacaoHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1039, 636);
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
            this.popMenuSelectionDecision.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ContextMenuStrip popMenuSelectionDecision;
        private System.Windows.Forms.ToolStripMenuItem popMenSelOverwriteAll;
        private System.Windows.Forms.ToolStripMenuItem popMenSelOverwriteSome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem popMenSelCancelar;
    }
}