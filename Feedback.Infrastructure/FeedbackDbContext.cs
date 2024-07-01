using System.Reflection;
using Feedback.Domain;
using Microsoft.EntityFrameworkCore;

namespace Feedback.Infrastructure;

public class FeedbackDbContext : DbContext
{
    public FeedbackDbContext(DbContextOptions<FeedbackDbContext> options) : base(options){ }
    
    public DbSet<FeedbackItem> FeedbackItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}