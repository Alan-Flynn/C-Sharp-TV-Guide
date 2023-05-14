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
            this.SuspendLayout();
            // 
            // btn_profiles
            // 
            this.btn_profiles.Location = new System.Drawing.Point(86, 84);
            this.btn_profiles.Name = "btn_profiles";
            this.btn_profiles.Size = new System.Drawing.Size(164, 74);
            this.btn_profiles.TabIndex = 0;
            this.btn_profiles.Text = "Profiles";
            this.btn_profiles.UseVisualStyleBackColor = true;
            this.btn_profiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_movies
            // 
            this.btn_movies.Location = new System.Drawing.Point(86, 202);
            this.btn_movies.Name = "btn_movies";
            this.btn_movies.Size = new System.Drawing.Size(164, 74);
            this.btn_movies.TabIndex = 1;
            this.btn_movies.Text = "Movies";
            this.btn_movies.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_movies);
            this.Controls.Add(this.btn_profiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_profiles;
        private System.Windows.Forms.Button btn_movies;
    }
}

