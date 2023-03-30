using System.Linq.Expressions;
using TodoApp.Entities.Concrete;

namespace TodoApp.DataAccess.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> Find(object id);
        Task<T> GetByFilter(Expression<Func<T, bool>> filter, bool asNoTracking = false);
        Task Create(T entity);
        void Update(T entity, T unChanged);
        void Remove(T entity);
        IQueryable<T> GetQuery();
    }
}
