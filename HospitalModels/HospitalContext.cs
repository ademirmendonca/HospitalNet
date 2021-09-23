using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModels
{
    public class HospitalContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<TipoExame> TipoExames { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<HospitalContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
