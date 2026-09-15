using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace LegacyProof.Diagnostics;

/// <summary>
/// Матрицы, которые нельзя переписать. Matrix4x4 выпустили с шестнадцатью
/// открытыми полями float. Заменить их на четыре Vector4 нельзя: это ломающее
/// изменение для всех, кто обращается к полям напрямую.
///
/// Реализацию вынесли во вложенную структуру того же размера, а публичный тип
/// приводится к ней и обратно. Джит такое приведение считает бесплатным.
/// </summary>
internal static class Matrices
{
    /// <summary>Выводит размеры и объявления типов.</summary>
    internal static int Run()
    {
        Console.WriteLine("Рантайм: " + Environment.Version);
        Console.WriteLine();
        Console.WriteLine("  тип            размер   открытых полей   все поля float");
        Console.WriteLine();

        Row<Matrix4x4>("Matrix4x4");

        Row<Matrix3x2>("Matrix3x2");
        Row<Vector4>("Vector4");

        Console.WriteLine();
        Console.WriteLine("Вложенные непубличные типы у Matrix4x4:");
        Console.WriteLine();

        Type[] nested = typeof(Matrix4x4).GetNestedTypes(BindingFlags.NonPublic);
        if (nested.Length == 0)
        {
            Console.WriteLine("  нет");
        }

        foreach (Type type in nested)
        {
            Console.WriteLine("  " + type.Name);
        }

        Console.WriteLine();
        Console.WriteLine("Первые четыре открытых поля Matrix4x4:");
        Console.WriteLine();

        FieldInfo[] fields = typeof(Matrix4x4).GetFields();
        for (int i = 0; i < Math.Min(4, fields.Length); i++)
        {
            Console.WriteLine("  " + fields[i].Name.PadRight(8) + fields[i].FieldType.Name);
        }

        Console.WriteLine("  ...");
        Console.WriteLine();
        Console.WriteLine("Аппаратное ускорение векторов: " + Vector.IsHardwareAccelerated);

        return 0;
    }

    /// <summary>Одна строка таблицы.</summary>
    private static void Row<T>(string name) where T : struct
    {
        FieldInfo[] fields = typeof(T).GetFields();
        bool allFloat = fields.Length > 0 && Array.TrueForAll(fields, f => f.FieldType == typeof(float));

        Console.WriteLine("  " + name.PadRight(15)
            + (Unsafe.SizeOf<T>() + " байт").PadLeft(9)
            + fields.Length.ToString().PadLeft(16)
            + (allFloat ? "да" : "нет").PadLeft(16));
    }
}
