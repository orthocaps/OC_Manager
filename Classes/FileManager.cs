using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocManager
{
    public static class FileManager
    {
        public static List<string> getDirectoriesAndFiles(string p_Path)
        {
            List<string> AllItems = new List<string>();

            foreach (var item in Directory.GetDirectories(p_Path))
            {
                AllItems.Add(item);
            }

            foreach (var item in Directory.GetFiles(p_Path))
            {
                AllItems.Add(item);
            }
            return AllItems;
        }

        public static void CopyFolder(string sourceFolder, string targetFolder)
        {
            List<string> Files = Directory.GetFiles(sourceFolder).ToList();

            //Check if destination Folder already exists
            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
                Console.WriteLine("Ordner erstellt: " + targetFolder);
            }
            foreach (var item in Files)
            {
                File.Copy(item, targetFolder + @"\" + Path.GetFileName(item));
                Console.WriteLine("Copy: " + item + " --> " + targetFolder + @"\" + Path.GetFileName(item));
            }

            foreach (var item in Directory.GetDirectories(sourceFolder))
            {
                Directory.CreateDirectory(targetFolder + @"\" + Path.GetFileName(item));
                Console.WriteLine("Ordner erstellt: " + targetFolder + @"\" + Path.GetFileName(item));
            }
        }

        public static void MoveFolder(string sourceFolder, string targetFolder)
        {
            List<string> Files = Directory.GetFiles(sourceFolder).ToList();
            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
                Console.WriteLine("Ordner wurde erstellt: " + targetFolder);
            }
            foreach (var item in Files)
            {
                File.Copy(item, targetFolder + @"\" + Path.GetFileName(item));
                Console.WriteLine("Copy: " + item, targetFolder + @"\" + Path.GetFileName(item));
            }

            //Delete
            foreach (var item in Directory.GetFiles(sourceFolder))
            {
                File.Delete(item);
            }
            Directory.Delete(sourceFolder);
            Console.WriteLine("Gelöscht: " + sourceFolder);
        }
    }
}
