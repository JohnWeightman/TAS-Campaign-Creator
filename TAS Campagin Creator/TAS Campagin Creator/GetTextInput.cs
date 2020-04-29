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
    public partial class GetTextInput : Form
    {
        public MainForm MyParent { get; set; }
        public string Text;
        public int Arg;

        public GetTextInput()
        {
            InitializeComponent();
        }

        private void GetTextInput_Load(object sender, EventArgs e)
        {
            textBox1.Text = Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                UpdateDisplay();
        }

        void UpdateDisplay()
        {
            switch (Arg)
            {
                case 0:
                    UpdateCampaignName();
                    break;
                default:
                    break;
            }
        }

        void UpdateCampaignName()
        {
            Storage.Campaign.Name = textBox1.Text;
            this.MyParent.UpdateCampaignLabel();
            this.Close();
        }

    }
}
