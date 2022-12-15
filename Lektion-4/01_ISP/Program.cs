using _01_ISP.Handlers;
using _01_ISP.Interfaces;
using _01_ISP.Models;
using System;

IBorrowableHandler handler = new BorrowHandler();

var person = new Person { FirstName = "Hans", LastName = "Mattin-Lassei", Email = "hans@domain.com", PhoneNumber = "073-123 45 67" };
Book book = new Book 
{ 
    ISBN = "9789137152653", 
    Title = "Gökungen", 
    Authors = new List<string> { "Camilla Läckberg" }, 
    Illustrators = new List<string> { "Maria Sundberg" },
    BookPublisher = "Bokförlaget Forum",
    ReleaseDate = new DateTime(2022, 09, 12),
    Pages = 350,
    Language = "Svenska",
    Weight = 553,
    Serie = "Fjällbacka-serien (del 11)"
};
handler.CheckOut(person, book);

IAudioBook audiobook = new AudioBook
{
    ISBN = "9789137152653",
    Title = "Gökungen",
    Authors = new List<string> { "Camilla Läckberg" },
    Readers = new List<string> { "Katarina Ewerlöf" },
    BookPublisher = "Bokförlaget Forum",
    ReleaseDate = new DateTime(2022, 09, 12),
    Language = "Svenska",
    Serie = "Fjällbacka-serien (del 11)",
    Playtime = "12tim 32min",
    AvailableAudioFormats = new List<string> { "MP3 - i en fil", "MP3 - i korta avsnitt", "Flash Stream", "HTTP Stream", "TSStream"  }
};
handler.CheckOut(person, audiobook);

IEBook ebook = new EBook
{
    ISBN = "9789137152653",
    Title = "Gökungen",
    Authors = new List<string> { "Camilla Läckberg" },
    Illustrators = new List<string> { "Maria Sundberg" },
    BookPublisher = "Bokförlaget Forum",
    ReleaseDate = new DateTime(2022, 09, 12),
    Pages = 350,
    Language = "Svenska",
    Serie = "Fjällbacka-serien (del 11)"
};
handler.CheckOut(person, ebook);

ICD cd = new CD
{
    ISBN = "9789137152653",
    Title = "Gökungen",
    Authors = new List<string> { "Camilla Läckberg" },
    BookPublisher = "Bokförlaget Forum",
    Readers = new List<string> { "Katarina Ewerlöf" },
    ReleaseDate = new DateTime(2022, 09, 12),
    Language = "Svenska",
    Serie = "Fjällbacka-serien (del 11)",
    Weight = 53,
};
handler.CheckOut(person, cd);

foreach (var checkoutItem in handler.CheckOuts)
{
    if (checkoutItem.Item is Book)
        Console.WriteLine($"{checkoutItem.Person.FirstName} {checkoutItem.Person.LastName} har lånat boken {((checkoutItem.Item) as Book).Title} ({checkoutItem.CheckOutDate})");

    if (checkoutItem.Item is AudioBook)
        Console.WriteLine($"{checkoutItem.Person.FirstName} {checkoutItem.Person.LastName} har lånat ljudboken {((checkoutItem.Item) as AudioBook).Title} ({checkoutItem.CheckOutDate})");

    if (checkoutItem.Item is EBook)
        Console.WriteLine($"{checkoutItem.Person.FirstName} {checkoutItem.Person.LastName} har lånat e-boken {((checkoutItem.Item) as EBook).Title} ({checkoutItem.CheckOutDate})");

    if (checkoutItem.Item is CD)
        Console.WriteLine($"{checkoutItem.Person.FirstName} {checkoutItem.Person.LastName} har lånat cdn {((checkoutItem.Item) as CD).Title} ({checkoutItem.CheckOutDate})");
}



Console.ReadKey();