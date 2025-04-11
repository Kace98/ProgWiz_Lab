using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GdzieJestDydelf
{
    public partial class Form2 : Form
    {
        private int dostepnePola;
        private int sumaObiektow;
        private int maxPola;
        private Form1 parent;

        public Form2(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            PrzeliczPola();
            textBox_Czas.Leave += textBox_Czas_Leave;
            textBox_DostepnePola.ReadOnly = true;
        }

        private void PrzeliczPola()
        {
            maxPola = (int)(numericUpDown_OsX.Value * numericUpDown_OsY.Value);
            sumaObiektow = (int)(numericUpDown_Dedelfy.Value + numericUpDown_Krokodyle.Value + numericUpDown_Szopy.Value);
            dostepnePola = maxPola - sumaObiektow;
            textBox_DostepnePola.Text = dostepnePola.ToString();
        }

        private void numericUpDown_OsX_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_Dedelfy.Value = numericUpDown_Dedelfy.Minimum;
            numericUpDown_Krokodyle.Value = numericUpDown_Krokodyle.Minimum;
            numericUpDown_Szopy.Value = numericUpDown_Szopy.Minimum;
            PrzeliczPola();
        }

        private void numericUpDown_OsY_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_Dedelfy.Value = numericUpDown_Dedelfy.Minimum;
            numericUpDown_Krokodyle.Value = numericUpDown_Krokodyle.Minimum;
            numericUpDown_Szopy.Value = numericUpDown_Szopy.Minimum;
            PrzeliczPola();
        }

        private void numericUpDown_Dedelfy_ValueChanged(object sender, EventArgs e)
        {
            sumaObiektow = (int)(numericUpDown_Dedelfy.Value + numericUpDown_Krokodyle.Value + numericUpDown_Szopy.Value);
            if (sumaObiektow > maxPola)
            {
                numericUpDown_Dedelfy.Value = maxPola - (int)(numericUpDown_Krokodyle.Value + numericUpDown_Szopy.Value);
            }
            PrzeliczPola();
        }

        private void numericUpDown_Krokodyle_ValueChanged(object sender, EventArgs e)
        {
            sumaObiektow = (int)(numericUpDown_Dedelfy.Value + numericUpDown_Krokodyle.Value + numericUpDown_Szopy.Value);
            if (sumaObiektow > maxPola)
            {
                numericUpDown_Krokodyle.Value = maxPola - (int)(numericUpDown_Dedelfy.Value + numericUpDown_Szopy.Value);
            }
            PrzeliczPola();
        }

        private void numericUpDown_Szopy_ValueChanged(object sender, EventArgs e)
        {
            sumaObiektow = (int)(numericUpDown_Dedelfy.Value + numericUpDown_Krokodyle.Value + numericUpDown_Szopy.Value);
            if (sumaObiektow > maxPola)
            {
                numericUpDown_Szopy.Value = maxPola - (int)(numericUpDown_Dedelfy.Value + numericUpDown_Krokodyle.Value);
            }
            PrzeliczPola();
        }

        private void textBox_Czas_TextChanged(object sender, EventArgs e)
        {
            // Pozostawiamy puste, aby nie blokować wprowadzania
        }

        private void textBox_Czas_Leave(object sender, EventArgs e)
        {
            // Sprawdź, czy wprowadzona wartość jest liczbą
            if (int.TryParse(textBox_Czas.Text, out int czas))
            {
                // Ogranicz wartość do zakresu 10-60
                if (czas < 10)
                {
                    textBox_Czas.Text = "10";
                }
                else if (czas > 60)
                {
                    textBox_Czas.Text = "60";
                }
            }
            else if (!string.IsNullOrEmpty(textBox_Czas.Text))
            {
                // Jeśli wprowadzono nieprawidłową wartość, wyczyść pole
                textBox_Czas.Text = "";
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            // Zapisz ustawienia do formularza głównego
            parent.OsX = (int)numericUpDown_OsX.Value;
            parent.OsY = (int)numericUpDown_OsY.Value;
            parent.Dydelfy = (int)numericUpDown_Dedelfy.Value;
            parent.Krokodyle = (int)numericUpDown_Krokodyle.Value;
            parent.Szopy = (int)numericUpDown_Szopy.Value;
            parent.Czas = int.Parse(textBox_Czas.Text);

            // Zamknij formularz ustawień i pokaż główny
            this.Close();
            parent.Show();
        }

        private void button_Anuluj_Click(object sender, EventArgs e)
        {
            // Zamknij formularz ustawień bez zapisywania zmian
            this.Close();
            parent.Show();
        }
    }
}
