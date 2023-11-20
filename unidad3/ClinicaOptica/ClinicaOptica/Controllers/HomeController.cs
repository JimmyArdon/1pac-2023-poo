using ClinicaOptica.Models;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using Microsoft.Data.SqlClient;
using ClinicaOptica.Servicios;

namespace ClinicaOptica.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly IRepositorioUsuario repositorioUsuario;
        private readonly IServicioUsuarios servicioUsuarios;
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,
            IRepositorioUsuario repositorioUsuario, 
            IServicioUsuarios servicioUsuarios
            )
        {
            _logger = logger;
            this.repositorioUsuario = repositorioUsuario;
            this.servicioUsuarios = servicioUsuarios;
           
        }


        
        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cita()
        {
            var modelo = new Usuario();
            return View(modelo);
        }

        [HttpPost]
        public async Task<IActionResult> Cita(Usuario modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await repositorioUsuario.Cita(modelo);

                    
                    return RedirectToAction("CitaExitosa");
                }
                catch (Exception ex)
                {
                   
                    return RedirectToAction("CitaError");
                }
            }

           
            return View(modelo);
        }
        public IActionResult CitaExitosa()
        {
            return View();
        }

        public IActionResult CitaError()
        {
            return View();
        }





        public IActionResult Historia()
        {
            return View();
        }

        public IActionResult Vision()
        {
            return View();
        }

        public IActionResult Mision()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }

        public IActionResult Clinica()
        {
            return View();
        }

        public IActionResult ClinicaSrc()
        {
            return View();
        }

        public IActionResult ClinicaSps()
        {
            return View();
        }

        public IActionResult ServiciosClinica()
        {
            return View();
        }

    }
}