namespace BusinessLogic;
using Note.DataAccess;

public static class TaskExtension
{

    public static TaskDTO ToTaskDTO(this MyTask task)
    {
        TaskDTO taskDTO = new(
            task.Id,
            task.Title,
            task.Description,
            task.Status.ToString(),
            task.UserId,
            task.CategoryId
        );
        return taskDTO;
    }

    public static MyTask ToMyTask(this TaskDTO taskDTO)
    {
        MyTask myTask = new()
        {
            Id = taskDTO.Id,
            Title = taskDTO.Title,
            Description = taskDTO.Description,
            Status = taskDTO.Status.ToStatusEnum(),
            UserId = taskDTO.UserId,
            CategoryId = taskDTO.CategoryId
        };
        return myTask;
    }
}