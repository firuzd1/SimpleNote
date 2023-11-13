
using Microsoft.AspNetCore.Mvc;

using BusinessLogic;


public sealed class TaskController : ControllerBase
{
    private readonly ITaskService _taskService;

    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpPatch("description/{id}")]
    public Task<TaskDTO> ChangeDescriptionAsync(long id, [FromQuery] string newDescription, CancellationToken token) 
        => _taskService.ChangeDescriptionAsync(id, newDescription, token);

    [HttpPatch("status/{id}")]
    public Task<TaskDTO> ChangeStatusAsync(long id, [FromQuery] string newStatus, CancellationToken token) 
        => _taskService.ChangeStatusAsync(id, newStatus, token);

    [HttpPatch("title/{id}")]
    public Task<TaskDTO> ChangeTitleAsync(long id, [FromQuery] string newTitle, CancellationToken token) 
        => _taskService.ChangeTitleAsync(id, newTitle, token);

    [HttpPost]
    public Task<TaskDTO> CreateTaskAsync([FromBody] TaskDTO task, CancellationToken token) 
        => _taskService.CreateTaskAsync(task, token);

    [HttpDelete("{id}")]
    public Task<bool> DeleteTaskAsync(long id, CancellationToken token) 
        => _taskService.DeleteTaskAsync(id, token);

    [HttpGet("{id}")]
    public Task<TaskDTO> GetTaskAsync(long id, CancellationToken token)
        => _taskService.GetTaskAsync(id, token);
}
