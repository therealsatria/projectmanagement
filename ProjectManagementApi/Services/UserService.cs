using ProjectManagementApi.Models;
using ProjectManagementApi.Repositories;
using ProjectManagementApi.Dtos;

namespace ProjectManagementApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<User> CreateUserAsync(CreateUserRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUserAsync(Guid id, UpdateUserRequest request)
        {
            throw new NotImplementedException();
        }
    }
}