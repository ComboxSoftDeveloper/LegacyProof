```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method      | Job   | Toolchain | Mean      | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| OverNumbers | net10 | net10     | 0.6912 ns | 0.0376 ns | 0.0333 ns |  1.00 |    0.07 |      23 B |         - |          NA |
| OverStrings | net10 | net10     | 0.7177 ns | 0.0499 ns | 0.0649 ns |  1.04 |    0.10 |      23 B |         - |          NA |
| OverNumbers | net8  | net8      | 0.7103 ns | 0.0136 ns | 0.0127 ns |  1.03 |    0.05 |      23 B |         - |          NA |
| OverStrings | net8  | net8      | 0.6981 ns | 0.0110 ns | 0.0097 ns |  1.01 |    0.05 |      23 B |         - |          NA |
| OverNumbers | net9  | net9      | 0.7257 ns | 0.0237 ns | 0.0210 ns |  1.05 |    0.06 |      23 B |         - |          NA |
| OverStrings | net9  | net9      | 0.7073 ns | 0.0211 ns | 0.0187 ns |  1.03 |    0.05 |      23 B |         - |          NA |
