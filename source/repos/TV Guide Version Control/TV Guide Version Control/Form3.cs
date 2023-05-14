using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TV_Guide_Version_Control;

namespace TV_Guide_Version_Control
{
    public partial class Form3 : Form_template
    {
        public Form3(Profile current_profile, List<Profile> profiles) : base(current_profile, profiles)
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = checkedListBox1.CheckedItems.Count;

            if (count > 3)
            {
                // Display a message to the user that they can only select up to 3 items
                MessageBox.Show("You can only select up to 3 items");

                // Uncheck the last item that was checked
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, false);
            }
            else
            {
                // Create a list to store the selected items
                List<string> selectedItems = new List<string>();

                // Add the selected items to the list
                foreach (string item in checkedListBox1.CheckedItems)
                {
                    selectedItems.Add(item);
                }

                // Do something with the selected items
                // ...
            }
        }
    }
}
