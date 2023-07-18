using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.ModelDTOs
{
    internal class QuizDTO
    {
        public int AttendanceId { get; set; }
        public int QuizId { get; set; }
        public string StudentId { get; set; }
        public int? Score { get; set; }
        public virtual QuizDTO Quiz { get; set; } = null!;
        public virtual UserDTO Student { get; set; } = null!;
    }
}
