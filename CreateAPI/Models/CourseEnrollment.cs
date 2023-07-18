using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CreateAPI.Models
{
    public class CourseEnrollment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EnrollmentId { get; set; }

        [ForeignKey(nameof(Course))]
        [Required]
        public int CourseId { get; set; }

        [ForeignKey(nameof(Student))]
        [Required]
        public string StudentId { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual User Student { get; set; } = null!;
    }
}
