using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Apply
    {
        [Key]
        public int ApplyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        // Relation
        public int JobPostId { get; set; }
        public JobPost JobPost { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
