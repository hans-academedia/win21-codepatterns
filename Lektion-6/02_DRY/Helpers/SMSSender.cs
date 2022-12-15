using System.Diagnostics;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace _02_DRY.Handlers
{
    public interface ISMSSender
    {
        void Configure(string from, string accountSid, string authToken);
        Task<MessageResource> SendAsync(string to, string message);
    }

    public class SMSSender : ISMSSender
    {
        private string _from;
        
        public void Configure(string from, string accountSid, string authToken)
        {
            _from = from;
            TwilioClient.Init(accountSid, authToken);
        }

        public async Task<MessageResource> SendAsync(string to, string message)
        {
            try
            {
                MessageResource result = await MessageResource
                    .CreateAsync(
                        to: new Twilio.Types.PhoneNumber(to),
                        from: new Twilio.Types.PhoneNumber(_from),
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
}
