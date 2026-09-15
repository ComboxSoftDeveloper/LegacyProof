using System.Reflection;

namespace LegacyProof.Types;

/// <summary>
/// Чтение внутренностей. Класс Random держит поле _impl с одной из реализаций
/// и переадресует вызовы ей.
///
/// Имя поля задано строкой, поэтому смена реализации сломает чтение.
/// Сверка это заметит и остановит прогон.
/// </summary>
internal static class Innards
{
    /// <summary>Имя реализации внутри генератора.</summary>
    internal static string ImplementationName(Random random)
    {
        FieldInfo? field = typeof(Random).GetField("_impl", BindingFlags.Instance | BindingFlags.NonPublic);
        if (field is null)
        {
            return "поле _impl не найдено";
        }

        object? value = field.GetValue(random);
        return value is null ? "реализация не задана" : value.GetType().Name;
    }
}
