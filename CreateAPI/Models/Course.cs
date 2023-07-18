using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CreateAPI.Models
{
    public class Course
    {
        public Course()
        {
            Assignments = new HashSet<Assignment>();
            CourseEnrollments = new HashSet<CourseEnrollment>();
            Quizzes = new HashSet<Quiz>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CourseId { get; set; }

        [MaxLength(255)]
        public string? Title { get; set; }
        public string? Description { get; set; }

        [Required]
        [ForeignKey(nameof(Lecturer))]
        public string LecturerId { get; set; }

        public virtual User Lecturer { get; set; } = null!;
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<CourseEnrollment> CourseEnrollments { get; set; }
        public virtual ICollection<Quiz> Quizzes { get; set; }

    }
}
