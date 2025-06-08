using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public partial class Form2 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TytulSesji { get; private set; } = string.Empty;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime DataUtworzenia { get; private set; } = DateTime.Now;

        private Sesja aktualnaSesja = new Sesja();
        private Sesja oryginalnaSesja = null;
        private bool trybEdycji = false;
        private bool trybPrzegladania = false;

        public Form2()
        {
            InitializeComponent();
            dateTimePicker_utworzenie.Enabled = false;
            dateTimePicker_utworzenie.Value = DateTime.Now;
            InitializeDataGridView();
        }

        public Form2(Sesja sesjaDoEdycji)
            : this()
        {
            if (sesjaDoEdycji != null)
            {
                trybEdycji = true;
                oryginalnaSesja = sesjaDoEdycji;
                // Tworzymy głęboką kopię sesji i wpisów
                aktualnaSesja = new Sesja
                {
                    Tytul = sesjaDoEdycji.Tytul,
                    DataUtworzenia = sesjaDoEdycji.DataUtworzenia,
                    Wpisy = sesjaDoEdycji.Wpisy.Select(w => new Wpis
                    {
                        Nazwa = w.Nazwa,
                        DataDodania = w.DataDodania,
                        Typ = w.Typ,
                        Opis = w.Opis,
                        SciezkaPliku = w.SciezkaPliku,
                        Tresc = w.Tresc
                    }).ToList(),
                    PlikiZalaczniki = new List<string>(sesjaDoEdycji.PlikiZalaczniki)
                };
                textBox_tytul.Text = aktualnaSesja.Tytul;
                dateTimePicker_utworzenie.Value = aktualnaSesja.DataUtworzenia;
                dataGridView_wpisy.Rows.Clear();
                foreach (var wpis in aktualnaSesja.Wpisy)
                {
                    dataGridView_wpisy.Rows.Add(
                        wpis.Nazwa,
                        wpis.DataDodania.ToString("dd.MM.yyyy HH:mm"),
                        wpis.Typ,
                        wpis.Opis
                    );
                }
            }
        }

        private void InitializeDataGridView()
        {
            dataGridView_wpisy.Columns.Add("Nazwa", "Nazwa");
            dataGridView_wpisy.Columns.Add("DataDodania", "Data dodania");
            dataGridView_wpisy.Columns.Add("Typ", "Typ");
            dataGridView_wpisy.Columns.Add("Opis", "Opis");
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (form3.ShowDialog() == DialogResult.OK)
            {
                aktualnaSesja.Wpisy.Add(form3.NowyWpis);
                dataGridView_wpisy.Rows.Add(
                    form3.NowyWpis.Nazwa,
                    form3.NowyWpis.DataDodania.ToString("dd.MM.yyyy HH:mm"),
                    form3.NowyWpis.Typ,
                    form3.NowyWpis.Opis
                );
            }
        }

        private void button_wyświetl_Click(object sender, EventArgs e)
        {
            if (dataGridView_wpisy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę wybrać wpis do wyświetlenia!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedIndex = dataGridView_wpisy.SelectedRows[0].Index;
            if (selectedIndex >= 0 && selectedIndex < aktualnaSesja.Wpisy.Count)
            {
                Wpis wybranyWpis = aktualnaSesja.Wpisy[selectedIndex];
                Form4 form4 = new Form4(wybranyWpis);
                form4.ShowDialog();
            }
        }

        private void button_edytuj_Click(object sender, EventArgs e)
        {
            if (dataGridView_wpisy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę wybrać wpis do edycji!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedIndex = dataGridView_wpisy.SelectedRows[0].Index;
            if (selectedIndex >= 0 && selectedIndex < aktualnaSesja.Wpisy.Count)
            {
                Wpis wpisDoEdycji = aktualnaSesja.Wpisy[selectedIndex];
                Form3 form3 = new Form3(wpisDoEdycji);
                if (form3.ShowDialog() == DialogResult.OK)
                {
                    // Aktualizujemy dane w DataGridView
                    dataGridView_wpisy.Rows[selectedIndex].Cells["Nazwa"].Value = form3.NowyWpis.Nazwa;
                    dataGridView_wpisy.Rows[selectedIndex].Cells["Typ"].Value = form3.NowyWpis.Typ;
                    dataGridView_wpisy.Rows[selectedIndex].Cells["Opis"].Value = form3.NowyWpis.Opis;
                }
            }
        }

        private void button_usun_Click(object sender, EventArgs e)
        {
            if (dataGridView_wpisy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę wybrać wpis do usunięcia!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedIndex = dataGridView_wpisy.SelectedRows[0].Index;
            if (selectedIndex >= 0 && selectedIndex < aktualnaSesja.Wpisy.Count)
            {
                Wpis wpisDoUsuniecia = aktualnaSesja.Wpisy[selectedIndex];
                
                DialogResult result = MessageBox.Show(
                    $"Czy na pewno chcesz usunąć wpis \"{wpisDoUsuniecia.Nazwa}\"?",
                    "Potwierdzenie usunięcia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    aktualnaSesja.Wpisy.RemoveAt(selectedIndex);
                    dataGridView_wpisy.Rows.RemoveAt(selectedIndex);
                }
            }
        }

        private void button_zapisz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_tytul.Text))
            {
                MessageBox.Show("Proszę podać tytuł sesji!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TytulSesji = textBox_tytul.Text;
            DataUtworzenia = dateTimePicker_utworzenie.Value;

            // Jeśli jesteśmy w trybie edycji, nadpisujemy oryginalną sesję danymi z kopii
            if (trybEdycji && oryginalnaSesja != null)
            {
                oryginalnaSesja.Tytul = aktualnaSesja.Tytul = TytulSesji;
                oryginalnaSesja.DataUtworzenia = aktualnaSesja.DataUtworzenia = DataUtworzenia;
                oryginalnaSesja.Wpisy = aktualnaSesja.Wpisy.Select(w => new Wpis
                {
                    Nazwa = w.Nazwa,
                    DataDodania = w.DataDodania,
                    Typ = w.Typ,
                    Opis = w.Opis,
                    SciezkaPliku = w.SciezkaPliku,
                    Tresc = w.Tresc
                }).ToList();
                oryginalnaSesja.PlikiZalaczniki = new List<string>(aktualnaSesja.PlikiZalaczniki);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_eksportuj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_tytul.Text))
            {
                MessageBox.Show("Proszę podać tytuł sesji przed eksportem!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (aktualnaSesja.Wpisy.Count == 0)
            {
                MessageBox.Show("Nie można wyeksportować pustej sesji!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki PDF|*.pdf";
                saveFileDialog.Title = "Zapisz sesję jako PDF";
                saveFileDialog.FileName = $"{textBox_tytul.Text}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                        var document = new SesjaDocument(aktualnaSesja);
                        document.Generate(saveFileDialog.FileName);
                        MessageBox.Show("Sesja została pomyślnie wyeksportowana do PDF!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas eksportu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button_odrzuc_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public List<Wpis> GetWpisy()
        {
            return aktualnaSesja.Wpisy.Select(w => new Wpis
            {
                Nazwa = w.Nazwa,
                DataDodania = w.DataDodania,
                Typ = w.Typ,
                Opis = w.Opis,
                SciezkaPliku = w.SciezkaPliku,
                Tresc = w.Tresc
            }).ToList();
        }

        public void UstawTrybPrzegladania(bool przegladanie)
        {
            trybPrzegladania = przegladanie;
            if (trybPrzegladania)
            {
                textBox_tytul.ReadOnly = true;
                button_dodaj.Enabled = false;
                button_usun.Enabled = false;
                button_edytuj.Enabled = false;
                button_zapisz.Enabled = false;
                button_odrzuc.Enabled = false;
            }
        }
    }
}
