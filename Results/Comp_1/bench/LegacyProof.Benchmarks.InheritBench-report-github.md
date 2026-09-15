```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3


```
| Method      | Job   | Toolchain | Mean       | Error     | StdDev    | Ratio  | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |-----------:|----------:|----------:|-------:|--------:|----------:|----------:|------------:|
| NextPlain   | net10 | net10     |   1.816 ns | 0.0179 ns | 0.0168 ns |   1.00 |    0.01 |     170 B |         - |          NA |
| NextHeir    | net10 | net10     |   2.608 ns | 0.0221 ns | 0.0207 ns |   1.44 |    0.02 |     520 B |         - |          NA |
| DoublePlain | net10 | net10     |   2.618 ns | 0.0557 ns | 0.0521 ns |   1.44 |    0.03 |     204 B |         - |          NA |
| DoubleHeir  | net10 | net10     |   3.937 ns | 0.0462 ns | 0.0432 ns |   2.17 |    0.03 |     627 B |         - |          NA |
| BytesPlain  | net10 | net10     |  37.025 ns | 0.2052 ns | 0.1919 ns |  20.39 |    0.21 |     349 B |         - |          NA |
| BytesHeir   | net10 | net10     | 537.487 ns | 2.1921 ns | 1.9432 ns | 296.05 |    2.82 |     583 B |         - |          NA |
| NextPlain   | net8  | net8      |   1.638 ns | 0.0258 ns | 0.0241 ns |   0.90 |    0.02 |     170 B |         - |          NA |
| NextHeir    | net8  | net8      |   2.609 ns | 0.0261 ns | 0.0244 ns |   1.44 |    0.02 |     517 B |         - |          NA |
| DoublePlain | net8  | net8      |   1.820 ns | 0.0079 ns | 0.0070 ns |   1.00 |    0.01 |     195 B |         - |          NA |
| DoubleHeir  | net8  | net8      |   3.894 ns | 0.0103 ns | 0.0086 ns |   2.14 |    0.02 |     630 B |         - |          NA |
| BytesPlain  | net8  | net8      |  34.574 ns | 0.1020 ns | 0.0904 ns |  19.04 |    0.18 |     365 B |         - |          NA |
| BytesHeir   | net8  | net8      | 523.339 ns | 1.2976 ns | 1.1503 ns | 288.25 |    2.63 |     585 B |         - |          NA |
| NextPlain   | net9  | net9      |   1.409 ns | 0.0039 ns | 0.0030 ns |   0.78 |    0.01 |     170 B |         - |          NA |
| NextHeir    | net9  | net9      |   2.336 ns | 0.0110 ns | 0.0103 ns |   1.29 |    0.01 |     511 B |         - |          NA |
| DoublePlain | net9  | net9      |   2.344 ns | 0.0727 ns | 0.2143 ns |   1.29 |    0.12 |     204 B |         - |          NA |
| DoubleHeir  | net9  | net9      |   3.844 ns | 0.0525 ns | 0.0491 ns |   2.12 |    0.03 |     618 B |         - |          NA |
| BytesPlain  | net9  | net9      |  36.350 ns | 0.3322 ns | 0.3107 ns |  20.02 |    0.24 |     346 B |         - |          NA |
| BytesHeir   | net9  | net9      | 516.636 ns | 3.7844 ns | 3.5399 ns | 284.56 |    3.15 |     574 B |         - |          NA |
