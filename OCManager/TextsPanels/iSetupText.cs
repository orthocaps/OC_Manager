using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ocManager.TextsPanels
{
    public partial class iSetupText : UserControl
    {
        public iSetupText()
        {
            InitializeComponent();
            comboBox_Language.SelectedIndex = 0;
        }

        private void Button_MovetoClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_Ouput.Text);
        }

        private void Button_Generate_Click(object sender, EventArgs e)
        {
            textBox_Ouput.Text = "";
            // Check for Language
            //GERMAN
            if (comboBox_Language.SelectedItem.ToString().Equals("German"))
            {
                textBox_Ouput.Text += "Stages OK: " + textBox_OKStages.Text
                    + Environment.NewLine + "Stages UK: " + textBox_UKStages.Text
                    + Environment.NewLine
                    + Environment.NewLine;
            }
            //ENGLISH
            else if (comboBox_Language.SelectedItem.ToString().Equals("English"))
            {
                textBox_Ouput.Text += "Stages Upper: " + textBox_OKStages.Text
                    + Environment.NewLine + "Stages Lower: " + textBox_UKStages.Text
                    + Environment.NewLine
                    + Environment.NewLine;
            }
            //FRENCH
            else if (comboBox_Language.SelectedItem.ToString().Equals("French"))
            {
                textBox_Ouput.Text += "Nombre d´aligneurs maxillaire: " + textBox_OKStages.Text
                    + Environment.NewLine + "Nombre d´aligneurs mandibule: " + textBox_UKStages.Text
                    + Environment.NewLine
                    + Environment.NewLine;
            }

            // Check for Stripping 
            //GERMAN
            if (checkBox_Stripping.Checked == true && comboBox_Language.SelectedItem.ToString().Equals("German"))
            {
                String Stripping = "Stripping: Erforderlich" + Environment.NewLine;
                textBox_Ouput.Text += Stripping;
            }
            else if (checkBox_Stripping.Checked == false && comboBox_Language.SelectedItem.ToString().Equals("German"))
            {
                String Stripping = "Stripping: Nicht erforderlich in der 1.Phase" + Environment.NewLine;
                textBox_Ouput.Text += Stripping;
            }

            //ENGLISH
            if (checkBox_Stripping.Checked == true && comboBox_Language.SelectedItem.ToString().Equals("English"))
            {
                String Stripping = "Stripping: Needed" + Environment.NewLine;
                textBox_Ouput.Text += Stripping;
            }
            else if (checkBox_Stripping.Checked == false && comboBox_Language.SelectedItem.ToString().Equals("English"))
            {
                String Stripping = "Stripping: No need for stripping in the first phase" + Environment.NewLine;
                textBox_Ouput.Text += Stripping;
            }

            //FRENCH
            if (checkBox_Stripping.Checked == true && comboBox_Language.SelectedItem.ToString().Equals("French"))
            {
                String Stripping = "Stripping: nécéssaire" + Environment.NewLine;
                textBox_Ouput.Text += Stripping;
            }
            else if (checkBox_Stripping.Checked == false && comboBox_Language.SelectedItem.ToString().Equals("French"))
            {
                String Stripping = "Stripping: pas nécéssaire pour la première phase" + Environment.NewLine;
                textBox_Ouput.Text += Stripping;
            }

            //Check For Classcorrection
            //GERMAN
            if (checkBox_KLIIGZ.Checked == true && comboBox_Language.SelectedItem.ToString().Equals("German"))
            {
                textBox_Ouput.Text += "KL II Korrektur simuliert." + Environment.NewLine;
            }
            else if (checkBox_KLIIIGZ.Checked == true && comboBox_Language.SelectedItem.ToString().Equals("German"))
            {
                textBox_Ouput.Text += "KL III Korrektur simuliert." + Environment.NewLine;
            }

            //ENGLISH
            else if (checkBox_KLIIGZ.Checked == true && comboBox_Language.SelectedItem.ToString().Equals("English"))
            {
                textBox_Ouput.Text += "Class II Correction simulated." + Environment.NewLine;
            }
            else if (checkBox_KLIIIGZ.Checked == true && comboBox_Language.SelectedItem.ToString().Equals("English"))
            {
                textBox_Ouput.Text += "Class III Correction simulated." + Environment.NewLine;
            }

            //FRENCH
            else if (checkBox_KLIIGZ.Checked == true && comboBox_Language.SelectedItem.ToString().Equals("French"))
            {
                textBox_Ouput.Text += "Simulation de la correction classe II." + Environment.NewLine;
            }
            else if (checkBox_KLIIIGZ.Checked == true && comboBox_Language.SelectedItem.ToString().Equals("French"))
            {
                textBox_Ouput.Text += "Simulation de la correction classe III." + Environment.NewLine;
            }

            //Check for Crowding
            //GERMAN
            if (checkBox_Crowding.Checked == true && comboBox_Language.SelectedItem.ToString().Equals("German"))
            {
                textBox_Ouput.Text += "Engstandsauflösung." + Environment.NewLine;
            }

            //ENGLISH
            else if (checkBox_Crowding.Checked == true && comboBox_Language.SelectedItem.ToString().Equals("English"))
            {
                textBox_Ouput.Text += "Resolving the crowding." + Environment.NewLine;
            }
            //FRENCH
            else if (checkBox_Crowding.Checked == true && comboBox_Language.SelectedItem.ToString().Equals("French"))
            {
                textBox_Ouput.Text += "Correction de l´encombrement dentaire." + Environment.NewLine;
            }


            //Check for Spacing
            //GERMAN
            if (checkBox_Spacing.Checked == true && comboBox_Language.SelectedItem.ToString().Equals("German"))
            {
                textBox_Ouput.Text += "Lückenschluss" + Environment.NewLine;
            }
            //ENGLISH
            else if (checkBox_Spacing.Checked == true && comboBox_Language.SelectedItem.ToString().Equals("English"))
            {
                textBox_Ouput.Text += "Close the spaces." + Environment.NewLine;
            }
            //FRENCH
            else if (checkBox_Spacing.Checked == true && comboBox_Language.SelectedItem.ToString().Equals("French"))
            {
                textBox_Ouput.Text += "Fermeture des espaces." + Environment.NewLine;
            }

            // Constand Lines
            //GERMAN
            if (comboBox_Language.SelectedItem.ToString().Equals("German"))
            {
                textBox_Ouput.Text += "Zahnbogenausformung."
                    + Environment.NewLine
                    + Environment.NewLine
                    + "Für ein optimales Behandlungsergebnis überprüfen Sie bitte gemeinsam mit dem"
                    + Environment.NewLine
                    + "Patienten das Trageverhalten und erklären es ihm ( mindestens 22 Std.pro Tag ).";
            }
            //ENGLISH
            else if (comboBox_Language.SelectedItem.ToString().Equals("English"))
            {
                textBox_Ouput.Text += "Aligning the arches."
                    + Environment.NewLine
                    + Environment.NewLine
                    + "For the best outcome, please ask the patient to wear the aligners as required"
                    + Environment.NewLine
                    + "( at least 22 hours a day ) and consider changing the aligners every 3 weeks.";
            }
            else if (comboBox_Language.SelectedItem.ToString().Equals("French"))
            {
                textBox_Ouput.Text += "Alignement des arcades dentaires.";
            }
        }
    }
}
    

