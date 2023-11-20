using ClinicaOptica.Models;

namespace ClinicaOptica.Servicios
{
    public interface IRepositorioUsuario
    {
        Task Cita(Usuario cita);
       
    }
}