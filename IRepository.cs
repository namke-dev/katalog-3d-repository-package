using System.Linq.Expressions;

namespace katalog_3d_respository
{
    public interface IRepository<T> where T : IEntity
    {
        Task<IReadOnlyCollection<T>> GetAllAsync();
        Task<IReadOnlyCollection<T>> GetAllAsync(Expression<Func<T, bool>> filter);
        Task<T> GetAsync(Guid id);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task CreateAsync(T entiry);
        Task UpdateAsync(T entiry);
        Task DeleteAsync(Guid id);
    }
}