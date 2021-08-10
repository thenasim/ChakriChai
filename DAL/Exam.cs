using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }
        public string ExamName { get; set; }

        // Relation
        public virtual List<Academic> Academics { get; set; }
    }
}
