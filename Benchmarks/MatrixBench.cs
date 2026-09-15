using System.Numerics;
using BenchmarkDotNet.Attributes;

namespace LegacyProof.Benchmarks;

/// <summary>
/// Раздел 3. Действия над матрицами. Публичный тип хранит шестнадцать
/// отдельных полей float, а работает через вложенную структуру того же
/// размера: значение приводится к ней и обратно.
/// </summary>
public class MatrixBench
{
    private Matrix4x4 _a;
    private Matrix4x4 _b;
    private Matrix3x2 _c;
    private Matrix3x2 _d;

    /// <summary>Матрицы готовятся один раз.</summary>
    [GlobalSetup]
    public void Setup()
    {
        _a = Matrix4x4.CreateRotationX(0.5f);
        _b = Matrix4x4.CreateTranslation(1, 2, 3);

        _c = Matrix3x2.CreateRotation(0.5f);
        _d = Matrix3x2.CreateTranslation(1, 2);
    }

    /// <summary>Умножение четыре на четыре.</summary>
    [Benchmark(Baseline = true)]
    public Matrix4x4 Multiply4x4() => Subjects.Multiply(_a, _b);

    /// <summary>Сложение четыре на четыре.</summary>
    [Benchmark]
    public Matrix4x4 Add4x4() => Subjects.Add(_a, _b);

    /// <summary>Умножение три на два.</summary>
    [Benchmark]
    public Matrix3x2 Multiply3x2() => Subjects.Multiply(_c, _d);
}
