``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.2251/21H2/November2021Update)
Intel Xeon CPU E5-1620 v2 3.70GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX
  DefaultJob : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX


```
|    Method | size |         Mean |       Error |      StdDev |       Median | Allocated |
|---------- |----- |-------------:|------------:|------------:|-------------:|----------:|
| **UsingPlus** |   **10** |     **236.3 ns** |     **4.72 ns** |     **8.39 ns** |     **235.3 ns** |     **680 B** |
| **UsingPlus** |  **100** |   **3,203.7 ns** |    **98.97 ns** |   **270.92 ns** |   **3,113.1 ns** |   **15800 B** |
| **UsingPlus** | **1000** | **104,399.1 ns** | **1,656.65 ns** | **2,154.11 ns** | **104,190.7 ns** | **1058000 B** |
