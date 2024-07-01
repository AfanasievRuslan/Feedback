namespace Feedback.Application.Interfaces.Write;

public interface IFeedbackWrite<T> : IRepositoryWrite
    where T : class
{
    Task<T> Add(T entity);
    Task<T> Update(T entity);
    Task<T> Delete(T entity);
    Task DeleteById(string id);
    Task DeleteRangeByParameter(T entity);
}

public interface IRepositoryWrite
{
    
}