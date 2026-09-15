using BenchmarkDotNet.Attributes;
using LegacyProof.Types;

namespace LegacyProof.Benchmarks;

/// <summary>
/// Раздел 2. Создание Span по массиву. У ссылочного типа рантайм проверяет,
/// что массив действительно того типа, что объявлен. У значимого проверять
/// нечего: подменить такой массив нельзя.
///
/// Замеряется именно создание, работа с содержимым сюда не входит.
/// </summary>
public class SpanBench
{
    private string[] _strings = [];
    private int[] _numbers = [];

    /// <summary>Массивы одного размера готовятся один раз.</summary>
    [GlobalSetup]
    public void Setup()
    {
        _strings = Payloads.Strings();
        _numbers = Payloads.Numbers();
    }

    /// <summary>Массив значимого типа, проверки нет.</summary>
    [Benchmark(Baseline = true)]
    public int OverNumbers() => Subjects.SpanOverNumbers(_numbers);

    /// <summary>Массив ссылочного типа, проверка есть.</summary>
    [Benchmark]
    public int OverStrings() => Subjects.SpanOverStrings(_strings);
}
