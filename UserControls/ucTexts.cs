using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ocManager.UserControls
{
    public partial class ucTexts : UserControl
    {

        TextsPanels.ReportText Reports;
        TextsPanels.iSetupText iSetup;
        TextsPanels.NoSubmission NoSubmission;
        TextsPanels.BadImpressions BadImpressions;
        TextsPanels.Impressions_missing Impressions_Missing;
        TextsPanels.Attachment_Request Attachment_Request;
        public ucTexts()
        {
            InitializeComponent();
            // Reports Panel
            Reports = new TextsPanels.ReportText();
            panel_TextsContent.Controls.Add(Reports);
            Reports.Visible = false;

            // iSetups Panel
            iSetup = new TextsPanels.iSetupText();
            panel_TextsContent.Controls.Add(iSetup);
            iSetup.Visible = false;

            //No Submission Panel
            NoSubmission = new TextsPanels.NoSubmission();
            panel_TextsContent.Controls.Add(NoSubmission);
            NoSubmission.Visible = false;

            //Bad Impressions Panel
            BadImpressions = new TextsPanels.BadImpressions();
            panel_TextsContent.Controls.Add(BadImpressions);
            BadImpressions.Visible = false;

            //Impressions missing Panel
            Impressions_Missing = new TextsPanels.Impressions_missing();
            panel_TextsContent.Controls.Add(Impressions_Missing);
            Impressions_Missing.Visible = false;

            // Attachment Request Panel
            Attachment_Request = new TextsPanels.Attachment_Request();
            panel_TextsContent.Controls.Add(Attachment_Request);
            Attachment_Request.Visible = false;
        }
        // Hide ALL Function
        private void Hide_All()
        {
            Reports.Visible = false;
            iSetup.Visible = false;
            NoSubmission.Visible = false;
            BadImpressions.Visible = false;
            Impressions_Missing.Visible = false;
            Attachment_Request.Visible = false;
        }

        private void Panel_TextsContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListBox_TextsChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListBox_TextsChoice_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Report visibility
            if (listBox_TextsChoice.SelectedItem.ToString().Equals("Report Text"))
            {
                Hide_All();
                Reports.Visible = true;
            }

            // iSetup visibility
            else if (listBox_TextsChoice.SelectedItem.ToString().Equals("iSetup Text"))
            {
                Hide_All();
                iSetup.Visible = true;
            }

            // No Submission visibility
            else if (listBox_TextsChoice.SelectedItem.ToString().Equals("No Submisson"))
            {
                Hide_All();
                NoSubmission.Visible = true;
            }

            // Bad Impressions visibility
            else if (listBox_TextsChoice.SelectedItem.ToString().Equals("Bad Impressions"))
            {
                Hide_All();
                BadImpressions.Visible = true;
            }

            // Impressions missing visibility
            else if (listBox_TextsChoice.SelectedItem.ToString().Equals("Impressions missing"))
            {
                Hide_All();
                Impressions_Missing.Visible = true;
            }

            // Attachment Request visibility
            else if (listBox_TextsChoice.SelectedItem.ToString().Equals("Attachment Request"))
            {
                Hide_All();
                Attachment_Request.Visible = true;
            }
        }
    }
}
