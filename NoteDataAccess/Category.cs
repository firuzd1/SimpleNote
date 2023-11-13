namespace Note.DataAccess;

public sealed class Category
{
    //  private string? _name;

    //     public long Id { get; set; }

    //     public string Name
    //     {
    //         get => _name ?? string.Empty;
    //         set => _name = value ?? throw new Exception("Name field cannot be empty!");
    //     }

    public long Id { get; set; }
    public string Name { get; set; }
        //public ICollection<MyTask> tasks {get; set; }
}
