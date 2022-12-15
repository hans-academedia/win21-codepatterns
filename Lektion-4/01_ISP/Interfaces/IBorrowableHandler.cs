using _01_ISP.Models;

namespace _01_ISP.Interfaces;

internal interface IBorrowableHandler
{
    List<CheckoutItem> CheckOuts { get; set; }
    void CheckOut(Person person, IBorrowableItem item);
}
