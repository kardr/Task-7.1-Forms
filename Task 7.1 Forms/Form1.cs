using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7._1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = Convert.ToString(textBox1.Text);
            var set = new HashSet<char>();
            foreach (var chr in s)
            {
                set.Add(chr);
            }
            textBox2.Text += set.Count;
        }
    }
}
