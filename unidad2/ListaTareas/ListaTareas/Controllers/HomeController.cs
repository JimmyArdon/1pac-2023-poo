using ListaTareas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading;

namespace ListaTareas.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly ILogger<HomeController> _logger;

        public HomeController(
            ILogger<HomeController> logger )
        {
           
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();

            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ListaTarea()
        {
            
            return View();
        }


        [HttpPost]
        public IActionResult ListaTarea(TareaViewModel datos)
        {

            return View(datos);

        }

        public IActionResult Agregado()
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