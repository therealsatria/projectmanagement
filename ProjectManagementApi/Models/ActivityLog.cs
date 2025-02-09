using System;

namespace Models
{
    public class ActivityLog
    {
        public Guid LogId { get; set; } // Changed to Guid
        public Guid UserId { get; set; } // Changed to Guid
        public string EntityType { get; set; }
        public Guid EntityId { get; set; } // Changed to Guid
        public string ActionType { get; set; }
        public string Description { get; set; }
        public string OldValues { get; set; }
        public string NewValues { get; set; }
        public DateTime CreatedOn { get; set; }

        // Navigation properties
        public User User { get; set; }
    }
}