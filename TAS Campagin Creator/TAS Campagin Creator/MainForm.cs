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
        #region Program Start

        public MainForm()
        {
            CallOtherClassFunctions();
            CallThisClassFunctions();
            UpdateThisControls();
        }

        void CallOtherClassFunctions()
        {
            GameObjects.LoadGameObjects();
            Storage.Campaign.NewModule();
            //Storage.AddTempData();
            //Storage.PlayableCampaign();
        }

        void CallThisClassFunctions()
        {
            InitializeComponent();
            FillModuleTypeControls();
            UpdateModuleBox();
        }

        void UpdateThisControls()
        {
            CampaignNameLabel.Text = Storage.Campaign.Name;
            ModuleBox.SelectedIndex = 0;
        }

        #endregion

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
            GTI.Textbox = Storage.Campaign.Name;
            GTI.LabelText = "Campaign Name";
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
                case 3:
                    ModTypeCBox.SelectedItem = "Trap Module";
                    break;
                case 4:
                    ModTypeCBox.SelectedItem = "End Campaign Module";
                    break;
                default:
                    break;
            }
        }

       void DisplayModuleGroupBox()
        {
            EncounterGBox.Visible = false;
            ShopGBox.Visible = false;
            TrapGBox.Visible = false;
            switch (Storage.Campaign.Modules[Storage.ModNum].ModType)
            {
                case 1:
                    EncounterGBox.Visible = true;
                    break;
                case 2:
                    ShopGBox.Visible = true;
                    break;
                case 3:
                    TrapGBox.Visible = true;
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
                    case 1:
                        Storage.Campaign.Modules[Storage.ModNum].ModType = 1;
                        break;
                    case 2:
                        Storage.Campaign.Modules[Storage.ModNum].ModType = 2;
                        break;
                    case 3:
                        Storage.Campaign.Modules[Storage.ModNum].ModType = 3;
                        break;
                    case 4:
                        Storage.Campaign.Modules[Storage.ModNum].ModType = 4;
                        break;
                    case 0:
                    default:
                        Storage.Campaign.Modules[Storage.ModNum].ModType = 0;
                        break;
                }
                DisplayModuleGroupBox();
            }
        }

        void FillModuleTypeControls()
        {
            FillEnemyListBox();
            FillItemsListBox(0);
            FillTrapsListBox();
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

        private void EnemyNameSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (EnemyNameSearchBox.Text != "")
                SearchForNPCs(EnemyNameSearchBox.Text);
            else
                FillEnemyListBox();
        }

        void SearchForNPCs(string Search)
        {
            EnemyListBox.Items.Clear();
            Search = Search.ToLower();
            foreach(NPC NPC in GameObjects.Enemies)
            {
                string Name = NPC.Name.ToLower();
                if (Name.Contains(Search))
                    EnemyListBox.Items.Add("DB: " + NPC.DifBonus + " - " + NPC.Name);
            }
        }

        void FillEnemyListBox()
        {
            EnemyListBox.Items.Clear();
            for (int x = 0; x < GameObjects.Enemies.Count; x++)
                EnemyListBox.Items.Add("DB: " + GameObjects.Enemies[x].DifBonus + " - " + GameObjects.Enemies[x].Name);
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

        private void ItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CurItem = ItemListBox.SelectedItem.ToString();
            if (ItemListBox.SelectedItem != null && CurItem != "" && CurItem != "Weapons" && CurItem != "Armour" && CurItem != "Potions")
            {
                CurItem = ReturnItemName(CurItem);
                Tuple<int, int> ItemTup = FindItem(CurItem);
                UpdateShopStockObject(ItemTup);
            }
        }

        private void ClearStockButton_Click(object sender, EventArgs e)
        {
            Storage.Campaign.Modules[Storage.ModNum].Shop.WeaponStock.Clear();
            Storage.Campaign.Modules[Storage.ModNum].Shop.ArmourStock.Clear();
            Storage.Campaign.Modules[Storage.ModNum].Shop.PotionStock.Clear();
            ShopTBox.Text = "";
        }

        private void SearchItemsTBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (SearchItemsTBox.Text != "")
                SearchForItems(SearchItemsTBox.Text);
            else
                FillItemsListBox(0);
        }

        void SearchForItems(string Search)
        {
            ItemListBox.Items.Clear();
            Search = Search.ToLower();
            bool WeaponBool = false;
            bool ArmourBool = false;
            bool PotionBool = false;
            foreach(Weapon Weapon in GameObjects.Weapons)
            {
                string Name = Weapon.Name.ToLower();
                if (Name.Contains(Search))
                {
                    if (!WeaponBool)
                    {
                        ItemListBox.Items.Add("Weapons");
                        ItemListBox.Items.Add("");
                        WeaponBool = !WeaponBool;
                    }
                    if (!Weapon.TwoHanded && !Weapon.Versatile)
                        ItemListBox.Items.Add(Weapon.Name + " - DMG: " + Weapon.Damage);
                    else if (Weapon.TwoHanded && !Weapon.Versatile)
                        ItemListBox.Items.Add(Weapon.Name + " - DMG: " + Weapon.Damage + ", TH");
                    else if (!Weapon.TwoHanded && Weapon.Versatile)
                        ItemListBox.Items.Add(Weapon.Name + " - DMG: " + Weapon.Damage + ", V");
                }
            }
            if (WeaponBool)
                ItemListBox.Items.Add("");
            foreach(Armour Armour in GameObjects.Armour)
            {
                string Name = Armour.Name.ToLower();
                if (Name.Contains(Search))
                {
                    if (!ArmourBool)
                    {
                        ItemListBox.Items.Add("Armour");
                        ItemListBox.Items.Add("");
                        ArmourBool = !ArmourBool;
                    }
                    if (Armour.Weight == "Light")
                        ItemListBox.Items.Add(Armour.Name + " - AC: " + Armour.AC + ", L");
                    else
                        ItemListBox.Items.Add(Armour.Name + " - AC: " + Armour.AC + ", H");
                }
            }
            if (WeaponBool || ArmourBool)
                ItemListBox.Items.Add("");
            foreach(Potions Potion in GameObjects.Potions)
            {
                string Name = Potion.Name.ToLower();
                if (Name.Contains(Search))
                {
                    if (!PotionBool)
                    {
                        ItemListBox.Items.Add("Potions");
                        ItemListBox.Items.Add("");
                        PotionBool = !PotionBool;
                    }
                    ItemListBox.Items.Add(Potion.Name + " - " + Potion.DiceNum + "D" + Potion.DiceSize + "+" + Potion.Modifier);
                }
            }
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
                case 3:
                    ItemsAddPotions(false);
                    break;
                default:
                    ItemsAddWeapons(true);
                    ItemsAddArmour(true);
                    ItemsAddPotions(true);
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
            for(int x = 0; x < GameObjects.Weapons.Count; x++)
            {

                if (!GameObjects.Weapons[x].TwoHanded && !GameObjects.Weapons[x].Versatile)
                    ItemListBox.Items.Add(GameObjects.Weapons[x].Name + " - DMG: " + GameObjects.Weapons[x].Damage);
                else if (!GameObjects.Weapons[x].TwoHanded && GameObjects.Weapons[x].Versatile)
                    ItemListBox.Items.Add(GameObjects.Weapons[x].Name + " - DMG: " + GameObjects.Weapons[x].Damage + ", V");
                else if(GameObjects.Weapons[x].TwoHanded && !GameObjects.Weapons[x].Versatile)
                    ItemListBox.Items.Add(GameObjects.Weapons[x].Name + " - DMG: " + GameObjects.Weapons[x].Damage + ", TH");
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
            for(int x = 0; x < GameObjects.Armour.Count; x++)
            {
                if(GameObjects.Armour[x].Weight == "Light")
                    ItemListBox.Items.Add(GameObjects.Armour[x].Name + " - AC: " + GameObjects.Armour[x].AC + ", L");
                else
                    ItemListBox.Items.Add(GameObjects.Armour[x].Name + " - AC: " + GameObjects.Armour[x].AC + ", H");
            }
            ItemListBox.Items.Add("");
        }

        void ItemsAddPotions(bool Type)
        {
            if (Type)
            {
                ItemListBox.Items.Add("Potions");
                ItemListBox.Items.Add("");
            }
            for (int x = 0; x < GameObjects.Potions.Count; x++)
                ItemListBox.Items.Add(GameObjects.Potions[x].Name + " - " + GameObjects.Potions[x].DiceNum + "D" + GameObjects.Potions[x].DiceSize + "+" +
                    GameObjects.Potions[x].Modifier);
        }

        void UpdateShopStockObject(Tuple<int, int> ItemTup)
        {
            string Cost = "";
            if (ItemTup.Item1 == 1)
            {
                Storage.Campaign.Modules[Storage.ModNum].Shop.AddWeapon(GameObjects.Weapons[ItemTup.Item2]);
                Storage.Campaign.Modules[Storage.ModNum].Shop.ItemType = 0;
                Cost = Convert.ToString(GameObjects.Weapons[ItemTup.Item2].Cost);
            }
            else if (ItemTup.Item1 == 2)
            {
                Storage.Campaign.Modules[Storage.ModNum].Shop.AddArmour(GameObjects.Armour[ItemTup.Item2]);
                Storage.Campaign.Modules[Storage.ModNum].Shop.ItemType = 1;
                Cost = Convert.ToString(GameObjects.Armour[ItemTup.Item2].Cost);
            }
            else if(ItemTup.Item1 == 3)
            {
                Storage.Campaign.Modules[Storage.ModNum].Shop.AddPotion(GameObjects.Potions[ItemTup.Item2]);
                Storage.Campaign.Modules[Storage.ModNum].Shop.ItemType = 2;
                Cost = Convert.ToString(GameObjects.Potions[ItemTup.Item2].Cost);
            }
            GetTextInput GTI = new GetTextInput();
            GTI.MyParent = this;
            GTI.Textbox = Cost;
            GTI.LabelText = "Item Cost";
            GTI.Arg = 1;
            GTI.NumOnly = true;
            GTI.Show();
        }

        public void UpdateShopStockDisplay(int Cost)
        {
            if (Storage.Campaign.Modules[Storage.ModNum].Shop.ItemType == 0)
            {
                int Count = Storage.Campaign.Modules[Storage.ModNum].Shop.WeaponStock.Count - 1;
                Storage.Campaign.Modules[Storage.ModNum].Shop.WeaponStock[Count].Cost = Cost;
                ShopTBox.Text += Storage.Campaign.Modules[Storage.ModNum].Shop.WeaponStock[Count].Name + "\nDMG: " + 
                    Storage.Campaign.Modules[Storage.ModNum].Shop.WeaponStock[Count].Damage;
                if (Storage.Campaign.Modules[Storage.ModNum].Shop.WeaponStock[Count].TwoHanded)
                    ShopTBox.Text += ", Two Handed";
                else if (Storage.Campaign.Modules[Storage.ModNum].Shop.WeaponStock[Count].Versatile)
                    ShopTBox.Text += ", Versatile";
                ShopTBox.Text += "\nCost: " + Storage.Campaign.Modules[Storage.ModNum].Shop.WeaponStock[Count].Cost + "GP";
            }
            else if (Storage.Campaign.Modules[Storage.ModNum].Shop.ItemType == 1)
            {
                int Count = Storage.Campaign.Modules[Storage.ModNum].Shop.ArmourStock.Count - 1;
                Storage.Campaign.Modules[Storage.ModNum].Shop.ArmourStock[Count].Cost = Cost;
                ShopTBox.Text += Storage.Campaign.Modules[Storage.ModNum].Shop.ArmourStock[Count].Name + "\nAC: " + 
                    Storage.Campaign.Modules[Storage.ModNum].Shop.ArmourStock[Count].AC + ", Weight: " +
                    Storage.Campaign.Modules[Storage.ModNum].Shop.ArmourStock[Count].Weight + "\nCost: " + 
                    Storage.Campaign.Modules[Storage.ModNum].Shop.ArmourStock[Count].Cost + "GP";
            }
            else if(Storage.Campaign.Modules[Storage.ModNum].Shop.ItemType == 2)
            {
                int Count = Storage.Campaign.Modules[Storage.ModNum].Shop.PotionStock.Count - 1;
                Storage.Campaign.Modules[Storage.ModNum].Shop.PotionStock[Count].Cost = Cost;
                ShopTBox.Text += Storage.Campaign.Modules[Storage.ModNum].Shop.PotionStock[Count].Name + "\nRegen: " +
                    Storage.Campaign.Modules[Storage.ModNum].Shop.PotionStock[Count].DiceNum + "D" +
                    Storage.Campaign.Modules[Storage.ModNum].Shop.PotionStock[Count].DiceSize + "+" +
                    Storage.Campaign.Modules[Storage.ModNum].Shop.PotionStock[Count].Modifier + "\nCost: " +
                    Storage.Campaign.Modules[Storage.ModNum].Shop.PotionStock[Count].Cost + "GP";
            }
            ShopTBox.Text += "\n\n";
        }

        string ReturnItemName(string Text)
        {
            char[] CharArr = Text.ToCharArray();
            int Count = 0;
            foreach (char Cha in CharArr)
            {
                if (Cha == '-')
                {
                    Count--;
                    break;
                }
                else
                    Count++;
            }
            Text = Text.Remove(Count, CharArr.Length - Count);
            return Text;
        }

        Tuple<int, int> FindItem(string Item)
        {
            for(int x = 0; x < GameObjects.Weapons.Count; x++)
                if(GameObjects.Weapons[x].Name == Item)
                    return new Tuple<int, int>(1, x); ;
            for(int x = 0; x < GameObjects.Armour.Count; x++) 
                if (GameObjects.Armour[x].Name == Item)
                    return new Tuple<int, int>(2, x);
            for (int x = 0; x < GameObjects.Potions.Count; x++)
                if (GameObjects.Potions[x].Name == Item)
                    return new Tuple<int, int>(3, x);
            return new Tuple<int, int>(0, 0); ;
        }

        #endregion

        #region Trap Module

        private void TrapListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TrapListBox.SelectedItem != null)
            {
                Storage.Campaign.Modules[Storage.ModNum].NewTrap(GameObjects.Traps[TrapListBox.SelectedIndex]);
                DisplayTrapProperties(Storage.Campaign.Modules[Storage.ModNum].Trap);
                DisplaySuccessFailText(Storage.Campaign.Modules[Storage.ModNum].Trap);
                SetTrapControls(Storage.Campaign.Modules[Storage.ModNum].Trap);
            }
        }

        private void SaveTypeCBox_SelectedValueChanged(object sender, EventArgs e)
        {

            if (SaveTypeCBox.SelectedItem != null)
            {
                switch (SaveTypeCBox.SelectedIndex)
                {
                    case 0:
                        Storage.Campaign.Modules[Storage.ModNum].Trap.SaveType = "Str";
                        break;
                    case 1:
                        Storage.Campaign.Modules[Storage.ModNum].Trap.SaveType = "Dex";
                        break;
                    case 2:
                        Storage.Campaign.Modules[Storage.ModNum].Trap.SaveType = "Con";
                        break;
                    default:
                        break;
                }
            }
            DisplayTrapProperties(Storage.Campaign.Modules[Storage.ModNum].Trap);
        }

        private void SaveTargetNUD_ValueChanged(object sender, EventArgs e)
        {
            Storage.Campaign.Modules[Storage.ModNum].Trap.SaveTarget = Convert.ToInt32(SaveTargetNUD.Value);
            DisplayTrapProperties(Storage.Campaign.Modules[Storage.ModNum].Trap);
        }

        private void DiceNumberNUD_ValueChanged(object sender, EventArgs e)
        {
            Storage.Campaign.Modules[Storage.ModNum].Trap.DiceNum = Convert.ToInt32(DiceNumberNUD.Value);
            DisplayTrapProperties(Storage.Campaign.Modules[Storage.ModNum].Trap);
        }

        private void DiceSizeNUD_ValueChanged(object sender, EventArgs e)
        {
            Storage.Campaign.Modules[Storage.ModNum].Trap.DiceSize = Convert.ToInt32(DiceSizeNUD.Value);
            DisplayTrapProperties(Storage.Campaign.Modules[Storage.ModNum].Trap);
        }

        private void ModifierNUD_ValueChanged(object sender, EventArgs e)
        {
            Storage.Campaign.Modules[Storage.ModNum].Trap.Modifier = Convert.ToInt32(ModifierNUD.Value);
            DisplayTrapProperties(Storage.Campaign.Modules[Storage.ModNum].Trap);
        }

        private void SaveSuccesTBox_KeyUp(object sender, KeyEventArgs e)
        {
            Storage.Campaign.Modules[Storage.ModNum].Trap.SaveSuccess = SaveSuccesTBox.Text;
        }

        private void SaveFailTBox_KeyUp(object sender, KeyEventArgs e)
        {
            Storage.Campaign.Modules[Storage.ModNum].Trap.SaveFail = SaveFailTBox.Text;
        }

        private void SearchTrapsTBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(SearchTrapsTBox.Text != "")
            {
                TrapListBox.Items.Clear();
                string Search = SearchTrapsTBox.Text.ToLower();
                foreach(Traps Trap in GameObjects.Traps)
                {
                    string Name = Trap.Name.ToLower();
                    if (Name.Contains(Search))
                    {
                        TrapListBox.Items.Add(Trap.Name);
                    }
                }
            }
            else
            {
                FillTrapsListBox();
            }
        }

        void FillTrapsListBox()
        {
            TrapListBox.Items.Clear();
            foreach (Traps Trap in GameObjects.Traps)
                TrapListBox.Items.Add(Trap.Name);
        }

        void DisplayTrapProperties(Traps Trap)
        {
            CalculateTrapStats(Trap);
            TrapStatsBox.Text = Trap.Name + "\n\nDMG: " + Trap.DiceNum + "D" + Trap.DiceSize + "+" + Trap.Modifier + "\nSave Type: " + Trap.SaveType +
                "\nSave Target: " + Trap.SaveTarget + "\n\nAverage Damage: " + Trap.AvgDamage + "\nMinimum Damage: " + Trap.MinDamage + "\nMaximum Damage: " +
                Trap.MaxDamage + "\n\nXP Value: " + Trap.XPValue;
        }

        void CalculateTrapStats(Traps Trap)
        {
            float Temp = ((((float)Trap.DiceSize + (float)1) / (float)2) * (float)Trap.DiceNum) + (float)Trap.Modifier;
            Trap.AvgDamage = Convert.ToInt32(Temp);
            Trap.MinDamage = Trap.DiceNum + Trap.Modifier;
            Trap.MaxDamage = (Trap.DiceNum * Trap.DiceSize) + Trap.Modifier;
            Temp = ((float)Trap.MinDamage + (float)Trap.AvgDamage + (float)Trap.MaxDamage + (float)Trap.SaveTarget) / 4;
            Trap.XPValue = Convert.ToInt32(Temp);
        }

        void DisplaySuccessFailText(Traps Trap)
        {
            SaveSuccesTBox.Text = Trap.SaveSuccess;
            SaveFailTBox.Text = Trap.SaveFail;
        }

        void SetTrapControls(Traps Trap)
        {
            SaveTypeCBox.Text = Trap.SaveType;
            SaveTargetNUD.Value = Trap.SaveTarget;
            DiceNumberNUD.Value = Trap.DiceNum;
            DiceSizeNUD.Value = Trap.DiceSize;
            ModifierNUD.Value = Trap.Modifier;
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

        private void ModNameTBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                if (ModNameTBox.Text != "")
                {
                    Storage.Campaign.Modules[Storage.ModNum].Name = ModNameTBox.Text;
                    UpdateModuleBox();
                }
        }
        #endregion
    }
}
