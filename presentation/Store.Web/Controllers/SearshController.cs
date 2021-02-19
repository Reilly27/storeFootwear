using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers
{
    public class SearshController : Controller
    {
        private readonly FootWServise footWServise;
        

        public SearshController(FootWServise footWServise)
        {
            this.footWServise = footWServise;
        }

        public IActionResult Index(string query)
        {
            if (query == null)
                query = "0";

            var footwear = footWServise.GetAllByQuery(query);
          
            return View(footwear);
        }
    }
}