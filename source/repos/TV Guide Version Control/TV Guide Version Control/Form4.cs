using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TV_Guide_Version_Control;

namespace TV_Guide_Version_Control
{
    public partial class Form4 : Form_template
    {
        private List<TextBox> profileTextBoxes;

        public Form4(Profile current_profile, List<Profile> profiles) : base(current_profile, profiles)
        {
            InitializeComponent();
            this.Text = "TV Guide";

            // Initialize the profile text boxes
            profileTextBoxes = new List<TextBox>();
            int textboxWidth = (int)(200); // 20% shorter
            int textboxHeight = 80;
            int margin = 10;
            int totalTextboxHeight = (profiles.Count + 1) * textboxHeight + profiles.Count * margin;
            int x = (int)(this.ClientSize.Width / 2 + margin + 1.3 * textboxWidth / 2); // 10% further to the right
            int y = this.ClientSize.Height / 2 - totalTextboxHeight / 2;
            for (int i = 0; i < profiles.Count; i++)
            {
                TextBox textBox = new TextBox();
                // Set the location and size of the TextBox
                textBox.Location = new Point(x - textboxWidth / 2, y + (i + 1) * textboxHeight + i * margin - textboxHeight / 2);
                textBox.Size = new Size(textboxWidth, textboxHeight);
                textBox.Multiline = true;
                textBox.ScrollBars = ScrollBars.Vertical;
                textBox.ReadOnly = true;
                textBox.BackColor = SystemColors.ControlLightLight;
                this.Controls.Add(textBox);
                profileTextBoxes.Add(textBox);
            }
        }

        public void UpdateProfileTextBoxes()
        {
            for (int i = 0; i < profiles.Count; i++)
            {
                Profile profile = profiles[i];
                TextBox textBox = profileTextBoxes[i];

                StringBuilder sb = new StringBuilder();
                sb.Append($"Name: {profile.Name}");
                if (profile.FavoriteFilms.Count > 0)
                {
                    sb.AppendLine();
                    sb.AppendLine("Favorite Movies:");
                    foreach (string movie in profile.FavoriteFilms)
                    {
                        sb.AppendLine(movie);
                    }
                }
                if (profile.FavoriteTVShows.Count > 0)
                {
                    sb.AppendLine();
                    sb.AppendLine("Favorite TV Shows:");
                    foreach (string tvShow in profile.FavoriteTVShows)
                    {
                        sb.AppendLine(tvShow);
                    }
                }
                textBox.Text = sb.ToString();
            }
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

                // Update the current profile's favorite movies
                current_profile.FavoriteTVShows = selectedItems;

                // Update the profile text boxes
                UpdateProfileTextBoxes();
            }

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(current_profile, profiles);
            form1.tb_profiles.Text = tb_profiles.Text;
            form1.Show();

            this.Hide();
        }
    }
}