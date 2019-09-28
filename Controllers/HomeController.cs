using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CVenLigne.Models;

namespace CVenLigne.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["activeHome"] = "bg-light";
            return View();
        }
    }
}
