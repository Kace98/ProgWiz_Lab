using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Web;
using System.Collections.Specialized;

namespace FormularzDanych
{
    public class DatabaseManager
    {
        private string connectionString = @"Data Source=Wnioski.db;Version=3";
        public DatabaseManager()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Wnioski (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        DataWypelnienia TEXT,
                        NumerAlbumu TEXT,
                        NazwiskoImie TEXT,
                        SemestrRok TEXT,
                        KierunekStopien TEXT,
                        Przedmiot TEXT,
                        Punkty TEXT,
                        Prowadzacy TEXT,
                        Uzasadnienie TEXT,
                        DataPodpisStudenta TEXT,
                        Decyzja TEXT,
                        Komisja1 TEXT,
                        Komisja2 TEXT,
                        Komisja3 TEXT,
                        DataDecyzji TEXT
                    )";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ReadData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM Wnioski";
                SQLiteCommand command = new SQLiteCommand(query, connection);

                try
                {
                    connection.Open();
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string dataWypelnienia = reader.GetString(1);
                        string numerAlbumu = reader.GetString(2);
                        string nazwiskoImie = reader.GetString(3);
                        string semestrRok = reader.GetString(4);
                        string kierunekStopien = reader.GetString(5);
                        string przedmiot = reader.GetString(6);
                        string punkty = reader.GetString(7);
                        string prowadzacy = reader.GetString(8);
                        string uzasadnienie = reader.GetString(9);
                        string dataPodpisStudenta = reader.GetString(10);
                        string decyzja = reader.GetString(11);
                        string komisja1 = reader.GetString(12);
                        string komisja2 = reader.GetString(13);
                        string komisja3 = reader.GetString(14);
                        string dataDecyzji = reader.GetString(15);

                        Console.WriteLine(
                            $"Id: {id}, Data wypełnienia: {dataWypelnienia}, Numer albumu: {numerAlbumu}, Imię i nazwisko: {nazwiskoImie}, Semestr/rok: {semestrRok}, " +
                            $"Kierunek/stopień: {kierunekStopien}, Przedmiot: {przedmiot}, Punkty: {punkty}, Prowadzący: {prowadzacy}, " +
                            $"Uzasadnienie: {uzasadnienie}, Data i podpis studenta: {dataPodpisStudenta}, Decyzja: {decyzja}, " +
                            $"Komisja1: {komisja1}, Komisja2: {komisja2}, Komisja3: {komisja3}, Data decyzji: {dataDecyzji}"
                        );
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public void WriteData(Wniosek wniosek)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = @"INSERT INTO Wnioski 
                    (DataWypelnienia, NumerAlbumu, NazwiskoImie, SemestrRok, KierunekStopien, Przedmiot, Punkty, Prowadzacy, Uzasadnienie, DataPodpisStudenta, Decyzja, Komisja1, Komisja2, Komisja3, DataDecyzji)
                     VALUES (@DataWypelnienia, @NumerAlbumu, @NazwiskoImie, @SemestrRok, @KierunekStopien, @Przedmiot, @Punkty, @Prowadzacy, @Uzasadnienie, @DataPodpisStudenta, @Decyzja, @Komisja1, @Komisja2, @Komisja3, @DataDecyzji)";
                SQLiteCommand command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@DataWypelnienia", wniosek.DataWypelnienia);
                command.Parameters.AddWithValue("@NumerAlbumu", wniosek.NumerAlbumu);
                command.Parameters.AddWithValue("@NazwiskoImie", wniosek.NazwiskoImie);
                command.Parameters.AddWithValue("@SemestrRok", wniosek.SemestrRok);
                command.Parameters.AddWithValue("@KierunekStopien", wniosek.KierunekStopien);
                command.Parameters.AddWithValue("@Przedmiot", wniosek.Przedmiot);
                command.Parameters.AddWithValue("@Punkty", wniosek.Punkty);
                command.Parameters.AddWithValue("@Prowadzacy", wniosek.Prowadzacy);
                command.Parameters.AddWithValue("@Uzasadnienie", wniosek.Uzasadnienie);
                command.Parameters.AddWithValue("@DataPodpisStudenta", wniosek.DataPodpisStudenta);
                command.Parameters.AddWithValue("@Decyzja", wniosek.Decyzja);
                command.Parameters.AddWithValue("@Komisja1", wniosek.Komisja1);
                command.Parameters.AddWithValue("@Komisja2", wniosek.Komisja2);
                command.Parameters.AddWithValue("@Komisja3", wniosek.Komisja3);
                command.Parameters.AddWithValue("@DataDecyzji", wniosek.DataDecyzji);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) inserted.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public List<Wniosek> PobierzWnioski()
        {
            var lista = new List<Wniosek>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM Wnioski";
                SQLiteCommand command = new SQLiteCommand(query, connection);

                try
                {
                    connection.Open();
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var wniosek = new Wniosek
                        {
                            Id = reader.GetInt32(0),
                            DataWypelnienia = reader.GetString(1),
                            NumerAlbumu = reader.GetString(2),
                            NazwiskoImie = reader.GetString(3),
                            SemestrRok = reader.GetString(4),
                            KierunekStopien = reader.GetString(5),
                            Przedmiot = reader.GetString(6),
                            Punkty = reader.GetString(7),
                            Prowadzacy = reader.GetString(8),
                            Uzasadnienie = reader.GetString(9),
                            DataPodpisStudenta = reader.GetString(10),
                            Decyzja = reader.GetString(11),
                            Komisja1 = reader.GetString(12),
                            Komisja2 = reader.GetString(13),
                            Komisja3 = reader.GetString(14),
                            DataDecyzji = reader.GetString(15)
                        };
                        lista.Add(wniosek);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return lista;
        }
    }
}
