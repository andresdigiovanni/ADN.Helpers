using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.Helpers.Data
{
    /// <summary>
    /// A static class of extension methods for <see cref="Array"/>.
    /// </summary>
    public static class ArrayHelper
    {
        /// <summary>
        /// Checks if the Arrays are equal.
        /// </summary>
        /// <typeparam name="T">Array type.</typeparam>
        /// <param name="first">The <see cref="Array"/> that contains data to compare with.</param>
        /// <param name="second">The <see cref="Array"/> that contains data to compare to.</param>
        /// <returns>Returns <c>true</c> if all element match and <c>false</c> otherwise.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var first= new double[] { 0, 0, 0, 0, 0 };
        /// var second = new double[] { 0, 0, 0, 0, 0 };
        /// var result = first.ArrayEqual(second);
        /// 
        /// /*
        /// result is true
        /// */
        /// </code>
        /// </example>
        public static bool ArrayEqual<T>(this T[] first, T[] second) where T : IEquatable<T>
        {
            if (ReferenceEquals(first, second))
            {
                return true;
            }

            if (first is null || second is null)
            {
                return false;
            }

            if (first.Length != second.Length)
            {
                return false;
            }

            for (int i = 0; i < first.Length; i++)
            {
                if (!first[i].Equals(second[i]))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Combine the Arrays.
        /// </summary>
        /// <typeparam name="T">Array type.</typeparam>
        /// <param name="first">First element to combine.</param>
        /// <param name="second">Second element to combine.</param>
        /// <returns>T[].</returns>
        /// <example>
        /// <code lang="csharp">
        /// var first= new double[] { 0, 1, 2 };
        /// var second = new double[] { 3, 4, 5 };
        /// var result = first.Combine(second);
        /// 
        /// /*
        /// result contains the values { 0, 1, 2, 3, 4, 5 }
        /// */
        /// </code>
        /// </example>
        public static T[] Combine<T>(this T[] first, T[] second)
        {
            T[] result = new T[first.Length + second.Length];
            Array.Copy(first, 0, result, 0, first.Length);
            Array.Copy(second, 0, result, first.Length, second.Length);
            return result;
        }

        /// <summary>
        /// Sets all values.
        /// </summary>
        /// <typeparam name="T">The type of the elements of the array that will be modified.</typeparam>
        /// <param name="array">The one-dimensional, zero-based array.</param>
        /// <param name="value">The value.</param>
        /// <returns>A reference to the changed array.</returns>
        /// <exception cref="ArgumentNullException">Array is null or empty.</exception>
        /// <example>
        /// <code lang="csharp">
        /// var array = new double[] { 0, 0, 0, 0, 0 };
        /// var result = array.SetAllValues(1);
        /// 
        /// /*
        /// result contains the values { 1, 1, 1, 1, 1 }
        /// */
        /// </code>
        /// </example>
        public static T[] SetAllValues<T>(this T[] array, T value)
        {
            // Check arguments
            if (array is null || array.Length <= 0)
            {
                throw (new ArgumentNullException("array"));
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }

            return array;
        }

        /// <summary>
        /// Split an array into subarrays by specifying the number of divisions.
        /// </summary>
        /// <typeparam name="T">The type of the elements of the array that will be split.</typeparam>
        /// <param name="array">Array to split.</param>
        /// <param name="numberOfDivisions">Number of divisions.</param>
        /// <returns>Subarrays.</returns>
        /// <exception cref="ArgumentNullException">Array is null or empty.</exception>
        /// <exception cref="DivideByZeroException">Number of divisions is zero.</exception>
        /// <example>
        /// <code lang="csharp">
        /// var array = new double[] { 0, 1, 2 };
        /// var numberOfDivisions = 2;
        /// var result = array.SplitByNumberOfDivisions(numberOfDivisions);
        /// 
        /// /*
        /// result contains the values { { 0, 1 }, { 2 } }
        /// */
        /// </code>
        /// </example>
        public static IEnumerable<T[]> SplitByNumberOfDivisions<T>(this T[] array, int numberOfDivisions)
        {
            // Check arguments
            if (array is null)
            {
                throw (new ArgumentNullException("array"));
            }

            if (numberOfDivisions <= 0)
            {
                throw (new DivideByZeroException("numberDivisions"));
            }

            IEnumerable<T[]> result;
            int elementsInDivision = (int)Math.Ceiling(array.Length / (double)numberOfDivisions);

            if (elementsInDivision > 0)
            {
                result = array.SplitByNumberOfElementsInDivision(elementsInDivision);
            }
            else
            {
                result = new List<T[]>();
            }

            return result;
        }

        /// <summary>
        /// Split an array into subarrays by specifying the number of elements in each division.
        /// </summary>
        /// <typeparam name="T">The type of the elements of the array that will be split.</typeparam>
        /// <param name="array">Array to split.</param>
        /// <param name="elementsInDivision">Elements in each division.</param>
        /// <returns>Subarrays.</returns>
        /// <exception cref="ArgumentNullException">Array is null or empty.</exception>
        /// <exception cref="DivideByZeroException">Number of elements in division is zero.</exception>
        /// <example>
        /// <code lang="csharp">
        /// var array = new double[] { 0, 1, 2 };
        /// var elementsInDivision = 2;
        /// var result = array.SplitByNumberOfElementsInDivision(elementsInDivision);
        /// 
        /// /*
        /// result contains the values { { 0, 1 }, { 2 } }
        /// */
        /// </code>
        /// </example>
        public static IEnumerable<T[]> SplitByNumberOfElementsInDivision<T>(this T[] array, int elementsInDivision)
        {
            // Check arguments
            if (array is null)
            {
                throw (new ArgumentNullException("array"));
            }

            if (elementsInDivision <= 0)
            {
                throw (new DivideByZeroException("elementsInDivision"));
            }

            var result = new List<T[]>();

            for (int index = 0; index < array.Length; index += elementsInDivision)
            {
                var length = index + elementsInDivision < array.Length ? elementsInDivision : array.Length - index;
                var temp = new T[length];
                Array.Copy(array, index, temp, 0, length);
                result.Add(temp);
            }

            return result;
        }

        /// <summary>
        /// Subs the array.
        /// </summary>
        /// <typeparam name="T">The type of the elements of the array that will be modified.</typeparam>
        /// <param name="array">The data.</param>
        /// <param name="index">The index.</param>
        /// <param name="length">The length.</param>
        /// <returns>T[].</returns>
        /// <exception cref="ArgumentNullException">array is null or empty.</exception>
        /// <exception cref="ArgumentOutOfRangeException">index or length is out of range.</exception>
        /// <example>
        /// <code lang="csharp">
        /// var array = new double[] { 0, 1, 2, 3, 4, 5 };
        /// var index = 1;
        /// var length = 4;
        /// var result = array.SubArray(index, length);
        /// 
        /// /*
        /// result contains the values { 1, 2, 3, 4 }
        /// */
        /// </code>
        /// </example>
        public static T[] SubArray<T>(this T[] array, int index, int length)
        {
            // Check arguments
            if (array is null || array.Length <= 0)
            {
                throw (new ArgumentNullException("array"));
            }

            if (index < 0 || index > array.Length)
            {
                throw (new ArgumentOutOfRangeException("index"));
            }

            if (length < 0)
            {
                throw (new ArgumentOutOfRangeException("length"));
            }

            if (index + length > array.Length)
            {
                throw (new ArgumentOutOfRangeException("length"));
            }

            T[] result = new T[length];
            Array.Copy(array, index, result, 0, length);
            return result;
        }
    }
}
