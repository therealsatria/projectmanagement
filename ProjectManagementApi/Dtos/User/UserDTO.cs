namespace ProjectManagementApi.Dtos
{
    public class UserDTO
    {
        public required Guid UserId { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required DateTime CreatedOn { get; set; }
        public required DateTime ModifiedOn { get; set; }
    }
}