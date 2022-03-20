namespace VideoService.Core.Domain.Video;
public class VideoCommentEntity : Entity
{   
    public Guid AuthorId { get; set; }
    public Guid VideoId { get; set; }
    public string Content { get; set; }
    public bool IsEdited { 
        get {
        return DateLastEdited != null;
    } }
    public DateTime? DateLastEdited { get; set; }
    public DateTime DateWritten { get; set; }
    public bool IsReply { 
        get {
        return ReplyCommentId != null;
    } }
    public Guid? ReplyCommentId { get; set; }
}
