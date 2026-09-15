using System.Numerics;
using System.Runtime.CompilerServices;

namespace LegacyProof;

/// <summary>
/// Все измеряемые способы. У каждого NoInlining: иначе компилятор перенесёт
/// код метода в замер и часть работы удалит.
/// </summary>
internal static class Subjects
{
    // ---------- пустой наследник ----------

    /// <summary>Очередное число из генератора.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int Next(Random random) => random.Next();

    /// <summary>Дробное число.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static double NextDouble(Random random) => random.NextDouble();

    /// <summary>Заполнение буфера.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void NextBytes(Random random, byte[] buffer) => random.NextBytes(buffer);

    // ---------- проверка типа массива ----------

    /// <summary>
    /// Создание Span по массиву ссылочного типа. Здесь рантайм проверяет,
    /// что массив действительно того типа, что объявлен.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int SpanOverStrings(string[] array) => new Span<string>(array).Length;

    /// <summary>
    /// То же самое по массиву значимого типа. Проверки тут нет: подменить
    /// такой массив нельзя.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int SpanOverNumbers(int[] array) => new Span<int>(array).Length;

    /// <summary>Запись в массив, который на самом деле другого типа.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void WriteToCovariant(object[] array, object value) => array[0] = value;

    // ---------- матрицы ----------

    /// <summary>Умножение матриц четыре на четыре.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Matrix4x4 Multiply(Matrix4x4 left, Matrix4x4 right) => left * right;

    /// <summary>Умножение матриц три на два.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Matrix3x2 Multiply(Matrix3x2 left, Matrix3x2 right) => left * right;

    /// <summary>Сложение матриц четыре на четыре.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Matrix4x4 Add(Matrix4x4 left, Matrix4x4 right) => left + right;
}
