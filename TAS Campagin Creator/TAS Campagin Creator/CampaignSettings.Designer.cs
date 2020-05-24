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
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerGBox = new System.Windows.Forms.GroupBox();
            this.FLUTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LUITBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NHCUDGreen = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.NHCUDDarkGreen = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.NHCUDDarkYellow = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.NHCUDRed = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.NHCUDDarkRed = new System.Windows.Forms.NumericUpDown();
            this.GeneralGBox.SuspendLayout();
            this.EnemeisGBox.SuspendLayout();
            this.PlayerGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDDarkGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDDarkYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDDarkRed)).BeginInit();
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
            this.EnemeisGBox.Controls.Add(this.NHCUDDarkRed);
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
            // LUITBox
            // 
            this.LUITBox.Location = new System.Drawing.Point(200, 105);
            this.LUITBox.Name = "LUITBox";
            this.LUITBox.Size = new System.Drawing.Size(175, 22);
            this.LUITBox.TabIndex = 5;
            this.LUITBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LUITBox_KeyPress);
            this.LUITBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LUITBox_KeyUp);
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
            // NHCUDGreen
            // 
            this.NHCUDGreen.Location = new System.Drawing.Point(375, 70);
            this.NHCUDGreen.Name = "NHCUDGreen";
            this.NHCUDGreen.Size = new System.Drawing.Size(120, 22);
            this.NHCUDGreen.TabIndex = 4;
            this.NHCUDGreen.ValueChanged += new System.EventHandler(this.NHCUDGreen_ValueChanged);
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
            // NHCUDDarkGreen
            // 
            this.NHCUDDarkGreen.Location = new System.Drawing.Point(375, 100);
            this.NHCUDDarkGreen.Name = "NHCUDDarkGreen";
            this.NHCUDDarkGreen.Size = new System.Drawing.Size(120, 22);
            this.NHCUDDarkGreen.TabIndex = 6;
            this.NHCUDDarkGreen.ValueChanged += new System.EventHandler(this.NHCUDDarkGreen_ValueChanged);
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
            // NHCUDDarkYellow
            // 
            this.NHCUDDarkYellow.Location = new System.Drawing.Point(375, 130);
            this.NHCUDDarkYellow.Name = "NHCUDDarkYellow";
            this.NHCUDDarkYellow.Size = new System.Drawing.Size(120, 22);
            this.NHCUDDarkYellow.TabIndex = 8;
            this.NHCUDDarkYellow.ValueChanged += new System.EventHandler(this.NHCUDDarkYellow_ValueChanged);
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
            // NHCUDRed
            // 
            this.NHCUDRed.Location = new System.Drawing.Point(375, 160);
            this.NHCUDRed.Name = "NHCUDRed";
            this.NHCUDRed.Size = new System.Drawing.Size(120, 22);
            this.NHCUDRed.TabIndex = 10;
            this.NHCUDRed.ValueChanged += new System.EventHandler(this.NHCUDRed_ValueChanged);
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
            // NHCUDDarkRed
            // 
            this.NHCUDDarkRed.Location = new System.Drawing.Point(375, 190);
            this.NHCUDDarkRed.Name = "NHCUDDarkRed";
            this.NHCUDDarkRed.Size = new System.Drawing.Size(120, 22);
            this.NHCUDDarkRed.TabIndex = 12;
            this.NHCUDDarkRed.ValueChanged += new System.EventHandler(this.NHCUDDarkRed_ValueChanged);
            // 
            // CampaignSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.SettingsLBox);
            this.Controls.Add(this.EnemeisGBox);
            this.Controls.Add(this.GeneralGBox);
            this.Controls.Add(this.PlayerGBox);
            this.Name = "CampaignSettings";
            this.Text = "Campaign Settings";
            this.GeneralGBox.ResumeLayout(false);
            this.GeneralGBox.PerformLayout();
            this.EnemeisGBox.ResumeLayout(false);
            this.EnemeisGBox.PerformLayout();
            this.PlayerGBox.ResumeLayout(false);
            this.PlayerGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDDarkGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDDarkYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHCUDDarkRed)).EndInit();
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
        private System.Windows.Forms.NumericUpDown NHCUDDarkRed;
        private System.Windows.Forms.Label label10;
    }
}