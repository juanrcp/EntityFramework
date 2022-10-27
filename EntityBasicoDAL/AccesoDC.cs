using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntityBasicoDAL
{
    public class AccesoDC : DbContext
    {
        public AccesoDC(DbContextOptions<AccesoDC> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<empleado> empleados { get; set; }
        public DbSet<nivel_acc> nivel_accesos { get; set; }
    }
}
