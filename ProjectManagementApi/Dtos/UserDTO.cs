namespace DTOs
{
    public class UserDTO
    {
        public required Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
    }
}