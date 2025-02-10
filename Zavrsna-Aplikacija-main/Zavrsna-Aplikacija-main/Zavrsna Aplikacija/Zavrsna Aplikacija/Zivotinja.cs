using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Zavrsna_Aplikacija
{
    public class Zivotinja
    {
        public string Ime { get; set; }
        public string Vrsta { get; set; }
        public string Pasmina { get; set; }
        public DateTime DatumRodenja { get; set; }
        public DateTime DatumCijepljenja { get; set; }
        public string PosjetVeterinaru { get; set; }

        public override string ToString()
        {
            return $"{Ime} ({Vrsta}, {Pasmina})";
        }
    }
}
