namespace _01_ISP.Interfaces;

internal interface IBook : ILibraryItem
{
    int Pages { get; set; }
    List<string> Illustrators { get; set; }
    decimal Weight { get; set; }
}
