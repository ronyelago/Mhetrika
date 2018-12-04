using mhetrika.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace mhetrika.Infrastructure.Data.Mappings
{
    public class LaboratoryMap : IEntityTypeConfiguration<Laboratory>
    {
        public void Configure(EntityTypeBuilder<Laboratory> builder)
        {
            builder.ToTable("Laboratories");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasColumnType("varchar(64)")
                .IsRequired();

            builder.Property(p => p.Cnpj)
                .HasColumnType("varchar(32)")
                .IsRequired();

            builder.Property(p => p.Email)
                .HasColumnType("varchar(32)")
                .IsRequired();
        }
    }
}
