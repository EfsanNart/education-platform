using EduPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace EduPlatform.Data
{
    public class EduPlatformContext:DbContext
    {
        public EduPlatformContext(DbContextOptions<EduPlatformContext>options): base(options) 
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Instructor)
                .WithMany(i => i.Courses) 
                .HasForeignKey(c => c.InstructorId);
            
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(c => c.Course)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(c => c.CourseId);

            modelBuilder.Entity<Course>()
                .Property(c => c.Price)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor
                {
                    Id = 1,
                    FirstName = "John Doe",
                    LastName = "Doe",
                    Email = "jdoe@gmail.com"
                }
                );


        }
    }
}
