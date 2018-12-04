using mhetrika.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace mhetrika.Infrastructure.Data.Mappings
{
    public class QuizMap : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.ToTable("Questions");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Description)
                .HasColumnType("varchar(128)")
                .IsRequired();
        }
    }
}
