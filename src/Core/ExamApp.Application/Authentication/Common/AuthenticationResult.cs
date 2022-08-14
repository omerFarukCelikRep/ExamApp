using ExamApp.Domain.Entities;

namespace ExamApp.Application.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token
);