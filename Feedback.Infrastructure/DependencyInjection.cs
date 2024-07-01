using Feedback.Application.Interfaces.Read;
using Feedback.Application.Interfaces.Write;

using Feedback.Infrastructure.Repositories.Read;
using Feedback.Infrastructure.Repositories.Write;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Feedback.Infrastructure;

public static class DependencyInjection
{
    // public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    // {
    //     services.AddDbContext<FeedbackDbContext>(options => options.UseSqlServer(connectionString));
    //     services.AddScoped<IFeedbackWriteRepository, ReadRepository>();
    //     services.AddScoped<IFeedbackReadRepository, WriteRepository>();
    //     return services;
    // }
}