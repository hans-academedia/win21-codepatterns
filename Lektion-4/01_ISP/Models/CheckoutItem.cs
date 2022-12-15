using _01_ISP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ISP.Models
{
    internal class CheckoutItem
    {
        public Person Person { get; set; } = null!;
        public IBorrowableItem Item { get; set; } = null!;
        public DateTime CheckOutDate { get; set; }
    }
}
