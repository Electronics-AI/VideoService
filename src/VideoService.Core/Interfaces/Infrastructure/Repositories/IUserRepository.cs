using VideoService.Core.Domain.User;

namespace VideoService.Core.Interfaces.Infrastructure.Repositories;

public interface IUserRepository : IGenericAggregateRepository<UserAggregate>
{
    
}