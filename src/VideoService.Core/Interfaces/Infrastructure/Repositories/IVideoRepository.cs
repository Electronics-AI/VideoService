using VideoService.Core.Domain.Video;

namespace VideoService.Core.Interfaces.Infrastructure.Repositories;

public interface IVideoRepository : IGenericAggregateRepository<VideoAggregate>
{
    Task<IList<VideoAggregate>> GetAllUserVideosAsync(Guid userId);
    Task AddCommentAsync(Guid videoId, VideoCommentEntity comment);
    Task UpdateCommentAsync(Guid videoId, VideoCommentEntity comment);
    Task DeleteCommentByIdAsync(Guid videoId, Guid commentId);
}