namespace Lab12
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
            button_dodaj = new Button();
            dataGridView_wpisy = new DataGridView();
            label1 = new Label();
            textBox_tytul = new TextBox();
            label2 = new Label();
            dateTimePicker_utworzenie = new DateTimePicker();
            button_usun = new Button();
            button_wyświetl = new Button();
            button_edytuj = new Button();
            button_eksportuj = new Button();
            button_zapisz = new Button();
            button_odrzuc = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_wpisy).BeginInit();
            SuspendLayout();
            // 
            // button_dodaj
            // 
            button_dodaj.Location = new Point(12, 234);
            button_dodaj.Name = "button_dodaj";
            button_dodaj.Size = new Size(132, 44);
            button_dodaj.TabIndex = 2;
            button_dodaj.Text = "Dodaj element";
            button_dodaj.UseVisualStyleBackColor = true;
            button_dodaj.Click += button_dodaj_Click;
            // 
            // dataGridView_wpisy
            // 
            dataGridView_wpisy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_wpisy.Location = new Point(12, 78);
            dataGridView_wpisy.Name = "dataGridView_wpisy";
            dataGridView_wpisy.Size = new Size(361, 150);
            dataGridView_wpisy.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 4;
            label1.Text = "TYTUŁ SESJI";
            // 
            // textBox_tytul
            // 
            textBox_tytul.Location = new Point(12, 40);
            textBox_tytul.Name = "textBox_tytul";
            textBox_tytul.PlaceholderText = "Wprowadź tytuł sesji";
            textBox_tytul.Size = new Size(115, 23);
            textBox_tytul.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(185, 9);
            label2.Name = "label2";
            label2.Size = new Size(169, 28);
            label2.TabIndex = 6;
            label2.Text = "DATA UTORZENIA";
            // 
            // dateTimePicker_utworzenie
            // 
            dateTimePicker_utworzenie.Location = new Point(155, 40);
            dateTimePicker_utworzenie.Name = "dateTimePicker_utworzenie";
            dateTimePicker_utworzenie.Size = new Size(218, 23);
            dateTimePicker_utworzenie.TabIndex = 7;
            // 
            // button_usun
            // 
            button_usun.Location = new Point(241, 284);
            button_usun.Name = "button_usun";
            button_usun.Size = new Size(132, 44);
            button_usun.TabIndex = 8;
            button_usun.Text = "Usuń element";
            button_usun.UseVisualStyleBackColor = true;
            button_usun.Click += button_usun_Click;
            // 
            // button_wyświetl
            // 
            button_wyświetl.Location = new Point(241, 234);
            button_wyświetl.Name = "button_wyświetl";
            button_wyświetl.Size = new Size(132, 44);
            button_wyświetl.TabIndex = 9;
            button_wyświetl.Text = "Wyświetl szczegóły wpisu";
            button_wyświetl.UseVisualStyleBackColor = true;
            button_wyświetl.Click += button_wyświetl_Click;
            // 
            // button_edytuj
            // 
            button_edytuj.Location = new Point(12, 284);
            button_edytuj.Name = "button_edytuj";
            button_edytuj.Size = new Size(132, 44);
            button_edytuj.TabIndex = 10;
            button_edytuj.Text = "Edytuj element";
            button_edytuj.UseVisualStyleBackColor = true;
            button_edytuj.Click += button_edytuj_Click;
            // 
            // button_eksportuj
            // 
            button_eksportuj.Location = new Point(12, 384);
            button_eksportuj.Name = "button_eksportuj";
            button_eksportuj.Size = new Size(361, 44);
            button_eksportuj.TabIndex = 11;
            button_eksportuj.Text = "Eksportuj do PDF";
            button_eksportuj.UseVisualStyleBackColor = true;
            button_eksportuj.Click += button_eksportuj_Click;
            // 
            // button_zapisz
            // 
            button_zapisz.Location = new Point(12, 334);
            button_zapisz.Name = "button_zapisz";
            button_zapisz.Size = new Size(132, 44);
            button_zapisz.TabIndex = 12;
            button_zapisz.Text = "Zapisz zmiany";
            button_zapisz.UseVisualStyleBackColor = true;
            button_zapisz.Click += button_zapisz_Click;
            // 
            // button_odrzuc
            // 
            button_odrzuc.Location = new Point(241, 334);
            button_odrzuc.Name = "button_odrzuc";
            button_odrzuc.Size = new Size(132, 44);
            button_odrzuc.TabIndex = 13;
            button_odrzuc.Text = "Odrzuć zmiany";
            button_odrzuc.UseVisualStyleBackColor = true;
            button_odrzuc.Click += button_odrzuc_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 435);
            Controls.Add(button_odrzuc);
            Controls.Add(button_zapisz);
            Controls.Add(button_eksportuj);
            Controls.Add(button_edytuj);
            Controls.Add(button_wyświetl);
            Controls.Add(button_usun);
            Controls.Add(dateTimePicker_utworzenie);
            Controls.Add(label2);
            Controls.Add(textBox_tytul);
            Controls.Add(label1);
            Controls.Add(dataGridView_wpisy);
            Controls.Add(button_dodaj);
            Name = "Form2";
            Text = "Sesja";
            ((System.ComponentModel.ISupportInitialize)dataGridView_wpisy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_dodaj;
        private DataGridView dataGridView_wpisy;
        private Label label1;
        private TextBox textBox_tytul;
        private Label label2;
        private DateTimePicker dateTimePicker_utworzenie;
        private Button button_usun;
        private Button button_wyświetl;
        private Button button_edytuj;
        private Button button_eksportuj;
        private Button button_zapisz;
        private Button button_odrzuc;
    }
}