using Note.DataAccess;
public static class StatusExtension
{
    public static MyTaskStatus ToStatusEnum(this string statusStr)
        => Enum.Parse<MyTaskStatus>(statusStr);
}