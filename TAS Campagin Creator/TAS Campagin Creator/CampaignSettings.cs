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

        void FillPlayerControlsData()
        {
            FLUTBox.Text = Convert.ToString(Storage.Campaign.Settings.Player.FirstLevelUp);
            LUITBox.Text = Convert.ToString(Storage.Campaign.Settings.Player.LevelUpIncrease);
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
            else if (NHCUDRed.Value <= NHCUDDarkRed.Value)
                NHCUDRed.Value = NHCUDDarkRed.Value + 1;
            Storage.Campaign.Settings.Enemeis.EnemyNamePlateColourRed = Convert.ToInt32(NHCUDRed.Value);
        }

        private void NHCUDDarkRed_ValueChanged(object sender, EventArgs e)
        {
            if (NHCUDDarkRed.Value >= NHCUDRed.Value)
                NHCUDDarkRed.Value = NHCUDRed.Value - 1;
            else if (NHCUDDarkRed.Value <= 0)
                NHCUDDarkRed.Value = 1;
            Storage.Campaign.Settings.Enemeis.EnemyNamePlateColourDarkRed = Convert.ToInt32(NHCUDRed.Value);
        }

        void FillEnemyControlsSettings()
        {
            NHCUDGreen.Value = Storage.Campaign.Settings.Enemeis.EnemyNamePlateColourGreen;
            NHCUDDarkGreen.Value = Storage.Campaign.Settings.Enemeis.EnemyNamePlateColourDarkGreen;
            NHCUDDarkYellow.Value = Storage.Campaign.Settings.Enemeis.EnemyNamePlateColourDarkYellow;
            NHCUDRed.Value = Storage.Campaign.Settings.Enemeis.EnemyNamePlateColourRed;
            NHCUDDarkRed.Value = Storage.Campaign.Settings.Enemeis.EnemyNamePlateColourDarkRed;
        }
        #endregion
    }
}
