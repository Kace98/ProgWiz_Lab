using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularzDanych
{
    public class Wniosek
    {
        public int Id { get; set; }
        public string DataWypelnienia { get; set; }
        public string NumerAlbumu { get; set; }
        public string NazwiskoImie { get; set; }
        public string SemestrRok { get; set; }
        public string KierunekStopien { get; set; }
        public string Przedmiot { get; set; }
        public string Punkty { get; set; }
        public string Prowadzacy { get; set; }
        public string Uzasadnienie { get; set; }
        public string DataPodpisStudenta { get; set; }
        public string Decyzja { get; set; }
        public string Komisja1 { get; set; }
        public string Komisja2 { get; set; }
        public string Komisja3 { get; set; }
        public string DataDecyzji { get; set; }
    }
}
