namespace mz.betainteractive.sigeas.Views.UserManagment {
    partial class RoleAdd {
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
            this.GBoxRoleAdd = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtRole_Name = new System.Windows.Forms.TextBox();
            this.BtnRole_Add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGViewPermissions = new System.Windows.Forms.DataGridView();
            this.ColSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColFormCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColActionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBoxRoleAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewPermissions)).BeginInit();
            this.SuspendLayout();
            // 
            // GBoxRoleAdd
            // 
            this.GBoxRoleAdd.Controls.Add(this.label8);
            this.GBoxRoleAdd.Controls.Add(this.TxtRole_Name);
            this.GBoxRoleAdd.Location = new System.Drawing.Point(12, 12);
            this.GBoxRoleAdd.Name = "GBoxRoleAdd";
            this.GBoxRoleAdd.Size = new System.Drawing.Size(649, 70);
            this.GBoxRoleAdd.TabIndex = 1;
            this.GBoxRoleAdd.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nome do perfil";
            // 
            // TxtRole_Name
            // 
            this.TxtRole_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRole_Name.Location = new System.Drawing.Point(122, 27);
            this.TxtRole_Name.Name = "TxtRole_Name";
            this.TxtRole_Name.Size = new System.Drawing.Size(433, 23);
            this.TxtRole_Name.TabIndex = 1;
            // 
            // BtnRole_Add
            // 
            this.BtnRole_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRole_Add.Location = new System.Drawing.Point(505, 324);
            this.BtnRole_Add.Name = "BtnRole_Add";
            this.BtnRole_Add.Size = new System.Drawing.Size(156, 24);
            this.BtnRole_Add.TabIndex = 3;
            this.BtnRole_Add.Text = "Adicionar";
            this.BtnRole_Add.UseVisualStyleBackColor = true;
            this.BtnRole_Add.Click += new System.EventHandler(this.BtnRole_Add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGViewPermissions);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 224);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de permissões";
            // 
            // DGViewPermissions
            // 
            this.DGViewPermissions.AllowUserToAddRows = false;
            this.DGViewPermissions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGViewPermissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGViewPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGViewPermissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelect,
            this.ColFormCode,
            this.ColActionCode,
            this.ColName});
            this.DGViewPermissions.EnableHeadersVisualStyles = false;
            this.DGViewPermissions.Location = new System.Drawing.Point(15, 22);
            this.DGViewPermissions.Name = "DGViewPermissions";
            this.DGViewPermissions.RowHeadersVisible = false;
            this.DGViewPermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGViewPermissions.Size = new System.Drawing.Size(617, 185);
            this.DGViewPermissions.TabIndex = 3;
            // 
            // ColSelect
            // 
            this.ColSelect.FalseValue = "false";
            this.ColSelect.HeaderText = "";
            this.ColSelect.Name = "ColSelect";
            this.ColSelect.TrueValue = "true";
            this.ColSelect.Width = 30;
            // 
            // ColFormCode
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColFormCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColFormCode.HeaderText = "Código";
            this.ColFormCode.Name = "ColFormCode";
            // 
            // ColActionCode
            // 
            this.ColActionCode.HeaderText = "Acção";
            this.ColActionCode.Name = "ColActionCode";
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Nome";
            this.ColName.Name = "ColName";
            this.ColName.Width = 355;
            // 
            // RoleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnRole_Add);
            this.Controls.Add(this.GBoxRoleAdd);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RoleAdd";
            this.Text = "Adicionar Perfil de usuário";
            this.GBoxRoleAdd.ResumeLayout(false);
            this.GBoxRoleAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewPermissions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBoxRoleAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtRole_Name;
        private System.Windows.Forms.Button BtnRole_Add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGViewPermissions;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFormCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColActionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
    }
}