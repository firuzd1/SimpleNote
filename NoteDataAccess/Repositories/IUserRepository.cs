namespace DataAccess;


public interface IUserRepository
{
    public Task<User> CreateUser(User user, CancellationToken token);
    public Task<User> GetUser(long id, CancellationToken token);
    public Task<bool> DeleteUser(long id, CancellationToken token);
    public Task<User> ChangeName(long id, string name, CancellationToken token);
    public Task<User> ChangeLastName(long id, string newLastName, CancellationToken token);
    public Task<User> ChangeEmail(long id, string newEmail, CancellationToken token);
    public Task<User> ChangePassword(long id, string newPassword, CancellationToken token);
}