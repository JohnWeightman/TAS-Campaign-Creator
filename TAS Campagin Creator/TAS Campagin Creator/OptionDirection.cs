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
    public partial class OptionDirection : Form
    {
        public int OptionNumber;

        public OptionDirection()
        {
            InitializeComponent();
        }

        private void OptionDirection_Load(object sender, EventArgs e)
        {
            //if (Storage.Campaign.Modules[Storage.ModNum].Options.OptionDirections[OptionNumber] != 0)
            textBox1.Text = Storage.Campaign.Modules[Storage.ModNum].Options.OptionDirectionStrings[OptionNumber].Remove(0, 6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Check = Convert.ToInt32(textBox1.Text);
            if(Check > 0 && Check <= Storage.Campaign.Modules.Count)
            {
                Storage.Campaign.Modules[Storage.ModNum].Options.OptionDirectionStrings[OptionNumber] = "Module" + textBox1.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Module: " + Check + " Doesn't exist! Please enter a module number that exists {Modules 1-" + Storage.Campaign.Modules.Count +
                    "}", "Module Error");
                textBox1.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
