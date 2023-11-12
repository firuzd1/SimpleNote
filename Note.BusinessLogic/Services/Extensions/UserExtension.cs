namespace BusinessLogic;
using DataAccess;

public static class UserExtension
{
    public static UserDTO ToUserDTO(this User user)
    {
        UserDTO userDTO = new(
            user.Id,
            user.FirstName,
            user.LastName,
            user.Email,
            user.Password
        );
        return userDTO;
    }

    public static User ToUser(this UserDTO userDTO)
    {
        User user = new()
        {
            FirstName = userDTO.FirstName,
            LastName = userDTO.LastName,
            Email = userDTO.Email,
            Password = userDTO.Password
        };
        return user;
    }
}