using mhetrika.core.Entities;
using mhetrika.Infrastructure.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace mhetrika.Infrastructure.Data
{
    public class MhetrikaContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Laboratory> Laboratories { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Response> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressMap());
            modelBuilder.ApplyConfiguration(new PatientMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new DoctorMap());
            modelBuilder.ApplyConfiguration(new ExamMap());
            modelBuilder.ApplyConfiguration(new LaboratoryMap());
            modelBuilder.ApplyConfiguration(new CardioMap());
            modelBuilder.ApplyConfiguration(new FibrosisMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=mssql.mflogic.com.br;initial catalog=Sql_mhetrika;persist security info=True;user id=mflogic;password=stl668?Z;MultipleActiveResultSets=True;App=EntityFramework");
        }
    }
}
