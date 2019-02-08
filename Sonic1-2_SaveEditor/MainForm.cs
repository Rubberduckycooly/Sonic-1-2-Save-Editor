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

namespace Sonic_12_SaveED
{
    public partial class Mainform : Form
    {

        public RSDKvB.SaveFiles SaveData;

        bool listLoaded = false;

        string Filepath;

        public Mainform()
        {
            InitializeComponent();
        }

        void writeLineToConsole(string line)
        {
            Console.WriteLine(line);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.CharacterID = CharLB.SelectedIndex;
            }        
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Bag 'O Dicks!");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.ZoneID = StageList.SelectedIndex;
            }          
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Sonic 1&2 Save File|Sgame*.bin";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               SaveData.Write(dlg.FileName);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.Lives = (int)LivesNUD.Value;
            }
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Filepath != null)
            {
                SaveData.Write(Filepath);
            }
            else
            {
                saveAsToolStripMenuItem_Click(this, e);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Sonic 1&2 Save File|Sgame*.bin";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                Filepath = dlg.FileName;
                SaveData = new RSDKvB.SaveFiles(dlg.FileName);
                RefreshUI();
            }
        }

        void RefreshUI()
        {
            if (SaveData != null)
            {
                SpindashLB.SelectedIndex = SaveData.ControlStyle;
                FilterLB.SelectedIndex = SaveData.Filter;
                MusNUD.Value = SaveData.MusVolume;
                SFXNUD.Value = SaveData.SFXVolume;
                NewSaveCB.Checked = SaveData.NewSave != 0;
                DisplayValNUD.Value = SaveData.DisplayValue;
                UnknownValNUD.Value = SaveData.Unknown;
                GameRegionBox.SelectedIndex = SaveData.Region;

                LivesNUD.Value = SaveData.Lives;
                if (listLoaded) StageList.SelectedIndex = SaveData.ZoneID;
                CharLB.SelectedIndex = SaveData.CharacterID;
                ScoreNUD.Value = SaveData.Score;
                ScoreBonusNUD.Value = SaveData.ScoreBonus;

                Emerald1.Checked = IsBitSet(SaveData.Emeralds, 0);
                Emerald2.Checked = IsBitSet(SaveData.Emeralds, 1);
                Emerald3.Checked = IsBitSet(SaveData.Emeralds, 2);
                Emerald4.Checked = IsBitSet(SaveData.Emeralds, 3);
                Emerald5.Checked = IsBitSet(SaveData.Emeralds, 4);
                Emerald6.Checked = IsBitSet(SaveData.Emeralds, 5);
                Emerald7.Checked = IsBitSet(SaveData.Emeralds, 6);
            }

        }

        private void SpindashLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.ControlStyle = SpindashLB.SelectedIndex;
            }
        }

        private void FilterLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.Filter = FilterLB.SelectedIndex;
            }
        }

        private void MusNUD_ValueChanged(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.MusVolume = (int)MusNUD.Value;
            }
        }

        private void SFXNUD_ValueChanged(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.SFXVolume = (int)SFXNUD.Value;
            }
        }

        private void selectSave1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.SaveFile = 0;
                RefreshUI();
            }
        }

        private void selectSave2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.SaveFile = 1;
                RefreshUI();
            }
        }

        private void selectSave3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.SaveFile = 2;
                RefreshUI();
            }
        }

        private void selectSave4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.SaveFile = 3;
                RefreshUI();
            }
        }

        private void SaveUnknownNUD_ValueChanged(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.Score = (int)ScoreNUD.Value;
            }
        }

        private void GlobalUnkownNUD_ValueChanged(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                int i = 0;
                if (NewSaveCB.Checked) i = 1;
                SaveData.NewSave = i;
            }
        }

        public bool IsBitSet(int b, int pos)
        {
            return (b & (1 << pos)) != 0;
        }

        private void Emerald1_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.SetEmeraldState(0, Emerald1.Checked);
                RefreshUI();
            }
        }

        private void Emerald2_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.SetEmeraldState(1, Emerald2.Checked);
                RefreshUI();
            }
        }

        private void Emerald3_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.SetEmeraldState(2, Emerald3.Checked);
                RefreshUI();
            }
        }

        private void Emerald4_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.SetEmeraldState(3, Emerald4.Checked);
                RefreshUI();
            }
        }

        private void Emerald5_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.SetEmeraldState(4, Emerald5.Checked);
                RefreshUI();
            }
        }

        private void Emerald6_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.SetEmeraldState(5, Emerald6.Checked);
                RefreshUI();
            }
        }

        private void Emerald7_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.SetEmeraldState(6, Emerald7.Checked);
                RefreshUI();
            }
        }

        private void AllEmeralds_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveData != null)
            {
                SaveData.SetEmeraldState(0, AllEmeralds.Checked);
                SaveData.SetEmeraldState(1, AllEmeralds.Checked);
                SaveData.SetEmeraldState(2, AllEmeralds.Checked);
                SaveData.SetEmeraldState(3, AllEmeralds.Checked);
                SaveData.SetEmeraldState(4, AllEmeralds.Checked);
                SaveData.SetEmeraldState(5, AllEmeralds.Checked);
                SaveData.SetEmeraldState(6, AllEmeralds.Checked);
                RefreshUI();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.ShowDialog();
        }

        private void openFromSteamAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HedgeModManager.Steam.SteamLocation == null)
                HedgeModManager.Steam.Init();
            var form = new HedgeModManager.SLWSaveForm();
            form.ShowDialog();
            if (!string.IsNullOrWhiteSpace(form.SID))
            {
                //200940
                string path = Path.Combine(HedgeModManager.Steam.SteamLocation, "userdata", form.SID, "200940", "local");
                if (!Directory.Exists(path))
                {
                    MessageBox.Show("Could not Find Sonic CD Data in user Profile!", "Data Not Forund", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                path = Path.Combine(path, "Sdata.bin");
                Filepath = path;
                SaveData = new RSDKvB.SaveFiles(path);
                RefreshUI();
            }
        }

        private void NewSaveCB_CheckedChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (NewSaveCB.Checked) i = 1;
            SaveData.NewSave = i;
        }

        private void NextSSBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NextSSBox.SelectedIndex < 0) NextSSBox.SelectedIndex = 0;
            SaveData.SpecialZoneID = NextSSBox.SelectedIndex;
        }

        private void loadStagelistFromGameconfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "RSDKvB Gameconfig files|Gameconfig*.bin";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                RSDKvB.GameConfig gc = new RSDKvB.GameConfig(dlg.FileName);
                StageList.Items.Clear();
                StageList.Items.Add("Erase Save Game");
                for (int i = 0; i < gc.Categories[1].Scenes.Count; i++)
                {
                    StageList.Items.Add(gc.Categories[1].Scenes[i].Name);
                }
                listLoaded = true;
            }
        }

        private void DisplayValNUD_ValueChanged(object sender, EventArgs e)
        {
            SaveData.DisplayValue = (int)DisplayValNUD.Value;
        }

        private void UnknownValNUD_ValueChanged(object sender, EventArgs e)
        {
            SaveData.Unknown = (int)UnknownValNUD.Value;
        }

        private void GameRegionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GameRegionBox.SelectedIndex < 0) GameRegionBox.SelectedIndex = 0;
            SaveData.Region = GameRegionBox.SelectedIndex;
        }
    }
}
