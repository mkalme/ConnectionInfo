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
using System.Text.RegularExpressions;

namespace ConnectionInfo
{
    public partial class Document : Form
    {
        private const string dialogText = "Text contains unicode characters, they will be deleted. Do you want to continue?";

        public static Base baseForm;
        public static String name;
        public static String text = "";

        public static String font = "";

        public Document()
        {
            InitializeComponent();
        }

        private void Document_Load(object sender, EventArgs e)
        {
            loadBox();
        }

        public void loadBox() {
            richTextBox1.Text = getText();
            text = richTextBox1.Text;
            richTextBox1.Font = getFont();
            font = new FontConverter().ConvertToString(richTextBox1.Font);
        }

        public String getText() {
            return Decoding.documentList[Decoding.getDirectoryIndex(Base.location)][Decoding.getDocumentIndex(Base.location, name)][1];
        }

        public Font getFont()
        {
            String fontString = Decoding.documentList[Decoding.getDirectoryIndex(Base.location)][Decoding.getDocumentIndex(Base.location, name)][3];
            Font font = new FontConverter().ConvertFromString(fontString) as Font;

            return font;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (!text.Equals(richTextBox1.Text) || !font.Equals(new FontConverter().ConvertToString(richTextBox1.Font)))
            {
                if (Methods.ContainsSpecialCharacters(richTextBox1.Text))
                {
                    if (Methods.dialog(dialogText, "Unicode Characters") == DialogResult.Yes)
                    {
                        changeDocument(0);
                    }
                }
                else {
                    changeDocument(1);
                }
            }
            else {
                Close();
            }
        }

        public void changeDocument(int type) {
            Decoding.documentList[Decoding.getDirectoryIndex(Base.location)][Decoding.getDocumentIndex(Base.location, name)][1] = Methods.replaceSpecial(richTextBox1.Text);

            var cvt = new FontConverter();
            String font = cvt.ConvertToString(richTextBox1.Font);

            Decoding.documentList[Decoding.getDirectoryIndex(Base.location)][Decoding.getDocumentIndex(Base.location, name)][3] = Methods.replaceSpecial(font);

            Decoding.update();

            Close();
        }

        private void changeFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }
    }
}
