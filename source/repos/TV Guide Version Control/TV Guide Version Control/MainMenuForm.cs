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
    public partial class MainMenuForm : Form_template
    {
        public MainMenuForm(Profile current_profile, List<Profile> profiles) : base(current_profile, profiles)
        {
            InitializeComponent();
            this.Text = "TV Guide";

            if (current_profile == null)
            {
                string name = PromptUserForName();
                CreateNewProfile(name);
            }
        }

        private void btn_profiles_Click(object sender, EventArgs e)
        {
            if (profiles.Count >= 4)
            {
                MessageBox.Show("You can only have a maximum of 4 profiles.");
                return;
            }

            TextBox textBox = new TextBox
            {
                Size = new Size(170, 20),
                Location = new Point(btn_profiles.Left, btn_profiles.Top - 30),
                Text = "Input a new name: "
            };

            textBox.KeyDown += (s, args) =>
            {
                if (args.KeyCode == Keys.Enter)
                {
                    string name = textBox.Text.Substring(18).Trim();

                    if (!string.IsNullOrEmpty(name))
                    {
                        Profile profile = new Profile(name);
                        current_profile = profile;
                        profiles.Add(profile);
                        tb_profiles.Text += " " + name + " ";
                        Controls.Remove(textBox);
                    }
                    else
                    {
                        MessageBox.Show("Profile name cannot be empty.");
                    }
                }
            };

            Controls.Add(textBox);
        }

        private string PromptUserForName()
        {
            string name = null;

            using (Form form = new Form())
            {
                TextBox textBox = new TextBox();
                Button button = new Button();

                form.Text = "Enter your name:";
                form.ClientSize = new Size(300, 100);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;

                textBox.Parent = form;
                textBox.Location = new Point(20, 20);
                textBox.Size = new Size(200, 20);

                button.Parent = form;
                button.Text = "OK";
                button.Location = new Point(230, 18);
                button.Size = new Size(50, 25);
                button.Enabled = false;

                textBox.TextChanged += (s, e) =>
                {
                    button.Enabled = !string.IsNullOrWhiteSpace(textBox.Text);
                };

                button.Click += (s, e) =>
                {
                    name = textBox.Text + " ";
                    form.DialogResult = DialogResult.OK;
                    form.Close();
                };

                form.AcceptButton = button;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    return name;
                }
            }

            return null;
        }

        private void btn_movies_Click(object sender, EventArgs e)
        {
            MoviesForm form3 = new MoviesForm(current_profile, profiles);
            form3.tb_profiles.Text = tb_profiles.Text;
            form3.Show();

            Hide();
        }

        private void btn_TVShows_Click(object sender, EventArgs e)
        {
            TVShowsForm form4 = new TVShowsForm(current_profile, profiles);
            form4.tb_profiles.Text = tb_profiles.Text;
            form4.Show();

            Hide();
        }

        private void btn_modprofiles_Click(object sender, EventArgs e)
        {
            using (Form profileListForm = new Form())
            {
                profileListForm.Text = "Select Profile";
                profileListForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                profileListForm.MaximizeBox = false;
                profileListForm.MinimizeBox = false;
                profileListForm.StartPosition = FormStartPosition.CenterScreen;
                ListBox profileListBox = new ListBox
                {
                    Dock = DockStyle.Top,
                    Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)))
                };

                foreach (Profile profile in profiles)
                {
                    profileListBox.Items.Add(profile.Name);
                }

                profileListForm.Controls.Add(profileListBox);

                Button okButton = new Button
                {
                    Text = "OK",
                    DialogResult = DialogResult.OK,
                    Dock = DockStyle.Right
                };

                Button deleteButton = new Button
                {
                    Text = "Delete",
                    DialogResult = DialogResult.Abort,
                    Dock = DockStyle.Right
                };

                Button cancelButton = new Button
                {
                    Text = "Cancel",
                    DialogResult = DialogResult.Cancel,
                    Dock = DockStyle.Right
                };

                profileListForm.Controls.Add(okButton);
                profileListForm.Controls.Add(deleteButton);
                profileListForm.Controls.Add(cancelButton);

                profileListForm.Height = (int)(profileListForm.Height * 0.4);

                DialogResult result = profileListForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int selectedIndex = profileListBox.SelectedIndex;
                    if (selectedIndex >= 0 && selectedIndex < profiles.Count)
                    {
                        current_profile = profiles[selectedIndex];
                    }
                }
                else if (result == DialogResult.Abort)
                {
                    int selectedIndex = profileListBox.SelectedIndex;
                    if (selectedIndex >= 0 && selectedIndex < profiles.Count)
                    {
                        if (current_profile != profiles[selectedIndex])
                        {
                            string deletedProfileName = profiles[selectedIndex].Name;
                            profiles.RemoveAt(selectedIndex);
                            tb_profiles.Text = tb_profiles.Text.Replace(deletedProfileName, string.Empty).Replace("  ", " ").Trim();

                            profileListBox.Items.RemoveAt(selectedIndex);
                        }
                        else
                        {
                            MessageBox.Show("You cannot delete the current profile.");
                        }
                    }
                }
            }
        }
    }
}