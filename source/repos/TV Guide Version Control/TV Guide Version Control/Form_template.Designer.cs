namespace TV_Guide_Version_Control
{
    partial class Form_template
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_tvguide = new System.Windows.Forms.TextBox();
            this.tb_profiles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_tvguide
            // 
            this.tb_tvguide.Location = new System.Drawing.Point(319, 46);
            this.tb_tvguide.Name = "tb_tvguide";
            this.tb_tvguide.Size = new System.Drawing.Size(100, 22);
            this.tb_tvguide.TabIndex = 0;
            this.tb_tvguide.Text = "TV Guide";
            this.tb_tvguide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_profiles
            // 
            this.tb_profiles.Location = new System.Drawing.Point(32, 402);
            this.tb_profiles.Name = "tb_profiles";
            this.tb_profiles.Size = new System.Drawing.Size(100, 22);
            this.tb_profiles.TabIndex = 1;
            this.tb_profiles.Text = "Profiles: ";
            // 
            // Form_template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_profiles);
            this.Controls.Add(this.tb_tvguide);
            this.Name = "Form_template";
            this.Text = "Form_template";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_tvguide;
        private System.Windows.Forms.TextBox tb_profiles;
    }
}