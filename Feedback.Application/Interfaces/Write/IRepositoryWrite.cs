using System.Linq.Expressions;

namespace Feedback.Application.Interfaces.Write
{
    public interface IRepositoryWrite<T> : IRepositoryWrite
        where T : class
    {
        Task Add(T entity);
        Task Update(T entity);
        Task<T> Delete(T entity);
        Task<T> DeleteById(string id);
        Task<ICollection<T>> DeleteRangeByParameter(Expression<Func<T, bool>> predicate);
    }

    public interface IRepositoryWrite
    {

    }
}