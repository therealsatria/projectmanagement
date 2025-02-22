namespace ProjectManagementApi.Models
{
    public class Board
    {
        public Guid BoardId { get; set; } = Guid.NewGuid();
        public Guid ProjectId { get; set; } // Changed to Guid
        public required string Name { get; set; }
        public int Position { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedOn { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public required Project Project { get; set; }
        public required ICollection<ProjectTask> ProjectTasks { get; set; }
    }
}