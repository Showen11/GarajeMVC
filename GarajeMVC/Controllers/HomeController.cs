using System.Diagnostics;
using GarajeMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GarajeMVC.Controllers
{
    public class HomeController : Controller
    {
        public class PersonaController : Controller
        {
            

           
        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Garage miGaraje = new Garage(1, "Owen Alexander Amador Padilla", 10, 2);

            miGaraje.IngresarAuto(new Auto(1, "Toyota", "HCH-123"));
            miGaraje.IngresarAuto(new Auto(2, "Honda", "FKS-456"));
            miGaraje.IngresarAuto(new Auto(3, "Hyundai", "FCB-789"));
            return View(miGaraje);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
