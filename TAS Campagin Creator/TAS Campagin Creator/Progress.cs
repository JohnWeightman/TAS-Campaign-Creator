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
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }

        public void InitiliaseProgressBar(int JobCount)
        {
            ProLabel.Text = "Progress: 0% - Job 0 of 0";
            ProBar.Value = 0;
            ProBar.Maximum = JobCount;
        }

        public void UpdateProgress(int CurJob)
        {
            decimal Percent = CalculatePercentage(CurJob);
            ProBar.Value = CurJob;
            ProLabel.Text = "Progress: " + Percent + "% - Job " + CurJob + " of " + ProBar.Maximum;
        }

        decimal CalculatePercentage(int CurJob)
        {
            decimal Percent = (CurJob / ProBar.Maximum) * 100;
            Percent = Math.Round(Percent, 1);
            return Percent;
        }
    }
}
