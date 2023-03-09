namespace LoadMultipleFormInPanel
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnClearFieldsLogin = new System.Windows.Forms.Button();
            this.btnConfirmBmi = new System.Windows.Forms.Button();
            this.labelNameLogin = new System.Windows.Forms.Label();
            this.txtNameLogin = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Results = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelFinalResult = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearFieldsLogin
            // 
            this.btnClearFieldsLogin.BackColor = System.Drawing.Color.DimGray;
            this.btnClearFieldsLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearFieldsLogin.BackgroundImage")));
            this.btnClearFieldsLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearFieldsLogin.FlatAppearance.BorderSize = 2;
            this.btnClearFieldsLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearFieldsLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFieldsLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearFieldsLogin.ForeColor = System.Drawing.Color.White;
            this.btnClearFieldsLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearFieldsLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClearFieldsLogin.Location = new System.Drawing.Point(685, 229);
            this.btnClearFieldsLogin.Name = "btnClearFieldsLogin";
            this.btnClearFieldsLogin.Size = new System.Drawing.Size(106, 100);
            this.btnClearFieldsLogin.TabIndex = 27;
            this.btnClearFieldsLogin.UseVisualStyleBackColor = false;
            this.btnClearFieldsLogin.Click += new System.EventHandler(this.btnClearFieldsLogin_Click);
            // 
            // btnConfirmBmi
            // 
            this.btnConfirmBmi.BackColor = System.Drawing.Color.DimGray;
            this.btnConfirmBmi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmBmi.BackgroundImage")));
            this.btnConfirmBmi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmBmi.FlatAppearance.BorderSize = 2;
            this.btnConfirmBmi.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirmBmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmBmi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmBmi.ForeColor = System.Drawing.Color.White;
            this.btnConfirmBmi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmBmi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfirmBmi.Location = new System.Drawing.Point(536, 229);
            this.btnConfirmBmi.Name = "btnConfirmBmi";
            this.btnConfirmBmi.Size = new System.Drawing.Size(106, 100);
            this.btnConfirmBmi.TabIndex = 24;
            this.btnConfirmBmi.UseVisualStyleBackColor = false;
            this.btnConfirmBmi.Click += new System.EventHandler(this.btnConfirmBmi_Click);
            // 
            // labelNameLogin
            // 
            this.labelNameLogin.BackColor = System.Drawing.Color.DimGray;
            this.labelNameLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNameLogin.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNameLogin.ForeColor = System.Drawing.Color.White;
            this.labelNameLogin.Location = new System.Drawing.Point(344, 151);
            this.labelNameLogin.Name = "labelNameLogin";
            this.labelNameLogin.Size = new System.Drawing.Size(231, 50);
            this.labelNameLogin.TabIndex = 20;
            this.labelNameLogin.Text = "Name:";
            this.labelNameLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNameLogin
            // 
            this.txtNameLogin.BackColor = System.Drawing.Color.DimGray;
            this.txtNameLogin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameLogin.ForeColor = System.Drawing.Color.White;
            this.txtNameLogin.Location = new System.Drawing.Point(594, 151);
            this.txtNameLogin.MaximumSize = new System.Drawing.Size(500, 50);
            this.txtNameLogin.MinimumSize = new System.Drawing.Size(500, 50);
            this.txtNameLogin.Name = "txtNameLogin";
            this.txtNameLogin.Size = new System.Drawing.Size(500, 50);
            this.txtNameLogin.TabIndex = 21;
            this.txtNameLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nev,
            this.Results});
            this.dataGridView1.Location = new System.Drawing.Point(12, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(1484, 259);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nev
            // 
            this.Nev.FillWeight = 1000F;
            this.Nev.HeaderText = "Nev";
            this.Nev.MinimumWidth = 10;
            this.Nev.Name = "Nev";
            this.Nev.ReadOnly = true;
            this.Nev.Width = 200;
            // 
            // Results
            // 
            this.Results.FillWeight = 1000F;
            this.Results.HeaderText = "Results";
            this.Results.MinimumWidth = 10;
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.Width = 1200;
            // 
            // labelFinalResult
            // 
            this.labelFinalResult.AutoSize = true;
            this.labelFinalResult.BackColor = System.Drawing.Color.DimGray;
            this.labelFinalResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFinalResult.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFinalResult.ForeColor = System.Drawing.Color.White;
            this.labelFinalResult.Location = new System.Drawing.Point(536, 697);
            this.labelFinalResult.Name = "labelFinalResult";
            this.labelFinalResult.Size = new System.Drawing.Size(2, 44);
            this.labelFinalResult.TabIndex = 29;
            this.labelFinalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(489, 624);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(407, 292);
            this.pictureBox.TabIndex = 30;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 1100);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelFinalResult);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClearFieldsLogin);
            this.Controls.Add(this.btnConfirmBmi);
            this.Controls.Add(this.labelNameLogin);
            this.Controls.Add(this.txtNameLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClearFieldsLogin;
        private Button btnConfirmBmi;
        private Label labelNameLogin;
        private TextBox txtNameLogin;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nev;
        private DataGridViewTextBoxColumn Results;
        private Label labelFinalResult;
        private PictureBox pictureBox;
    }
}