namespace GdzieJestDydelf
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button_OK = new Button();
            button_Anuluj = new Button();
            numericUpDown_OsX = new NumericUpDown();
            numericUpDown_OsY = new NumericUpDown();
            numericUpDown_Dedelfy = new NumericUpDown();
            numericUpDown_Krokodyle = new NumericUpDown();
            numericUpDown_Szopy = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            textBox_Czas = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_OsX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_OsY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Dedelfy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Krokodyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Szopy).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(84, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 1;
            label1.Text = "PLANSZA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(54, 44);
            label2.Name = "label2";
            label2.Size = new Size(24, 28);
            label2.TabIndex = 3;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(53, 84);
            label3.Name = "label3";
            label3.Size = new Size(23, 28);
            label3.TabIndex = 4;
            label3.Text = "Y";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(84, 144);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 12;
            label4.Text = "DYDELFY";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(70, 212);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 13;
            label5.Text = "KROKODYLE";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(84, 280);
            label6.Name = "label6";
            label6.Size = new Size(96, 28);
            label6.TabIndex = 14;
            label6.Text = "SZOPY";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_OK
            // 
            button_OK.Font = new Font("Segoe UI", 15F);
            button_OK.Location = new Point(12, 496);
            button_OK.Name = "button_OK";
            button_OK.Size = new Size(111, 34);
            button_OK.TabIndex = 15;
            button_OK.Text = "OK";
            button_OK.UseVisualStyleBackColor = true;
            button_OK.Click += button_OK_Click;
            // 
            // button_Anuluj
            // 
            button_Anuluj.Font = new Font("Segoe UI", 15F);
            button_Anuluj.Location = new Point(138, 496);
            button_Anuluj.Name = "button_Anuluj";
            button_Anuluj.Size = new Size(109, 34);
            button_Anuluj.TabIndex = 16;
            button_Anuluj.Text = "ANULUJ";
            button_Anuluj.UseVisualStyleBackColor = true;
            button_Anuluj.Click += button_Anuluj_Click;
            // 
            // numericUpDown_OsX
            // 
            numericUpDown_OsX.Font = new Font("Segoe UI", 15F);
            numericUpDown_OsX.Location = new Point(84, 42);
            numericUpDown_OsX.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown_OsX.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown_OsX.Name = "numericUpDown_OsX";
            numericUpDown_OsX.Size = new Size(97, 34);
            numericUpDown_OsX.TabIndex = 17;
            numericUpDown_OsX.TextAlign = HorizontalAlignment.Center;
            numericUpDown_OsX.Value = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown_OsX.ValueChanged += numericUpDown_OsX_ValueChanged;
            // 
            // numericUpDown_OsY
            // 
            numericUpDown_OsY.Font = new Font("Segoe UI", 15F);
            numericUpDown_OsY.Location = new Point(82, 82);
            numericUpDown_OsY.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown_OsY.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown_OsY.Name = "numericUpDown_OsY";
            numericUpDown_OsY.Size = new Size(97, 34);
            numericUpDown_OsY.TabIndex = 18;
            numericUpDown_OsY.TextAlign = HorizontalAlignment.Center;
            numericUpDown_OsY.Value = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown_OsY.ValueChanged += numericUpDown_OsY_ValueChanged;
            // 
            // numericUpDown_Dedelfy
            // 
            numericUpDown_Dedelfy.Font = new Font("Segoe UI", 15F);
            numericUpDown_Dedelfy.Location = new Point(83, 175);
            numericUpDown_Dedelfy.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown_Dedelfy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Dedelfy.Name = "numericUpDown_Dedelfy";
            numericUpDown_Dedelfy.Size = new Size(97, 34);
            numericUpDown_Dedelfy.TabIndex = 19;
            numericUpDown_Dedelfy.TextAlign = HorizontalAlignment.Center;
            numericUpDown_Dedelfy.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown_Dedelfy.ValueChanged += numericUpDown_Dedelfy_ValueChanged;
            // 
            // numericUpDown_Krokodyle
            // 
            numericUpDown_Krokodyle.Font = new Font("Segoe UI", 15F);
            numericUpDown_Krokodyle.Location = new Point(82, 243);
            numericUpDown_Krokodyle.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Krokodyle.Name = "numericUpDown_Krokodyle";
            numericUpDown_Krokodyle.Size = new Size(97, 34);
            numericUpDown_Krokodyle.TabIndex = 20;
            numericUpDown_Krokodyle.TextAlign = HorizontalAlignment.Center;
            numericUpDown_Krokodyle.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Krokodyle.ValueChanged += numericUpDown_Krokodyle_ValueChanged;
            // 
            // numericUpDown_Szopy
            // 
            numericUpDown_Szopy.Font = new Font("Segoe UI", 15F);
            numericUpDown_Szopy.Location = new Point(82, 311);
            numericUpDown_Szopy.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDown_Szopy.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown_Szopy.Name = "numericUpDown_Szopy";
            numericUpDown_Szopy.Size = new Size(97, 34);
            numericUpDown_Szopy.TabIndex = 21;
            numericUpDown_Szopy.TextAlign = HorizontalAlignment.Center;
            numericUpDown_Szopy.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown_Szopy.ValueChanged += numericUpDown_Szopy_ValueChanged;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(82, 376);
            label7.Name = "label7";
            label7.Size = new Size(96, 28);
            label7.TabIndex = 22;
            label7.Text = "CZAS";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(82, 404);
            label8.Name = "label8";
            label8.Size = new Size(96, 19);
            label8.TabIndex = 23;
            label8.Text = "( 10 - 60 )";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Czas
            // 
            textBox_Czas.Font = new Font("Segoe UI", 15F);
            textBox_Czas.Location = new Point(84, 426);
            textBox_Czas.Name = "textBox_Czas";
            textBox_Czas.Size = new Size(97, 34);
            textBox_Czas.TabIndex = 24;
            textBox_Czas.Text = "35";
            textBox_Czas.TextAlign = HorizontalAlignment.Center;
            textBox_Czas.TextChanged += textBox_Czas_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 542);
            Controls.Add(textBox_Czas);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(numericUpDown_Szopy);
            Controls.Add(numericUpDown_Krokodyle);
            Controls.Add(numericUpDown_Dedelfy);
            Controls.Add(numericUpDown_OsY);
            Controls.Add(numericUpDown_OsX);
            Controls.Add(button_Anuluj);
            Controls.Add(button_OK);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "USTAWIENIA";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_OsX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_OsY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Dedelfy).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Krokodyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Szopy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button_OK;
        private Button button_Anuluj;
        private NumericUpDown numericUpDown_OsX;
        private NumericUpDown numericUpDown_OsY;
        private NumericUpDown numericUpDown_Dedelfy;
        private NumericUpDown numericUpDown_Krokodyle;
        private NumericUpDown numericUpDown_Szopy;
        private Label label7;
        private Label label8;
        private TextBox textBox_Czas;
    }
}