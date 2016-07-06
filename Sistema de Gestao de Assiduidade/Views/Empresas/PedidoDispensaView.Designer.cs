namespace mz.betainteractive.sigeas.Views.Empresas {
    partial class PedidoDispensaView {
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Paulo Roberto Filimone - (2016-04-20  à 2016-04-20)", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoDispensaView));
            this.cboFuncionarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoAusencias = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpToTime = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromTime = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkJustificada = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lvAusencias = new System.Windows.Forms.ListView();
            this.cboSearchFuncionarios = new System.Windows.Forms.ComboBox();
            this.dtpSearchFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSearchToDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btClean = new System.Windows.Forms.Button();
            this.listUsersImageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboFuncionarios
            // 
            this.cboFuncionarios.FormattingEnabled = true;
            this.cboFuncionarios.Location = new System.Drawing.Point(22, 36);
            this.cboFuncionarios.Name = "cboFuncionarios";
            this.cboFuncionarios.Size = new System.Drawing.Size(328, 21);
            this.cboFuncionarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Ausência/Falta";
            // 
            // cboTipoAusencias
            // 
            this.cboTipoAusencias.FormattingEnabled = true;
            this.cboTipoAusencias.Location = new System.Drawing.Point(22, 86);
            this.cboTipoAusencias.Name = "cboTipoAusencias";
            this.cboTipoAusencias.Size = new System.Drawing.Size(328, 21);
            this.cboTipoAusencias.TabIndex = 3;
            this.cboTipoAusencias.SelectedIndexChanged += new System.EventHandler(this.cboTipoAusencias_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpToTime);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.dtpFromTime);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Location = new System.Drawing.Point(19, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodo da ausência";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data Inicial";
            // 
            // dtpToTime
            // 
            this.dtpToTime.Enabled = false;
            this.dtpToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpToTime.Location = new System.Drawing.Point(179, 54);
            this.dtpToTime.Name = "dtpToTime";
            this.dtpToTime.ShowUpDown = true;
            this.dtpToTime.Size = new System.Drawing.Size(70, 20);
            this.dtpToTime.TabIndex = 13;
            this.dtpToTime.Value = new System.DateTime(2012, 9, 8, 23, 59, 0, 0);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(82, 54);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(91, 20);
            this.dtpToDate.TabIndex = 12;
            // 
            // dtpFromTime
            // 
            this.dtpFromTime.Enabled = false;
            this.dtpFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFromTime.Location = new System.Drawing.Point(179, 27);
            this.dtpFromTime.Name = "dtpFromTime";
            this.dtpFromTime.ShowUpDown = true;
            this.dtpFromTime.Size = new System.Drawing.Size(70, 20);
            this.dtpFromTime.TabIndex = 11;
            this.dtpFromTime.Value = new System.DateTime(2012, 9, 8, 0, 0, 0, 0);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(82, 27);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(91, 20);
            this.dtpFromDate.TabIndex = 10;
            this.dtpFromDate.Value = new System.DateTime(2016, 6, 22, 0, 0, 0, 0);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMotivo.Location = new System.Drawing.Point(22, 249);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(328, 112);
            this.txtMotivo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Motivo da Falta";
            // 
            // chkJustificada
            // 
            this.chkJustificada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkJustificada.AutoSize = true;
            this.chkJustificada.Location = new System.Drawing.Point(27, 381);
            this.chkJustificada.Name = "chkJustificada";
            this.chkJustificada.Size = new System.Drawing.Size(267, 17);
            this.chkJustificada.TabIndex = 7;
            this.chkJustificada.Text = "Falta Justificada (Não será considerado como falta)";
            this.chkJustificada.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chkJustificada);
            this.groupBox2.Controls.Add(this.cboFuncionarios);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMotivo);
            this.groupBox2.Controls.Add(this.cboTipoAusencias);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(319, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 418);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.Location = new System.Drawing.Point(338, 435);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(113, 23);
            this.btSave.TabIndex = 9;
            this.btSave.Text = "Registar";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Location = new System.Drawing.Point(577, 435);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(113, 23);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Fechar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lvAusencias
            // 
            this.lvAusencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAusencias.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAusencias.GridLines = true;
            this.lvAusencias.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvAusencias.LargeImageList = this.listUsersImageList;
            this.lvAusencias.Location = new System.Drawing.Point(16, 131);
            this.lvAusencias.Name = "lvAusencias";
            this.lvAusencias.Size = new System.Drawing.Size(273, 310);
            this.lvAusencias.SmallImageList = this.listUsersImageList;
            this.lvAusencias.TabIndex = 11;
            this.lvAusencias.UseCompatibleStateImageBehavior = false;
            this.lvAusencias.View = System.Windows.Forms.View.List;
            this.lvAusencias.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAusencias_MouseDoubleClick);
            // 
            // cboSearchFuncionarios
            // 
            this.cboSearchFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchFuncionarios.FormattingEnabled = true;
            this.cboSearchFuncionarios.Location = new System.Drawing.Point(16, 36);
            this.cboSearchFuncionarios.Name = "cboSearchFuncionarios";
            this.cboSearchFuncionarios.Size = new System.Drawing.Size(273, 21);
            this.cboSearchFuncionarios.TabIndex = 12;
            // 
            // dtpSearchFromDate
            // 
            this.dtpSearchFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchFromDate.Location = new System.Drawing.Point(16, 76);
            this.dtpSearchFromDate.Name = "dtpSearchFromDate";
            this.dtpSearchFromDate.Size = new System.Drawing.Size(108, 20);
            this.dtpSearchFromDate.TabIndex = 13;
            this.dtpSearchFromDate.Value = new System.DateTime(2016, 6, 22, 0, 0, 0, 0);
            // 
            // dtpSearchToDate
            // 
            this.dtpSearchToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSearchToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchToDate.Location = new System.Drawing.Point(174, 76);
            this.dtpSearchToDate.Name = "dtpSearchToDate";
            this.dtpSearchToDate.Size = new System.Drawing.Size(115, 20);
            this.dtpSearchToDate.TabIndex = 14;
            this.dtpSearchToDate.Value = new System.DateTime(2016, 6, 22, 0, 0, 0, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btSearch);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cboSearchFuncionarios);
            this.groupBox3.Controls.Add(this.lvAusencias);
            this.groupBox3.Controls.Add(this.dtpSearchToDate);
            this.groupBox3.Controls.Add(this.dtpSearchFromDate);
            this.groupBox3.Location = new System.Drawing.Point(8, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 458);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar";
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.Location = new System.Drawing.Point(16, 102);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(273, 23);
            this.btSearch.TabIndex = 18;
            this.btSearch.Text = "Pesquisar";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Para";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "De";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Funcionario";
            // 
            // btClean
            // 
            this.btClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClean.Location = new System.Drawing.Point(458, 435);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(113, 23);
            this.btClean.TabIndex = 16;
            this.btClean.Text = "Limpar";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // listUsersImageList
            // 
            this.listUsersImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listUsersImageList.ImageStream")));
            this.listUsersImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.listUsersImageList.Images.SetKeyName(0, "icon-door.png");
            this.listUsersImageList.Images.SetKeyName(1, "role_icon2.png");
            this.listUsersImageList.Images.SetKeyName(2, "users-icon.png");
            this.listUsersImageList.Images.SetKeyName(3, "users-icon2.png");
            // 
            // PedidoDispensaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 470);
            this.Controls.Add(this.btClean);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(717, 509);
            this.Name = "PedidoDispensaView";
            this.Text = "Pedido de Dispensa / Justificação de Faltas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PedidoDispensaView_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.PedidoDispensaView_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFuncionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipoAusencias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpToTime;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromTime;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkJustificada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ListView lvAusencias;
        private System.Windows.Forms.ComboBox cboSearchFuncionarios;
        private System.Windows.Forms.DateTimePicker dtpSearchFromDate;
        private System.Windows.Forms.DateTimePicker dtpSearchToDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.ImageList listUsersImageList;
    }
}