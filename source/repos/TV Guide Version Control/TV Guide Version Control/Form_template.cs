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
    public partial class Form_template : Form
    {
        public Profile current_profile;
        public List<Profile> profiles;

        public Form_template()
        {
            InitializeComponent();
            this.Text = "TV Guide";
            this.current_profile = null;
            this.profiles = new List<Profile>();
            //this.tb_profiles.Text += profiles;
        }

        protected Form_template(Profile current_profile, List<Profile> profiles)
        {
            InitializeComponent();
            this.Text = "TV Guide";
            this.current_profile = current_profile;
            this.profiles = profiles;

            if (profiles != null)
            {
                foreach (Profile profile in profiles)
                {
                    if (profile == current_profile)
                    {
                        tb_profiles.AppendText(profile.Name + Environment.NewLine);
                    }
                    else
                    {
                        tb_profiles.AppendText(profile.Name + Environment.NewLine);
                    }
                }
            }
        }
        public void CreateNewProfile(string newProfileName)
        {
            if (this.profiles == null)
            {
                this.profiles = new List<Profile>();
            }
            this.current_profile = new Profile(newProfileName);
            this.profiles.Add(current_profile);
            this.tb_profiles.Text += " " + newProfileName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tb_add_profile(String Profile_name)
        {
            tb_profiles.Text += Profile_name;
        }
    }
}
