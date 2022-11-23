using BenchmarkDotNet.Attributes;
using System.Text;

namespace Benchmarker.StringBenchmarks;

[MemoryDiagnoser(false)]
public class StringBenchmark
{
    private static readonly Random rng = new();
    private string item;

    [Params(10, 100, 1_000)]
    public int size { get; set; }

    [GlobalSetup]
    public void setup()
    {
        StringBuilder builder = new();
        for (int i = 0; i < size; i++)
            builder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(25 * rng.NextDouble())) + 65));
        item = builder.ToString();
    }

    [Benchmark]
    public string UsingPlus()
    {
        string test = "Test";
        for (int i = 0; i < item.Length; i++)
            test += item[i];
        
        return test;
    }

    [Benchmark]
    public string UsingConcat()
    {
        string test = "Test";
        for(int i = 0; i < item.Length; i++)
            test = string.Concat(test, item[i]);

        return test;
    }
    
    [Benchmark]
    public string UsingFormat()
    {
        string test = "Test";
        
        for (int i = 0; i < item.Length; i++)
            test = string.Format("{0}{1}", test, item[i]);

        return test;
    }

    [Benchmark]
    public string UsingStringBuilder() 
    {
        StringBuilder builder = new("Test");

        for (int i = 0; i < item.Length; i++)
            builder.Append(item[i]);

        return builder.ToString();
    }

    [Benchmark] 
    public string UsingStringBuilderAppendJoin() 
    {
        StringBuilder builder = new("Test");
        
        builder.AppendJoin(string.Empty, item);
        
        return builder.ToString();
    }

    //[Benchmark]
    //public string UsingLinqAggregeta()
    //{
    //    string test = "Test";
    //    test += item.Aggregate((partialphrase, word) => $"{partialphrase}{word}");
    //    return test;
    //}

    [Benchmark]
    public string UsingConcatArray()
    {
        string test = "Test";
        test = string.Concat(item);
        return test;
    }

    [Benchmark]
    public string UsingStringJoin()
    {
        string test = "Test";
        test += string.Join(string.Empty, item);
        return test;
    }
}
