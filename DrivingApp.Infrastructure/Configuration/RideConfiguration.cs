

using DrivingApp.Core;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DrivingApp.Infrastructure
{
    public class RideConfiguration :BaseConfiguration<Ride>
    {
        public override void Configure(EntityTypeBuilder<Ride> builder)
        {
            base.Configure(builder);

            builder.Property(x=>x.Price).IsRequired();
            builder.Property(x=> x.StartDateTime).IsRequired();
            builder.Property(x=>x.EndDateTime).IsRequired(false);
            builder.Property(x=>x.MaxPassengers).IsRequired();

            builder.Property(x => x.PaymentType).IsRequired();
            builder.Property(x => x.CommunicationType).IsRequired();
            builder.Property(x => x.Notes).IsRequired(false);
           

            builder.HasOne(x => x.Driver).
                WithMany(r => r.Rides).
                HasForeignKey(x => x.DriverId).
                IsRequired();

        }
    }
}
