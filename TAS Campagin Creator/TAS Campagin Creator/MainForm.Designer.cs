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
            this.exportCampaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CampaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CampaignNameLabel = new System.Windows.Forms.Label();
            this.ModuleBox = new System.Windows.Forms.ListBox();
            this.StoryBox = new System.Windows.Forms.RichTextBox();
            this.StoryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ModuleLabel = new System.Windows.Forms.Label();
            this.UpdateModuleButton = new System.Windows.Forms.Button();
            this.OptionsBox = new System.Windows.Forms.RichTextBox();
            this.OptionsBox2 = new System.Windows.Forms.ListBox();
            this.ModuleTypeLabel = new System.Windows.Forms.Label();
            this.StoryRButton = new System.Windows.Forms.RadioButton();
            this.EncounterRButton = new System.Windows.Forms.RadioButton();
            this.EncounterGBox = new System.Windows.Forms.GroupBox();
            this.ModuleEnemiesBox = new System.Windows.Forms.RichTextBox();
            this.ClearEnemiesButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DifBonusSearchBox = new System.Windows.Forms.TextBox();
            this.EnemyNameSearchBox = new System.Windows.Forms.TextBox();
            this.EnemyListBox = new System.Windows.Forms.ListBox();
            this.renameCampaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.EncounterGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.CampaignToolStripMenuItem});
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
            this.exportCampaignToolStripMenuItem,
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
            this.NewCampaignButton.Size = new System.Drawing.Size(249, 26);
            this.NewCampaignButton.Text = "&New Campaign";
            this.NewCampaignButton.Click += new System.EventHandler(this.NewCampaignButton_Click);
            // 
            // SaveCampaignButton
            // 
            this.SaveCampaignButton.Name = "SaveCampaignButton";
            this.SaveCampaignButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveCampaignButton.Size = new System.Drawing.Size(249, 26);
            this.SaveCampaignButton.Text = "&Save Campaign";
            this.SaveCampaignButton.Click += new System.EventHandler(this.SaveCampaignButton_Click);
            // 
            // LoadCampaignButton
            // 
            this.LoadCampaignButton.Name = "LoadCampaignButton";
            this.LoadCampaignButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.LoadCampaignButton.Size = new System.Drawing.Size(249, 26);
            this.LoadCampaignButton.Text = "&Load Campaign";
            this.LoadCampaignButton.Click += new System.EventHandler(this.LoadCampaignButton_Click);
            // 
            // exportCampaignToolStripMenuItem
            // 
            this.exportCampaignToolStripMenuItem.Name = "exportCampaignToolStripMenuItem";
            this.exportCampaignToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportCampaignToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.exportCampaignToolStripMenuItem.Text = "Export Campaign";
            this.exportCampaignToolStripMenuItem.Click += new System.EventHandler(this.exportCampaignToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(246, 6);
            // 
            // QuitButton
            // 
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Q)));
            this.QuitButton.Size = new System.Drawing.Size(249, 26);
            this.QuitButton.Text = "&Quit";
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // CampaignToolStripMenuItem
            // 
            this.CampaignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameCampaignToolStripMenuItem,
            this.addModuleToolStripMenuItem});
            this.CampaignToolStripMenuItem.Name = "CampaignToolStripMenuItem";
            this.CampaignToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.CampaignToolStripMenuItem.Text = "Campaign";
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
            this.ModuleBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModuleBox_KeyDown);
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
            // ModuleLabel
            // 
            this.ModuleLabel.AutoSize = true;
            this.ModuleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleLabel.Location = new System.Drawing.Point(220, 85);
            this.ModuleLabel.Name = "ModuleLabel";
            this.ModuleLabel.Size = new System.Drawing.Size(326, 32);
            this.ModuleLabel.TabIndex = 8;
            this.ModuleLabel.Text = "Module: Select Module";
            // 
            // UpdateModuleButton
            // 
            this.UpdateModuleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateModuleButton.Location = new System.Drawing.Point(220, 120);
            this.UpdateModuleButton.Name = "UpdateModuleButton";
            this.UpdateModuleButton.Size = new System.Drawing.Size(140, 62);
            this.UpdateModuleButton.TabIndex = 9;
            this.UpdateModuleButton.Text = "Update Module";
            this.UpdateModuleButton.UseVisualStyleBackColor = true;
            this.UpdateModuleButton.Click += new System.EventHandler(this.UpdateModuleButton_Click);
            // 
            // OptionsBox
            // 
            this.OptionsBox.Location = new System.Drawing.Point(220, 560);
            this.OptionsBox.Name = "OptionsBox";
            this.OptionsBox.Size = new System.Drawing.Size(200, 280);
            this.OptionsBox.TabIndex = 10;
            this.OptionsBox.Text = "";
            this.OptionsBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OptionsBox_KeyDown);
            // 
            // OptionsBox2
            // 
            this.OptionsBox2.FormattingEnabled = true;
            this.OptionsBox2.ItemHeight = 16;
            this.OptionsBox2.Location = new System.Drawing.Point(430, 560);
            this.OptionsBox2.Name = "OptionsBox2";
            this.OptionsBox2.Size = new System.Drawing.Size(200, 276);
            this.OptionsBox2.TabIndex = 11;
            this.OptionsBox2.SelectedIndexChanged += new System.EventHandler(this.OptionsBox2_SelectedIndexChanged);
            // 
            // ModuleTypeLabel
            // 
            this.ModuleTypeLabel.AutoSize = true;
            this.ModuleTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleTypeLabel.Location = new System.Drawing.Point(720, 185);
            this.ModuleTypeLabel.Name = "ModuleTypeLabel";
            this.ModuleTypeLabel.Size = new System.Drawing.Size(190, 32);
            this.ModuleTypeLabel.TabIndex = 12;
            this.ModuleTypeLabel.Text = "Module Type";
            // 
            // StoryRButton
            // 
            this.StoryRButton.AutoSize = true;
            this.StoryRButton.Location = new System.Drawing.Point(725, 220);
            this.StoryRButton.Name = "StoryRButton";
            this.StoryRButton.Size = new System.Drawing.Size(112, 21);
            this.StoryRButton.TabIndex = 13;
            this.StoryRButton.TabStop = true;
            this.StoryRButton.Text = "Story Module";
            this.StoryRButton.UseVisualStyleBackColor = true;
            this.StoryRButton.CheckedChanged += new System.EventHandler(this.StoryRButton_CheckedChanged);
            // 
            // EncounterRButton
            // 
            this.EncounterRButton.AutoSize = true;
            this.EncounterRButton.Location = new System.Drawing.Point(725, 250);
            this.EncounterRButton.Name = "EncounterRButton";
            this.EncounterRButton.Size = new System.Drawing.Size(144, 21);
            this.EncounterRButton.TabIndex = 14;
            this.EncounterRButton.TabStop = true;
            this.EncounterRButton.Text = "Encounter Module";
            this.EncounterRButton.UseVisualStyleBackColor = true;
            this.EncounterRButton.CheckedChanged += new System.EventHandler(this.EncounterRButton_CheckedChanged);
            // 
            // EncounterGBox
            // 
            this.EncounterGBox.Controls.Add(this.ModuleEnemiesBox);
            this.EncounterGBox.Controls.Add(this.ClearEnemiesButton);
            this.EncounterGBox.Controls.Add(this.SearchButton);
            this.EncounterGBox.Controls.Add(this.DifBonusSearchBox);
            this.EncounterGBox.Controls.Add(this.EnemyNameSearchBox);
            this.EncounterGBox.Controls.Add(this.EnemyListBox);
            this.EncounterGBox.Location = new System.Drawing.Point(920, 185);
            this.EncounterGBox.Name = "EncounterGBox";
            this.EncounterGBox.Size = new System.Drawing.Size(650, 655);
            this.EncounterGBox.TabIndex = 15;
            this.EncounterGBox.TabStop = false;
            this.EncounterGBox.Visible = false;
            // 
            // ModuleEnemiesBox
            // 
            this.ModuleEnemiesBox.Location = new System.Drawing.Point(210, 70);
            this.ModuleEnemiesBox.Name = "ModuleEnemiesBox";
            this.ModuleEnemiesBox.Size = new System.Drawing.Size(285, 585);
            this.ModuleEnemiesBox.TabIndex = 5;
            this.ModuleEnemiesBox.Text = "";
            // 
            // ClearEnemiesButton
            // 
            this.ClearEnemiesButton.Location = new System.Drawing.Point(420, 40);
            this.ClearEnemiesButton.Name = "ClearEnemiesButton";
            this.ClearEnemiesButton.Size = new System.Drawing.Size(75, 23);
            this.ClearEnemiesButton.TabIndex = 4;
            this.ClearEnemiesButton.Text = "Clear";
            this.ClearEnemiesButton.UseVisualStyleBackColor = true;
            this.ClearEnemiesButton.Click += new System.EventHandler(this.ClearEnemiesButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(420, 10);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // DifBonusSearchBox
            // 
            this.DifBonusSearchBox.Location = new System.Drawing.Point(210, 40);
            this.DifBonusSearchBox.Name = "DifBonusSearchBox";
            this.DifBonusSearchBox.Size = new System.Drawing.Size(200, 22);
            this.DifBonusSearchBox.TabIndex = 2;
            // 
            // EnemyNameSearchBox
            // 
            this.EnemyNameSearchBox.Location = new System.Drawing.Point(210, 10);
            this.EnemyNameSearchBox.Name = "EnemyNameSearchBox";
            this.EnemyNameSearchBox.Size = new System.Drawing.Size(200, 22);
            this.EnemyNameSearchBox.TabIndex = 1;
            // 
            // EnemyListBox
            // 
            this.EnemyListBox.FormattingEnabled = true;
            this.EnemyListBox.ItemHeight = 16;
            this.EnemyListBox.Location = new System.Drawing.Point(5, 10);
            this.EnemyListBox.Name = "EnemyListBox";
            this.EnemyListBox.Size = new System.Drawing.Size(200, 644);
            this.EnemyListBox.TabIndex = 0;
            this.EnemyListBox.SelectedIndexChanged += new System.EventHandler(this.EnemyListBox_SelectedIndexChanged);
            // 
            // renameCampaignToolStripMenuItem
            // 
            this.renameCampaignToolStripMenuItem.Name = "renameCampaignToolStripMenuItem";
            this.renameCampaignToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.renameCampaignToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.renameCampaignToolStripMenuItem.Text = "Rename Campaign";
            this.renameCampaignToolStripMenuItem.Click += new System.EventHandler(this.renameCampaignToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.EncounterGBox);
            this.Controls.Add(this.EncounterRButton);
            this.Controls.Add(this.StoryRButton);
            this.Controls.Add(this.ModuleTypeLabel);
            this.Controls.Add(this.OptionsBox2);
            this.Controls.Add(this.OptionsBox);
            this.Controls.Add(this.UpdateModuleButton);
            this.Controls.Add(this.ModuleLabel);
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
            this.EncounterGBox.ResumeLayout(false);
            this.EncounterGBox.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem CampaignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addModuleToolStripMenuItem;
        private System.Windows.Forms.Label StoryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ModuleLabel;
        private System.Windows.Forms.Button UpdateModuleButton;
        private System.Windows.Forms.RichTextBox OptionsBox;
        private System.Windows.Forms.ListBox OptionsBox2;
        private System.Windows.Forms.ToolStripMenuItem exportCampaignToolStripMenuItem;
        private System.Windows.Forms.Label ModuleTypeLabel;
        private System.Windows.Forms.RadioButton StoryRButton;
        private System.Windows.Forms.RadioButton EncounterRButton;
        private System.Windows.Forms.GroupBox EncounterGBox;
        private System.Windows.Forms.ListBox EnemyListBox;
        private System.Windows.Forms.RichTextBox ModuleEnemiesBox;
        private System.Windows.Forms.Button ClearEnemiesButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox DifBonusSearchBox;
        private System.Windows.Forms.TextBox EnemyNameSearchBox;
        private System.Windows.Forms.ToolStripMenuItem renameCampaignToolStripMenuItem;
    }
}

