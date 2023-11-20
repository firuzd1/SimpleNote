namespace Note.DataAccess;


public interface ITaskRepository
{
    public Task<MyTask> CreateTaskAsync(MyTask task, CancellationToken token);
    public Task<bool> DeleteTaskAsync(long id, CancellationToken token);
    public Task<MyTask> GetTaskAsync(long id, CancellationToken token);
    public Task<MyTask> ChangeTitleAsync(long id, string newTitle, CancellationToken token);
    public Task<MyTask> ChangeDescriptionAsync(long id, string newDescription, CancellationToken token);
    public Task<MyTask> ChangeStatusAsync(long id, MyTaskStatus newStatus, CancellationToken token);
}