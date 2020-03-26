using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi1.Modelos
{
    public class Medicamento
    {
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        public int Miligramos { get; set; }
        [Required]
        public string Fecha { get; set; }
    }
}
