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
        public byte OptionType = 0;

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

        void SetOptionType(byte OptionTypeArg)
        {
            OptionType = OptionTypeArg;
        }

        #endregion

        private void UpdateOptionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
