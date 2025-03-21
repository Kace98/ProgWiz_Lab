using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorCen
{
    public partial class Form2 : Form
    {
        private Form1 parentForm;
        private decimal cenaProcesora = 0; // Tymczasowa zmienna na cenę procesora
        private decimal cenaDysku = 0; // Tymczasowa zmienna na cenę dysku

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.parentForm = form1;
            
            // Inicjalizacja ComboBox z procesorami
            comboBox_Proc.Items.AddRange(new string[] {
                "Intel Core i3-12100F",
                "Intel Core i5-12400F",
                "Intel Core i7-12700F",
                "AMD Ryzen 5 5600X",
                "AMD Ryzen 7 5800X"
            });

            // Ustawienie domyślnego tekstu
            comboBox_Proc.Text = "Wybierz procesor...";

            // Ustawienie tekstu dla radio buttonów
            radioButton1.Text = "SSD 256GB";
            radioButton2.Text = "SSD 512GB";
            radioButton3.Text = "SSD 1TB";

            // Inicjalizacja etykiet
            label_ProcWyb.Text = "Nie wybrano procesora";
            label_DyskWyb.Text = "Nie wybrano dysku";
            AktualizujSumeCen();
        }

        private void AktualizujSumeCen()
        {
            label_SumaCen.Text = $"{cenaProcesora + cenaDysku} zł";
        }

        private void label_ProcWyb_Click(object sender, EventArgs e)
        {
            // Pusta metoda wymagana przez projektant formularza
        }

        private void comboBox_Proc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Proc.SelectedItem != null)
            {
                string wybranyProcesor = comboBox_Proc.SelectedItem.ToString();
                
                // Aktualizacja ceny procesora
                switch (wybranyProcesor)
                {
                    case "Intel Core i3-12100F":
                        cenaProcesora = 800;
                        break;
                    case "Intel Core i5-12400F":
                        cenaProcesora = 1200;
                        break;
                    case "Intel Core i7-12700F":
                        cenaProcesora = 1800;
                        break;
                    case "AMD Ryzen 5 5600X":
                        cenaProcesora = 1000;
                        break;
                    case "AMD Ryzen 7 5800X":
                        cenaProcesora = 1600;
                        break;
                }
                
                // Aktualizacja etykiety z informacją o wyborze
                label_ProcWyb.Text = cenaProcesora.ToString();
                AktualizujSumeCen();
            }
        }

        private void label_DyskWyb_Click(object sender, EventArgs e)
        {
            // Pusta metoda wymagana przez projektant formularza
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cenaDysku = 200;
                label_DyskWyb.Text = cenaDysku.ToString();
                AktualizujSumeCen();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cenaDysku = 350;
                label_DyskWyb.Text = cenaDysku.ToString();
                AktualizujSumeCen();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                cenaDysku = 600;
                label_DyskWyb.Text = cenaDysku.ToString();
                AktualizujSumeCen();
            }
        }

        private void label_SumaCen_Click(object sender, EventArgs e)
        {
            // Pusta metoda wymagana przez projektant formularza
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            // Sprawdzenie czy wybrano procesor
            if (comboBox_Proc.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać procesor!", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sprawdzenie czy wybrano dysk
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Proszę wybrać dysk!", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aktualizacja ceny komputera w formularzu głównym (suma procesora i dysku)
            parentForm.cenaKomputera = cenaProcesora + cenaDysku;
            parentForm.AktualizujSumeCen(); // Aktualizacja sumy cen w formularzu głównym
            this.Close();
            this.parentForm.Show();
        }

        private void button_Anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parentForm.Show();
        }
    }
}
