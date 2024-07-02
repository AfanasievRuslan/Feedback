using Feedback.Application.Interfaces.Write;
using Feedback.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Feedback.Infrastructure.Repositories.Write;

public class WriteBase<T,U>(U context) : IRepositoryWrite<T>
    where T : class
    where U : DbContext
{
    private readonly U _context = context;

    public async Task Update(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }
    public async Task Add(T entity)
    {
        _context.Set<T>().Add(entity);
        await _context.SaveChangesAsync();
    }
    public async Task<T> Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
        return entity;  
    }
    public async Task<T> DeleteById(string id)
    {
        T? entity = await _context.Set<T>().FindAsync(id);
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
        return entity;  
    }
    public async Task<ICollection<T>> DeleteRangeByParameter(Expression<Func<T,bool>> predicate)
    {
        ICollection<T> entities = await _context.Set<T>().Where(predicate).ToListAsync();
        _context.Set<T>().RemoveRange(entities);
        await _context.SaveChangesAsync();
        return entities;
    }

}