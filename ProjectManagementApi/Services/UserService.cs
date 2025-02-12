using Models;
using Repositories;
using DTOs;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<UserDTO>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllUsersAsync();
            var userDTOs = new List<UserDTO>();
            foreach (var user in users)
            {
                userDTOs.Add(new UserDTO
                {
                    UserId = user.UserId,
                    Username = user.Username,
                    Email = user.Email,
                    CreatedOn = user.CreatedOn,
                    ModifiedOn = user.ModifiedOn
                });
                
            }
            return userDTOs;
        }

        public async Task<UserDTO> GetUserByIdAsync(Guid id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null) {
                Console.WriteLine("User not found");
            };

            return new UserDTO
            {
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email,
                CreatedOn = user.CreatedOn,
                ModifiedOn = user.ModifiedOn
            };
        }


        public async Task<UserDTO> CreateUserAsync(CreateUserRequest request)
        {
            var user = new User
            {
                UserId = Guid.NewGuid(),
                Username = request.Username,
                Email = request.Email,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                Notebooks = new List<Notebook>(),
                Projects = new List<Project>(),
                Comments = new List<Comment>(),
                AssignedTasks = new List<ProjectTask>(),
                ActivityLogs = new List<ActivityLog>()
            };

            await _userRepository.AddUserAsync(user);

            return new UserDTO
            {
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email,
                CreatedOn = user.CreatedOn,
                ModifiedOn = user.ModifiedOn
            };
        }

        public async Task<UserDTO> UpdateUserAsync(Guid id, UpdateUserRequest request)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null) Console.WriteLine("User not found");

            user.Username = request.Username;
            user.Email = request.Email;
            user.ModifiedOn = DateTime.Now;

            await _userRepository.UpdateUserAsync(user);

            return new UserDTO
            {
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email,
                CreatedOn = user.CreatedOn,
                ModifiedOn = user.ModifiedOn
            };
        }

        public async Task DeleteUserAsync(Guid id)
        {
            await _userRepository.DeleteUserAsync(id);
        }
    }
}