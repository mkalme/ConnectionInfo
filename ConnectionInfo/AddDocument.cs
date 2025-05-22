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
    public partial class AddDocument : Form
    {
        private const string dialogText = "Text contains unicode characters, they will be deleted. Do you want to continue?";
        public static Base baseForm;

        public AddDocument()
        {
            InitializeComponent();

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
                for (int i = 0; i < baseForm.dataGridView1.RowCount; i++)
                {
                    if (Methods.replaceSpecial(textBox1.Text).Equals(baseForm.dataGridView1.Rows[i].Cells[1].Value.ToString()))
                    {
                        ifEnabled = false;
                    }
                }

                doneButton.Enabled = ifEnabled;
            }
            else
            {
                doneButton.Enabled = false;
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (Methods.ContainsSpecialCharacters(textBox1.Text))
            {
                if (Methods.dialog(dialogText, "Unicode Characters") == DialogResult.Yes)
                {
                    addDocument();
                }
            }
            else
            {
                addDocument();
            }
        }

        public void addDocument() {
            Decoding.addDocument(Base.location, new String[] { Methods.replaceSpecial(textBox1.Text), "", DateTime.Now.ToString("M.d.yyyy  HH:mm"), new FontConverter().ConvertToString(new Font("Consolas", 11)) });
            Decoding.update();
            baseForm.refresh_dataGridView();

            Hide();

            baseForm.openDocument(textBox1.Text);

            Close();
        }
    }
}
