using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ocManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread Splash = new Thread(new ThreadStart(StartForm));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Splash.Start();
            Thread.Sleep(5000);
            Thread programm = new Thread(new ThreadStart(StartProgramm));
            programm.Start();
            Splash.Abort();
        }
        //Splashscreen
        static void StartForm()
        {            
            Application.Run(new LoadingScreen.SplashScreen());
        }
        //Mainprogramm
        static void StartProgramm()
        {
            Application.Run(new MainView());
        }
    }
}
