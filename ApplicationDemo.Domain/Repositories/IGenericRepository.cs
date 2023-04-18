using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace ApplicationDemo.Domain.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        bool Save();
        List<T> GetAll();
        T GetById(Guid id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(Guid id);
        List<T> FindByCondition(Expression<Func<T, bool>> expression = null,
                                Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
    }
}
