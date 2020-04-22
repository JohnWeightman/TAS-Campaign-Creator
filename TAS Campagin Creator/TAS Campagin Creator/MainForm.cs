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
            GameObjects.LoadEnemyNPCs();
            UpdateModuleBox();
            FillEnemyListBox();
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
            Export.ExportCampaign();
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
                DisplayModuleGroupBox();
                ClearRandomControls();
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

       void DisplayModuleGroupBox()
        {
            EncounterGBox.Visible = false;
            if (Storage.Campaign.Modules[Storage.ModNum].ModType == 1)
                EncounterGBox.Visible = true;
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

        #region Module Type Control Functions

        #region Encounter Modules

        private void ClearEnemiesButton_Click(object sender, EventArgs e)
        {
            ModuleEnemiesBox.Text = "";
            Storage.Campaign.Modules[Storage.ModNum].Encounter.EnemyTypes.Clear();
            Storage.Campaign.Modules[Storage.ModNum].Encounter.EnemyNumber.Clear();
        }

        private void EnemyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(EnemyListBox.SelectedItem != null)
            {
                UpdateModuleEncounter(GetNPCString(EnemyListBox.SelectedItem.ToString()));
                UpdateModuleEnemyListBox();
            }
        }

        void FillEnemyListBox()
        {
            for (int x = 0; x < GameObjects.EnemyNPCs.Count; x++)
                EnemyListBox.Items.Add("DB: " + GameObjects.DifBonus[x] + " - " + GameObjects.EnemyNPCs[x]);
        }

        string GetNPCString(string SelectedItem)
        {
            char[] Arr = SelectedItem.ToCharArray();
            int Loc = 0;
            bool Found = false;
            while (!Found)
            {
                if(Arr[Loc] == '-')
                    Found = !Found;
                else
                    Loc += 1;
            }
            string NPC = SelectedItem.Remove(0, Loc + 2);
            return NPC;
        }

        void UpdateModuleEncounter(string NewNPC)
        {
            int EnemyCount = Storage.Campaign.Modules[Storage.ModNum].Encounter.EnemyNumber.Sum(x => Convert.ToInt32(x));
            if(EnemyCount < 7)
            {
                if (Storage.Campaign.Modules[Storage.ModNum].Encounter.EnemyTypes.Count > 0)
                {
                    bool Exists = false;
                    int Loc = 0;
                    foreach (string NPC in Storage.Campaign.Modules[Storage.ModNum].Encounter.EnemyTypes)
                    {
                        if (NewNPC == NPC)
                            Exists = !Exists;
                        else if (NewNPC != NPC && !Exists)
                            Loc += 1;
                    }
                    if (Exists)
                    {
                        Storage.Campaign.Modules[Storage.ModNum].Encounter.EnemyNumber[Loc] += 1;
                    }
                    else
                    {
                        Storage.Campaign.Modules[Storage.ModNum].Encounter.EnemyTypes.Add(NewNPC);
                        Storage.Campaign.Modules[Storage.ModNum].Encounter.EnemyNumber.Add(1);
                    }
                }
                else
                {
                    Storage.Campaign.Modules[Storage.ModNum].Encounter.EnemyTypes.Add(NewNPC);
                    Storage.Campaign.Modules[Storage.ModNum].Encounter.EnemyNumber.Add(1);
                }
            }
        }

        void UpdateModuleEnemyListBox()
        {
            ModuleEnemiesBox.Clear();
            for(int x = 0; x < Storage.Campaign.Modules[Storage.ModNum].Encounter.EnemyTypes.Count; x++)
            {
                ModuleEnemiesBox.Text += Storage.Campaign.Modules[Storage.ModNum].Encounter.EnemyTypes[x] + " x" +
                    Storage.Campaign.Modules[Storage.ModNum].Encounter.EnemyNumber[x] + "\n";
            }
        }

        #endregion

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

        private void StoryRButton_CheckedChanged(object sender, EventArgs e)
        {
            Storage.Campaign.Modules[Storage.ModNum].ModType = 0;
            DisplayModuleGroupBox();
        }

        private void EncounterRButton_CheckedChanged(object sender, EventArgs e)
        {
            Storage.Campaign.Modules[Storage.ModNum].ModType = 1;
            DisplayModuleGroupBox();
        }

        void ClearRandomControls()
        {
            ModuleEnemiesBox.Text = "";
        }

        #endregion
    }
}
