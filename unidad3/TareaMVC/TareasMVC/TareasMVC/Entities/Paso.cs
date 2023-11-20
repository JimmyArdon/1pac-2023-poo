using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace TareasMVC.Entities
{
        [Table("pasos")]
    public class Paso 
    {
        [Column("id")]
        
        public Guid Id{ get; set; }
        [Column("tarea_id")]
        public int TareaId { get; set; }

        [ForeignKey(nameof(TareaId))]
        public Tarea Tarea { get; set; }

        [Column("descripcion")]
        public string Descripcion { get; set; }

        [Column("completado")]
        public bool Completado { get; set; }

        public int Orden { get; set; }

    }
}
