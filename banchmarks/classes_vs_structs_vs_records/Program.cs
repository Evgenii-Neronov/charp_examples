using BenchmarkDotNet.Running;

class Program
{
    static void Main(string[] args)
    {
        StartBenchmark();
    }

    static void StartBenchmark()
    {
        var summary1 = BenchmarkRunner.Run<BenchmarkExample<MyStructPoint>>();
        var summary2 = BenchmarkRunner.Run<BenchmarkExample<MyClassPoint>>();
        var summary3 = BenchmarkRunner.Run<BenchmarkExample<MyRecordClassPoint>>();
        var summary4 = BenchmarkRunner.Run<BenchmarkExample<MyRecordStructPoint>>();

        summary1.PrintSummary(nameof(MyStructPoint));
        summary2.PrintSummary(nameof(MyClassPoint));
        summary3.PrintSummary(nameof(MyRecordClassPoint));
        summary4.PrintSummary(nameof(MyRecordStructPoint));
    }
}
