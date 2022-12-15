using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DIP.Interfaces
{
    internal interface IMessageHandler
    {
        void Send(IPerson receiver, string message);
    }
}
