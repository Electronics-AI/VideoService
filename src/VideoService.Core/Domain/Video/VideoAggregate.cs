namespace VideoService.Core.Domain.Video;

public class VideoAggregate : Entity, IAggregateRoot
{
    public Guid PublisherId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string StorageLocationLink { get; set; }
    public string PreviewImageStorageLocationLink { get; set; }
    public IList<VideoQualityTypes> QualitiesAvailable  { get; set; }
    public IList<VideoCommentEntity> Comments { get; set; }
    public DateTime DateUploaded { get; set; }
    public bool IsPublished { 
        get {
        return DatePublished != null;
    } }
    public DateTime? DatePublished { get; set; }

}