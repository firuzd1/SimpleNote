using System.ComponentModel.DataAnnotations.Schema;

namespace Note.DataAccess;

[Table("user")]
public sealed class User
{
    private string? _userFirstName;
    private string? _userLastName;
    private string? _userEmail;
    private string? _userPassword;
    public long Id { get; set; }
    public string FirstName
    {
        get => _userFirstName ?? string.Empty;
        set => _userFirstName = value is {Length: > 1} ?value : throw new Exception("the Name field can not contain only one character!");
    }
    public string LastName
    {
        get => _userLastName ?? string.Empty;
        set => _userLastName = value is {Length: > 1} ? value : throw new Exception("the Last name field can not contain only one character!");
    }
    public string Email
    {
        get => _userEmail ?? string.Empty;
        set => _userEmail = value;
    }
    public string Password
    {
        get => _userPassword ?? string.Empty;
        set => _userPassword = value is {Length: > 4} ? value : throw new Exception("Password can not be less then 4 simbols");
    }

    public ICollection<MyTask>? tasks { get; set; }

     // private string? _userFirstName;
    // private string? _userLastName;
    // private string? _userEmail;
    // private string? _userPassword;
    // public long Id { get; set; }

    // public long Id { get; set; }
    // public string FirstName { get; set; }
    // public string LastName { get; set; }
    // public string Email { get; set; }
    // public string Password { get; set; }
}
