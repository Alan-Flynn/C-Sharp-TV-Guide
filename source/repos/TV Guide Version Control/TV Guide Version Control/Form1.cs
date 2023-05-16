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
        public partial class Form1 : Form_template
        {
            public Form1(Profile current_profile, List<Profile> profiles) : base(current_profile, profiles)
            {
                InitializeComponent();
            this.Text = "TV Guide";

            string name;

                if (current_profile == null)
                {
                    name = PromptUserForName();
                    CreateNewProfile(name);
                }
            }

        private void button1_Click(object sender, EventArgs e)
            {
            if (this.profiles.Count >= 4)
            {
                MessageBox.Show("You can only have a maximum of 4 profiles.");
                return;
            }
            // Create a new TextBox control
            TextBox text_box = new TextBox();
            text_box.Size = new Size(170, 20);
            text_box.Location = new Point(btn_profiles.Left, btn_profiles.Top - text_box.Height - 10);

            text_box.Text = "Input a new name: ";

            text_box.KeyDown += (s, args) =>
            {
                if (args.KeyCode == Keys.Enter && text_box.Text.Substring(18) != "")
                {
                    string name = text_box.Text.Substring(18);
                    Profile profile = new Profile(name);
                    this.current_profile = profile;
                    this.profiles.Add(profile);
                    this.tb_profiles.Text += " " + name + " ";
                    this.Controls.Remove(text_box);
                }
            };

            // Add the TextBox to the form
            this.Controls.Add(text_box);
        }

            private string PromptUserForName()
            {
            string name = null;

            using (var form = new Form())
            {
                var textBox = new TextBox();
                var button = new Button();

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
                button.Click += (s, e) =>
                {
                    name = textBox.Text;
                    form.DialogResult = DialogResult.OK;
                    form.Close();
                };

                form.AcceptButton = button;

                Console.WriteLine(name);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    return name;
                }
            }

            return null;
        }

        private void btn_movies_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(current_profile, profiles);
            form3.tb_profiles.Text = tb_profiles.Text;
            form3.Show();

            this.Hide();
        }

        private void btn_TVShows_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(current_profile, profiles);
            form4.tb_profiles.Text = tb_profiles.Text;
            form4.Show();

            this.Hide();
        }

            private void button1_Click_1(object sender, EventArgs e)
        {
            // Create a new form to display the list of profiles
            Form profileListForm = new Form();
            profileListForm.Text = "Select Profile";
            profileListForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            profileListForm.MaximizeBox = false;
            profileListForm.MinimizeBox = false;
            profileListForm.StartPosition = FormStartPosition.CenterScreen;

            // Create a ListBox to display the profiles
            ListBox profileListBox = new ListBox();
            profileListBox.Dock = DockStyle.Top;  // Set the ListBox to be docked to the top
            profileListBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            // Add the profiles to the ListBox
            foreach (Profile profile in profiles)
            {
                profileListBox.Items.Add(profile.Name);
            }

            // Add the ListBox to the form
            profileListForm.Controls.Add(profileListBox);

            // Create OK, Delete, and Cancel buttons
            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Dock = DockStyle.Right;

            Button deleteButton = new Button();
            deleteButton.Text = "Delete";
            deleteButton.DialogResult = DialogResult.Abort;
            deleteButton.Dock = DockStyle.Right;

            Button cancelButton = new Button();
            cancelButton.Text = "Cancel";
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Dock = DockStyle.Right;

            // Add the buttons to the form
            profileListForm.Controls.Add(okButton);
            profileListForm.Controls.Add(deleteButton);
            profileListForm.Controls.Add(cancelButton);

            // Calculate the new height of the form
            int newHeight = (int)(profileListForm.Height * 0.4);

            // Set the height of the form to the new height
            profileListForm.Height = newHeight;

            // Show the form as a dialog and get the result
            DialogResult result = profileListForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Get the selected profile
                int selectedIndex = profileListBox.SelectedIndex;
                if (selectedIndex >= 0 && selectedIndex < profiles.Count)
                {
                    current_profile = profiles[selectedIndex];
                }
            }
            else if (result == DialogResult.Abort)
            {
                // Delete the selected profile
                int selectedIndex = profileListBox.SelectedIndex;
                if (selectedIndex >= 0 && selectedIndex < profiles.Count)
                {
                    if (current_profile != profiles[selectedIndex])
                    {
                        tb_profiles.Text = tb_profiles.Text.Replace(" " + profiles[selectedIndex].Name + " ", "");
                        profiles.RemoveAt(selectedIndex);
                        // Update the ListBox
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
