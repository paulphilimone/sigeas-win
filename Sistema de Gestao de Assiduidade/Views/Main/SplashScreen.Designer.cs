namespace mz.betainteractive.sigeas.Views.Main {
    partial class SplashScreen {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DetailsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Copyright = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ApplicationTitle = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.MainLayoutPanel.SuspendLayout();
            this.DetailsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainLayoutPanel.BackgroundImage")));
            this.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainLayoutPanel.ColumnCount = 2;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 449F));
            this.MainLayoutPanel.Controls.Add(this.DetailsLayoutPanel, 1, 4);
            this.MainLayoutPanel.Controls.Add(this.Label1, 1, 6);
            this.MainLayoutPanel.Controls.Add(this.ProgressBar, 1, 5);
            this.MainLayoutPanel.Controls.Add(this.ApplicationTitle, 1, 1);
            this.MainLayoutPanel.Controls.Add(this.Version, 1, 3);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 7;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(487, 282);
            this.MainLayoutPanel.TabIndex = 1;
            this.MainLayoutPanel.UseWaitCursor = true;
            // 
            // DetailsLayoutPanel
            // 
            this.DetailsLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.DetailsLayoutPanel.ColumnCount = 1;
            this.DetailsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 305F));
            this.DetailsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.DetailsLayoutPanel.Controls.Add(this.Copyright, 0, 1);
            this.DetailsLayoutPanel.Location = new System.Drawing.Point(101, 138);
            this.DetailsLayoutPanel.Name = "DetailsLayoutPanel";
            this.DetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.55932F));
            this.DetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.44068F));
            this.DetailsLayoutPanel.Size = new System.Drawing.Size(340, 118);
            this.DetailsLayoutPanel.TabIndex = 3;
            this.DetailsLayoutPanel.UseWaitCursor = true;
            // 
            // Copyright
            // 
            this.Copyright.BackColor = System.Drawing.Color.Transparent;
            this.Copyright.Dock = System.Windows.Forms.DockStyle.Top;
            this.Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copyright.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Copyright.Location = new System.Drawing.Point(3, 15);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(334, 20);
            this.Copyright.TabIndex = 2;
            this.Copyright.Text = "Produzido e distribuido por Beta Interactive Lda";
            this.Copyright.UseWaitCursor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Label1.Location = new System.Drawing.Point(50, 285);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(126, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Carregando o Sistema ....";
            this.Label1.UseWaitCursor = true;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(182, 268);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(311, 12);
            this.ProgressBar.Step = 1;
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 4;
            this.ProgressBar.UseWaitCursor = true;
            // 
            // ApplicationTitle
            // 
            this.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ApplicationTitle.BackColor = System.Drawing.Color.MidnightBlue;
            this.ApplicationTitle.Font = new System.Drawing.Font("Arial Narrow", 17.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationTitle.ForeColor = System.Drawing.Color.NavajoWhite;
            this.ApplicationTitle.Location = new System.Drawing.Point(68, 32);
            this.ApplicationTitle.Name = "ApplicationTitle";
            this.ApplicationTitle.Size = new System.Drawing.Size(407, 31);
            this.ApplicationTitle.TabIndex = 2;
            this.ApplicationTitle.Text = "Sistema de Gestao de Assiduidade";
            this.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ApplicationTitle.UseWaitCursor = true;
            this.ApplicationTitle.Visible = false;
            this.ApplicationTitle.Click += new System.EventHandler(this.ApplicationTitle_Click);
            // 
            // Version
            // 
            this.Version.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.Font = new System.Drawing.Font("Segoe Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.ForeColor = System.Drawing.Color.LightCyan;
            this.Version.Location = new System.Drawing.Point(103, 107);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(337, 20);
            this.Version.TabIndex = 1;
            this.Version.Text = "Beta Interactive Lda - Sigeas 0.1";
            this.Version.UseWaitCursor = true;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 282);
            this.Controls.Add(this.MainLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Shown += new System.EventHandler(this.SplashScreen_Shown);
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            this.DetailsLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        internal System.Windows.Forms.TableLayoutPanel DetailsLayoutPanel;
        internal System.Windows.Forms.Label Copyright;
        internal System.Windows.Forms.Label ApplicationTitle;
        internal System.Windows.Forms.Label Version;
        internal System.Windows.Forms.Label Label1;
        public System.Windows.Forms.ProgressBar ProgressBar;
    }
}