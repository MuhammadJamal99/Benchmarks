using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarker;

[MemoryDiagnoser(false)]
public class StringBenchmark
{
    [Benchmark]
    public string GetFullString()
    {
        string Output = "";
        for (int i = 0; i < 100; i++)
        {
            Output += i;
        }
        return Output;
    }
}
