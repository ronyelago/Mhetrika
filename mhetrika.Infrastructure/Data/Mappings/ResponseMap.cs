using mhetrika.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace mhetrika.Infrastructure.Data.Mappings
{
    public class ResponseMap : IEntityTypeConfiguration<Response>
    {
        public void Configure(EntityTypeBuilder<Response> builder)
        {
            builder.ToTable("Responses");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Description)
                .HasColumnType("varchar(8)")
                .IsRequired();
        }
    }
}
