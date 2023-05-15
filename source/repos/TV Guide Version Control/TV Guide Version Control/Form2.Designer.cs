namespace TV_Guide_Version_Control
{
    partial class Form2
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
            this.btn_create_profile = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_create_profile
            // 
            this.btn_create_profile.Location = new System.Drawing.Point(86, 84);
            this.btn_create_profile.Name = "btn_create_profile";
            this.btn_create_profile.Size = new System.Drawing.Size(164, 74);
            this.btn_create_profile.TabIndex = 0;
            this.btn_create_profile.Text = "Create Profile";
            this.btn_create_profile.UseVisualStyleBackColor = true;
            this.btn_create_profile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(32, 23);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(143, 33);
            this.btn_menu.TabIndex = 2;
            this.btn_menu.Text = "Main Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_create_profile);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Controls.SetChildIndex(this.tb_profiles, 0);
            this.Controls.SetChildIndex(this.btn_create_profile, 0);
            this.Controls.SetChildIndex(this.btn_menu, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create_profile;
        private System.Windows.Forms.Button btn_menu;
    }
}