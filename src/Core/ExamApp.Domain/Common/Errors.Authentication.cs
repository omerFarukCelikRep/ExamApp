using ErrorOr;

namespace ExamApp.Domain.Common;

public static partial class Errors
{
    public static class Authentication
    {
        public static Error InvalidCredentials => Error.Validation(code: "Authentication.InvalidCredentials", description: "Invalid Credentials!");
    }
}