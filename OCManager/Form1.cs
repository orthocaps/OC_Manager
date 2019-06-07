using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ocManager.UserControls;

namespace ocManager
{
    public partial class MainView : Form
    {
        ucExplorer explorer;
        ucTools tools;
        ucTexts texts;
        ucLog log;
        public MainView()
        {
            this.Hide();
            Thread Splash = new Thread(new ThreadStart(StartForm));
            Splash.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            ContentManager.LoadAllCases();
            LoadUserControls();
            panel_ActualPointer.Visible = false;
            Splash.Abort();
            LogManager.loadLogFromFile();
        }

        public void StartForm()
        {
            Application.Run(new LoadingScreen.SplashScreen());
        }

        private void HideAllControls()
        {
            explorer.Visible = false;
            tools.Visible = false;
            texts.Visible = false;
            log.Visible = false;
        }

        private void LoadUserControls()
        {
            // Explorer
            explorer = new ucExplorer();
            panel_Content.Controls.Add(explorer);
            explorer.Visible = false;
            explorer.LoadAllCasesToListbox();

            //Tools
            tools = new ucTools();
            panel_Content.Controls.Add(tools);
            tools.Visible = false;

            //Texts
            texts = new ucTexts();
            panel_Content.Controls.Add(texts);
            texts.Visible = false;

            //Log
            log = new ucLog();
            panel_Content.Controls.Add(log);
            log.Visible = false;
        }

        private void Button_OpenExplorer_Click(object sender, EventArgs e)
        {
            //When Button EXPLORER is clicked
            HideAllControls();
            explorer.Visible = true;

            panel_ActualPointer.Location = new Point(button_OpenExplorer.Location.X,button_OpenExplorer.Location.Y+button_OpenExplorer.Height + 5);
            panel_ActualPointer.Width = button_OpenExplorer.Width;
            panel_ActualPointer.Visible = true;
            explorer.StatusLabel = Label_Status;
        }

        private void Button_OpenTexts_Click(object sender, EventArgs e)
        {
            //When Button TEXTS is clicked
            HideAllControls();
            texts.Visible = true;
            panel_ActualPointer.Location = new Point(button_OpenTexts.Location.X, button_OpenTexts.Location.Y + button_OpenTexts.Height + 5);
            panel_ActualPointer.Visible = true;
            panel_ActualPointer.Width = button_OpenTexts.Width;
        }

        private void Button_OpenTools_Click(object sender, EventArgs e)
        {
            //When Button TOOLS is clicked
            HideAllControls();
            tools.Visible = true;
            panel_ActualPointer.Location = new Point(button_OpenTools.Location.X, button_OpenTools.Location.Y + button_OpenTools.Height + 5);
            panel_ActualPointer.Width = button_OpenTools.Width;
            panel_ActualPointer.Visible = true;
        }

        private void Button_OpenLog_Click(object sender, EventArgs e)
        {
            //When Button LOG is clicked
            HideAllControls();
            log.Visible = true;
            panel_ActualPointer.Location = new Point(button_OpenLog.Location.X, button_OpenLog.Location.Y + button_OpenLog.Height + 5);
            panel_ActualPointer.Visible = true;
            panel_ActualPointer.Width = button_OpenLog.Width;
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogManager.WriteLogFile();
        }
    }
}
