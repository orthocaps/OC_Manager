using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocManager
{
    public static class LogManager
    {
        public static List<string> LogFile = new List<string>();
        public static void addToLog(string text)
        {
            LogFile.Add(DateTime.Now + " >> " + text);
        }

        public static void WriteLogFile()
        {
            File.WriteAllLines(ContentManager.LogFilePath, LogFile);
        }

        public static void loadLogFromFile()
        {
            LogFile = File.ReadAllLines(ContentManager.LogFilePath, Encoding.Default).ToList();
        }
    }
}
