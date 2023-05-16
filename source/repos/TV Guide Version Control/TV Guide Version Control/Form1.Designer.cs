namespace TV_Guide_Version_Control
{
    partial class Form1
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
            this.btn_profiles = new System.Windows.Forms.Button();
            this.btn_movies = new System.Windows.Forms.Button();
            this.btn_TVShows = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_profiles
            // 
            this.tb_profiles.Location = new System.Drawing.Point(32, 416);
            this.tb_profiles.Size = new System.Drawing.Size(229, 22);
            // 
            // btn_profiles
            // 
            this.btn_profiles.Location = new System.Drawing.Point(86, 23);
            this.btn_profiles.Name = "btn_profiles";
            this.btn_profiles.Size = new System.Drawing.Size(164, 74);
            this.btn_profiles.TabIndex = 0;
            this.btn_profiles.Text = "Create Profile";
            this.btn_profiles.UseVisualStyleBackColor = true;
            this.btn_profiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_movies
            // 
            this.btn_movies.Location = new System.Drawing.Point(86, 205);
            this.btn_movies.Name = "btn_movies";
            this.btn_movies.Size = new System.Drawing.Size(164, 74);
            this.btn_movies.TabIndex = 1;
            this.btn_movies.Text = "Movies";
            this.btn_movies.UseVisualStyleBackColor = true;
            this.btn_movies.Click += new System.EventHandler(this.btn_movies_Click);
            // 
            // btn_TVShows
            // 
            this.btn_TVShows.Location = new System.Drawing.Point(86, 298);
            this.btn_TVShows.Name = "btn_TVShows";
            this.btn_TVShows.Size = new System.Drawing.Size(164, 74);
            this.btn_TVShows.TabIndex = 2;
            this.btn_TVShows.Text = "TV Shows";
            this.btn_TVShows.UseVisualStyleBackColor = true;
            this.btn_TVShows.Click += new System.EventHandler(this.btn_TVShows_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 74);
            this.button1.TabIndex = 3;
            this.button1.Text = "Modify Profiles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_TVShows);
            this.Controls.Add(this.btn_movies);
            this.Controls.Add(this.btn_profiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.btn_profiles, 0);
            this.Controls.SetChildIndex(this.btn_movies, 0);
            this.Controls.SetChildIndex(this.btn_TVShows, 0);
            this.Controls.SetChildIndex(this.tb_profiles, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_profiles;
        private System.Windows.Forms.Button btn_movies;
        private System.Windows.Forms.Button btn_TVShows;
        private System.Windows.Forms.Button button1;
    }
}

