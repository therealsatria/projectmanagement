using System.Collections.Generic;
using System.Threading.Tasks;
using DTOs;

namespace Services
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> GetUserByIdAsync(Guid id);
        Task<UserDTO> CreateUserAsync(CreateUserRequest request);
    }
}