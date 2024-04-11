using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp122222
{
    public class Senior: Inimene
    {
        public int Tööstaž;

        public override decimal Sissetulek(decimal tasu)
        {
            tasu = tasu * (1+(Tööstaž / 100));
            return tasu;
        }
    }
}
