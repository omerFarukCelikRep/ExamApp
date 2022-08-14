using ExamApp.Application.Common.Interfaces.Authentication;
using ExamApp.Application.Common.Interfaces.Persistence;
using ExamApp.Application.Common.Interfaces.Services;
using ExamApp.Infrastructure.Authentication;
using ExamApp.Infrastructure.Persistence;
using ExamApp.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExamApp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration){
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}