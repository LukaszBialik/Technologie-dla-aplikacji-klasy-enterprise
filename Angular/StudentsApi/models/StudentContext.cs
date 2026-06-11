using Microsoft.EntityFrameworkCore;

namespace StudentsApi.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        // DODAJ TEN NOWY PUSTY KONSTRUKTOR:
        public StudentContext()
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}