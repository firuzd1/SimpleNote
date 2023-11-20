

using Microsoft.EntityFrameworkCore;

namespace Note.DataAccess;

public sealed class EfCoreTaskRepository : ITaskRepository
{
    private readonly NoteDbContext _db;

    public EfCoreTaskRepository(NoteDbContext dbContext)
    {
        _db = dbContext;
    }

    public async Task<MyTask> ChangeDescriptionAsync(long id, string newDescription, CancellationToken token)
    {
        MyTask? task = await _db.tasks.FindAsync(id, token);
        if(task is null)
            throw new NotFoundExeption("Task not found for changing description! ");

        task.Description = newDescription;
        await _db.SaveChangesAsync(token);
        return task;
    }

    public async Task<MyTask> ChangeStatusAsync(long id, MyTaskStatus newStatus, CancellationToken token)
    {
        MyTask? task = await _db.tasks.FindAsync(id, token);
        if(task is null)
            throw new NotFoundExeption("Task not found for changing status! ");

        task.Status = newStatus;
        await _db.SaveChangesAsync(token);
        return task;
    }

    public async Task<MyTask> ChangeTitleAsync(long id, string newTitle, CancellationToken token)
    {
        MyTask? task = await _db.tasks.FindAsync(id, token);
        if(task is null)
            throw new NotFoundExeption("Task not found for changing title! ");

        task.Title = newTitle;
        await _db.SaveChangesAsync(token);
        return task;
    }

    public async Task<MyTask> CreateTaskAsync(MyTask task, CancellationToken token)
    {
        await _db.tasks.AddAsync(task, token);
        await _db.SaveChangesAsync(token);
        return task;
    }

    public async Task<bool> DeleteTaskAsync(long id, CancellationToken token)
    {
        MyTask? task = await _db.tasks.FindAsync(id, token);
        if(task is null)
            throw new NotFoundExeption("Task not found for deleting!");

        _db.tasks.Remove(task);
        return true;
    }

    public async Task<MyTask> GetTaskAsync(long id, CancellationToken token)
    {
        MyTask? task = await _db.tasks.FindAsync(id, token);
        if(task is null)
            throw new NotFoundExeption("Task not found!");

        return task;
    }
}