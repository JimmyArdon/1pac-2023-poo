namespace Portafolio.Models.Interfaces
{
    public interface IServicioEmail
    {
        Task Enviar(ContactoViewModel contactoViewModel);
    }
}
