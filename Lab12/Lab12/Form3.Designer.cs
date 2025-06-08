namespace Lab12
{
    partial class Form3
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
            this.label_nazwa = new System.Windows.Forms.Label();
            this.textBox_nazwa = new System.Windows.Forms.TextBox();
            this.label_typ = new System.Windows.Forms.Label();
            this.comboBox_typ = new System.Windows.Forms.ComboBox();
            this.label_opis = new System.Windows.Forms.Label();
            this.textBox_opis = new System.Windows.Forms.TextBox();
            this.textBox_tresc = new System.Windows.Forms.TextBox();
            this.button_wybierzPlik = new System.Windows.Forms.Button();
            this.textBox_sciezkaPliku = new System.Windows.Forms.TextBox();
            this.button_zapisz = new System.Windows.Forms.Button();
            this.button_anuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nazwa
            // 
            this.label_nazwa.AutoSize = true;
            this.label_nazwa.Location = new System.Drawing.Point(12, 15);
            this.label_nazwa.Name = "label_nazwa";
            this.label_nazwa.Size = new System.Drawing.Size(43, 15);
            this.label_nazwa.TabIndex = 0;
            this.label_nazwa.Text = "Nazwa:";
            // 
            // textBox_nazwa
            // 
            this.textBox_nazwa.Location = new System.Drawing.Point(12, 33);
            this.textBox_nazwa.Name = "textBox_nazwa";
            this.textBox_nazwa.Size = new System.Drawing.Size(360, 23);
            this.textBox_nazwa.TabIndex = 1;
            // 
            // label_typ
            // 
            this.label_typ.AutoSize = true;
            this.label_typ.Location = new System.Drawing.Point(12, 69);
            this.label_typ.Name = "label_typ";
            this.label_typ.Size = new System.Drawing.Size(31, 15);
            this.label_typ.TabIndex = 2;
            this.label_typ.Text = "Typ:";
            // 
            // comboBox_typ
            // 
            this.comboBox_typ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_typ.FormattingEnabled = true;
            this.comboBox_typ.Location = new System.Drawing.Point(12, 87);
            this.comboBox_typ.Name = "comboBox_typ";
            this.comboBox_typ.Size = new System.Drawing.Size(360, 23);
            this.comboBox_typ.TabIndex = 3;
            this.comboBox_typ.SelectedIndexChanged += new System.EventHandler(this.comboBox_typ_SelectedIndexChanged);
            // 
            // label_opis
            // 
            this.label_opis.AutoSize = true;
            this.label_opis.Location = new System.Drawing.Point(12, 123);
            this.label_opis.Name = "label_opis";
            this.label_opis.Size = new System.Drawing.Size(35, 15);
            this.label_opis.TabIndex = 4;
            this.label_opis.Text = "Opis:";
            // 
            // textBox_opis
            // 
            this.textBox_opis.Location = new System.Drawing.Point(12, 141);
            this.textBox_opis.Multiline = true;
            this.textBox_opis.Name = "textBox_opis";
            this.textBox_opis.Size = new System.Drawing.Size(360, 60);
            this.textBox_opis.TabIndex = 5;
            // 
            // textBox_tresc
            // 
            this.textBox_tresc.Location = new System.Drawing.Point(12, 220);
            this.textBox_tresc.Multiline = true;
            this.textBox_tresc.Name = "textBox_tresc";
            this.textBox_tresc.Size = new System.Drawing.Size(360, 100);
            this.textBox_tresc.TabIndex = 6;
            // 
            // button_wybierzPlik
            // 
            this.button_wybierzPlik.Location = new System.Drawing.Point(12, 220);
            this.button_wybierzPlik.Name = "button_wybierzPlik";
            this.button_wybierzPlik.Size = new System.Drawing.Size(100, 23);
            this.button_wybierzPlik.TabIndex = 7;
            this.button_wybierzPlik.Text = "Wybierz plik";
            this.button_wybierzPlik.UseVisualStyleBackColor = true;
            this.button_wybierzPlik.Click += new System.EventHandler(this.button_wybierzPlik_Click);
            // 
            // textBox_sciezkaPliku
            // 
            this.textBox_sciezkaPliku.Location = new System.Drawing.Point(118, 220);
            this.textBox_sciezkaPliku.Name = "textBox_sciezkaPliku";
            this.textBox_sciezkaPliku.ReadOnly = true;
            this.textBox_sciezkaPliku.Size = new System.Drawing.Size(254, 23);
            this.textBox_sciezkaPliku.TabIndex = 8;
            // 
            // button_zapisz
            // 
            this.button_zapisz.Location = new System.Drawing.Point(12, 340);
            this.button_zapisz.Name = "button_zapisz";
            this.button_zapisz.Size = new System.Drawing.Size(175, 30);
            this.button_zapisz.TabIndex = 9;
            this.button_zapisz.Text = "Zapisz";
            this.button_zapisz.UseVisualStyleBackColor = true;
            this.button_zapisz.Click += new System.EventHandler(this.button_zapisz_Click);
            // 
            // button_anuluj
            // 
            this.button_anuluj.Location = new System.Drawing.Point(197, 340);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(175, 30);
            this.button_anuluj.TabIndex = 10;
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.UseVisualStyleBackColor = true;
            this.button_anuluj.Click += new System.EventHandler(this.button_anuluj_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 382);
            this.Controls.Add(this.button_anuluj);
            this.Controls.Add(this.button_zapisz);
            this.Controls.Add(this.textBox_sciezkaPliku);
            this.Controls.Add(this.button_wybierzPlik);
            this.Controls.Add(this.textBox_tresc);
            this.Controls.Add(this.textBox_opis);
            this.Controls.Add(this.label_opis);
            this.Controls.Add(this.comboBox_typ);
            this.Controls.Add(this.label_typ);
            this.Controls.Add(this.textBox_nazwa);
            this.Controls.Add(this.label_nazwa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj wpis";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_nazwa;
        private System.Windows.Forms.TextBox textBox_nazwa;
        private System.Windows.Forms.Label label_typ;
        private System.Windows.Forms.ComboBox comboBox_typ;
        private System.Windows.Forms.Label label_opis;
        private System.Windows.Forms.TextBox textBox_opis;
        private System.Windows.Forms.TextBox textBox_tresc;
        private System.Windows.Forms.Button button_wybierzPlik;
        private System.Windows.Forms.TextBox textBox_sciezkaPliku;
        private System.Windows.Forms.Button button_zapisz;
        private System.Windows.Forms.Button button_anuluj;
    }
} 