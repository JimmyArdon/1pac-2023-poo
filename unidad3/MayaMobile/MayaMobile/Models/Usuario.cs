using Dapper;
using Microsoft.OData.Edm;
using Microsoft.AspNetCore.Mvc;

namespace MayaMobile.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Usuarios { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Clave { get; set; }

        public string ConfirmarClave { get; set; }
    }

}
