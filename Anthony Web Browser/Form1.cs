using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anthony_Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri(textBox1.Text);
        }

        private void aboutAnthonysWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anthony's Web Browser Version 1.0 © Anthony Corbin Kruse");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("http://www.google.com/");
        }
    }
}
