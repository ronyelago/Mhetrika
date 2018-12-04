using mhetrika.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace mhetrika.Infrastructure.Data.Mappings
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Cep)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(p => p.Number)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Street)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(p => p.Neighbourhood)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(p => p.City)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(p => p.Uf)
                .HasColumnType("varchar(2)")
                .IsRequired();
        }
    }
}
