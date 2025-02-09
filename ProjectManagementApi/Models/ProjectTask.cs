using System;
using System.Collections.Generic;

namespace Models
{
    public class ProjectTask
    {
        public Guid TaskId { get; set; } // Changed to Guid
        public Guid BoardId { get; set; } // Changed to Guid
        public Guid AssigneeId { get; set; } // Changed to Guid
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        // Navigation properties
        public Board Board { get; set; }
        public User Assignee { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}