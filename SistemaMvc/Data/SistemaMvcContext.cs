using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaMvc.Models;

namespace SistemaMvc.Data
{
    public class SistemaMvcContext : DbContext
    {
        public SistemaMvcContext (DbContextOptions<SistemaMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaMvc.Models.Departamento> Departamento { get; set; }
    }
}
