namespace mz.betainteractive.sigeas.Views.FuncionarioDevices {
    partial class FuncionarioDevicesView {
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBoxCategorias = new System.Windows.Forms.ComboBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxDepartamentos = new System.Windows.Forms.ComboBox();
            this.CBoxFuncionarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGViewFuncDevices = new System.Windows.Forms.DataGridView();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSaveOnDevices = new System.Windows.Forms.Button();
            this.BtnSaveAll = new System.Windows.Forms.Button();
            this.BtFechar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewFuncDevices)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CBoxCategorias);
            this.groupBox2.Controls.Add(this.BtnPesquisar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CBoxDepartamentos);
            this.groupBox2.Controls.Add(this.CBoxFuncionarios);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 105);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Critérios de pesquisa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categoria";
            // 
            // CBoxCategorias
            // 
            this.CBoxCategorias.FormattingEnabled = true;
            this.CBoxCategorias.Location = new System.Drawing.Point(107, 47);
            this.CBoxCategorias.Name = "CBoxCategorias";
            this.CBoxCategorias.Size = new System.Drawing.Size(277, 21);
            this.CBoxCategorias.TabIndex = 7;
            this.CBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.CBoxCategorias_SelectedIndexChanged);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.Location = new System.Drawing.Point(706, 38);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(154, 37);
            this.BtnPesquisar.TabIndex = 6;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departamento";
            // 
            // CBoxDepartamentos
            // 
            this.CBoxDepartamentos.FormattingEnabled = true;
            this.CBoxDepartamentos.Location = new System.Drawing.Point(107, 20);
            this.CBoxDepartamentos.Name = "CBoxDepartamentos";
            this.CBoxDepartamentos.Size = new System.Drawing.Size(277, 21);
            this.CBoxDepartamentos.TabIndex = 0;
            this.CBoxDepartamentos.SelectedIndexChanged += new System.EventHandler(this.CBoxDepartamentos_SelectedIndexChanged);
            // 
            // CBoxFuncionarios
            // 
            this.CBoxFuncionarios.FormattingEnabled = true;
            this.CBoxFuncionarios.Location = new System.Drawing.Point(107, 74);
            this.CBoxFuncionarios.Name = "CBoxFuncionarios";
            this.CBoxFuncionarios.Size = new System.Drawing.Size(277, 21);
            this.CBoxFuncionarios.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funcionario";
            // 
            // DGViewFuncDevices
            // 
            this.DGViewFuncDevices.AllowUserToAddRows = false;
            this.DGViewFuncDevices.AllowUserToDeleteRows = false;
            this.DGViewFuncDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGViewFuncDevices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGViewFuncDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGViewFuncDevices.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGViewFuncDevices.EnableHeadersVisualStyles = false;
            this.DGViewFuncDevices.Location = new System.Drawing.Point(16, 21);
            this.DGViewFuncDevices.Name = "DGViewFuncDevices";
            this.DGViewFuncDevices.RowHeadersVisible = false;
            this.DGViewFuncDevices.Size = new System.Drawing.Size(865, 322);
            this.DGViewFuncDevices.TabIndex = 4;
            this.DGViewFuncDevices.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGViewBenDevices_CellEndEdit);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(766, 476);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(143, 23);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Fechar";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnSaveOnDevices);
            this.groupBox1.Controls.Add(this.BtnSaveAll);
            this.groupBox1.Controls.Add(this.DGViewFuncDevices);
            this.groupBox1.Location = new System.Drawing.Point(12, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 386);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionário - Portas/Biométricos";
            // 
            // BtnSaveOnDevices
            // 
            this.BtnSaveOnDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSaveOnDevices.Location = new System.Drawing.Point(227, 349);
            this.BtnSaveOnDevices.Name = "BtnSaveOnDevices";
            this.BtnSaveOnDevices.Size = new System.Drawing.Size(284, 26);
            this.BtnSaveOnDevices.TabIndex = 8;
            this.BtnSaveOnDevices.Text = "Atualizar Associações nos Biometricos";
            this.BtnSaveOnDevices.UseVisualStyleBackColor = true;
            this.BtnSaveOnDevices.Click += new System.EventHandler(this.BtnSaveOnDevices_Click);
            // 
            // BtnSaveAll
            // 
            this.BtnSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSaveAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveAll.Location = new System.Drawing.Point(16, 349);
            this.BtnSaveAll.Name = "BtnSaveAll";
            this.BtnSaveAll.Size = new System.Drawing.Size(205, 26);
            this.BtnSaveAll.TabIndex = 7;
            this.BtnSaveAll.Text = "Guardar Associações";
            this.BtnSaveAll.UseVisualStyleBackColor = true;
            this.BtnSaveAll.Click += new System.EventHandler(this.BtnSaveAll_Click);
            // 
            // BtFechar
            // 
            this.BtFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFechar.Location = new System.Drawing.Point(766, 515);
            this.BtFechar.Name = "BtFechar";
            this.BtFechar.Size = new System.Drawing.Size(143, 26);
            this.BtFechar.TabIndex = 5;
            this.BtFechar.Text = "Fechar";
            this.BtFechar.UseVisualStyleBackColor = true;
            this.BtFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FuncionarioDevicesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 547);
            this.Controls.Add(this.BtFechar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FuncionarioDevicesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Associar Funcionários ás Portas/Biometricos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableFuncionarioDeviceView_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.TableFuncionarioDeviceView_VisibleChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewFuncDevices)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxDepartamentos;
        private System.Windows.Forms.ComboBox CBoxFuncionarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGViewFuncDevices;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSaveAll;
        private System.Windows.Forms.Button BtFechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBoxCategorias;
        private System.Windows.Forms.Button BtnSaveOnDevices;
        
    }
}