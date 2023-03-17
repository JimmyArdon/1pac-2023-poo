using Portafolio.Models;
using Portafolio.Models.Interfaces;

namespace Portafolio.Servicios
{
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
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
                }
            };
        }
    }
}
