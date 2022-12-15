using Twilio.Rest.Api.V2010.Account;

namespace _01_DRY.Interfaces.Handlers;

internal interface ISMS
{
    Task<MessageResource> SendAsync(string to, string message);
}
