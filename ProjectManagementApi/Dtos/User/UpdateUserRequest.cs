namespace ProjectManagementApi.Dtos
{
    public class UpdateUserRequest
    {
        public required string Username { get; set; }
        public required string Email { get; set; }
    }
}