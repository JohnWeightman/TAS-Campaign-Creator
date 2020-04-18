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
    public partial class OptionsWindow : Form
    {
        public int OptionNumber;

        #region Form Load

        public OptionsWindow()
        {
            InitializeComponent();
        }

        private void OptionsWindow_Load(object sender, EventArgs e)
        {
            CheckRadioButton();
        }

        public void CheckRadioButton()
        {
            switch (Storage.Campaign.Modules[Storage.ModNum].Options.OptionType[OptionNumber])
            {
                case 0:
                    StoryRButton.Checked = true;
                    break;
                case 1:
                    EncounterRButton.Checked = true;
                    break;
                default:
                    StoryRButton.Checked = true;
                    break;
            }
        }

        #endregion

        #region RadioButtons

        private void StoryRButton_Click(object sender, EventArgs e)
        {
            SetOptionType(0);
        }

        private void EncounterRButton_Click(object sender, EventArgs e)
        {
            SetOptionType(1);
        }

        void SetOptionType(byte OptionType)
        {
            Storage.Campaign.Modules[Storage.ModNum].Options.OptionType[OptionNumber] = OptionType;
        }

        #endregion
    }
}
