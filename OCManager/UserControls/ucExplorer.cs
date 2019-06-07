using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace ocManager.UserControls
{
    public partial class ucExplorer : UserControl
    {
        //General Stuff
        ImageList imagelist1;
        System.Timers.Timer statusTimer = new System.Timers.Timer();
        public Label StatusLabel;

        //Filewatcher
        public FileSystemWatcher FSW_Explorer;
        public FileSystemWatcher FSW_CaseFolder;

        //Tooltips:
        ToolTip tooltip_ButtonOpenCaseFolder = new ToolTip();
        ToolTip tooltip_ButtonEditCaseFolder = new ToolTip();


        public ucExplorer()
        {
            InitializeComponent();
            //Does not resize the columns of the explorer Listview, it stays the size which is in Designer given
            listView_Explorer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);

            imagelist1 = new ImageList();
            imagelist1.Images.Add("Folder", Properties.Resources.Folder_Icon);
            imagelist1.Images.Add("File", Properties.Resources.File_Icon);
            listView_Explorer.SmallImageList = imagelist1;

            statusTimer.Interval = 10000;

            statusTimer.Elapsed += OnTimedEvent;
            FSW_Initialisieren();
            loadToolTips();
            //LoadAllCasesToListbox();

            button_SendScans.Enabled = false;
            button_GetData.Enabled = false;

        }

        private void loadToolTips()
        {
            try
            {
                //Open Case Folder
                tooltip_ButtonOpenCaseFolder.IsBalloon = true;
                tooltip_ButtonOpenCaseFolder.ShowAlways = true;
                tooltip_ButtonOpenCaseFolder.SetToolTip(button_OpenCaseFolder, "Opens the Case Folder in Explorer");

                tooltip_ButtonEditCaseFolder.IsBalloon = true;
                tooltip_ButtonEditCaseFolder.ShowAlways = true;
                tooltip_ButtonEditCaseFolder.SetToolTip(button_EditCaseFolder, "Edit the Name of the Case");
            }
            catch(Exception ex)
            {
                LogManager.addToLog("Loading: " + ex.Message);
            }



        }

        private void FSW_Initialisieren()
        {
            try
            {
                // Filesystemwatcher anlegen
                FSW_Explorer = new FileSystemWatcher();
                FSW_CaseFolder = new FileSystemWatcher();

                // Pfad und Filter festlegen
                FSW_Explorer.Path = ContentManager.JobsFolderPath;
                FSW_CaseFolder.Path = ContentManager.JobsFolderPath;

                // Events definieren
                FSW_Explorer.Created += new FileSystemEventHandler(FSW_Changed);
                FSW_Explorer.Changed += new FileSystemEventHandler(FSW_Changed);
                FSW_Explorer.Renamed += new RenamedEventHandler(FSW_Changed);
                FSW_Explorer.Deleted += new FileSystemEventHandler(FSW_Changed);

                FSW_CaseFolder.Created += new FileSystemEventHandler(FSW_CaseFolder_Changed);
                FSW_CaseFolder.Changed += new FileSystemEventHandler(FSW_CaseFolder_Changed);
                FSW_CaseFolder.Deleted += new FileSystemEventHandler(FSW_CaseFolder_Changed);
                FSW_CaseFolder.Renamed += new RenamedEventHandler(FSW_CaseFolder_Changed);
                // Filesystemwatcher aktivieren
                FSW_Explorer.EnableRaisingEvents = true;
                FSW_CaseFolder.EnableRaisingEvents = true;
            }
            catch (Exception ex)
            {
                LogManager.addToLog("Loading: " + ex.Message);
            }
        }

        void FSW_Changed(object sender, FileSystemEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                UpdateExplorerWithPath(ContentManager.actualPath);
            }));
        }

        void FSW_CaseFolder_Changed(object sender, FileSystemEventArgs e)
        {
            try
            {
                this.BeginInvoke(new Action(() =>
                {

                    ContentManager.LoadAllCases();
                    if (textbox_SearchInTextbox.Text != "")
                    {
                        string oldsearchText = textbox_SearchInTextbox.Text;
                        textbox_SearchInTextbox.Text = "";
                        textbox_SearchInTextbox.Text = oldsearchText;
                        listbox_AllCases.SelectedItem = null;
                    }
                    Console.WriteLine("Case Folder updated");
                }));
            }
            catch(Exception ex)
            {
                LogManager.addToLog("Loading: " + ex.Message);
            }

        }

        public void LoadAllCasesToListbox()
        {
            try
            {
                List<string> allCaseNames = new List<string>();
                for (int i = 0; i < ContentManager.AllCases.GetLength(0); i++)
                {
                    allCaseNames.Add(ContentManager.AllCases[i, 2]);
                }
                listbox_AllCases.DataSource = allCaseNames;
            }
            catch(Exception ex)
            {
                LogManager.addToLog("Loading: " + ex.Message);
            }

        }

        private void UcExplorer_Load(object sender, EventArgs e)
        {

        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                StatusLabel.Text = "";
                statusTimer.Stop();
            }));
        }

        private void Textbox_SearchInTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> temp = new List<string>();
                if (textbox_SearchInTextbox.Text != "")
                {

                    for (int i = 0; i < ContentManager.AllCases.GetLength(0); i++)
                    {
                        if (ContentManager.AllCases[i, 2].IndexOf(textbox_SearchInTextbox.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            temp.Add(ContentManager.AllCases[i, 2]);
                        }
                    }
                    listbox_AllCases.SelectedItem = null;
                    listbox_AllCases.DataSource = temp;

                }
                else
                {
                    //listbox_AllCases.DataSource = null;
                    //listbox_AllCases.Items.Clear();
                    LoadAllCasesToListbox();
                }
            }
            catch (Exception ex)
            {
                LogManager.addToLog("General: " + ex.Message);
            }
        }

        public void UpdateExplorerWhenCaseFolderChanged()
        {
            try
            {
                if (listbox_AllCases.SelectedItem != null)
                {
                    listView_Explorer.Items.Clear();

                    //Get Current Element from AllCases Array to get Path and ID
                    string path = "";
                    for (int i = 0; i < ContentManager.AllCases.GetLength(0); i++)
                    {
                        if (ContentManager.AllCases[i, 2].Equals(listbox_AllCases.SelectedItem.ToString()))
                        {
                            path = ContentManager.AllCases[i, 1];
                        }
                    }

                    //Move through all Files and Folders in the Case Folder and add them to the Listview
                    foreach (var item in FileManager.getDirectoriesAndFiles(path))
                    {
                        Classes.ExplorerElement ee = new Classes.ExplorerElement(item);
                        ListViewItem lvi = ee.getListViewItem();
                        lvi.ImageKey = ee.isFile();
                        listView_Explorer.Items.Add(lvi);
                    }
                }
            }
            catch (Exception ex)
            {
                LogManager.addToLog("General: " + ex.Message);
            }
        }

        public void UpdateExplorerWithPath(string path)
        {
            try
            {
                listView_Explorer.Items.Clear();
                foreach (var item in FileManager.getDirectoriesAndFiles(path))
                {
                    Classes.ExplorerElement ee = new Classes.ExplorerElement(item);
                    ListViewItem lvi = ee.getListViewItem();
                    lvi.ImageKey = ee.isFile();
                    listView_Explorer.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                LogManager.addToLog("General: " + ex.Message);
            }
        }

        private void Listbox_AllCases_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateExplorerWhenCaseFolderChanged();
                if (listbox_AllCases.Items.Count != 0 && listbox_AllCases.SelectedItems.Count != 0)
                {
                    ContentManager.actualBaseFolder = ContentManager.getPathFromName(listbox_AllCases.SelectedItem.ToString());
                    ContentManager.actualPath = ContentManager.getPathFromName(listbox_AllCases.SelectedItem.ToString());
                    ContentManager.actualCaseID = ContentManager.getCaseIDFromName(listbox_AllCases.SelectedItem.ToString());
                    textBox_Path.Text = ContentManager.actualPath;
                    FSW_Explorer.Path = ContentManager.actualPath;
                }
            }
            catch (Exception ex)
            {
                LogManager.addToLog("General: " + ex.Message);
            }

        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void Back()
        {
            try
            {
                string currentPath = textBox_Path.Text;
                string[] temp = currentPath.Split('\\');
                string last = temp.Last();
                string nextpath = currentPath.Substring(0, currentPath.Length - last.Length).TrimEnd('\\');

                //Console.WriteLine(temp);
                if (nextpath.Length > ContentManager.JobsFolderPath.Length)
                {
                    UpdateExplorerWithPath(nextpath);
                    ContentManager.actualPath = nextpath;
                    textBox_Path.Text = nextpath;
                    enableButtons();
                }
            }
            catch (Exception ex)
            {
                LogManager.addToLog("General: " + ex.Message);
            }
        }

        private void ListView_Explorer_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            ChooseFileOrFolderInExplorer();
        }

        private void ChooseFileOrFolderInExplorer()
        {
            try
            {
                //Check if File or Folder. If File: Open the File. If Folder: Open the folder in listview
                string chosenPathOrFile = ContentManager.actualPath + @"\" + listView_Explorer.SelectedItems[0].Text;
                if (ContentManager.isFile(chosenPathOrFile))
                {
                    Process.Start(chosenPathOrFile);
                }
                else
                {
                    UpdateExplorerWithPath(chosenPathOrFile);
                    ContentManager.actualPath = chosenPathOrFile;
                    textBox_Path.Text = chosenPathOrFile;
                    FSW_Explorer.Path = ContentManager.actualPath;
                    enableButtons();
                }
            }
            catch (Exception ex)
            {
                LogManager.addToLog("General: " + ex.Message);
            }
        }

        private void Button_SendScans_Click(object sender, EventArgs e)
        {
            try
            {
                string CustomFolderName = "";

                //Build List with all chosen Scan Files
                List<string> ChosenItems = new List<string>();
                foreach (ListViewItem item in listView_Explorer.SelectedItems)
                {
                    ChosenItems.Add(item.Text);
                }

                //Check if Scans are from e.g. 3Shape so 
                foreach (var item in ChosenItems)
                {
                    if (!item.Split('_').First().Equals(ContentManager.actualCaseID))
                    {
                        CustomFolderName = DialogManager.ShowScanSendNameDialog();
                            break;
                    }
                }

                if(ChosenItems.Count !=0)
                {


                    string scanFolder = ContentManager.actualBaseFolder + @"\Scans";

                    //If there is no FolderName, so it has to be set from the Scans Name
                    if (CustomFolderName == "")
                    {
                        string actualCaseID = ChosenItems.First().Split('_').First();
                        string actualPhase = ChosenItems.First().Split('_')[1];
                        string newFolderToSend = ContentManager.actualBaseFolder + @"\" + actualCaseID + "_" + actualPhase + "_OC1";

                        // Create new Folder in Case Folder
                        Directory.CreateDirectory(newFolderToSend);

                        //Copy each chosen Scan to the new Folder
                        foreach (var item in ChosenItems)
                        {
                            File.Copy(scanFolder + @"\" + item, newFolderToSend + @"\" + item);
                            Console.WriteLine(scanFolder + @"\" + item + " Copy ----> " + newFolderToSend + @"\" + item);
                        }
                        // Copy the new Folder to Files From Orthocaps
                        FileManager.CopyFolder(newFolderToSend, ContentManager.FilesFromOrthocapsFolderPath + @"\" + actualCaseID + "_" + actualPhase + "_OC1");
                    }

                    else
                    {
                        string newFolderToSend = ContentManager.actualBaseFolder + @"\" + CustomFolderName;

                        //Create new Folder with Name from Dialogform
                        Directory.CreateDirectory(newFolderToSend);

                        //Copy each chosen Scan to the new Folder
                        foreach (var item in ChosenItems)
                        {
                            File.Copy(scanFolder + @"\" + item, newFolderToSend + @"\" + item);
                            Console.WriteLine(scanFolder + @"\" + item + " Copy ----> " + newFolderToSend + @"\" + item);
                        }
                        // Copy the new Folder to Files From Orthocaps
                        FileManager.CopyFolder(newFolderToSend, ContentManager.FilesFromOrthocapsFolderPath + @"\" + CustomFolderName);

                        Console.WriteLine("Folder Copied: " + newFolderToSend + " --> " + ContentManager.FilesFromOrthocapsFolderPath + @"\" + CustomFolderName);
                        //StatusLabel.Content = "Scans sent";
                        //statusTimer.Start();
                        LogManager.addToLog("SendScans: " + newFolderToSend + " wurde geschickt");
                    }
                }
            }
            catch(Exception ex)
            {
                LogManager.addToLog("SendScans: " + ex.Message);
            }
        }

        private void Button_GetData_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in Directory.GetDirectories(ContentManager.FilesFromSimothPackage1Path))
                {
                    if (System.IO.Path.GetFileName(item).Contains(ContentManager.actualCaseID))
                    {
                        FileManager.MoveFolder(item, ContentManager.actualBaseFolder + @"\Documents\" + System.IO.Path.GetFileName(item));
                    }
                }

                foreach (var item in Directory.GetFiles(ContentManager.FilesFromSimothPackage1Path))
                {
                    if (System.IO.Path.GetFileName(item).Contains(ContentManager.actualCaseID))
                    {
                        foreach (var folder in Directory.GetDirectories(ContentManager.actualBaseFolder + @"\Documents\"))
                        {
                            if (folder.Contains(ContentManager.actualCaseID))
                            {
                                File.Move(item, folder + @"\" + System.IO.Path.GetFileName(item));
                                Console.WriteLine("MOVED " + item + " " + ContentManager.actualBaseFolder + @"\Documents\" + System.IO.Path.GetFileName(item));
                            }
                        }

                    }
                }
                LogManager.addToLog("GetData: Data was moved for ID  " + ContentManager.actualCaseID);
            }
            catch (Exception ex)
            {
                LogManager.addToLog("GetData: " + ex.Message);
            }
        }

        private void Button_OpenCaseFolder_Click(object sender, EventArgs e)
        {
            Process.Start(ContentManager.getPathFromName(listbox_AllCases.SelectedItem.ToString()));
        }

        private void Button_EditCaseFolder_Click(object sender, EventArgs e)
        {
            Classes.RenameBox rb = new Classes.RenameBox(listbox_AllCases.GetItemRectangle(listbox_AllCases.SelectedIndex),listbox_AllCases);
            this.ActiveControl = rb.showRenameBox();
        }

        private void ListView_Explorer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back)
            {
                Back();
            }
            if (e.KeyCode == Keys.Enter)
            {
                ChooseFileOrFolderInExplorer();
            }
        }

        private void enableButtons()
        {
            string FolderName = textBox_Path.Text.Split('\\').Last();
            if (FolderName.Equals("Scans"))
            {
                button_SendScans.Enabled = true;
                button_GetData.Enabled = false;
            }
            else if (FolderName.Equals("Documents") || FolderName.Equals("Editable") || FolderName.Equals("iSetup"))
            {
                button_SendScans.Enabled = false;
                button_GetData.Enabled = true;
            }
            else
            {
                button_SendScans.Enabled = false;
                button_GetData.Enabled = false;
            }
        }

        private void ListView_Explorer_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {

            }
        }

        private void ListView_Explorer_DragLeave(object sender, EventArgs e)
        {

        }

        private void ListView_Explorer_MouseDown(object sender, MouseEventArgs e)
        {
            List<string> chosenItems = new List<string>();
            foreach (ListViewItem item in listView_Explorer.SelectedItems)
            {
                chosenItems.Add(ContentManager.actualPath + @"\" + item.Text);
            }

            DataObject data = new DataObject(DataFormats.FileDrop, chosenItems);
            foreach (var item in chosenItems)
            {
                data.SetData(DataFormats.StringFormat, item);
            }

            DoDragDrop(data, DragDropEffects.Copy);
        }
    }
}
