using CreateAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CreateAPI.Data
{
    public class ProjectPRN231Context : IdentityDbContext<User>
    {
        public ProjectPRN231Context(DbContextOptions<ProjectPRN231Context> options) : base(options)
        {

        }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> quizzes { get; set; }
        public DbSet<QuizAttendance> QuizAttendances { get; set; }
        public DbSet<StudentAssignment> StudentAssignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserLogin<string>>()
                .HasKey(l => new { l.LoginProvider, l.ProviderKey });

            modelBuilder.Entity<Assignment>().ToTable("Assignment").HasOne(ce => ce.Course)
                  .WithMany(c => c.Assignments)
                  .HasForeignKey(ce => ce.CourseId)
                  .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Course>().ToTable("Course");

            modelBuilder.Entity<CourseEnrollment>().ToTable("CourseEnrollment").HasOne(ce => ce.Course)
                  .WithMany(c => c.CourseEnrollments)
                  .HasForeignKey(ce => ce.CourseId)
                  .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Question>().ToTable("Question").HasOne(ce => ce.Quiz)
                  .WithMany(c => c.Questions)
                  .HasForeignKey(ce => ce.QuizId)
                  .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Quiz>().ToTable("Quiz").HasOne(ce => ce.Course)
                  .WithMany(c => c.Quizzes)
                  .HasForeignKey(ce => ce.CourseId)
                  .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<QuizAttendance>().ToTable("QuizAttendance").HasOne(ce => ce.Quiz)
                  .WithMany(c => c.QuizAttendances)
                  .HasForeignKey(ce => ce.QuizId)
                  .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<StudentAssignment>().ToTable("StudentAssignment").HasOne(ce => ce.Assignment)
                  .WithMany(c => c.StudentAssignments)
                  .HasForeignKey(ce => ce.AssignmentId)
                  .OnDelete(DeleteBehavior.Restrict); ;


        }
    }
}
