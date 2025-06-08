using System;
using System.Collections.Generic;

namespace Lab12
{
    public class Sesja
    {
        public string Tytul { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public List<Wpis> Wpisy { get; set; }
        public List<string> PlikiZalaczniki { get; set; }
        public int Id { get; set; }

        public Sesja()
        {
            Wpisy = new List<Wpis>();
            PlikiZalaczniki = new List<string>();
        }

        public Sesja(string tytul, DateTime dataUtworzenia)
        {
            Tytul = tytul;
            DataUtworzenia = dataUtworzenia;
            Wpisy = new List<Wpis>();
            PlikiZalaczniki = new List<string>();
        }
    }
} 