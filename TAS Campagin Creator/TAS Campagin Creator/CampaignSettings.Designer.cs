namespace TAS_Campagin_Creator
{
    partial class CampaignSettings
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
            this.SettingsLBox = new System.Windows.Forms.ListBox();
            this.GeneralGBox = new System.Windows.Forms.GroupBox();
            this.EnemeisGBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // SettingsLBox
            // 
            this.SettingsLBox.FormattingEnabled = true;
            this.SettingsLBox.ItemHeight = 16;
            this.SettingsLBox.Items.AddRange(new object[] {
            "General",
            "Enemies"});
            this.SettingsLBox.Location = new System.Drawing.Point(10, 10);
            this.SettingsLBox.Name = "SettingsLBox";
            this.SettingsLBox.Size = new System.Drawing.Size(200, 676);
            this.SettingsLBox.TabIndex = 0;
            this.SettingsLBox.SelectedIndexChanged += new System.EventHandler(this.SettingsLBox_SelectedIndexChanged);
            // 
            // GeneralGBox
            // 
            this.GeneralGBox.Location = new System.Drawing.Point(215, 10);
            this.GeneralGBox.Name = "GeneralGBox";
            this.GeneralGBox.Size = new System.Drawing.Size(955, 675);
            this.GeneralGBox.TabIndex = 1;
            this.GeneralGBox.TabStop = false;
            this.GeneralGBox.Text = "groupBox1";
            // 
            // EnemeisGBox
            // 
            this.EnemeisGBox.Location = new System.Drawing.Point(215, 10);
            this.EnemeisGBox.Name = "EnemeisGBox";
            this.EnemeisGBox.Size = new System.Drawing.Size(955, 675);
            this.EnemeisGBox.TabIndex = 2;
            this.EnemeisGBox.TabStop = false;
            this.EnemeisGBox.Text = "groupBox1";
            // 
            // CampaignSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.GeneralGBox);
            this.Controls.Add(this.SettingsLBox);
            this.Controls.Add(this.EnemeisGBox);
            this.Name = "CampaignSettings";
            this.Text = "Campaign Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SettingsLBox;
        private System.Windows.Forms.GroupBox GeneralGBox;
        private System.Windows.Forms.GroupBox EnemeisGBox;
    }
}