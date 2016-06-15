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
using System.IO;
using System.Text.RegularExpressions;

namespace Ui
{
    class Utils
    {
        public void Editor(string oldvalue, string newvalue)
        {
            File.WriteAllText("C:\\PP-Multi\\Settings.txt", File.ReadAllText("C:\\PP-Multi\\Settings.txt").Replace(oldvalue, newvalue));
        }

        public string BooltoString(bool enable)
        {
            string value;
            if (enable)
            {
                value = "1";
            }
            else
            {
                value = "0";
            }
            return value;
        }

        public IEnumerable<string> SettingsList()
        {
            IEnumerable<String> lines = lines = File.ReadLines("C:\\PP-Multi\\Settings.txt");
            return lines;
        }

        public string GetValue(string value)
        {
            string returnvalue = value.Split(' ').Last();
            if (returnvalue.Contains("("))
            {
                returnvalue = returnvalue.Replace("(", "");
                returnvalue = returnvalue.Replace(")", "");
            }
            return returnvalue;
        }

        public bool StringtoBool(string value)
        {
            if (value == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string RGBtoColor(string RGB)
        {
            int A = int.Parse(RGB.Split(',').ElementAt(0));
            int R = int.Parse(RGB.Split(',').ElementAt(1));
            int G = int.Parse(RGB.Split(',').ElementAt(2));
            int B = int.Parse(RGB.Split(',').ElementAt(3));
            string colorname = ColorTranslator.FromHtml(string.Format("#{0}", Color.FromArgb(A, R, G, B).Name)).Name;
            return colorname;
        }

        public string ColortoRGB(string color)
        {
            string a = Color.FromName(color).A.ToString();
            string r = Color.FromName(color).R.ToString();
            string g = Color.FromName(color).G.ToString();
            string b = Color.FromName(color).B.ToString();
            if (a == "0")
            {
                a = "000";
            }
            if (r == "0")
            {
                r = "000";
            }
            if (g == "0")
            {
                g = "000";
            }
            if (b == "0")
            {
                b = "000";
            }
            string RGB = string.Format("({0},{1},{2},{3})", a, r, g, b);
            return RGB;
        }
    }

}
