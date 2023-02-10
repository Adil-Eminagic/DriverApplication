

using DrivingApp.Core;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DrivingApp.Infrastructure
{
    public class UserRideConfiguration :BaseConfiguration<UserRide>
    {
        public override void Configure(EntityTypeBuilder<UserRide> builder)
        {
            base.Configure(builder);

            builder.Property(x=>x.Price).IsRequired();
            builder.Property(x=> x.ReviewRatng).IsRequired(false);
            builder.Property(x=>x.ReviewComment).IsRequired(false);
           
            //many to many relationship
            builder.HasOne(x => x.Ride).
                WithMany(r => r.Passengers).
                HasForeignKey(x => x.RideId).
                IsRequired();
             // user cann't buy one card for more than one rides

            builder.HasOne(x => x.User).
                WithMany(r => r.UserRides).
                HasForeignKey(x => x.UserId).
                IsRequired();
            // one user cann't buy two or more tickets for one ride
        }
    }
}
