using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Lab12
{
    public partial class Form4 : Form
    {
        private Wpis wpis;

        public Form4(Wpis wpis)
        {
            InitializeComponent();
            this.wpis = wpis;
            this.Text = $"Podgląd wpisu: {wpis.Nazwa}";
            InitializeView();
        }

        private void InitializeView()
        {
            if (wpis.Typ == "Tekstowy")
            {
                textBox_tresc.Visible = true;
                pictureBox_podglad.Visible = false;
                textBox_tresc.Text = wpis.Tresc;
                textBox_tresc.ReadOnly = true;
            }
            else // Załącznik
            {
                if (File.Exists(wpis.SciezkaPliku))
                {
                    string extension = Path.GetExtension(wpis.SciezkaPliku).ToLower();
                    if (extension == ".png")
                    {
                        try
                        {
                            textBox_tresc.Visible = false;
                            pictureBox_podglad.Visible = true;
                            pictureBox_podglad.Image = Image.FromFile(wpis.SciezkaPliku);
                            pictureBox_podglad.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Nie można załadować obrazu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (extension == ".fasta" || extension == ".csv")
                    {
                        try
                        {
                            textBox_tresc.Visible = true;
                            pictureBox_podglad.Visible = false;
                            textBox_tresc.Text = File.ReadAllText(wpis.SciezkaPliku);
                            textBox_tresc.ReadOnly = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Nie można odczytać pliku: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nie znaleziono pliku załącznika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_zamknij_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
} 