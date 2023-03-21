using System.Linq.Expressions;

namespace ApplicationDemo.Infrastructure.Repositories.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        bool Save();
        List<T> GetAll();
        T GetById(Guid id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(Guid id);
        List<T> FindByCondition(Expression<Func<T, bool>> expression);
    }
}
