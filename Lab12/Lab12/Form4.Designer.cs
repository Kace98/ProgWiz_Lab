namespace Lab12
{
    partial class Form4
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
            this.textBox_tresc = new System.Windows.Forms.TextBox();
            this.pictureBox_podglad = new System.Windows.Forms.PictureBox();
            this.button_zamknij = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_podglad)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_tresc
            // 
            this.textBox_tresc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_tresc.Location = new System.Drawing.Point(0, 0);
            this.textBox_tresc.Multiline = true;
            this.textBox_tresc.Name = "textBox_tresc";
            this.textBox_tresc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_tresc.Size = new System.Drawing.Size(584, 337);
            this.textBox_tresc.TabIndex = 0;
            // 
            // pictureBox_podglad
            // 
            this.pictureBox_podglad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_podglad.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_podglad.Name = "pictureBox_podglad";
            this.pictureBox_podglad.Size = new System.Drawing.Size(584, 337);
            this.pictureBox_podglad.TabIndex = 1;
            this.pictureBox_podglad.TabStop = false;
            // 
            // button_zamknij
            // 
            this.button_zamknij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_zamknij.Location = new System.Drawing.Point(497, 355);
            this.button_zamknij.Name = "button_zamknij";
            this.button_zamknij.Size = new System.Drawing.Size(75, 23);
            this.button_zamknij.TabIndex = 2;
            this.button_zamknij.Text = "Zamknij";
            this.button_zamknij.UseVisualStyleBackColor = true;
            this.button_zamknij.Click += new System.EventHandler(this.button_zamknij_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.textBox_tresc);
            this.panel1.Controls.Add(this.pictureBox_podglad);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 337);
            this.panel1.TabIndex = 3;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_zamknij);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Podgląd wpisu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_podglad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_tresc;
        private System.Windows.Forms.PictureBox pictureBox_podglad;
        private System.Windows.Forms.Button button_zamknij;
        private System.Windows.Forms.Panel panel1;
    }
} 