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
using System.Text.RegularExpressions;

namespace Ui
{
    public partial class A : Form
    {
        bool TempEnable;
        bool TempEnableFire;
        bool TempEnableRandomPitchRecoilReductionFactor;
        bool TempEnableRandomYawRecoilReductionFactor;
        bool TempEnableTimeout;
        bool TempTargetJumpingPlayers;
        string TempIgnoreShotCount;
        string TempMaxRandomPitch;
        string TempMaxRandomYaw;
        string TempMinRandomPitch;
        string TempMinRandomYaw;
        string TempSmoothPercent;
        string TempStaticPitch;
        string TempStaticYaw;
        string TempTargetBone;
        string TempTimeout;
        Utils utility = new Utils();

        public A()
        {
            InitializeComponent();
            try
            {
                ReadData();
                WriteData();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "ERROR!!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void save()
        {
            utility.Editor(string.Format("AimbotSettings.Enabled = {0}", utility.BooltoString(TempEnable)), string.Format("AimbotSettings.Enabled = {0}", utility.BooltoString(Enable.Checked)));
            utility.Editor(string.Format("AimbotSettings.EnableFire = {0}", utility.BooltoString(TempEnableFire)), string.Format("AimbotSettings.EnableFire = {0}", utility.BooltoString(EnableFire.Checked)));
            utility.Editor(string.Format("AimbotSettings.EnableRandomPitchRecoilReductionFactor = {0}", utility.BooltoString(TempEnableRandomPitchRecoilReductionFactor)), string.Format("AimbotSettings.EnableRandomPitchRecoilReductionFactor = {0}", utility.BooltoString(EnableRandomPitchRecoilReductionFactor.Checked)));
            utility.Editor(string.Format("AimbotSettings.EnableRandomYawRecoilReductionFactor = {0}", utility.BooltoString(TempEnableRandomYawRecoilReductionFactor)), string.Format("AimbotSettings.EnableRandomYawRecoilReductionFactor = {0}", utility.BooltoString(EnableRandomYawRecoilReductionFactor.Checked)));
            utility.Editor(string.Format("AimbotSettings.EnableTimeout = {0}", utility.BooltoString(TempEnableTimeout)), string.Format("AimbotSettings.EnableTimeout = {0}", utility.BooltoString(EnableTimeout.Checked)));
            utility.Editor(string.Format("AimbotSettings.TargetJumpingPlayers = {0}", utility.BooltoString(TempTargetJumpingPlayers)), string.Format("AimbotSettings.TargetJumpingPlayers = {0}", utility.BooltoString(TargetJumpingPlayers.Checked)));
            utility.Editor(string.Format("AimbotSettings.IgnoreShotCount = {0}", TempIgnoreShotCount), string.Format("AimbotSettings.IgnoreShotCount = {0}", IgnoreShotCount.Text));
            utility.Editor(string.Format("AimbotSettings.MaxRandomPitch = {0}", TempMaxRandomPitch), string.Format("AimbotSettings.MaxRandomPitch = {0}", MaxRandomPitch.Text));
            utility.Editor(string.Format("AimbotSettings.MinRandomPitch = {0}", TempMinRandomPitch), string.Format("AimbotSettings.MinRandomPitch = {0}", MinRandomPitch.Text));
            utility.Editor(string.Format("AimbotSettings.MaxRandomYaw = {0}", TempMaxRandomYaw), string.Format("AimbotSettings.MaxRandomYaw = {0}", MaxRandomYaw.Text));
            utility.Editor(string.Format("AimbotSettings.MinRandomYaw = {0}", TempMinRandomYaw), string.Format("AimbotSettings.MinRandomYaw = {0}", MinRandomYaw.Text));
            utility.Editor(string.Format("AimbotSettings.SmoothPercent = {0}", TempSmoothPercent), string.Format("AimbotSettings.SmoothPercent = {0}", SmoothPercent.Text));
            utility.Editor(string.Format("AimbotSettings.StaticPitch = {0}", TempStaticPitch), string.Format("AimbotSettings.StaticPitch = {0}", StaticPitch.Text));
            utility.Editor(string.Format("AimbotSettings.StaticYaw = {0}", TempStaticYaw), string.Format("AimbotSettings.StaticYaw = {0}", StaticYaw.Text));
            utility.Editor(string.Format("AimbotSettings.TargetBone = {0}", TempTargetBone), string.Format("AimbotSettings.TargetBone = {0}", TargetBone.Text));
            utility.Editor(string.Format("AimbotSettings.Timeout = {0}", TempTimeout), string.Format("AimbotSettings.Timeout = {0}", Timeout.Text));
        }

        private void Save_Settings_Click(object sender, EventArgs e)
        {
            save();
            MessageBox.Show("Saved", "DONE!");
            SendKeys.Send("^{F1}");
        }

        private void ReadData()
        {
            TempEnable = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(29)));
            TempEnableFire = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(31)));
            TempEnableRandomPitchRecoilReductionFactor = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(32)));
            TempEnableRandomYawRecoilReductionFactor = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(33)));
            TempEnableTimeout = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(34)));
            TempTargetJumpingPlayers = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(40)));
            TempIgnoreShotCount = utility.GetValue(utility.SettingsList().ElementAt(35));
            TempMaxRandomPitch = utility.GetValue(utility.SettingsList().ElementAt(36));
            TempMaxRandomYaw = utility.GetValue(utility.SettingsList().ElementAt(37));
            TempMinRandomPitch = utility.GetValue(utility.SettingsList().ElementAt(38));
            TempMinRandomYaw = utility.GetValue(utility.SettingsList().ElementAt(39));
            TempSmoothPercent = utility.GetValue(utility.SettingsList().ElementAt(41));
            TempStaticPitch = utility.GetValue(utility.SettingsList().ElementAt(42));
            TempStaticYaw = utility.GetValue(utility.SettingsList().ElementAt(43));
            TempTargetBone = utility.GetValue(utility.SettingsList().ElementAt(44));
            TempTimeout = utility.GetValue(utility.SettingsList().ElementAt(45));
        }

        public void WriteData()
        {
            Enable.Checked = TempEnable;
            EnableFire.Checked = TempEnableFire;
            EnableRandomPitchRecoilReductionFactor.Checked = TempEnableRandomPitchRecoilReductionFactor;
            EnableRandomYawRecoilReductionFactor.Checked = TempEnableRandomYawRecoilReductionFactor;
            EnableTimeout.Checked = TempEnableTimeout;
            TargetJumpingPlayers.Checked = TempTargetJumpingPlayers;
            IgnoreShotCount.Text = TempIgnoreShotCount;
            MaxRandomPitch.Text = TempMaxRandomPitch;
            MaxRandomYaw.Text = TempMaxRandomYaw;
            MinRandomPitch.Text = TempMinRandomPitch;
            MinRandomYaw.Text = TempMinRandomYaw;
            SmoothPercent.Text = TempSmoothPercent;
            StaticPitch.Text = TempStaticPitch;
            StaticYaw.Text = TempStaticYaw;
            TargetBone.Text = TempTargetBone;
            Timeout.Text = TempTimeout;
        }
    }
}
