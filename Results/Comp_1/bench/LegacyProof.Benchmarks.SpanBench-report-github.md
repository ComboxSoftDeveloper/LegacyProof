```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3


```
| Method      | Job   | Toolchain | Mean      | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| OverNumbers | net10 | net10     | 0.4034 ns | 0.0068 ns | 0.0064 ns |  1.00 |    0.02 |      23 B |         - |          NA |
| OverStrings | net10 | net10     | 0.3966 ns | 0.0029 ns | 0.0024 ns |  0.98 |    0.02 |      23 B |         - |          NA |
| OverNumbers | net8  | net8      | 0.3994 ns | 0.0067 ns | 0.0063 ns |  0.99 |    0.02 |      23 B |         - |          NA |
| OverStrings | net8  | net8      | 0.4539 ns | 0.0338 ns | 0.0474 ns |  1.13 |    0.12 |      23 B |         - |          NA |
| OverNumbers | net9  | net9      | 0.3864 ns | 0.0062 ns | 0.0052 ns |  0.96 |    0.02 |      23 B |         - |          NA |
| OverStrings | net9  | net9      | 0.3821 ns | 0.0074 ns | 0.0058 ns |  0.95 |    0.02 |      23 B |         - |          NA |
