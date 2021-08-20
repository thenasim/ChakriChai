using System;

namespace BEL
{
    public class EmployeerModel
    {
        public int EmployeerId { get; set; }
        public string Organization { get; set; }
        public DateTime YearEstablishment { get; set; }
        public int CompanySize { get; set; }
        public string OrganizationType { get; set; }

        // Relation
        public int UserId { get; set; }
    }
}