
using DrivingApp.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrivingApp.Infrastructure
{
    public class CountryConfiguration:BaseConfiguration<Country>
    {
        public override void Configure(EntityTypeBuilder<Country> builder)
        {
            base.Configure(builder);

            builder.Property(x=>x.Name).IsRequired();
            builder.Property(x=>x.Abbreviation).IsRequired();
            builder.Property(x=>x.IsActive).IsRequired();
        }
    }
}
