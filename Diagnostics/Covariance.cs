namespace LegacyProof.Diagnostics;

/// <summary>
/// Массив, который оказался не того типа. Массивы ссылочных типов в .NET
/// ковариантны: string[] присваивается в object[]. Запись туда значения
/// другого типа проверяется при выполнении.
///
/// Из-за этого Span при создании проверяет, что массив действительно того
/// типа, что объявлен.
/// </summary>
internal static class Covariance
{
    /// <summary>Показывает, где срабатывает проверка.</summary>
    internal static int Run()
    {
        Console.WriteLine("Рантайм: " + Environment.Version);
        Console.WriteLine();
        Console.WriteLine("Массив строк присваивается в массив объектов:");
        Console.WriteLine();
        Console.WriteLine("  string[] strings = new string[4];");
        Console.WriteLine("  object[] objects = strings;      // компилятор не против");
        Console.WriteLine();

        string[] strings = new string[4];
        object[] objects = strings;

        Console.WriteLine("  objects.GetType()              " + objects.GetType().Name);
        Console.WriteLine("  ReferenceEquals(strings, objects)  " + ReferenceEquals(strings, objects));
        Console.WriteLine();

        Describe("objects[0] = \"строка\"", () => Subjects.WriteToCovariant(objects, "строка"));
        Describe("objects[0] = 42", () => Subjects.WriteToCovariant(objects, 42));
        Describe("new Span<object>(objects)", () => _ = new Span<object>(objects));
        Describe("new Span<string>(strings)", () => _ = new Span<string>(strings));

        Console.WriteLine();
        Console.WriteLine("Запись числа в массив строк не проходит: проверка идёт");
        Console.WriteLine("при каждой записи. Span проверяет тип один раз, при создании,");
        Console.WriteLine("и дальше работает без проверок.");

        return 0;
    }

    /// <summary>Выполняет действие и выводит итог.</summary>
    private static void Describe(string name, Action action)
    {
        try
        {
            action();
            Console.WriteLine("  " + name.PadRight(32) + "прошло");
        }
        catch (Exception error)
        {
            Console.WriteLine("  " + name.PadRight(32) + error.GetType().Name);
        }
    }
}
