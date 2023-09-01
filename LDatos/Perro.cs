using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LDatos
{
    public class Perro
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string Nombre { get; set; } = string.Empty;
        [Column(TypeName = "varchar(250)")] [Required]public string Direccion { get; set; } = string.Empty;
        [ForeignKey("DuenoId")]
        public int? DuenoId { get; set; }
        [JsonIgnore]
        public Persona Dueno { get; set; }
    }
}
