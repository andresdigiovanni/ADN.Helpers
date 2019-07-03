using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.Helpers
{
    /// <summary>
    /// A static class of extension methods for <see cref="Enum"/>.
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// Get enum value.
        /// </summary>
        /// <param name="enumType">Enum type.</param>
        /// <param name="name">Enum text value.</param>
        /// <param name="ignoreCase">Ignore case sensitive.</param>
        /// <returns>Enum value.</returns>
        /// <exception cref="ArgumentException">name is not a value in enumType.</exception>
        /// <example>
        /// <code lang="csharp">
        /// enum Foo
        /// {
        ///     A, B, C, D
        /// }
        /// var value = "A";
        /// var type = typeof(Foo);
        /// var ignoreCase = true;
        /// var result = EnumHelper.GetEnumValue(type, value, ignoreCase);
        /// 
        /// /*
        /// result is Foo.A
        /// */
        /// </code>
        /// </example>
        public static Enum GetEnumValue(Type enumType, string name, bool ignoreCase = false)
        {
            int index;
            if (ignoreCase)
            {
                index = Array.FindIndex(
                    Enum.GetNames(enumType),
                    s => string.Compare(s, name, StringComparison.OrdinalIgnoreCase) == 0);
            }
            else
            {
                index = Array.IndexOf(Enum.GetNames(enumType), name);
            }

            if (index < 0)
            {
                throw new ArgumentException($"{name} is not a value in {enumType}", "name");
            }

            return (Enum)Enum.GetValues(enumType).GetValue(index);
        }
    }
}
