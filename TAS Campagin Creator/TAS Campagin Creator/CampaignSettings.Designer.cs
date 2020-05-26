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
            this.label1 = new System.Windows.Forms.Label();
            this.EnemeisGBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NHCUDRed = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.NHCUDDarkYellow = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.NHCUDDarkGreen = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.NHCUDGreen = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerGBox = new System.Windows.Forms.GroupBox();
            this.LUITBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FLUTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SetStatsCBox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.StrUD = new System.Windows.Forms.NumericUpDown();
            this.DexUD = new System.Windows.Forms.NumericUpDown();
            this.ConUD = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.StartWeaponCBox = new System.Windows.Forms.ComboBox();
            this.StartArmourCBox = new System.Windows.Forms.ComboBox();
            this.StrModLabel = new System.Windows.Forms.Label();
            this.DexModLabel = new System.Windows.Forms.Label();
            this.ConModLabel = new System.Windows.Forms.Label();
            this.GeneralGBox.SuspendLayout();
            this.EnemeisGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDDarkYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDDarkGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDGreen)).BeginInit();
            this.PlayerGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StrUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConUD)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsLBox
            // 
            this.SettingsLBox.FormattingEnabled = true;
            this.SettingsLBox.ItemHeight = 16;
            this.SettingsLBox.Items.AddRange(new object[] {
            "General",
            "Player",
            "Enemies"});
            this.SettingsLBox.Location = new System.Drawing.Point(10, 10);
            this.SettingsLBox.Name = "SettingsLBox";
            this.SettingsLBox.Size = new System.Drawing.Size(200, 676);
            this.SettingsLBox.TabIndex = 0;
            this.SettingsLBox.SelectedIndexChanged += new System.EventHandler(this.SettingsLBox_SelectedIndexChanged);
            // 
            // GeneralGBox
            // 
            this.GeneralGBox.Controls.Add(this.label1);
            this.GeneralGBox.Location = new System.Drawing.Point(215, 10);
            this.GeneralGBox.Name = "GeneralGBox";
            this.GeneralGBox.Size = new System.Drawing.Size(955, 675);
            this.GeneralGBox.TabIndex = 1;
            this.GeneralGBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "General";
            // 
            // EnemeisGBox
            // 
            this.EnemeisGBox.Controls.Add(this.label11);
            this.EnemeisGBox.Controls.Add(this.label10);
            this.EnemeisGBox.Controls.Add(this.NHCUDRed);
            this.EnemeisGBox.Controls.Add(this.label9);
            this.EnemeisGBox.Controls.Add(this.NHCUDDarkYellow);
            this.EnemeisGBox.Controls.Add(this.label8);
            this.EnemeisGBox.Controls.Add(this.NHCUDDarkGreen);
            this.EnemeisGBox.Controls.Add(this.label7);
            this.EnemeisGBox.Controls.Add(this.NHCUDGreen);
            this.EnemeisGBox.Controls.Add(this.label6);
            this.EnemeisGBox.Controls.Add(this.label2);
            this.EnemeisGBox.Location = new System.Drawing.Point(215, 10);
            this.EnemeisGBox.Name = "EnemeisGBox";
            this.EnemeisGBox.Size = new System.Drawing.Size(955, 675);
            this.EnemeisGBox.TabIndex = 2;
            this.EnemeisGBox.TabStop = false;
            this.EnemeisGBox.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(341, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Nameplate Health Colour: Dark Red (%)";
            // 
            // NHCUDRed
            // 
            this.NHCUDRed.Location = new System.Drawing.Point(375, 160);
            this.NHCUDRed.Name = "NHCUDRed";
            this.NHCUDRed.Size = new System.Drawing.Size(120, 22);
            this.NHCUDRed.TabIndex = 10;
            this.NHCUDRed.ValueChanged += new System.EventHandler(this.NHCUDRed_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(298, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nameplate Health Colour: Red (%)";
            // 
            // NHCUDDarkYellow
            // 
            this.NHCUDDarkYellow.Location = new System.Drawing.Point(375, 130);
            this.NHCUDDarkYellow.Name = "NHCUDDarkYellow";
            this.NHCUDDarkYellow.Size = new System.Drawing.Size(120, 22);
            this.NHCUDDarkYellow.TabIndex = 8;
            this.NHCUDDarkYellow.ValueChanged += new System.EventHandler(this.NHCUDDarkYellow_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(362, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nameplate Health Colour: Dark Yellow (%)";
            // 
            // NHCUDDarkGreen
            // 
            this.NHCUDDarkGreen.Location = new System.Drawing.Point(375, 100);
            this.NHCUDDarkGreen.Name = "NHCUDDarkGreen";
            this.NHCUDDarkGreen.Size = new System.Drawing.Size(120, 22);
            this.NHCUDDarkGreen.TabIndex = 6;
            this.NHCUDDarkGreen.ValueChanged += new System.EventHandler(this.NHCUDDarkGreen_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(359, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nameplate Health Colour: Dark Green (%)";
            // 
            // NHCUDGreen
            // 
            this.NHCUDGreen.Location = new System.Drawing.Point(375, 70);
            this.NHCUDGreen.Name = "NHCUDGreen";
            this.NHCUDGreen.Size = new System.Drawing.Size(120, 22);
            this.NHCUDGreen.TabIndex = 4;
            this.NHCUDGreen.ValueChanged += new System.EventHandler(this.NHCUDGreen_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nameplate Health Colour: Green (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enemies";
            // 
            // PlayerGBox
            // 
            this.PlayerGBox.Controls.Add(this.ConModLabel);
            this.PlayerGBox.Controls.Add(this.DexModLabel);
            this.PlayerGBox.Controls.Add(this.StrModLabel);
            this.PlayerGBox.Controls.Add(this.StartArmourCBox);
            this.PlayerGBox.Controls.Add(this.StartWeaponCBox);
            this.PlayerGBox.Controls.Add(this.HealthLabel);
            this.PlayerGBox.Controls.Add(this.label15);
            this.PlayerGBox.Controls.Add(this.ConUD);
            this.PlayerGBox.Controls.Add(this.DexUD);
            this.PlayerGBox.Controls.Add(this.StrUD);
            this.PlayerGBox.Controls.Add(this.label14);
            this.PlayerGBox.Controls.Add(this.label13);
            this.PlayerGBox.Controls.Add(this.label12);
            this.PlayerGBox.Controls.Add(this.SetStatsCBox);
            this.PlayerGBox.Controls.Add(this.LUITBox);
            this.PlayerGBox.Controls.Add(this.label5);
            this.PlayerGBox.Controls.Add(this.FLUTBox);
            this.PlayerGBox.Controls.Add(this.label4);
            this.PlayerGBox.Controls.Add(this.label3);
            this.PlayerGBox.Location = new System.Drawing.Point(215, 10);
            this.PlayerGBox.Name = "PlayerGBox";
            this.PlayerGBox.Size = new System.Drawing.Size(955, 675);
            this.PlayerGBox.TabIndex = 3;
            this.PlayerGBox.TabStop = false;
            this.PlayerGBox.Visible = false;
            // 
            // LUITBox
            // 
            this.LUITBox.Location = new System.Drawing.Point(200, 105);
            this.LUITBox.Name = "LUITBox";
            this.LUITBox.Size = new System.Drawing.Size(175, 22);
            this.LUITBox.TabIndex = 5;
            this.LUITBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LUITBox_KeyPress);
            this.LUITBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LUITBox_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Level Up Increase";
            // 
            // FLUTBox
            // 
            this.FLUTBox.Location = new System.Drawing.Point(200, 70);
            this.FLUTBox.Name = "FLUTBox";
            this.FLUTBox.Size = new System.Drawing.Size(175, 22);
            this.FLUTBox.TabIndex = 3;
            this.FLUTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FLUTBox_KeyPress);
            this.FLUTBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FLUTBox_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "First Level Up";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Player";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(372, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "1";
            // 
            // SetStatsCBox
            // 
            this.SetStatsCBox.AutoSize = true;
            this.SetStatsCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetStatsCBox.Location = new System.Drawing.Point(425, 70);
            this.SetStatsCBox.Name = "SetStatsCBox";
            this.SetStatsCBox.Size = new System.Drawing.Size(210, 28);
            this.SetStatsCBox.TabIndex = 6;
            this.SetStatsCBox.Text = "Set Players Start Stats";
            this.SetStatsCBox.UseVisualStyleBackColor = true;
            this.SetStatsCBox.CheckedChanged += new System.EventHandler(this.SetStatsCBox_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(425, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 24);
            this.label12.TabIndex = 7;
            this.label12.Text = "Strength";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(425, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 24);
            this.label13.TabIndex = 8;
            this.label13.Text = "Dexterity";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(425, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 24);
            this.label14.TabIndex = 9;
            this.label14.Text = "Constitution";
            // 
            // StrUD
            // 
            this.StrUD.Enabled = false;
            this.StrUD.Location = new System.Drawing.Point(575, 100);
            this.StrUD.Name = "StrUD";
            this.StrUD.Size = new System.Drawing.Size(60, 22);
            this.StrUD.TabIndex = 10;
            this.StrUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.StrUD.ValueChanged += new System.EventHandler(this.StrUD_ValueChanged);
            // 
            // DexUD
            // 
            this.DexUD.Enabled = false;
            this.DexUD.Location = new System.Drawing.Point(575, 130);
            this.DexUD.Name = "DexUD";
            this.DexUD.Size = new System.Drawing.Size(60, 22);
            this.DexUD.TabIndex = 11;
            this.DexUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DexUD.ValueChanged += new System.EventHandler(this.DexUD_ValueChanged);
            // 
            // ConUD
            // 
            this.ConUD.Enabled = false;
            this.ConUD.Location = new System.Drawing.Point(575, 160);
            this.ConUD.Name = "ConUD";
            this.ConUD.Size = new System.Drawing.Size(60, 22);
            this.ConUD.TabIndex = 12;
            this.ConUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ConUD.ValueChanged += new System.EventHandler(this.ConUD_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(425, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 24);
            this.label15.TabIndex = 13;
            this.label15.Text = "Health";
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthLabel.Location = new System.Drawing.Point(575, 190);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(30, 24);
            this.HealthLabel.TabIndex = 14;
            this.HealthLabel.Text = "13";
            this.HealthLabel.Visible = false;
            // 
            // StartWeaponCBox
            // 
            this.StartWeaponCBox.Enabled = false;
            this.StartWeaponCBox.FormattingEnabled = true;
            this.StartWeaponCBox.Location = new System.Drawing.Point(725, 100);
            this.StartWeaponCBox.Name = "StartWeaponCBox";
            this.StartWeaponCBox.Size = new System.Drawing.Size(150, 24);
            this.StartWeaponCBox.TabIndex = 15;
            this.StartWeaponCBox.SelectedIndexChanged += new System.EventHandler(this.StartWeaponCBox_SelectedIndexChanged);
            // 
            // StartArmourCBox
            // 
            this.StartArmourCBox.Enabled = false;
            this.StartArmourCBox.FormattingEnabled = true;
            this.StartArmourCBox.Location = new System.Drawing.Point(725, 130);
            this.StartArmourCBox.Name = "StartArmourCBox";
            this.StartArmourCBox.Size = new System.Drawing.Size(150, 24);
            this.StartArmourCBox.TabIndex = 16;
            this.StartArmourCBox.SelectedIndexChanged += new System.EventHandler(this.StartArmourCBox_SelectedIndexChanged);
            // 
            // StrModLabel
            // 
            this.StrModLabel.AutoSize = true;
            this.StrModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrModLabel.Location = new System.Drawing.Point(650, 100);
            this.StrModLabel.Name = "StrModLabel";
            this.StrModLabel.Size = new System.Drawing.Size(31, 24);
            this.StrModLabel.TabIndex = 17;
            this.StrModLabel.Text = "+3";
            // 
            // DexModLabel
            // 
            this.DexModLabel.AutoSize = true;
            this.DexModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexModLabel.Location = new System.Drawing.Point(650, 130);
            this.DexModLabel.Name = "DexModLabel";
            this.DexModLabel.Size = new System.Drawing.Size(31, 24);
            this.DexModLabel.TabIndex = 18;
            this.DexModLabel.Text = "+3";
            // 
            // ConModLabel
            // 
            this.ConModLabel.AutoSize = true;
            this.ConModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConModLabel.Location = new System.Drawing.Point(650, 160);
            this.ConModLabel.Name = "ConModLabel";
            this.ConModLabel.Size = new System.Drawing.Size(31, 24);
            this.ConModLabel.TabIndex = 19;
            this.ConModLabel.Text = "+3";
            // 
            // CampaignSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.SettingsLBox);
            this.Controls.Add(this.PlayerGBox);
            this.Controls.Add(this.EnemeisGBox);
            this.Controls.Add(this.GeneralGBox);
            this.Name = "CampaignSettings";
            this.Text = "Campaign Settings";
            this.GeneralGBox.ResumeLayout(false);
            this.GeneralGBox.PerformLayout();
            this.EnemeisGBox.ResumeLayout(false);
            this.EnemeisGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDDarkYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDDarkGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDGreen)).EndInit();
            this.PlayerGBox.ResumeLayout(false);
            this.PlayerGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StrUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SettingsLBox;
        private System.Windows.Forms.GroupBox GeneralGBox;
        private System.Windows.Forms.GroupBox EnemeisGBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox PlayerGBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FLUTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LUITBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NHCUDRed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NHCUDDarkYellow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NHCUDDarkGreen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NHCUDGreen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox SetStatsCBox;
        private System.Windows.Forms.NumericUpDown ConUD;
        private System.Windows.Forms.NumericUpDown DexUD;
        private System.Windows.Forms.NumericUpDown StrUD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox StartArmourCBox;
        private System.Windows.Forms.ComboBox StartWeaponCBox;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label StrModLabel;
        private System.Windows.Forms.Label ConModLabel;
        private System.Windows.Forms.Label DexModLabel;
    }
}