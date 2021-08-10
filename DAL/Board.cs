using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Board
    {
        [Key]
        public int BoardId { get; set; }
        public string BoardName { get; set; }

        // Relation
        public virtual List<Academic> Academics { get; set; }
    }
}
