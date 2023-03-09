namespace LoadMultipleFormInPanel
{
    partial class OptometryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptometryForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnConfirmOptometry = new System.Windows.Forms.Button();
            this.btnNoOptometry = new System.Windows.Forms.Button();
            this.labelOptometry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(463, 34);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(590, 590);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnConfirmOptometry
            // 
            this.btnConfirmOptometry.BackColor = System.Drawing.Color.DimGray;
            this.btnConfirmOptometry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmOptometry.BackgroundImage")));
            this.btnConfirmOptometry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmOptometry.FlatAppearance.BorderSize = 2;
            this.btnConfirmOptometry.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirmOptometry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmOptometry.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmOptometry.ForeColor = System.Drawing.Color.White;
            this.btnConfirmOptometry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmOptometry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfirmOptometry.Location = new System.Drawing.Point(610, 751);
            this.btnConfirmOptometry.Name = "btnConfirmOptometry";
            this.btnConfirmOptometry.Size = new System.Drawing.Size(106, 100);
            this.btnConfirmOptometry.TabIndex = 10;
            this.btnConfirmOptometry.UseVisualStyleBackColor = false;
            this.btnConfirmOptometry.Click += new System.EventHandler(this.btnConfirmOptometry_Click);
            // 
            // btnNoOptometry
            // 
            this.btnNoOptometry.BackColor = System.Drawing.Color.DimGray;
            this.btnNoOptometry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNoOptometry.BackgroundImage")));
            this.btnNoOptometry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNoOptometry.FlatAppearance.BorderSize = 2;
            this.btnNoOptometry.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNoOptometry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoOptometry.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNoOptometry.ForeColor = System.Drawing.Color.White;
            this.btnNoOptometry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoOptometry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNoOptometry.Location = new System.Drawing.Point(776, 751);
            this.btnNoOptometry.Name = "btnNoOptometry";
            this.btnNoOptometry.Size = new System.Drawing.Size(106, 100);
            this.btnNoOptometry.TabIndex = 11;
            this.btnNoOptometry.UseVisualStyleBackColor = false;
            this.btnNoOptometry.Click += new System.EventHandler(this.btnNoOptometry_Click);
            // 
            // labelOptometry
            // 
            this.labelOptometry.BackColor = System.Drawing.Color.DimGray;
            this.labelOptometry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOptometry.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOptometry.ForeColor = System.Drawing.Color.White;
            this.labelOptometry.Location = new System.Drawing.Point(382, 627);
            this.labelOptometry.Name = "labelOptometry";
            this.labelOptometry.Size = new System.Drawing.Size(747, 108);
            this.labelOptometry.TabIndex = 12;
            this.labelOptometry.Text = "Measure width using a ruler. Is width between 26 - 29 mm?";
            this.labelOptometry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OptometryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 1000);
            this.Controls.Add(this.labelOptometry);
            this.Controls.Add(this.btnNoOptometry);
            this.Controls.Add(this.btnConfirmOptometry);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OptometryForm";
            this.Text = "OptometryForm";
            this.Load += new System.EventHandler(this.OptometryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox;
        private Button btnConfirmOptometry;
        private Button btnNoOptometry;
        private Label labelOptometry;
    }
}