using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ConnectionInfo
{
    class Methods
    {
        private const string errorText = "There was an error.\t\t\t\t\t";
        private const string encoding = "Unicode";

        public const int newLineEvery = 65;

        public static void create() {
            //CREATE DIRECTORY
            Directory.CreateDirectory(Base.basePath);

            //CREATE INFO FILE
            Methods.createFile(Base.infoFile, insertNewLine(Encryption.Encrypt(Decoding.baseF + "{\n\n}")));
        }

        public static String byteToHex(byte[] byteArray) {
            String text = "";           
            try {
                text = BitConverter.ToString(byteArray).Replace("-", " ");
            }
            catch{
                errorMessage(errorText, "Error");
            }
            return text;
        }

        public static byte[] hexToByte(String text)
        {
            text = text.Replace(" ", "").Replace("-", "").Replace("\n", "");
            byte[] byteArray = null;
            try {
                byteArray = Enumerable.Range(0, text.Length / 2).Select(x => Convert.ToByte(text.Substring(x * 2, 2), 16)).ToArray();
            }
            catch{
                errorMessage(errorText, "Error");
            }

            return byteArray;
        }

        public static byte[] byteSubstring(byte[] byteArray, int index, int endIndex) {
            int length = endIndex - index;
            byte[] array = new byte[length];

            try
            {
                for (int i = 0; i < length; i++)
                {
                    array[i] = byteArray[index + i];
                }
            }
            catch{
                errorMessage(errorText, "Error");
            }

            return array;
        }

        public static byte[] byteSubstringAll(byte[] byteArray, int index)
        {
            int length = byteArray.Length - index;
            byte[] array = new byte[length];

            try
            {
                for (int i = 0; i < length; i++)
                {
                    array[i] = byteArray[index + i];
                }
            }
            catch{
                errorMessage(errorText, "Error");
            }

            return array;
        }

        public static String insertNewLine(String text) {
            return Regex.Replace(text, ".{" + (newLineEvery * 3) + "}", "$0\n");
        }

        public static bool ContainsSpecialCharacters(string input)
        {
            return false;
        }

        public static String replaceSpecial(String text) {
            return text;
        }

        public static DialogResult dialog(String text, String title) {
            DialogResult dialogResult = MessageBox.Show(text, title, MessageBoxButtons.YesNo);
            return dialogResult;
        }

        public static void errorMessage(String text, String title) {
            MessageBox.Show(text, title,
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(1);
        }

        public static void createFile(String path, String text)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine(text);
                }
            }
        }

        public static void writeFile(String path, String text)
        {
            using (TextWriter tw = new StreamWriter(path))
            {
                tw.WriteLine(text);
            }
        }

        public static String readFile(String filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
