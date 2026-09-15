```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method      | Job   | Toolchain | Mean      | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| OverNumbers | net10 | net10     | 0.4684 ns | 0.0127 ns | 0.0106 ns |  1.00 |    0.03 |      23 B |         - |          NA |
| OverStrings | net10 | net10     | 0.4671 ns | 0.0036 ns | 0.0028 ns |  1.00 |    0.02 |      23 B |         - |          NA |
| OverNumbers | net8  | net8      | 0.4714 ns | 0.0085 ns | 0.0075 ns |  1.01 |    0.03 |      23 B |         - |          NA |
| OverStrings | net8  | net8      | 0.4777 ns | 0.0158 ns | 0.0132 ns |  1.02 |    0.03 |      23 B |         - |          NA |
| OverNumbers | net9  | net9      | 0.4761 ns | 0.0394 ns | 0.0387 ns |  1.02 |    0.08 |      23 B |         - |          NA |
| OverStrings | net9  | net9      | 0.4773 ns | 0.0376 ns | 0.0462 ns |  1.02 |    0.10 |      23 B |         - |          NA |
