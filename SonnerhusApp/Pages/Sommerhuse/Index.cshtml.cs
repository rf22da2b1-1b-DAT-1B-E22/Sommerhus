using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SommerhusLib.model;
using SonnerhusApp.services;

namespace SonnerhusApp.Pages.Sommerhuse
{
    public class IndexModel : PageModel
    {
        private readonly ISommerhusRepositoryService _service;

        public IndexModel(ISommerhusRepositoryService service)
        {
            _service = service;
        }





        [BindProperty]
        public int MaxPris { get; set; }
        public List<Sommerhus> Sommerhuse { get; set; }




        public void OnGet()
        {
            Sommerhuse = _service.GetAll();
        }


        public void OnPostFilterMax()
        {
            if (MaxPris == 0) MaxPris = int.MaxValue;
            Sommerhuse = _service.GetAll().Where((s) => s.PrisPrUge <= MaxPris).ToList<Sommerhus>();
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
