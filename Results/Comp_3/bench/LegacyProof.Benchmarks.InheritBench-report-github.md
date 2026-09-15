```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method      | Job   | Toolchain | Mean       | Error      | StdDev     | Median     | Ratio  | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |-----------:|-----------:|-----------:|-----------:|-------:|--------:|----------:|----------:|------------:|
| NextPlain   | net10 | net10     |   2.318 ns |  0.0763 ns |  0.1642 ns |   2.235 ns |   1.00 |    0.10 |     170 B |         - |          NA |
| NextHeir    | net10 | net10     |   3.138 ns |  0.0861 ns |  0.1057 ns |   3.091 ns |   1.36 |    0.10 |     520 B |         - |          NA |
| DoublePlain | net10 | net10     |   2.020 ns |  0.0711 ns |  0.1042 ns |   1.987 ns |   0.88 |    0.07 |     177 B |         - |          NA |
| DoubleHeir  | net10 | net10     |   4.940 ns |  0.0636 ns |  0.0531 ns |   4.952 ns |   2.14 |    0.14 |     627 B |         - |          NA |
| BytesPlain  | net10 | net10     |  50.093 ns |  0.9957 ns |  1.2228 ns |  50.301 ns |  21.71 |    1.51 |     349 B |         - |          NA |
| BytesHeir   | net10 | net10     | 648.626 ns | 11.8831 ns | 10.5340 ns | 645.347 ns | 281.10 |   18.90 |     583 B |         - |          NA |
| NextPlain   | net8  | net8      |   2.225 ns |  0.0664 ns |  0.0622 ns |   2.205 ns |   0.96 |    0.07 |     170 B |         - |          NA |
| NextHeir    | net8  | net8      |   3.550 ns |  0.1004 ns |  0.2732 ns |   3.544 ns |   1.54 |    0.15 |     517 B |         - |          NA |
| DoublePlain | net8  | net8      |   2.206 ns |  0.0199 ns |  0.0155 ns |   2.202 ns |   0.96 |    0.06 |     179 B |         - |          NA |
| DoubleHeir  | net8  | net8      |   5.034 ns |  0.1275 ns |  0.1657 ns |   5.036 ns |   2.18 |    0.16 |     630 B |         - |          NA |
| BytesPlain  | net8  | net8      |  35.458 ns |  0.2022 ns |  0.1689 ns |  35.489 ns |  15.37 |    1.01 |     365 B |         - |          NA |
| BytesHeir   | net8  | net8      | 628.598 ns |  3.0731 ns |  2.3992 ns | 628.149 ns | 272.42 |   17.84 |     585 B |         - |          NA |
| NextPlain   | net9  | net9      |   2.546 ns |  0.0852 ns |  0.2514 ns |   2.525 ns |   1.10 |    0.13 |     170 B |         - |          NA |
| NextHeir    | net9  | net9      |   3.417 ns |  0.0344 ns |  0.0305 ns |   3.406 ns |   1.48 |    0.10 |     511 B |         - |          NA |
| DoublePlain | net9  | net9      |   2.151 ns |  0.0088 ns |  0.0078 ns |   2.148 ns |   0.93 |    0.06 |     173 B |         - |          NA |
| DoubleHeir  | net9  | net9      |   4.861 ns |  0.0259 ns |  0.0202 ns |   4.858 ns |   2.11 |    0.14 |     618 B |         - |          NA |
| BytesPlain  | net9  | net9      |  48.851 ns |  0.8130 ns |  0.7207 ns |  48.603 ns |  21.17 |    1.42 |     346 B |         - |          NA |
| BytesHeir   | net9  | net9      | 612.018 ns |  1.6378 ns |  1.3676 ns | 611.501 ns | 265.23 |   17.35 |     574 B |         - |          NA |
