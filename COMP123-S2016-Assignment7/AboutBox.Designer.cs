namespace COMP123_S2016_Assignment7
{
    partial class AboutBox
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameLabel2 = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.VersionLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 30);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(172, 24);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Programmer Name:";
            // 
            // NameLabel2
            // 
            this.NameLabel2.AutoSize = true;
            this.NameLabel2.Location = new System.Drawing.Point(201, 30);
            this.NameLabel2.Name = "NameLabel2";
            this.NameLabel2.Size = new System.Drawing.Size(73, 24);
            this.NameLabel2.TabIndex = 1;
            this.NameLabel2.Text = "Zun Dai";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(12, 74);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(152, 24);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "Program Version:";
            // 
            // VersionLabel2
            // 
            this.VersionLabel2.AutoSize = true;
            this.VersionLabel2.Location = new System.Drawing.Point(200, 74);
            this.VersionLabel2.Name = "VersionLabel2";
            this.VersionLabel2.Size = new System.Drawing.Size(35, 24);
            this.VersionLabel2.TabIndex = 3;
            this.VersionLabel2.Text = "1.0";
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 253);
            this.Controls.Add(this.VersionLabel2);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.NameLabel2);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AboutBox";
            this.Text = "AboutBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label NameLabel2;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label VersionLabel2;
    }
}