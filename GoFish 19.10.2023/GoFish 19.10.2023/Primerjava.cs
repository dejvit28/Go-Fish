using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish_19._10._2023
{
    internal class Primerjava : IComparer<Karta>
    {
        public int Compare(Karta x, Karta y)
        {
            if(x.v<y.v) return -1;
            if(x.v>y.v) return  1;
            if(x.b<y.b) return -1;  
            if(x.b>y.b) return  1;
            return 0;
        }
    }
}
