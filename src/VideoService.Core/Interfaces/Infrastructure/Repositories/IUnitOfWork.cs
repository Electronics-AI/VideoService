

namespace VideoService.Core.Interfaces.Infrastructure.Repositories
{
    public interface IUnitOfWork : IDisposable, IAsyncDisposable
    {
        IVideoRepository Videos { get; }
        IUserRepository Users { get; }
        Task CompleteAsync();
    }
}