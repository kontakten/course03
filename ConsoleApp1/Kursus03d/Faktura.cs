using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursus03d
{
    public class Faktura
    {
        public int Nr { get; set; }

        public DateTime Dato { get; set; }

        public string Kunde { get; set; }

        public override string ToString()
        {
            return $"Faktura til {Kunde} nr {Nr}, fra {Dato}";
        }
    }
}
