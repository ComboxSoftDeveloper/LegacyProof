```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.17763.3165/1809/October2018Update/Redstone5)
AMD Ryzen 9 5950X 3.39GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3


```
| Method      | Job   | Toolchain | Mean      | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| OverNumbers | net10 | net10     | 0.2886 ns | 0.0336 ns | 0.0745 ns |  1.07 |    0.40 |      23 B |         - |          NA |
| OverStrings | net10 | net10     | 0.2679 ns | 0.0335 ns | 0.0907 ns |  0.99 |    0.43 |      23 B |         - |          NA |
| OverNumbers | net8  | net8      | 0.2878 ns | 0.0335 ns | 0.0815 ns |  1.07 |    0.42 |      23 B |         - |          NA |
| OverStrings | net8  | net8      | 0.2771 ns | 0.0336 ns | 0.0965 ns |  1.03 |    0.46 |      23 B |         - |          NA |
| OverNumbers | net9  | net9      | 0.2731 ns | 0.0338 ns | 0.0824 ns |  1.01 |    0.41 |      23 B |         - |          NA |
| OverStrings | net9  | net9      | 0.3165 ns | 0.0389 ns | 0.1121 ns |  1.17 |    0.53 |      23 B |         - |          NA |
