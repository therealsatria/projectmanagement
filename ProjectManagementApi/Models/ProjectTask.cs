namespace ProjectManagementApi.Models
{
    public class ProjectTask
    {
        public Guid TaskId { get; set; } = Guid.NewGuid();
        public Guid BoardId { get; set; } // Changed to Guid
        public Guid AssigneeId { get; set; } // Changed to Guid
        public required string Title { get; set; }
        public required string Description { get; set; }
        public int Priority { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedOn { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public required Board Board { get; set; }
        public required User Assignee { get; set; }
        public required ICollection<Comment> Comments { get; set; }
    }
}