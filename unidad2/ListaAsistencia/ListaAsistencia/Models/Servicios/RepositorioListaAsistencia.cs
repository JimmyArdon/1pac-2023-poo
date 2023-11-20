using ListaAsistencia.Models.Interfaces;

namespace ListaAsistencia.Models.Servicios
{
    public class RepositorioListaAsistencia : IListaAsistencia
    {
        public List<Persona> ObtenerLista()
        {
            return new List<Persona>
            {

            new Persona
            {
                Id= 1,
                Nombre = "Juan",
                Apellidos = "Perez",
                NumeroCuenta = "20182144559"
            },
            new Persona
            {
                Id= 2,
                Nombre = "Jorge",
                Apellidos = "Sandoval",
                NumeroCuenta = "20182100048"
            },
                new Persona
            {
                Id= 3,
                Nombre = "Maria",
                Apellidos = "Mejia",
                NumeroCuenta = "20182100045"
            },
                new Persona
            {
                Id= 4,
                Nombre = "Nicol",
                Apellidos = "Altamirano",
                NumeroCuenta = "20182100005"
            },
                new Persona
            {
                Id= 5,
                Nombre = "Nicolas",
                Apellidos = "Castellanos",
                NumeroCuenta = "20182100008"
            }
            };
        }
    }
}
