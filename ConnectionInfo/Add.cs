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
    public partial class Add : Form
    {
        private const string dialogText = "File contains special characters, they will be deleted. Do you want to continue?";
        public static Base baseForm;
        public static int type = 0;

        public static String[] arrayFields = new String[12];
        public static String[] allText;

        public static String oldName = "";

        public Add()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            String[] array = { nameField.Text, websiteField.Text, passwordField.Text, emailField.Text, noteBox.Text, labelName.Text, nameField1.Text, passwordField1.Text, labelName1.Text, nameField2.Text, passwordField2.Text, enableEditing.Checked.ToString(), DateTime.Now.ToString("M.d.yyyy  HH:mm") };

            if (Methods.ContainsSpecialCharacters(String.Join("", array)))
            {
                if (Methods.dialog(dialogText, "Unicode Characters") == DialogResult.Yes)
                {
                    saveChangeFile(type, array);
                }
            }
            else
            {
                saveChangeFile(type, array);
            }
        }

        public void saveChangeFile(int type, String[] array){
            if (type == 0)
            {
                saveFile(array);
            }
            else {
                changeFile(array);
            }

            Close();
        }

        public static void saveFile(String[] array) {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Methods.replaceSpecial(array[i]);
                if (string.IsNullOrEmpty(array[i]))
                    array[i] = "";
            }
            Decoding.addFile(Base.location, array);
            Decoding.update();
            baseForm.refresh_dataGridView();
        }

        public static void changeFile(String[] array ){
            for (int i = 0; i < array.Length; i++)
            {
                Decoding.changeName(Base.location, oldName, Methods.replaceSpecial(array[i]), i, 1);
            }

            Decoding.update();
            baseForm.refresh_dataGridView();
        }

        public void enabled() {
            TextBox[] textBoxes = { nameField, websiteField, passwordField, emailField, nameField1, passwordField1, nameField2, passwordField2};

            for (int i = 0; i < textBoxes.Length; i++) {
                textBoxes[i].Enabled = enableEditing.Checked;
            }
            noteBox.ReadOnly = !enableEditing.Checked;
            passwordGenField.Enabled = enableEditing.Checked;
            passwordGenButton.Enabled = enableEditing.Checked;
            maskedTextBox4.Enabled = enableEditing.Checked;
            changeName1.Enabled = enableEditing.Checked;
            changeName2.Enabled = enableEditing.Checked;
        }

        private void enableEditing_CheckedChanged(object sender, EventArgs e)
        {
            enabled();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkDoneButton();
        }

        public void checkDoneButton() {
            if (type == 0)
            {
                if (!string.IsNullOrEmpty(Methods.replaceSpecial(nameField.Text.Trim())))
                {
                    bool ifEnabled = true;
                    for (int i = 0; i < baseForm.dataGridView1.RowCount; i++)
                    {
                        if (baseForm.dataGridView1.Rows[i].Cells[1].Value.ToString().Equals(Methods.replaceSpecial(nameField.Text)))
                        {
                            ifEnabled = false;
                        }
                    }

                    saveButton.Enabled = ifEnabled;
                }
                else
                {
                    saveButton.Enabled = false;
                }
            }
            else {
                if (!string.IsNullOrEmpty(Methods.replaceSpecial(nameField.Text.Trim())))
                {
                    if (arrayFields.SequenceEqual(getFields()))
                    {
                        saveButton.Enabled = false;
                    }
                    else
                    {
                        saveButton.Enabled = true;
                    }
                }
                else {
                    saveButton.Enabled = false;
                }
            }
        }

        public void initialize(String name) {
            int directoryIndex = Decoding.getDirectoryIndex(Base.location);
            int fileIndex = Decoding.getFileIndex(Base.location, name);

            for (int i = 0; i < arrayFields.Length; i++) {
                arrayFields[i] = Decoding.fileList[directoryIndex][fileIndex][i];
            }

            nameField.Text = arrayFields[0];
            websiteField.Text = arrayFields[1];
            passwordField.Text = arrayFields[2];
            emailField.Text = arrayFields[3];
            noteBox.Text = arrayFields[4];
            labelName.Text = arrayFields[5];
            nameField1.Text = arrayFields[6];
            passwordField1.Text = arrayFields[7];
            labelName1.Text = arrayFields[8];
            nameField2.Text = arrayFields[9];
            passwordField2.Text = arrayFields[10];
            enableEditing.Checked = arrayFields[11].Equals("True") ? true : false;

            oldName = name;
        }

        private String[] getFields() {
            String[] array = new String[12];

            setAllTextArray();

            for (int i = 0; i < array.Length; i++) {
                array[i] = allText[i];
            }

            return array;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void changeName1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddName addNameForm = new AddName();
            AddName.label = labelName;
            addNameForm.textBox1.Text = labelName.Text;
            addNameForm.ShowDialog();
        }

        private void changeName2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddName addNameForm = new AddName();
            AddName.label = labelName1;
            addNameForm.textBox1.Text = labelName1.Text;
            addNameForm.ShowDialog();
        }

        private void passwordLink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(string.IsNullOrEmpty(passwordField.Text) ? " " : passwordField.Text);
        }

        private void emailLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(string.IsNullOrEmpty(emailField.Text) ? " " : emailField.Text);
        }

        private void notesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(string.IsNullOrEmpty(noteBox.Text) ? " " : noteBox.Text);
        }

        private void passwordLink2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(string.IsNullOrEmpty(passwordField1.Text) ? " " : passwordField1.Text);
        }

        private void passwordLink3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(string.IsNullOrEmpty(passwordField2.Text) ? " " : passwordField2.Text);
        }

        private void passwordGeneratorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(string.IsNullOrEmpty(passwordGenField.Text) ? " " : passwordGenField.Text);
        }

        private void passwordGenButton_Click(object sender, EventArgs e)
        {
            if (maskedTextBox4.Text.Length > 0) {
                int length = Int32.Parse(maskedTextBox4.Text.Replace(" ", ""));

                String text = "";
                Random rand = new Random();
                for (int i = 0; i < length; i++) {
                    text += Masking.allChars[rand.Next(Masking.allChars.Length - 2)];
                }

                passwordGenField.Text = text;
            }
        }

        private void setAllTextArray() {
            allText = new string[]{nameField.Text, websiteField.Text, passwordField.Text, emailField.Text, noteBox.Text, labelName.Text, nameField1.Text
                , passwordField1.Text, labelName1.Text, nameField2.Text, passwordField2.Text, enableEditing.Checked.ToString()};
        }
    }
}
