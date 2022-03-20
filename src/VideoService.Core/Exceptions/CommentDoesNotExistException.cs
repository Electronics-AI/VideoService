namespace VideoService.Core.Exceptions;

public class CommentDoesNotExistException : Exception
{
    public CommentDoesNotExistException()
    {
        
    }

    public CommentDoesNotExistException(string message) : base(message)
    {
        
    }
}