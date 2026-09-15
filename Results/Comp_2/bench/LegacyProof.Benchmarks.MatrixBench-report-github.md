```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.17763.3165/1809/October2018Update/Redstone5)
AMD Ryzen 9 5950X 3.39GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3


```
| Method      | Job   | Toolchain | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |----------:|----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| Multiply4x4 | net10 | net10     |  6.405 ns | 0.2226 ns | 0.6564 ns |  6.240 ns |  1.01 |    0.14 |     447 B |         - |          NA |
| Add4x4      | net10 | net10     |  4.464 ns | 0.1778 ns | 0.5242 ns |  4.398 ns |  0.70 |    0.11 |     203 B |         - |          NA |
| Multiply3x2 | net10 | net10     |  6.184 ns | 0.1492 ns | 0.3180 ns |  6.139 ns |  0.98 |    0.11 |     386 B |         - |          NA |
| Multiply4x4 | net8  | net8      | 11.564 ns | 0.2556 ns | 0.6823 ns | 11.489 ns |  1.82 |    0.21 |     502 B |         - |          NA |
| Add4x4      | net8  | net8      |  4.860 ns | 0.1524 ns | 0.4494 ns |  4.807 ns |  0.77 |    0.10 |     194 B |         - |          NA |
| Multiply3x2 | net8  | net8      |  6.676 ns | 0.1709 ns | 0.4986 ns |  6.586 ns |  1.05 |    0.13 |     370 B |         - |          NA |
| Multiply4x4 | net9  | net9      |  6.447 ns | 0.1623 ns | 0.4760 ns |  6.348 ns |  1.02 |    0.12 |     447 B |         - |          NA |
| Add4x4      | net9  | net9      |  4.233 ns | 0.1479 ns | 0.4338 ns |  4.235 ns |  0.67 |    0.09 |     203 B |         - |          NA |
| Multiply3x2 | net9  | net9      |  6.519 ns | 0.1908 ns | 0.5624 ns |  6.350 ns |  1.03 |    0.13 |     386 B |         - |          NA |
