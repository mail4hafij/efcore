using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using src.db.data.model;

namespace src.db.builder
{
    public class LandlordBuilder : IEntityTypeConfiguration<Landlord>
    {
        public void Configure(EntityTypeBuilder<Landlord> builder)
        {
            builder.ToTable("Landlords");
            builder.Property(p => p.LandlordId);
            builder.Property(p => p.Name);

            builder.HasData(
                new Landlord(1, "BRF default")
            );
            
        }
    }
}
