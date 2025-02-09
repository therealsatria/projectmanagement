using System;

namespace Models
{
    public class Comment
    {
        public Guid CommentId { get; set; } // Changed to Guid
        public Guid TaskId { get; set; } // Changed to Guid
        public Guid UserId { get; set; } // Changed to Guid
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        // Navigation properties
        public Task Task { get; set; }
        public User User { get; set; }
    }
}