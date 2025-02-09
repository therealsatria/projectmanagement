using System;
using System.Collections.Generic;

namespace Models
{
    public class User
    {
        public Guid UserId { get; set; } = Guid.NewGuid();
        public required string Username { get; set; }
        public required string Email { get; set; } 
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedOn { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public required ICollection<Notebook> Notebooks { get; set; }
        public required ICollection<Project> Projects { get; set; }
        public required ICollection<Comment> Comments { get; set; }
        public required ICollection<ProjectTask> AssignedTasks { get; set; }
        public required ICollection<ActivityLog> ActivityLogs { get; set; }
    }
}