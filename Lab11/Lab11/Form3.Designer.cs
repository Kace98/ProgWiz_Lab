namespace Lab11
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_eksportuj = new System.Windows.Forms.Button();
            this.button_drukuj = new System.Windows.Forms.Button();

            // pictureBox1
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            // button_eksportuj
            this.button_eksportuj.Location = new System.Drawing.Point(12, 318);
            this.button_eksportuj.Name = "button_eksportuj";
            this.button_eksportuj.Size = new System.Drawing.Size(140, 30);
            this.button_eksportuj.Text = "Eksportuj do PNG";
            this.button_eksportuj.Click += new System.EventHandler(this.button_eksportuj_Click);

            // button_drukuj
            this.button_drukuj.Location = new System.Drawing.Point(172, 318);
            this.button_drukuj.Name = "button_drukuj";
            this.button_drukuj.Size = new System.Drawing.Size(140, 30);
            this.button_drukuj.Text = "Drukuj";
            this.button_drukuj.Click += new System.EventHandler(this.button_drukuj_Click);

            // Form3
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 361);
            this.Controls.Add(this.button_drukuj);
            this.Controls.Add(this.button_eksportuj);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kod QR próbki";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_eksportuj;
        private System.Windows.Forms.Button button_drukuj;
    }
} 