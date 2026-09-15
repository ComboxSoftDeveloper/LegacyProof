```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3


```
| Method      | Job   | Toolchain | Mean     | Error     | StdDev    | Ratio | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |---------:|----------:|----------:|------:|----------:|----------:|------------:|
| Multiply4x4 | net10 | net10     | 6.306 ns | 0.0261 ns | 0.0231 ns |  1.00 |     447 B |         - |          NA |
| Add4x4      | net10 | net10     | 2.353 ns | 0.0134 ns | 0.0119 ns |  0.37 |     203 B |         - |          NA |
| Multiply3x2 | net10 | net10     | 4.921 ns | 0.0208 ns | 0.0174 ns |  0.78 |     386 B |         - |          NA |
| Multiply4x4 | net8  | net8      | 8.393 ns | 0.0242 ns | 0.0214 ns |  1.33 |     502 B |         - |          NA |
| Add4x4      | net8  | net8      | 3.539 ns | 0.0043 ns | 0.0036 ns |  0.56 |     194 B |         - |          NA |
| Multiply3x2 | net8  | net8      | 4.266 ns | 0.0038 ns | 0.0032 ns |  0.68 |     370 B |         - |          NA |
| Multiply4x4 | net9  | net9      | 5.243 ns | 0.0196 ns | 0.0183 ns |  0.83 |     447 B |         - |          NA |
| Add4x4      | net9  | net9      | 2.789 ns | 0.0087 ns | 0.0068 ns |  0.44 |     203 B |         - |          NA |
| Multiply3x2 | net9  | net9      | 4.404 ns | 0.0062 ns | 0.0048 ns |  0.70 |     386 B |         - |          NA |
