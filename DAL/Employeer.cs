using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Employeer
    {
        [Key]
        public int EmployeerId { get; set; }
        public string Organization { get; set; }
        public DateTime YearEstablishment { get; set; }
        public int CompanySize { get; set; }
        public string OrganizationType { get; set; }

        // Relation
        public int UserId { get; set; }
        public User User { get; set; }
        public virtual List<JobPost> JobPosts { get; set; }
    }
}
