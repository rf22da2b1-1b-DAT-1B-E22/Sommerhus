using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SommerhusLib.model.SortUtil
{
    public class SortByHusdyr : IComparer<Sommerhus>
    {
        public int Compare(Sommerhus? x, Sommerhus? y)
        {
            if (y is null) return -1;
            if (x is null) return 1;
            if (x == y || x.Equals(y)) return 0;
            if (x.Faciliteter.Husdyr == y.Faciliteter.Husdyr) return 0;


            return (x.Faciliteter.Husdyr) ? -1 : 1;
        }
    }
}
