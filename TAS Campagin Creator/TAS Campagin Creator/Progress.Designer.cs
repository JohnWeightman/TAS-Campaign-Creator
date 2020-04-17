namespace TAS_Campagin_Creator
{
    partial class Progress
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
            this.ProBar = new System.Windows.Forms.ProgressBar();
            this.ProLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProBar
            // 
            this.ProBar.ForeColor = System.Drawing.Color.Lime;
            this.ProBar.Location = new System.Drawing.Point(12, 75);
            this.ProBar.Name = "ProBar";
            this.ProBar.Size = new System.Drawing.Size(458, 25);
            this.ProBar.TabIndex = 0;
            // 
            // ProLabel
            // 
            this.ProLabel.AutoSize = true;
            this.ProLabel.Location = new System.Drawing.Point(13, 52);
            this.ProLabel.Name = "ProLabel";
            this.ProLabel.Size = new System.Drawing.Size(169, 17);
            this.ProLabel.TabIndex = 1;
            this.ProLabel.Text = "Progress: 0% - Job 0 of 0";
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 113);
            this.Controls.Add(this.ProLabel);
            this.Controls.Add(this.ProBar);
            this.Name = "Progress";
            this.Text = "Progress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProBar;
        private System.Windows.Forms.Label ProLabel;
    }
}