﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SommerhusLib.model.SortUtil
{
    public class SortBySpa : IComparer<Sommerhus>
    {
        public int Compare(Sommerhus? x, Sommerhus? y)
        {
            if (y is null) return -1;
            if (x is null) return 1;
            if (x == y || x.Equals(y)) return 0;
            if (x.Faciliteter.Spa == y.Faciliteter.Spa) return 0;


            return (x.Faciliteter.Spa) ? -1 : 1;
        }
    }
}