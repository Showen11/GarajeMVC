using System.Diagnostics;
using GarajeMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GarajeMVC.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Garage miGaraje = new Garage(1, "Owen Alexander Amador Padilla", 10, 2);

            miGaraje.IngresarAuto(new Auto(1, "Toyota", "HCH-1232"));
            miGaraje.IngresarAuto(new Auto(2, "Honda", "FKS-4561"));
            miGaraje.IngresarAuto(new Auto(3, "Hyundai", "FCB-7895"));
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
