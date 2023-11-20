namespace Note.DataAccess;


public interface IUserRepository
{
    public Task<User> CreateUserAsync(User user, CancellationToken token);
    public Task<User> GetUserAsync(long id, CancellationToken token);
    public Task<bool> DeleteUserAsync(long id, CancellationToken token);
    public Task<User> ChangeNameAsync(long id, string name, CancellationToken token);
    public Task<User> ChangeLastNameAsync(long id, string newLastName, CancellationToken token);
    public Task<User> ChangeEmailAsync(long id, string newEmail, CancellationToken token);
    public Task<User> ChangePasswordAsync(long id, string newPassword, CancellationToken token);
}