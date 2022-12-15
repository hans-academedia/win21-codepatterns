using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LSP.Interfaces
{
    internal interface IHasManager
    {
        public IEmployee Manager { get; set; }
        public void ShowManager();
    }
}
