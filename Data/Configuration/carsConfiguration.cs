using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRUEBAPRACTICA.Models;

namespace PRUEBAPRACTICA.Data.Configuration
{
    public class carsConfiguration : IEntityTypeConfiguration<cars>
    {
        public void Configure(EntityTypeBuilder<cars> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("cars");
            
            builder.Property(e => e.Make)
                .HasColumnName("make");

            builder.Property(e => e.Model)
                .HasColumnName("model");
            
            builder.Property(e => e.Year)
                .HasColumnName("year");
            
            builder.Property(e => e.Color)
                .HasColumnName("color");
            
            builder.Property(e => e.Price)
                .HasColumnName("price");               
        }
    }
}
