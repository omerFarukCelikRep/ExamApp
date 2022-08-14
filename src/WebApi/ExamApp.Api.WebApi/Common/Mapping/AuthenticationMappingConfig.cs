using ExamApp.Application.Authentication.Common;
using ExamApp.Contracts.Authentication;
using Mapster;

namespace ExamApp.Api.WebApi.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
        .Map(dest => dest, src => src.User);
    }
}