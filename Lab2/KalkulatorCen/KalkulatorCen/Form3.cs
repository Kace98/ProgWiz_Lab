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
    public partial class Form3 : Form
    {
        private Form1 parentForm;
        private decimal cenaMonitora = 0; // Tymczasowa zmienna na cenę monitora

        public Form3(Form1 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

            // Inicjalizacja ListView
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            // Dodanie kolumn
            listView1.Columns.Add("Nazwa", 200);
            listView1.Columns.Add("Cena", 100);

            // Dodanie monitorów do listy
            listView1.Items.Add(new ListViewItem(new string[] { "LG 24\" 75Hz", "800" }));
            listView1.Items.Add(new ListViewItem(new string[] { "LG 27\" 144Hz", "1200" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Samsung 32\" 165Hz", "1800" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Dell 27\" 165Hz", "1500" }));
            listView1.Items.Add(new ListViewItem(new string[] { "AOC 24\" 144Hz", "900" }));

            // Inicjalizacja etykiety
            label3.Text = "Nie wybrano monitora";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                cenaMonitora = decimal.Parse(listView1.SelectedItems[0].SubItems[1].Text);
                label3.Text = cenaMonitora.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Pusta metoda wymagana przez projektant formularza
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            // Sprawdzenie czy wybrano monitor
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Proszę wybrać monitor!", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aktualizacja ceny monitora w formularzu głównym
            parentForm.cenaMonitora = cenaMonitora;
            parentForm.AktualizujSumeCen();
            this.Close();
            parentForm.Show();
        }

        private void button_Anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Show();
        }
    }
}
