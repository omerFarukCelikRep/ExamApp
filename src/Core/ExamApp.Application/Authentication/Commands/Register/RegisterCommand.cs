using ErrorOr;
using ExamApp.Application.Authentication.Common;
using MediatR;

namespace ExamApp.Application.Authentication.Commands.Register;

public record RegisterCommand(
 string FirstName,
 string LastName,
 string Email,
 string Password):IRequest<ErrorOr<AuthenticationResult>>;