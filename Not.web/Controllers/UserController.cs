using BusinessLogic;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("users")]
public sealed class UserController : ControllerBase
{
    private IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPatch("email/{id}")]
    public Task<UserDTO> ChangeEmailAsync(long id, [FromQuery] string newEmail, CancellationToken token) 
        => _userService.ChangeEmailAsync(id, newEmail, token);

    [HttpPatch("lastName/{id}")]
    public Task<UserDTO> ChangeLastNameAsync(long id, [FromQuery] string newLastName, CancellationToken token) 
        => _userService.ChangeLastNameAsync(id, newLastName, token);

    [HttpPatch("name/{id}")]
    public Task<UserDTO> ChangeNameAsync(long id, [FromQuery] string name, CancellationToken token) 
        => _userService.ChangeNameAsync(id, name, token);

    [HttpPatch("password/{id}")]
    public Task<UserDTO> ChangePasswordAsync(long id, [FromQuery] string newPassword, CancellationToken token) 
        => _userService.ChangePasswordAsync(id, newPassword, token);

    [HttpPost]
    public Task<UserDTO> CreateUserAsync([FromBody] UserDTO user, CancellationToken token) 
        => _userService.CreateUserAsync(user, token);

    [HttpDelete("{id}")]
    public Task<bool> DeleteUserAsync(long id, CancellationToken token) 
        => _userService.DeleteUserAsync(id, token);

    [HttpGet("{id}")]
    public Task<UserDTO> GetUserAsync(long id, CancellationToken token) 
        => _userService.GetUserAsync(id, token);

}
