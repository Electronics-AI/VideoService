
namespace VideoService.Core.Interfaces.Infrastructure.Loggers
{
    public interface ILogger<out T> where T : class
    {
        void Log(LogLevelTypes logLevel, string message, Exception exception = null, params object[] args);
        
    }
}