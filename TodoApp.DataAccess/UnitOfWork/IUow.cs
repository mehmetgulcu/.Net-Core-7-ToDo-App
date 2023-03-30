using TodoApp.DataAccess.Interfaces;
using TodoApp.Entities.Concrete;

namespace TodoApp.DataAccess.UnitOfWork
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;

        Task SaveChanges();
    }
}
