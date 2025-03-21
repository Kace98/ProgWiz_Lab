namespace KalkulatorCen
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
            button_komp = new Button();
            button_Moni = new Button();
            label_SumaCen = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_komp
            // 
            button_komp.Location = new Point(12, 58);
            button_komp.Name = "button_komp";
            button_komp.Size = new Size(90, 23);
            button_komp.TabIndex = 0;
            button_komp.Text = "Komputer";
            button_komp.UseVisualStyleBackColor = true;
            button_komp.Click += button_komp_Click;
            // 
            // button_Moni
            // 
            button_Moni.Location = new Point(125, 58);
            button_Moni.Name = "button_Moni";
            button_Moni.Size = new Size(90, 23);
            button_Moni.TabIndex = 1;
            button_Moni.Text = "Monitor";
            button_Moni.UseVisualStyleBackColor = true;
            button_Moni.Click += button_Moni_Click;
            // 
            // label_SumaCen
            // 
            label_SumaCen.BackColor = SystemColors.HighlightText;
            label_SumaCen.BorderStyle = BorderStyle.FixedSingle;
            label_SumaCen.Location = new Point(234, 58);
            label_SumaCen.Name = "label_SumaCen";
            label_SumaCen.Size = new Size(90, 23);
            label_SumaCen.TabIndex = 2;
            label_SumaCen.Click += label_SumaCen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 43);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Cena zł";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 115);
            Controls.Add(label1);
            Controls.Add(label_SumaCen);
            Controls.Add(button_Moni);
            Controls.Add(button_komp);
            Name = "Form1";
            Text = "Kalkulator Zestawów Komputerowych";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_komp;
        private Button button_Moni;
        private Label label_SumaCen;
        private Label label1;
    }
}
