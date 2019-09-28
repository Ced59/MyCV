using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CVenLigne.Controllers
{
    public class RealisationsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["activeRealisations"] = "bg-light";
            return View();
        }
    }
}