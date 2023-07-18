using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CreateAPI.Models
{
    public class QuizAttendance
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AttendanceId { get; set; }

        [ForeignKey(nameof(Quiz))]
        [Required]
        public int QuizId { get; set; }

        [ForeignKey(nameof(Student))]
        [Required]
        public string StudentId { get; set; }


        public int? Score { get; set; }

        public virtual Quiz Quiz { get; set; } = null!;
        public virtual User Student { get; set; } = null!;
    }
}
