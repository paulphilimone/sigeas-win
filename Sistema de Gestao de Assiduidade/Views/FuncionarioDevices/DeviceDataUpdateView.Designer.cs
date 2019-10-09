namespace mz.betainteractive.sigeas.Views.FuncionarioDevices {
    partial class DeviceDataUpdateView {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelDeviceConnected = new System.Windows.Forms.Label();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CBoxDevices = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtDeviceDoor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSerialNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDownloadClocks = new System.Windows.Forms.Button();
            this.BtnClearUserClock = new System.Windows.Forms.Button();
            this.BtnUpdateUsers = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LabelDeviceConnected);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(488, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 26);
            this.panel1.TabIndex = 23;
            // 
            // LabelDeviceConnected
            // 
            this.LabelDeviceConnected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDeviceConnected.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeviceConnected.ForeColor = System.Drawing.Color.BlueViolet;
            this.LabelDeviceConnected.Location = new System.Drawing.Point(0, 0);
            this.LabelDeviceConnected.Name = "LabelDeviceConnected";
            this.LabelDeviceConnected.Size = new System.Drawing.Size(119, 22);
            this.LabelDeviceConnected.TabIndex = 0;
            this.LabelDeviceConnected.Text = "Desconectado";
            this.LabelDeviceConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Enabled = false;
            this.BtnConnect.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnect.Location = new System.Drawing.Point(322, 32);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(160, 24);
            this.BtnConnect.TabIndex = 21;
            this.BtnConnect.Text = "Conectar Dispositivo";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Biométrico";
            // 
            // CBoxDevices
            // 
            this.CBoxDevices.FormattingEnabled = true;
            this.CBoxDevices.ItemHeight = 13;
            this.CBoxDevices.Location = new System.Drawing.Point(87, 35);
            this.CBoxDevices.Name = "CBoxDevices";
            this.CBoxDevices.Size = new System.Drawing.Size(229, 21);
            this.CBoxDevices.TabIndex = 20;
            this.CBoxDevices.SelectedIndexChanged += new System.EventHandler(this.CBoxDevices_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.CBoxDevices);
            this.groupBox1.Controls.Add(this.BtnConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 149);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dispositivo Biométrico";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TxtDeviceDoor);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxtSerialNumber);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(19, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 54);
            this.panel2.TabIndex = 24;
            // 
            // TxtDeviceDoor
            // 
            this.TxtDeviceDoor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDeviceDoor.Location = new System.Drawing.Point(403, 15);
            this.TxtDeviceDoor.Name = "TxtDeviceDoor";
            this.TxtDeviceDoor.ReadOnly = true;
            this.TxtDeviceDoor.Size = new System.Drawing.Size(170, 22);
            this.TxtDeviceDoor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Porta";
            // 
            // TxtSerialNumber
            // 
            this.TxtSerialNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSerialNumber.Location = new System.Drawing.Point(119, 15);
            this.TxtSerialNumber.Name = "TxtSerialNumber";
            this.TxtSerialNumber.ReadOnly = true;
            this.TxtSerialNumber.Size = new System.Drawing.Size(158, 22);
            this.TxtSerialNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Série";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDownloadClocks);
            this.groupBox2.Controls.Add(this.BtnClearUserClock);
            this.groupBox2.Controls.Add(this.BtnUpdateUsers);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 100);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // BtnDownloadClocks
            // 
            this.BtnDownloadClocks.Location = new System.Drawing.Point(423, 39);
            this.BtnDownloadClocks.Name = "BtnDownloadClocks";
            this.BtnDownloadClocks.Size = new System.Drawing.Size(200, 31);
            this.BtnDownloadClocks.TabIndex = 2;
            this.BtnDownloadClocks.Text = "Download Registos de Ent/Saida";
            this.BtnDownloadClocks.UseVisualStyleBackColor = true;
            this.BtnDownloadClocks.Click += new System.EventHandler(this.BtnDownloadClocks_Click);
            // 
            // BtnClearUserClock
            // 
            this.BtnClearUserClock.Location = new System.Drawing.Point(216, 39);
            this.BtnClearUserClock.Name = "BtnClearUserClock";
            this.BtnClearUserClock.Size = new System.Drawing.Size(200, 31);
            this.BtnClearUserClock.TabIndex = 1;
            this.BtnClearUserClock.Text = "Apagar Registos de Ent/Saida";
            this.BtnClearUserClock.UseVisualStyleBackColor = true;
            this.BtnClearUserClock.Click += new System.EventHandler(this.BtnClearUserClock_Click);
            // 
            // BtnUpdateUsers
            // 
            this.BtnUpdateUsers.Location = new System.Drawing.Point(8, 39);
            this.BtnUpdateUsers.Name = "BtnUpdateUsers";
            this.BtnUpdateUsers.Size = new System.Drawing.Size(200, 31);
            this.BtnUpdateUsers.TabIndex = 0;
            this.BtnUpdateUsers.Text = "Atualizar Usuários no dispositivo";
            this.BtnUpdateUsers.UseVisualStyleBackColor = true;
            this.BtnUpdateUsers.Click += new System.EventHandler(this.BtnUpdateUsers_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(491, 275);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(138, 32);
            this.BtnClose.TabIndex = 26;
            this.BtnClose.Text = "Fechar";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // DeviceDataUpdateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(654, 314);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DeviceDataUpdateView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registar Funcionários nos Dispositivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeviceDataUpdateView_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.DeviceDataUpdateView_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelDeviceConnected;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBoxDevices;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnUpdateUsers;
        private System.Windows.Forms.Button BtnClearUserClock;
        private System.Windows.Forms.Button BtnDownloadClocks;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSerialNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDeviceDoor;
    }
}