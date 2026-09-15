```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.17763.3165/1809/October2018Update/Redstone5)
AMD Ryzen 9 5950X 3.39GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3


```
| Method      | Job   | Toolchain | Mean       | Error      | StdDev     | Median     | Ratio  | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |-----------:|-----------:|-----------:|-----------:|-------:|--------:|----------:|----------:|------------:|
| NextPlain   | net10 | net10     |   2.333 ns |  0.1027 ns |  0.2948 ns |   2.292 ns |   1.02 |    0.18 |     170 B |         - |          NA |
| NextHeir    | net10 | net10     |   3.190 ns |  0.0957 ns |  0.2700 ns |   3.127 ns |   1.39 |    0.20 |     520 B |         - |          NA |
| DoublePlain | net10 | net10     |   3.104 ns |  0.0930 ns |  0.2594 ns |   3.031 ns |   1.35 |    0.20 |     204 B |         - |          NA |
| DoubleHeir  | net10 | net10     |   4.434 ns |  0.1189 ns |  0.3354 ns |   4.395 ns |   1.93 |    0.27 |     627 B |         - |          NA |
| BytesPlain  | net10 | net10     |  35.885 ns |  0.7359 ns |  2.0877 ns |  35.630 ns |  15.61 |    2.07 |     349 B |         - |          NA |
| BytesHeir   | net10 | net10     | 572.608 ns | 13.2989 ns | 37.0720 ns | 569.495 ns | 249.11 |   33.76 |     583 B |         - |          NA |
| NextPlain   | net8  | net8      |   2.952 ns |  0.3705 ns |  1.0925 ns |   2.472 ns |   1.28 |    0.50 |     170 B |         - |          NA |
| NextHeir    | net8  | net8      |   3.197 ns |  0.1307 ns |  0.3770 ns |   3.072 ns |   1.39 |    0.23 |     517 B |         - |          NA |
| DoublePlain | net8  | net8      |   2.521 ns |  0.0775 ns |  0.2159 ns |   2.454 ns |   1.10 |    0.16 |     195 B |         - |          NA |
| DoubleHeir  | net8  | net8      |   5.039 ns |  0.1408 ns |  0.3950 ns |   5.012 ns |   2.19 |    0.31 |     630 B |         - |          NA |
| BytesPlain  | net8  | net8      |  35.869 ns |  0.7358 ns |  1.8460 ns |  35.596 ns |  15.60 |    2.02 |     365 B |         - |          NA |
| BytesHeir   | net8  | net8      | 638.305 ns | 18.1932 ns | 53.3574 ns | 629.636 ns | 277.69 |   40.41 |     585 B |         - |          NA |
| NextPlain   | net9  | net9      |   2.479 ns |  0.0734 ns |  0.1596 ns |   2.465 ns |   1.08 |    0.15 |     170 B |         - |          NA |
| NextHeir    | net9  | net9      |   3.331 ns |  0.1311 ns |  0.3696 ns |   3.237 ns |   1.45 |    0.24 |     511 B |         - |          NA |
| DoublePlain | net9  | net9      |   3.043 ns |  0.0912 ns |  0.2558 ns |   2.956 ns |   1.32 |    0.19 |     204 B |         - |          NA |
| DoubleHeir  | net9  | net9      |   4.596 ns |  0.1675 ns |  0.4726 ns |   4.613 ns |   2.00 |    0.31 |     618 B |         - |          NA |
| BytesPlain  | net9  | net9      |  34.986 ns |  0.7221 ns |  1.7441 ns |  34.604 ns |  15.22 |    1.96 |     346 B |         - |          NA |
| BytesHeir   | net9  | net9      | 586.098 ns | 16.3285 ns | 47.1115 ns | 576.641 ns | 254.98 |   36.64 |     574 B |         - |          NA |
