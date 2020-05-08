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
        public bool NumOnly = false;

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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NumOnly)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        void UpdateDisplay()
        {
            switch (Arg)
            {
                case 0:
                    UpdateCampaignName();
                    break;
                case 1:
                    UpdateItemCost();
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

        void UpdateItemCost()
        {
            this.MyParent.UpdateShopStockDisplay(Convert.ToInt32(textBox1.Text));
            this.Close();
        }
    }
}
