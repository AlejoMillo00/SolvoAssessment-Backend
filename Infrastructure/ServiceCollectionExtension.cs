using Application.Common.Interfaces;
using Infrastructure.Persistence;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shared.Configuration;

namespace Infrastructure;

public static class ServiceCollectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(DbConfigurationOptions.MainConnectionString));

        services.AddScoped<IEmployeeCommands, EmployeeCommands>();
        services.AddScoped<IEmployeeQueries, EmployeeQueries>();
    }
}
