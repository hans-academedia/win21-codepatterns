using _01_DRY.Handlers;

namespace _01_DRY.Factories;

internal static class SMSFactory
{
    public static SMS Create(string from, string accountSid, string authToken)
    {
        return new SMS(from, accountSid, authToken);
    }
}
