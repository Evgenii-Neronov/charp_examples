
using BenchmarkDotNet.Attributes;

public partial class BenchmarkExample<T> where T : IPoint, new()
{
    public const int Length = 10000;

    static T[] Array = new T[Length];


    [Benchmark]
    public int Sum()
    {
        return Array.Sum(x => x.X);
    }

    [Benchmark]
    public T[] Sort()
    {
        return Array.OrderBy(x=>x.X).ToArray();
    }
}