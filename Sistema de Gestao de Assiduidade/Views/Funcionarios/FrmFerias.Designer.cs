namespace mz.betainteractive.sigeas.Views.Funcionarios {
    partial class FrmFerias {
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "01 de Fevereiro de 2012"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "29 de Fevereiro de 2012"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "28 dias"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Cumpridas", System.Drawing.SystemColors.MenuHighlight, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.CBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btViewList = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewFerias = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CBoxDepartamento);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CBoxFuncionario);
            this.groupBox2.Controls.Add(this.CBoxCategoria);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(11, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 126);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecione o Funcionário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departamento";
            // 
            // cboDepartamento
            // 
            this.CBoxDepartamento.FormattingEnabled = true;
            this.CBoxDepartamento.Location = new System.Drawing.Point(95, 31);
            this.CBoxDepartamento.Name = "cboDepartamento";
            this.CBoxDepartamento.Size = new System.Drawing.Size(146, 21);
            this.CBoxDepartamento.TabIndex = 0;
            this.CBoxDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Categoria";
            // 
            // cboFuncionario
            // 
            this.CBoxFuncionario.FormattingEnabled = true;
            this.CBoxFuncionario.Location = new System.Drawing.Point(95, 85);
            this.CBoxFuncionario.Name = "cboFuncionario";
            this.CBoxFuncionario.Size = new System.Drawing.Size(146, 21);
            this.CBoxFuncionario.TabIndex = 1;
            this.CBoxFuncionario.SelectedIndexChanged += new System.EventHandler(this.cboFuncionario_SelectedIndexChanged);
            // 
            // cboCategoria
            // 
            this.CBoxCategoria.FormattingEnabled = true;
            this.CBoxCategoria.Location = new System.Drawing.Point(95, 58);
            this.CBoxCategoria.Name = "cboCategoria";
            this.CBoxCategoria.Size = new System.Drawing.Size(146, 21);
            this.CBoxCategoria.TabIndex = 12;
            this.CBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funcionario";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "d\' de \'MMMM\' de \'yyyy";
            this.dtpInicio.Location = new System.Drawing.Point(92, 30);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(233, 22);
            this.dtpInicio.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Data do inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Data do fim";
            // 
            // dtpFim
            // 
            this.dtpFim.Location = new System.Drawing.Point(92, 57);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(233, 22);
            this.dtpFim.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btViewList);
            this.groupBox1.Controls.Add(this.btGravar);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.dtpFim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(273, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 126);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodo das férias";
            // 
            // btViewList
            // 
            this.btViewList.Enabled = false;
            this.btViewList.Location = new System.Drawing.Point(17, 88);
            this.btViewList.Name = "btViewList";
            this.btViewList.Size = new System.Drawing.Size(167, 23);
            this.btViewList.TabIndex = 10;
            this.btViewList.Text = "Visualisar Lista de ferias";
            this.btViewList.UseVisualStyleBackColor = true;
            this.btViewList.Click += new System.EventHandler(this.btViewList_Click);
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(190, 88);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(135, 23);
            this.btGravar.TabIndex = 23;
            this.btGravar.Text = "Registar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewFerias);
            this.groupBox3.Location = new System.Drawing.Point(11, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(602, 206);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de feriados registados";
            // 
            // listViewFerias
            // 
            this.listViewFerias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewFerias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewFerias.FullRowSelect = true;
            this.listViewFerias.GridLines = true;
            this.listViewFerias.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewFerias.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewFerias.Location = new System.Drawing.Point(16, 64);
            this.listViewFerias.MultiSelect = false;
            this.listViewFerias.Name = "listViewFerias";
            this.listViewFerias.Size = new System.Drawing.Size(571, 126);
            this.listViewFerias.TabIndex = 0;
            this.listViewFerias.UseCompatibleStateImageBehavior = false;
            this.listViewFerias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Data de inicio";
            this.columnHeader1.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data do fim";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 158;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Duração";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 74;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Estado";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(500, 358);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(99, 23);
            this.btFechar.TabIndex = 25;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtFuncionario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(27, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 35);
            this.panel1.TabIndex = 26;
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionario.Location = new System.Drawing.Point(78, 8);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.ReadOnly = true;
            this.txtFuncionario.Size = new System.Drawing.Size(252, 20);
            this.txtFuncionario.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Funcionário";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(400, 358);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(94, 23);
            this.btLimpar.TabIndex = 27;
            this.btLimpar.Text = "Limpar lista";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(299, 358);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(95, 23);
            this.btRemover.TabIndex = 28;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // FrmFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 393);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmFerias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Férias dos funcionários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFerias_FormClosing);            
            this.VisibleChanged += new System.EventHandler(this.FrmFerias_VisibleChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxDepartamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBoxFuncionario;
        private System.Windows.Forms.ComboBox CBoxCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.ListView listViewFerias;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btViewList;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btRemover;
    }
}