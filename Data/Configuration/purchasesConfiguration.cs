using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRUEBAPRACTICA.Models;

namespace PRUEBAPRACTICA.Data.Configuration
{
    public class purchasesConfiguration : IEntityTypeConfiguration<purchases>
    {
        public void Configure(EntityTypeBuilder<purchases> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("purchases");
            
            builder.Property(e => e.CustomerId)
                .HasColumnName("customerID");

            builder.Property(e => e.CardId)
                .HasColumnName("carId");
            
            builder.Property(e => e.Date)
                .HasColumnName("date");
            
            builder.Property(e => e.Price)
                .HasColumnName("price");
        }
    }
}
