using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CVenLigne.Controllers
{
    public class EtudesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["activeEtudes"] = "bg-light";
            return View();
        }
    }
}