using System;
using System.Collections.Generic;

namespace Models
{
    public class Board
    {
        public Guid BoardId { get; set; } // Changed to Guid
        public Guid ProjectId { get; set; } // Changed to Guid
        public string Name { get; set; }
        public int Position { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        // Navigation properties
        public Project Project { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}