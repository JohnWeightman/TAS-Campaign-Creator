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
        public string Text;

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
            Storage.Campaign.Name = textBox1.Text;
        }
    }
}
