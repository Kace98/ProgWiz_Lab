using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using System.Data.SQLite;
using System.IO;

namespace Lab11
{
    public partial class Form1 : Form
    {
        private List<Próbka> próbki;
        private List<Próbka> wszystkiePróbki;
        private int następneID;
        private const string DB_FILE = "próbki.db";

        public Form1()
        {
            InitializeComponent();
            próbki = new List<Próbka>();
            wszystkiePróbki = new List<Próbka>();
            następneID = 1;
            KonfigurujDataGridView();
            KonfigurujFiltry();
            InicjalizujBazęDanych();
        }

        private void InicjalizujBazęDanych()
        {
            if (!File.Exists(DB_FILE))
            {
                SQLiteConnection.CreateFile(DB_FILE);
                using (var conn = new SQLiteConnection($"Data Source={DB_FILE};Version=3;"))
                {
                    conn.Open();
                    string sql = "CREATE TABLE Próbki (ID INTEGER, Nazwa TEXT, Typ TEXT, DataPobrania TEXT, Opis TEXT)";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void KonfigurujFiltry()
        {
            comboBox_filter.Items.Add("Wszystkie");
            comboBox_filter.Items.AddRange(new string[] { "DNA", "RNA", "Białko", "Inny" });
            comboBox_filter.SelectedIndex = 0;
        }

        private void KonfigurujDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                DataPropertyName = "ID",
                HeaderText = "ID"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nazwa",
                DataPropertyName = "Nazwa",
                HeaderText = "Nazwa"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Typ",
                DataPropertyName = "Typ",
                HeaderText = "Typ"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DataPobrania",
                DataPropertyName = "DataPobrania",
                HeaderText = "Data pobrania"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Opis",
                DataPropertyName = "Opis",
                HeaderText = "Opis"
            });
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            using (var form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    form2.NowaPróbka.ID = następneID++;
                    próbki.Add(form2.NowaPróbka);
                    wszystkiePróbki.Add(form2.NowaPróbka);
                    AktualizujDataGridView();
                }
            }
        }

        private void button_edytuj_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz próbkę do edycji.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var wybranaPróbka = (Próbka)dataGridView1.SelectedRows[0].DataBoundItem;
            using (var form2 = new Form2(wybranaPróbka))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    AktualizujDataGridView();
                }
            }
        }

        private void button_usun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz próbkę do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var wybranaPróbka = (Próbka)dataGridView1.SelectedRows[0].DataBoundItem;
            var potwierdzenie = MessageBox.Show(
                $"Czy na pewno chcesz usunąć próbkę {wybranaPróbka.Nazwa}?",
                "Potwierdzenie usunięcia",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (potwierdzenie == DialogResult.Yes)
            {
                próbki.Remove(wybranaPróbka);
                wszystkiePróbki.Remove(wybranaPróbka);
                AktualizujDataGridView();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wyszukiwanaNazwa = textBox1.Text.ToLower();
            var wybranyTyp = comboBox_filter.SelectedItem.ToString();

            próbki = wszystkiePróbki.Where(p =>
                (wybranyTyp == "Wszystkie" || p.Typ == wybranyTyp) &&
                (string.IsNullOrEmpty(wyszukiwanaNazwa) || p.Nazwa.ToLower().Contains(wyszukiwanaNazwa))
            ).ToList();

            AktualizujDataGridView();
        }

        private void button_generujQR_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz próbkę do wygenerowania kodu QR.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var wybranaPróbka = (Próbka)dataGridView1.SelectedRows[0].DataBoundItem;
            using (var form3 = new Form3(wybranaPróbka))
            {
                form3.ShowDialog();
            }
        }

        private void button_zapisz_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SQLiteConnection($"Data Source={DB_FILE};Version=3;"))
                {
                    conn.Open();
                    
                    // Usuwamy wszystkie rekordy
                    using (var cmd = new SQLiteCommand("DELETE FROM Próbki", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Dodajemy wszystkie próbki
                    foreach (var próbka in wszystkiePróbki)
                    {
                        string sql = "INSERT INTO Próbki VALUES (@ID, @Nazwa, @Typ, @Data, @Opis)";
                        using (var cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", próbka.ID);
                            cmd.Parameters.AddWithValue("@Nazwa", próbka.Nazwa);
                            cmd.Parameters.AddWithValue("@Typ", próbka.Typ);
                            cmd.Parameters.AddWithValue("@Data", próbka.DataPobrania.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@Opis", próbka.Opis ?? (object)DBNull.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Dane zostały zapisane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd zapisu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_wczytaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(DB_FILE))
                {
                    MessageBox.Show("Brak pliku bazy danych.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (var conn = new SQLiteConnection($"Data Source={DB_FILE};Version=3;"))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Próbki";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            wszystkiePróbki.Clear();
                            próbki.Clear();
                            następneID = 1;

                            while (reader.Read())
                            {
                                var próbka = new Próbka
                                {
                                    ID = reader.GetInt32(0),
                                    Nazwa = reader.GetString(1),
                                    Typ = reader.GetString(2),
                                    DataPobrania = DateTime.Parse(reader.GetString(3)),
                                    Opis = reader.IsDBNull(4) ? null : reader.GetString(4)
                                };

                                wszystkiePróbki.Add(próbka);
                                próbki.Add(próbka);
                                następneID = Math.Max(następneID, próbka.ID + 1);
                            }
                        }
                    }
                }
                AktualizujDataGridView();
                MessageBox.Show("Dane zostały wczytane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd wczytania: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AktualizujDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = próbki;
        }
    }
}
