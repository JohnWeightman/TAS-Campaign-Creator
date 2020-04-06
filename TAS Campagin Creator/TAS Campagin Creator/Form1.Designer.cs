namespace TAS_Campagin_Creator
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewCampaignButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveCampaignButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadCampaignButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.modulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CampaignNameLabel = new System.Windows.Forms.Label();
            this.ModuleBox = new System.Windows.Forms.ListBox();
            this.StoryBox = new System.Windows.Forms.RichTextBox();
            this.StoryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OptionsBox = new System.Windows.Forms.ListBox();
            this.ModuleLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modulesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1582, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewCampaignButton,
            this.SaveCampaignButton,
            this.LoadCampaignButton,
            this.toolStripMenuItem1,
            this.QuitButton});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // NewCampaignButton
            // 
            this.NewCampaignButton.Name = "NewCampaignButton";
            this.NewCampaignButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewCampaignButton.Size = new System.Drawing.Size(239, 26);
            this.NewCampaignButton.Text = "&New Campaign";
            this.NewCampaignButton.Click += new System.EventHandler(this.NewCampaignButton_Click);
            // 
            // SaveCampaignButton
            // 
            this.SaveCampaignButton.Name = "SaveCampaignButton";
            this.SaveCampaignButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveCampaignButton.Size = new System.Drawing.Size(239, 26);
            this.SaveCampaignButton.Text = "&Save Campaign";
            this.SaveCampaignButton.Click += new System.EventHandler(this.SaveCampaignButton_Click);
            // 
            // LoadCampaignButton
            // 
            this.LoadCampaignButton.Name = "LoadCampaignButton";
            this.LoadCampaignButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.LoadCampaignButton.Size = new System.Drawing.Size(239, 26);
            this.LoadCampaignButton.Text = "&Load Campaign";
            this.LoadCampaignButton.Click += new System.EventHandler(this.LoadCampaignButton_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(236, 6);
            // 
            // QuitButton
            // 
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Q)));
            this.QuitButton.Size = new System.Drawing.Size(239, 26);
            this.QuitButton.Text = "&Quit";
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // modulesToolStripMenuItem
            // 
            this.modulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addModuleToolStripMenuItem});
            this.modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            this.modulesToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.modulesToolStripMenuItem.Text = "Modules";
            // 
            // addModuleToolStripMenuItem
            // 
            this.addModuleToolStripMenuItem.Name = "addModuleToolStripMenuItem";
            this.addModuleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.addModuleToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.addModuleToolStripMenuItem.Text = "&Add Module";
            this.addModuleToolStripMenuItem.Click += new System.EventHandler(this.addModuleToolStripMenuItem_Click);
            // 
            // CampaignNameLabel
            // 
            this.CampaignNameLabel.AutoSize = true;
            this.CampaignNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampaignNameLabel.Location = new System.Drawing.Point(10, 30);
            this.CampaignNameLabel.Name = "CampaignNameLabel";
            this.CampaignNameLabel.Size = new System.Drawing.Size(209, 46);
            this.CampaignNameLabel.TabIndex = 2;
            this.CampaignNameLabel.Text = "Campaign";
            // 
            // ModuleBox
            // 
            this.ModuleBox.FormattingEnabled = true;
            this.ModuleBox.ItemHeight = 16;
            this.ModuleBox.Location = new System.Drawing.Point(10, 85);
            this.ModuleBox.Name = "ModuleBox";
            this.ModuleBox.Size = new System.Drawing.Size(200, 756);
            this.ModuleBox.TabIndex = 3;
            this.ModuleBox.SelectedIndexChanged += new System.EventHandler(this.ModuleBox_SelectedIndexChanged);
            // 
            // StoryBox
            // 
            this.StoryBox.Location = new System.Drawing.Point(220, 220);
            this.StoryBox.Name = "StoryBox";
            this.StoryBox.Size = new System.Drawing.Size(500, 300);
            this.StoryBox.TabIndex = 4;
            this.StoryBox.Text = "";
            // 
            // StoryLabel
            // 
            this.StoryLabel.AutoSize = true;
            this.StoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoryLabel.Location = new System.Drawing.Point(220, 185);
            this.StoryLabel.Name = "StoryLabel";
            this.StoryLabel.Size = new System.Drawing.Size(261, 32);
            this.StoryLabel.TabIndex = 5;
            this.StoryLabel.Text = "Module Story Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Module Player Options";
            // 
            // OptionsBox
            // 
            this.OptionsBox.FormattingEnabled = true;
            this.OptionsBox.ItemHeight = 16;
            this.OptionsBox.Location = new System.Drawing.Point(220, 560);
            this.OptionsBox.Name = "OptionsBox";
            this.OptionsBox.Size = new System.Drawing.Size(500, 260);
            this.OptionsBox.TabIndex = 7;
            // 
            // ModuleLabel
            // 
            this.ModuleLabel.AutoSize = true;
            this.ModuleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleLabel.Location = new System.Drawing.Point(220, 85);
            this.ModuleLabel.Name = "ModuleLabel";
            this.ModuleLabel.Size = new System.Drawing.Size(140, 32);
            this.ModuleLabel.TabIndex = 8;
            this.ModuleLabel.Text = "Module 1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(220, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "Update Module";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ModuleLabel);
            this.Controls.Add(this.OptionsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StoryLabel);
            this.Controls.Add(this.StoryBox);
            this.Controls.Add(this.ModuleBox);
            this.Controls.Add(this.CampaignNameLabel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "TAS Campaign Creator";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewCampaignButton;
        private System.Windows.Forms.ToolStripMenuItem SaveCampaignButton;
        private System.Windows.Forms.ToolStripMenuItem LoadCampaignButton;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem QuitButton;
        private System.Windows.Forms.Label CampaignNameLabel;
        private System.Windows.Forms.ListBox ModuleBox;
        private System.Windows.Forms.RichTextBox StoryBox;
        private System.Windows.Forms.ToolStripMenuItem modulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addModuleToolStripMenuItem;
        private System.Windows.Forms.Label StoryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox OptionsBox;
        private System.Windows.Forms.Label ModuleLabel;
        private System.Windows.Forms.Button button1;
    }
}

