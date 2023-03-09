namespace LoadMultipleFormInPanel
{
    partial class Cardiology
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cardiology));
            this.labelDiastolic = new System.Windows.Forms.Label();
            this.txtDiastolic = new System.Windows.Forms.TextBox();
            this.labelSystolic = new System.Windows.Forms.Label();
            this.txtSystolic = new System.Windows.Forms.TextBox();
            this.btnConfirmCardio = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.labelShowUpCardio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDiastolic
            // 
            this.labelDiastolic.BackColor = System.Drawing.Color.DimGray;
            this.labelDiastolic.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDiastolic.ForeColor = System.Drawing.Color.White;
            this.labelDiastolic.Location = new System.Drawing.Point(479, 431);
            this.labelDiastolic.Name = "labelDiastolic";
            this.labelDiastolic.Size = new System.Drawing.Size(500, 50);
            this.labelDiastolic.TabIndex = 6;
            this.labelDiastolic.Text = "Enter diastolic value:";
            this.labelDiastolic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiastolic
            // 
            this.txtDiastolic.BackColor = System.Drawing.Color.DimGray;
            this.txtDiastolic.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiastolic.ForeColor = System.Drawing.Color.White;
            this.txtDiastolic.Location = new System.Drawing.Point(479, 530);
            this.txtDiastolic.MaximumSize = new System.Drawing.Size(500, 50);
            this.txtDiastolic.MinimumSize = new System.Drawing.Size(500, 50);
            this.txtDiastolic.Name = "txtDiastolic";
            this.txtDiastolic.Size = new System.Drawing.Size(500, 50);
            this.txtDiastolic.TabIndex = 7;
            this.txtDiastolic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSystolic
            // 
            this.labelSystolic.BackColor = System.Drawing.Color.DimGray;
            this.labelSystolic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSystolic.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSystolic.ForeColor = System.Drawing.Color.White;
            this.labelSystolic.Location = new System.Drawing.Point(479, 233);
            this.labelSystolic.Name = "labelSystolic";
            this.labelSystolic.Size = new System.Drawing.Size(500, 50);
            this.labelSystolic.TabIndex = 4;
            this.labelSystolic.Text = "Enter Systolic value:";
            this.labelSystolic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSystolic
            // 
            this.txtSystolic.BackColor = System.Drawing.Color.DimGray;
            this.txtSystolic.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSystolic.ForeColor = System.Drawing.Color.White;
            this.txtSystolic.Location = new System.Drawing.Point(479, 332);
            this.txtSystolic.MaximumSize = new System.Drawing.Size(500, 50);
            this.txtSystolic.MinimumSize = new System.Drawing.Size(500, 50);
            this.txtSystolic.Name = "txtSystolic";
            this.txtSystolic.Size = new System.Drawing.Size(500, 50);
            this.txtSystolic.TabIndex = 5;
            this.txtSystolic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfirmCardio
            // 
            this.btnConfirmCardio.BackColor = System.Drawing.Color.DimGray;
            this.btnConfirmCardio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmCardio.BackgroundImage")));
            this.btnConfirmCardio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmCardio.FlatAppearance.BorderSize = 2;
            this.btnConfirmCardio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirmCardio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmCardio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmCardio.ForeColor = System.Drawing.Color.White;
            this.btnConfirmCardio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmCardio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfirmCardio.Location = new System.Drawing.Point(676, 629);
            this.btnConfirmCardio.Name = "btnConfirmCardio";
            this.btnConfirmCardio.Size = new System.Drawing.Size(106, 100);
            this.btnConfirmCardio.TabIndex = 8;
            this.btnConfirmCardio.UseVisualStyleBackColor = false;
            this.btnConfirmCardio.Click += new System.EventHandler(this.btnConfirmCardio_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 1100);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(6, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(6, 1100);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
            // 
            // labelShowUpCardio
            // 
            this.labelShowUpCardio.BackColor = System.Drawing.Color.DimGray;
            this.labelShowUpCardio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShowUpCardio.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelShowUpCardio.ForeColor = System.Drawing.Color.White;
            this.labelShowUpCardio.Location = new System.Drawing.Point(179, 64);
            this.labelShowUpCardio.Name = "labelShowUpCardio";
            this.labelShowUpCardio.Size = new System.Drawing.Size(1100, 120);
            this.labelShowUpCardio.TabIndex = 11;
            this.labelShowUpCardio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShowUpCardio.Visible = false;
            // 
            // Cardiology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 1100);
            this.Controls.Add(this.labelShowUpCardio);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnConfirmCardio);
            this.Controls.Add(this.labelDiastolic);
            this.Controls.Add(this.txtDiastolic);
            this.Controls.Add(this.labelSystolic);
            this.Controls.Add(this.txtSystolic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cardiology";
            this.Text = "Cardiology";
            this.Load += new System.EventHandler(this.Cardiology_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDiastolic;
        private TextBox txtDiastolic;
        private Label labelSystolic;
        private TextBox txtSystolic;
        private Button btnConfirmCardio;
        private Splitter splitter1;
        private Splitter splitter2;
        private Label labelShowUpCardio;
    }
}