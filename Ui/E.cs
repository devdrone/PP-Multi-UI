using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;

namespace Ui
{
    public partial class E : Form
    {
        bool TempEnabled;
        bool TempDrawEnemyBox;
        string TempEnemyBoxColor;
        string TempEnemyBoxLineWidth;
        string TempEnemyBoxOutlineColor;
        string TempEnemyBoxOutlineWidth;
        bool TempDrawFriendlyBox;
        string TempFriendlyBoxColor;
        string TempFriendlyBoxLineWidth;
        string TempFriendlyBoxOutlineColor;
        string TempFriendlyBoxOutlineWidth;
        bool TempDrawTargetBoxHighlight;
        string TempTargetEnemyBoxColor;
        string TempTargetEnemyBoxLineWidth;
        string TempTargetEnemyBoxOutlineColor;
        string TempTargetEnemyBoxOutlineWidth;
        bool TempDrawEnemySnapLines;
        string TempEnemySnapLineColor;
        string TempEnemySnapLineOutlineColor;
        string TempEnemySnapLineOutlineWidth;
        string TempEnemySnapLineWidth;
        bool TempDrawFriendlySnapLines;
        string TempFriendlySnapLineColor;
        string TempFriendlySnapLineOutlineColor;
        string TempFriendlySnapLineOutlineWidth;
        string TempFriendlySnapLineWidth;
        bool TempDrawTargetSnapLineHighlight;
        string TempTargetEnemySnapLineColor;
        string TempTargetEnemySnapLineOutlineColor;
        string TempTargetEnemySnapLineOutlineWidth;
        string TempTargetEnemySnapLineWidth;
        bool TempDrawEnemyHealthBar;
        string TempEnemyHealthBarBackColor;
        string TempEnemyHealthBarFrontColor;
        string TempEnemyHealthBarOutlineColor;
        string TempEnemyHealthBarOutlineWidth;
        string TempEnemyHealthBarWidth;
        bool TempDrawFriendlyHealthBar;
        string TempFriendlyHealthBarBackColor;
        string TempFriendlyHealthBarFrontColor;
        string TempFriendlyHealthBarOutlineColor;
        string TempFriendlyHealthBarOutlineWidth;
        string TempFriendlyHealthBarWidth;
        bool TempDrawEnemyNameText;
        bool TempDrawEnemyHealthText;
        bool TempDrawEnemyKillsText;
        bool TempDrawEnemyDeathsText;
        bool TempDrawEnemyKDRatioText;
        bool TempDrawEnemyRankText;
        bool TempDrawEnemyBombCarrierText;
        bool TempDrawEnemyDefuseKitCarrierText;
        string TempEnemyInfoTextColor;
        string TempEnemyInfoTextOutlineColor;
        bool TempDrawFriendlyNameText;
        bool TempDrawFriendlyHealthText;
        bool TempDrawFriendlyKillsText;
        bool TempDrawFriendlyDeathsText;
        bool TempDrawFriendlyKDRatioText;
        bool TempDrawFriendlyRankText;
        bool TempDrawFriendlyBombCarrierText;
        bool TempDrawFriendlyDefuseKitCarrierText;
        string TempFriendlyInfoTextColor;
        string TempFriendlyInfoTextOutlineColor;
        bool TempDrawEnemyTargetBoneMarker;
        string TempEnemyTargetBoneMarkerColor;
        string TempEnemyTargetBoneMarkerLineWidth;
        string TempEnemyTargetBoneMarkerSize5;
        string TempEnemyTargetBoneMarkerType;
        string TempEnemyTargetBoneMarkerOutlineColor;
        string TempEnemyTargetBoneMarkerOutlineWidth;
        bool TempDrawFriendlyTargetBoneMarker;
        string TempFriendlyTargetBoneMarkerColor;
        string TempFriendlyTargetBoneMarkerLineWidth;
        string TempFriendlyTargetBoneMarkerSize5;
        string TempFriendlyTargetBoneMarkerType;
        string TempFriendlyTargetBoneMarkerOutlineColor;
        string TempFriendlyTargetBoneMarkerOutlineWidth;
        bool TempDrawRecoilMarker;
        string TempRecoilMarkerColor;
        string TempRecoilMarkerLineWidth;
        string TempRecoilMarkerOutlineColor;
        string TempRecoilMarkerOutlineWidth;
        string TempRecoilMarkerSize5;
        string TempRecoilMarkerType;
        Utils utility = new Utils();

        public E()
        {
            InitializeComponent();
            try
            {
                LoadColor();
                ReadData();
                WriteData();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message, "ERROR!!");
            }
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5, rect.Width - 10, rect.Height - 10);
            }
        }

        public void LoadColor()
        {
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.EnemyBoxColor.Items.Add(c.Name);
                this.EnemyBoxOutlineColor.Items.Add(c.Name);
                this.FriendlyBoxColor.Items.Add(c.Name);
                FriendlyBoxOutlineC.Items.Add(c.Name);
                TargetEnemyBoxOutlineColor.Items.Add(c.Name);
                TargetEnemyBoxColor.Items.Add(c.Name);
                EnemySnapLineColor.Items.Add(c.Name);
                EnemySnapLineOutlineColor.Items.Add(c.Name);
                FriendlySnapLineColor.Items.Add(c.Name);
                FriendlySnapLineOutlineColor.Items.Add(c.Name);
                TargetEnemySnapLineColor.Items.Add(c.Name);
                TargetEnemySnapLineOutlineColor.Items.Add(c.Name);
                EnemyHealthBarBackColor.Items.Add(c.Name);
                EnemyHealthBarFrontColor.Items.Add(c.Name);
                EnemyHealthBarOutlineColor.Items.Add(c.Name);
                FriendlyHealthBarBackColor.Items.Add(c.Name);
                FriendlyHealthBarFrontColor.Items.Add(c.Name);
                FriendlyHealthBarOutlineColor.Items.Add(c.Name);
                EnemyTargetBoneMarkerColor.Items.Add(c.Name);
                FriendlyTargetBoneMarkerColor.Items.Add(c.Name);
            }

        }

        public void ReadData()
        {
            TempEnabled = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(46)));

            TempDrawEnemyBox = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(47)));
            TempEnemyBoxColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(48)));
            TempEnemyBoxLineWidth = utility.GetValue(utility.SettingsList().ElementAt(49));
            TempEnemyBoxOutlineColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(50)));
            TempEnemyBoxOutlineWidth = utility.GetValue(utility.SettingsList().ElementAt(51));

            TempDrawFriendlyBox = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(52)));
            TempFriendlyBoxColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(53)));
            TempFriendlyBoxLineWidth = utility.GetValue(utility.SettingsList().ElementAt(54));
            TempFriendlyBoxOutlineColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(55)));
            TempFriendlyBoxOutlineWidth = utility.GetValue(utility.SettingsList().ElementAt(56));

            TempDrawTargetBoxHighlight = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(57)));
            TempTargetEnemyBoxColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(58)));
            TempTargetEnemyBoxLineWidth = utility.GetValue(utility.SettingsList().ElementAt(59));
            TempTargetEnemyBoxOutlineColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(60)));
            TempTargetEnemyBoxOutlineWidth = utility.GetValue(utility.SettingsList().ElementAt(61));

            TempDrawEnemySnapLines = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(62)));
            TempEnemySnapLineColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(63)));
            TempEnemySnapLineOutlineColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(64)));
            TempEnemySnapLineOutlineWidth = utility.GetValue(utility.SettingsList().ElementAt(65));
            TempEnemySnapLineWidth = utility.GetValue(utility.SettingsList().ElementAt(66));

            TempDrawFriendlySnapLines = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(67)));
            TempFriendlySnapLineColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(68)));
            TempFriendlySnapLineOutlineColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(69)));
            TempFriendlySnapLineOutlineWidth = utility.GetValue(utility.SettingsList().ElementAt(70));
            TempFriendlySnapLineWidth = utility.GetValue(utility.SettingsList().ElementAt(71));

            TempDrawTargetSnapLineHighlight = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(72)));
            TempTargetEnemySnapLineColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(73)));
            TempTargetEnemySnapLineOutlineColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(74)));
            TempTargetEnemySnapLineOutlineWidth = utility.GetValue(utility.SettingsList().ElementAt(75));
            TempTargetEnemySnapLineWidth = utility.GetValue(utility.SettingsList().ElementAt(76));

            TempDrawEnemyHealthBar = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(77)));
            TempEnemyHealthBarBackColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(78)));
            TempEnemyHealthBarFrontColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(79)));
            TempEnemyHealthBarOutlineColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(80)));
            TempEnemyHealthBarOutlineWidth = utility.GetValue(utility.SettingsList().ElementAt(81));
            TempEnemyHealthBarWidth = utility.GetValue(utility.SettingsList().ElementAt(82));

            TempDrawFriendlyHealthBar = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(83)));
            TempFriendlyHealthBarBackColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(84)));
            TempFriendlyHealthBarFrontColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(85)));
            TempFriendlyHealthBarOutlineColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(86)));
            TempFriendlyHealthBarOutlineWidth = utility.GetValue(utility.SettingsList().ElementAt(87));
            TempFriendlyHealthBarWidth = utility.GetValue(utility.SettingsList().ElementAt(88));

            TempDrawEnemyNameText = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(89)));
            TempDrawEnemyHealthText = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(90)));
            TempDrawEnemyKillsText = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(91)));
            TempDrawEnemyDeathsText = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(92)));
            TempDrawEnemyKDRatioText = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(93)));
            TempDrawEnemyRankText = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(94)));
            TempDrawEnemyBombCarrierText = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(95)));
            TempDrawEnemyDefuseKitCarrierText = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(96)));
            TempEnemyInfoTextColor = utility.GetValue(utility.SettingsList().ElementAt(97));
            TempEnemyInfoTextOutlineColor = utility.GetValue(utility.SettingsList().ElementAt(98));
            TempDrawFriendlyNameText = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(99)));
            TempDrawFriendlyHealthText = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(100)));
            TempDrawFriendlyKillsText = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(101)));
            TempDrawFriendlyDeathsText = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(102)));
            TempDrawFriendlyKDRatioText = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(103)));
            TempDrawFriendlyRankText = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(104)));
            TempDrawFriendlyBombCarrierText = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(105)));
            TempDrawFriendlyDefuseKitCarrierText = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(106)));
            TempFriendlyInfoTextColor = utility.GetValue(utility.SettingsList().ElementAt(107));
            TempFriendlyInfoTextOutlineColor = utility.GetValue(utility.SettingsList().ElementAt(108));

            TempDrawEnemyTargetBoneMarker = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(109)));
            TempEnemyTargetBoneMarkerColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(110)));
            TempEnemyTargetBoneMarkerLineWidth = utility.GetValue(utility.SettingsList().ElementAt(111));
            TempEnemyTargetBoneMarkerSize5 = utility.GetValue(utility.SettingsList().ElementAt(112));
            TempEnemyTargetBoneMarkerType = utility.GetValue(utility.SettingsList().ElementAt(113));
            TempEnemyTargetBoneMarkerOutlineColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(114)));
            TempEnemyTargetBoneMarkerOutlineWidth = utility.GetValue(utility.SettingsList().ElementAt(115));

            TempDrawFriendlyTargetBoneMarker = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(116)));
            TempFriendlyTargetBoneMarkerColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(117)));
            TempFriendlyTargetBoneMarkerLineWidth = utility.GetValue(utility.SettingsList().ElementAt(118));
            TempFriendlyTargetBoneMarkerSize5 = utility.GetValue(utility.SettingsList().ElementAt(119));
            TempFriendlyTargetBoneMarkerType = utility.GetValue(utility.SettingsList().ElementAt(120));
            TempFriendlyTargetBoneMarkerOutlineColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(121)));
            TempFriendlyTargetBoneMarkerOutlineWidth = utility.GetValue(utility.SettingsList().ElementAt(122));

            TempDrawRecoilMarker = utility.StringtoBool(utility.GetValue(utility.SettingsList().ElementAt(123)));
            TempRecoilMarkerColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(124)));
            TempRecoilMarkerLineWidth = utility.GetValue(utility.SettingsList().ElementAt(125));
            TempRecoilMarkerOutlineColor = utility.RGBtoColor(utility.GetValue(utility.SettingsList().ElementAt(126)));
            TempRecoilMarkerOutlineWidth = utility.GetValue(utility.SettingsList().ElementAt(127));
            TempRecoilMarkerSize5 = utility.GetValue(utility.SettingsList().ElementAt(128));
            TempRecoilMarkerType = utility.GetValue(utility.SettingsList().ElementAt(129));
        }

        public void WriteData()
        {
            EnableChecked.Checked = TempEnabled;

            EBoxCheck.Checked = TempDrawEnemyBox;
            EnemyBoxColor.Text = TempEnemyBoxColor;
            EnemyBoxLineWidth.Text = TempEnemyBoxLineWidth;
            EnemyBoxOutlineColor.Text = TempEnemyBoxOutlineColor;
            EnemyBoxOutlineWidth.Text = TempEnemyBoxOutlineWidth;

            FBoxCheck.Checked = TempDrawFriendlyBox;
            FriendlyBoxColor.Text = TempFriendlyBoxColor;
            FriendlyBoxLineWidth.Text = TempFriendlyBoxLineWidth;
            FriendlyBoxOutlineC.Text = TempFriendlyBoxOutlineColor;
            FriendlyBoxOutlineWidth.Text = TempFriendlyBoxOutlineWidth;

            TEBoxCheck.Checked = TempDrawTargetBoxHighlight;
            TargetEnemyBoxColor.Text = TempTargetEnemyBoxColor;
            TargetEnemyBoxLineWidth.Text = TempTargetEnemyBoxLineWidth;
            TargetEnemyBoxOutlineColor.Text = TempTargetEnemyBoxOutlineColor;
            TargetEnemyBoxOutlineWidth.Text = TempTargetEnemyBoxOutlineWidth;

            ESnapCheck.Checked = TempDrawEnemySnapLines;
            EnemySnapLineColor.Text = TempEnemySnapLineColor;
            EnemySnapLineOutlineColor.Text = TempEnemySnapLineOutlineColor;
            EnemySnapLineOutlineWidth.Text = TempEnemySnapLineOutlineWidth;
            EnemySnapLineWidth.Text = TempEnemySnapLineWidth;

            FriendlySnapLinesCheck.Checked = TempDrawFriendlySnapLines;
            FriendlySnapLineColor.Text = TempFriendlySnapLineColor;
            FriendlySnapLineOutlineColor.Text = TempFriendlySnapLineOutlineColor;
            FriendlySnapLineOutlineWidth.Text = TempFriendlySnapLineOutlineWidth;
            FriendlySnapLineWidth.Text = TempFriendlySnapLineWidth;

            TargetSnapLineCheck.Checked = TempDrawTargetSnapLineHighlight;
            TargetEnemySnapLineColor.Text = TempTargetEnemySnapLineColor;
            TargetEnemySnapLineOutlineColor.Text = TempTargetEnemySnapLineOutlineColor;
            TargetEnemySnapLineOutlineWidth.Text = TempTargetEnemySnapLineOutlineWidth;
            TargetEnemySnapLineWidth.Text = TempTargetEnemySnapLineWidth;

            EnemyHealthBarCheck.Checked = TempDrawEnemyHealthBar;
            EnemyHealthBarBackColor.Text = TempEnemyHealthBarBackColor;
            EnemyHealthBarFrontColor.Text = TempEnemyHealthBarFrontColor;
            EnemyHealthBarOutlineColor.Text = TempEnemyHealthBarOutlineColor;
            EnemyHealthBarOutlineWidth.Text = TempEnemyHealthBarOutlineWidth;
            EnemyHealthBarWidth.Text = TempEnemyHealthBarWidth;

            FHealthBarCheck.Checked = TempDrawFriendlyHealthBar;
            FriendlyHealthBarBackColor.Text = TempFriendlyHealthBarBackColor;
            FriendlyHealthBarFrontColor.Text = TempFriendlyHealthBarFrontColor;
            FriendlyHealthBarOutlineColor.Text = TempFriendlyHealthBarOutlineColor;
            FriendlyHealthBarOutlineWidth.Text = TempFriendlyHealthBarOutlineWidth;
            FriendlyHealthBarWidth.Text = TempFriendlyHealthBarWidth;

            EnemyName.Checked = TempDrawEnemyNameText;
            EnemyHealthText.Checked = TempDrawEnemyHealthText;
            EnemyKills.Checked = TempDrawEnemyKillsText;
            EnemyDeaths.Checked = TempDrawEnemyDeathsText;
            EnemyKDRatio.Checked = TempDrawEnemyKDRatioText;
            EnemyRank.Checked = TempDrawEnemyRankText;
            EnemyBombCarrier.Checked = TempDrawEnemyBombCarrierText;
            EnemyDefuseKitCarrier.Checked = TempDrawEnemyDefuseKitCarrierText;

            FriendlyName.Checked = TempDrawFriendlyNameText;
            FriendlyHealthText.Checked = TempDrawFriendlyHealthText;
            FriendlyKills.Checked = TempDrawFriendlyKillsText;
            FriendlyDeaths.Checked = TempDrawFriendlyDeathsText;
            FriendlyKDRatio.Checked = TempDrawFriendlyKDRatioText;
            FriendlyRank.Checked = TempDrawFriendlyRankText;
            FriendlyBombCarrier.Checked = TempDrawFriendlyBombCarrierText;
            FriendlyDefuseKit.Checked = TempDrawFriendlyDefuseKitCarrierText;

            ETargetBoneMarkerCheck.Checked = TempDrawEnemyTargetBoneMarker;
            EnemyTargetBoneMarkerColor.Text = TempEnemyTargetBoneMarkerColor;
            EnemyTargetBoneMarkerLineWidth.Text = TempEnemyTargetBoneMarkerLineWidth;
            EnemyTargetBoneMarkerSize.Text = TempEnemyTargetBoneMarkerSize5;
            EnemyTargetBoneMarkerType.Text = TempEnemyTargetBoneMarkerType;

            FtargetBoneMarkerCheck.Checked = TempDrawFriendlyTargetBoneMarker;
            FriendlyTargetBoneMarkerColor.Text = TempFriendlyTargetBoneMarkerColor;
            FriendlyTargetBoneMarkerLineWidth.Text = TempFriendlyTargetBoneMarkerLineWidth;
            FriendlyTargetBoneMarkerSize.Text = TempFriendlyTargetBoneMarkerSize5;
            FriendlyTargetBoneMarkerType.Text = TempFriendlyTargetBoneMarkerType;
        }

        public void save()
        {
            utility.Editor(string.Format("EspSettings.Enabled = {0}", utility.BooltoString(TempEnabled)), string.Format("EspSettings.Enabled = {0}", utility.BooltoString(EnableChecked.Checked)));

            utility.Editor(string.Format("EspSettings.DrawEnemyBox = {0}", utility.BooltoString(TempDrawEnemyBox)), string.Format("EspSettings.DrawEnemyBox = {0}", utility.BooltoString(EBoxCheck.Checked)));
            utility.Editor(string.Format("EspSettings.EnemyBoxColor = {0}", utility.ColortoRGB(TempEnemyBoxColor)), string.Format("EspSettings.EnemyBoxColor = {0}",utility.ColortoRGB(EnemyBoxColor.Text)));
            utility.Editor(string.Format("EspSettings.EnemyBoxLineWidth = {0}", TempEnemyBoxLineWidth), string.Format("EspSettings.EnemyBoxLineWidth = {0}", EnemyBoxLineWidth.Text));
            utility.Editor(string.Format("EspSettings.EnemyBoxOutlineColor = {0}", utility.ColortoRGB(TempEnemyBoxOutlineColor)), string.Format("EspSettings.EnemyBoxOutlineColor = {0}", utility.ColortoRGB(EnemyBoxOutlineColor.Text)));
            utility.Editor(string.Format("EspSettings.EnemyBoxOutlineWidth = {0}", TempEnemyBoxOutlineWidth), string.Format("EspSettings.EnemyBoxOutlineWidth = {0}", EnemyBoxOutlineWidth.Text));

            utility.Editor(string.Format("EspSettings.DrawFriendlyBox = {0}", utility.BooltoString(TempDrawFriendlyBox)), string.Format("EspSettings.DrawFriendlyBox = {0}", utility.BooltoString(FBoxCheck.Checked)));
            utility.Editor(string.Format("EspSettings.FriendlyBoxColor = {0}", utility.ColortoRGB(TempFriendlyBoxColor)), string.Format("EspSettings.FriendlyBoxColor = {0}", utility.ColortoRGB(FriendlyBoxColor.Text)));
            utility.Editor(string.Format("EspSettings.FriendlyBoxLineWidth = {0}", (TempFriendlyBoxLineWidth)), string.Format("EspSettings.FriendlyBoxLineWidth = {0}", FriendlyBoxLineWidth.Text));
            utility.Editor(string.Format("EspSettings.FriendlyBoxOutlineColor = {0}", utility.ColortoRGB(TempFriendlyBoxOutlineColor)), string.Format("EspSettings.FriendlyBoxOutlineColor = {0}", utility.ColortoRGB(FriendlyBoxOutlineColor.Text)));
            utility.Editor(string.Format("EspSettings.FriendlyBoxOutlineWidth = {0}", (TempFriendlyBoxOutlineWidth)), string.Format("EspSettings.FriendlyBoxOutlineWidth = {0}", FriendlyBoxOutlineWidth.Text));

            utility.Editor(string.Format("EspSettings.DrawTargetBoxHighlight = {0}", (TempDrawTargetBoxHighlight)), string.Format("EspSettings.DrawTargetBoxHighlight = {0}", utility.BooltoString(TEBoxCheck.Checked)));
            utility.Editor(string.Format("EspSettings.TargetEnemyBoxColor = {0}", utility.ColortoRGB(TempTargetEnemyBoxColor)), string.Format("EspSettings.TargetEnemyBoxColor = {0}", utility.ColortoRGB(TargetEnemyBoxColor.Text)));
            utility.Editor(string.Format("EspSettings.TargetEnemyBoxLineWidth = {0}", (TempTargetEnemyBoxLineWidth)), string.Format("EspSettings.TargetEnemyBoxLineWidth = {0}", TargetEnemyBoxLineWidth.Text));
            utility.Editor(string.Format("EspSettings.TargetEnemyBoxOutlineColor = {0}", utility.ColortoRGB(TempTargetEnemyBoxOutlineColor)), string.Format("EspSettings.TargetEnemyBoxOutlineColor = {0}", utility.ColortoRGB(TargetEnemyBoxOutlineColor.Text)));
            utility.Editor(string.Format("EspSettings.TargetEnemyBoxOutlineWidth = {0}", (TempTargetEnemyBoxOutlineWidth)), string.Format("EspSettings.TargetEnemyBoxOutlineWidth = {0}", TargetEnemyBoxOutlineWidth.Text));

            utility.Editor(string.Format("EspSettings.DrawEnemySnapLines = {0}", (TempDrawEnemySnapLines)), string.Format("EspSettings.DrawEnemySnapLines = {0}", utility.BooltoString(ESnapCheck.Checked)));
            utility.Editor(string.Format("EspSettings.EnemySnapLineColor = {0}", utility.ColortoRGB(TempEnemySnapLineColor)), string.Format("EspSettings.EnemySnapLineColor = {0}", utility.ColortoRGB(EnemySnapLineColor.Text)));
            utility.Editor(string.Format("EspSettings.EnemySnapLineOutlineColor = {0}", utility.ColortoRGB(TempEnemySnapLineOutlineColor)), string.Format("EspSettings.EnemySnapLineOutlineColor = {0}", utility.ColortoRGB(EnemySnapLineOutlineColor.Text)));
            utility.Editor(string.Format("EspSettings.EnemySnapLineOutlineWidth = {0}", (TempEnemySnapLineOutlineWidth)), string.Format("EspSettings.EnemySnapLineOutlineWidth = {0}", EnemySnapLineOutlineWidth.Text));
            utility.Editor(string.Format("EspSettings.EnemySnapLineWidth = {0}", (TempEnemySnapLineWidth)), string.Format("EspSettings.EnemySnapLineWidth = {0}", EnemySnapLineWidth.Text));

            utility.Editor(string.Format("EspSettings.DrawFriendlySnapLines = {0}", (TempDrawFriendlySnapLines)), string.Format("EspSettings.DrawFriendlySnapLines = {0}", utility.BooltoString(FriendlySnapLinesCheck.Checked)));
            utility.Editor(string.Format("EspSettings.FriendlySnapLineColor = {0}", utility.ColortoRGB(TempFriendlySnapLineColor)), string.Format("EspSettings.FriendlySnapLineColor = {0}", utility.ColortoRGB(FriendlySnapLineColor.Text)));
            utility.Editor(string.Format("EspSettings.FriendlySnapLineOutlineColor = {0}", utility.ColortoRGB(TempFriendlySnapLineOutlineColor)), string.Format("EspSettings.FriendlySnapLineOutlineColor = {0}", utility.ColortoRGB(FriendlySnapLineOutlineColor.Text)));
            utility.Editor(string.Format("EspSettings.FriendlySnapLineOutlineWidth = {0}", (TempFriendlySnapLineOutlineWidth)), string.Format("EspSettings.FriendlySnapLineOutlineWidth = {0}", FriendlySnapLineOutlineWidth.Text));
            utility.Editor(string.Format("EspSettings.FriendlySnapLineWidth = {0}", (TempFriendlySnapLineWidth)), string.Format("EspSettings.FriendlySnapLineWidth = {0}", FriendlySnapLineWidth.Text));

            utility.Editor(string.Format("EspSettings.DrawTargetSnapLineHighlight = {0}", (TempDrawTargetSnapLineHighlight)), string.Format("EspSettings.DrawTargetSnapLineHighlight = {0}", utility.BooltoString(TargetSnapLineCheck.Checked)));
            utility.Editor(string.Format("EspSettings.TargetEnemySnapLineColor = {0}", utility.ColortoRGB(TempTargetEnemySnapLineColor)), string.Format("EspSettings.TargetEnemySnapLineColor = {0}", utility.ColortoRGB(TargetEnemySnapLineColor.Text)));
            utility.Editor(string.Format("EspSettings.TargetEnemySnapLineOutlineColor = {0}", utility.ColortoRGB(TempTargetEnemySnapLineOutlineColor)), string.Format("EspSettings.TargetEnemySnapLineOutlineColor = {0}", utility.ColortoRGB(TargetEnemySnapLineOutlineColor.Text)));
            utility.Editor(string.Format("EspSettings.TargetEnemySnapLineOutlineWidth = {0}", (TempTargetEnemySnapLineOutlineWidth)), string.Format("EspSettings.TargetEnemySnapLineOutlineWidth = {0}", TargetEnemySnapLineOutlineWidth.Text));
            utility.Editor(string.Format("EspSettings.TargetEnemySnapLineWidth = {0}", (TempTargetEnemySnapLineWidth)), string.Format("EspSettings.TargetEnemySnapLineWidth = {0}", TargetEnemySnapLineWidth.Text));

            utility.Editor(string.Format("EspSettings.DrawEnemyHealthBar = {0}", (TempDrawEnemyHealthBar)), string.Format("EspSettings.DrawEnemyHealthBar = {0}", utility.BooltoString(EnemyHealthBarCheck.Checked)));
            utility.Editor(string.Format("EspSettings.EnemyHealthBarBackColor = {0}", utility.ColortoRGB(TempEnemyHealthBarBackColor)), string.Format("EspSettings.EnemyHealthBarBackColor = {0}", utility.ColortoRGB(EnemyHealthBarBackColor.Text)));
            utility.Editor(string.Format("EspSettings.EnemyHealthBarFrontColor = {0}", utility.ColortoRGB(TempEnemyHealthBarFrontColor)), string.Format("EspSettings.EnemyHealthBarFrontColor = {0}", utility.ColortoRGB(EnemyHealthBarFrontColor.Text)));
            utility.Editor(string.Format("EspSettings.EnemyHealthBarOutlineColor = {0}", utility.ColortoRGB(TempEnemyHealthBarOutlineColor)), string.Format("EspSettings.EnemyHealthBarOutlineColor = {0}", utility.ColortoRGB(EnemyHealthBarOutlineColor.Text)));
            utility.Editor(string.Format("EspSettings.EnemyHealthBarOutlineWidth = {0}", (TempEnemyHealthBarOutlineWidth)), string.Format("EspSettings.EnemyHealthBarOutlineWidth = {0}", EnemyHealthBarOutlineWidth.Text));
            utility.Editor(string.Format("EspSettings.EnemyHealthBarWidth = {0}", (TempEnemyHealthBarWidth)), string.Format("EspSettings.EnemyHealthBarWidth = {0}", EnemyHealthBarWidth.Text));

            utility.Editor(string.Format("EspSettings.DrawFriendlyHealthBar = {0}", (TempDrawFriendlyHealthBar)), string.Format("EspSettings.DrawFriendlyHealthBar = {0}", utility.BooltoString(FHealthBarCheck.Checked)));
            utility.Editor(string.Format("EspSettings.FriendlyHealthBarBackColor = {0}", utility.ColortoRGB(TempFriendlyHealthBarBackColor)), string.Format("EspSettings.FriendlyHealthBarBackColor = {0}", utility.ColortoRGB(FriendlyHealthBarBackColor.Text)));
            utility.Editor(string.Format("EspSettings.FriendlyHealthBarFrontColor = {0}", utility.ColortoRGB(TempFriendlyHealthBarFrontColor)), string.Format("EspSettings.FriendlyHealthBarFrontColor = {0}", utility.ColortoRGB(FriendlyHealthBarFrontColor.Text)));
            utility.Editor(string.Format("EspSettings.FriendlyHealthBarOutlineColor = {0}", utility.ColortoRGB(TempFriendlyHealthBarOutlineColor)), string.Format("EspSettings.FriendlyHealthBarOutlineColor = {0}", utility.ColortoRGB(FriendlyHealthBarOutlineColor.Text)));
            utility.Editor(string.Format("EspSettings.FriendlyHealthBarOutlineWidth = {0}", (TempFriendlyHealthBarOutlineWidth)), string.Format("EspSettings.FriendlyHealthBarOutlineWidth = {0}", FriendlyHealthBarOutlineWidth.Text));
            utility.Editor(string.Format("EspSettings.FriendlyHealthBarWidth = {0}", (TempFriendlyHealthBarWidth)), string.Format("EspSettings.FriendlyHealthBarWidth = {0}", FriendlyHealthBarWidth.Text));

            utility.Editor(string.Format("EspSettings.DrawEnemyNameText = {0}", (TempDrawEnemyNameText)), string.Format("EspSettings.DrawEnemyNameText = {0}", utility.BooltoString(EnemyName.Checked)));
            utility.Editor(string.Format("EspSettings.DrawEnemyHealthText = {0}", (TempDrawEnemyHealthText)), string.Format("EspSettings.DrawEnemyHealthText = {0}", utility.BooltoString(EnemyHealthText.Checked)));
            utility.Editor(string.Format("EspSettings.DrawEnemyKillsText = {0}", (TempDrawEnemyKillsText)), string.Format("EspSettings.DrawEnemyKillsText = {0}", utility.BooltoString(EnemyKills.Checked)));
            utility.Editor(string.Format("EspSettings.DrawEnemyDeathsText = {0}", (TempDrawEnemyDeathsText)), string.Format("EspSettings.DrawEnemyDeathsText = {0}", utility.BooltoString(EnemyDeaths.Checked)));
            utility.Editor(string.Format("EspSettings.DrawEnemyKDRatioText = {0}", (TempDrawEnemyKDRatioText)), string.Format("EspSettings.DrawEnemyKDRatioText = {0}", utility.BooltoString(EnemyKDRatio.Checked)));
            utility.Editor(string.Format("EspSettings.DrawEnemyRankText = {0}", (TempDrawEnemyRankText)), string.Format("EspSettings.DrawEnemyRankText = {0}", utility.BooltoString(EnemyRank.Checked)));
            utility.Editor(string.Format("EspSettings.DrawEnemyBombCarrierText = {0}", (TempDrawEnemyBombCarrierText)), string.Format("EspSettings.DrawEnemyBombCarrierText = {0}", utility.BooltoString(EnemyBombCarrier.Checked)));
            utility.Editor(string.Format("EspSettings.DrawEnemyDefuseKitCarrierText = {0}", (TempDrawEnemyDefuseKitCarrierText)), string.Format("EspSettings.DrawEnemyDefuseKitCarrierText = {0}", utility.BooltoString(EnemyDefuseKitCarrier.Checked)));
            utility.Editor(string.Format("EspSettings.EnemyInfoTextColor = {0}", (TempEnemyInfoTextColor)), string.Format("EspSettings.EnemyInfoTextColor = {0}", ""));
            utility.Editor(string.Format("EspSettings.EnemyInfoTextOutlineColor = {0}", (TempEnemyInfoTextOutlineColor)), string.Format("EspSettings.EnemyInfoTextOutlineColor = {0}", ""));
            utility.Editor(string.Format("EspSettings.DrawFriendlyNameText = {0}", (TempDrawFriendlyNameText)), string.Format("EspSettings.DrawFriendlyNameText = {0}", utility.BooltoString(FriendlyName.Checked)));
            utility.Editor(string.Format("EspSettings.DrawFriendlyHealthText = {0}", (TempDrawFriendlyHealthText)), string.Format("EspSettings.DrawFriendlyHealthText = {0}", utility.BooltoString(FriendlyHealthText.Checked)));
            utility.Editor(string.Format("EspSettings.DrawFriendlyKillsText = {0}", (TempDrawFriendlyKillsText)), string.Format("EspSettings.DrawFriendlyKillsText = {0}", utility.BooltoString(FriendlyKills.Checked)));
            utility.Editor(string.Format("EspSettings.DrawFriendlyDeathsText = {0}", (TempDrawFriendlyDeathsText)), string.Format("EspSettings.DrawFriendlyDeathsText = {0}", utility.BooltoString(FriendlyDeaths.Checked)));
            utility.Editor(string.Format("EspSettings.DrawFriendlyKDRatioText = {0}", (TempDrawFriendlyKDRatioText)), string.Format("EspSettings.DrawFriendlyKDRatioText = {0}", utility.BooltoString(FriendlyKDRatio.Checked)));
            utility.Editor(string.Format("EspSettings.DrawFriendlyRankText = {0}", (TempDrawFriendlyRankText)), string.Format("EspSettings.DrawFriendlyRankText = {0}", utility.BooltoString(FriendlyRank.Checked)));
            utility.Editor(string.Format("EspSettings.DrawFriendlyBombCarrierText = {0}", (TempDrawFriendlyBombCarrierText)), string.Format("EspSettings.DrawFriendlyBombCarrierText = {0}", utility.BooltoString(FriendlyBombCarrier.Checked)));
            utility.Editor(string.Format("EspSettings.DrawFriendlyDefuseKitCarrierText = {0}", (TempDrawFriendlyDefuseKitCarrierText)), string.Format("EspSettings.DrawFriendlyDefuseKitCarrierText = {0}", utility.BooltoString(FriendlyDefuseKit.Checked)));
            utility.Editor(string.Format("EspSettings.FriendlyInfoTextColor = {0}", (TempFriendlyInfoTextColor)), string.Format("EspSettings.FriendlyInfoTextColor = {0}", ""));
            utility.Editor(string.Format("EspSettings.FriendlyInfoTextOutlineColor = {0}", (TempFriendlyInfoTextOutlineColor)), string.Format("EspSettings.FriendlyInfoTextOutlineColor = {0}", ""));

            utility.Editor(string.Format("EspSettings.DrawEnemyTargetBoneMarker = {0}", (TempDrawEnemyTargetBoneMarker)), string.Format("EspSettings.DrawEnemyTargetBoneMarker = {0}", utility.BooltoString(ETargetBoneMarkerCheck.Checked)));
            utility.Editor(string.Format("EspSettings.EnemyTargetBoneMarkerColor = {0}", utility.ColortoRGB(TempEnemyTargetBoneMarkerColor)), string.Format("EspSettings.EnemyTargetBoneMarkerColor = {0}", utility.ColortoRGB(EnemyTargetBoneMarkerColor.Text)));
            utility.Editor(string.Format("EspSettings.EnemyTargetBoneMarkerLineWidth = {0}", (TempEnemyTargetBoneMarkerLineWidth)), string.Format("EspSettings.EnemyTargetBoneMarkerLineWidth = {0}", EnemyTargetBoneMarkerLineWidth.Text));
            utility.Editor(string.Format("EspSettings.EnemyTargetBoneMarkerSize = {0}", (TempEnemyTargetBoneMarkerSize5)), string.Format("EspSettings.EnemyTargetBoneMarkerSize = {0}", EnemyTargetBoneMarkerSize.Text));
            utility.Editor(string.Format("EspSettings.EnemyTargetBoneMarkerType =  {0}", (TempEnemyTargetBoneMarkerType)), string.Format("EspSettings.EnemyTargetBoneMarkerType =  {0}", EnemyTargetBoneMarkerType.Text));
            //utility.Editor(string.Format("EspSettings.EnemyTargetBoneMarkerOutlineColor = {0}", (TempEnemyTargetBoneMarkerOutlineColor)), string.Format("EspSettings.EnemyTargetBoneMarkerOutlineColor = {0}", EnemyTargetBoneMarkerOutlineColor));
            //utility.Editor(string.Format("EspSettings.EnemyTargetBoneMarkerOutlineWidth = {0}", (TempEnemyTargetBoneMarkerOutlineWidth)), string.Format("EspSettings.EnemyTargetBoneMarkerOutlineWidth = {0}",EnemyTargetBoneMarkerOutlineWidth ));

            utility.Editor(string.Format("EspSettings.DrawFriendlyTargetBoneMarker = {0}", (TempDrawFriendlyTargetBoneMarker)), string.Format("EspSettings.DrawFriendlyTargetBoneMarker = {0}", utility.BooltoString(FtargetBoneMarkerCheck.Checked)));
            utility.Editor(string.Format("EspSettings.FriendlyTargetBoneMarkerColor = {0}", utility.ColortoRGB(TempFriendlyTargetBoneMarkerColor)), string.Format("EspSettings.FriendlyTargetBoneMarkerColor = {0}", utility.ColortoRGB(FriendlyTargetBoneMarkerColor.Text)));
            utility.Editor(string.Format("EspSettings.FriendlyTargetBoneMarkerLineWidth = {0}", (TempFriendlyTargetBoneMarkerLineWidth)), string.Format("EspSettings.FriendlyTargetBoneMarkerLineWidth = {0}", FriendlyTargetBoneMarkerLineWidth.Text));
            utility.Editor(string.Format("EspSettings.FriendlyTargetBoneMarkerSize = {0}", (TempFriendlyTargetBoneMarkerSize5)), string.Format("EspSettings.FriendlyTargetBoneMarkerSize = {0}", FriendlyTargetBoneMarkerSize.Text));
            utility.Editor(string.Format("EspSettings.FriendlyTargetBoneMarkerType =  {0}", (TempFriendlyTargetBoneMarkerType)), string.Format("EspSettings.FriendlyTargetBoneMarkerType =  {0}", FriendlyTargetBoneMarkerType.Text));
            //utility.Editor(string.Format("EspSettings.FriendlyTargetBoneMarkerOutlineColor = {0}", (TempFriendlyTargetBoneMarkerOutlineColor)), string.Format("EspSettings.FriendlyTargetBoneMarkerOutlineColor = {0}",FriendlyTargetBoneMarkerOutlineColor ));
            //utility.Editor(string.Format("EspSettings.FriendlyTargetBoneMarkerOutlineWidth = {0}", (TempFriendlyTargetBoneMarkerOutlineWidth)), string.Format("EspSettings.FriendlyTargetBoneMarkerOutlineWidth = {0}", FriendlyTargetBoneMarkerOutlineWidth));
            //utility.Editor(string.Format("EspSettings.DrawRecoilMarker = {0}", (Temp)), string.Format("EspSettings.DrawRecoilMarker = {0}", ));
            //utility.Editor(string.Format("EspSettings.RecoilMarkerColor = {0}", (Temp)), string.Format("EspSettings.RecoilMarkerColor = {0}", ));
            //utility.Editor(string.Format("EspSettings.RecoilMarkerLineWidth = {0}", (Temp)), string.Format("EspSettings.RecoilMarkerLineWidth = {0}", ));
            //utility.Editor(string.Format("EspSettings.RecoilMarkerOutlineColor = {0}", (Temp)), string.Format("EspSettings.RecoilMarkerOutlineColor = {0}", ));
            //utility.Editor(string.Format("EspSettings.RecoilMarkerOutlineWidth = {0}", (Temp)), string.Format("EspSettings.RecoilMarkerOutlineWidth = {0}", ));
            //utility.Editor(string.Format("EspSettings.RecoilMarkerSize = {0}", (Temp)), string.Format("EspSettings.RecoilMarkerSize = {0}", ));
            //utility.Editor(string.Format("EspSettings.RecoilMarkerType =  {0}", (Temp)), string.Format("EspSettings.RecoilMarkerType =  {0}", ));

        }

        private void SaveSetting_Click(object sender, EventArgs e)
        {
            save();
            MessageBox.Show("Saved", "DONE!");
        }

    }
}
