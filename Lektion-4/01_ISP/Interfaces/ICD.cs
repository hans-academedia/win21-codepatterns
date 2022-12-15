namespace _01_ISP.Interfaces;

internal interface ICD : ILibraryItem, IBorrowableItem
{
    List<string> Readers { get; set; }
    decimal Weight { get; set; }
}