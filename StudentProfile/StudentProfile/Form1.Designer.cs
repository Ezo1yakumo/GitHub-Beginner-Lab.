namespace StudentProfile
{
    partial class Form1
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
            this.lblStudProfile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStudProfile
            // 
            this.lblStudProfile.AutoSize = true;
            this.lblStudProfile.Location = new System.Drawing.Point(28, 55);
            this.lblStudProfile.Name = "lblStudProfile";
            this.lblStudProfile.Size = new System.Drawing.Size(187, 13);
            this.lblStudProfile.TabIndex = 0;
            this.lblStudProfile.Text = "Student Profile — GitHub Beginner Lab";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 124);
            this.Controls.Add(this.lblStudProfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudProfile;
    }
}

