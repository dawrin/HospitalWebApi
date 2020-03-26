using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi1.Modelos;

namespace WebApi1.Data
{
    public class MedicamentoContexto:DbContext
    {
        public MedicamentoContexto(DbContextOptions<MedicamentoContexto>options):base(options) 
        {
                
        }
        public DbSet<Medicamento> MedicamentoItem { get; set; }
    }
}
