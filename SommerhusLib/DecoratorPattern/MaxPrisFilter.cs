using SommerhusLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SommerhusLib.DecoratorPattern
{
    public class MaxPrisFilter : IFilter
    {
        // decorator har en refence til IFilter 
        private readonly IFilter _filter;
        private readonly int? _maxPris;
        // construktør skal have et filter at dekorere
        public MaxPrisFilter(IFilter filter, int? maxPris)
        {
            _filter = filter;
            _maxPris = maxPris; 
        }

        public List<Sommerhus> Filter()
        {
            // gør som i _filter PLUS filtrere for husdyr
            return _filter.Filter().Where(h => h.PrisPrUge < _maxPris).ToList();
        }
    }
}
