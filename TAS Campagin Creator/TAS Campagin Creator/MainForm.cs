using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TAS_Campagin_Creator
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            Storage.Campaign.NewModule();
            //Storage.AddTempData();
            //Storage.PlayableCampaign();
            GameObjects.LoadEnemyNPCs();
            UpdateModuleBox();
            FillModuleTypeControls();
            CampaignNameLabel.Text = Storage.Campaign.Name;
        }

        #region Menu Bar

        #region File

        private void NewCampaignButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to start a new campaign?", "New Campaign", buttons);
            if (result == DialogResult.Yes)
            {
                Storage.Campaign.Name = "Campaign1";
                Storage.Campaign.Modules.Clear();
                Storage.Campaign.NewModule();
                UpdateDisplay(Storage.Campaign.Modules[0].Name, false);
            }
        }

        private void SaveCampaignButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog Save = new SaveFileDialog();
            if(Save.ShowDialog() == DialogResult.OK)
            {
                SerializeData.SaveToBinary(Save.FileName);
            }
        }

        private void LoadCampaignButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            if(Open.ShowDialog() == DialogResult.OK)
            {
                Storage.Campaign.Modules.Clear();
                SerializeData.LoadFromBinary(Open.FileName);
                UpdateDisplay(Storage.Campaign.Modules[0].Name, false);
            }
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

        #region Campaign

        private void renameCampaignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetTextInput GTI = new GetTextInput();
            GTI.MyParent = this;
            GTI.Arg = 0;
            GTI.Text = Storage.Campaign.Name;
            GTI.Show();
        }

        private void addModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Storage.Campaign.NewModule();
            UpdateModuleBox();
        }

        private void removeModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Storage.Campaign.Modules.Remove(Storage.Campaign.Modules[Storage.ModNum]);
            if (Storage.ModNum < Storage.Campaign.Modules.Count && Storage.ModNum >= 1 && Storage.Campaign.Modules.Count > 0)
                UpdateDisplay(Storage.Campaign.Modules[Storage.ModNum - 1].Name, false);
            else if (Storage.Campaign.Modules.Count > 0)
                UpdateDisplay(Storage.Campaign.Modules[0].Name, false);
            else
            {
                Storage.Campaign.NewModule();
                UpdateDisplay(Storage.Campaign.Modules[0].Name, false);
            }
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
            if (ModuleBox.SelectedItem != null)
            {
                UpdateDisplay(ModuleBox.SelectedItem.ToString(), true);
            }
        }

        void UpdateDisplay(string Name, bool UpMod)
        {
            if(UpMod)
                UpdateModuleData();
            FindModule(Name);
            ModNameTBox.Text = Storage.Campaign.Modules[Storage.ModNum].Name;
            DisplayModuleStory();
            DisplayModuleOptions();
            DisplayModuleType();
            DisplayModuleGroupBox();
            UpdateModuleEnemyListBox();
            ClearRandomControls();
            UpdateModuleBox();
        }

        void FindModule(string Name)
        {
            Storage.ModNum = 0;
            foreach (Module Mod in Storage.Campaign.Modules)
            {
                if (Name == Mod.Name)
                {
                    Storage.SelMod = Mod.ID;
                    break;
                }
                Storage.ModNum += 1;
            }
        }

        void DisplayModuleStory()
        {
            StoryBox.Clear();
            int Count = Storage.Campaign.Modules[Storage.ModNum].Story.Count;
            if(Count > 0)
            {
                foreach (string Text in Storage.Campaign.Modules[Storage.ModNum].Story)
                {
                    StoryBox.Text += Text + "//";
                }
                int Length = StoryBox.Text.Length;
                StoryBox.Text = StoryBox.Text.Remove((Length - 2), 2);
            }
        }

        void DisplayModuleOptions()
        {
            OptionsBox.Clear();
            OptionsBox2.Items.Clear();
            int Count = Storage.Campaign.Modules[Storage.ModNum].Options.OptionsList.Count;
            if(Count > 0)
            {
                foreach (string Option in Storage.Campaign.Modules[Storage.ModNum].Options.OptionsList)
                {
                    OptionsBox.Text += Option + "//";
                }
                int Length = OptionsBox.Text.Length;
                OptionsBox.Text = OptionsBox.Text.Remove((Length - 2), 2);
                UpdateOptionBox2();
            }
        }

        void DisplayModuleType()
        {
            switch (Storage.Campaign.Modules[Storage.ModNum].ModType)
            {
                case 0:
                    ModTypeCBox.SelectedItem = "Story Module";
                    break;
                case 1:
                    ModTypeCBox.SelectedItem = "Encounter Module";
                    break;
                case 2:
                    ModTypeCBox.SelectedItem = "Shop Module";
                    break;
                default:
                    break;
            }
        }

       void DisplayModuleGroupBox()
        {
            EncounterGBox.Visible = false;
            ShopGBox.Visible = false;
            switch (Storage.Campaign.Modules[Storage.ModNum].ModType)
            {
                case 1:
                    EncounterGBox.Visible = true;
                    break;
                case 2:
                    ShopGBox.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void OptionsBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OptionsBox2.SelectedItem != null)
            {
                string CurItem = OptionsBox2.SelectedItem.ToString();
                int Index = OptionsBox2.FindString(CurItem);
                OptionDirection OptDir = new OptionDirection();
                OptDir.OptionNumber = Index;
                OptDir.Show();
            }
        }

        #endregion

        #region Update Module Data

        void UpdateModuleData()
        {
            UpdateModuleStory();
            UpdateModuleOptions();
            UpdateOptionBox2();
            if(ModNameTBox.Text != "")
                Storage.Campaign.Modules[Storage.ModNum].Name = ModNameTBox.Text;
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
            while (Storage.Campaign.Modules[Storage.ModNum].Options.OptionDirectionStrings.Count < Storage.Campaign.Modules[Storage.ModNum].Options.OptionsList.Count)
                Storage.Campaign.Modules[Storage.ModNum].Options.OptionDirectionStrings.Add("");
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

        #region Module Type Controls

        private void ModTypeCBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ModTypeCBox.SelectedItem != null)
            {
                switch (ModTypeCBox.SelectedIndex)
                {
                    case 0:
                        Storage.Campaign.Modules[Storage.ModNum].ModType = 0;
                        break;
                    case 1:
                        Storage.Campaign.Modules[Storage.ModNum].ModType = 1;
                        break;
                    case 2:
                        Storage.Campaign.Modules[Storage.ModNum].ModType = 2;
                        break;
                    default:
                        break;
                }
                DisplayModuleGroupBox();
            }
        }

        void FillModuleTypeControls()
        {
            FillEnemyListBox();
            FillItemsListBox(0);
        }

        #endregion

        #region Encounter Module

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
            for (int x = 0; x < GameObjects.NPC.EnemyNPCs.Count; x++)
                EnemyListBox.Items.Add("DB: " + GameObjects.NPC.DifBonus[x] + " - " + GameObjects.NPC.EnemyNPCs[x]);
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

        #region Shop Module

        private void ItemTypeCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillItemsListBox(ItemTypeCBox.SelectedIndex);
        }

        void FillItemsListBox(int Option)
        {
            ItemListBox.Items.Clear();
            switch (Option)
            {
                case 1:
                    ItemsAddWeapons(false);
                    break;
                case 2:
                    ItemsAddArmour(false);
                    break;
                default:
                    ItemsAddWeapons(true);
                    ItemsAddArmour(true);
                    break;
            }
        }

        void ItemsAddWeapons(bool Type)
        {
            if (Type)
            {
                ItemListBox.Items.Add("Weapons");
                ItemListBox.Items.Add("");
            }
            for(int x = 0; x < GameObjects.Weapons.WeaponsList.Count; x++)
            {

                if (!GameObjects.Weapons.TwoHanded[x] && !GameObjects.Weapons.Versatile[x])
                    ItemListBox.Items.Add(GameObjects.Weapons.WeaponsList[x] + " - DMG: " + GameObjects.Weapons.Damage[x]);
                else if (!GameObjects.Weapons.TwoHanded[x] && GameObjects.Weapons.Versatile[x])
                    ItemListBox.Items.Add(GameObjects.Weapons.WeaponsList[x] + " - DMG: " + GameObjects.Weapons.Damage[x] + ", V");
                else if(GameObjects.Weapons.TwoHanded[x] && !GameObjects.Weapons.Versatile[x])
                    ItemListBox.Items.Add(GameObjects.Weapons.WeaponsList[x] + " - DMG: " + GameObjects.Weapons.Damage[x] + ", TH");
            }
            ItemListBox.Items.Add("");
        }

        void ItemsAddArmour(bool Type)
        {
            if (Type)
            {
                ItemListBox.Items.Add("Armour");
                ItemListBox.Items.Add("");
            }
            for(int x = 0; x < GameObjects.Armour.ArmourList.Count; x++)
            {
                if(GameObjects.Armour.Weight[x] == "Light")
                    ItemListBox.Items.Add(GameObjects.Armour.ArmourList[x] + " - AC: " + GameObjects.Armour.AC[x] + ", L");
                else
                    ItemListBox.Items.Add(GameObjects.Armour.ArmourList[x] + " - AC: " + GameObjects.Armour.AC[x] + ", H");
            }
        }

        private void ItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CurItem = ItemListBox.SelectedItem.ToString();
            if (ItemListBox.SelectedItem != null && CurItem != "" && CurItem != "Weapons" && CurItem != "Armour")
            {
                CurItem = ReturnItemName(CurItem);
                int ItemNum = FindItem(CurItem);
            }
        }

        string ReturnItemName(string Text)
        {
            char[] CharArr = Text.ToCharArray();
            int Count = 0;
            foreach(char Cha in CharArr)
            {
                if (Cha == ' ')
                    break;
                else
                    Count++;
            }
            Text = Text.Remove(Count, CharArr.Length - Count);
            return Text;
        }

        int FindItem(string Item)
        {
            for(int x = 0; x < GameObjects.Weapons.WeaponsList.Count; x++)
                if(GameObjects.Weapons.WeaponsList[x] == Item)
                    return x;
            for(int x = 0; x < GameObjects.Armour.ArmourList.Count; x++) 
                if (GameObjects.Armour.ArmourList[x] == Item)
                    return x;
            return 9999;
        }

        #endregion

        #endregion

        #region Other Functions

        private void OptionsBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                UpdateModuleOptions();
                UpdateOptionBox2();
            }
        }

        public void UpdateCampaignLabel()
        {
            CampaignNameLabel.Text = Storage.Campaign.Name;
        }

        void ClearRandomControls()
        {
            ModuleEnemiesBox.Text = "";
        }

        #endregion
    }
}
