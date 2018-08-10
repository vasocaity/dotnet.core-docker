using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class DataContext: DbContext
    {
        private readonly IDataContext _datacontext;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=mariadb;uid=myuser;pwd=1234;database=mydb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
            .HasOne<Grade>(s => s.CurrentGrade)
            .WithMany(g => g.Student)
            .HasForeignKey(s => s.CurrentGradeId);
        }

        public DbSet<Data> Data { get; set;}
        public DbSet<Student> Student {get; set;}
        public DbSet<Grade> Grade { get; set; }
    }
}