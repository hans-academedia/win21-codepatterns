using Twilio.Rest.Api.V2010.Account;

namespace _02_DRY.Handlers
{
    public interface ISmsHandler
    {
        Task<MessageResource> SendSMSAsync(string to, string message);
    }

    public class SmsHandler : ISmsHandler
    {
        private ISMSSender _sms;
        private readonly ILogger _log;

        public SmsHandler(ISMSSender sms, ILogger log)
        {
            _sms = sms;
            _log = log;
        }

        public async Task<MessageResource> SendSMSAsync(string to, string message)
        {
            _sms.Configure("+13149704879", "AC076f8907ae97698229a6fa99503b23fe", "e6e113ebc8019cda62ee72c02bd8d07e");
            return await _sms.SendAsync(to, message);
        }


    }
}
