using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SommerhusLib.model.SortUtil
{
    public class SortByRengøring : IComparer<Sommerhus>
    {
        public int Compare(Sommerhus? x, Sommerhus? y)
        {
            if (y is null) return -1;
            if (x is null) return 1;
            if (x == y || x.Equals(y)) return 0;
            if (x.Rengøring == y.Rengøring) return 0;


            return (x.Rengøring)? -1 : 1;
        }

    }
}
