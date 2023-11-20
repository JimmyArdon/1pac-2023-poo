using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using ClinicaOptica.Validaciones;
using Dapper;
using Microsoft.OData.Edm;

namespace ClinicaOptica.Models
{
    public class Usuario : IValidatableObject
    {
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El {0} es requerido")]
        [PrimeraLetraMayuscula]
       
        public string Nombre { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El {0} es requerido")]
        public string Apellido { get; set; }

        [Range(minimum: 18, maximum: 130, ErrorMessage = "El valor de {0} debe ser entre {1} y {2}")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [EmailAddress(ErrorMessage = "El {0} debe ser un correo electronico")]
        public string Email { get; set; }

        public string NumeroTelefono { get; set; }

        public DateTime FechaCita { get; set; }
       
        [Display(Name = "Clinica")]
        [Required(ErrorMessage = "El {0} es requerido")]
        public string Clinica { get; set; }

        [Display(Name = "Doctor")]
        [Required(ErrorMessage = "El {0} es requerido")]
        public string Doctor { get; set; }
 

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if (Nombre != null && Nombre.Length > 0)
            {
                var primeraLetra = Nombre.ToString()[0].ToString();
                if (primeraLetra != primeraLetra.ToUpper())
                {
                    yield return new ValidationResult("La primera letra debe ser mayúscula",
                        new[] { nameof(Nombre) });

                }
            }
        }

    }
}
