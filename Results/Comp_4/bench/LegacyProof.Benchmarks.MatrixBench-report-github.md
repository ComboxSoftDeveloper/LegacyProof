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
| Multiply4x4 | net10 | net10     | 11.601 ns | 0.2161 ns | 0.1804 ns |  1.00 |    0.02 |     421 B |         - |          NA |
| Add4x4      | net10 | net10     | 10.795 ns | 0.1970 ns | 0.1843 ns |  0.93 |    0.02 |     174 B |         - |          NA |
| Multiply3x2 | net10 | net10     |  6.101 ns | 0.1412 ns | 0.1102 ns |  0.53 |    0.01 |     306 B |         - |          NA |
| Multiply4x4 | net8  | net8      | 17.016 ns | 0.1657 ns | 0.1469 ns |  1.47 |    0.03 |     491 B |         - |          NA |
| Add4x4      | net8  | net8      |  8.944 ns | 0.0734 ns | 0.0650 ns |  0.77 |    0.01 |     191 B |         - |          NA |
| Multiply3x2 | net8  | net8      |  6.502 ns | 0.0653 ns | 0.0545 ns |  0.56 |    0.01 |     354 B |         - |          NA |
| Multiply4x4 | net9  | net9      | 10.812 ns | 0.0595 ns | 0.0557 ns |  0.93 |    0.01 |     421 B |         - |          NA |
| Add4x4      | net9  | net9      |  9.176 ns | 0.0476 ns | 0.0445 ns |  0.79 |    0.01 |     174 B |         - |          NA |
| Multiply3x2 | net9  | net9      |  5.694 ns | 0.0991 ns | 0.0827 ns |  0.49 |    0.01 |     307 B |         - |          NA |
