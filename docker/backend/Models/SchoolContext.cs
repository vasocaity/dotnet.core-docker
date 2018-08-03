using Microsoft.EntityFrameworkCore;

namespace dotnetdocker.Models
{
    public class SchoolContext : DbContext
    {
         public SchoolContext(): base()
        {
            
        }
            
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}