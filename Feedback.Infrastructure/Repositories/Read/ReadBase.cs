using Feedback.Application.Interfaces.Read;
using Feedback.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Feedback.Infrastructure.Repositories.Read;

public class ReadBase<T, U> : IRepositoryRead<T>
    where T : class
    where U : FeedbackDbContext
{
    private U _dbContext;
    public ReadBase(U dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<ICollection<T>> GetAll()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }
    public async Task<T> GetById(string entityId)
    {
        return await _dbContext.Set<T>().FindAsync(entityId);
    }
    public async Task<ICollection<T>> GetTop(int count)
    {
        return await _dbContext.Set<T>().ToListAsync();
    }
    public async Task<ICollection<T>> GetByParameter(Expression<Func<T, bool>> predicate)
    {
        return await _dbContext.Set<T>().Where(predicate).ToListAsync();
    }
}