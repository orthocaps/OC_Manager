using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocManager
{
    public static class ContentManager
    {
        public static string JobsFolderPath = @"X:\Jobs";
        public static string FilesFromOrthocapsFolderPath = @"X:\Files From Orthocaps";
        public static string FilesFromSimothPackage1Path = @"X:\Files From Simorth\Package1";
        public static string FilesFromSimothPackage2Path = @"X:\ftp\Files From Simorth\Package2";
        public static string DefaultCaseFolderPath = @"X:\ftp\Jobs\_Muster";

        public static string ScanMoverToolPath = @"X:\ftp\Jobs\__tempScans\_Tool\ocScanMover.exe";
        public static string STLMoverToolPath = @"X:\ftp\Jobs\__tempSTLs\_Tool\ocSTLMover.exe";

        public static string actualBaseFolder = "";

        public static string actualCaseID = "";
        public static string actualName = "";
        public static string actualPath = "";

        public static string LogFilePath = Directory.GetCurrentDirectory() + @"\Data\Logfile.txt";
        

        //Text Presets Paths:
        public static string Path_TextPresetsBasic = Directory.GetCurrentDirectory() + @"\Data\Texts";
        //Reports:
        public static string Path_reportEN = Path_TextPresetsBasic + @"\Reports\ReportDE.txt";
        public static string Path_reportDE = Path_TextPresetsBasic + @"\Reports\ReportEN.txt";
        public static string Path_reportFR = Path_TextPresetsBasic + @"\Reports\ReportFR.txt";

        // No Submission Paths:
        public static string Path_NoSubmissonDE = Path_TextPresetsBasic + @"\NoSubmission\NoSub_DE.txt";
        public static string Path_NoSubmissonEN = Path_TextPresetsBasic + @"\NoSubmission\NoSub_EN.txt";
        public static string Path_NoSubmissonFR = Path_TextPresetsBasic + @"\NoSubmission\NoSub_FR.txt";

        // Import Picture:
        public static string Path_OCLogo = Directory.GetCurrentDirectory() + @"\Data\Res\Orthocaps_logo.png";


        public static string[,] AllCases;

        //public static List<Item> ActualListViewItems = new List<Item>();
        public static bool FSW_EventDoneOnce = false;



        #region Functions:

        public static void LoadAllCases()
        {
            try
            {
                List<string> Folders = Directory.GetDirectories(JobsFolderPath).ToList();
                AllCases = new string[Folders.Count, 3];
                for (int i = 0; i < Folders.Count; i++)
                {
                    string FolderName = System.IO.Path.GetFileName(Folders[i]);
                    string OnlyNumbers = extractNumbersFromString(FolderName);
                    string CaseID = string.Empty;
                    if (OnlyNumbers.Length > 5)
                    {
                        CaseID = OnlyNumbers.Substring(4, OnlyNumbers.Length - 4);
                    }
                    else
                    {
                        CaseID = OnlyNumbers;
                    }
                    AllCases[i, 0] = CaseID;
                    AllCases[i, 1] = Folders[i];
                    AllCases[i, 2] = Path.GetFileName(Folders[i]);
                }
            }
            catch(Exception ex)
            {
                LogManager.addToLog("Loading: " + ex.Message);
            }

        }
        public static string extractNumbersFromString(string text)
        {
            string Number = string.Empty;

            foreach (char NumChar in text.ToCharArray())
            {
                if (Char.IsNumber(NumChar))
                {
                    Number += NumChar.ToString();
                }
            }
            return Number;
        }

        public static string getPathFromName(string Name)
        {
            string path = "";
            for (int i = 0; i < AllCases.GetLength(0); i++)
            {
                if(Name.Equals(AllCases[i,2]))
                {
                    path = AllCases[i, 1];
                }
            }
            return path;
        }

        public static string getCaseIDFromName(string Name)
        {
            string path = "";
            for (int i = 0; i < AllCases.GetLength(0); i++)
            {
                if (Name.Equals(AllCases[i, 2]))
                {
                    path = AllCases[i, 0];
                }
            }
            return path;
        }

        public static bool isFile(string _Path)
        {
            FileAttributes attr = File.GetAttributes(_Path);
            if (attr.HasFlag(FileAttributes.Directory))
                return false;
            else
                return true;
        }
        #endregion
    }
}
