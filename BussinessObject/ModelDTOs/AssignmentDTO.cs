using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.ModelDTOs
{
    internal class AssignmentDTO
    {
        public AssignmentDTO()
        {
            StudentAssignments = new HashSet<StudentAssignmentDTO>();
        }
        public int AssignmentId { get; set; }
        public int CourseId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? Deadline { get; set; }
        public string? File { get; set; }
        public virtual ICollection<StudentAssignmentDTO> StudentAssignments { get; set; }
        public virtual CourseDTO Course { get; set; } = null!;
    }
}
