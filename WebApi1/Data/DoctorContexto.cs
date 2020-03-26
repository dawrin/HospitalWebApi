using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi1.Modelos;

namespace WebApi1.Data
{
    public class DoctorContexto:DbContext
    {
        public DoctorContexto(DbContextOptions<DoctorContexto> options) : base(options)
        {

        }
        public DbSet<Doctor> DoctorItem { get; set; }
    }
}
