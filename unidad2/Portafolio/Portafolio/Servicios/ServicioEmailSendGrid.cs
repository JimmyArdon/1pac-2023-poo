using Portafolio.Models;
using Portafolio.Models.Interfaces;
using SendGrid.Helpers.Mail;
using SendGrid;

namespace Portafolio.Servicios
{
    public class ServicioEmailSendGrid : IServicioEmail
    {
        private readonly IConfiguration configuracion;

        public ServicioEmailSendGrid(IConfiguration configuracion)
        {
            this.configuracion = configuracion;
        }
        public async Task Enviar (ContactoViewModel contactoViewModel){

            var apikey = configuracion.GetValue<string>("SENDGRID_API_KEY");
            var email = configuracion.GetValue<string>("SENDGRID_FROM");
            var nombre = configuracion.GetValue<string>("SENDGRID_NOMBRE");

            var cliente = new SendGridClient(apikey);
            var from = new EmailAddress(email, nombre);
            var subject = $"El cliente {contactoViewModel.Email} quiere contactarte";
            var to = new EmailAddress(email, nombre);
            var mensajeTextoPlano = contactoViewModel.Mensaje;
            var contenidoHtml = $@"De: {contactoViewModel.Nombre} 
            Email: {contactoViewModel.Email}
            Mensaje: {contactoViewModel.Mensaje}";

            var sigleEmail = MailHelper.CreateSingleEmail(from, to, subject, mensajeTextoPlano, contenidoHtml);
            var respuesta = await cliente.SendEmailAsync(sigleEmail);
            
        }

    }
}
