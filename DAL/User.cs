using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }

        // Relation
        public virtual List<Employee> Employees { get; set; }
        public virtual List<Employeer> Employeers { get; set; }
    }
}
