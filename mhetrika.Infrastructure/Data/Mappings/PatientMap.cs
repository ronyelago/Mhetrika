using mhetrika.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace mhetrika.Infrastructure.Data.Mappings
{
    public class PatientMap : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("Patients");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.Gender)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(p => p.BirthDate)
                .HasColumnType("datetime2");

            builder.Property(p => p.Cpf)
                .HasColumnType("varchar(20)");

            builder.Property(p => p.Email)
                .HasColumnType("varchar(32)");

            builder.Property(p => p.Phone)
                .HasColumnType("varchar(20)");

        }
    }
}
