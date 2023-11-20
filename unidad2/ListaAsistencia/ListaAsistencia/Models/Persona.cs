using System.Security.Principal;

namespace ListaAsistencia.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? NumeroCuenta { get; set;}
        public string Asistencia { get; set; }

    }
}
