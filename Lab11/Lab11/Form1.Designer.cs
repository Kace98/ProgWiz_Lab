namespace Lab11
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox_filter = new ComboBox();
            button1 = new Button();
            button_dodaj = new Button();
            button_edytuj = new Button();
            button_usun = new Button();
            button_generujQR = new Button();
            button_wczytaj = new Button();
            button_zapisz = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(545, 265);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 306);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(107, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 288);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 2;
            label1.Text = "Wyszukaj próbkę";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 339);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Filtrowanie";
            // 
            // comboBox_filter
            // 
            comboBox_filter.FormattingEnabled = true;
            comboBox_filter.Location = new Point(12, 357);
            comboBox_filter.Name = "comboBox_filter";
            comboBox_filter.Size = new Size(107, 23);
            comboBox_filter.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(12, 391);
            button1.Name = "button1";
            button1.Size = new Size(107, 32);
            button1.TabIndex = 5;
            button1.Text = "Filtruj/Wyszukaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button_dodaj
            // 
            button_dodaj.Location = new Point(177, 288);
            button_dodaj.Name = "button_dodaj";
            button_dodaj.Size = new Size(94, 41);
            button_dodaj.TabIndex = 6;
            button_dodaj.Text = "Dodaj próbkę";
            button_dodaj.UseVisualStyleBackColor = true;
            button_dodaj.Click += button_dodaj_Click;
            // 
            // button_edytuj
            // 
            button_edytuj.Location = new Point(177, 335);
            button_edytuj.Name = "button_edytuj";
            button_edytuj.Size = new Size(94, 41);
            button_edytuj.TabIndex = 7;
            button_edytuj.Text = "Edytuj próbkę";
            button_edytuj.UseVisualStyleBackColor = true;
            button_edytuj.Click += button_edytuj_Click;
            // 
            // button_usun
            // 
            button_usun.Location = new Point(177, 382);
            button_usun.Name = "button_usun";
            button_usun.Size = new Size(94, 41);
            button_usun.TabIndex = 8;
            button_usun.Text = "Usuń próbkę";
            button_usun.UseVisualStyleBackColor = true;
            button_usun.Click += button_usun_Click;
            // 
            // button_generujQR
            // 
            button_generujQR.Location = new Point(277, 288);
            button_generujQR.Name = "button_generujQR";
            button_generujQR.Size = new Size(94, 41);
            button_generujQR.TabIndex = 9;
            button_generujQR.Text = "Generuj kod QR";
            button_generujQR.UseVisualStyleBackColor = true;
            button_generujQR.Click += button_generujQR_Click;
            // 
            // button_wczytaj
            // 
            button_wczytaj.Location = new Point(277, 382);
            button_wczytaj.Name = "button_wczytaj";
            button_wczytaj.Size = new Size(94, 41);
            button_wczytaj.TabIndex = 13;
            button_wczytaj.Text = "Wczytaj z bazy danych";
            button_wczytaj.UseVisualStyleBackColor = true;
            button_wczytaj.Click += button_wczytaj_Click;
            // 
            // button_zapisz
            // 
            button_zapisz.Location = new Point(277, 335);
            button_zapisz.Name = "button_zapisz";
            button_zapisz.Size = new Size(94, 41);
            button_zapisz.TabIndex = 12;
            button_zapisz.Text = "Zapisz do bazy danych";
            button_zapisz.UseVisualStyleBackColor = true;
            button_zapisz.Click += button_zapisz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 439);
            Controls.Add(button_wczytaj);
            Controls.Add(button_zapisz);
            Controls.Add(button_generujQR);
            Controls.Add(button_usun);
            Controls.Add(button_edytuj);
            Controls.Add(button_dodaj);
            Controls.Add(button1);
            Controls.Add(comboBox_filter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Lab11";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox_filter;
        private Button button1;
        private Button button_dodaj;
        private Button button_edytuj;
        private Button button_usun;
        private Button button_generujQR;
        private Button button_wczytaj;
        private Button button_zapisz;
    }
}
