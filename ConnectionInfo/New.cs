using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ConnectionInfo
{
    public partial class New : Form
    {
        public static String key = "";

        public New()
        {
            InitializeComponent();

            //SET PASSWORD CHARACTER
            textBox1.PasswordChar = '\u25CF';
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(string.IsNullOrEmpty(textBox1.Text) ? " " : textBox1.Text);
        }

        private void New_Load(object sender, EventArgs e)
        {
            textBox1.Text = key;
        }
    }
}
