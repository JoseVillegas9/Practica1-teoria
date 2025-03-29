using System;
 using System.Collections.Generic;
 using System.Diagnostics;
 using System.Linq;
 using System.Threading.Tasks;
 using Microsoft.AspNetCore.Mvc;
 using Microsoft.Extensions.Logging;
using Practica1teoria.Models;

namespace Practica1teoria.Controllers
{
    
    public class BoletaController : Controller
    {
        private readonly ILogger<BoletaController> _logger;

        public BoletaController(ILogger<BoletaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Generar(BoletaModel model)
        {
            if (ModelState.IsValid)
            {
                return View("BoletaGenerada", model);
            }
            return View("Index", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}