using mhetrika.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace mhetrika.Infrastructure.Data.Mappings
{
    public class ResultMap : IEntityTypeConfiguration<Result>
    {
        public void Configure(EntityTypeBuilder<Result> builder)
        {
            builder.ToTable("Results");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Description)
                .HasColumnType("varchar(8)");
        }
    }
}
