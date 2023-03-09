namespace LoadMultipleFormInPanel
{
    partial class HearingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HearingForm));
            this.labelpressForSound = new System.Windows.Forms.Label();
            this.btnStopSound = new System.Windows.Forms.Button();
            this.btnStartSound = new System.Windows.Forms.Button();
            this.btnNoSoundHeard = new System.Windows.Forms.Button();
            this.btnConfirmHeardSound = new System.Windows.Forms.Button();
            this.labelShowUpHearing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelpressForSound
            // 
            this.labelpressForSound.BackColor = System.Drawing.Color.DimGray;
            this.labelpressForSound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelpressForSound.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelpressForSound.ForeColor = System.Drawing.Color.White;
            this.labelpressForSound.Location = new System.Drawing.Point(364, 146);
            this.labelpressForSound.Name = "labelpressForSound";
            this.labelpressForSound.Size = new System.Drawing.Size(747, 108);
            this.labelpressForSound.TabIndex = 13;
            this.labelpressForSound.Text = "Press button to play sound.";
            this.labelpressForSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelpressForSound.Click += new System.EventHandler(this.labelpressForSound_Click);
            // 
            // btnStopSound
            // 
            this.btnStopSound.BackColor = System.Drawing.Color.White;
            this.btnStopSound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStopSound.BackgroundImage")));
            this.btnStopSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStopSound.FlatAppearance.BorderSize = 2;
            this.btnStopSound.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStopSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopSound.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStopSound.ForeColor = System.Drawing.Color.White;
            this.btnStopSound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopSound.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStopSound.Location = new System.Drawing.Point(746, 280);
            this.btnStopSound.Name = "btnStopSound";
            this.btnStopSound.Size = new System.Drawing.Size(106, 100);
            this.btnStopSound.TabIndex = 15;
            this.btnStopSound.UseVisualStyleBackColor = false;
            this.btnStopSound.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStartSound
            // 
            this.btnStartSound.BackColor = System.Drawing.Color.White;
            this.btnStartSound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartSound.BackgroundImage")));
            this.btnStartSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStartSound.FlatAppearance.BorderSize = 2;
            this.btnStartSound.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartSound.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartSound.ForeColor = System.Drawing.Color.White;
            this.btnStartSound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartSound.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStartSound.Location = new System.Drawing.Point(585, 280);
            this.btnStartSound.Name = "btnStartSound";
            this.btnStartSound.Size = new System.Drawing.Size(106, 100);
            this.btnStartSound.TabIndex = 14;
            this.btnStartSound.UseVisualStyleBackColor = false;
            this.btnStartSound.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNoSoundHeard
            // 
            this.btnNoSoundHeard.BackColor = System.Drawing.Color.DimGray;
            this.btnNoSoundHeard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNoSoundHeard.BackgroundImage")));
            this.btnNoSoundHeard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNoSoundHeard.FlatAppearance.BorderSize = 2;
            this.btnNoSoundHeard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNoSoundHeard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoSoundHeard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNoSoundHeard.ForeColor = System.Drawing.Color.White;
            this.btnNoSoundHeard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoSoundHeard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNoSoundHeard.Location = new System.Drawing.Point(746, 658);
            this.btnNoSoundHeard.Name = "btnNoSoundHeard";
            this.btnNoSoundHeard.Size = new System.Drawing.Size(106, 100);
            this.btnNoSoundHeard.TabIndex = 18;
            this.btnNoSoundHeard.UseVisualStyleBackColor = false;
            this.btnNoSoundHeard.Visible = false;
            this.btnNoSoundHeard.Click += new System.EventHandler(this.btnNoSoundHeard_Click);
            // 
            // btnConfirmHeardSound
            // 
            this.btnConfirmHeardSound.BackColor = System.Drawing.Color.DimGray;
            this.btnConfirmHeardSound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmHeardSound.BackgroundImage")));
            this.btnConfirmHeardSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmHeardSound.FlatAppearance.BorderSize = 2;
            this.btnConfirmHeardSound.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirmHeardSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmHeardSound.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmHeardSound.ForeColor = System.Drawing.Color.White;
            this.btnConfirmHeardSound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmHeardSound.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfirmHeardSound.Location = new System.Drawing.Point(585, 658);
            this.btnConfirmHeardSound.Name = "btnConfirmHeardSound";
            this.btnConfirmHeardSound.Size = new System.Drawing.Size(106, 100);
            this.btnConfirmHeardSound.TabIndex = 17;
            this.btnConfirmHeardSound.UseVisualStyleBackColor = false;
            this.btnConfirmHeardSound.Visible = false;
            this.btnConfirmHeardSound.Click += new System.EventHandler(this.btnConfirmHeardSound_Click);
            // 
            // labelShowUpHearing
            // 
            this.labelShowUpHearing.BackColor = System.Drawing.Color.DimGray;
            this.labelShowUpHearing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShowUpHearing.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelShowUpHearing.ForeColor = System.Drawing.Color.White;
            this.labelShowUpHearing.Location = new System.Drawing.Point(364, 493);
            this.labelShowUpHearing.Name = "labelShowUpHearing";
            this.labelShowUpHearing.Size = new System.Drawing.Size(747, 108);
            this.labelShowUpHearing.TabIndex = 16;
            this.labelShowUpHearing.Text = "Did you hear a sound playing?";
            this.labelShowUpHearing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShowUpHearing.Visible = false;
            this.labelShowUpHearing.Click += new System.EventHandler(this.labelShowUpHearing_Click);
            // 
            // HearingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 1100);
            this.Controls.Add(this.btnNoSoundHeard);
            this.Controls.Add(this.btnConfirmHeardSound);
            this.Controls.Add(this.labelShowUpHearing);
            this.Controls.Add(this.btnStopSound);
            this.Controls.Add(this.btnStartSound);
            this.Controls.Add(this.labelpressForSound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HearingForm";
            this.Text = "HearingForm";
            this.Load += new System.EventHandler(this.HearingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelpressForSound;
        private Button btnStopSound;
        private Button btnStartSound;
        private Button btnNoSoundHeard;
        private Button btnConfirmHeardSound;
        private Label labelShowUpHearing;
    }
}