namespace Lab12
{
    public partial class Form1 : Form
    {
        private List<Sesja> sesje;

        public Form1()
        {
            InitializeComponent();
            DatabaseHelper.InitializeDatabase();
            sesje = new List<Sesja>();
            dataGridView_sesje.Columns.Add("Tytul", "Tytuł");
            dataGridView_sesje.Columns.Add("DataUtworzenia", "Data utworzenia");
        }

        private void button_utworzSesje_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                Sesja nowaSesja = new Sesja(form2.TytulSesji, form2.DataUtworzenia);
                // Kopiujemy wpisy utworzone w Form2
                nowaSesja.Wpisy = form2.GetWpisy().Select(w => new Wpis
                {
                    Nazwa = w.Nazwa,
                    DataDodania = w.DataDodania,
                    Typ = w.Typ,
                    Opis = w.Opis,
                    SciezkaPliku = w.SciezkaPliku,
                    Tresc = w.Tresc
                }).ToList();
                sesje.Add(nowaSesja);
                dataGridView_sesje.Rows.Add(nowaSesja.Tytul, nowaSesja.DataUtworzenia.ToString("dd.MM.yyyy HH:mm"));
            }
        }

        private void button_edytujSesje_Click(object sender, EventArgs e)
        {
            if (dataGridView_sesje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę wybrać sesję do edycji!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedIndex = dataGridView_sesje.SelectedRows[0].Index;
            if (selectedIndex >= 0 && selectedIndex < sesje.Count)
            {
                Sesja wybranaSesja = sesje[selectedIndex];
                Form2 form2 = new Form2(wybranaSesja);
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    // Aktualizujemy dane w liście i DataGridView
                    wybranaSesja.Tytul = form2.TytulSesji;
                    wybranaSesja.DataUtworzenia = form2.DataUtworzenia;
                    dataGridView_sesje.Rows[selectedIndex].Cells["Tytul"].Value = wybranaSesja.Tytul;
                    dataGridView_sesje.Rows[selectedIndex].Cells["DataUtworzenia"].Value = wybranaSesja.DataUtworzenia.ToString("dd.MM.yyyy HH:mm");
                }
            }
        }

        private void button_usunSesje_Click(object sender, EventArgs e)
        {

        }

        private void button_wczytaj_Click(object sender, EventArgs e)
        {
            try
            {
                sesje = DatabaseHelper.LoadAll();
                dataGridView_sesje.Rows.Clear();
                foreach (var sesja in sesje)
                {
                    dataGridView_sesje.Rows.Add(sesja.Tytul, sesja.DataUtworzenia.ToString("dd.MM.yyyy HH:mm"));
                }
                MessageBox.Show("Dane zostały wczytane z bazy danych.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd wczytywania z bazy: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_zapisz_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper.SaveAll(sesje);
                MessageBox.Show("Dane zostały zapisane do bazy danych.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd zapisu do bazy: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_przegladaj_Click(object sender, EventArgs e)
        {
            if (dataGridView_sesje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę wybrać sesję do przeglądania!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedIndex = dataGridView_sesje.SelectedRows[0].Index;
            if (selectedIndex >= 0 && selectedIndex < sesje.Count)
            {
                Sesja wybranaSesja = sesje[selectedIndex];
                Form2 form2 = new Form2(wybranaSesja);
                form2.UstawTrybPrzegladania(true);
                form2.ShowDialog();
            }
        }
    }
}
