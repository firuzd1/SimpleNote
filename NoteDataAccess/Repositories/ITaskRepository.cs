namespace Note.DataAccess;


public interface ITaskRepository
{
    public Task<MyTask> CreateTask(MyTask task, CancellationToken token);
    public Task<bool> DeleteTask(long id, CancellationToken token);
    public Task<MyTask> GetTask(long id, CancellationToken token);
    public Task<MyTask> ChangeTitle(long id, string newTitle, CancellationToken token);
    public Task<MyTask> ChangeDescription(long id, string newDescription, CancellationToken token);
    public Task<MyTask> ChangeStatus(long id, MyTaskStatus newStatus, CancellationToken token);
}