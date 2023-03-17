using AgendaTelefonica.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace AgendaTelefonica.Controllers
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
            return View();
        }
         public static List<Datos> _datos = new List<Datos>();
    public IActionResult Agenda()
        {
            return View(_datos);
        }

        public IActionResult Privacy()
        {
            return View();
        }
       

        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Datos contacto)
        {
            contacto.Id = _datos.Count + 1;
            _datos.Add(contacto);
            _logger.LogCritical(contacto.Nombre);
            return RedirectToAction(nameof(Agenda));
        }

        public IActionResult Editar(int id)
        {
            Datos contacto = _datos.FirstOrDefault(c => c.Id == id);
            if (contacto == null)
            {
                return NotFound();
            }
            return View(contacto);
        }

        [HttpPost]
        public IActionResult Editar(Datos contacto)
        {
            Datos contactoExistente = _datos.FirstOrDefault(c => c.Id == contacto.Id);
            if (contactoExistente != null)
            {
                contactoExistente.Nombre = contacto.Nombre;
                contactoExistente.Apellidos = contacto.Apellidos;
                contactoExistente.Telefono = contacto.Telefono;
                contactoExistente.TipoTelefono = contacto.TipoTelefono;
            }
            return RedirectToAction("Agenda");
        }

            public IActionResult Eliminar(int id)
            {
            Datos contacto = _datos.FirstOrDefault(c => c.Id == id);
                if (contacto == null)
                {
                    return NotFound();
                }
                return View(contacto);
            }

            [HttpPost]
            public IActionResult Eliminar(Datos contacto)
            {
                Datos contactoExistente = _datos.FirstOrDefault(c => c.Id == contacto.Id);
                if (contactoExistente != null)
                {
                    _datos.Remove(contactoExistente);
                }
                return RedirectToAction("Agenda");
            }
        }

    //    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //    public IActionResult Error()
    //    {
    //        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //    }
    //}

}