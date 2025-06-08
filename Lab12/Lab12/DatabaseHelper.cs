using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace Lab12
{
    public static class DatabaseHelper
    {
        private static readonly string DbFile = "database.db";
        private static readonly string ConnectionString = $"Data Source={DbFile};Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists(DbFile))
            {
                SQLiteConnection.CreateFile(DbFile);
            }
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string createSesje = @"CREATE TABLE IF NOT EXISTS Sesje (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Tytul TEXT NOT NULL,
                    DataUtworzenia TEXT NOT NULL
                );";
                string createWpisy = @"CREATE TABLE IF NOT EXISTS Wpisy (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    SesjaId INTEGER NOT NULL,
                    Nazwa TEXT NOT NULL,
                    DataDodania TEXT NOT NULL,
                    Typ TEXT NOT NULL,
                    Opis TEXT,
                    SciezkaPliku TEXT,
                    Tresc TEXT,
                    FOREIGN KEY(SesjaId) REFERENCES Sesje(Id) ON DELETE CASCADE
                );";
                using (var cmd = new SQLiteCommand(createSesje, conn))
                    cmd.ExecuteNonQuery();
                using (var cmd = new SQLiteCommand(createWpisy, conn))
                    cmd.ExecuteNonQuery();
            }
        }

        public static void SaveAll(List<Sesja> sesje)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    // Czyścimy stare dane
                    new SQLiteCommand("DELETE FROM Wpisy", conn, trans).ExecuteNonQuery();
                    new SQLiteCommand("DELETE FROM Sesje", conn, trans).ExecuteNonQuery();

                    foreach (var sesja in sesje)
                    {
                        // Dodaj sesję
                        var cmdSesja = new SQLiteCommand("INSERT INTO Sesje (Tytul, DataUtworzenia) VALUES (@Tytul, @DataUtworzenia); SELECT last_insert_rowid();", conn, trans);
                        cmdSesja.Parameters.AddWithValue("@Tytul", sesja.Tytul);
                        cmdSesja.Parameters.AddWithValue("@DataUtworzenia", sesja.DataUtworzenia.ToString("o"));
                        long sesjaId = (long)cmdSesja.ExecuteScalar();
                        // Dodaj wpisy
                        foreach (var wpis in sesja.Wpisy)
                        {
                            var cmdWpis = new SQLiteCommand(@"INSERT INTO Wpisy (SesjaId, Nazwa, DataDodania, Typ, Opis, SciezkaPliku, Tresc) VALUES (@SesjaId, @Nazwa, @DataDodania, @Typ, @Opis, @SciezkaPliku, @Tresc);", conn, trans);
                            cmdWpis.Parameters.AddWithValue("@SesjaId", sesjaId);
                            cmdWpis.Parameters.AddWithValue("@Nazwa", wpis.Nazwa);
                            cmdWpis.Parameters.AddWithValue("@DataDodania", wpis.DataDodania.ToString("o"));
                            cmdWpis.Parameters.AddWithValue("@Typ", wpis.Typ);
                            cmdWpis.Parameters.AddWithValue("@Opis", wpis.Opis ?? "");
                            cmdWpis.Parameters.AddWithValue("@SciezkaPliku", wpis.SciezkaPliku ?? "");
                            cmdWpis.Parameters.AddWithValue("@Tresc", wpis.Tresc ?? "");
                            cmdWpis.ExecuteNonQuery();
                        }
                    }
                    trans.Commit();
                }
            }
        }

        public static List<Sesja> LoadAll()
        {
            var sesje = new List<Sesja>();
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                // Wczytaj sesje
                var cmdSesje = new SQLiteCommand("SELECT Id, Tytul, DataUtworzenia FROM Sesje", conn);
                using (var reader = cmdSesje.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sesja = new Sesja
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Tytul = reader["Tytul"].ToString(),
                            DataUtworzenia = DateTime.Parse(reader["DataUtworzenia"].ToString()),
                            Wpisy = new List<Wpis>()
                        };
                        sesje.Add(sesja);
                    }
                }
                // Wczytaj wpisy
                var cmdWpisy = new SQLiteCommand("SELECT * FROM Wpisy", conn);
                using (var reader = cmdWpisy.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int sesjaId = Convert.ToInt32(reader["SesjaId"]);
                        var wpis = new Wpis
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nazwa = reader["Nazwa"].ToString(),
                            DataDodania = DateTime.Parse(reader["DataDodania"].ToString()),
                            Typ = reader["Typ"].ToString(),
                            Opis = reader["Opis"].ToString(),
                            SciezkaPliku = reader["SciezkaPliku"].ToString(),
                            Tresc = reader["Tresc"].ToString()
                        };
                        var sesja = sesje.Find(s => s.Id == sesjaId);
                        if (sesja != null)
                            sesja.Wpisy.Add(wpis);
                    }
                }
            }
            return sesje;
        }
    }
} 