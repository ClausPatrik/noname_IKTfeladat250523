using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autokmozgasa_250523
{
    internal class Adat
    {

            public string Rendszam { get; set; }
            public int Honap { get; set; }
            public int Nap { get; set; }
            public int Ido { get; set; }

            public override string ToString()
            {
                return $"{Rendszam} - {Honap}.{Nap} - {Ido} mp";
            }
        }

    }

