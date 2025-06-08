using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Lab12
{
    public partial class Form3 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Wpis NowyWpis { get; private set; } = new Wpis();

        private bool trybEdycji = false;

        public Form3()
        {
            InitializeComponent();
            comboBox_typ.Items.AddRange(new string[] { "Tekstowy", "Załącznik" });
            comboBox_typ.SelectedIndex = 0;
            UpdateControlsVisibility();
        }

        public Form3(Wpis wpisDoEdycji) : this()
        {
            trybEdycji = true;
            NowyWpis = wpisDoEdycji;
            
            // Wypełniamy pola formularza
            textBox_nazwa.Text = wpisDoEdycji.Nazwa;
            comboBox_typ.SelectedItem = wpisDoEdycji.Typ;
            textBox_opis.Text = wpisDoEdycji.Opis;

            if (wpisDoEdycji.Typ == "Tekstowy")
            {
                textBox_tresc.Text = wpisDoEdycji.Tresc;
            }
            else
            {
                textBox_sciezkaPliku.Text = wpisDoEdycji.SciezkaPliku;
            }

            this.Text = "Edytuj wpis";
            button_zapisz.Text = "Zapisz zmiany";
        }

        private void comboBox_typ_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControlsVisibility();
        }

        private void UpdateControlsVisibility()
        {
            bool isZałącznik = comboBox_typ.SelectedItem.ToString() == "Załącznik";
            textBox_tresc.Visible = !isZałącznik;
            button_wybierzPlik.Visible = isZałącznik;
            textBox_sciezkaPliku.Visible = isZałącznik;
        }

        private void button_wybierzPlik_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pliki FASTA|*.fasta|Pliki CSV|*.csv|Pliki PNG|*.png|Wszystkie pliki|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox_sciezkaPliku.Text = openFileDialog.FileName;
                }
            }
        }

        private void button_zapisz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_nazwa.Text))
            {
                MessageBox.Show("Proszę podać nazwę wpisu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NowyWpis.Nazwa = textBox_nazwa.Text;
            NowyWpis.Typ = comboBox_typ.SelectedItem.ToString();
            NowyWpis.Opis = textBox_opis.Text;

            if (NowyWpis.Typ == "Załącznik")
            {
                if (string.IsNullOrWhiteSpace(textBox_sciezkaPliku.Text))
                {
                    MessageBox.Show("Proszę wybrać plik!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                NowyWpis.SciezkaPliku = textBox_sciezkaPliku.Text;
            }
            else
            {
                NowyWpis.Tresc = textBox_tresc.Text;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
} 