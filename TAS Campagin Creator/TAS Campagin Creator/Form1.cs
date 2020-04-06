using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAS_Campagin_Creator
{
    public partial class MainForm : Form
    {
        Campaign Campaign = new Campaign();

        public MainForm()
        {
            InitializeComponent();
            Campaign.NewModule();
            UpdateModuleBox();
            CampaignNameLabel.Text = Campaign.Name;
        }

        #region Menu Bar

        #region File

        private void NewCampaignButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveCampaignButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadCampaignButton_Click(object sender, EventArgs e)
        {

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK) 
                Environment.Exit(1);
        }

        #endregion

        #region Modules

        private void addModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Campaign.NewModule();
            UpdateModuleBox();
        }

        #endregion

        #endregion

        #region Update Interface

        void UpdateModuleBox()
        {
            ModuleBox.Items.Clear();
            foreach (Module Mod in Campaign.Modules)
                ModuleBox.Items.Add(Mod.Name);
        }

        #endregion

    }
}
