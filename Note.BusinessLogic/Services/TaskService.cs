using Note.DataAccess;
namespace BusinessLogic;


public sealed class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;
    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }
    public async Task<TaskDTO> ChangeDescriptionAsync(long id, string newDescription, CancellationToken token)
    {
        MyTask myTask = await _taskRepository.ChangeDescriptionAsync(id, newDescription, token);
        return  myTask.ToTaskDTO();
    }

    public async Task<TaskDTO> ChangeStatusAsync(long id, string newStatus, CancellationToken token)
    {
        MyTask myTask = await _taskRepository.ChangeStatusAsync(id, newStatus.ToStatusEnum(), token);
        return myTask.ToTaskDTO();
    }

    public async Task<TaskDTO> ChangeTitleAsync(long id, string newTitle, CancellationToken token)
    {
        MyTask myTask = await _taskRepository.ChangeTitleAsync(id, newTitle, token);
        return myTask.ToTaskDTO();
    }

    public async Task<TaskDTO> CreateTaskAsync(TaskDTO task, CancellationToken token)
    {
       await _taskRepository.CreateTaskAsync(task.ToMyTask(), token);
       return task;
    }

    public Task<bool> DeleteTaskAsync(long id, CancellationToken token) 
        => _taskRepository.DeleteTaskAsync(id, token);

    public async Task<TaskDTO> GetTaskAsync(long id, CancellationToken token)
    {
        MyTask myTask = await _taskRepository.GetTaskAsync(id, token);
        return myTask.ToTaskDTO();
    }
}