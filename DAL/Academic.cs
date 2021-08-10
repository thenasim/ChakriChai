using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Academic
    {
        [Key]
        public int AcademicId { get; set; }
        public string InstituteName { get; set; }
        public DateTime PassedYear { get; set; }

        // Relation
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public int BoardId { get; set; }
        public Board Board { get; set; }
    }
}
