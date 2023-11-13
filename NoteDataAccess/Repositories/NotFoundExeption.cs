namespace Note.DataAccess;

public sealed class NotFoundExeption : Exception
{
    public NotFoundExeption(string? message) : base(message)
    {
    }

    public NotFoundExeption(string? message, Exception? innerException) 
        : base(message, innerException)
    {
    }
}