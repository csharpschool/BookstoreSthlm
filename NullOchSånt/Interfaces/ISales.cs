namespace NullOchSånt.Interfaces
{
    public interface ISales
    {
        IBook Book { get; init; }
        public int Count { get; init; }
        public double Total { get; }
    }
}
