namespace mz.betainteractive.sigeas.Views.DeviceManagement {
    partial class DeviceAdd {
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BtnTestConnection = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtSerialNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBoxComPort = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtIPAddress = new IPAddressControlLib.IPAddressControl();
            this.TxtIpPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.RbUSB = new System.Windows.Forms.RadioButton();
            this.RbRS = new System.Windows.Forms.RadioButton();
            this.RbTCP = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ipAddressControl1 = new IPAddressControlLib.IPAddressControl();
            this.CBoxDeviceType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(173, 414);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 23);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Adicionar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.BtnCancel);
            this.panel4.Controls.Add(this.groupBox7);
            this.panel4.Controls.Add(this.BtnAdd);
            this.panel4.Controls.Add(this.groupBox6);
            this.panel4.Controls.Add(this.groupBox5);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(379, 450);
            this.panel4.TabIndex = 4;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(276, 414);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(88, 23);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.BtnTestConnection);
            this.groupBox7.Controls.Add(this.panel3);
            this.groupBox7.Controls.Add(this.panel2);
            this.groupBox7.Controls.Add(this.panel1);
            this.groupBox7.Location = new System.Drawing.Point(15, 197);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(349, 211);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            // 
            // BtnTestConnection
            // 
            this.BtnTestConnection.Location = new System.Drawing.Point(181, 178);
            this.BtnTestConnection.Name = "BtnTestConnection";
            this.BtnTestConnection.Size = new System.Drawing.Size(147, 23);
            this.BtnTestConnection.TabIndex = 7;
            this.BtnTestConnection.Text = "Testar conexão";
            this.BtnTestConnection.UseVisualStyleBackColor = true;
            this.BtnTestConnection.Click += new System.EventHandler(this.BtnTestConnection_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.TxtSerialNumber);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(19, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 43);
            this.panel3.TabIndex = 2;
            // 
            // TxtSerialNumber
            // 
            this.TxtSerialNumber.Location = new System.Drawing.Point(102, 8);
            this.TxtSerialNumber.Name = "TxtSerialNumber";
            this.TxtSerialNumber.ReadOnly = true;
            this.TxtSerialNumber.Size = new System.Drawing.Size(178, 20);
            this.TxtSerialNumber.TabIndex = 5;
            this.TxtSerialNumber.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TxtSerialNumber_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
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
            this.panel2.Location = new System.Drawing.Point(19, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 43);
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
            this.CBoxBaudRate.Location = new System.Drawing.Point(215, 11);
            this.CBoxBaudRate.Name = "CBoxBaudRate";
            this.CBoxBaudRate.Size = new System.Drawing.Size(65, 21);
            this.CBoxBaudRate.TabIndex = 4;
            this.CBoxBaudRate.Text = "115200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
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
            this.CBoxComPort.TabIndex = 3;
            this.CBoxComPort.Text = "COM1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Taxa de trans.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TxtIPAddress);
            this.panel1.Controls.Add(this.TxtIpPort);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(19, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 43);
            this.panel1.TabIndex = 0;
            // 
            // TxtIPAddress
            // 
            this.TxtIPAddress.AllowInternalTab = false;
            this.TxtIPAddress.AutoHeight = true;
            this.TxtIPAddress.BackColor = System.Drawing.SystemColors.Window;
            this.TxtIPAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtIPAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtIPAddress.Location = new System.Drawing.Point(36, 11);
            this.TxtIPAddress.MinimumSize = new System.Drawing.Size(87, 20);
            this.TxtIPAddress.Name = "TxtIPAddress";
            this.TxtIPAddress.ReadOnly = false;
            this.TxtIPAddress.Size = new System.Drawing.Size(145, 20);
            this.TxtIPAddress.TabIndex = 1;
            this.TxtIPAddress.Text = "192.168.1.201";
            // 
            // TxtIpPort
            // 
            this.TxtIpPort.Location = new System.Drawing.Point(224, 11);
            this.TxtIpPort.Name = "TxtIpPort";
            this.TxtIpPort.Size = new System.Drawing.Size(56, 20);
            this.TxtIpPort.TabIndex = 2;
            this.TxtIpPort.Text = "4370";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Porta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.RbUSB);
            this.groupBox6.Controls.Add(this.RbRS);
            this.groupBox6.Controls.Add(this.RbTCP);
            this.groupBox6.Location = new System.Drawing.Point(15, 121);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(349, 73);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tipo de Conexão";
            // 
            // RbUSB
            // 
            this.RbUSB.AutoSize = true;
            this.RbUSB.Location = new System.Drawing.Point(254, 31);
            this.RbUSB.Name = "RbUSB";
            this.RbUSB.Size = new System.Drawing.Size(47, 17);
            this.RbUSB.TabIndex = 2;
            this.RbUSB.Text = "USB";
            this.RbUSB.UseVisualStyleBackColor = true;
            // 
            // RbRS
            // 
            this.RbRS.AutoSize = true;
            this.RbRS.Location = new System.Drawing.Point(138, 31);
            this.RbRS.Name = "RbRS";
            this.RbRS.Size = new System.Drawing.Size(81, 17);
            this.RbRS.TabIndex = 1;
            this.RbRS.Text = "RS232/485";
            this.RbRS.UseVisualStyleBackColor = true;
            // 
            // RbTCP
            // 
            this.RbTCP.AutoSize = true;
            this.RbTCP.Checked = true;
            this.RbTCP.Location = new System.Drawing.Point(40, 31);
            this.RbTCP.Name = "RbTCP";
            this.RbTCP.Size = new System.Drawing.Size(61, 17);
            this.RbTCP.TabIndex = 0;
            this.RbTCP.TabStop = true;
            this.RbTCP.Text = "TCP/IP";
            this.RbTCP.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CBoxDeviceType);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.TxtName);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(15, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(349, 92);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(129, 24);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(187, 20);
            this.TxtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome do dispositivo";
            // 
            // ipAddressControl1
            // 
            this.ipAddressControl1.AllowInternalTab = false;
            this.ipAddressControl1.AutoHeight = true;
            this.ipAddressControl1.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControl1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControl1.Location = new System.Drawing.Point(36, 11);
            this.ipAddressControl1.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipAddressControl1.Name = "ipAddressControl1";
            this.ipAddressControl1.ReadOnly = false;
            this.ipAddressControl1.Size = new System.Drawing.Size(145, 20);
            this.ipAddressControl1.TabIndex = 3;
            this.ipAddressControl1.Text = "...";
            // 
            // CBoxDeviceType
            // 
            this.CBoxDeviceType.FormattingEnabled = true;
            this.CBoxDeviceType.Location = new System.Drawing.Point(129, 55);
            this.CBoxDeviceType.Name = "CBoxDeviceType";
            this.CBoxDeviceType.Size = new System.Drawing.Size(187, 21);
            this.CBoxDeviceType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de dispositivo";
            // 
            // DeviceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DeviceAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar Biometrico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeviceAdd_FormClosing);
            this.panel4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button BtnTestConnection;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton RbUSB;
        private System.Windows.Forms.RadioButton RbRS;
        private System.Windows.Forms.RadioButton RbTCP;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private IPAddressControlLib.IPAddressControl TxtIPAddress;
        private IPAddressControlLib.IPAddressControl ipAddressControl1;
        private System.Windows.Forms.ComboBox CBoxDeviceType;
        private System.Windows.Forms.Label label3;
        
    }
}