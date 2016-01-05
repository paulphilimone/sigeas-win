namespace mz.betainteractive.sigeas.Views.Main {
    partial class LoginView {
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Sisga Programmers", 2);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Paulo Filimone", 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.ListViewUsuarios = new System.Windows.Forms.ListView();
            this.listUsersImageList = new System.Windows.Forms.ImageList(this.components);
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.PasswordTextBox);
            this.GroupBox2.Controls.Add(this.PasswordLabel);
            this.GroupBox2.Controls.Add(this.UsernameTextBox);
            this.GroupBox2.Location = new System.Drawing.Point(172, 157);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(330, 56);
            this.GroupBox2.TabIndex = 7;
            this.GroupBox2.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(43, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Usuário";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(214, 22);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(98, 20);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextBox_KeyPress);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(171, 19);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(46, 23);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "&Senha";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.UsernameTextBox.Location = new System.Drawing.Point(57, 21);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.ReadOnly = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(105, 21);
            this.UsernameTextBox.TabIndex = 1;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btCancel);
            this.GroupBox1.Controls.Add(this.btOK);
            this.GroupBox1.Location = new System.Drawing.Point(172, 212);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(330, 55);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btCancel.Location = new System.Drawing.Point(173, 19);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(107, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "&Sair";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOK
            // 
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btOK.Location = new System.Drawing.Point(51, 19);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(107, 23);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "&Entrar";
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // ListViewUsuarios
            // 
            this.ListViewUsuarios.BackgroundImageTiled = true;
            this.ListViewUsuarios.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewUsuarios.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ListViewUsuarios.FullRowSelect = true;
            this.ListViewUsuarios.HideSelection = false;
            this.ListViewUsuarios.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.ListViewUsuarios.LargeImageList = this.listUsersImageList;
            this.ListViewUsuarios.Location = new System.Drawing.Point(172, 4);
            this.ListViewUsuarios.MultiSelect = false;
            this.ListViewUsuarios.Name = "ListViewUsuarios";
            this.ListViewUsuarios.Size = new System.Drawing.Size(330, 148);
            this.ListViewUsuarios.TabIndex = 6;
            this.ListViewUsuarios.UseCompatibleStateImageBehavior = false;
            this.ListViewUsuarios.View = System.Windows.Forms.View.Tile;
            this.ListViewUsuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewUsuarios_MouseDoubleClick);
            // 
            // listUsersImageList
            // 
            this.listUsersImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listUsersImageList.ImageStream")));
            this.listUsersImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.listUsersImageList.Images.SetKeyName(0, "users-icon.png");
            this.listUsersImageList.Images.SetKeyName(1, "globe.png");
            this.listUsersImageList.Images.SetKeyName(2, "users-icon2.png");
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackgroundImage = global::mz.betainteractive.sigeas.Properties.Resources.Imagem_de_um_glogo_terrestre_num_ambiente_azul1;
            this.LogoPictureBox.InitialImage = null;
            this.LogoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(165, 267);
            this.LogoPictureBox.TabIndex = 5;
            this.LogoPictureBox.TabStop = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(508, 272);
            this.ControlBox = false;
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.ListViewUsuarios);
            this.Controls.Add(this.LogoPictureBox);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginView_FormClosed);
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.Shown += new System.EventHandler(this.FrmLogin_Shown);
            this.VisibleChanged += new System.EventHandler(this.LoginView_VisibleChanged);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox PasswordTextBox;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.TextBox UsernameTextBox;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btCancel;
        internal System.Windows.Forms.Button btOK;
        internal System.Windows.Forms.ListView ListViewUsuarios;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.ImageList listUsersImageList;
    }
}