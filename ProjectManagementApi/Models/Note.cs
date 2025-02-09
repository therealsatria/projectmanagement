using System;

namespace Models
{
    public class Note
    {
        public Guid NoteId { get; set; } // Changed to Guid
        public Guid NotebookId { get; set; } // Changed to Guid
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        // Navigation properties
        public Notebook Notebook { get; set; }
    }
}