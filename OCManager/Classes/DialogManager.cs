using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocManager
{
    public static class DialogManager
    {
        public static string ShowScanSendNameDialog()
        {
            Dialogs.SetScanName NameDialog = new Dialogs.SetScanName();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (NameDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                return NameDialog.textBox1.Text;
            }
            NameDialog.Dispose();
            return null;
        }
    }
}
