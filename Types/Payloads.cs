namespace LegacyProof.Types;

/// <summary>
/// Общие значения для замеров и отчётов. Собраны в одном месте, чтобы
/// в отчётах и в замерах стояли одни и те же числа.
/// </summary>
internal static class Payloads
{
    /// <summary>Начальное значение, с которого работают все проверки.</summary>
    internal const int Seed = 42;

    /// <summary>Сколько элементов в массивах для Span.</summary>
    internal const int ArraySize = 16;

    /// <summary>Сколько чисел выводится в отчёте о последовательности.</summary>
    internal const int Preview = 5;

    /// <summary>Размер буфера для заполнения байтами.</summary>
    internal const int BufferSize = 256;

    /// <summary>Массив строк для замеров со Span.</summary>
    internal static string[] Strings()
    {
        string[] result = new string[ArraySize];
        for (int i = 0; i < ArraySize; i++)
        {
            result[i] = "значение";
        }

        return result;
    }

    /// <summary>Массив чисел того же размера.</summary>
    internal static int[] Numbers()
    {
        int[] result = new int[ArraySize];
        for (int i = 0; i < ArraySize; i++)
        {
            result[i] = i;
        }

        return result;
    }
}
