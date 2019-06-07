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

namespace ocManager.TextsPanels
{
    public partial class ReportText : UserControl
    {
        //Array Texts generate
        string[] ReportDE;
        string[] ReportEN;
        string[] ReportFR;
        public ReportText()
        {
            InitializeComponent();
            ReportDE = File.ReadAllLines(ContentManager.Path_reportDE, Encoding.Default);
            ReportEN = File.ReadAllLines(ContentManager.Path_reportEN, Encoding.Default);
            ReportFR = File.ReadAllLines(ContentManager.Path_reportFR, Encoding.Default);


            //Write in Textbox
            foreach (string Element in ReportDE)
            {
                textBox_ReportDE.Text += Element + Environment.NewLine;
            }

            foreach (string Element in ReportEN)
            {
                textBox_ReportEN.Text += Element + Environment.NewLine;
            }
            foreach (string Element in ReportFR)
            {
                textBox_ReportFR.Text += Element + Environment.NewLine;
            }
        }
        // Clipboard Buttons
        private void Button_ReportDE_MovetoClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_ReportDE.Text);
        }

        private void Button_ReportEN_MovetoClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_ReportEN.Text);
        }

        private void Button_ReportFR_MovetoClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_ReportFR.Text);
        }

    }
}
