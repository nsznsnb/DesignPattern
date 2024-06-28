using Iterator;

var bookShelf = new BookShelf();
bookShelf.AppendBook(new Book("Around the World in 80 Days."));
bookShelf.AppendBook(new Book("Bible"));
bookShelf.AppendBook(new Book("Cinderella"));
bookShelf.AppendBook(new Book("Daddy-Long-Legs"));

var it = bookShelf.Iterator();
while (it.HasNext())
{
    var book = it.Next();
    Console.WriteLine(book.Name);
}
Console.WriteLine();





