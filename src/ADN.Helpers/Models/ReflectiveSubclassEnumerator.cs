using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ADN.Helpers
{
    /// <summary>
    /// A static class of reflective enumerator.
    /// </summary>
    public static class ReflectiveSubclassEnumerator
    {
        /// <summary>
        /// Gets all subclasses of the given abstract class.
        /// </summary>
        /// <typeparam name="T">The type of the abstract class.</typeparam>
        /// <param name="constructorArgs">An array of arguments that match in number, order,
        /// and type the parameters of the constructor to invoke. If args is an empty array or null,
        /// the constructor that takes no parameters (the default constructor) is invoked.</param>
        /// <returns>List of references to the newly created objects.</returns>
        /// <example>
        /// <code lang="csharp">
        /// public class AbsFoo {}
        /// public class Foo1 : AbsFoo { }
        /// public class Foo2 : AbsFoo { }
        /// 
        /// <![CDATA[var result = ReflectiveSubclassEnumerator.GetEnumerableOfType<AbsFoo>(null).ToList();]]>
        /// 
        /// /*
        /// result is [ Foo1, Foo2 ]
        /// */
        /// </code>
        /// </example>
        public static IEnumerable<T> GetEnumerableOfType<T>(params object[] constructorArgs) where T : class
        {
            var objects = new List<T>();
            var types = Assembly
                .GetAssembly(typeof(T))
                .GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T)));

            foreach (Type type in types)
            {
                objects.Add((T)Activator.CreateInstance(type, constructorArgs));
            }
            return objects;
        }
    }
}
