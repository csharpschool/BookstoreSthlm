using NullOchSånt.Interfaces;

namespace NullOchSånt.Classes;

public class Sales : ISales
{
    public IBook Book { get; init; }
    public int Count { get; init; }
    public double Total => Count * Book.Price;

    public Sales(IBook book, int count) => (Book, Count) = (book, count);

    /*public Sales(IBook book, int count)
    {
        Book = book;
        Count = count;
        Total = count * book.Price;
    }*/
}
