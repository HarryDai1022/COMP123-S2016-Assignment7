namespace COMP123_S2016_Assignment7
{
    partial class SelectionForm
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.MovieListLabel = new System.Windows.Forms.Label();
            this.SlectionGroupBox = new System.Windows.Forms.GroupBox();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SlectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(25, 29);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(490, 24);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Choose the movie you wish to stream from the list below";
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 24;
            this.MovieListBox.Items.AddRange(new object[] {
            "Cedar Rapids",
            "Company Men",
            "Death Race 2",
            "FootLoose",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No String Attached",
            "Real Steel",
            "Sanctum",
            "Season of the Witch",
            "The Dilemma",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other Woman",
            "The Rite",
            "The Roommate",
            "The Way Back",
            "Waiting for Forever"});
            this.MovieListBox.Location = new System.Drawing.Point(29, 102);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(230, 292);
            this.MovieListBox.TabIndex = 1;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // MovieListLabel
            // 
            this.MovieListLabel.AutoSize = true;
            this.MovieListLabel.Location = new System.Drawing.Point(73, 75);
            this.MovieListLabel.Name = "MovieListLabel";
            this.MovieListLabel.Size = new System.Drawing.Size(139, 24);
            this.MovieListLabel.TabIndex = 2;
            this.MovieListLabel.Text = "Current Movies";
            // 
            // SlectionGroupBox
            // 
            this.SlectionGroupBox.Controls.Add(this.CostTextBox);
            this.SlectionGroupBox.Controls.Add(this.CostLabel);
            this.SlectionGroupBox.Controls.Add(this.CategoryTextBox);
            this.SlectionGroupBox.Controls.Add(this.CategoryLabel);
            this.SlectionGroupBox.Controls.Add(this.TitleTextBox);
            this.SlectionGroupBox.Controls.Add(this.TitleLabel);
            this.SlectionGroupBox.Controls.Add(this.MoviePictureBox);
            this.SlectionGroupBox.Location = new System.Drawing.Point(282, 90);
            this.SlectionGroupBox.Name = "SlectionGroupBox";
            this.SlectionGroupBox.Size = new System.Drawing.Size(399, 244);
            this.SlectionGroupBox.TabIndex = 3;
            this.SlectionGroupBox.TabStop = false;
            this.SlectionGroupBox.Text = "Your Slection";
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.Location = new System.Drawing.Point(16, 46);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(127, 169);
            this.MoviePictureBox.TabIndex = 0;
            this.MoviePictureBox.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(163, 31);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(47, 24);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BackColor = System.Drawing.Color.White;
            this.TitleTextBox.Location = new System.Drawing.Point(167, 59);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(203, 32);
            this.TitleTextBox.TabIndex = 2;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(163, 94);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(84, 24);
            this.CategoryLabel.TabIndex = 3;
            this.CategoryLabel.Text = "Category";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.BackColor = System.Drawing.Color.White;
            this.CategoryTextBox.Location = new System.Drawing.Point(167, 121);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(203, 32);
            this.CategoryTextBox.TabIndex = 4;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(163, 156);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(47, 24);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost";
            // 
            // CostTextBox
            // 
            this.CostTextBox.BackColor = System.Drawing.Color.White;
            this.CostTextBox.Location = new System.Drawing.Point(167, 183);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(203, 32);
            this.CostTextBox.TabIndex = 6;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(582, 359);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(99, 35);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.SlectionGroupBox);
            this.Controls.Add(this.MovieListLabel);
            this.Controls.Add(this.MovieListBox);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.Text = "Movie Bonanza – Online Streaming";
            this.SlectionGroupBox.ResumeLayout(false);
            this.SlectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.Label MovieListLabel;
        private System.Windows.Forms.GroupBox SlectionGroupBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.Button NextButton;
    }
}

