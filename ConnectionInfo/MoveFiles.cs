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
    public partial class MoveFiles : Form
    {
        public static Base baseForm;

        public static List<String> location;

        public static List<int> selectedRows = new List<int>();

        public static String childFolder = "";

        public MoveFiles()
        {
            InitializeComponent();
        }

        private void MoveFiles_Load(object sender, EventArgs e)
        {
            //SET LOCATION
            location = new List<String>(Base.location);

            //SET SELECTED ROWS
            setSelectedRows();

            childFolder = "";

            //SETTINGS
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            //SET ROWS
            selectedRows.Add(-1);

            //REFRESH DATAGRIDVIEW
            refresh_dataGridView();

            timer1.Start();
        }

        public void refresh_dataGridView() {
            dataGridView1.Rows.Clear();

            Decoding.getDirectories(location);

            for (int i = 0; i < Decoding.folders.Count; i++)
            {
                if (Decoding.comparePath(location, Base.location))
                {
                    if (!baseForm.getCol(1).Equals(Decoding.folders[i][0]) || !baseForm.getCol(6).Equals("0")) {
                        dataGridView1.Rows.Add(Properties.Resources.packageImage, Decoding.folders[i][0]);
                    }
                }
                else {
                    dataGridView1.Rows.Add(Properties.Resources.packageImage, Decoding.folders[i][0]);

                    if (Decoding.folders[i][0].Equals(childFolder) && selectedRows[location.Count - 2] < 0)
                    {
                        selectedRows[location.Count - 2] = i;
                    }
                }
            }

            if (selectedRows[location.Count - 2] > -1 && dataGridView1.RowCount > 0)
            {
                if (dataGridView1.RowCount <= selectedRows[location.Count - 2])
                {
                    selectedRows[location.Count - 2] = dataGridView1.RowCount - 1;
                }
                dataGridView1.Rows[selectedRows[location.Count - 2]].Selected = true;
            }
            else
            {
                dataGridView1.ClearSelection();
            }
        }

        public void setSelectedRows() {
            selectedRows.Clear();

            for (int i = 0; i < location.Count - 1; i++) {
                selectedRows.Add(-1);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            location.Add(getCol(1));
            selectedRows.Add(-1);
            refresh_dataGridView();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRows[location.Count - 2] = dataGridView1.RowCount > 0 ? dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0].Index : -1 : -1;
        }

        public String getCol(int col)
        {
            return dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[col].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkBackButton();
        }

        public void checkBackButton() {
            List<String> tempList = new List<String>(location);

            tempList.RemoveAt(0);
            tempList.RemoveAt(0);

            if (tempList.Count > 0)
            {
                backButton.Enabled = true;
            }
            else
            {
                backButton.Enabled = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            childFolder = location[location.Count - 1];
            location.RemoveAt(location.Count - 1);
            selectedRows.RemoveAt(selectedRows.Count - 1);
            refresh_dataGridView();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (!Decoding.comparePath(Base.location, location)) {
                Decoding.moveToDirectory(Base.location, location, baseForm.getCol(1), Int32.Parse(baseForm.getCol(6)));
                Decoding.update();
                baseForm.refresh_dataGridView();
            }

            Close();
        }
    }
}
