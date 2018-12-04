using mhetrika.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace mhetrika.Infrastructure.Data.Mappings
{
    public class CardioMap : IEntityTypeConfiguration<Cardio>
    {
        public void Configure(EntityTypeBuilder<Cardio> builder)
        {
            builder.ToTable("Cardio");
            builder.Property(p => p.Pas).IsRequired();
            builder.Property(p => p.Ldl_c).IsRequired();
            builder.Property(p => p.Hdl_c).IsRequired();
            builder.Property(p => p.Ct).IsRequired();
            builder.Property(p => p.Status).IsRequired();
            builder.Property(p => p.Smokes).IsRequired();
            builder.Property(p => p.Statin).IsRequired();
        }
    }
}
