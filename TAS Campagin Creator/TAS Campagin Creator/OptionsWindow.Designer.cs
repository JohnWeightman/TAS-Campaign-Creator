namespace TAS_Campagin_Creator
{
    partial class OptionsWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.StoryRButton = new System.Windows.Forms.RadioButton();
            this.EncounterRButton = new System.Windows.Forms.RadioButton();
            this.UpdateOptionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Option Type";
            // 
            // StoryRButton
            // 
            this.StoryRButton.AutoSize = true;
            this.StoryRButton.Location = new System.Drawing.Point(10, 125);
            this.StoryRButton.Name = "StoryRButton";
            this.StoryRButton.Size = new System.Drawing.Size(62, 21);
            this.StoryRButton.TabIndex = 1;
            this.StoryRButton.TabStop = true;
            this.StoryRButton.Text = "Story";
            this.StoryRButton.UseVisualStyleBackColor = true;
            this.StoryRButton.Click += new System.EventHandler(this.StoryRButton_Click);
            // 
            // EncounterRButton
            // 
            this.EncounterRButton.AutoSize = true;
            this.EncounterRButton.Location = new System.Drawing.Point(10, 155);
            this.EncounterRButton.Name = "EncounterRButton";
            this.EncounterRButton.Size = new System.Drawing.Size(94, 21);
            this.EncounterRButton.TabIndex = 2;
            this.EncounterRButton.TabStop = true;
            this.EncounterRButton.Text = "Encounter";
            this.EncounterRButton.UseVisualStyleBackColor = true;
            this.EncounterRButton.Click += new System.EventHandler(this.EncounterRButton_Click);
            // 
            // UpdateOptionButton
            // 
            this.UpdateOptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateOptionButton.Location = new System.Drawing.Point(10, 10);
            this.UpdateOptionButton.Name = "UpdateOptionButton";
            this.UpdateOptionButton.Size = new System.Drawing.Size(140, 62);
            this.UpdateOptionButton.TabIndex = 10;
            this.UpdateOptionButton.Text = "Update Option";
            this.UpdateOptionButton.UseVisualStyleBackColor = true;
            this.UpdateOptionButton.Click += new System.EventHandler(this.UpdateOptionButton_Click);
            // 
            // OptionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateOptionButton);
            this.Controls.Add(this.EncounterRButton);
            this.Controls.Add(this.StoryRButton);
            this.Controls.Add(this.label1);
            this.Name = "OptionsWindow";
            this.Text = "OptionsWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton StoryRButton;
        private System.Windows.Forms.RadioButton EncounterRButton;
        private System.Windows.Forms.Button UpdateOptionButton;
    }
}