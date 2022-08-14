using ExamApp.Application.Common.Interfaces.Services;

namespace ExamApp.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}