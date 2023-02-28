using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SommerhusLib.model
{
    public class Faciliteter
    {
        public bool Husdyr { get; set; }
        public bool Vaskemaskine { get; set; }
        public bool Opvaskemaskine { get; set; }
        public bool Spa { get; set; }

        public Faciliteter(bool husdyr, bool vaskemaskine, bool opvaskemaskine, bool spa)
        {
            Husdyr= husdyr;
            Vaskemaskine = vaskemaskine;
            Opvaskemaskine = opvaskemaskine;
            Spa = spa;
        }

        public Faciliteter():this(false, false, true, false)
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(Husdyr)}={ConvertBool(Husdyr)}, {nameof(Vaskemaskine)}={ConvertBool(Vaskemaskine)}, {nameof(Opvaskemaskine)}={ConvertBool(Opvaskemaskine)}, {nameof(Spa)}={ConvertBool(Spa)}}}";
        }
        private String ConvertBool(bool value)
        {
            return value ? "Ja" : "Nej";
        }
    }
}
