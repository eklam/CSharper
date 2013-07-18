using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharper
{
    public static class ObjectSharper
    {
        /// <summary>
        /// Determines whether a sequence contains a specified element by using the default equality comparer. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The v alue to locate in the sequence.</param>
        /// <param name="source">A sequence in which to locate a value.</param>
        /// <seealso cref="http://stackoverflow.com/a/833477/821054"/>
        /// <returns> true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
        public static bool In<T>(this T value, params T[] source)
        {
            if (null == value) throw new ArgumentNullException("value");
            return source.Contains(value);
        }

        /// <summary>
        /// Determines whether a sequence contains a specified element by using the default equality comparer. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value to locate in the sequence.</param>
        /// <param name="source">A sequence in which to locate a value.</param>
        /// <seealso cref="http://stackoverflow.com/a/833477/821054"/>
        /// <returns> true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
        public static bool In<T>(this T value, IEnumerable<T> source)
        {
            if (null == value) throw new ArgumentNullException("value");
            return source.Contains(value);
        }
    }
}
