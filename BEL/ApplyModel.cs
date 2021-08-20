namespace BEL
{
    public class ApplyModel
    {
        public int ApplyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        // Relation
        public int JobPostId { get; set; }

        public int EmployeeId { get; set; }
    }
}