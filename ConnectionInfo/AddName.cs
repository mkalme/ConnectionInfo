using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionInfo
{
    public partial class AddName : Form
    {
        public static Label label;

        public AddName()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            label.Text = textBox1.Text;

            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                doneButton.Enabled = false;
            }
            else {
                doneButton.Enabled = true;
            }
        }
    }
}
