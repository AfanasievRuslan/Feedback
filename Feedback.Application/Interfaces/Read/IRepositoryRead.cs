using System.Collections;
using System.Linq.Expressions;

namespace Feedback.Application.Interfaces.Read;

public interface IRepositoryRead<T> : IRepositoryQuery
    where T : class
{
    Task<ICollection<T>> GetAll();
    Task<T> GetById(string id);
    Task<ICollection<T>> GetTop(int count);
    Task<ICollection<T>> GetByParameter(Expression<Func<T, bool>> predicate);
}

public interface IRepositoryQuery
{
    
}