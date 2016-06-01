namespace mz.betainteractive.sigeas.Views.ImportExport
{
    partial class ImportHrData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSaveImportedData = new System.Windows.Forms.Button();
            this.BtnImportFile = new System.Windows.Forms.Button();
            this.GBoxImportData = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LViewDepartamentos = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LViewCategorias = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LViewFuncionarios = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.TxtImportedFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GBoxImportData.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSaveImportedData
            // 
            this.BtnSaveImportedData.Location = new System.Drawing.Point(184, 484);
            this.BtnSaveImportedData.Name = "BtnSaveImportedData";
            this.BtnSaveImportedData.Size = new System.Drawing.Size(210, 23);
            this.BtnSaveImportedData.TabIndex = 3;
            this.BtnSaveImportedData.Text = "Guardar Informação importada";
            this.BtnSaveImportedData.UseVisualStyleBackColor = true;
            this.BtnSaveImportedData.Click += new System.EventHandler(this.BtnSaveImportedData_Click);
            // 
            // BtnImportFile
            // 
            this.BtnImportFile.Location = new System.Drawing.Point(39, 484);
            this.BtnImportFile.Name = "BtnImportFile";
            this.BtnImportFile.Size = new System.Drawing.Size(139, 23);
            this.BtnImportFile.TabIndex = 2;
            this.BtnImportFile.Text = "Importar Ficheiro";
            this.BtnImportFile.UseVisualStyleBackColor = true;
            this.BtnImportFile.Click += new System.EventHandler(this.BtnImportFile_Click);
            // 
            // GBoxImportData
            // 
            this.GBoxImportData.BackColor = System.Drawing.Color.White;
            this.GBoxImportData.Controls.Add(this.tabControl1);
            this.GBoxImportData.Controls.Add(this.label3);
            this.GBoxImportData.Controls.Add(this.TxtImportedFile);
            this.GBoxImportData.Controls.Add(this.label2);
            this.GBoxImportData.Location = new System.Drawing.Point(12, 12);
            this.GBoxImportData.Name = "GBoxImportData";
            this.GBoxImportData.Size = new System.Drawing.Size(646, 457);
            this.GBoxImportData.TabIndex = 1;
            this.GBoxImportData.TabStop = false;
            this.GBoxImportData.Text = "Dados da Empresa";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(23, 103);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 339);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LViewDepartamentos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(596, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Departamentos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LViewDepartamentos
            // 
            this.LViewDepartamentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader18});
            this.LViewDepartamentos.FullRowSelect = true;
            this.LViewDepartamentos.GridLines = true;
            this.LViewDepartamentos.Location = new System.Drawing.Point(13, 13);
            this.LViewDepartamentos.Name = "LViewDepartamentos";
            this.LViewDepartamentos.Size = new System.Drawing.Size(573, 280);
            this.LViewDepartamentos.TabIndex = 1;
            this.LViewDepartamentos.UseCompatibleStateImageBehavior = false;
            this.LViewDepartamentos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Codigo";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nome";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 185;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Descrição";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 204;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LViewCategorias);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(596, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Categorias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LViewCategorias
            // 
            this.LViewCategorias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader19});
            this.LViewCategorias.FullRowSelect = true;
            this.LViewCategorias.GridLines = true;
            this.LViewCategorias.Location = new System.Drawing.Point(12, 16);
            this.LViewCategorias.Name = "LViewCategorias";
            this.LViewCategorias.Size = new System.Drawing.Size(573, 280);
            this.LViewCategorias.TabIndex = 1;
            this.LViewCategorias.UseCompatibleStateImageBehavior = false;
            this.LViewCategorias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Codigo";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nome";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 185;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Descrição";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 204;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LViewFuncionarios);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(596, 313);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Funcionarios";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LViewFuncionarios
            // 
            this.LViewFuncionarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader20});
            this.LViewFuncionarios.FullRowSelect = true;
            this.LViewFuncionarios.GridLines = true;
            this.LViewFuncionarios.Location = new System.Drawing.Point(17, 15);
            this.LViewFuncionarios.Name = "LViewFuncionarios";
            this.LViewFuncionarios.Size = new System.Drawing.Size(573, 280);
            this.LViewFuncionarios.TabIndex = 0;
            this.LViewFuncionarios.UseCompatibleStateImageBehavior = false;
            this.LViewFuncionarios.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Codigo";
            this.columnHeader2.Width = 56;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 159;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sexo";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 59;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Cod. Dept";
            this.columnHeader10.Width = 67;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Cod. Categ";
            this.columnHeader11.Width = 67;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "eNumber";
            this.columnHeader12.Width = 66;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Privilege";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Username";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Password";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "CardNumber";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Enabled";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Informação Importada";
            // 
            // TxtImportedFile
            // 
            this.TxtImportedFile.Location = new System.Drawing.Point(23, 46);
            this.TxtImportedFile.Name = "TxtImportedFile";
            this.TxtImportedFile.ReadOnly = true;
            this.TxtImportedFile.Size = new System.Drawing.Size(600, 20);
            this.TxtImportedFile.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Ficheiro Importado";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Status";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Status";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Status";
            // 
            // ImportHrData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 527);
            this.Controls.Add(this.BtnSaveImportedData);
            this.Controls.Add(this.BtnImportFile);
            this.Controls.Add(this.GBoxImportData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ImportHrData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImportHrData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportHrData_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.ImportHrData_VisibleChanged);
            this.GBoxImportData.ResumeLayout(false);
            this.GBoxImportData.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSaveImportedData;
        private System.Windows.Forms.Button BtnImportFile;
        private System.Windows.Forms.GroupBox GBoxImportData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtImportedFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView LViewFuncionarios;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView LViewDepartamentos;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView LViewCategorias;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
    }
}