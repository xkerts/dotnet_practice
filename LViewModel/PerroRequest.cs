using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LViewModel
{
    public class PerroRequest
    {
        public string Nombre { get; set; } = string.Empty;
     
        [Required] 
        public string Direccion { get; set; } = string.Empty;
        [Required]
        public int DuenoId { get; set; }
    }
}
