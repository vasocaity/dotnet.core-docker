using Microsoft.EntityFrameworkCore;

namespace dotnetdocker.Models
{
    public class DataContext: DbContext
    {
        public DbSet<Data> Data { get; set;}
        public DbSet<Student> Student {get; set;}
        public DbSet<Grade> Grade { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=mariadb;uid=myuser;pwd=1234;database=mydb");
        }
    }
}