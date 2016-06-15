using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui
{
    public partial class T : Form
    {
        bool TempEnable;
        bool TempEnableTimeout;
        bool TempEnableRecoilLimit;
        string TempYawRecoilLimit;
        string TempPitchRecoilLimit;
        string TempFirstShotDelay;
        string TempFollowUpDelay;
        string TempTimeout;
        Utils utility = new Utils();


        public T()
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


        public void Save()
        {
            utility.Editor(string.Format("TriggerbotSettings.Enabled = {0}", utility.BooltoString(TempEnable)), string.Format("TriggerbotSettings.Enabled = {0}", utility.BooltoString(TEnable.Checked)));
            utility.Editor(string.Format("TriggerbotSettings.EnableTimeout = {0}", utility.BooltoString(TempEnableTimeout)), string.Format("TriggerbotSettings.EnableTimeout = {0}", utility.BooltoString(EnableTimeout.Checked)));
            utility.Editor(string.Format("TriggerbotSettings.EnableRecoilLimit = {0}", utility.BooltoString(TempEnableRecoilLimit)), string.Format("TriggerbotSettings.EnableRecoilLimit = {0}", utility.BooltoString(EnableRecoilLimit.Checked)));
            utility.Editor(string.Format("TriggerbotSettings.YawRecoilLimit = {0}", TempYawRecoilLimit), string.Format("TriggerbotSettings.YawRecoilLimit = {0}", YawRecoilLimit.Text));
            utility.Editor(string.Format("TriggerbotSettings.PitchRecoilLimit = {0}", TempPitchRecoilLimit), string.Format("TriggerbotSettings.PitchRecoilLimit = {0}", PitchRecoilLimit.Text));
            utility.Editor(string.Format("TriggerbotSettings.FirstShotDelay = {0}", TempFirstShotDelay), string.Format("TriggerbotSettings.FirstShotDelay = {0}", FirstShotDelay.Text));
            utility.Editor(string.Format("TriggerbotSettings.FollowUpDelay = {0}", TempFollowUpDelay), string.Format("TriggerbotSettings.FollowUpDelay = {0}", FollowUpDelay.Text));
            utility.Editor(string.Format("TriggerbotSettings.Timeout = {0}", TempTimeout), string.Format("TriggerbotSettings.Timeout = {0}", Timeout.Text));
        }


        public void ReadData()
        {
            TempEnable = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(130)));
            TempEnableTimeout = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(132)));
            TempEnableRecoilLimit = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(133)));
            TempYawRecoilLimit = utility.GetValue(utility.SettingsList().ElementAt(134));
            TempPitchRecoilLimit = utility.GetValue(utility.SettingsList().ElementAt(135));
            TempFirstShotDelay = utility.GetValue(utility.SettingsList().ElementAt(136));
            TempFollowUpDelay = utility.GetValue(utility.SettingsList().ElementAt(137));
            TempTimeout = utility.GetValue(utility.SettingsList().ElementAt(138));
        }


        public void WriteData()
        {
            TEnable.Checked = TempEnable;
            EnableTimeout.Checked = TempEnableTimeout;
            EnableRecoilLimit.Checked = TempEnableRecoilLimit;
            YawRecoilLimit.Text = TempYawRecoilLimit;
            PitchRecoilLimit.Text = TempPitchRecoilLimit;
            FirstShotDelay.Text = TempFirstShotDelay;
            FollowUpDelay.Text = TempFollowUpDelay;
            Timeout.Text = TempTimeout;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
            MessageBox.Show("Saved", "DONE!");
        }
    }
}
