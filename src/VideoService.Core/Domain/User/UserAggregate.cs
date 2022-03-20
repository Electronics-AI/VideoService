namespace VideoService.Core.Domain.User;

public class UserAggregate : Entity, IAggregateRoot
{
    public RoleTypes Role { get; set; }
    public DateTime DateOfBirth { get; set; }
}