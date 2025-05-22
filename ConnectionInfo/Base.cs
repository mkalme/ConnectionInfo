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
using System.IO;
using System.Text.RegularExpressions;

namespace ConnectionInfo
{
    public partial class Base : Form
    {
        private const string dialogText = "Text contains unicode characters, they will be deleted. Do you want to continue?";
        private const string deleteText = "Are you sure you want to delete this?\t\t\t\t\t";

        public static String basePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Connection Tools v4\Info Tools";
        public static String infoFile = basePath + @"\info";
        public static List<String> location = new List<String>(Decoding.baseFolder);

        public static List<int> selectedRows = new List<int>();

        public Base()
        {
            InitializeComponent();
        }

        private void Base_Load(object sender, EventArgs e)
        {
            //CREATE BASE
            Methods.create();

            //DECODING
            Decoding.decoding();

            //ADD LOCATION & BASE;
            location.Add("base");

            //SET ROWS
            selectedRows.Add(-1);

            //REFRESH DATAGRIDVIEW
            refresh_dataGridView();

            //START TIMER1
            timer1.Start();
        }

        public void refresh_dataGridView() {
            dataGridView1.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F2F2F2");
            timer2.Interval = 100;
            timer2.Start();

            dataGridView1.Rows.Clear();

            Decoding.getFilesDirectory(location);

            for (int i = 0; i < Decoding.files.Count; i++) {
                if (Decoding.files[i][0].Equals("0"))
                {
                    dataGridView1.Rows.Add(Properties.Resources.packageImage, Decoding.files[i][1], "", "", "", Decoding.files[i][2], Decoding.files[i][0]);
                }
                else if (Decoding.files[i][0].Equals("1")){
                    dataGridView1.Rows.Add(Properties.Resources.fileImage, Decoding.files[i][1], Decoding.files[i][2], String.IsNullOrEmpty(Decoding.files[i][3]) ? "" : Decoding.files[i][3].Length.ToString(), Decoding.files[i][4], Decoding.files[i][Decoding.files[i].Count - 1], Decoding.files[i][0]);
                }
                else {
                    dataGridView1.Rows.Add(Properties.Resources.documentImage, Decoding.files[i][1], "", "", "", Decoding.files[i][3], Decoding.files[i][0]);
                }
            }

            changePathLabel();
            if (selectedRows[location.Count - 2] > -1 && dataGridView1.RowCount > 0)
            {
                if (dataGridView1.RowCount <= selectedRows[location.Count - 2]) {
                    selectedRows[location.Count - 2] = dataGridView1.RowCount - 1;
                }
                    dataGridView1.Rows[selectedRows[location.Count - 2]].Selected = true;
            }
            else {
                dataGridView1.ClearSelection();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            Add.type = 0;
            Add.baseForm = this;
            add.ShowDialog();
        }

        private void addDirectoryButton_Click(object sender, EventArgs e)
        {
            if (Methods.ContainsSpecialCharacters(directoryNameField.Text))
            {
                if (Methods.dialog(dialogText, "Unicode Characters") == DialogResult.Yes)
                {
                    addDirectory();
                }
            }
            else {
                addDirectory();
            }
        }

        public void addDirectory() {
            String foldersName = Methods.replaceSpecial(directoryNameField.Text);
            String[] arrayPath = location.ToArray();

            Decoding.addFolder(foldersName, DateTime.Now.ToString("M.d.yyyy  HH:mm"), arrayPath);

            Decoding.update();

            directoryNameField.Text = "";
            addDirectoryButton.Enabled = false;

            refresh_dataGridView();
        }

        public String getCol(int col) {
            return dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[col].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (Methods.dialog(deleteText, "Delete") == DialogResult.Yes)
            {
                if (getCol(6).Equals("0"))
                {
                    List<String> tempList = new List<String>(location);
                    tempList.Add(getCol(1));
                    Decoding.remove(getCol(1), tempList, getCol(6));
                }
                else
                {
                    Decoding.remove(getCol(1), location, getCol(6));
                }

                Decoding.update();

                refresh_dataGridView();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkRemoveButton();
            checkAddDirectoryButton();
            checkBackButton();
            checkRenameLink();
            checkMoveLink();
        }

        public void checkRemoveButton()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                deleteButton.Enabled = true;
            }
            else
            {
                deleteButton.Enabled = false;
            }
        }

        public void checkRenameLink()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                renameLink.Enabled = true;
            }
            else
            {
                renameLink.Enabled = false;
            }
        }

        public void checkMoveLink()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                moveLink.Enabled = true;
            }
            else
            {
                moveLink.Enabled = false;
            }
        }

        public void checkAddDirectoryButton() {
            if (!string.IsNullOrEmpty(Methods.replaceSpecial(directoryNameField.Text)))
            {
                bool ifEnabled = true;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString().Equals(Methods.replaceSpecial(directoryNameField.Text)))
                    {
                        ifEnabled = false;
                    }
                }

                addDirectoryButton.Enabled = ifEnabled;
            }
            else {
                addDirectoryButton.Enabled = false;
            }
        }

        public void checkBackButton() {
            List<String> tempList = new List<String>(location);

            tempList.RemoveAt(0);
            tempList.RemoveAt(0);

            if (tempList.Count > 0)
            {
                backButton.Enabled = true;
            }
            else {
                backButton.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            timer2.Stop();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Decoding.decoding();

            refresh_dataGridView();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void windowsExplorerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(basePath);
        }

        private void clearClipboardLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.Clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) {
                if (getCol(6).Equals("0"))
                {
                    location.Add(getCol(1));
                    selectedRows.Add(-1);
                    refresh_dataGridView();
                }
                else if (getCol(6).Equals("1"))
                {
                    Add addForm = new Add();
                    Add.baseForm = this;
                    Add.type = 1;
                    addForm.initialize(getCol(1));
                    addForm.ShowDialog();
                }
                else {
                    openDocument(getCol(1));
                }
            }
        }

        public void openDocument(String name) {
            Document document = new Document();
            Document.baseForm = this;
            Document.name = name;
            document.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            location.RemoveAt(location.Count - 1);
            selectedRows.RemoveAt(selectedRows.Count - 1);
            refresh_dataGridView();
        }

        private void renameLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rename rename = new Rename();
            Rename.baseForm = this;
            rename.ShowDialog();
        }

        public void changePathLabel() {
            String text = "";

            for (int i = 2; i < location.Count; i++) {
                text += location[i] + (i == location.Count - 1 ? "" : " \\ ");
            }

            pathLabel.Text = text;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRows[location.Count - 2] = dataGridView1.RowCount > 0 ? dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0].Index: -1 : -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDocument addDocument = new AddDocument();
            AddDocument.baseForm = this;
            addDocument.ShowDialog();
        }

        private void statsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Stats stats = new Stats();
            stats.ShowDialog();
        }

        private void moveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MoveFiles move = new MoveFiles();
            MoveFiles.baseForm = this;
            move.ShowDialog();
        }
    }
}
