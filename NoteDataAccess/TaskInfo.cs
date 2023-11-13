namespace Note.DataAccess;

public readonly struct MyTaskInfo
{
    public readonly long Id { get; init; }
    public readonly string Title { get; init; }
    public readonly string Description { get; init; }
    public readonly TaskStatus Status { get; init; }
}