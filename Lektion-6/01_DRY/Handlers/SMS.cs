using System.Diagnostics;
using _01_DRY.Interfaces.Handlers;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace _01_DRY.Handlers;

internal class SMS : ISMS
{
    private string from;

    public SMS(string from, string accountSid, string authToken)
    {
        this.from = from;
        TwilioClient.Init(accountSid, authToken);
    }

    public async Task<MessageResource> SendAsync(string to, string message)
    {
        try
        {
            MessageResource result = await MessageResource
                .CreateAsync(
                    to: new Twilio.Types.PhoneNumber(to),
                    from: new Twilio.Types.PhoneNumber(from),
                    body: message
                );

            return result;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return null!;
        }
    }
}
