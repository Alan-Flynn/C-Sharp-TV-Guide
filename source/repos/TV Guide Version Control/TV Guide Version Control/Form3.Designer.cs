namespace TV_Guide_Version_Control
{
    partial class Form3
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "The Godfather (1972)",
            "Forrest Gump (1994)",
            "Inception (2010)",
            "The Shawshank Redemption (1994)",
            "The Dark Knight (2008)",
            "Titanic (1997)",
            "The Silence of the Lambs (1991)",
            "Schindler\'s List (1993)",
            "The Matrix (1999)",
            "Interstellar (2014)",
            "Avengers: Endgame (2019)",
            "Parasite (2019)",
            "The Departed (2006)",
            "Jurassic Park (1993)",
            "The Lion King (1994)"});
            this.checkedListBox1.Location = new System.Drawing.Point(49, 96);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(302, 276);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_1);
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(32, 33);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(143, 33);
            this.btn_menu.TabIndex = 2;
            this.btn_menu.Text = "Main Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Controls.SetChildIndex(this.checkedListBox1, 0);
            this.Controls.SetChildIndex(this.tb_profiles, 0);
            this.Controls.SetChildIndex(this.btn_menu, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_menu;
    }
}