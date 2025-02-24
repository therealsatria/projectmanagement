using AutoMapper;
using ProjectManagementApi.Models;
using ProjectManagementApi.Dtos;
using ProjectManagementApi.Services.interfaces;
using ProjectManagementApi.Repositories.Interfaces;

namespace ProjectManagementApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<List<UserDTO>> GetAllAsync()
        {
            // var users = await _userRepository.GetAllAsync();
            // return users.Select(u => new UserDTO
            // {
            //     UserId = u.UserId,
            //     Username = u.Username,
            //     Email = u.Email,
            //     CreatedOn = u.CreatedOn,
            //     ModifiedOn = u.ModifiedOn
            // }).ToList();
            

        }
    }
}