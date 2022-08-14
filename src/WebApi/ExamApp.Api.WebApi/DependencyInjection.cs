using ExamApp.Api.WebApi.Common.Errors;
using ExamApp.Api.WebApi.Common.Mapping;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace ExamApp.Api.WebApi;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services){
        services.AddControllers();

        services.AddSingleton<ProblemDetailsFactory, ExamAppProblemDetailsFactory>();

        services.AddMappings();

        return services;
    }    
}