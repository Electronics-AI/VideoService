namespace VideoService.Core.Exceptions;

public class VideoDoesNotExistException : Exception
{
    public VideoDoesNotExistException()
    {
        
    }

    public VideoDoesNotExistException(string message) : base(message)
    {
        
    }
    
}