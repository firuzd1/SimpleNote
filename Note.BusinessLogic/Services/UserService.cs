using Note.DataAccess;
namespace BusinessLogic;

public sealed class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<UserDTO> ChangeEmailAsync(long id, string newEmail, CancellationToken token)
    {
       User user = await _userRepository.ChangeEmailAsync(id, newEmail, token);
       return user.ToUserDTO();
    }

    public async Task<UserDTO> ChangeLastNameAsync(long id, string newLastName, CancellationToken token)
    {
        User user = await _userRepository.ChangeLastNameAsync(id, newLastName, token);
        return user.ToUserDTO();
    }

    public async Task<UserDTO> ChangeNameAsync(long id, string name, CancellationToken token)
    {
        User user = await _userRepository.ChangeNameAsync(id, name, token);
        return user.ToUserDTO();
    }

    public async Task<UserDTO> ChangePasswordAsync(long id, string newPassword, CancellationToken token)
    {
        User user = await _userRepository.ChangePasswordAsync(id, newPassword, token);
        return user.ToUserDTO();
    }

    public async Task<UserDTO> CreateUserAsync(UserDTO userDTO, CancellationToken token)
    {   
        User user = await _userRepository.CreateUserAsync(userDTO.ToUser(), token);
        return user.ToUserDTO();
    }

    public Task<bool> DeleteUserAsync(long id, CancellationToken token) 
        => _userRepository.DeleteUserAsync(id, token);

    public async Task<UserDTO> GetUserAsync(long id, CancellationToken token)
    {
        User user = await _userRepository.GetUserAsync(id, token);
        return user.ToUserDTO();
    }
}