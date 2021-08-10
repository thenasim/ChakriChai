using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class JobPost
    {
        [Key]
        public int JobPostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public int Vacancies { get; set; }
        public double SalaryMin { get; set; }
        public double SalaryMax { get; set; }

        // Relation
        public int EmployeerId { get; set; }
        public Employeer Employeer { get; set; }
        public virtual List<Apply> Applies { get; set; }
    }
}
