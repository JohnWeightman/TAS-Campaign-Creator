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
    public partial class CampaignSettings : Form
    {
        public CampaignSettings()
        {
            InitializeComponent();
        }

        #region Group Boxes
        private void SettingsLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SettingsLBox.SelectedItem != null)
            {
                HideGroupBoxes();
                switch (SettingsLBox.SelectedIndex)
                {
                    case 0:
                        GeneralGBox.Visible = true;
                        break;
                    case 1:
                        FillPlayerControlsData();
                        PlayerGBox.Visible = true;
                        break;
                    case 2:
                        FillEnemyControlsSettings();
                        EnemeisGBox.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        void HideGroupBoxes()
        {
            GeneralGBox.Visible = false;
            PlayerGBox.Visible = false;
            EnemeisGBox.Visible = false;
        }
        #endregion

        #region General Settings

        #endregion

        #region Player Settings
        private void FLUTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FLUTBox_KeyUp(object sender, KeyEventArgs e)
        {
            Storage.Campaign.Settings.Player.FirstLevelUp = Convert.ToInt32(FLUTBox.Text);
        }

        private void LUITBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void LUITBox_KeyUp(object sender, KeyEventArgs e)
        {
            Storage.Campaign.Settings.Player.LevelUpIncrease = Convert.ToInt32(LUITBox.Text);
        }

        private void SetStatsCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SetStatsCBox.Checked)
            {
                Storage.Campaign.Settings.Player.SetPlayerStats = true;
                StrUD.Enabled = true;
                DexUD.Enabled = true;
                ConUD.Enabled = true;
                HealthLabel.Visible = true;
                StartWeaponCBox.Enabled = true;
                StartArmourCBox.Enabled = true;
            }
            else
            {
                Storage.Campaign.Settings.Player.SetPlayerStats = false;
                StrUD.Enabled = false;
                DexUD.Enabled = false;
                ConUD.Enabled = false;
                HealthLabel.Visible = false;
                StartWeaponCBox.Enabled = false;
                StartArmourCBox.Enabled = false;
            }
        }

        private void StrUD_ValueChanged(object sender, EventArgs e)
        {
            if (StrUD.Value > 15)
                StrUD.Value = 15;
            else if (StrUD.Value < 1)
                StrUD.Value = 1;
            Storage.Campaign.Settings.Player.Str = Convert.ToInt32(StrUD.Value);
            StrModLabel.Text = "+" + Convert.ToString(Storage.Campaign.Settings.Player.Str / 3);
        }

        private void DexUD_ValueChanged(object sender, EventArgs e)
        {
            if (DexUD.Value > 15)
                DexUD.Value = 15;
            else if (DexUD.Value < 1)
                DexUD.Value = 1;
            Storage.Campaign.Settings.Player.Dex = Convert.ToInt32(DexUD.Value);
            DexModLabel.Text = "+" + Convert.ToString(Storage.Campaign.Settings.Player.Dex / 3);
        }

        private void ConUD_ValueChanged(object sender, EventArgs e)
        {
            if (ConUD.Value > 15)
                ConUD.Value = 15;
            else if (ConUD.Value < 1)
                ConUD.Value = 1;
            Storage.Campaign.Settings.Player.Con = Convert.ToInt32(ConUD.Value);
            Storage.Campaign.Settings.Player.HP = (Convert.ToInt32(ConUD.Value) / 3) + 10;
            ConModLabel.Text = "+" + Convert.ToString(Storage.Campaign.Settings.Player.Con / 3);
            HealthLabel.Text = Convert.ToString(Storage.Campaign.Settings.Player.HP);
        }

        private void StartWeaponCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.Campaign.Settings.Player.Weapon = StartWeaponCBox.Text;
        }

        private void StartArmourCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Storage.Campaign.Settings.Player.Armour = StartArmourCBox.Text;
        }

        void FillPlayerControlsData()
        {
            FLUTBox.Text = Convert.ToString(Storage.Campaign.Settings.Player.FirstLevelUp);
            LUITBox.Text = Convert.ToString(Storage.Campaign.Settings.Player.LevelUpIncrease);
            foreach (Weapon Weapon in GameObjects.Weapons)
                StartWeaponCBox.Items.Add(Weapon.Name);
            foreach (Armour Armour in GameObjects.Armour)
                StartArmourCBox.Items.Add(Armour.Name);
        }
        #endregion

        #region Enemy Settings
        private void NHCUDGreen_ValueChanged(object sender, EventArgs e)
        {
            if (NHCUDGreen.Value > 100)
                NHCUDGreen.Value = 100;
            else if (NHCUDGreen.Value <= NHCUDDarkGreen.Value)
                NHCUDGreen.Value = NHCUDDarkGreen.Value + 1;
            Storage.Campaign.Settings.Enemeis.EnemyNamePlateColourGreen = Convert.ToInt32(NHCUDGreen.Value);
        }

        private void NHCUDDarkGreen_ValueChanged(object sender, EventArgs e)
        {
            if (NHCUDDarkGreen.Value >= NHCUDGreen.Value)
                NHCUDDarkGreen.Value = NHCUDGreen.Value - 1;
            else if (NHCUDDarkGreen.Value <= NHCUDDarkYellow.Value)
                NHCUDDarkGreen.Value = NHCUDDarkYellow.Value + 1;
            Storage.Campaign.Settings.Enemeis.EnemyNamePlateColourDarkGreen = Convert.ToInt32(NHCUDDarkGreen.Value);
        }

        private void NHCUDDarkYellow_ValueChanged(object sender, EventArgs e)
        {
            if (NHCUDDarkYellow.Value >= NHCUDDarkGreen.Value)
                NHCUDDarkYellow.Value = NHCUDDarkGreen.Value - 1;
            else if (NHCUDDarkYellow.Value <= NHCUDRed.Value)
                NHCUDDarkYellow.Value = NHCUDRed.Value + 1;
            Storage.Campaign.Settings.Enemeis.EnemyNamePlateColourDarkYellow = Convert.ToInt32(NHCUDDarkYellow.Value);
        }

        private void NHCUDRed_ValueChanged(object sender, EventArgs e)
        {
            if (NHCUDRed.Value >= NHCUDDarkYellow.Value)
                NHCUDRed.Value = NHCUDDarkYellow.Value - 1;
            else if (NHCUDRed.Value <= 1)
                NHCUDRed.Value = 2;
            Storage.Campaign.Settings.Enemeis.EnemyNamePlateColourRed = Convert.ToInt32(NHCUDRed.Value);
        }

        void FillEnemyControlsSettings()
        {
            NHCUDGreen.Value = Storage.Campaign.Settings.Enemeis.EnemyNamePlateColourGreen;
            NHCUDDarkGreen.Value = Storage.Campaign.Settings.Enemeis.EnemyNamePlateColourDarkGreen;
            NHCUDDarkYellow.Value = Storage.Campaign.Settings.Enemeis.EnemyNamePlateColourDarkYellow;
            NHCUDRed.Value = Storage.Campaign.Settings.Enemeis.EnemyNamePlateColourRed;
        }
        #endregion
    }
}
