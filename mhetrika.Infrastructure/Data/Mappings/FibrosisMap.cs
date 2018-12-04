using mhetrika.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace mhetrika.Infrastructure.Data.Mappings
{
    public class FibrosisMap : IEntityTypeConfiguration<Fibrosis>
    {
        public void Configure(EntityTypeBuilder<Fibrosis> builder)
        {
            builder.ToTable("Fibrosis");
            builder.Property(p => p.Age).IsRequired();
            builder.Property(p => p.AST).IsRequired();
            builder.Property(p => p.ALT).IsRequired();
            builder.Property(p => p.IMC).IsRequired();
            builder.Property(p => p.Platelets).IsRequired();
            builder.Property(p => p.Albumin).IsRequired();
            builder.Property(p => p.Diabetic).IsRequired();
        }
    }
}
