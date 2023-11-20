using ListaAsistencia.Models;
using ListaAsistencia.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace ListaAsistencia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IListaAsistencia listaAsistencia;

        public HomeController(
            ILogger<HomeController> logger,
            IListaAsistencia listaAsistencia
            )
        {
            _logger = logger;
            this.listaAsistencia = listaAsistencia;
        }

        public IActionResult Index()
        {

            return View();
        }

        public static List<Persona> datos = new List<Persona>();
       
        public IActionResult Resumen()
        {
            List<Persona> presentes = datos.Where(c => c.Asistencia == "Presente").ToList();
            List<Persona> ausentes = datos.Where(c => c.Asistencia == "Ausente").ToList();

            ViewBag.Presentes = presentes;
            ViewBag.Ausentes = ausentes;

            return View(datos);
        }

        [HttpPost]
        public IActionResult Resumen(List<Persona> datos)
        {
          

            return RedirectToAction("Resumen");
        }

        public IActionResult Lista()
        {
            //var lista = listaAsistencia.ObtenerLista();
            //return View(lista);

            return View(datos);
        }

        public IActionResult Asistencia()
        {
            
            //var lista = listaAsistencia.ObtenerLista();
            return View(datos);
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Persona contacto)
        {
            contacto.Id = datos.Count + 1;
            datos.Add(contacto);
            return RedirectToAction(nameof(Lista));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}