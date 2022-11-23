``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.2251/21H2/November2021Update)
Intel Xeon CPU E5-1620 v2 3.70GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX


```
|                       Method | size |           Mean |         Error |        StdDev |         Median | Allocated |
|----------------------------- |----- |---------------:|--------------:|--------------:|---------------:|----------:|
|                    **UsingPlus** |   **10** |     **226.080 ns** |     **4.5507 ns** |     **4.4694 ns** |     **225.765 ns** |     **680 B** |
|                  UsingConcat |   10 |     274.414 ns |     5.5411 ns |    11.1933 ns |     270.036 ns |     920 B |
|                  UsingFormat |   10 |     845.680 ns |    14.5542 ns |    12.1534 ns |     843.786 ns |     680 B |
|           UsingStringBuilder |   10 |      52.440 ns |     0.8059 ns |     1.1297 ns |      52.157 ns |     160 B |
| UsingStringBuilderAppendJoin |   10 |      62.563 ns |     1.4129 ns |     3.8677 ns |      61.154 ns |     192 B |
|             UsingConcatArray |   10 |      10.417 ns |     0.2711 ns |     0.6800 ns |      10.288 ns |      32 B |
|              UsingStringJoin |   10 |      26.381 ns |     0.5894 ns |     0.6052 ns |      26.200 ns |      88 B |
|                    **UsingPlus** |  **100** |   **3,012.125 ns** |    **39.1791 ns** |    **32.7163 ns** |   **3,022.348 ns** |   **15800 B** |
|                  UsingConcat |  100 |   3,440.743 ns |    48.3205 ns |    40.3498 ns |   3,444.336 ns |   18200 B |
|                  UsingFormat |  100 |   9,257.851 ns |    82.8823 ns |    77.5281 ns |   9,275.429 ns |   15800 B |
|           UsingStringBuilder |  100 |     346.061 ns |     4.4684 ns |     4.1797 ns |     347.493 ns |     776 B |
| UsingStringBuilderAppendJoin |  100 |     113.425 ns |     2.3340 ns |     3.7019 ns |     112.172 ns |     616 B |
|             UsingConcatArray |  100 |       9.865 ns |     0.1240 ns |     0.1036 ns |       9.828 ns |      32 B |
|              UsingStringJoin |  100 |      45.303 ns |     0.4260 ns |     0.3326 ns |      45.398 ns |     264 B |
|                    **UsingPlus** | **1000** | **127,503.545 ns** | **2,122.1176 ns** | **1,881.2020 ns** | **127,128.430 ns** | **1058000 B** |
|                  UsingConcat | 1000 | 130,874.300 ns | 1,801.2142 ns | 1,684.8569 ns | 131,115.527 ns | 1082000 B |
|                  UsingFormat | 1000 | 249,265.492 ns | 3,307.8041 ns | 3,094.1220 ns | 250,888.281 ns | 1058048 B |
|           UsingStringBuilder | 1000 |   2,502.022 ns |    13.2377 ns |    12.3826 ns |   2,505.385 ns |    4584 B |
| UsingStringBuilderAppendJoin | 1000 |     507.414 ns |     9.0711 ns |    11.7949 ns |     506.462 ns |    4216 B |
|             UsingConcatArray | 1000 |       9.764 ns |     0.0844 ns |     0.0659 ns |       9.762 ns |      32 B |
|              UsingStringJoin | 1000 |     248.305 ns |     3.4577 ns |     3.2343 ns |     248.699 ns |    2064 B |
