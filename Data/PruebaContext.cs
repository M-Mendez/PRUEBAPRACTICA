using Microsoft.EntityFrameworkCore;
using PRUEBAPRACTICA.Data.Configuration;
using PRUEBAPRACTICA.Models;

namespace PRUEBAPRACTICA.Data
{
    public class PruebaContext: DbContext
    {
        public PruebaContext(DbContextOptions options) : base(options)
        { }

        public virtual DbSet<cars> cars { get;set; }
        public virtual DbSet<customers> customers { get;set; }
        public virtual  DbSet<purchases> puschases { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new customersConfiguration());
            builder.ApplyConfiguration(new carsConfiguration());
            builder.ApplyConfiguration(new purchasesConfiguration());

        }

    }
}
