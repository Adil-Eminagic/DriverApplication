

using DrivingApp.Core;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DrivingApp.Infrastructure
{
    public class VehicleConfiguration :BaseConfiguration<Vehicle>
    {
        public override void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            base.Configure(builder);

            builder.Property(x=>x.Make).IsRequired();
            builder.Property(x=> x.Model).IsRequired();
            builder.Property(x=>x.Color).IsRequired();
            builder.Property(x => x.Notes).IsRequired(false);

            
            builder.HasOne(x => x.User).
                WithMany(r => r.Vehicles).
                HasForeignKey(x => x.UserId).
                IsRequired();
            

            
            
        }
    }
}
