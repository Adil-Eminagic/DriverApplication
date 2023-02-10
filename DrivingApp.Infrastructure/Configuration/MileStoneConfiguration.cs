

using DrivingApp.Core;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DrivingApp.Infrastructure
{
    public class MileStoneConfiguration :BaseConfiguration<MileStone>
    {
        public override void Configure(EntityTypeBuilder<MileStone> builder)
        {
            base.Configure(builder);

            builder.Property(x=>x.LocationName).IsRequired();
            builder.Property(x=> x.MileStoneType).IsRequired();
            builder.Property(x=>x.DateTime).IsRequired(false);
            builder.Property(x=>x.Notes).IsRequired(false);

            builder.HasOne(x => x.Ride).WithMany(r => r.MileStones).HasForeignKey(x => x.RideId).IsRequired();

            builder.HasOne(x=>x.City).WithMany(c=>c.MileStones).HasForeignKey(x=>x.CityId).IsRequired();
        }
    }
}
