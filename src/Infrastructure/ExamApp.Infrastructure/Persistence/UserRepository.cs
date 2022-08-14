using ExamApp.Application.Common.Interfaces.Persistence;
using ExamApp.Domain.Entities;

namespace ExamApp.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new();
    public void Add(User user)
    {
        _users.Add(user);
    }

    public User? GetByEmail(string email)
    {
        return _users.SingleOrDefault(x => x.Email == email);
    }
}