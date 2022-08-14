using ErrorOr;
using ExamApp.Application.Authentication.Common;
using MediatR;

namespace ExamApp.Application.Authentication.Queries.Login;

public record LoginQuery(string Email, string Password) : IRequest<ErrorOr<AuthenticationResult>>;