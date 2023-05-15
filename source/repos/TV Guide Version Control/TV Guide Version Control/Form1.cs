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
                Form2 form2 = new Form2(current_profile, profiles);
                form2.tb_profiles.Text = tb_profiles.Text;
                form2.Show();

                // Hide the current form
                this.Hide();
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
    }
    }
