using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App_netcore.Models;
using Microsoft.AspNetCore.Authorization;

namespace App_netcore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        public IActionResult Gracias()
        {
            return View();
        }

        [Authorize]
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Contacto(ContactoViewModel contactoViewModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Gracias");
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
