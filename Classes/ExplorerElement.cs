using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ocManager.Classes
{
    public class ExplorerElement
    {
        string _Path;
        public ExplorerElement(string Path)
        {
            _Path = Path;
        }
        public ListViewItem getListViewItem()
        {
            string Name = System.IO.Path.GetFileName(_Path);
            string LastModified = File.GetLastWriteTime(_Path).ToString();
            string FileType = Path.GetExtension(_Path);
            string FileSize = "";
            if (isFile().Equals("File"))
                FileSize = GetFileSizeInBytes(new FileInfo(_Path).Length);





            ListViewItem lvi = new ListViewItem(Name);
            lvi.SubItems.Add(LastModified);
            lvi.SubItems.Add(FileType);
            lvi.SubItems.Add(FileSize);

            return lvi;


        }

        public string isFile()
        {
            FileAttributes attr = File.GetAttributes(_Path);
            if (attr.HasFlag(FileAttributes.Directory))
                return "Folder";
            else
                return "File";
        }

        public static string GetFileSizeInBytes(long TotalBytes)
        {
            if (TotalBytes >= 1073741824) //Giga Bytes
            {
                Decimal FileSize = Decimal.Divide(TotalBytes,1073741824);
                return String.Format("{0:##.##} GB", FileSize);
            }
            else if (TotalBytes >= 1048576) //Mega Bytes
            {
                Decimal FileSize = Decimal.Divide(TotalBytes,1048576);
                return String.Format("{0:##.##} MB", FileSize);
            }
            else if (TotalBytes >= 1024) //Kilo Bytes
            {
                Decimal FileSize = Decimal.Divide(TotalBytes,1024);
                return String.Format("{0:##.##} KB", FileSize);
            }
            else if (TotalBytes == 0)
            {
                Decimal FileSize = TotalBytes;
                return String.Format("{0:##.##} Bytes", FileSize);
            }
            else
            {
                return "0 Bytes";
            }
        }
    }
}
