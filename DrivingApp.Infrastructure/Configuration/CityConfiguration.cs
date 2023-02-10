
using DrivingApp.Core;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrivingApp.Infrastructure
{
    public class CityConfiguration : BaseConfiguration<City>
    {
        public override void Configure(EntityTypeBuilder<City> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.ZipCode).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();

            builder.HasOne(x => x.Country)
                .WithMany(c => c.Cities)
                .HasForeignKey(x => x.CountryId)
                .IsRequired();
        }
    }
}
