namespace mz.betainteractive.sigeas.bpkgenerator.Views {
    partial class FrmGenerateKey {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerateKey));
            this.gBCommunication = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelConState = new System.Windows.Forms.Label();
            this.btEditBio_TestConnection1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtSerialNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBoxComPort = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtIpPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtIPAddress = new IPAddressControlLib.IPAddressControl();
            this.label4 = new System.Windows.Forms.Label();
            this.gBConnections = new System.Windows.Forms.GroupBox();
            this.RbUSB = new System.Windows.Forms.RadioButton();
            this.RbRS = new System.Windows.Forms.RadioButton();
            this.RbTCP = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMKey = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btCreateFile = new System.Windows.Forms.Button();
            this.btGenerate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.FormSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.FormOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.gBCommunication.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gBConnections.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBCommunication
            // 
            this.gBCommunication.Controls.Add(this.panel4);
            this.gBCommunication.Controls.Add(this.btEditBio_TestConnection1);
            this.gBCommunication.Controls.Add(this.panel3);
            this.gBCommunication.Controls.Add(this.panel2);
            this.gBCommunication.Controls.Add(this.panel1);
            this.gBCommunication.Enabled = false;
            this.gBCommunication.Location = new System.Drawing.Point(10, 57);
            this.gBCommunication.Name = "gBCommunication";
            this.gBCommunication.Size = new System.Drawing.Size(293, 196);
            this.gBCommunication.TabIndex = 4;
            this.gBCommunication.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Bisque;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.labelConState);
            this.panel4.Location = new System.Drawing.Point(19, 167);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(103, 23);
            this.panel4.TabIndex = 4;
            // 
            // labelConState
            // 
            this.labelConState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelConState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConState.Location = new System.Drawing.Point(0, 0);
            this.labelConState.Name = "labelConState";
            this.labelConState.Size = new System.Drawing.Size(99, 19);
            this.labelConState.TabIndex = 0;
            this.labelConState.Text = "Desconectado";
            this.labelConState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btEditBio_TestConnection1
            // 
            this.btEditBio_TestConnection1.Location = new System.Drawing.Point(128, 167);
            this.btEditBio_TestConnection1.Name = "btEditBio_TestConnection1";
            this.btEditBio_TestConnection1.Size = new System.Drawing.Size(147, 23);
            this.btEditBio_TestConnection1.TabIndex = 3;
            this.btEditBio_TestConnection1.Text = "Conectar";
            this.btEditBio_TestConnection1.UseVisualStyleBackColor = true;
            this.btEditBio_TestConnection1.Click += new System.EventHandler(this.btEditBio_TestConnection1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.TxtSerialNumber);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(19, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 43);
            this.panel3.TabIndex = 2;
            // 
            // TxtSerialNumber
            // 
            this.TxtSerialNumber.Location = new System.Drawing.Point(102, 8);
            this.TxtSerialNumber.Name = "TxtSerialNumber";
            this.TxtSerialNumber.ReadOnly = true;
            this.TxtSerialNumber.Size = new System.Drawing.Size(140, 22);
            this.TxtSerialNumber.TabIndex = 1;
            this.TxtSerialNumber.TextChanged += new System.EventHandler(this.txtEditBio_SN1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Número de série";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.CBoxBaudRate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CBoxComPort);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(19, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 43);
            this.panel2.TabIndex = 1;
            // 
            // CBoxBaudRate
            // 
            this.CBoxBaudRate.FormattingEnabled = true;
            this.CBoxBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.CBoxBaudRate.Location = new System.Drawing.Point(177, 11);
            this.CBoxBaudRate.Name = "CBoxBaudRate";
            this.CBoxBaudRate.Size = new System.Drawing.Size(65, 21);
            this.CBoxBaudRate.TabIndex = 10;
            this.CBoxBaudRate.Text = "115200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Porta";
            // 
            // CBoxComPort
            // 
            this.CBoxComPort.FormattingEnabled = true;
            this.CBoxComPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.CBoxComPort.Location = new System.Drawing.Point(47, 11);
            this.CBoxComPort.Name = "CBoxComPort";
            this.CBoxComPort.Size = new System.Drawing.Size(56, 21);
            this.CBoxComPort.TabIndex = 9;
            this.CBoxComPort.Text = "COM1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "BaudRate";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TxtIpPort);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtIPAddress);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(19, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 43);
            this.panel1.TabIndex = 0;
            // 
            // TxtIpPort
            // 
            this.TxtIpPort.Location = new System.Drawing.Point(187, 11);
            this.TxtIpPort.Name = "TxtIpPort";
            this.TxtIpPort.Size = new System.Drawing.Size(56, 22);
            this.TxtIpPort.TabIndex = 3;
            this.TxtIpPort.Text = "4370";
            this.TxtIpPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Porta";
            // 
            // TxtIPAddress
            // 
            this.TxtIPAddress.AllowInternalTab = false;
            this.TxtIPAddress.AutoHeight = true;
            this.TxtIPAddress.BackColor = System.Drawing.SystemColors.Window;
            this.TxtIPAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtIPAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtIPAddress.Location = new System.Drawing.Point(36, 11);
            this.TxtIPAddress.MinimumSize = new System.Drawing.Size(87, 22);
            this.TxtIPAddress.Name = "TxtIPAddress";
            this.TxtIPAddress.ReadOnly = false;
            this.TxtIPAddress.Size = new System.Drawing.Size(104, 22);
            this.TxtIPAddress.TabIndex = 1;
            this.TxtIPAddress.Text = "192.168.1.201";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP";
            // 
            // gBConnections
            // 
            this.gBConnections.Controls.Add(this.RbUSB);
            this.gBConnections.Controls.Add(this.RbRS);
            this.gBConnections.Controls.Add(this.RbTCP);
            this.gBConnections.Enabled = false;
            this.gBConnections.Location = new System.Drawing.Point(10, 7);
            this.gBConnections.Name = "gBConnections";
            this.gBConnections.Size = new System.Drawing.Size(294, 47);
            this.gBConnections.TabIndex = 3;
            this.gBConnections.TabStop = false;
            // 
            // RbUSB
            // 
            this.RbUSB.AutoSize = true;
            this.RbUSB.Location = new System.Drawing.Point(230, 19);
            this.RbUSB.Name = "RbUSB";
            this.RbUSB.Size = new System.Drawing.Size(46, 17);
            this.RbUSB.TabIndex = 2;
            this.RbUSB.Text = "USB";
            this.RbUSB.UseVisualStyleBackColor = true;
            // 
            // RbRS
            // 
            this.RbRS.AutoSize = true;
            this.RbRS.Location = new System.Drawing.Point(114, 19);
            this.RbRS.Name = "RbRS";
            this.RbRS.Size = new System.Drawing.Size(79, 17);
            this.RbRS.TabIndex = 1;
            this.RbRS.Text = "RS232/485";
            this.RbRS.UseVisualStyleBackColor = true;
            // 
            // RbTCP
            // 
            this.RbTCP.AutoSize = true;
            this.RbTCP.Checked = true;
            this.RbTCP.Location = new System.Drawing.Point(16, 19);
            this.RbTCP.Name = "RbTCP";
            this.RbTCP.Size = new System.Drawing.Size(58, 17);
            this.RbTCP.TabIndex = 0;
            this.RbTCP.TabStop = true;
            this.RbTCP.Text = "TCP/IP";
            this.RbTCP.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMKey);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtCompany);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(309, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 139);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Key";
            // 
            // txtMKey
            // 
            this.txtMKey.Location = new System.Drawing.Point(92, 47);
            this.txtMKey.Mask = "AAAA - AAAA - AAAA - AAAA - AAAA - AAAA - AAAA - AAAA";
            this.txtMKey.Name = "txtMKey";
            this.txtMKey.ReadOnly = true;
            this.txtMKey.Size = new System.Drawing.Size(305, 22);
            this.txtMKey.TabIndex = 2;
            this.txtMKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMKey.TextChanged += new System.EventHandler(this.txtMKey_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.btCreateFile);
            this.groupBox3.Controls.Add(this.btGenerate);
            this.groupBox3.Location = new System.Drawing.Point(114, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 57);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btCreateFile
            // 
            this.btCreateFile.Enabled = false;
            this.btCreateFile.Location = new System.Drawing.Point(154, 19);
            this.btCreateFile.Name = "btCreateFile";
            this.btCreateFile.Size = new System.Drawing.Size(90, 23);
            this.btCreateFile.TabIndex = 5;
            this.btCreateFile.Text = "Create Key File";
            this.btCreateFile.UseVisualStyleBackColor = true;
            this.btCreateFile.Click += new System.EventHandler(this.btCreateFile_Click);
            // 
            // btGenerate
            // 
            this.btGenerate.Enabled = false;
            this.btGenerate.Location = new System.Drawing.Point(55, 19);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(92, 23);
            this.btGenerate.TabIndex = 4;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(21, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "End Project";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(92, 21);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(305, 22);
            this.txtCompany.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEncrypted);
            this.groupBox2.Location = new System.Drawing.Point(310, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 101);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Encrypted";
            this.label3.Visible = false;
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(87, 75);
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(235, 22);
            this.txtEncrypted.TabIndex = 0;
            this.txtEncrypted.Visible = false;
            // 
            // FormSaveFile
            // 
            this.FormSaveFile.DefaultExt = "btskey";
            this.FormSaveFile.Title = "Guardar Ficheiro";
            // 
            // FormOpenFile
            // 
            this.FormOpenFile.DefaultExt = "btskey";
            this.FormOpenFile.Filter = "Sisga Keys (*.btskey)|";
            this.FormOpenFile.Title = "Abrir Ficheiro";
            // 
            // FrmGenerateKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(729, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBCommunication);
            this.Controls.Add(this.gBConnections);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmGenerateKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de chaves de acesso ao biométrico 9/01";
            this.Load += new System.EventHandler(this.FrmGenerateKey_Load);
            this.gBCommunication.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBConnections.ResumeLayout(false);
            this.gBConnections.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBCommunication;
        private System.Windows.Forms.Button btEditBio_TestConnection1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtSerialNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CBoxBaudRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBoxComPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtIpPort;
        private System.Windows.Forms.Label label7;
        private IPAddressControlLib.IPAddressControl TxtIPAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gBConnections;
        private System.Windows.Forms.RadioButton RbUSB;
        private System.Windows.Forms.RadioButton RbRS;
        private System.Windows.Forms.RadioButton RbTCP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.Button btCreateFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelConState;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SaveFileDialog FormSaveFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.MaskedTextBox txtMKey;
        private System.Windows.Forms.OpenFileDialog FormOpenFile;
        private System.Windows.Forms.Button button3;
    }
}

