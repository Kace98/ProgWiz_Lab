namespace GdzieJestDydelf
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
            label1 = new Label();
            button_start = new Button();
            button_ustawienia = new Button();
            button_koniec = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 35F);
            label1.Location = new Point(14, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(263, 141);
            label1.TabIndex = 0;
            label1.Text = "GDZIE JEST DYDELF???";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_start
            // 
            button_start.Font = new Font("Segoe UI", 25F);
            button_start.Location = new Point(12, 153);
            button_start.Name = "button_start";
            button_start.Size = new Size(256, 83);
            button_start.TabIndex = 1;
            button_start.Text = "START";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_Click;
            // 
            // button_ustawienia
            // 
            button_ustawienia.Font = new Font("Segoe UI", 25F);
            button_ustawienia.Location = new Point(12, 242);
            button_ustawienia.Name = "button_ustawienia";
            button_ustawienia.Size = new Size(256, 83);
            button_ustawienia.TabIndex = 2;
            button_ustawienia.Text = "USTAWIENIA";
            button_ustawienia.UseVisualStyleBackColor = true;
            button_ustawienia.Click += button_ustawienia_Click;
            // 
            // button_koniec
            // 
            button_koniec.Font = new Font("Segoe UI", 25F);
            button_koniec.Location = new Point(12, 331);
            button_koniec.Name = "button_koniec";
            button_koniec.Size = new Size(256, 83);
            button_koniec.TabIndex = 3;
            button_koniec.Text = "KONIEC";
            button_koniec.UseVisualStyleBackColor = true;
            button_koniec.Click += button_koniec_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 426);
            Controls.Add(button_koniec);
            Controls.Add(button_ustawienia);
            Controls.Add(button_start);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "MENU GŁÓWNE";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button_start;
        private Button button_ustawienia;
        private Button button_koniec;
    }
}
