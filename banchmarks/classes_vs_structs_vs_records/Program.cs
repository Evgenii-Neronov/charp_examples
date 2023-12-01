using BenchmarkDotNet.Running;

class Program
{
    static void Main(string[] args)
    {
        StartBenchmark();
    }

    static void StartBenchmark()
    {
        Console.WriteLine($"### START {nameof(MyStructPoint)} ###");
        var summary = BenchmarkRunner.Run<BenchmarkExample<MyStructPoint>>();
        Console.WriteLine(summary);

        Console.WriteLine($"### START {nameof(MyClassPoint)} ###");
        summary = BenchmarkRunner.Run<BenchmarkExample<MyClassPoint>>();
        Console.WriteLine(summary);

        Console.WriteLine($"### START {nameof(MyRecordClassPoint)} ###");
        summary = BenchmarkRunner.Run<BenchmarkExample<MyRecordClassPoint>>();
        Console.WriteLine(summary);

        Console.WriteLine($"### START {nameof(MyRecordStructPoint)} ###");
        summary = BenchmarkRunner.Run<BenchmarkExample<MyRecordStructPoint>>();
        Console.WriteLine(summary);
    }
}
