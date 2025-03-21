using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProjektGridView
{
    public partial class Form2 : Form
    {
        private readonly Regex regexWiek = new Regex(@"^[0-9]{1,3}$");

        public Form2()
        {
            InitializeComponent();
            KonfigurujFormularz();
        }

        private void KonfigurujFormularz()
        {
            // Konfiguracja pól tekstowych
            textBox1.Name = "txtImie";
            textBox2.Name = "txtNazwisko";
            textBox3.Name = "txtWiek";
            textBox3.MaxLength = 3; // Maksymalna długość pola wieku

            // Konfiguracja ComboBox
            comboBox1.Name = "cmbStanowisko";
            comboBox1.Items.AddRange(new string[] {
                "Programista",
                "Projektant",
                "Manager",
                "Analityk",
                "Tester"
            });

            // Konfiguracja przycisków
            button_Zatwierdz.DialogResult = DialogResult.OK;
            button_Anuluj.DialogResult = DialogResult.Cancel;
        }

        public string[] GetDane()
        {
            return new string[] {
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                comboBox1.Text
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                if (!regexWiek.IsMatch(textBox3.Text))
                {
                    textBox3.Text = textBox3.Text.Substring(0, textBox3.Text.Length - 1);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Zatwierdz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || 
                string.IsNullOrWhiteSpace(textBox2.Text) || 
                string.IsNullOrWhiteSpace(textBox3.Text) || 
                string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }

        private void button_Anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
