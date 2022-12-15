using _01_DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DIP.Handlers
{
    internal class SmsHandler : IMessageHandler
    {
        public void Send(IPerson receiver, string message)
        {
            Console.WriteLine($"Sending SMS to {receiver.PhoneNumber}, message: {message}");
        }
    }
}
