using SommerhusLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SommerhusLib.DecoratorPattern
{
    public class BasicNoFilter : IFilter
    {
        private readonly List<Sommerhus> _huse;

        public BasicNoFilter(List<Sommerhus> huse)
        {
            _huse = huse;
        }

        public List<Sommerhus> Filter()
        {
            return new List<Sommerhus>(_huse);
        }
    }
}
