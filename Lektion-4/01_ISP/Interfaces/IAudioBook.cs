namespace _01_ISP.Interfaces;

internal interface IAudioBook : ILibraryItem, IBorrowableItem
{
    List<string> Readers { get; set; }
    List<string> AvailableAudioFormats { get; set; }
    string Playtime { get; set; }
}
