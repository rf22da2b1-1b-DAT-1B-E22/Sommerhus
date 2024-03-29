using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SommerhusLib.DecoratorPattern;
using SommerhusLib.model;
using SommerhusLib.model.SortUtil;
using SonnerhusApp.services;
using System.Web.Helpers;

namespace SonnerhusApp.Pages.Sommerhuse
{
    public class IndexModel : PageModel
    {
        private readonly ISommerhusRepositoryService _service;

        public IndexModel(ISommerhusRepositoryService service)
        {
            _service = service;
        }

        /*
         * input fields
         */
        [BindProperty]
        public int? MaxPris { get; set; }
        [BindProperty]
        public String Reng { get; set; }
        [BindProperty]
        public bool Husdyr { get; set; }
        [BindProperty]
        public bool Vask { get; set; }
        [BindProperty]
        public bool Opvask { get; set; }
        [BindProperty]
        public bool Spa { get; set; }


        /*
         * reading fields
         */
        public List<Sommerhus> Sommerhuse { get; set; }




        public void OnGet()
        {
            Sommerhuse = _service.GetAll();
        }


        public void OnPostFilter()
        {
            Sommerhuse = _service.GetAll();

            if (MaxPris is not null)
            {
                Sommerhuse = Sommerhuse.Where((s) => s.PrisPrUge <= MaxPris).ToList();
            }

            switch (Reng)
            {
                case "Med":
                    Sommerhuse = Sommerhuse.Where(s => s.Reng�ring).ToList(); break;
                case "Uden":
                    Sommerhuse = Sommerhuse.Where(s => !s.Reng�ring).ToList(); break;
                default:
                    break; // ingen filtrering
            }

            if (Husdyr)
            {
                Sommerhuse = Sommerhuse.Where(s => s.Faciliteter.Husdyr).ToList();

            }

            if (Vask)
            {
                Sommerhuse = Sommerhuse.Where(s => s.Faciliteter.Vaskemaskine).ToList();

            }

            if (Opvask)
            {
                Sommerhuse = Sommerhuse.Where(s => s.Faciliteter.Opvaskemaskine).ToList();

            }

            if (Spa)
            {
                Sommerhuse = Sommerhuse.Where(s => s.Faciliteter.Spa).ToList();

            }
        }

        public void OnPostFilterUseDecorator()
        {
            IFilter filter = new BasicNoFilter(_service.GetAll());

            if (MaxPris is not null)
            {
                filter = new MaxPrisFilter(filter, MaxPris);
            }

            switch (Reng)
            {
                case "Med":
                    filter = new MedReng�ringFilter(filter); break;
                case "Uden":
                    filter = new UdenReng�ringFilter(filter); break;
                default:
                    break; // ingen filtrering
            }

            if (Husdyr)
            {
                filter = new HusdyrFilter(filter);
            }

            if (Vask)
            {
                filter = new VaskemaskineFilter(filter);
            }

            if (Opvask)
            {
                filter = new OpvaskemaskineFilter(filter);
            }

            if (Spa)
            {
                filter = new SpaFilter(filter);
            }

            Sommerhuse = filter.Filter();
        }



        public void OnPostSort1()
        {
            Sommerhuse = _service.GetAll();
            Sommerhuse.Sort(); // sort p� pris pr uge
        }
        public void OnPostSort2()
        {
            Sommerhuse = _service.GetAll().OrderBy(s => s.Id).ToList(); // sort p� id
            
        }


        public void OnPostSortById()
        {
            OnPostSort2();
        }
        public void OnPostSortBySted()
        {
            Sommerhuse = _service.GetAll();
            Sommerhuse.Sort(new SortBySted()); // sort p� pris pr uge
        }
        public void OnPostSortBySenge()
        {
            Sommerhuse = _service.GetAll();
            Sommerhuse.Sort(new SortBySenge()); // sort p� pris pr uge
        }
        public void OnPostSortByReng()
        {
            Sommerhuse = _service.GetAll();
            Sommerhuse.Sort(new SortByReng�ring()); // sort p� pris pr uge
        }
        public void OnPostSortByPris()
        {
            Sommerhuse = _service.GetAll();
            Sommerhuse.Sort(new SortPrisH�jLav()); // sort p� pris pr uge
        }
        public void OnPostSortByHusdyr()
        {
            Sommerhuse = _service.GetAll();
            Sommerhuse.Sort(new SortByHusdyr()); // sort p� pris pr uge
        }
        public void OnPostSortByVask()
        {
            Sommerhuse = _service.GetAll();
            Sommerhuse.Sort(new SortByVask()); // sort p� pris pr uge
        }
        public void OnPostSortByOpvask()
        {
            Sommerhuse = _service.GetAll();
            Sommerhuse.Sort(new SortByOpvask()); // sort p� pris pr uge
        }
        public void OnPostSortBySpa()
        {
            Sommerhuse = _service.GetAll();
            Sommerhuse.Sort(new SortBySpa()); // sort p� pris pr uge
        }






        /*
         * help methods
         */
        public String Convert2Str(bool value)
        {
            return (value) ? "Ja" : "Nej";
        }
    }
}
