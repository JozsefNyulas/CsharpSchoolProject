namespace LoadMultipleFormInPanel
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btnRegister = new System.Windows.Forms.Button();
            this.labelPasswordRegist = new System.Windows.Forms.Label();
            this.txtPasswordRegist = new System.Windows.Forms.TextBox();
            this.labelNameRegist = new System.Windows.Forms.Label();
            this.txtNameRegist = new System.Windows.Forms.TextBox();
            this.labelPassworRetypeRegist = new System.Windows.Forms.Label();
            this.txtRePassRegist = new System.Windows.Forms.TextBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DimGray;
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegister.FlatAppearance.BorderSize = 2;
            this.btnRegister.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRegister.Location = new System.Drawing.Point(642, 640);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(106, 100);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnConfirmBmi_Click);
            // 
            // labelPasswordRegist
            // 
            this.labelPasswordRegist.BackColor = System.Drawing.Color.DimGray;
            this.labelPasswordRegist.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPasswordRegist.ForeColor = System.Drawing.Color.White;
            this.labelPasswordRegist.Location = new System.Drawing.Point(392, 477);
            this.labelPasswordRegist.Name = "labelPasswordRegist";
            this.labelPasswordRegist.Size = new System.Drawing.Size(231, 50);
            this.labelPasswordRegist.TabIndex = 12;
            this.labelPasswordRegist.Text = "Password:";
            this.labelPasswordRegist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPasswordRegist
            // 
            this.txtPasswordRegist.BackColor = System.Drawing.Color.DimGray;
            this.txtPasswordRegist.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasswordRegist.ForeColor = System.Drawing.Color.White;
            this.txtPasswordRegist.Location = new System.Drawing.Point(642, 477);
            this.txtPasswordRegist.MaximumSize = new System.Drawing.Size(500, 50);
            this.txtPasswordRegist.MinimumSize = new System.Drawing.Size(500, 50);
            this.txtPasswordRegist.Name = "txtPasswordRegist";
            this.txtPasswordRegist.PasswordChar = '*';
            this.txtPasswordRegist.Size = new System.Drawing.Size(500, 50);
            this.txtPasswordRegist.TabIndex = 13;
            this.txtPasswordRegist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNameRegist
            // 
            this.labelNameRegist.BackColor = System.Drawing.Color.DimGray;
            this.labelNameRegist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNameRegist.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNameRegist.ForeColor = System.Drawing.Color.White;
            this.labelNameRegist.Location = new System.Drawing.Point(392, 390);
            this.labelNameRegist.Name = "labelNameRegist";
            this.labelNameRegist.Size = new System.Drawing.Size(231, 50);
            this.labelNameRegist.TabIndex = 10;
            this.labelNameRegist.Text = "Name:";
            this.labelNameRegist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNameRegist
            // 
            this.txtNameRegist.BackColor = System.Drawing.Color.DimGray;
            this.txtNameRegist.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameRegist.ForeColor = System.Drawing.Color.White;
            this.txtNameRegist.Location = new System.Drawing.Point(642, 390);
            this.txtNameRegist.MaximumSize = new System.Drawing.Size(500, 50);
            this.txtNameRegist.MinimumSize = new System.Drawing.Size(500, 50);
            this.txtNameRegist.Name = "txtNameRegist";
            this.txtNameRegist.Size = new System.Drawing.Size(500, 50);
            this.txtNameRegist.TabIndex = 11;
            this.txtNameRegist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPassworRetypeRegist
            // 
            this.labelPassworRetypeRegist.BackColor = System.Drawing.Color.DimGray;
            this.labelPassworRetypeRegist.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassworRetypeRegist.ForeColor = System.Drawing.Color.White;
            this.labelPassworRetypeRegist.Location = new System.Drawing.Point(392, 564);
            this.labelPassworRetypeRegist.Name = "labelPassworRetypeRegist";
            this.labelPassworRetypeRegist.Size = new System.Drawing.Size(231, 50);
            this.labelPassworRetypeRegist.TabIndex = 15;
            this.labelPassworRetypeRegist.Text = "Re-Password:";
            this.labelPassworRetypeRegist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPassworRetypeRegist.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRePassRegist
            // 
            this.txtRePassRegist.BackColor = System.Drawing.Color.DimGray;
            this.txtRePassRegist.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRePassRegist.ForeColor = System.Drawing.Color.White;
            this.txtRePassRegist.Location = new System.Drawing.Point(642, 564);
            this.txtRePassRegist.MaximumSize = new System.Drawing.Size(500, 50);
            this.txtRePassRegist.MinimumSize = new System.Drawing.Size(500, 50);
            this.txtRePassRegist.Name = "txtRePassRegist";
            this.txtRePassRegist.PasswordChar = '*';
            this.txtRePassRegist.Size = new System.Drawing.Size(500, 50);
            this.txtRePassRegist.TabIndex = 16;
            this.txtRePassRegist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRePassRegist.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.DimGray;
            this.btnClearFields.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearFields.BackgroundImage")));
            this.btnClearFields.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearFields.FlatAppearance.BorderSize = 2;
            this.btnClearFields.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearFields.ForeColor = System.Drawing.Color.White;
            this.btnClearFields.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearFields.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClearFields.Location = new System.Drawing.Point(781, 640);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(106, 100);
            this.btnClearFields.TabIndex = 19;
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 1100);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.labelPassworRetypeRegist);
            this.Controls.Add(this.txtRePassRegist);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.labelPasswordRegist);
            this.Controls.Add(this.txtPasswordRegist);
            this.Controls.Add(this.labelNameRegist);
            this.Controls.Add(this.txtNameRegist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Register";
            this.Text = "Register";
            this.BackgroundImageChanged += new System.EventHandler(this.Register_BackgroundImageChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegister;
        private Label labelPasswordRegist;
        private TextBox txtPasswordRegist;
        private Label labelNameRegist;
        private TextBox txtNameRegist;
        private Label labelPassworRetypeRegist;
        private TextBox txtRePassRegist;
        private Button btnClearFields;
    }
}