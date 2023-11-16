using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish_19._10._2023
{
    internal class Karta
    {
        public  Barve b;
        public  Vrednosti v;
        public  string Ime;
        public Karta(Barve b1, Vrednosti v1)
        {
            b = b1;
            v = v1;
            Ime = v + " " + b;
        }
        public override string ToString()
        {
            return Ime;
        }
    }
}
