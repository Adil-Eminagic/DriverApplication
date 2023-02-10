

using DrivingApp.Core;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrivingApp.Infrastructure
{
    public class RideConditionConfiguration : BaseConfiguration<RideCondition>
    {
        public override void Configure(EntityTypeBuilder<RideCondition> builder)
        {
            base.Configure(builder);


            builder.HasOne(x => x.Ride).
                WithMany(r => r.Conditions).
                HasForeignKey(x => x.RideId).
                IsRequired();

            builder.HasOne(x => x.Condition).
                WithMany(c => c.Rides).
                HasForeignKey(x => x.ConditionId).
                IsRequired();
        }
    }
}
