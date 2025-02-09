using System;
using System.Collections.Generic;

namespace Models
{
    public class User
    {
        public Guid UserId { get; set; } // Changed to Guid
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        // Navigation properties
        public ICollection<Notebook> Notebooks { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Task> AssignedTasks { get; set; }
        public ICollection<ActivityLog> ActivityLogs { get; set; }
    }
}