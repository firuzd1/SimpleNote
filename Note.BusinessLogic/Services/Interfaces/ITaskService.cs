namespace BusinessLogic;


public interface ITaskService
{
    public Task<TaskDTO> CreateTaskAsync(TaskDTO task, CancellationToken token);
    public Task<bool> DeleteTaskAsync(long id, CancellationToken token);
    public Task<TaskDTO> GetTaskAsync(long id, CancellationToken token);
    public Task<TaskDTO> ChangeTitleAsync(long id, string newTitle, CancellationToken token);
    public Task<TaskDTO> ChangeDescriptionAsync(long id, string newDescription, CancellationToken token);
    public Task<TaskDTO> ChangeStatusAsync(long id, string newStatus, CancellationToken token);
}