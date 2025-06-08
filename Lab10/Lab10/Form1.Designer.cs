namespace Lab10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_wczytaj = new Button();
            SuspendLayout();
            // 
            // button_wczytaj
            // 
            button_wczytaj.Font = new Font("Segoe UI", 20F);
            button_wczytaj.Location = new Point(12, 12);
            button_wczytaj.Name = "button_wczytaj";
            button_wczytaj.Size = new Size(307, 118);
            button_wczytaj.TabIndex = 0;
            button_wczytaj.Text = "WCZYTAJ PLIK .fasta";
            button_wczytaj.UseVisualStyleBackColor = true;
            button_wczytaj.Click += button_wczytaj_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 142);
            Controls.Add(button_wczytaj);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button_wczytaj;
    }
}
