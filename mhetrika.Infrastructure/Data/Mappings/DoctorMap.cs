using mhetrika.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace mhetrika.Infrastructure.Data.Mappings
{
    public class DoctorMap : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.ToTable("Doctors");

            builder.Property(p => p.Crm)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(p => p.Uf)
                .HasColumnType("varchar(2)")
                .IsRequired();

            builder.Property(p => p.Phone)
                .HasColumnType("varchar(16)");

            builder.Property(p => p.Specialty)
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}
