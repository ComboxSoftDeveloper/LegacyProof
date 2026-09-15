using LegacyProof.Types;

namespace LegacyProof.Diagnostics;

/// <summary>
/// Что достаётся пустому наследнику. Конструктор Random проверяет собственный
/// тип и для потомков включает реализацию, оставленную ради совместимости.
/// </summary>
internal static class Inherit
{
    /// <summary>Выводит реализацию и первые числа.</summary>
    internal static int Run()
    {
        Console.WriteLine("Рантайм: " + Environment.Version);
        Console.WriteLine();
        Console.WriteLine("Наследник объявлен так и больше в нём ничего нет:");
        Console.WriteLine();
        Console.WriteLine("  internal sealed class EmptyRandom : Random");
        Console.WriteLine("  {");
        Console.WriteLine("  }");
        Console.WriteLine();
        Console.WriteLine("  как создан                     реализация");
        Console.WriteLine();

        Row("new Random()", new Random());
        Row("new EmptyRandom()", new EmptyRandom());

        Row("new Random(" + Payloads.Seed + ")", new Random(Payloads.Seed));
        Row("new SeededRandom(" + Payloads.Seed + ")", new SeededRandom(Payloads.Seed));

        Console.WriteLine();
        Console.WriteLine("Первые " + Payloads.Preview + " чисел с начальным значением " + Payloads.Seed + ":");
        Console.WriteLine();

        Numbers("Random", new Random(Payloads.Seed));
        Numbers("SeededRandom", new SeededRandom(Payloads.Seed));

        Console.WriteLine();
        Console.WriteLine("Числа совпадают: обе реализации считают одинаково.");
        Console.WriteLine("Отличается только скорость и путь вызова.");

        return 0;
    }

    /// <summary>Одна строка с реализацией.</summary>
    private static void Row(string name, Random random)
    {
        Console.WriteLine("  " + name.PadRight(32) + Innards.ImplementationName(random));
    }

    /// <summary>Одна строка с числами.</summary>
    private static void Numbers(string name, Random random)
    {
        Console.Write("  " + name.PadRight(18));
        for (int i = 0; i < Payloads.Preview; i++)
        {
            Console.Write(random.Next(1000).ToString().PadLeft(6));
        }

        Console.WriteLine();
    }
}
