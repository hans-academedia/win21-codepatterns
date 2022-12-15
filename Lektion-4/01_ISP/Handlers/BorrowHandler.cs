using _01_ISP.Interfaces;
using _01_ISP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ISP.Handlers
{
    internal class BorrowHandler : IBorrowableHandler
    {
        public BorrowHandler()
        {
            CheckOuts = new List<CheckoutItem>();
        }

        public List<CheckoutItem> CheckOuts { get; set; }

        public void CheckOut(Person person, IBorrowableItem item)
        {
            CheckOuts.Add(new CheckoutItem
            {
                Person = person,
                Item = item,
                CheckOutDate = DateTime.Now
            });
        }
    }
}
