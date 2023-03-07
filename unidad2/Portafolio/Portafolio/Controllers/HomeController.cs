using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
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
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos};
            return View();

        }

        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>
            {
                new Proyecto {
                    Titulo = "La Prensa",
                    Descripcion = "Aplicacion de Planilla realizado en ASP.Net Core",
                    ImagenUrl = " /images/pic-laprensa.png",
                    Link = "http://laprensa.hn"
                },
                new Proyecto {
                    Titulo = "Diunsa",
                    Descripcion = "E-commerce desarrollado en React",
                    ImagenUrl = " /images/pic-diunsa.png",
                    Link = "http://diunsa.hn"
                },

                new Proyecto {
                    Titulo = "Jetstereo",
                    Descripcion = "Desarrollo de un sistema de cotizaciones Online en React",
                    ImagenUrl = " /images/pic-jetstereo.png",
                    Link = "http://jetstereo.com"
                },

                new Proyecto {
                    Titulo = "Unah",
                    Descripcion = "Sistema de Matricula en ASP.Net Core con base de datos Oracle",
                    ImagenUrl = " /images/pic-unah.png",
                    Link = "http://unah.edu.hn"
                },
            };
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