namespace ProjectManagementApi.Dtos
{
    public class NotebookDTO
    {
        public required Guid NotebookId { get; set; }
        public required Guid UserId { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required DateTime CreatedOn { get; set; }
        public required DateTime ModifiedOn { get; set; }
        public required UserDTO User { get; set; }
    }
}
