namespace LoadMultipleFormInPanel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResults = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOptometry = new System.Windows.Forms.Button();
            this.btnHearing = new System.Windows.Forms.Button();
            this.btnBmi = new System.Windows.Forms.Button();
            this.btnCardiology = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DimGray;
            this.sidePanel.Controls.Add(this.btnLogin);
            this.sidePanel.Controls.Add(this.btnRegister);
            this.sidePanel.Controls.Add(this.panel1);
            this.sidePanel.Controls.Add(this.btnResults);
            this.sidePanel.Controls.Add(this.pictureBox1);
            this.sidePanel.Controls.Add(this.btnOptometry);
            this.sidePanel.Controls.Add(this.btnHearing);
            this.sidePanel.Controls.Add(this.btnBmi);
            this.sidePanel.Controls.Add(this.btnCardiology);
            resources.ApplyResources(this.sidePanel, "sidePanel");
            this.sidePanel.Name = "sidePanel";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnRegister, "btnRegister");
            this.btnRegister.FlatAppearance.BorderSize = 2;
            this.btnRegister.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnResults, "btnResults");
            this.btnResults.FlatAppearance.BorderSize = 2;
            this.btnResults.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResults.ForeColor = System.Drawing.Color.White;
            this.btnResults.Name = "btnResults";
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnOptometry
            // 
            this.btnOptometry.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnOptometry, "btnOptometry");
            this.btnOptometry.FlatAppearance.BorderSize = 2;
            this.btnOptometry.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOptometry.ForeColor = System.Drawing.Color.White;
            this.btnOptometry.Name = "btnOptometry";
            this.btnOptometry.UseVisualStyleBackColor = false;
            this.btnOptometry.Click += new System.EventHandler(this.btnOptometry_Click);
            // 
            // btnHearing
            // 
            this.btnHearing.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnHearing, "btnHearing");
            this.btnHearing.FlatAppearance.BorderSize = 2;
            this.btnHearing.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHearing.ForeColor = System.Drawing.Color.White;
            this.btnHearing.Name = "btnHearing";
            this.btnHearing.UseVisualStyleBackColor = false;
            this.btnHearing.Click += new System.EventHandler(this.btnHearing_Click);
            // 
            // btnBmi
            // 
            this.btnBmi.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnBmi, "btnBmi");
            this.btnBmi.FlatAppearance.BorderSize = 2;
            this.btnBmi.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBmi.ForeColor = System.Drawing.Color.White;
            this.btnBmi.Name = "btnBmi";
            this.btnBmi.UseVisualStyleBackColor = false;
            this.btnBmi.Click += new System.EventHandler(this.btnBmi_Click);
            // 
            // btnCardiology
            // 
            this.btnCardiology.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnCardiology, "btnCardiology");
            this.btnCardiology.FlatAppearance.BorderSize = 2;
            this.btnCardiology.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCardiology.ForeColor = System.Drawing.Color.White;
            this.btnCardiology.Name = "btnCardiology";
            this.btnCardiology.UseVisualStyleBackColor = false;
            this.btnCardiology.Click += new System.EventHandler(this.btnCardiology_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Gray;
            this.headerPanel.Controls.Add(this.btnClose);
            resources.ApplyResources(this.headerPanel, "headerPanel");
            this.headerPanel.Name = "headerPanel";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMain
            // 
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sidePanel;
        private Panel headerPanel;
        private Button btnResults;
        private PictureBox pictureBox1;
        private Button btnOptometry;
        private Button btnHearing;
        private Button btnBmi;
        private Button btnCardiology;
        private Button btnClose;
        private Panel panel1;
        private Panel panelMain;
        private Button btnLogin;
        private Button btnRegister;
    }
}