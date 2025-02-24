using ProjectManagementApi.Dtos;

namespace ProjectManagementApi.Services.interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllAsync();
        Task<UserDTO> GetAsync(Guid id);
        Task<UserDTO> CreateAsync(CreateUserRequest request);
        Task<UserDTO> UpdateAsync(Guid id, UpdateUserRequest request);
        Task DeleteAsync(Guid id);
    }
}