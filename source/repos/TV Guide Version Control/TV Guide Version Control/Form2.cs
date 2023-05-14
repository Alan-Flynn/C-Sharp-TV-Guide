using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TV_Guide_Version_Control;

namespace TV_Guide_Version_Control
{
    public partial class Form2 : Form_template
    {
        public Form2(Profile current_profile, List<Profile> profiles) : base(current_profile, profiles)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new TextBox control
            TextBox text_box = new TextBox();
            text_box.Size = new Size(170, 20);
            text_box.Location = new Point(btn_create_profile.Left, btn_create_profile.Bottom + text_box.Height - 10);

            text_box.Text = "Input a new name: ";

            text_box.KeyDown += (s, args) =>
            {
                if (args.KeyCode == Keys.Enter)
                {
                    string name = text_box.Text.Substring(18);
                    Profile profile = new Profile(name);
                    this.current_profile = profile;
                    //this.tb_profiles.Text += " " + name;
                    this.Controls.Remove(text_box);
                }
            };

            // Add the TextBox to the form
            this.Controls.Add(text_box);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
