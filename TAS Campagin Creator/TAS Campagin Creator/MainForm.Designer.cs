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
            this.renameCampaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CampaignNameLabel = new System.Windows.Forms.Label();
            this.ModuleBox = new System.Windows.Forms.ListBox();
            this.StoryBox = new System.Windows.Forms.RichTextBox();
            this.StoryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ModuleLabel = new System.Windows.Forms.Label();
            this.OptionsBox = new System.Windows.Forms.RichTextBox();
            this.OptionsBox2 = new System.Windows.Forms.ListBox();
            this.ModuleTypeLabel = new System.Windows.Forms.Label();
            this.EncounterGBox = new System.Windows.Forms.GroupBox();
            this.ModuleEnemiesBox = new System.Windows.Forms.RichTextBox();
            this.ClearEnemiesButton = new System.Windows.Forms.Button();
            this.DifBonusSearchBox = new System.Windows.Forms.TextBox();
            this.EnemyNameSearchBox = new System.Windows.Forms.TextBox();
            this.EnemyListBox = new System.Windows.Forms.ListBox();
            this.ModTypeCBox = new System.Windows.Forms.ComboBox();
            this.ModNameTBox = new System.Windows.Forms.TextBox();
            this.ShopGBox = new System.Windows.Forms.GroupBox();
            this.ItemTypeCBox = new System.Windows.Forms.ComboBox();
            this.ShopTBox = new System.Windows.Forms.RichTextBox();
            this.ClearStockButton = new System.Windows.Forms.Button();
            this.SearchItemsTBox = new System.Windows.Forms.TextBox();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.TrapGBox = new System.Windows.Forms.GroupBox();
            this.SaveFailTBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveSuccesTBox = new System.Windows.Forms.RichTextBox();
            this.TrapStatsBox = new System.Windows.Forms.RichTextBox();
            this.SearchTrapsTBox = new System.Windows.Forms.TextBox();
            this.TrapListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveTargetNUD = new System.Windows.Forms.NumericUpDown();
            this.DiceNumberNUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveTypeCBox = new System.Windows.Forms.ComboBox();
            this.DiceSizeNUD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ModifierNUD = new System.Windows.Forms.NumericUpDown();
            this.menuStrip.SuspendLayout();
            this.EncounterGBox.SuspendLayout();
            this.ShopGBox.SuspendLayout();
            this.TrapGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveTargetNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceNumberNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceSizeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifierNUD)).BeginInit();
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
            this.addModuleToolStripMenuItem,
            this.removeModuleToolStripMenuItem});
            this.CampaignToolStripMenuItem.Name = "CampaignToolStripMenuItem";
            this.CampaignToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.CampaignToolStripMenuItem.Text = "Campaign";
            // 
            // renameCampaignToolStripMenuItem
            // 
            this.renameCampaignToolStripMenuItem.Name = "renameCampaignToolStripMenuItem";
            this.renameCampaignToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.renameCampaignToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.renameCampaignToolStripMenuItem.Text = "Rename Campaign";
            this.renameCampaignToolStripMenuItem.Click += new System.EventHandler(this.renameCampaignToolStripMenuItem_Click);
            // 
            // addModuleToolStripMenuItem
            // 
            this.addModuleToolStripMenuItem.Name = "addModuleToolStripMenuItem";
            this.addModuleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.addModuleToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.addModuleToolStripMenuItem.Text = "&Add Module";
            this.addModuleToolStripMenuItem.Click += new System.EventHandler(this.addModuleToolStripMenuItem_Click);
            // 
            // removeModuleToolStripMenuItem
            // 
            this.removeModuleToolStripMenuItem.Name = "removeModuleToolStripMenuItem";
            this.removeModuleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.removeModuleToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.removeModuleToolStripMenuItem.Text = "Remove Module";
            this.removeModuleToolStripMenuItem.Click += new System.EventHandler(this.removeModuleToolStripMenuItem_Click);
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
            this.StoryBox.Location = new System.Drawing.Point(220, 205);
            this.StoryBox.Name = "StoryBox";
            this.StoryBox.Size = new System.Drawing.Size(500, 300);
            this.StoryBox.TabIndex = 4;
            this.StoryBox.Text = "";
            // 
            // StoryLabel
            // 
            this.StoryLabel.AutoSize = true;
            this.StoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoryLabel.Location = new System.Drawing.Point(220, 170);
            this.StoryLabel.Name = "StoryLabel";
            this.StoryLabel.Size = new System.Drawing.Size(261, 32);
            this.StoryLabel.TabIndex = 5;
            this.StoryLabel.Text = "Module Story Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 510);
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
            this.ModuleLabel.Size = new System.Drawing.Size(124, 32);
            this.ModuleLabel.TabIndex = 8;
            this.ModuleLabel.Text = "Module:";
            // 
            // OptionsBox
            // 
            this.OptionsBox.Location = new System.Drawing.Point(220, 545);
            this.OptionsBox.Name = "OptionsBox";
            this.OptionsBox.Size = new System.Drawing.Size(200, 296);
            this.OptionsBox.TabIndex = 10;
            this.OptionsBox.Text = "";
            this.OptionsBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OptionsBox_KeyDown);
            // 
            // OptionsBox2
            // 
            this.OptionsBox2.FormattingEnabled = true;
            this.OptionsBox2.ItemHeight = 16;
            this.OptionsBox2.Location = new System.Drawing.Point(430, 545);
            this.OptionsBox2.Name = "OptionsBox2";
            this.OptionsBox2.Size = new System.Drawing.Size(200, 292);
            this.OptionsBox2.TabIndex = 11;
            this.OptionsBox2.SelectedIndexChanged += new System.EventHandler(this.OptionsBox2_SelectedIndexChanged);
            // 
            // ModuleTypeLabel
            // 
            this.ModuleTypeLabel.AutoSize = true;
            this.ModuleTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleTypeLabel.Location = new System.Drawing.Point(720, 170);
            this.ModuleTypeLabel.Name = "ModuleTypeLabel";
            this.ModuleTypeLabel.Size = new System.Drawing.Size(190, 32);
            this.ModuleTypeLabel.TabIndex = 12;
            this.ModuleTypeLabel.Text = "Module Type";
            // 
            // EncounterGBox
            // 
            this.EncounterGBox.Controls.Add(this.ModuleEnemiesBox);
            this.EncounterGBox.Controls.Add(this.ClearEnemiesButton);
            this.EncounterGBox.Controls.Add(this.DifBonusSearchBox);
            this.EncounterGBox.Controls.Add(this.EnemyNameSearchBox);
            this.EncounterGBox.Controls.Add(this.EnemyListBox);
            this.EncounterGBox.Location = new System.Drawing.Point(920, 170);
            this.EncounterGBox.Name = "EncounterGBox";
            this.EncounterGBox.Size = new System.Drawing.Size(650, 671);
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
            this.EnemyNameSearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnemyNameSearchBox_KeyUp);
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
            // ModTypeCBox
            // 
            this.ModTypeCBox.FormattingEnabled = true;
            this.ModTypeCBox.Items.AddRange(new object[] {
            "Story Module",
            "Encounter Module",
            "Shop Module",
            "Trap Module",
            "End Campaign Module"});
            this.ModTypeCBox.Location = new System.Drawing.Point(725, 205);
            this.ModTypeCBox.Name = "ModTypeCBox";
            this.ModTypeCBox.Size = new System.Drawing.Size(185, 24);
            this.ModTypeCBox.TabIndex = 16;
            this.ModTypeCBox.SelectedValueChanged += new System.EventHandler(this.ModTypeCBox_SelectedValueChanged);
            // 
            // ModNameTBox
            // 
            this.ModNameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModNameTBox.Location = new System.Drawing.Point(345, 80);
            this.ModNameTBox.Name = "ModNameTBox";
            this.ModNameTBox.Size = new System.Drawing.Size(200, 38);
            this.ModNameTBox.TabIndex = 17;
            this.ModNameTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModNameTBox_KeyDown);
            // 
            // ShopGBox
            // 
            this.ShopGBox.Controls.Add(this.ItemTypeCBox);
            this.ShopGBox.Controls.Add(this.ShopTBox);
            this.ShopGBox.Controls.Add(this.ClearStockButton);
            this.ShopGBox.Controls.Add(this.SearchItemsTBox);
            this.ShopGBox.Controls.Add(this.ItemListBox);
            this.ShopGBox.Location = new System.Drawing.Point(920, 170);
            this.ShopGBox.Name = "ShopGBox";
            this.ShopGBox.Size = new System.Drawing.Size(650, 671);
            this.ShopGBox.TabIndex = 16;
            this.ShopGBox.TabStop = false;
            this.ShopGBox.Visible = false;
            // 
            // ItemTypeCBox
            // 
            this.ItemTypeCBox.FormattingEnabled = true;
            this.ItemTypeCBox.Items.AddRange(new object[] {
            "All Items",
            "Weapons",
            "Armour",
            "Potions"});
            this.ItemTypeCBox.Location = new System.Drawing.Point(210, 35);
            this.ItemTypeCBox.Name = "ItemTypeCBox";
            this.ItemTypeCBox.Size = new System.Drawing.Size(200, 24);
            this.ItemTypeCBox.TabIndex = 18;
            this.ItemTypeCBox.SelectedIndexChanged += new System.EventHandler(this.ItemTypeCBox_SelectedIndexChanged);
            // 
            // ShopTBox
            // 
            this.ShopTBox.Location = new System.Drawing.Point(210, 70);
            this.ShopTBox.Name = "ShopTBox";
            this.ShopTBox.Size = new System.Drawing.Size(285, 585);
            this.ShopTBox.TabIndex = 5;
            this.ShopTBox.Text = "";
            // 
            // ClearStockButton
            // 
            this.ClearStockButton.Location = new System.Drawing.Point(420, 40);
            this.ClearStockButton.Name = "ClearStockButton";
            this.ClearStockButton.Size = new System.Drawing.Size(75, 23);
            this.ClearStockButton.TabIndex = 4;
            this.ClearStockButton.Text = "Clear";
            this.ClearStockButton.UseVisualStyleBackColor = true;
            this.ClearStockButton.Click += new System.EventHandler(this.ClearStockButton_Click);
            // 
            // SearchItemsTBox
            // 
            this.SearchItemsTBox.Location = new System.Drawing.Point(210, 10);
            this.SearchItemsTBox.Name = "SearchItemsTBox";
            this.SearchItemsTBox.Size = new System.Drawing.Size(200, 22);
            this.SearchItemsTBox.TabIndex = 1;
            this.SearchItemsTBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchItemsTBox_KeyUp);
            // 
            // ItemListBox
            // 
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 16;
            this.ItemListBox.Location = new System.Drawing.Point(5, 10);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(200, 644);
            this.ItemListBox.TabIndex = 0;
            this.ItemListBox.SelectedIndexChanged += new System.EventHandler(this.ItemListBox_SelectedIndexChanged);
            // 
            // TrapGBox
            // 
            this.TrapGBox.Controls.Add(this.ModifierNUD);
            this.TrapGBox.Controls.Add(this.label8);
            this.TrapGBox.Controls.Add(this.DiceSizeNUD);
            this.TrapGBox.Controls.Add(this.label7);
            this.TrapGBox.Controls.Add(this.SaveTypeCBox);
            this.TrapGBox.Controls.Add(this.label6);
            this.TrapGBox.Controls.Add(this.DiceNumberNUD);
            this.TrapGBox.Controls.Add(this.label5);
            this.TrapGBox.Controls.Add(this.SaveTargetNUD);
            this.TrapGBox.Controls.Add(this.label4);
            this.TrapGBox.Controls.Add(this.SaveFailTBox);
            this.TrapGBox.Controls.Add(this.label3);
            this.TrapGBox.Controls.Add(this.label2);
            this.TrapGBox.Controls.Add(this.SaveSuccesTBox);
            this.TrapGBox.Controls.Add(this.TrapStatsBox);
            this.TrapGBox.Controls.Add(this.SearchTrapsTBox);
            this.TrapGBox.Controls.Add(this.TrapListBox);
            this.TrapGBox.Location = new System.Drawing.Point(920, 170);
            this.TrapGBox.Name = "TrapGBox";
            this.TrapGBox.Size = new System.Drawing.Size(650, 671);
            this.TrapGBox.TabIndex = 16;
            this.TrapGBox.TabStop = false;
            this.TrapGBox.Visible = false;
            // 
            // SaveFailTBox
            // 
            this.SaveFailTBox.Location = new System.Drawing.Point(430, 405);
            this.SaveFailTBox.Name = "SaveFailTBox";
            this.SaveFailTBox.Size = new System.Drawing.Size(210, 250);
            this.SaveFailTBox.TabIndex = 9;
            this.SaveFailTBox.Text = "";
            this.SaveFailTBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SaveFailTBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Save Fail Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Save Success Text";
            // 
            // SaveSuccesTBox
            // 
            this.SaveSuccesTBox.Location = new System.Drawing.Point(210, 405);
            this.SaveSuccesTBox.Name = "SaveSuccesTBox";
            this.SaveSuccesTBox.Size = new System.Drawing.Size(210, 250);
            this.SaveSuccesTBox.TabIndex = 6;
            this.SaveSuccesTBox.Text = "";
            this.SaveSuccesTBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SaveSuccesTBox_KeyUp);
            // 
            // TrapStatsBox
            // 
            this.TrapStatsBox.Location = new System.Drawing.Point(210, 40);
            this.TrapStatsBox.Name = "TrapStatsBox";
            this.TrapStatsBox.Size = new System.Drawing.Size(200, 330);
            this.TrapStatsBox.TabIndex = 5;
            this.TrapStatsBox.Text = "";
            // 
            // SearchTrapsTBox
            // 
            this.SearchTrapsTBox.Location = new System.Drawing.Point(210, 10);
            this.SearchTrapsTBox.Name = "SearchTrapsTBox";
            this.SearchTrapsTBox.Size = new System.Drawing.Size(200, 22);
            this.SearchTrapsTBox.TabIndex = 1;
            this.SearchTrapsTBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchTrapsTBox_KeyUp);
            // 
            // TrapListBox
            // 
            this.TrapListBox.FormattingEnabled = true;
            this.TrapListBox.ItemHeight = 16;
            this.TrapListBox.Location = new System.Drawing.Point(5, 10);
            this.TrapListBox.Name = "TrapListBox";
            this.TrapListBox.Size = new System.Drawing.Size(200, 644);
            this.TrapListBox.TabIndex = 0;
            this.TrapListBox.SelectedIndexChanged += new System.EventHandler(this.TrapListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Save Target:";
            // 
            // SaveTargetNUD
            // 
            this.SaveTargetNUD.Location = new System.Drawing.Point(415, 140);
            this.SaveTargetNUD.Name = "SaveTargetNUD";
            this.SaveTargetNUD.Size = new System.Drawing.Size(120, 22);
            this.SaveTargetNUD.TabIndex = 11;
            this.SaveTargetNUD.ValueChanged += new System.EventHandler(this.SaveTargetNUD_ValueChanged);
            // 
            // DiceNumberNUD
            // 
            this.DiceNumberNUD.Location = new System.Drawing.Point(415, 210);
            this.DiceNumberNUD.Name = "DiceNumberNUD";
            this.DiceNumberNUD.Size = new System.Drawing.Size(120, 22);
            this.DiceNumberNUD.TabIndex = 13;
            this.DiceNumberNUD.ValueChanged += new System.EventHandler(this.DiceNumberNUD_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dice Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Save Type:";
            // 
            // SaveTypeCBox
            // 
            this.SaveTypeCBox.FormattingEnabled = true;
            this.SaveTypeCBox.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Constitution"});
            this.SaveTypeCBox.Location = new System.Drawing.Point(415, 70);
            this.SaveTypeCBox.Name = "SaveTypeCBox";
            this.SaveTypeCBox.Size = new System.Drawing.Size(121, 24);
            this.SaveTypeCBox.TabIndex = 15;
            this.SaveTypeCBox.SelectedValueChanged += new System.EventHandler(this.SaveTypeCBox_SelectedValueChanged);
            // 
            // DiceSizeNUD
            // 
            this.DiceSizeNUD.Location = new System.Drawing.Point(415, 280);
            this.DiceSizeNUD.Name = "DiceSizeNUD";
            this.DiceSizeNUD.Size = new System.Drawing.Size(120, 22);
            this.DiceSizeNUD.TabIndex = 17;
            this.DiceSizeNUD.ValueChanged += new System.EventHandler(this.DiceSizeNUD_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(415, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Dice Size:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(415, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Modifier:";
            // 
            // ModifierNUD
            // 
            this.ModifierNUD.Location = new System.Drawing.Point(415, 350);
            this.ModifierNUD.Name = "ModifierNUD";
            this.ModifierNUD.Size = new System.Drawing.Size(120, 22);
            this.ModifierNUD.TabIndex = 19;
            this.ModifierNUD.ValueChanged += new System.EventHandler(this.ModifierNUD_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.ModNameTBox);
            this.Controls.Add(this.ModTypeCBox);
            this.Controls.Add(this.ModuleTypeLabel);
            this.Controls.Add(this.OptionsBox2);
            this.Controls.Add(this.OptionsBox);
            this.Controls.Add(this.ModuleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StoryLabel);
            this.Controls.Add(this.StoryBox);
            this.Controls.Add(this.ModuleBox);
            this.Controls.Add(this.CampaignNameLabel);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.TrapGBox);
            this.Controls.Add(this.EncounterGBox);
            this.Controls.Add(this.ShopGBox);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "TAS Campaign Creator";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.EncounterGBox.ResumeLayout(false);
            this.EncounterGBox.PerformLayout();
            this.ShopGBox.ResumeLayout(false);
            this.ShopGBox.PerformLayout();
            this.TrapGBox.ResumeLayout(false);
            this.TrapGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveTargetNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceNumberNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceSizeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifierNUD)).EndInit();
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
        private System.Windows.Forms.RichTextBox OptionsBox;
        private System.Windows.Forms.ListBox OptionsBox2;
        private System.Windows.Forms.ToolStripMenuItem exportCampaignToolStripMenuItem;
        private System.Windows.Forms.Label ModuleTypeLabel;
        private System.Windows.Forms.GroupBox EncounterGBox;
        private System.Windows.Forms.ListBox EnemyListBox;
        private System.Windows.Forms.RichTextBox ModuleEnemiesBox;
        private System.Windows.Forms.Button ClearEnemiesButton;
        private System.Windows.Forms.TextBox DifBonusSearchBox;
        private System.Windows.Forms.TextBox EnemyNameSearchBox;
        private System.Windows.Forms.ToolStripMenuItem renameCampaignToolStripMenuItem;
        private System.Windows.Forms.ComboBox ModTypeCBox;
        private System.Windows.Forms.TextBox ModNameTBox;
        private System.Windows.Forms.ToolStripMenuItem removeModuleToolStripMenuItem;
        private System.Windows.Forms.GroupBox ShopGBox;
        private System.Windows.Forms.RichTextBox ShopTBox;
        private System.Windows.Forms.Button ClearStockButton;
        private System.Windows.Forms.TextBox SearchItemsTBox;
        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.ComboBox ItemTypeCBox;
        private System.Windows.Forms.GroupBox TrapGBox;
        private System.Windows.Forms.RichTextBox TrapStatsBox;
        private System.Windows.Forms.TextBox SearchTrapsTBox;
        private System.Windows.Forms.ListBox TrapListBox;
        private System.Windows.Forms.RichTextBox SaveFailTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox SaveSuccesTBox;
        private System.Windows.Forms.NumericUpDown ModifierNUD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown DiceSizeNUD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SaveTypeCBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown DiceNumberNUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown SaveTargetNUD;
        private System.Windows.Forms.Label label4;
    }
}

