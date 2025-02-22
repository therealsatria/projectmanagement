namespace ProjectManagementApi.Models
{
    public class Note
    {
        public Guid NoteId { get; set; } = Guid.NewGuid();
        public Guid NotebookId { get; set; } // Changed to Guid
        public required string Title { get; set; }
        public required string Content { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedOn { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public required Notebook Notebook { get; set; }
    }
}