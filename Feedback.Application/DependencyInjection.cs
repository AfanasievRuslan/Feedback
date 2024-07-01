using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Feedback.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection service)
    {
        service.AddMediatR(scan => scan.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        return service;
    } 
}