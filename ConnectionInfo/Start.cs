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
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ConnectionInfo
{
    public partial class Start : Form
    {

        public Start()
        {
            InitializeComponent();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            String text = entTextBox.Text.Replace("-", "").Replace(" ", "");
            Encryption.key = Methods.hexToByte(text);

            Base baseForm = new Base();

            Hide();

            baseForm.ShowDialog();

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void entTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.CapsLock)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {
            //SET PASSWORD CHARACTER
            entTextBox.PasswordChar = '\u25CF';

            //CHECK IF DIRECTORY EXISTS
            if (!File.Exists(Base.infoFile))
            {
                newKey();
            }
        }

        private void newKey() {
            //GENERATE KEY
            Encryption.generateKey();

            //CREATE BASE
            Methods.create();

            New newForm = new New();
            New.key = Methods.byteToHex(Encryption.key);

            //HIDE
            Hide();

            //OPEN FORM
            newForm.ShowDialog();

            //OPEN BASE FORM
            Base baseForm = new Base();
            baseForm.ShowDialog();

            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Change changeForm = new Change();

            Hide();

            changeForm.ShowDialog();

            Close();
        }
    }
}
