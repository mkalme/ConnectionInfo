using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;

namespace ConnectionInfo
{
    class Masking
    {
        public static String allChars = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~\n\t";
        public static String programChars = "{},[],<>";

        public static int length = 2;

        public static int maxNumberOfThreads = 20;
        public static int charPerThread = 50000;

        public static String maskTo(String text) {
            return activeString(text, 1, 0);
        }

        public static String maskAction(String text) {
            byte[] bytes = Encoding.Unicode.GetBytes(text);

            var result = BitConverter.ToString(bytes);

            return result.Replace("-", "").Replace("\n", "");

        }

        public static String demask(String text)
        {
            return activeString(text, length, 1);
        }

        public static String demaskAction(String text)
        {
            byte[] bytes = Methods.hexToByte(text);

            return Encoding.Unicode.GetString(bytes);
        }

        public static String activeString(String text, int amount, int type) {
            String result = "";

            int firstLoop = (int)Math.Ceiling(Double.Parse((text.Length / amount).ToString()) / Double.Parse((charPerThread * maxNumberOfThreads).ToString()));

            for (int i = 0; i < firstLoop; i++)
            {
                String textSubstring = text.Substring(0, (text.Length > (charPerThread * maxNumberOfThreads * amount) ? charPerThread * maxNumberOfThreads * amount : text.Length));
                int secondLoop = (int)Math.Ceiling(Double.Parse(textSubstring.Length.ToString()) / Double.Parse((charPerThread * amount).ToString()));

                List<Task> allTasks = new List<Task>();
                String[] stringArray = new String[secondLoop];
                for (int b = 0; b < secondLoop; b++)
                {
                    int copyB = b;
                    Task task = new Task(() =>
                    {
                        if (type == 0)
                        {
                            stringArray[copyB] = maskAction(textSubstring.Substring(copyB * charPerThread, (textSubstring.Length - (copyB * charPerThread)) < charPerThread ? (textSubstring.Length - (copyB * charPerThread)) : charPerThread));
                        }
                        else {
                            stringArray[copyB] = demaskAction(textSubstring.Substring(copyB * charPerThread * amount, (textSubstring.Length - (copyB * charPerThread * amount)) < charPerThread * amount ? (textSubstring.Length - (copyB * charPerThread * amount)) : charPerThread * amount));
                        }
                    });
                    allTasks.Add(task);
                    task.Start();
                }

                Task.WaitAll(allTasks.ToArray());

                //END
                result += String.Join("", stringArray);

                int endSubstring = charPerThread * maxNumberOfThreads * amount;
                text = text.Substring(endSubstring > text.Length ? text.Length : endSubstring);
            }

            return result;
        }
    }
}
