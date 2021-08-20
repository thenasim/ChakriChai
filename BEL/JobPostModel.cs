using System;

namespace BEL
{
    public class JobPostModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public int Vacancies { get; set; }
        public double SalaryMin { get; set; }
        public double SalaryMax { get; set; }

        // Relation
        public int EmployeerId { get; set; }
    }
}