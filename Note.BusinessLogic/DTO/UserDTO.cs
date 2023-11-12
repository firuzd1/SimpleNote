namespace BusinessLogic;

public readonly record struct UserDTO(
    long Id,
    string FirstName,
    string LastName,
    string Email,
    string Password
);
