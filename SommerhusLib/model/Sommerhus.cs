using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SommerhusLib.model
{
    public enum StedType  {Bornholm, Nordjylland, Vestjylland, Sønderjyllend, Fyn, Vestsjælland, Falster, Øvrige}
    public class Sommerhus
    {
        public int Id { get; set; }
        public StedType Sted { get; set; }
        public int PrisPrUge { get; set; }
        public int AntalSenge { get; set; }
        public bool Rengøring { get; set; }
        public Faciliteter Faciliteter { get; set; }

        public Sommerhus(int id, StedType sted, int prisPrUge, int antalSenge, bool rengøring, Faciliteter faciliteter)
        {
            Id = id;
            Sted = sted;
            PrisPrUge = prisPrUge;
            AntalSenge = antalSenge;
            Rengøring = rengøring;
            Faciliteter = faciliteter;
        }

        public Sommerhus():this(-1, StedType.Øvrige, 0,0,false,new Faciliteter())
        {
        }

        public override string ToString()
        {
            String rengøring = (Rengøring) ? "Rengøring" : "Ingen rengøring";
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Sted)}={Sted}, {nameof(PrisPrUge)}={PrisPrUge.ToString()}, {nameof(AntalSenge)}={AntalSenge.ToString()}, {nameof(Rengøring)}={rengøring}, {nameof(Faciliteter)}={Faciliteter}}}";
        }

       
    }
}
