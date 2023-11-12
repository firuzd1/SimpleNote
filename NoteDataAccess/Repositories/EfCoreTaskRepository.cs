

using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public sealed class EfCoreTaskRepository : ITaskRepository
{
    private readonly SimpleNoteDbContext _db;

    public EfCoreTaskRepository(SimpleNoteDbContext dbContext)
    {
        _db = dbContext;
    }

    public async Task<MyTask> ChangeDescription(long id, string newDescription, CancellationToken token)
    {
        MyTask? task = await _db.tasks.FindAsync(id, token);
        if(task is null)
            throw new NotFoundExeption("Task not found for changing description! ");

        task.Description = newDescription;
        await _db.SaveChangesAsync(token);
        return task;
    }

    public async Task<MyTask> ChangeStatus(long id, MyTaskStatus newStatus, CancellationToken token)
    {
        MyTask? task = await _db.tasks.FindAsync(id, token);
        if(task is null)
            throw new NotFoundExeption("Task not found for changing status! ");

        task.Status = newStatus;
        await _db.SaveChangesAsync(token);
        return task;
    }

    public async Task<MyTask> ChangeTitle(long id, string newTitle, CancellationToken token)
    {
        MyTask? task = await _db.tasks.FindAsync(id, token);
        if(task is null)
            throw new NotFoundExeption("Task not found for changing title! ");

        task.Title = newTitle;
        await _db.SaveChangesAsync(token);
        return task;
    }

    public async Task<MyTask> CreateTask(MyTask task, CancellationToken token)
    {
        await _db.tasks.AddAsync(task, token);
        await _db.SaveChangesAsync(token);
        return task;
    }

    public async Task<bool> DeleteTask(long id, CancellationToken token)
    {
        MyTask? task = await _db.tasks.FindAsync(id, token);
        if(task is null)
            throw new NotFoundExeption("Task not found for deleting!");

        _db.tasks.Remove(task);
        return true;
    }

    public async Task<MyTask> GetTask(long id, CancellationToken token)
    {
        MyTask? task = await _db.tasks.FindAsync(id, token);
        if(task is null)
            throw new NotFoundExeption("Task not found!");

        return task;
    }
}