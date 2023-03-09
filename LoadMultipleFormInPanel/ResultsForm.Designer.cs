namespace LoadMultipleFormInPanel
{
    partial class ResultsForm
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
            this.labelResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelResults
            // 
            this.labelResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResults.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResults.ForeColor = System.Drawing.Color.DimGray;
            this.labelResults.Location = new System.Drawing.Point(0, 0);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(1523, 977);
            this.labelResults.TabIndex = 0;
            this.labelResults.Text = "Results are shown here:";
            this.labelResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResults.Click += new System.EventHandler(this.labelResults_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 977);
            this.Controls.Add(this.labelResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.ResumeLayout(false);

        }

        #endregion

        public Label labelResults;
    }
}