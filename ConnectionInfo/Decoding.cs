using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace ConnectionInfo
{
    class Decoding
    {
        private const string errorText = "There was an error.\t\t\t\t\t";

        public static List<List<String>> folderList = new List<List<String>>();
        public static List<List<List<String>>> fileList = new List<List<List<String>>>();
        public static List<List<List<String>>> documentList = new List<List<List<String>>>();

        public static List<List<String>> files = new List<List<String>>();
        public static List<List<String>> folders = new List<List<String>>();

        //{} FOLDER
        //[] FILE
        //< FILE DIRECTORY
        //> LEFT OVER
        // (space) SEPERATOR BETWEEN ENTRIES
        //newLine IGNORED

        public static List<String> baseFolder = new List<String>() { "/base*folder//*" };
        public static String baseF = Masking.maskTo("base") + " " + Masking.maskTo(DateTime.Now.ToString("M.d.yyyy  HH:mm")) + " " + Masking.maskTo(baseFolder[0]);

        public static int newLineEvery = 95;

        public static void decoding() {
            resetLists();

            String text = Encryption.Decrypt(Methods.readFile(Base.infoFile));

            text = text.Replace("\n", "").Replace("\t", "");

            changeFromCode(text);
        }

        public static void resetLists() {
            folderList.Clear();
            fileList.Clear();
            documentList.Clear();
        }

        public static void changeFromCode(String text) {
            try
            {
                getFolders(text);

                getFilesDocuments(text);
            }
            catch{
                Methods.errorMessage(errorText, "Error");
            }
        }

        public static void getFolders(String text) {
            String[] arrayOfFolders = text.Split(new[] { '}' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arrayOfFolders.Length; i++) {
                arrayOfFolders[i] += "}";
                arrayOfFolders[i] = arrayOfFolders[i].Replace("{" + Regex.Match(arrayOfFolders[i], @"\{([^}]*)\}").Groups[1].Value + "}", "");
                String[] tempArray = arrayOfFolders[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                folderList.Add(new List<String> { Masking.demask(tempArray[0]), Masking.demask(tempArray[1]) });
                String[] tempPath = tempArray[2].Split(new[] { '<' }, StringSplitOptions.RemoveEmptyEntries);
                for (int b = 0; b < tempPath.Length; b++) {
                    folderList[i].Add(Masking.demask(tempPath[b]));
                }
                fileList.Add(new List<List<String>> { });
                documentList.Add(new List<List<String>> { });
            }
        }

        public static void getFilesDocuments(String text) {
            String[] arrayOfFolders = text.Split(new[] { '}' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arrayOfFolders.Length; i++)
            {
                arrayOfFolders[i] += "}";
                arrayOfFolders[i] = arrayOfFolders[i].Replace(arrayOfFolders[i].Replace("{" + Regex.Match(arrayOfFolders[i], @"\{([^}]*)\}").Groups[1].Value + "}", ""), "").Replace("{", "").Replace("}", "");
                getFileInformation(arrayOfFolders[i], i);
            }
        }

        public static void getFileInformation(String text, int folderNumber) {
            String[] arrayOfFilesDocuments = text.Split(new[] { ']' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arrayOfFilesDocuments.Length; i++) {
                arrayOfFilesDocuments[i] += "]";
                int type = fileType(arrayOfFilesDocuments[i]);

                arrayOfFilesDocuments[i] = Regex.Match(arrayOfFilesDocuments[i], @"\[([^]]*)\]").Groups[1].Value;
                String[] tempArray = arrayOfFilesDocuments[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                addFileDocuments(tempArray, type, folderNumber);
            }
        }

        public static void addFileDocuments(String[] tempArray, int type, int folderNumber) {

            if (type == 1)
            {
                fileList[folderNumber].Add(new List<String> { });
            }
            else if (type == 2)
            {
                documentList[folderNumber].Add(new List<String> { });
            }

            int lastFile = fileList[folderNumber].Count - 1;
            int lastDocument = documentList[folderNumber].Count - 1;

            for (int b = 0; b < tempArray.Length; b++)
            {
                if (tempArray[b].Equals(">"))
                {
                    if (type == 1)
                    {
                        fileList[folderNumber][lastFile].Add("");
                    }
                    else
                    {
                        documentList[folderNumber][lastDocument].Add("");
                    }
                }
                else
                {
                    if (type == 1)
                    {
                        fileList[folderNumber][lastFile].Add(Masking.demask(tempArray[b]));
                    }
                    else
                    {
                        documentList[folderNumber][lastDocument].Add(Masking.demask(tempArray[b]));
                    }
                }
            }
        }

        public static int fileType(String text) {
            text = text.Replace("[" + Regex.Match(text, @"\[([^]]*)\]").Groups[1].Value + "]", "");
            return Int32.Parse(Masking.demask(text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1]));
        }

        public static void getFilesDirectory(List<String> directoryList) {
            files.Clear();

            List<String> pathList = new List<String>();

            if (comparePath(directoryList, baseFolder))
                directoryList.Add("base");

            int directoryIndex = getDirectoryIndex(directoryList);

            addFoldersList(pathList, directoryList, 0);
            addFilesList(directoryIndex);
            addDocumentsList(directoryIndex);
        }

        public static void addFoldersList(List<String> pathList, List<String> directoryList, int type) {
            for (int i = 0; i < folderList.Count; i++)
            {
                pathList.Clear();
                for (int b = 2; b < folderList[i].Count; b++)
                {
                    pathList.Add(folderList[i][b]);
                }

                if (comparePath(pathList, directoryList))
                {
                    if (type == 0)
                    {
                        files.Add(new List<String> { "0", folderList[i][0], folderList[i][1] });
                        int lastItem = files.Count - 1;
                        for (int b = 0; b < pathList.Count; b++)
                        {
                            files[lastItem].Add(pathList[b]);
                        }
                    }
                    else if(type == 1){
                        folders.Add(new List<String> {folderList[i][0]});
                        int lastItem = folders.Count - 1;
                        for (int b = 0; b < pathList.Count; b++)
                        {
                            folders[lastItem].Add(pathList[b]);
                        }
                    }
                }
            }
        }

        public static void addFilesList(int directoryIndex){
            for (int i = 0; i < fileList[directoryIndex].Count; i++)
            {
                files.Add(new List<String> { "1" });
                for (int b = 0; b < fileList[directoryIndex][i].Count; b++)
                {
                    files[files.Count - 1].Add(fileList[directoryIndex][i][b]);
                }
            }
        }

        public static void addDocumentsList(int directoryIndex){
            for (int i = 0; i < documentList[directoryIndex].Count; i++)
            {
                files.Add(new List<String> { "2" });
                for (int b = 0; b < documentList[directoryIndex][i].Count; b++)
                {
                    files[files.Count - 1].Add(documentList[directoryIndex][i][b]);
                }
            }
        }

        public static String changeToCode() {
            String text = "";

            for (int i = 0; i < folderList.Count; i++) {
                String folderText = "";

                folderText += Masking.maskTo(folderList[i][0]) + " " + Masking.maskTo(folderList[i][1]);       

                String path = "";
                for (int b = 2; b < folderList[i].Count; b++) {
                    path += Masking.maskTo(folderList[i][b]) + (b == folderList[i].Count - 1 ? "" : "<");
                }
                folderText += " " + path;
                text += folderText + "{\n";

                text += filesCode(i, fileList, 1);
                text += filesCode(i, documentList, 2);

                text += "\n}" + (i == fileList.Count - 1 ? "" : "\n\n");
            }

            return Regex.Replace(text, ".{" + newLineEvery + "}", "$0\n");
        }

        public static String filesCode(int index, List<List<List<String>>> list, int type) {
            String text = "";

            for (int b = 0; b < list[index].Count; b++)
            {
                text += "\t";
                text += Masking.maskTo(b.ToString()) + " " + Masking.maskTo(type.ToString()) +"[\n";

            for (int c = 0; c < list[index][b].Count; c++)
                {
                    if (list[index][b][c].Length <= 0)
                    {
                        text += "\t\t" + ">";
                    }
                    else
                    {
                        text += Masking.maskTo(list[index][b][c]);
                    }
                    text += (c == list[index][b].Count - 1 ? "" : " \n");
                }

                text += "\n\t]" + (b == list[index].Count - 1 ? "" : "\n\n");
            }

            if (type == 1 && list[index].Count > 0) {
                text += documentList[index].Count == 0 ? "" : "\n\n";
            }

            return text;
        }

        public static void update() {
            getFilesDirectory(Base.location);

            String allText = Methods.insertNewLine(Encryption.Encrypt(changeToCode()));

            Methods.writeFile(Base.infoFile, allText);

            createBackup(allText);
        }

        public static void addFolder(String name, String date, String[] pathArray) {
            folderList.Add(new List<String> { name, date });
            fileList.Add(new List<List<String>> { });
            documentList.Add(new List<List<String>> { });

            int lastItem = folderList.Count - 1;

            for (int i = 0; i < pathArray.Length; i++)
            {
                folderList[lastItem].Add(pathArray[i]);
            }
        }

        public static void addFile(List<String> directoryList, String[] infoArray) {
            //GET FOLDER
            int directoryIndex = getDirectoryIndex(directoryList);

            fileList[directoryIndex].Add(new List<String> { });
            int lastItem = fileList[directoryIndex].Count - 1;
            for (int i = 0; i < infoArray.Length; i++) {
                fileList[directoryIndex][lastItem].Add(infoArray[i]);
            }
        }

        public static void addDocument(List<String> directoryList, String[] infoArray)
        {
            //GET FOLDER
            int directoryIndex = getDirectoryIndex(directoryList);

            documentList[directoryIndex].Add(new List<String> { });
            int lastItem = documentList[directoryIndex].Count - 1;
            for (int i = 0; i < infoArray.Length; i++)
            {
                documentList[directoryIndex][lastItem].Add(infoArray[i]);
            }
        }

        public static void remove(String name, List<String> pathList, String type) {
            if (type.Equals("0"))
            {
                deleteFolder(pathList);
            }
            else if (type.Equals("1")){
                deleteFile(pathList, name);
            }
            else {
                deleteDocument(pathList, name);
            }
        }
        static int te = 0;
        public static void deleteFolder(List<String> pathList) {
            List<String> tempList = new List<String>();
            te++;
            if (!comparePath(pathList, baseFolder))
            {
                int directoryIndex = getDirectoryIndex(pathList);
                folderList.RemoveAt(directoryIndex);
                fileList.RemoveAt(directoryIndex);
                documentList.RemoveAt(directoryIndex);
            }
            else {
                fileList[getDirectoryIndex(pathList)].Clear();
                documentList[getDirectoryIndex(pathList)].Clear();
            }
            
            for (int i = 0; i < folderList.Count; i++)
            {
                tempList.Clear();
                for (int b = 2; b < folderList[i].Count; b++)
                {
                    tempList.Add(folderList[i][b]);
                }

                if (comparePath(tempList, pathList))
                {
                    tempList.Add(folderList[i][0]);
                    i--;
                    deleteFolder(tempList);
                }
            }
        }

        public static void deleteFile(List<String> pathList, String name) {

            fileList[getDirectoryIndex(pathList)].RemoveAt(getFileIndex(pathList, name));
        }

        public static void deleteDocument(List<String> pathList, String name)
        {

            documentList[getDirectoryIndex(pathList)].RemoveAt(getDocumentIndex(pathList, name));
        }

        public static int getDirectoryIndex(List<String> directoryList) {
            List<String> pathList = new List<String>();

            int directoryIndex = 0;

            for (int i = 0; i < folderList.Count; i++)
            {
                pathList.Clear();
                for (int b = 2; b < folderList[i].Count; b++)
                {
                    pathList.Add(folderList[i][b]);
                }
                pathList.Add(folderList[i][0]);

                if (comparePath(pathList, directoryList))
                {
                    directoryIndex = i;
                    goto after_loop;
                }
            }
        after_loop:

            return directoryIndex;
        }

        public static int getFileIndex(List<String> pathList, String name)
        {
            int fileIndex = 0;
            for (int i = 0; i < fileList[getDirectoryIndex(pathList)].Count; i++)
            {
                if (name.Equals(fileList[getDirectoryIndex(pathList)][i][0]))
                {
                    fileIndex = i;
                    goto after_loop;
                }
            }
        after_loop:

            return fileIndex;
        }

        public static int getDocumentIndex(List<String> pathList, String name)
        {
            int fileIndex = 0;
            for (int i = 0; i < documentList[getDirectoryIndex(pathList)].Count; i++)
            {
                if (name.Equals(documentList[getDirectoryIndex(pathList)][i][0]))
                {
                    fileIndex = i;
                    goto after_loop;
                }
            }
        after_loop:

            return fileIndex;
        }

        public static bool comparePath(List<String> path1, List<String> path2)
        {
            bool ifSame = true;

            if (path1.Count == path2.Count)
            {
                for (int i = 0; i < path1.Count; i++)
                {
                    if (!path1[i].Equals(path2[i]))
                    {
                        ifSame = false;
                        goto after_loop;
                    }
                }
            }
            else {
                ifSame = false;
            }
        after_loop:

            return ifSame;
        }

        public static void changeName(List<String> listPath, String name, String newName, int type, int folderOrFile) {
            if (folderOrFile == 0)
            {
                List<String> tempList = new List<String>(listPath);
                tempList.Add(name);
                changeFolderName(tempList, newName, type, tempList.Count - 1);
            }
            else if (folderOrFile == 1)
            {
                changeFileName(listPath, name, newName, type);
            }
            else {
                changeDocumentName(listPath, name, newName, type);
            }
        }

        public static void changeFolderName(List<String> listPath, String newName, int type, int index) {
            folderList[getDirectoryIndex(listPath)][0] = newName;

            for (int i = 0; i < folderList.Count; i++) {
                if (folderList[i].Count - 2 >= index + 1) {
                    if (folderList[i][index + 2].Equals(listPath[index])) {
                        folderList[i][index + 2] = newName;
                    }
                }
            }
        }

        public static void changeFileName(List<String> listPath, String name, String newName, int type) {
            fileList[getDirectoryIndex(listPath)][getFileIndex(listPath, name)][type] = newName;
        }

        public static void changeDocumentName(List<String> listPath, String name, String newName, int type)
        {
            documentList[getDirectoryIndex(listPath)][getDocumentIndex(listPath, name)][type] = newName;
        }

        public static void createBackup(String allText) {
            Methods.writeFile(Base.basePath + @"\back", allText);
        }

        public static int getAmountOfFolders() {
            return folderList.Count;
        }

        public static int getAmountOfFiles()
        {
            int amount = 0;

            for (int i = 0; i < fileList.Count; i++) {
                amount += fileList[i].Count;
            }

            return amount;
        }

        public static int getAmountOfDocuments()
        {
            int amount = 0;

            for (int i = 0; i < documentList.Count; i++)
            {
                amount += documentList[i].Count;
            }

            return amount;
        }

        public static void getDirectories(List<String> directoryList) {
            folders.Clear();

            List<String> pathList = new List<String>();

            if (comparePath(directoryList, baseFolder))
                directoryList.Add("base");

            int directoryIndex = getDirectoryIndex(directoryList);

            addFoldersList(pathList, directoryList, 1);
        }

        public static void moveToDirectory(List<String> listPathFrom, List<String> listPathTo, String name, int type) {
            if (type == 0) {
                moveDirectory(listPathFrom, listPathTo, name, ifNameExists(listPathTo, name));
            } else if (type == 1) {
                moveFile(listPathFrom, listPathTo, name, ifNameExists(listPathTo, name));
            }
            else {
                moveDocument(listPathFrom, listPathTo, name, ifNameExists(listPathTo, name));
            }
        }

        public static void moveDirectory(List<String> listPath, List<String> listPathTo, String name, String newName)
        {
            List<String> tempListFrom = new List<String>(listPath);
            tempListFrom.Add(name);

            List<String> tempListTo = new List<String>(listPathTo);
            tempListTo.Add(newName);

            int directoryIndex = getDirectoryIndex(tempListFrom);

            folderList[directoryIndex][0] = newName;
            folderList[directoryIndex].RemoveRange(2, folderList[directoryIndex].Count - 2);
            for (int i = 0; i < listPathTo.Count; i++) {
                folderList[directoryIndex].Add(listPathTo[i]);
            }

            //MOVE ALL DIRECTORIES
            for (int i = 0; i < folderList.Count; i++) {
                List<String> tempList = new List<String>();
                for (int b = 2; b < folderList[i].Count; b++) {
                    tempList.Add(folderList[i][b]);
                }

                if (comparePath(tempListFrom, tempList)) {
                    moveDirectory(tempList, tempListTo, folderList[i][0], folderList[i][0]);
                }
            }
        }

        public static void moveFile(List<String> listPathFrom, List<String> listPathTo, String name, String newName)
        {
            int directoryIndexFrom = getDirectoryIndex(listPathFrom);
            int fileIndexFrom = getFileIndex(listPathFrom, name);

            int directoryIndexTo = getDirectoryIndex(listPathTo);

            List<String> tempList = new List<String>(fileList[directoryIndexFrom][fileIndexFrom]);
            tempList[0] = newName;

            addFile(listPathTo, tempList.ToArray());
            remove(name, listPathFrom, "1");
        }

        public static void moveDocument(List<String> listPathFrom, List<String> listPathTo, String name, String newName)
        {
            int directoryIndexFrom = getDirectoryIndex(listPathFrom);
            int documentIndexFrom = getDocumentIndex(listPathFrom, name);

            int directoryIndexTo = getDirectoryIndex(listPathTo);

            List<String> tempList = new List<String>(documentList[directoryIndexFrom][documentIndexFrom]);
            tempList[0] = newName;

            addDocument(listPathTo, tempList.ToArray());
            remove(name, listPathFrom, "2");
        }

        public static String ifNameExists(List<String> location, String name) {
            String newName = name;

            int directoryIndex = getDirectoryIndex(location);

            //CHECK FILES
            for (int i = 0; i < fileList[directoryIndex].Count; i++) {
                if (fileList[directoryIndex][i][0].Equals(newName)) {
                    newName += "-";
                    newName = ifNameExists(location, newName);
                    goto after_loop;
                }
            }

            //CHECK DOCUMENTS
            for (int i = 0; i < documentList[directoryIndex].Count; i++)
            {
                if (documentList[directoryIndex][i][0].Equals(newName))
                {
                    newName += "-";
                    newName = ifNameExists(location, newName);
                    goto after_loop;
                }
            }

            //CHECK DIRECTORY
            for (int i = 0; i < folderList.Count; i++) {
                List<String> tempList = new List<String>();
                for (int b = 2; b < folderList[i].Count; b++)
                {
                    tempList.Add(folderList[i][b]);
                }

                if (comparePath(location, tempList) && folderList[i][0].Equals(newName))
                {
                    newName += "-";
                    newName = ifNameExists(location, newName);
                    goto after_loop;
                }
            }


            after_loop:
            return newName;
        }
    }
}
