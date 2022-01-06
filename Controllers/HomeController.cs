using Andor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;



namespace Andor.Controllers
{
    public class HomeController : Controller
    {
        /*
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */

        private readonly Contexto _context;

        public HomeController(Contexto context)
        {
            _context = context; 
        }

        public IActionResult Index()
        {
            ViewData["trabalhos"] = _context.Trabalhos.ToList();    // cria lista de trabalhos 
            ViewData["moradias"]  = _context.Moradias.ToList();     // cria lista de Moradias 
            return View();
        }

        
        /*
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        */
    }
}
