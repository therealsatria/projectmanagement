using System;
using System.Collections.Generic;

namespace Models
{
    public class Project
    {
        public Guid ProjectId { get; set; } // Changed to Guid
        public Guid UserId { get; set; } // Changed to Guid
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        // Navigation properties
        public User User { get; set; }
        public ICollection<Board> Boards { get; set; }
    }
}