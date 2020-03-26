using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi1.Modelos
{
    public class Paciente
    {
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Telefono { get; set; }
        [Required]
        public string Cedula { get; set; }
        [Required]
        public bool Seguro { get; set; }
    }
}
