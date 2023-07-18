using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.ModelDTOs
{
    internal class StudentAssignmentDTO
    {
        public int SubmissionId { get; set; }
        public int AssignmentId { get; set; }
        public string StudentId { get; set; }
        public string? File { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public virtual AssignmentDTO Assignment { get; set; } = null!;
        public virtual UserDTO Student { get; set; } = null!;
    }
}
