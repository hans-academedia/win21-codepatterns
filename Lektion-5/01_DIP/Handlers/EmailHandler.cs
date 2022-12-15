using _01_DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DIP.Handlers
{
    internal class EmailHandler : IMessageHandler
    {
        public void Send(IPerson receiver, string message)
        {
            Console.WriteLine($"Sending e-mail to {receiver.Email}, message: {message}");
        }
    }
}
