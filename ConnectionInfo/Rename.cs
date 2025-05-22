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
    public partial class Rename : Form
    {
        private const string dialogText = "Text contains unicode characters, they will be deleted. Do you want to continue?";

        public static Base baseForm;

        public Rename()
        {
            InitializeComponent();
        }

        private void Rename_Load(object sender, EventArgs e)
        {
            textBox1.Text = baseForm.getCol(1);

            timer1.Start();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Methods.replaceSpecial(textBox1.Text)))
            {
                bool ifEnabled = true;
                for (int i = 0; i < baseForm.dataGridView1.RowCount; i++) {
                    if (Methods.replaceSpecial(textBox1.Text).Equals(baseForm.dataGridView1.Rows[i].Cells[1].Value.ToString())) {
                        ifEnabled = false;
                    }
                }

                doneButton.Enabled = ifEnabled;
            }
            else {
                doneButton.Enabled = false;
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (Methods.ContainsSpecialCharacters(textBox1.Text))
            {
                if (Methods.dialog(dialogText, "Unicode Characters") == DialogResult.Yes)
                {
                    changeName();
                }
            }
            else
            {
                changeName();
            }
        }

        private void changeName() {
            Decoding.changeName(Base.location, baseForm.getCol(1), Methods.replaceSpecial(textBox1.Text), 0, Int32.Parse(baseForm.getCol(6)));

            Decoding.update();
            baseForm.refresh_dataGridView();

            Close();
        }
    }
}
