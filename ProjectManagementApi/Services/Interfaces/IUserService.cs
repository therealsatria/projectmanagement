using ProjectManagementApi.Dtos;

namespace ProjectManagementApi.Services.interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> GetUserByIdAsync(Guid id);
        Task<UserDTO> CreateUserAsync(CreateUserRequest request);
        Task<UserDTO> UpdateUserAsync(Guid id, UpdateUserRequest request);
        Task DeleteUserAsync(Guid id);
    }
}