using System;

namespace BEL
{
    public class AcademicModel
    {
        public int AcademicId { get; set; }
        public string InstituteName { get; set; }
        public DateTime PassedYear { get; set; }

        // Relation
        public int EmployeeId { get; set; }
        public int ExamId { get; set; }
        //public ExamModel Exam { get; set; }
        public int BoardId { get; set; }
        //public BoardModel Board { get; set; }
    }
}