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

        public MainForm()
        {
            InitializeComponent();
            //Storage.Campaign.NewModule();
            Storage.AddTempData();
            UpdateModuleBox();
            CampaignNameLabel.Text = Storage.Campaign.Name;
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
            Export.ExportCampaign(Storage.Campaign);
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
            Storage.Campaign.NewModule();
            UpdateModuleBox();
        }

        #endregion

        #endregion

        #region Update Interface

        void UpdateModuleBox()
        {
            ModuleBox.Items.Clear();
            foreach (Module Mod in Storage.Campaign.Modules)
                ModuleBox.Items.Add(Mod.Name);
        }

        private void ModuleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ModuleBox.SelectedItem != null)
            {
                string Name = ModuleBox.SelectedItem.ToString();
                FindModule(Name);
                ModuleLabel.Text = "Module: " + (Storage.ModNum + 1);
                DisplayModuleStory();
                DisplayModuleOptions();
                DisplayModuleType();
            }
        }

        void FindModule(string Name)
        {
            Storage.ModNum = 0;
            foreach (Module Mod in Storage.Campaign.Modules)
            {
                if (Name == Mod.Name)
                    break;
                Storage.ModNum += 1;
            }
        }

        void DisplayModuleStory()
        {
            StoryBox.Clear();
            int Count = Storage.Campaign.Modules[Storage.ModNum].Story.Count;
            foreach (string Text in Storage.Campaign.Modules[Storage.ModNum].Story)
            {
                StoryBox.Text += Text + "//";
            }
            int Length = StoryBox.Text.Length;
            StoryBox.Text = StoryBox.Text.Remove((Length - 2), 2);
        }

        void DisplayModuleOptions()
        {
            OptionsBox.Clear();
            OptionsBox2.Items.Clear();
            foreach (string Option in Storage.Campaign.Modules[Storage.ModNum].Options.OptionsList)
            {
                OptionsBox.Text += Option + "//";
            }
            int Length = OptionsBox.Text.Length;
            OptionsBox.Text = OptionsBox.Text.Remove((Length - 2), 2);
            UpdateOptionBox2();
        }

        void DisplayModuleType()
        {
            switch (Storage.Campaign.Modules[Storage.ModNum].ModType)
            {
                case 0:
                    StoryRButton.Checked = true;
                    break;
                case 1:
                    EncounterRButton.Checked = true;
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Update Module Data

        private void UpdateModuleButton_Click(object sender, EventArgs e)
        {
            UpdateModuleType();
            UpdateModuleStory();
            UpdateModuleOptions();
            UpdateModuleOptionDirections();
            UpdateOptionBox2();
        }

        void UpdateModuleType()
        {
            if (StoryRButton.Checked)
                Storage.Campaign.Modules[Storage.ModNum].ModType = 0;
            else
                Storage.Campaign.Modules[Storage.ModNum].ModType = 1;
        }

        void UpdateModuleStory()
        {
            List<string> StoryText = SplitIntoStrings(StoryBox.Text);
            Storage.Campaign.Modules[Storage.ModNum].Story = StoryText;
        }

        void UpdateModuleOptions()
        {
            List<string> Options = SplitIntoStrings(OptionsBox.Text);
            Storage.Campaign.Modules[Storage.ModNum].Options.OptionsList = Options;
        }

        void UpdateOptionBox2()
        {
            OptionsBox2.Items.Clear();
            foreach (string Option in Storage.Campaign.Modules[Storage.ModNum].Options.OptionsList)
                OptionsBox2.Items.Add(Option);
        }

        void UpdateModuleOptionDirections()
        {
            Storage.Campaign.Modules[Storage.ModNum].Options.OptionDirections.Clear();
            foreach (string Option in Storage.Campaign.Modules[Storage.ModNum].Options.OptionsList)
                Storage.Campaign.Modules[Storage.ModNum].Options.OptionDirections.Add(0);
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

        private void OptionsBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CurItem = OptionsBox2.SelectedItem.ToString();
            int Index = OptionsBox2.FindString(CurItem);
            OptionDirection OptDir = new OptionDirection();
            OptDir.OptionNumber = Index;
            OptDir.Show();
        }

        #endregion

    }
}
