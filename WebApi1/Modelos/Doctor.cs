using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi1.Modelos
{
    public class Doctor
    {
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Telefono { get; set; }
        public string Area { get; set; }
        public bool Expericencia { get; set; }

    }
}
