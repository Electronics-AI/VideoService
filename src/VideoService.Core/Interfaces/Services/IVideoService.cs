using VideoService.Core.Domain.User;
using VideoService.Core.Domain.Video;

namespace VideoService.Core.Interfaces.Services;

public interface IVideoService
{   
    Task<IList<VideoAggregate>> GetAllUserVideosAsync(UserAggregate user, Guid userId);
    Task<VideoAggregate> GetVideoByIdAsync(UserAggregate user, Guid videoId);
    Task DeleteVideoByIdAsync(UserAggregate user, Guid videoId);
    Task UpdateVideoAsync(UserAggregate user, VideoAggregate video);
    Task UploadVideoAsync(UserAggregate user, VideoAggregate video);
    Task PublishVideoByIdAsync(UserAggregate user, Guid videoId); 
    Task WriteCommentAsync(UserAggregate user, Guid videoId, VideoCommentEntity comment);
    Task UpdateCommentAsync(UserAggregate user, Guid videoId, VideoCommentEntity comment);
    Task DeleteCommentByIdAsync(UserAggregate user, Guid videoId, Guid commentId);
}