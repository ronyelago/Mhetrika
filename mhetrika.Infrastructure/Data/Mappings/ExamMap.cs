using mhetrika.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace mhetrika.Infrastructure.Data.Mappings
{
    public class ExamMap : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.ToTable("Exams");
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Laboratory)
                .WithMany(p => p.Exams)
                .HasForeignKey(p => p.LaboratoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Doctor)
                .WithMany(p => p.Exams)
                .HasForeignKey(p => p.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(p => p.Name)
                .HasColumnType("varchar(32)");

            builder.Property(p => p.CreationDate)
                .HasColumnType("datetime2");
        }
    }
}
