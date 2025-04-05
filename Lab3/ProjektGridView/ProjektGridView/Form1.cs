using System.Text.Json;

namespace ProjektGridView
{
    public partial class Form1 : Form
    {
        private static int nextId = 1;

        public Form1()
        {
            InitializeComponent();
            KonfigurujDataGridView();
        }

        private void KonfigurujDataGridView()
        {
            // Konfiguracja podstawowych właściwości DataGridView
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Dodawanie kolumn
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("imie", "Imię");
            dataGridView1.Columns.Add("nazwisko", "Nazwisko");
            dataGridView1.Columns.Add("wiek", "Wiek");
            dataGridView1.Columns.Add("stanowisko", "Stanowisko");

            // Ustawienie właściwości kolumn
            dataGridView1.Columns["id"].Width = 30;
            dataGridView1.Columns["imie"].Width = 50;
            dataGridView1.Columns["nazwisko"].Width = 50;
            dataGridView1.Columns["wiek"].Width = 30;
            dataGridView1.Columns["stanowisko"].Width = 80;

            // Ustawienie stylu nagłówków
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void button_Dodaj_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    // Pobierz dane z Form2 i dodaj je do DataGridView
                    string[] dane = form2.GetDane();
                    dataGridView1.Rows.Add(nextId, dane[0], dane[1], dane[2], dane[3]);
                    nextId++;
                }
            }
        }

        private void button_Usun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Czy na pewno chcesz usunąć zaznaczony wiersz?",
                                  "Potwierdzenie",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Zaznacz wiersz do usunięcia!",
                              "Informacja",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
        }

        private void ExportToCSV(DataGridView dataGridView, string filePath)
        {
            // Zapisanie nextId w pierwszej linii
            string csvContent = $"#NextID:{nextId}" + Environment.NewLine;

            // Tworzenie nagłówka pliku CSV
            csvContent += string.Join(",", dataGridView.Columns.Cast<DataGridViewColumn>()
                .Select(column => column.HeaderText)) + Environment.NewLine;

            // Dodawanie danych z DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    csvContent += string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>()
                        .ToArray(), c => c.Value)) + Environment.NewLine;
                }
            }

            // Zapisanie zawartości do pliku CSV
            File.WriteAllText(filePath, csvContent);
        }

        private void button_zapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.Title = "Wybierz lokalizację zapisu pliku CSV";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExportToCSV(dataGridView1, saveFileDialog1.FileName);
                MessageBox.Show("Dane zostały zapisane pomyślnie!", "Sukces",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadCSVToDataGridView(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik CSV nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length < 2) // Sprawdzamy czy mamy przynajmniej linię z nextId i nagłówki
            {
                MessageBox.Show("Nieprawidłowy format pliku CSV.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sprawdzanie i wczytywanie nextId
            if (lines[0].StartsWith("#NextID:"))
            {
                if (int.TryParse(lines[0].Substring(8), out int loadedNextId))
                {
                    nextId = loadedNextId;
                }
                lines = lines.Skip(1).ToArray(); // Pomijamy linię z nextId
            }

            // Czyszczenie istniejących danych
            dataGridView1.Rows.Clear();

            // Sprawdzanie nagłówków
            string[] headers = lines[0].Split(',');
            if (headers.Length != dataGridView1.Columns.Count)
            {
                MessageBox.Show("Nieprawidłowa liczba kolumn w pliku CSV.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Dodawanie wierszy do DataGridView
            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                if (values.Length == dataGridView1.Columns.Count)
                {
                    dataGridView1.Rows.Add(values);
                }
            }
        }

        private void button_wczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik CSV do wczytania";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadCSVToDataGridView(openFileDialog1.FileName);
                MessageBox.Show("Dane zostały wczytane pomyślnie!", "Sukces",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_saveToJson_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki JSON (*.json)|*.json|Wszystkie pliki (*.*)|*.*";
            saveFileDialog.Title = "Wybierz lokalizację zapisu pliku JSON";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var osoby = new List<Osoba>();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            osoby.Add(new Osoba
                            {
                                Id = Convert.ToInt32(row.Cells["id"].Value),
                                Imie = row.Cells["imie"].Value.ToString(),
                                Nazwisko = row.Cells["nazwisko"].Value.ToString(),
                                Wiek = Convert.ToInt32(row.Cells["wiek"].Value),
                                Stanowisko = row.Cells["stanowisko"].Value.ToString()
                            });
                        }
                    }

                    var options = new JsonSerializerOptions { WriteIndented = true };
                    string jsonString = JsonSerializer.Serialize(osoby, options);
                    File.WriteAllText(saveFileDialog.FileName, jsonString);

                    MessageBox.Show("Dane zostały zapisane do pliku JSON pomyślnie!", "Sukces",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd podczas zapisywania do pliku JSON: {ex.Message}", "Błąd",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_readFromJson_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki JSON (*.json)|*.json|Wszystkie pliki (*.*)|*.*";
            openFileDialog.Title = "Wybierz plik JSON do wczytania";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonString = File.ReadAllText(openFileDialog.FileName);
                    var osoby = JsonSerializer.Deserialize<List<Osoba>>(jsonString);

                    dataGridView1.Rows.Clear();
                    foreach (var osoba in osoby)
                    {
                        dataGridView1.Rows.Add(osoba.Id, osoba.Imie, osoba.Nazwisko, osoba.Wiek, osoba.Stanowisko);
                    }

                    // Aktualizacja nextId na podstawie najwyższego ID w wczytanych danych
                    if (osoby != null && osoby.Any())
                    {
                        nextId = osoby.Max(o => o.Id) + 1;
                    }

                    MessageBox.Show("Dane zostały wczytane z pliku JSON pomyślnie!", "Sukces",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd podczas wczytywania z pliku JSON: {ex.Message}", "Błąd",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
