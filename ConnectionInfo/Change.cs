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

namespace ConnectionInfo
{
    public partial class Change : Form
    {
        private const string dialogText = "Are you sure you want to change your key?\t\t\t\t";

        public Change()
        {
            InitializeComponent();

            //SET PASSWORD CHARACTER
            textBox1.PasswordChar = '\u25CF';
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (Methods.dialog(dialogText, "Change key") == DialogResult.Yes)
            {
                changeKey();
            }
        }

        private void changeKey() {
            //GET KEY
            String key = textBox1.Text.Replace("-", "").Replace(" ", "");
            Encryption.key = Methods.hexToByte(key);
            
            //DECRYPT
            String text = Encryption.Decrypt(Methods.readFile(Base.infoFile));

            //CHANGE KEY
            Encryption.generateKey();

            //ENCRYPT FILE
            Methods.writeFile(Base.infoFile, Methods.insertNewLine(Encryption.Encrypt(text)));
            Methods.writeFile(Base.basePath + @"\back", Methods.insertNewLine(Encryption.Encrypt(text)));

            //DISPLAY
            New newForm = new New();
            Hide();
            New.key = Methods.byteToHex(Encryption.key);
            newForm.ShowDialog();

            //OPEN BASE FORM
            Base baseForm = new Base();
            Hide();
            baseForm.ShowDialog();
            Close();
        }
    }
}
