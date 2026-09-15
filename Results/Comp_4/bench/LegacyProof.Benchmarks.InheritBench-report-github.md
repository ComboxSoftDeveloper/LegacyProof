```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method      | Job   | Toolchain | Mean       | Error      | StdDev     | Ratio  | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |-----------:|-----------:|-----------:|-------:|--------:|----------:|----------:|------------:|
| NextPlain   | net10 | net10     |   3.196 ns |  0.0748 ns |  0.0663 ns |   1.00 |    0.03 |     170 B |         - |          NA |
| NextHeir    | net10 | net10     |   4.104 ns |  0.0384 ns |  0.0359 ns |   1.28 |    0.03 |     520 B |         - |          NA |
| DoublePlain | net10 | net10     |   3.316 ns |  0.1002 ns |  0.1468 ns |   1.04 |    0.05 |     177 B |         - |          NA |
| DoubleHeir  | net10 | net10     |   6.034 ns |  0.0755 ns |  0.0706 ns |   1.89 |    0.04 |     627 B |         - |          NA |
| BytesPlain  | net10 | net10     |  51.063 ns |  0.6301 ns |  0.5894 ns |  15.98 |    0.36 |     349 B |         - |          NA |
| BytesHeir   | net10 | net10     | 889.873 ns |  2.4162 ns |  2.0177 ns | 278.56 |    5.51 |     583 B |         - |          NA |
| NextPlain   | net8  | net8      |   3.435 ns |  0.0568 ns |  0.0504 ns |   1.08 |    0.03 |     170 B |         - |          NA |
| NextHeir    | net8  | net8      |   4.001 ns |  0.1059 ns |  0.0990 ns |   1.25 |    0.04 |     517 B |         - |          NA |
| DoublePlain | net8  | net8      |   3.071 ns |  0.0395 ns |  0.0369 ns |   0.96 |    0.02 |     179 B |         - |          NA |
| DoubleHeir  | net8  | net8      |   6.371 ns |  0.1372 ns |  0.2215 ns |   1.99 |    0.08 |     630 B |         - |          NA |
| BytesPlain  | net8  | net8      |  53.045 ns |  0.4139 ns |  0.3456 ns |  16.60 |    0.34 |     365 B |         - |          NA |
| BytesHeir   | net8  | net8      | 791.863 ns | 10.1338 ns | 11.2637 ns | 247.88 |    5.96 |     585 B |         - |          NA |
| NextPlain   | net9  | net9      |   3.452 ns |  0.0575 ns |  0.0480 ns |   1.08 |    0.03 |     170 B |         - |          NA |
| NextHeir    | net9  | net9      |   4.285 ns |  0.1148 ns |  0.1787 ns |   1.34 |    0.06 |     511 B |         - |          NA |
| DoublePlain | net9  | net9      |   3.513 ns |  0.0232 ns |  0.0206 ns |   1.10 |    0.02 |     173 B |         - |          NA |
| DoubleHeir  | net9  | net9      |   6.097 ns |  0.0538 ns |  0.0449 ns |   1.91 |    0.04 |     618 B |         - |          NA |
| BytesPlain  | net9  | net9      |  55.302 ns |  0.7701 ns |  0.6827 ns |  17.31 |    0.40 |     346 B |         - |          NA |
| BytesHeir   | net9  | net9      | 824.706 ns |  3.9100 ns |  3.2650 ns | 258.16 |    5.17 |     574 B |         - |          NA |
