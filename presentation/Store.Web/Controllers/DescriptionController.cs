using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store_Mamory;

namespace Store.Web.Controllers
{
    public class DescriptionController : Controller
    {
        private readonly IFootwearRepository footwearRepository;

        public DescriptionController(IFootwearRepository footwearRepository)
        {
            this.footwearRepository = footwearRepository;
        }

        public IActionResult Index(int id)
        {
            Footwear footwear = footwearRepository.GetById(id);
            return View("Index", footwear);
        }
    }
}