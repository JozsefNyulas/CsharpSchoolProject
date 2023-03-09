namespace LoadMultipleFormInPanel
{
    partial class BmiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BmiForm));
            this.labelHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.btnConfirmBmi = new System.Windows.Forms.Button();
            this.labelShowUp = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // labelHeight
            // 
            this.labelHeight.BackColor = System.Drawing.Color.DimGray;
            this.labelHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHeight.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHeight.ForeColor = System.Drawing.Color.White;
            this.labelHeight.Location = new System.Drawing.Point(487, 308);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(500, 50);
            this.labelHeight.TabIndex = 0;
            this.labelHeight.Text = "Enter Height in cm:";
            this.labelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.Color.DimGray;
            this.txtHeight.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHeight.ForeColor = System.Drawing.Color.White;
            this.txtHeight.Location = new System.Drawing.Point(487, 397);
            this.txtHeight.MaximumSize = new System.Drawing.Size(500, 50);
            this.txtHeight.MinimumSize = new System.Drawing.Size(500, 50);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(500, 50);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // textWeight
            // 
            this.textWeight.BackColor = System.Drawing.Color.DimGray;
            this.textWeight.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textWeight.ForeColor = System.Drawing.Color.White;
            this.textWeight.Location = new System.Drawing.Point(487, 575);
            this.textWeight.MaximumSize = new System.Drawing.Size(500, 50);
            this.textWeight.MinimumSize = new System.Drawing.Size(500, 50);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(500, 50);
            this.textWeight.TabIndex = 3;
            this.textWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelWeight
            // 
            this.labelWeight.BackColor = System.Drawing.Color.DimGray;
            this.labelWeight.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWeight.ForeColor = System.Drawing.Color.White;
            this.labelWeight.Location = new System.Drawing.Point(487, 486);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(500, 50);
            this.labelWeight.TabIndex = 2;
            this.labelWeight.Text = "Enter weight in kg:";
            this.labelWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnConfirmBmi.Location = new System.Drawing.Point(684, 664);
            this.btnConfirmBmi.Name = "btnConfirmBmi";
            this.btnConfirmBmi.Size = new System.Drawing.Size(106, 100);
            this.btnConfirmBmi.TabIndex = 9;
            this.btnConfirmBmi.UseVisualStyleBackColor = false;
            this.btnConfirmBmi.Click += new System.EventHandler(this.btnConfirmBmi_Click);
            // 
            // labelShowUp
            // 
            this.labelShowUp.BackColor = System.Drawing.Color.DimGray;
            this.labelShowUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShowUp.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelShowUp.ForeColor = System.Drawing.Color.White;
            this.labelShowUp.Location = new System.Drawing.Point(187, 149);
            this.labelShowUp.Name = "labelShowUp";
            this.labelShowUp.Size = new System.Drawing.Size(1100, 120);
            this.labelShowUp.TabIndex = 10;
            this.labelShowUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShowUp.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 1100);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // BmiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 1100);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.labelShowUp);
            this.Controls.Add(this.btnConfirmBmi);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.txtHeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BmiForm";
            this.Text = "BmiForm";
            this.Load += new System.EventHandler(this.BmiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelHeight;
        private TextBox txtHeight;
        private TextBox textWeight;
        private Label labelWeight;
        private Button btnConfirmBmi;
        private Label labelShowUp;
        private Splitter splitter1;
    }
}