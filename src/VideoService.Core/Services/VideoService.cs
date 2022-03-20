using VideoService.Core.Domain.Comment;
using VideoService.Core.Domain.User;
using VideoService.Core.Domain.Video;
using VideoService.Core.Exceptions;
using VideoService.Core.Interfaces.Infrastructure.Repositories;
using VideoService.Core.Interfaces.Services;

namespace VideoService.Core.Services;

// Video comment does not exist or deleted
// Video does not exist or is deleted
// Video is not published

// Authorization IS a part of business logic
public class VideoService : IVideoService
{   
    private readonly IUnitOfWork _unitOfWork;

    public VideoService(
        IUnitOfWork unitOfWork
    )
    {
        _unitOfWork = unitOfWork ??
            throw new ArgumentNullException(nameof(unitOfWork));
    }
    // 1. Verify the video exists
    // 2. Verify the requester is allowed to delete the video
    // 1. Verify which videos the requester can see 

    public async Task DeleteCommentByIdAsync(UserAggregate user, Guid videoId, Guid commentId)
    {
        // 1. Verify the video exists
        // 2. Verify the comment exists
        // 3. Verify the requester is allowed to delete the comment

        VideoAggregate video = await _unitOfWork.Videos.GetByIdAsync(videoId) ??
            throw new VideoDoesNotExistException("Video you are trying to delete does not exist.");
        
        VideoCommentEntity comment = video.Comments.First(comment => comment.Id == commentId) ??
            throw new CommentDoesNotExistException("Comment you are trying to delete does not exist.");
        
        bool userIsAllowedToDeleteComment = await verifyUserIsAllowedToDeleteComment(user, comment);

        if (userIsAllowedToDeleteComment) {
            await _unitOfWork.Videos.DeleteCommentByIdAsync(videoId, commentId);
            await _unitOfWork.CompleteAsync();
            return;
        }

        throw new NoPermissionToDeleteCommentException("You have no permission to delete the comment.");



    }

    public Task DeleteVideoByIdAsync(UserAggregate user, Guid videoId)
    {
        throw new NotImplementedException();
    }

    public Task<IList<VideoAggregate>> GetAllUserVideosAsync(UserAggregate user, Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<VideoAggregate> GetVideoByIdAsync(UserAggregate user, Guid videoId)
    {
        throw new NotImplementedException();
    }

    public Task PublishVideoByIdAsync(UserAggregate user, Guid videoId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateCommentAsync(UserAggregate user, Guid videoId, VideoCommentEntity comment)
    {
        throw new NotImplementedException();
    }

    public Task UpdateVideoAsync(UserAggregate user, VideoAggregate video)
    {
        throw new NotImplementedException();
    }

    public Task UploadVideoAsync(UserAggregate user, VideoAggregate video)
    {
        throw new NotImplementedException();
    }

    public Task WriteCommentAsync(UserAggregate user, Guid videoId, VideoCommentEntity comment)
    {
        throw new NotImplementedException();
    }

    private async Task<bool> verifyUserIsAllowedToDeleteComment(UserAggregate user, VideoCommentEntity comment)
    {
        if (user.Id == comment.AuthorId)
            return true;
        
        Probably comment.AuthorId should be just User, then the VideoAggregate.PublisherId will be User...
        RoleTypes commentAuthorRole = (await _unitOfWork.Users.GetByIdAsync(comment.AuthorId)).Role;
        if (user.Role == RoleTypes.Admin && commentAuthorRole == RoleTypes.User) 
            return true;
        
        return false;
    }
}