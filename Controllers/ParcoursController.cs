using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CVenLigne.Controllers
{
    public class ParcoursController : Controller
    {
        public IActionResult Index()
        {
            ViewData["activeParcours"] = "bg-light";
            return View();
        }
    }
}