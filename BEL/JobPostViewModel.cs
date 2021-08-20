using System;

namespace BEL
{
    public class JobPostViewModel
    {
        public int JobPostId { get; set; }
        public string Title { get; set; }
        public DateTime DeadLine { get; set; }
        public int Vacancies { get; set; }
    }
}