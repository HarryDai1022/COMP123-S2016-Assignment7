namespace COMP123_S2016_Assignment7
{
    partial class OrderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectedMovieGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectedCategoryTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.SelectedTitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SelectedMoviePictureBox = new System.Windows.Forms.PictureBox();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.CostTextBox2 = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.GrandTotalTextBox = new System.Windows.Forms.TextBox();
            this.DVDCheckBox = new System.Windows.Forms.CheckBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StreamButton = new System.Windows.Forms.Button();
            this.OrderAddLabel = new System.Windows.Forms.Label();
            this.OrderAddTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SelectedMovieGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedMoviePictureBox)).BeginInit();
            this.OrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.streamToolStripMenuItem.Text = "Stream";
            this.streamToolStripMenuItem.Click += new System.EventHandler(this.streamToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SelectedMovieGroupBox
            // 
            this.SelectedMovieGroupBox.Controls.Add(this.SelectedMoviePictureBox);
            this.SelectedMovieGroupBox.Controls.Add(this.SelectedCategoryTextBox);
            this.SelectedMovieGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectedMovieGroupBox.Controls.Add(this.SelectedTitleTextBox);
            this.SelectedMovieGroupBox.Controls.Add(this.TitleLabel);
            this.SelectedMovieGroupBox.Location = new System.Drawing.Point(13, 32);
            this.SelectedMovieGroupBox.Name = "SelectedMovieGroupBox";
            this.SelectedMovieGroupBox.Size = new System.Drawing.Size(298, 389);
            this.SelectedMovieGroupBox.TabIndex = 1;
            this.SelectedMovieGroupBox.TabStop = false;
            this.SelectedMovieGroupBox.Text = "Movie Selected";
            // 
            // SelectedCategoryTextBox
            // 
            this.SelectedCategoryTextBox.BackColor = System.Drawing.Color.White;
            this.SelectedCategoryTextBox.Location = new System.Drawing.Point(24, 125);
            this.SelectedCategoryTextBox.Name = "SelectedCategoryTextBox";
            this.SelectedCategoryTextBox.ReadOnly = true;
            this.SelectedCategoryTextBox.Size = new System.Drawing.Size(247, 32);
            this.SelectedCategoryTextBox.TabIndex = 9;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(20, 98);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(84, 24);
            this.CategoryLabel.TabIndex = 8;
            this.CategoryLabel.Text = "Category";
            // 
            // SelectedTitleTextBox
            // 
            this.SelectedTitleTextBox.BackColor = System.Drawing.Color.White;
            this.SelectedTitleTextBox.Location = new System.Drawing.Point(24, 63);
            this.SelectedTitleTextBox.Name = "SelectedTitleTextBox";
            this.SelectedTitleTextBox.ReadOnly = true;
            this.SelectedTitleTextBox.Size = new System.Drawing.Size(247, 32);
            this.SelectedTitleTextBox.TabIndex = 7;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(20, 35);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(47, 24);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Title";
            // 
            // SelectedMoviePictureBox
            // 
            this.SelectedMoviePictureBox.Location = new System.Drawing.Point(60, 180);
            this.SelectedMoviePictureBox.Name = "SelectedMoviePictureBox";
            this.SelectedMoviePictureBox.Size = new System.Drawing.Size(173, 203);
            this.SelectedMoviePictureBox.TabIndex = 10;
            this.SelectedMoviePictureBox.TabStop = false;
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.Controls.Add(this.OrderAddTextBox);
            this.OrderGroupBox.Controls.Add(this.OrderAddLabel);
            this.OrderGroupBox.Controls.Add(this.DVDCheckBox);
            this.OrderGroupBox.Controls.Add(this.GrandTotalTextBox);
            this.OrderGroupBox.Controls.Add(this.GrandTotalLabel);
            this.OrderGroupBox.Controls.Add(this.TaxTextBox);
            this.OrderGroupBox.Controls.Add(this.TaxLabel);
            this.OrderGroupBox.Controls.Add(this.SubTotalTextBox);
            this.OrderGroupBox.Controls.Add(this.TotalLabel);
            this.OrderGroupBox.Controls.Add(this.CostTextBox2);
            this.OrderGroupBox.Controls.Add(this.CostLabel);
            this.OrderGroupBox.Location = new System.Drawing.Point(361, 32);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(329, 314);
            this.OrderGroupBox.TabIndex = 2;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "Your Order";
            // 
            // CostTextBox2
            // 
            this.CostTextBox2.BackColor = System.Drawing.Color.White;
            this.CostTextBox2.Location = new System.Drawing.Point(62, 63);
            this.CostTextBox2.Name = "CostTextBox2";
            this.CostTextBox2.ReadOnly = true;
            this.CostTextBox2.Size = new System.Drawing.Size(203, 32);
            this.CostTextBox2.TabIndex = 8;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(140, 36);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(47, 24);
            this.CostLabel.TabIndex = 7;
            this.CostLabel.Text = "Cost";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(18, 153);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(82, 24);
            this.TotalLabel.TabIndex = 9;
            this.TotalLabel.Text = "SubTotal";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.BackColor = System.Drawing.Color.White;
            this.SubTotalTextBox.Location = new System.Drawing.Point(165, 150);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 32);
            this.SubTotalTextBox.TabIndex = 10;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(18, 197);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(130, 24);
            this.TaxLabel.TabIndex = 11;
            this.TaxLabel.Text = "Sales Tax(13%)";
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.BackColor = System.Drawing.Color.White;
            this.TaxTextBox.Location = new System.Drawing.Point(165, 189);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.ReadOnly = true;
            this.TaxTextBox.Size = new System.Drawing.Size(100, 32);
            this.TaxTextBox.TabIndex = 12;
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Location = new System.Drawing.Point(18, 235);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(108, 24);
            this.GrandTotalLabel.TabIndex = 13;
            this.GrandTotalLabel.Text = "Grand Total";
            // 
            // GrandTotalTextBox
            // 
            this.GrandTotalTextBox.BackColor = System.Drawing.Color.White;
            this.GrandTotalTextBox.Location = new System.Drawing.Point(165, 227);
            this.GrandTotalTextBox.Name = "GrandTotalTextBox";
            this.GrandTotalTextBox.ReadOnly = true;
            this.GrandTotalTextBox.Size = new System.Drawing.Size(100, 32);
            this.GrandTotalTextBox.TabIndex = 14;
            // 
            // DVDCheckBox
            // 
            this.DVDCheckBox.AutoSize = true;
            this.DVDCheckBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVDCheckBox.Location = new System.Drawing.Point(22, 274);
            this.DVDCheckBox.Name = "DVDCheckBox";
            this.DVDCheckBox.Size = new System.Drawing.Size(290, 22);
            this.DVDCheckBox.TabIndex = 15;
            this.DVDCheckBox.Text = "Order the DVD (adds $10.00 to your order)";
            this.DVDCheckBox.UseVisualStyleBackColor = true;
            this.DVDCheckBox.CheckedChanged += new System.EventHandler(this.DVDCheckBox_CheckedChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(361, 387);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(87, 33);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(490, 387);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(87, 33);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StreamButton
            // 
            this.StreamButton.Location = new System.Drawing.Point(586, 387);
            this.StreamButton.Name = "StreamButton";
            this.StreamButton.Size = new System.Drawing.Size(87, 33);
            this.StreamButton.TabIndex = 5;
            this.StreamButton.Text = "Stream";
            this.StreamButton.UseVisualStyleBackColor = true;
            this.StreamButton.Click += new System.EventHandler(this.StreamButton_Click);
            // 
            // OrderAddLabel
            // 
            this.OrderAddLabel.AutoSize = true;
            this.OrderAddLabel.Location = new System.Drawing.Point(18, 111);
            this.OrderAddLabel.Name = "OrderAddLabel";
            this.OrderAddLabel.Size = new System.Drawing.Size(128, 24);
            this.OrderAddLabel.TabIndex = 16;
            this.OrderAddLabel.Text = "Added Charge";
            this.OrderAddLabel.Visible = false;
            // 
            // OrderAddTextBox
            // 
            this.OrderAddTextBox.Location = new System.Drawing.Point(165, 108);
            this.OrderAddTextBox.Name = "OrderAddTextBox";
            this.OrderAddTextBox.Size = new System.Drawing.Size(100, 32);
            this.OrderAddTextBox.TabIndex = 17;
            this.OrderAddTextBox.Visible = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.ControlBox = false;
            this.Controls.Add(this.StreamButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OrderGroupBox);
            this.Controls.Add(this.SelectedMovieGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SelectedMovieGroupBox.ResumeLayout(false);
            this.SelectedMovieGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedMoviePictureBox)).EndInit();
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox SelectedMovieGroupBox;
        private System.Windows.Forms.PictureBox SelectedMoviePictureBox;
        private System.Windows.Forms.TextBox SelectedCategoryTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox SelectedTitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox OrderGroupBox;
        private System.Windows.Forms.TextBox GrandTotalTextBox;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox CostTextBox2;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.CheckBox DVDCheckBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button StreamButton;
        private System.Windows.Forms.TextBox OrderAddTextBox;
        private System.Windows.Forms.Label OrderAddLabel;
    }
}