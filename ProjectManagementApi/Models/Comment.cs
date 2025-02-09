using System;

namespace Models
{
    public class Comment
    {
        public Guid CommentId { get; set; } = Guid.NewGuid();
        public Guid TaskId { get; set; } // Changed to Guid
        public Guid UserId { get; set; } // Changed to Guid
        public required string Content { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedOn { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public required ProjectTask ProjectTask { get; set; }
        public required User User { get; set; }
    }
}