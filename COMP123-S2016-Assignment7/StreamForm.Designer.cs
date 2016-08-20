namespace COMP123_S2016_Assignment7
{
    partial class StreamForm
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
            this.MessageLabel1 = new System.Windows.Forms.Label();
            this.MessageLabel2 = new System.Windows.Forms.Label();
            this.MessageLabel3 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageLabel1
            // 
            this.MessageLabel1.AutoSize = true;
            this.MessageLabel1.Location = new System.Drawing.Point(37, 31);
            this.MessageLabel1.Name = "MessageLabel1";
            this.MessageLabel1.Size = new System.Drawing.Size(346, 24);
            this.MessageLabel1.TabIndex = 0;
            this.MessageLabel1.Text = "Thank you for choosing Movie Bonanza!";
            // 
            // MessageLabel2
            // 
            this.MessageLabel2.AutoSize = true;
            this.MessageLabel2.Location = new System.Drawing.Point(38, 75);
            this.MessageLabel2.Name = "MessageLabel2";
            this.MessageLabel2.Size = new System.Drawing.Size(345, 24);
            this.MessageLabel2.TabIndex = 1;
            this.MessageLabel2.Text = "Your credit card will be charged  dollars.";
            // 
            // MessageLabel3
            // 
            this.MessageLabel3.AutoSize = true;
            this.MessageLabel3.Location = new System.Drawing.Point(90, 126);
            this.MessageLabel3.Name = "MessageLabel3";
            this.MessageLabel3.Size = new System.Drawing.Size(241, 24);
            this.MessageLabel3.TabIndex = 2;
            this.MessageLabel3.Text = "will begin streaming shortly";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(173, 191);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 34);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 253);
            this.ControlBox = false;
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.MessageLabel3);
            this.Controls.Add(this.MessageLabel2);
            this.Controls.Add(this.MessageLabel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StreamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel1;
        private System.Windows.Forms.Label MessageLabel2;
        private System.Windows.Forms.Label MessageLabel3;
        private System.Windows.Forms.Button OKButton;
    }
}