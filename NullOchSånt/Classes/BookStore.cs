using NullOchSånt.Interfaces;

namespace NullOchSånt.Classes;

public class BookStore
{
    List<IBook> _books = new();
    List<ISales> _sales = new();
    
    public BookStore()
    {
        _books.Add(new Book() { Id = 1, Title = "Title 1", Description = "Descr 1", Price = 10.5 });
        _books.Add(new Book() { Id = 2, Title = "Title 2", Description = "Descr 2", Price = 8.75 });

        var book1 = _books.First();
        _sales.Add(new Sales(book1, 2));

        var book2 = _books.FirstOrDefault(b => b.Id == 2);
        if(book2 is not null)
            _sales.Add(new Sales(book2, 2));
    }

    public List<IBook> GetBooks() { 
        return _books; 
    }

    public List<ISales> GetSales() => _sales;

    public void Buy(int id, int? count)
    {
        if (count is null || count < 1 || id < 1) return;

        var book = _books.SingleOrDefault(b => b.Id.Equals(id));

        if (book is null) return;

        Sales sale = new Sales(book, (int)count);

        _sales.Add(sale);
    }
}
