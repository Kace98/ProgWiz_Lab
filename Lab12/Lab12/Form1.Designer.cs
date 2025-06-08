namespace Lab12
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
            dataGridView_sesje = new DataGridView();
            button_utworzSesje = new Button();
            button_edytujSesje = new Button();
            button_usunSesje = new Button();
            button_wczytaj = new Button();
            button_zapisz = new Button();
            button_przegladaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_sesje).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_sesje
            // 
            dataGridView_sesje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_sesje.Location = new Point(12, 12);
            dataGridView_sesje.Name = "dataGridView_sesje";
            dataGridView_sesje.Size = new Size(291, 180);
            dataGridView_sesje.TabIndex = 0;
            // 
            // button_utworzSesje
            // 
            button_utworzSesje.Location = new Point(12, 198);
            button_utworzSesje.Name = "button_utworzSesje";
            button_utworzSesje.Size = new Size(132, 44);
            button_utworzSesje.TabIndex = 1;
            button_utworzSesje.Text = "Utwórz nową sesję";
            button_utworzSesje.UseVisualStyleBackColor = true;
            button_utworzSesje.Click += button_utworzSesje_Click;
            // 
            // button_edytujSesje
            // 
            button_edytujSesje.Location = new Point(12, 248);
            button_edytujSesje.Name = "button_edytujSesje";
            button_edytujSesje.Size = new Size(132, 44);
            button_edytujSesje.TabIndex = 2;
            button_edytujSesje.Text = "Edytuj sesję";
            button_edytujSesje.UseVisualStyleBackColor = true;
            button_edytujSesje.Click += button_edytujSesje_Click;
            // 
            // button_usunSesje
            // 
            button_usunSesje.Location = new Point(171, 248);
            button_usunSesje.Name = "button_usunSesje";
            button_usunSesje.Size = new Size(132, 44);
            button_usunSesje.TabIndex = 3;
            button_usunSesje.Text = "Usuń sesję";
            button_usunSesje.UseVisualStyleBackColor = true;
            button_usunSesje.Click += button_usunSesje_Click;
            // 
            // button_wczytaj
            // 
            button_wczytaj.Location = new Point(12, 298);
            button_wczytaj.Name = "button_wczytaj";
            button_wczytaj.Size = new Size(132, 44);
            button_wczytaj.TabIndex = 5;
            button_wczytaj.Text = "Wczytaj dane";
            button_wczytaj.UseVisualStyleBackColor = true;
            button_wczytaj.Click += button_wczytaj_Click;
            // 
            // button_zapisz
            // 
            button_zapisz.Location = new Point(171, 298);
            button_zapisz.Name = "button_zapisz";
            button_zapisz.Size = new Size(132, 44);
            button_zapisz.TabIndex = 6;
            button_zapisz.Text = "Zapisz dane";
            button_zapisz.UseVisualStyleBackColor = true;
            button_zapisz.Click += button_zapisz_Click;
            // 
            // button_przegladaj
            // 
            button_przegladaj.Location = new Point(171, 198);
            button_przegladaj.Name = "button_przegladaj";
            button_przegladaj.Size = new Size(132, 44);
            button_przegladaj.TabIndex = 7;
            button_przegladaj.Text = "Wyświetl szczegóły sesji";
            button_przegladaj.UseVisualStyleBackColor = true;
            button_przegladaj.Click += button_przegladaj_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 351);
            Controls.Add(button_przegladaj);
            Controls.Add(button_zapisz);
            Controls.Add(button_wczytaj);
            Controls.Add(button_usunSesje);
            Controls.Add(button_edytujSesje);
            Controls.Add(button_utworzSesje);
            Controls.Add(dataGridView_sesje);
            Name = "Form1";
            Text = "Notatnik bioinformatyczny";
            ((System.ComponentModel.ISupportInitialize)dataGridView_sesje).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_sesje;
        private Button button_utworzSesje;
        private Button button_edytujSesje;
        private Button button_usunSesje;
        private Button button_wczytaj;
        private Button button_zapisz;
        private Button button_przegladaj;
    }
}
