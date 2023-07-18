using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CreateAPI.Models
{
    public class Quiz
    {
        public Quiz()
        {
            Questions = new HashSet<Question>();
            QuizAttendances = new HashSet<QuizAttendance>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int QuizId { get; set; }

        [ForeignKey(nameof(Course))]
        [Required]
        public int CourseId { get; set; }

        
        public string? Title { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<QuizAttendance> QuizAttendances { get; set; }

    }
}
