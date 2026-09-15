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
| Multiply4x4 | net10 | net10     |  7.081 ns | 0.1154 ns | 0.0963 ns |  1.00 |    0.02 |     425 B |         - |          NA |
| Add4x4      | net10 | net10     |  3.044 ns | 0.0197 ns | 0.0175 ns |  0.43 |    0.01 |     178 B |         - |          NA |
| Multiply3x2 | net10 | net10     |  3.912 ns | 0.0255 ns | 0.0199 ns |  0.55 |    0.01 |     306 B |         - |          NA |
| Multiply4x4 | net8  | net8      | 10.612 ns | 0.1079 ns | 0.0956 ns |  1.50 |    0.02 |     519 B |         - |          NA |
| Add4x4      | net8  | net8      |  4.352 ns | 0.0355 ns | 0.0277 ns |  0.61 |    0.01 |     200 B |         - |          NA |
| Multiply3x2 | net8  | net8      |  4.461 ns | 0.0591 ns | 0.0493 ns |  0.63 |    0.01 |     354 B |         - |          NA |
| Multiply4x4 | net9  | net9      |  6.165 ns | 0.1146 ns | 0.1072 ns |  0.87 |    0.02 |     426 B |         - |          NA |
| Add4x4      | net9  | net9      |  2.895 ns | 0.0193 ns | 0.0151 ns |  0.41 |    0.01 |     179 B |         - |          NA |
| Multiply3x2 | net9  | net9      |  4.890 ns | 0.0525 ns | 0.0438 ns |  0.69 |    0.01 |     307 B |         - |          NA |
