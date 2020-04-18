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

        public OptionsWindow()
        {
            InitializeComponent();
        }

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
