﻿using System.Text.Json.Serialization;

namespace ProjektGridView
{
    public class Osoba
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public string Stanowisko { get; set; }
    }
}
