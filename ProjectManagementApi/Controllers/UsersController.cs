using Microsoft.AspNetCore.Mvc;
using Services;
using DTOs;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserDTO>>> GetAllUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpGet("{UserId}")]
        public async Task<ActionResult<UserDTO>> GetUserById(Guid UserId)
        {
            var user = await _userService.GetUserByIdAsync(UserId);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<UserDTO>> CreateUser([FromBody] CreateUserRequest request)
        {
            var newUser = await _userService.CreateUserAsync(request);
            return CreatedAtAction(nameof(GetUserById), new { Userid = newUser.UserId }, newUser);
        }

        [HttpPut("{UserId}")]
        public async Task<ActionResult<UserDTO>> UpdateUser(Guid UserId, [FromBody] UpdateUserRequest request)
        {
            var updatedUser = await _userService .UpdateUserAsync(UserId, request);
            if (updatedUser == null) return NotFound();
            return Ok(updatedUser);
        }

        [HttpDelete("{UserId}")]
        public async Task<IActionResult> DeleteUser(Guid UserId)
        {
            await _userService.DeleteUserAsync(UserId);
            return NoContent();
        }

    }
}