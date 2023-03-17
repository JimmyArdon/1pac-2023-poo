using ListaTareas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace ListaTareas.Controllers
{
    public class TareaController : Controller
    {
        private static List<TareaViewModel> _tareas = new List<TareaViewModel>();

        [HttpPost]
        public IActionResult AgregarTarea(TareaViewModel tarea)
        {
            _tareas.Add(tarea);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult BorrarTareas()
        {
            _tareas.Clear();
            return RedirectToAction("Index");
        }
    }

}
