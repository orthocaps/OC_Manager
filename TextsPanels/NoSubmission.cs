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
    public partial class NoSubmission : UserControl
    {
        string[] NoSub_DE;
        string[] NoSub_EN;
        string[] NoSub_FR;
        string[] Chosen_language;
        string Sex;
        string Date;
        string Clinician_Name;
        public NoSubmission()
        {
            InitializeComponent();
            NoSub_DE = File.ReadAllLines(ContentManager.Path_NoSubmissonDE, Encoding.Default);
            NoSub_EN = File.ReadAllLines(ContentManager.Path_NoSubmissonEN, Encoding.Default);
            NoSub_FR = File.ReadAllLines(ContentManager.Path_NoSubmissonFR, Encoding.Default);
            comboBox_Language.SelectedIndex = 0;
            comboBox_Sex.SelectedIndex = 0;

        }

        private void Button_Generate_Click(object sender, EventArgs e)
        {
            // Check for entry
            if (comboBox_Language.SelectedItem.ToString().Equals("German"))
            {
                Chosen_language = NoSub_DE;
            }
            else if (comboBox_Language.SelectedItem.ToString().Equals("English"))
            {
                Chosen_language = NoSub_EN;
            }
            else if (comboBox_Language.SelectedItem.ToString().Equals("French"))
            {
                Chosen_language = NoSub_FR;
            }
            else
            {
                Chosen_language = NoSub_DE;
            }
            //Check for Sex
            if (comboBox_Sex.SelectedItem.ToString().Equals("Male"))
            {
                Sex = "geehrter Herr";
            }
            else
            {
                Sex = "geehrte Frau";
            }

            // Check for Date
            Date = monthCalendar_Date.SelectionRange.Start.ToShortDateString();
            Clinician_Name = textBox_ClinicianName.Text;

            // Replacer
            for (int i = 0; i < Chosen_language.Length; i++)
            {
                Chosen_language[i] = Chosen_language[i].Replace("%Sex%", Sex);
                Chosen_language[i] = Chosen_language[i].Replace("%Clinician%", Clinician_Name);
                Chosen_language[i] = Chosen_language[i].Replace("%Date%", Date);
                Console.WriteLine(Chosen_language[i]);
                textBox_Output.Text += Chosen_language[i] + Environment.NewLine;
            }

        }

        private void Button_MovetoClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_Output.Text);
        }
    }
}
