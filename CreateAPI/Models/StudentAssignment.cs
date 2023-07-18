using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CreateAPI.Models
{
    public class StudentAssignment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int SubmissionId { get; set; }

        [ForeignKey(nameof(Assignment))]
        [Required]
        public int AssignmentId { get; set; }

        [ForeignKey(nameof(Student))]
        [Required]
        public string StudentId { get; set; }

        public string? File { get; set; }
        public DateTime? SubmissionDate { get; set; }

        public virtual Assignment Assignment { get; set; } = null!;
        public virtual User Student { get; set; } = null!;
    }
}
