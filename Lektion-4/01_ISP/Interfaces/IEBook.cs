namespace _01_ISP.Interfaces;

internal interface IEBook : ILibraryItem, IBorrowableItem
{
    int Pages { get; set; }
    List<string> Illustrators { get; set; }
}
