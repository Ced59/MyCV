using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CVenLigne.Controllers
{
    public class CompetencesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["activeCompetences"] = "bg-light";
            return View();
        }
    }
}