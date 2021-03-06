﻿using System;
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
            foreach(Module Mod in Storage.Campaign.Modules)
            {
                if(Mod.ID == Storage.Campaign.Modules[Storage.ModNum].Options.OptionDirectionStrings[OptionNumber])
                {
                    textBox1.Text = Mod.Name;
                    break;
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CheckInput();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckInput();
        }

        void CheckInput()
        {
            string Check = textBox1.Text;
            bool Found = false;
            foreach (Module Mod in Storage.Campaign.Modules)
            {
                if (Check == Mod.Name)
                {
                    Storage.Campaign.Modules[Storage.ModNum].Options.OptionDirectionStrings[OptionNumber] = Mod.ID;
                    Found = true;
                    this.Close();
                }
            }
            if (!Found)
            {
                MessageBox.Show(Check + " Doesn't exist! Please enter a valid module name!", "Module Error");
                textBox1.Text = "";
            }
        }
    }
}
