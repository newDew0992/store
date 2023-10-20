using Store;

namespace ClassLibrary1;

public class BookRepository : IBookRepository
{
    private readonly Book[] _books =
    {
        new Book(1, "Art of Programming"),
        new Book(2, "Refactoring"),
        new Book(3, "C Programming Language")
    };

    public Book[] GetAllByTitle(string titlePart)
    {
        var result = _books.Where(books => books.Title.Contains(titlePart)).ToArray();
        return result;
    }
}