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
    public partial class Stats : Form
    {
        public static String[,] dataArray;

        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            //INITIALIZE DATA ARRAY
            initializeDataArray();

            refresh_DataGridView();
        }

        public void refresh_DataGridView() {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < dataArray.GetLength(0); i++) {
                dataGridView1.Rows.Add(dataArray[i, 0], dataArray[i, 1]);
            }
        }

        public static void initializeDataArray() {
            dataArray = new string[,]{{ "Number of directores", (Decoding.getAmountOfFolders() - 1).ToString() }, 
                                        { "Number of files", Decoding.getAmountOfFiles().ToString() }, 
                                        { "Number of documents", Decoding.getAmountOfDocuments().ToString() }
            };
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
