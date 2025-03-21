namespace KalkulatorCen
{
    partial class Form2
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
            label1 = new Label();
            label_ProcWyb = new Label();
            label2 = new Label();
            comboBox_Proc = new ComboBox();
            label3 = new Label();
            label_DyskWyb = new Label();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label4 = new Label();
            label_SumaCen = new Label();
            label6 = new Label();
            button_Ok = new Button();
            button_Anuluj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Procesor";
            // 
            // label_ProcWyb
            // 
            label_ProcWyb.BackColor = SystemColors.HighlightText;
            label_ProcWyb.BorderStyle = BorderStyle.FixedSingle;
            label_ProcWyb.Location = new Point(71, 36);
            label_ProcWyb.Name = "label_ProcWyb";
            label_ProcWyb.Size = new Size(90, 23);
            label_ProcWyb.TabIndex = 1;
            label_ProcWyb.Click += label_ProcWyb_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 37);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 2;
            label2.Text = "zł";
            // 
            // comboBox_Proc
            // 
            comboBox_Proc.FormattingEnabled = true;
            comboBox_Proc.Location = new Point(12, 71);
            comboBox_Proc.Name = "comboBox_Proc";
            comboBox_Proc.Size = new Size(170, 23);
            comboBox_Proc.TabIndex = 3;
            comboBox_Proc.SelectedIndexChanged += comboBox_Proc_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "Dysk";
            // 
            // label_DyskWyb
            // 
            label_DyskWyb.BackColor = SystemColors.HighlightText;
            label_DyskWyb.BorderStyle = BorderStyle.FixedSingle;
            label_DyskWyb.Location = new Point(71, 138);
            label_DyskWyb.Name = "label_DyskWyb";
            label_DyskWyb.Size = new Size(90, 23);
            label_DyskWyb.TabIndex = 5;
            label_DyskWyb.Click += label_DyskWyb_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 139);
            label5.Name = "label5";
            label5.Size = new Size(15, 15);
            label5.TabIndex = 6;
            label5.Text = "zł";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 164);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(84, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "240 GB SSD";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 189);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(91, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "500 GB SATA";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 214);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(97, 19);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "1000 GB SATA";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 267);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 10;
            label4.Text = "Suma:";
            // 
            // label_SumaCen
            // 
            label_SumaCen.BackColor = SystemColors.HighlightText;
            label_SumaCen.BorderStyle = BorderStyle.FixedSingle;
            label_SumaCen.Location = new Point(71, 266);
            label_SumaCen.Name = "label_SumaCen";
            label_SumaCen.Size = new Size(90, 23);
            label_SumaCen.TabIndex = 11;
            label_SumaCen.Click += label_SumaCen_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(167, 267);
            label6.Name = "label6";
            label6.Size = new Size(15, 15);
            label6.TabIndex = 12;
            label6.Text = "zł";
            // 
            // button_Ok
            // 
            button_Ok.Location = new Point(12, 313);
            button_Ok.Name = "button_Ok";
            button_Ok.Size = new Size(75, 23);
            button_Ok.TabIndex = 13;
            button_Ok.Text = "OK";
            button_Ok.UseVisualStyleBackColor = true;
            button_Ok.Click += button_Ok_Click;
            // 
            // button_Anuluj
            // 
            button_Anuluj.Location = new Point(107, 313);
            button_Anuluj.Name = "button_Anuluj";
            button_Anuluj.Size = new Size(75, 23);
            button_Anuluj.TabIndex = 14;
            button_Anuluj.Text = "Anuluj";
            button_Anuluj.UseVisualStyleBackColor = true;
            button_Anuluj.Click += button_Anuluj_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(196, 351);
            Controls.Add(button_Anuluj);
            Controls.Add(button_Ok);
            Controls.Add(label6);
            Controls.Add(label_SumaCen);
            Controls.Add(label4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(label_DyskWyb);
            Controls.Add(label3);
            Controls.Add(comboBox_Proc);
            Controls.Add(label2);
            Controls.Add(label_ProcWyb);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Komputer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_ProcWyb;
        private Label label2;
        private ComboBox comboBox_Proc;
        private Label label3;
        private Label label_DyskWyb;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label4;
        private Label label_SumaCen;
        private Label label6;
        private Button button_Ok;
        private Button button_Anuluj;
    }
}