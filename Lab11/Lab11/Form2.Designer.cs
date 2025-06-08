namespace Lab11
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label_nazwa = new System.Windows.Forms.Label();
            this.textBox_nazwa = new System.Windows.Forms.TextBox();
            this.label_typ = new System.Windows.Forms.Label();
            this.comboBox_typ = new System.Windows.Forms.ComboBox();
            this.label_data = new System.Windows.Forms.Label();
            this.dateTimePicker_data = new System.Windows.Forms.DateTimePicker();
            this.label_opis = new System.Windows.Forms.Label();
            this.textBox_opis = new System.Windows.Forms.TextBox();
            this.button_zapisz = new System.Windows.Forms.Button();
            this.button_anuluj = new System.Windows.Forms.Button();

            // label_nazwa
            this.label_nazwa.AutoSize = true;
            this.label_nazwa.Location = new System.Drawing.Point(12, 15);
            this.label_nazwa.Name = "label_nazwa";
            this.label_nazwa.Size = new System.Drawing.Size(43, 13);
            this.label_nazwa.Text = "Nazwa:";

            // textBox_nazwa
            this.textBox_nazwa.Location = new System.Drawing.Point(120, 12);
            this.textBox_nazwa.Name = "textBox_nazwa";
            this.textBox_nazwa.Size = new System.Drawing.Size(200, 20);

            // label_typ
            this.label_typ.AutoSize = true;
            this.label_typ.Location = new System.Drawing.Point(12, 45);
            this.label_typ.Name = "label_typ";
            this.label_typ.Size = new System.Drawing.Size(28, 13);
            this.label_typ.Text = "Typ:";

            // comboBox_typ
            this.comboBox_typ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_typ.FormattingEnabled = true;
            this.comboBox_typ.Location = new System.Drawing.Point(120, 42);
            this.comboBox_typ.Name = "comboBox_typ";
            this.comboBox_typ.Size = new System.Drawing.Size(200, 21);

            // label_data
            this.label_data.AutoSize = true;
            this.label_data.Location = new System.Drawing.Point(12, 75);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(72, 13);
            this.label_data.Text = "Data pobrania:";

            // dateTimePicker_data
            this.dateTimePicker_data.Location = new System.Drawing.Point(120, 72);
            this.dateTimePicker_data.Name = "dateTimePicker_data";
            this.dateTimePicker_data.Size = new System.Drawing.Size(200, 20);

            // label_opis
            this.label_opis.AutoSize = true;
            this.label_opis.Location = new System.Drawing.Point(12, 105);
            this.label_opis.Name = "label_opis";
            this.label_opis.Size = new System.Drawing.Size(31, 13);
            this.label_opis.Text = "Opis:";

            // textBox_opis
            this.textBox_opis.Location = new System.Drawing.Point(120, 102);
            this.textBox_opis.Multiline = true;
            this.textBox_opis.Name = "textBox_opis";
            this.textBox_opis.Size = new System.Drawing.Size(200, 60);

            // button_zapisz
            this.button_zapisz.Location = new System.Drawing.Point(120, 180);
            this.button_zapisz.Name = "button_zapisz";
            this.button_zapisz.Size = new System.Drawing.Size(75, 23);
            this.button_zapisz.Text = "Zapisz";
            this.button_zapisz.Click += new System.EventHandler(this.button_zapisz_Click);

            // button_anuluj
            this.button_anuluj.Location = new System.Drawing.Point(245, 180);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(75, 23);
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.Click += new System.EventHandler(this.button_anuluj_Click);

            // Form2
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 221);
            this.Controls.Add(this.button_anuluj);
            this.Controls.Add(this.button_zapisz);
            this.Controls.Add(this.textBox_opis);
            this.Controls.Add(this.label_opis);
            this.Controls.Add(this.dateTimePicker_data);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.comboBox_typ);
            this.Controls.Add(this.label_typ);
            this.Controls.Add(this.textBox_nazwa);
            this.Controls.Add(this.label_nazwa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj próbkę";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label_nazwa;
        private System.Windows.Forms.TextBox textBox_nazwa;
        private System.Windows.Forms.Label label_typ;
        private System.Windows.Forms.ComboBox comboBox_typ;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data;
        private System.Windows.Forms.Label label_opis;
        private System.Windows.Forms.TextBox textBox_opis;
        private System.Windows.Forms.Button button_zapisz;
        private System.Windows.Forms.Button button_anuluj;
    }
} 