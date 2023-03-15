using SommerhusLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SommerhusLib.DecoratorPattern
{
    public class UdenRengøringFilter : IFilter
    {
        // decorator har en refence til IFilter 
        private readonly IFilter _filter;
        // construktør skal have et filter at dekorere
        public UdenRengøringFilter(IFilter filter)
        {
            _filter = filter;
        }

        public List<Sommerhus> Filter()
        {
            // gør som i _filter PLUS filtrere ingen rengøring
            return _filter.Filter().Where(h => !h.Rengøring).ToList();
        }
    }
}
