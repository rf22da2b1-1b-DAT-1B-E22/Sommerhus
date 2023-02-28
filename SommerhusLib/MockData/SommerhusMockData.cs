using SommerhusLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SommerhusLib.MockData
{
    public static class SommerhusMockData
    {
        private const bool HusdyrOK = true;
        private const bool HusdyrNej = false;

        private const bool VaskemaskineOK = true;
        private const bool VaskemaskineNej = false;

        private const bool OpvaskemaskineOK = true;
        private const bool OpvaskemaskineNej = false;

        private const bool SpaOK = true;
        private const bool SpaNej = false;

        private const bool RengøringMed = true;
        private const bool RengøringUden = false;


        private static readonly List<Sommerhus> sommerhuse = new List<Sommerhus>() {
            new Sommerhus(1, StedType.Bornholm, 7600, 4, RengøringMed, new Faciliteter(HusdyrOK,VaskemaskineOK,OpvaskemaskineOK,SpaNej)),
            new Sommerhus(2, StedType.Bornholm, 7810, 3, RengøringUden, new Faciliteter(HusdyrOK,VaskemaskineNej,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(3, StedType.Vestsjælland, 8800, 5, RengøringMed, new Faciliteter(HusdyrOK,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(4, StedType.Nordjylland, 5100, 3, RengøringMed, new Faciliteter(HusdyrNej,VaskemaskineNej,OpvaskemaskineNej,SpaNej)),
            new Sommerhus(5, StedType.Vestjylland, 17000, 8, RengøringMed, new Faciliteter(HusdyrNej,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(6, StedType.Vestsjælland, 6000, 6, RengøringUden, new Faciliteter(HusdyrNej,VaskemaskineOK,OpvaskemaskineOK,SpaNej)),
            new Sommerhus(7, StedType.Vestsjælland, 5600, 5, RengøringMed, new Faciliteter(HusdyrOK,VaskemaskineNej,OpvaskemaskineNej,SpaNej)),
            new Sommerhus(8, StedType.Falster, 17000, 9, RengøringMed, new Faciliteter(HusdyrOK,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(9, StedType.Nordjylland, 8120, 5, RengøringUden, new Faciliteter(HusdyrNej,VaskemaskineOK,OpvaskemaskineOK,SpaNej)),
            new Sommerhus(10, StedType.Nordjylland, 9050, 7, RengøringMed, new Faciliteter(HusdyrOK,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(11, StedType.Vestjylland, 6600, 3, RengøringUden, new Faciliteter(HusdyrNej,VaskemaskineNej,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(12, StedType.Bornholm, 8910, 6, RengøringMed, new Faciliteter(HusdyrNej,VaskemaskineOK,OpvaskemaskineOK,SpaNej)),
            new Sommerhus(13, StedType.Vestsjælland, 5540, 4, RengøringMed, new Faciliteter(HusdyrOK,VaskemaskineNej,OpvaskemaskineOK,SpaNej)),
            new Sommerhus(14, StedType.Bornholm, 17600, 11, RengøringMed, new Faciliteter(HusdyrOK,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(15, StedType.Vestsjælland, 4600, 3, RengøringUden, new Faciliteter(HusdyrNej,VaskemaskineNej,OpvaskemaskineNej,SpaNej)),
            new Sommerhus(16, StedType.Sønderjyllend, 9600, 6, RengøringMed, new Faciliteter(HusdyrNej,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(17, StedType.Nordjylland, 7700, 6, RengøringUden, new Faciliteter(HusdyrOK,VaskemaskineOK,OpvaskemaskineOK,SpaNej)),
            new Sommerhus(18, StedType.Bornholm, 8900, 7, RengøringMed, new Faciliteter(HusdyrOK,VaskemaskineOK,OpvaskemaskineOK,SpaNej)),
            new Sommerhus(19, StedType.Vestsjælland, 9100, 10, RengøringMed, new Faciliteter(HusdyrOK,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(20, StedType.Vestsjælland, 4400, 3, RengøringUden, new Faciliteter(HusdyrNej,VaskemaskineNej,OpvaskemaskineNej,SpaNej)),
            new Sommerhus(21, StedType.Vestjylland, 9900, 7, RengøringMed, new Faciliteter(HusdyrNej,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(22, StedType.Vestsjælland, 6000, 8, RengøringUden, new Faciliteter(HusdyrOK,VaskemaskineNej,OpvaskemaskineOK,SpaNej)),
            new Sommerhus(23, StedType.Nordjylland, 12000, 10, RengøringMed, new Faciliteter(HusdyrNej,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(24, StedType.Nordjylland, 10100, 8, RengøringMed, new Faciliteter(HusdyrNej,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(25, StedType.Vestjylland, 10500, 8, RengøringMed, new Faciliteter(HusdyrNej,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(26, StedType.Vestjylland, 10000, 7, RengøringMed, new Faciliteter(HusdyrOK,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(27, StedType.Sønderjyllend, 9900, 5, RengøringUden, new Faciliteter(HusdyrNej,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(28, StedType.Nordjylland, 8800, 5, RengøringMed, new Faciliteter(HusdyrOK,VaskemaskineOK,OpvaskemaskineOK,SpaNej)),
            new Sommerhus(29, StedType.Falster, 8700, 6, RengøringUden, new Faciliteter(HusdyrNej,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(30, StedType.Vestjylland, 7900, 5, RengøringMed, new Faciliteter(HusdyrNej,VaskemaskineOK,OpvaskemaskineOK,SpaNej)),
            new Sommerhus(31, StedType.Nordjylland, 8300, 6, RengøringMed, new Faciliteter(HusdyrNej,VaskemaskineOK,OpvaskemaskineOK,SpaNej)),
            new Sommerhus(32, StedType.Nordjylland, 8800, 7, RengøringMed, new Faciliteter(HusdyrOK,VaskemaskineOK,OpvaskemaskineOK,SpaNej)),
            new Sommerhus(33, StedType.Vestsjælland, 6300, 3, RengøringUden, new Faciliteter(HusdyrOK,VaskemaskineNej,OpvaskemaskineOK,SpaNej)),
            new Sommerhus(34, StedType.Øvrige, 4400, 5, RengøringMed, new Faciliteter(HusdyrNej,VaskemaskineNej,OpvaskemaskineOK,SpaNej)),
            new Sommerhus(35, StedType.Vestsjælland, 3900, 2, RengøringUden, new Faciliteter(HusdyrNej,VaskemaskineNej,OpvaskemaskineNej,SpaNej)),
            new Sommerhus(36, StedType.Bornholm, 14000, 10, RengøringMed, new Faciliteter(HusdyrOK,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(37, StedType.Bornholm, 17600, 12, RengøringMed, new Faciliteter(HusdyrNej,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(38, StedType.Vestjylland, 11000, 10, RengøringMed, new Faciliteter(HusdyrNej,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(39, StedType.Nordjylland, 8400, 6, RengøringUden, new Faciliteter(HusdyrNej,VaskemaskineOK,OpvaskemaskineOK,SpaOK)),
            new Sommerhus(40, StedType.Falster, 7600, 5, RengøringUden, new Faciliteter(HusdyrOK,VaskemaskineNej,OpvaskemaskineOK,SpaNej))
        };


        public static List<Sommerhus> GetSommerhuse() { 
            return new List<Sommerhus> (sommerhuse); 
        }

    }
}
