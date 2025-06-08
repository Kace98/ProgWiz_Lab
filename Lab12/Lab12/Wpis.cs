using System;

namespace Lab12
{
    public class Wpis
    {
        public string Nazwa { get; set; }
        public DateTime DataDodania { get; set; }
        public string Typ { get; set; } // "Tekstowy" lub "Załącznik"
        public string Opis { get; set; }
        public string SciezkaPliku { get; set; } // Dla załączników
        public string Tresc { get; set; } // Dla wpisów tekstowych
        public int Id { get; set; }

        public Wpis()
        {
            DataDodania = DateTime.Now;
        }
    }
} 