using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TareasMVC.Entities
{
    [Table("archivos_adjuntos")]
    public class ArchivoAdjunto
    {
        [Column("id")]
        public Guid id { get; set; }
        [Column("tarea_id")]
        public int TareaId { get; set; }

        [ForeignKey(nameof(TareaId))]
        public Tarea Tarea { get; set; }

        [Column("url")]
        [Unicode]
        public string Url { get; set; }

        [Column("titulo")]
        [Required]
        public string Titulo { get; set; }

        [Column("orden")]
        public int Orden { get; set; }

        [Column("fecha_creacion")]

        public DateTime FechaCreacion { get; set; }
    }
}
