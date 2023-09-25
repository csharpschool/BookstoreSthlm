namespace NullOchSånt.Interfaces;

public interface IBook
{
    public int Id { get; set; }
    public double Price { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

}
