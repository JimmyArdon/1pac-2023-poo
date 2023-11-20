using Dapper;
using Microsoft.OData.Edm;
using Microsoft.AspNetCore.Mvc;

namespace MayaMobile.Models
{
    public class UsuarioLogin
    {
        public int Id { get; set; }

        public string Correo { get; set; }
        public string Clave { get; set; }

        public string ConfirmarClave { get; set; }
    }

}
