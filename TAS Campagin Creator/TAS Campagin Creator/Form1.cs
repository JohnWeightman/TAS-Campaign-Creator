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
    public partial class MainForm : Form
    {
        Campaign Campaign = new Campaign();
        int ModNum = 0;

        public MainForm()
        {
            InitializeComponent();
            Campaign.NewModule();
            UpdateModuleBox();
            CampaignNameLabel.Text = Campaign.Name;
        }

        #region Menu Bar

        #region File

        private void NewCampaignButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveCampaignButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadCampaignButton_Click(object sender, EventArgs e)
        {

        }

        private void exportCampaignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export.ExportCampaign(Campaign);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK) 
                Environment.Exit(1);
        }

        #endregion

        #region Modules

        private void addModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Campaign.NewModule();
            UpdateModuleBox();
        }

        #endregion

        #endregion

        #region Update Interface

        void UpdateModuleBox()
        {
            ModuleBox.Items.Clear();
            foreach (Module Mod in Campaign.Modules)
                ModuleBox.Items.Add(Mod.Name);
        }

        private void ModuleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ModuleBox.SelectedItem != null)
            {
                string Name = ModuleBox.SelectedItem.ToString();
                FindModule(Name);
                ModuleLabel.Text = "Module: " + (ModNum + 1);
                DisplayModuleStory();
                DisplayModuleOptions();
            }
        }

        void FindModule(string Name)
        {
            ModNum = 0;
            foreach (Module Mod in Campaign.Modules)
            {
                if (Name == Mod.Name)
                    break;
                ModNum += 1;
            }
        }

        void DisplayModuleStory()
        {
            StoryBox.Clear();
            int Count = Campaign.Modules[ModNum].Story.Count;
            foreach (string Text in Campaign.Modules[ModNum].Story)
            {
                StoryBox.Text += Text;
                Count--;
                if (Count > 0)
                    StoryBox.Text += "//";
            }
        }

        void DisplayModuleOptions()
        {
            OptionsBox.Clear();
            OptionsBox2.Items.Clear();
            int Count = Campaign.Modules[ModNum].Story.Count;
            foreach (string Option in Campaign.Modules[ModNum].Options.OptionsList)
            {
                OptionsBox.Text += Option;
                Count--;
                if (Count > 0)
                    OptionsBox.Text += "//";
            }
            UpdateOptionBox2();
        }

        #endregion

        #region Update Module Data

        private void UpdateModuleButton_Click(object sender, EventArgs e)
        {
            UpdateModuleStory();
            UpdateModuleOptions();
            UpdateOptionBox2();
        }

        void UpdateModuleStory()
        {
            List<string> StoryText = SplitIntoStrings(StoryBox.Text);
            Campaign.Modules[ModNum].Story = StoryText;
        }

        void UpdateModuleOptions()
        {
            List<string> Options = SplitIntoStrings(OptionsBox.Text);
            Campaign.Modules[ModNum].Options.OptionsList = Options;
        }

        List<string> SplitIntoStrings(string StoryText)
        {
            List<string> Story = new List<string>();
            bool Done = false;
            while (!Done)
            {
                char[] CharString = StoryText.ToCharArray();
                if (CharString.Length == 0)
                    break;
                bool Found = false;
                int Count = 0;
                while (!Found)
                {
                    if (CharString[Count] == '/')
                    {
                        if (CharString[Count + 1] == '/')
                        {
                            char[] chars = StoryText.ToCharArray(0, Count);
                            string Temp = new string(chars);
                            Story.Add(Temp);
                            StoryText = StoryText.Substring(Count + 2);
                            Found = true;
                        }
                    }
                    else
                    {
                        Count++;
                        if (Count == CharString.Length)
                        {
                            break;
                        }
                    }
                }
                Done = CheckForSlashes(StoryText.ToCharArray());
                if(Done)
                    Story.Add(StoryText);
            }
            return Story;
        }

        bool CheckForSlashes(char[] CharString)
        {
            bool NoSlashes = true;
            for(int x = 0; x < CharString.Length; x++)
            {
                if(CharString[x] == '/')
                {
                    if(CharString[x] == '/')
                    {
                        NoSlashes = false;
                        break;
                    }
                }
            }
            return NoSlashes;
        }

        #endregion

        #region Other Functions

        void UpdateOptionBox2()
        {
            foreach (string Option in Campaign.Modules[ModNum].Options.OptionsList)
                OptionsBox2.Items.Add(Option);
        }

        private void OptionsBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OptionsWindow OptWin = new OptionsWindow();
            OptWin.Show();
        }

        #endregion

    }
}
