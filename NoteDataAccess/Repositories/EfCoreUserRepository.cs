namespace Note.DataAccess;

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class EfCoreUserRepository : IUserRepository
{
    private readonly NoteDbContext _db;

    public EfCoreUserRepository(NoteDbContext dbContext)
    {
        _db = dbContext;
    }
    public async Task<User> ChangeEmailAsync(long id, string newEmail, CancellationToken token)
    {
        User? user = await _db.users.FindAsync(id, token);
        if(user is null)
            throw new NotFoundExeption("user not found for changing email! ");

        user.Email = newEmail;
        await _db.SaveChangesAsync(token);
        return user;
    }

    public async Task<User> ChangeLastNameAsync(long id, string newLastName, CancellationToken token)
    {
        User? user = await _db.users.FindAsync(id, token);
        if(user is null)
            throw new NotFoundExeption("user not found for changing Last Name! ");

        user.LastName = newLastName;
        await _db.SaveChangesAsync(token);
        return user;
    }

    public async Task<User> ChangeNameAsync(long id, string name, CancellationToken token)
    {
        User? user = await _db.users.FindAsync(id, token);
        if(user is null)
            throw new NotFoundExeption("user not found for changing Name! ");

        user.FirstName = name;
        await _db.SaveChangesAsync(token);
        return user;
    }

    public async Task<User> ChangePasswordAsync(long id, string newPassword, CancellationToken token)
    {
        User? user = await _db.users.FindAsync(id, token);
        if(user is null)
            throw new NotFoundExeption("user not found for changing password! ");

        user.Password = newPassword;
        await _db.SaveChangesAsync(token);
        return user;
    }

    public async Task<User> CreateUserAsync(User user, CancellationToken token)
    {
        await _db.users.AddAsync(user, token);
        await _db.SaveChangesAsync(token);
        return user;
    }

    public async Task<bool> DeleteUserAsync(long id, CancellationToken token)
    {
        User? user = await _db.users.FindAsync(id, token);
        if(user is null)
            throw new NotFoundExeption("Did not find user for deleting!");

        _db.users.Remove(user);
        await _db.SaveChangesAsync(token);
        return true;
    }

    public async Task<User> GetUserAsync(long id, CancellationToken token)
    {
        User? user = await _db.users.FindAsync(id, token);
        if(user is null)
            throw new NotFoundExeption("user did not find!");

        return user;
    }

}
