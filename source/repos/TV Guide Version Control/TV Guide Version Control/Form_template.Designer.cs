﻿namespace TV_Guide_Version_Control
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
            this.tb_profiles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_profiles
            // 
            this.tb_profiles.Location = new System.Drawing.Point(32, 402);
            this.tb_profiles.Name = "tb_profiles";
            this.tb_profiles.Size = new System.Drawing.Size(188, 22);
            this.tb_profiles.TabIndex = 1;
            this.tb_profiles.Text = "Profiles: ";
            // 
            // Form_template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_profiles);
            this.Name = "Form_template";
            this.Text = "Form_template";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox tb_profiles;
    }
}