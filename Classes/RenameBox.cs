using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ocManager.Classes
{
    public class RenameBox
    {
        TextBox renameBox;
        ListBox listbox;
        Rectangle rectangle;
        string oldFolderName;
        public RenameBox(Rectangle p_Rectangle, ListBox p_listbox)
        {
            rectangle = p_Rectangle;
            renameBox = new TextBox();
            renameBox.Focus();
            renameBox.Size = new Size(rectangle.Width, rectangle.Height);
            renameBox.Location = new Point(rectangle.X, rectangle.Y);

            listbox = p_listbox;
            renameBox.Text = listbox.SelectedItem.ToString();
            oldFolderName = listbox.SelectedItem.ToString();
            renameBox.SelectionStart = 0;
            renameBox.Select();
            renameBox.Hide();
            listbox.Controls.Add(renameBox);

            renameBox.KeyDown += new KeyEventHandler(renameBoxKeyDown);
            listbox.MouseDown += new MouseEventHandler(renameBoxMouseDown);
            renameBox.GotFocus += new EventHandler(BoxFocused);

        }
        private void renameBoxKeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    renameBox.Hide();
                }
                if (e.KeyCode == Keys.Enter)
                {
                    renameBox.Hide();
                    string newCaseFolderName = renameBox.Text;
                    Process process = new Process();
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/C rename " + "\"" + @"\\192.168.8.240\ftp\Jobs\" + oldFolderName + "\" \"" + newCaseFolderName + "\"";
                    //process.StartInfo.Verb = "runas";
                    process.Start();

                    listbox.Items[listbox.SelectedIndex] = newCaseFolderName;

                    LogManager.addToLog("Rename: Case Folder was Renamed from " + oldFolderName + " to " + newCaseFolderName);
                    Console.WriteLine(LogManager.LogFile);
                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private void renameBoxMouseDown(object sender, MouseEventArgs e)
        {
            if (listbox.DisplayRectangle.Contains(e.Location))
            {
                if(listbox.GetItemRectangle(listbox.SelectedIndex).Contains(e.Location))
                {
                    renameBox.Hide();
                }
                    
            }
        }

        private void BoxFocused(object sender, EventArgs e)
        {
            renameBox.SelectionStart = 0;
            renameBox.SelectionLength = renameBox.Text.Length;
        }

        public TextBox getTextbox()
        {
            return renameBox;
        }

        public TextBox showRenameBox()
        {
            renameBox.Show();
            return renameBox;
        }


    }
}
