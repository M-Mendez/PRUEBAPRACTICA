using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRUEBAPRACTICA.Models;

namespace PRUEBAPRACTICA.Data.Configuration
{
    public class customersConfiguration : IEntityTypeConfiguration<customers>
    {
        public void Configure(EntityTypeBuilder<customers> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("customers");
            
            builder.Property(e => e.firstname)
                .HasColumnName("firstname");

            builder.Property(e => e.lastName)
                .HasColumnName("lastname");
            
            builder.Property(e => e.phone)
                .HasColumnName("phone");
            
            builder.Property(e => e.address)
                .HasColumnName("address");
            
            builder.Property(e => e.city)
                .HasColumnName("city");
            
            builder.Property(e => e.state)
                .HasColumnName("state");
            
            builder.Property(e => e.zipcode)
                .HasColumnName("zip");
        }
    }
}
