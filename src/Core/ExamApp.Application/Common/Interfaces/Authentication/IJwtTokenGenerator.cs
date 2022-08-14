using ExamApp.Domain.Entities;

namespace ExamApp.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}