using SRS_LMS.Model;
using Microsoft.EntityFrameworkCore;

namespace SRS_LMS.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<TypeExam> Types { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}
