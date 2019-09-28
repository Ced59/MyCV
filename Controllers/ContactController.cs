using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CVenLigne.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewData["activeContact"] = "bg-light";
            return View();
        }
    }
}