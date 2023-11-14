namespace BusinessLogic;


public readonly record struct TaskDTO(
    long Id,
    string Title,
    string Description,
    string Status,
    long UserId,
    long CategoryId
);
