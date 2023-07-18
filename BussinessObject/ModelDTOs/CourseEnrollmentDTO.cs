using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.ModelDTOs
{
    internal class CourseEnrollmentDTO
    {
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public string StudentId { get; set; }
        public virtual CourseDTO Course { get; set; } = null!;
        public virtual UserDTO Student { get; set; } = null!;
    }
}
