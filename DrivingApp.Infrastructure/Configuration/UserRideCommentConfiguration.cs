

using DrivingApp.Core;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DrivingApp.Infrastructure
{
    public class UserRideCommentConfiguration :BaseConfiguration<UserRideComment>
    {
        public override void Configure(EntityTypeBuilder<UserRideComment> builder)
        {
            base.Configure(builder);

            builder.Property(x=>x.Comment).IsRequired();
           

            builder.HasOne(x => x.UserRide).
                WithMany(r => r.Comments).
                HasForeignKey(x => x.UserRideId).
                IsRequired();
            //one travel can have many comments, 
            // but one comment belogns to only one travel
            //and only users who are included in that travel
            //can add comments on it
        }
    }
}
