
using DrivingApp.Core;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrivingApp.Infrastructure
{
    public class ConditionConfiguration : BaseConfiguration<Condition>
    {
        public override void Configure(EntityTypeBuilder<Condition> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x=>x.Description).IsRequired(false);

            //if one-many realation, only cofigure where is many
        }
    }
}
