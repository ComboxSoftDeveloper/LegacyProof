using System.Numerics;
using System.Reflection;
using LegacyProof.Types;

namespace LegacyProof.Diagnostics;

/// <summary>
/// Сверка. Проверяет каждое утверждение статьи на том рантайме, где запущена.
/// Если поведение изменится, прогон это заметит и вернёт код 1.
/// </summary>
internal static class Checks
{
    /// <summary>Сколько чисел сравнивается в проверке последовательностей.</summary>
    private const int Compare = 1000;

    /// <summary>Код возврата: 0 — всё сошлось, 1 — есть расхождение.</summary>
    internal static int Run()
    {
        bool ok = true;

        ok &= EmptyHeirDiffers();
        ok &= HeirGivesSameNumbers();

        ok &= CovarianceThrows();
        ok &= MatrixShape();

        Console.WriteLine();
        Console.WriteLine(ok ? "СВЕРКА ПРОЙДЕНА" : "СВЕРКА НЕ ПРОЙДЕНА");

        return ok ? 0 : 1;
    }

    /// <summary>Пустому наследнику достаётся другая реализация.</summary>
    private static bool EmptyHeirDiffers()
    {
        Console.WriteLine("Пустой наследник");

        string plain = Innards.ImplementationName(new Random());
        string heir = Innards.ImplementationName(new EmptyRandom());

        bool ok = Report("поле _impl читается", !plain.Contains("не найдено"), plain);

        ok &= Report("у наследника другая реализация", plain != heir, heir);
        ok &= Report("наследник ничего не переопределяет",
            typeof(EmptyRandom).GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly
                | BindingFlags.Public | BindingFlags.NonPublic).Length == 0, "");

        return ok;
    }

    /// <summary>Числа при этом совпадают.</summary>
    private static bool HeirGivesSameNumbers()
    {
        Console.WriteLine();
        Console.WriteLine("Числа у наследника");

        Random plain = new(Payloads.Seed);
        SeededRandom heir = new(Payloads.Seed);

        bool same = true;
        for (int i = 0; i < Compare; i++)
        {
            if (plain.Next() != heir.Next())
            {
                same = false;
                break;
            }
        }

        return Report("совпадают с базовым типом", same, Compare + " чисел");
    }

    /// <summary>Запись значения другого типа в ковариантный массив падает.</summary>
    private static bool CovarianceThrows()
    {
        Console.WriteLine();
        Console.WriteLine("Массив не того типа");

        string[] strings = new string[4];
        object[] objects = strings;

        bool ok = Report("string[] присваивается в object[]", ReferenceEquals(strings, objects), "");

        ok &= Report("запись строки проходит", !Throws(() => Subjects.WriteToCovariant(objects, "строка")), "");
        ok &= Report("запись числа не проходит", Throws(() => Subjects.WriteToCovariant(objects, 42)), "");

        ok &= Report("Span<object> по string[] не создаётся", Throws(() => _ = new Span<object>(objects)), "");
        ok &= Report("Span<string> по string[] создаётся", !Throws(() => _ = new Span<string>(strings)), "");

        return ok;
    }

    /// <summary>Матрица устроена так, как описано.</summary>
    private static bool MatrixShape()
    {
        Console.WriteLine();
        Console.WriteLine("Как объявлена матрица");

        FieldInfo[] fields = typeof(Matrix4x4).GetFields();

        bool ok = Report("шестнадцать открытых полей", fields.Length == 16, fields.Length.ToString());

        ok &= Report("все поля float", Array.TrueForAll(fields, f => f.FieldType == typeof(float)), "");
        ok &= Report("есть вложенный непубличный тип", typeof(Matrix4x4).GetNestedTypes(BindingFlags.NonPublic).Length > 0, "");

        return ok;
    }

    /// <summary>Бросает ли действие исключение.</summary>
    private static bool Throws(Action action)
    {
        try
        {
            action();
            return false;
        }
        catch (Exception)
        {
            return true;
        }
    }

    /// <summary>Одна строка отчёта.</summary>
    private static bool Report(string name, bool ok, string detail)
    {
        Console.WriteLine((ok ? "  ок   " : "  СБОЙ ") + name + (detail.Length == 0 ? "" : ": " + detail));
        return ok;
    }
}
