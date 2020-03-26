using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi1.Modelos;

namespace WebApi1.Data
{
    public class PacienteContexto: DbContext
    {
        public PacienteContexto(DbContextOptions<PacienteContexto> options) : base(options)
        {

        }
        public DbSet<Paciente> PacienteItem { get; set; }
    }
}
