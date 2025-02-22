namespace ProjectManagementApi.Models
{
    public class ActivityLog
    {
        public Guid LogId { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; } // Changed to Guid
        public required string EntityType { get; set; }
        public Guid EntityId { get; set; } 
        public required string ActionType { get; set; }
        public required string Description { get; set; }
        public required string OldValues { get; set; }
        public required string NewValues { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public required User User { get; set; }
    }
}