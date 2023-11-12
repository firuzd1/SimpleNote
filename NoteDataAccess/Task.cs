using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess;

[Table("task")]
public sealed class MyTask
{
    private string _title;
    private string _description;
    private MyTaskStatus _taskStatus;
    private User? _user;
    private Category? _category;


    public long Id { get; init; }
    public string Title
    {
        get => _title ?? string.Empty;
        set => _title = value;
    }
    public string Description
    {
        get => _description ?? string.Empty;
        set => _description = value is not null ? value : throw new Exception("Descriptions field can not be empty!"); 
    }
    public MyTaskStatus Status
    {
        get => _taskStatus;
        set => _taskStatus = value;
    }
    public long UserId{ get; set; }
    public User User { get; set; }
    public long CategoryId { get; set; }
    public Category? Category { get; set; }
}
