

using DrivingApp.Core;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DrivingApp.Infrastructure
{
    public class PhotoConfiguration :BaseConfiguration<Photo>
    {
        public override void Configure(EntityTypeBuilder<Photo> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Data).IsRequired();
            builder.Property(x=> x.ContentType).IsRequired();
            
        }
    }
}
