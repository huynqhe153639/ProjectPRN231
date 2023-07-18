using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.ModelDTOs
{
    internal class CourseDTO
    {
        public CourseDTO()
        {
            Assignments = new HashSet<AssignmentDTO>();
            CourseEnrollments = new HashSet<CourseEnrollmentDTO>();
            Quizzes = new HashSet<QuizDTO>();
        }

        public int CourseId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string LecturerId { get; set; }
        public virtual UserDTO Lecturer { get; set; } = null!;
        public virtual ICollection<AssignmentDTO> Assignments { get; set; }
        public virtual ICollection<CourseEnrollmentDTO> CourseEnrollments { get; set; }
        public virtual ICollection<QuizDTO> Quizzes { get; set; }
    }
}
