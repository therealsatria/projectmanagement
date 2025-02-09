using System;
using System.Collections.Generic;

namespace Models
{
    public class Notebook
    {
        public Guid NotebookId { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; } // Changed to Guid
        public required string Name { get; set; }
        public required string Description { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedOn { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public required User User { get; set; }
        public required ICollection<Note> Notes { get; set; }
    }
}