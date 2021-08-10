using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        // Relation
        public int UserId { get; set; }
        public User User { get; set; }
        public virtual List<Academic> Academics { get; set; }
        public virtual List<Apply> Applies { get; set; }
    }
}
