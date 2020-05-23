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
    public partial class CampaignSettings : Form
    {
        public CampaignSettings()
        {
            InitializeComponent();
        }

        private void SettingsLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SettingsLBox.SelectedItem != null)
            {
                switch (SettingsLBox.SelectedIndex)
                {
                    case 0:
                        GeneralGBox.Visible = true;
                        break;
                    case 1:
                        EnemeisGBox.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        void HideGroupBoxes()
        {
            GeneralGBox.Visible = false;
            EnemeisGBox.Visible = false;
        }
    }
}
