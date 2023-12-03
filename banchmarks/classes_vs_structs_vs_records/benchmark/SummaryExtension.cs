using BenchmarkDotNet.Reports;

public static class SummaryExtension
{
    public static void PrintSummary(this Summary summary, string title)
    {
        Console.WriteLine();
        Console.WriteLine($"[{title}]");
        Console.WriteLine("Method | Mean | Error | StdDev");
        Console.WriteLine(new string('-', 40));

        foreach (var report in summary.Reports)
            Console.WriteLine($"{report.BenchmarkCase.Descriptor.WorkloadMethodDisplayInfo} | {report.ResultStatistics.Mean} | {report.ResultStatistics.StandardError} | {report.ResultStatistics.StandardDeviation}");
        Console.WriteLine(new string('-', 40));
        Console.WriteLine();
    }
}