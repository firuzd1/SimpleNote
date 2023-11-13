namespace BusinessLogic;

public interface IUserService
{
    public Task<UserDTO> CreateUserAsync(UserDTO user, CancellationToken token);
    public Task<UserDTO> GetUserAsync(long id, CancellationToken token);
    public Task<bool> DeleteUserAsync(long id, CancellationToken token);
    public Task<UserDTO> ChangeNameAsync(long id, string name, CancellationToken token);
    public Task<UserDTO> ChangeLastNameAsync(long id, string newLastName, CancellationToken token);
    public Task<UserDTO> ChangeEmailAsync(long id, string newEmail, CancellationToken token);
    public Task<UserDTO> ChangePasswordAsync(long id, string newPassword, CancellationToken token);
}