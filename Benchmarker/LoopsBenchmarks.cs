using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarker;

[MemoryDiagnoser(false)]
public class LoopsBenchmarks
{
    private static readonly Random rng = new(80085);
    private List<int> items = new();
    [Params(100, 100_000, 1_000_000)]
    public int size { get; set; }
    
    [GlobalSetup]
    public void setup()
    {
        items = Enumerable.Range(1, size).Select(x => rng.Next()).ToList();
    }

    [Benchmark]
    public void For()
    {
        for(var i = 0; i < items.Count; i++)
        {
            var item = items[i];
        }
    }

    [Benchmark]
    public void Foreach()
    {
        foreach (var item in items)
        {
        }
    }

    [Benchmark]
    public void Foreach_Linq()
    {
        items.ForEach(item => { });
    }

    [Benchmark]
    public void Parallel_Foreach()
    {
        Parallel.ForEach(items, i => { });
    }

    [Benchmark]
    public void Parallel_Linq()
    {
        items.AsParallel().ForAll(i => { });
    }

    [Benchmark]
    public void Foreach_Span()
    {
        foreach(var item in CollectionsMarshal.AsSpan(items))
        {

        }
    }

    [Benchmark]
    public void For_Span()
    {
        var asSpan = CollectionsMarshal.AsSpan(items);
        for(int i = 0; i < asSpan.Length; i++)
        {
            var item = asSpan[i];
        }
    }
}
