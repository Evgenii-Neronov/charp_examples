
using BenchmarkDotNet.Attributes;

public partial class BenchmarkExample<T> where T : IPoint, new()
{
    public const int Length = 10000;

    private T[] _array = new T[Length];

    public BenchmarkExample()
    {
        var rnd = new Random();

        for (int i = 0; i < Length; i++)
        {
            _array[i] = new T()
            {

                X = rnd.Next(1000),
                Y = rnd.Next(1000),
            };
        }
    }

    [Benchmark]
    public int Sum()
    {
        return _array.Sum(x => x.X);
    }

    [Benchmark]
    public T[] Sort()
    {
        return _array.OrderBy(x=>x.X).ToArray();
    }
}