``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.2130/21H2/November2021Update)
Intel Xeon CPU E5-1620 v2 3.70GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]     : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX
  DefaultJob : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX


```
|        Method |     Mean |     Error |    StdDev |   Median |
|-------------- |---------:|----------:|----------:|---------:|
| GetFullString | 4.084 μs | 0.0816 μs | 0.1971 μs | 4.021 μs |
