using Microsoft.EntityFrameworkCore;

namespace dotnetdocker.Models
{
    public class DataContext: DbContext
    {
        public DbSet<Data> Data { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;uid=myuser;pwd=1234;database=mydb");
        }
    }
}