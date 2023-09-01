using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDatos
{
    [Table("Personas")]
    public class Persona
    {

            [Key]
            public int Id { get; set; }

            [Column(TypeName = "varchar(25)")]
            public string Nombre { get; set; } = string.Empty;
            
            [Column(TypeName = "varchar(250)")]
            public string Direccion { get; set; } = string.Empty;
            public List<Perro> Mascotas { get; set; }
        
    }
}
