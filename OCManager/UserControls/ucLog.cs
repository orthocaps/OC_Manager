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
    public partial class ucLog : UserControl
    {
        public ucLog()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;


        }

        

        private void LoadLogToListbox(string category)
        {
            listBox1.Items.Clear();
            if(category.Equals("All"))
            {
                foreach (var item in LogManager.LogFile)
                {
                    listBox1.Items.Add(item);
                }
            }
            // show Log when GENERAL is selected
            else if(category.Equals(LogCategories.General))
            {
                foreach (var item in LogManager.LogFile)
                {
                    if(item.StartsWith(LogCategories.General))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            // show Log when GENERAL is selected
            else if (category.Equals(LogCategories.Loading))
            {
                foreach (var item in LogManager.LogFile)
                {
                    if (item.StartsWith(LogCategories.Loading))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLogToListbox(comboBox1.SelectedItem.ToString());
        }
    }
}
