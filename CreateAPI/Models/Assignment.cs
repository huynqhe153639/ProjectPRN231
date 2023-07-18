using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CreateAPI.Models
{
    public class Assignment
    {
        public Assignment()
        {
            StudentAssignments = new HashSet<StudentAssignment>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AssignmentId { get; set; }

        [Required]
        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }

        [MaxLength(255)]
        public string? Title { get; set; }

        [MaxLength(255)]
        public string? Description { get; set; }
        public DateTime? Deadline { get; set; }

        [MaxLength(255)]
        public string? File { get; set; }
        public virtual ICollection<StudentAssignment> StudentAssignments { get; set; }
        public virtual Course Course { get; set; } = null!;
    }
}