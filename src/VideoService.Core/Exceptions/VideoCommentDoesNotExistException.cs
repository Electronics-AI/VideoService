namespace VideoService.Core.Exceptions;

public class VideoCommentDoesNotExistException : Exception
{
    public VideoCommentDoesNotExistException()
    {
        
    }

    public VideoCommentDoesNotExistException(string message) : base(message)
    {
        
    }
}