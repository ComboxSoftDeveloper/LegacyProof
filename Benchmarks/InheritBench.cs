using BenchmarkDotNet.Attributes;
using LegacyProof.Types;

namespace LegacyProof.Benchmarks;

/// <summary>
/// Раздел 1. Базовый тип против пустого наследника. Наследник ничего
/// не переопределяет, но конструктор Random выдаёт ему другую реализацию.
/// </summary>
public class InheritBench
{
    private Random _plain = new();
    private Random _heir = new EmptyRandom();
    private byte[] _buffer = new byte[Payloads.BufferSize];

    /// <summary>Генераторы и буфер готовятся один раз.</summary>
    [GlobalSetup]
    public void Setup()
    {
        _plain = new Random();

        _heir = new EmptyRandom();
        _buffer = new byte[Payloads.BufferSize];
    }

    /// <summary>Число из базового типа.</summary>
    [Benchmark(Baseline = true)]
    public int NextPlain() => Subjects.Next(_plain);

    /// <summary>Число из пустого наследника.</summary>
    [Benchmark]
    public int NextHeir() => Subjects.Next(_heir);

    /// <summary>Дробное число из базового типа.</summary>
    [Benchmark]
    public double DoublePlain() => Subjects.NextDouble(_plain);

    /// <summary>Дробное число из наследника.</summary>
    [Benchmark]
    public double DoubleHeir() => Subjects.NextDouble(_heir);

    /// <summary>Буфер байт из базового типа.</summary>
    [Benchmark]
    public void BytesPlain() => Subjects.NextBytes(_plain, _buffer);

    /// <summary>Буфер байт из наследника.</summary>
    [Benchmark]
    public void BytesHeir() => Subjects.NextBytes(_heir, _buffer);
}
