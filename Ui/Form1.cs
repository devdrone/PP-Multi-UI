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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A form = new A();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            E form = new E();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            T from = new T();
            from.Show();
        }

        
    }
}
