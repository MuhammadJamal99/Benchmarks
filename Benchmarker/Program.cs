using BenchmarkDotNet.Running;
namespace Benchmarker;

public class Program
{
    static void Main(string[] args)
    {
        //var results = BenchmarkRunner.Run<LoopsBenchmarks.LoopsBenchmarks>();
        var results = BenchmarkRunner.Run<StringBenchmarks.StringBenchmark>();
    }
}