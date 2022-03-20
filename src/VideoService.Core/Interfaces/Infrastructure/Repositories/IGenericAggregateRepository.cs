using VideoService.Core.Domain;

namespace VideoService.Core.Interfaces.Infrastructure.Repositories
{
    public interface IGenericAggregateRepository<TAggregateRoot> where TAggregateRoot : IAggregateRoot
    {
            Task<TAggregateRoot> GetByIdAsync(Guid id);
            Task<IEnumerable<TAggregateRoot>> GetAllAsync();
            Task AddAsync(TAggregateRoot entity);
            Task AddRangeAsync(IEnumerable<TAggregateRoot> entities);
            Task UpdateAsync(TAggregateRoot entity);
            Task RemoveAsync(TAggregateRoot entity);
            Task RemoveRangeAsync(IEnumerable<TAggregateRoot> entities);

    }
}