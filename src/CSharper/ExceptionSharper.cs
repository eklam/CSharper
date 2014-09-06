using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharper
{
    public static class ExceptionSharper
    {
        /// <summary>
        /// Throws an exception if the object called upon is null.
        /// </summary>
        /// <typeparam name="T">The calling class</typeparam>
        /// <param name="obj">The This object</param>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        public static void ThrowIfArgIsNull<T>(this T obj, string paramName) where T : class
        {
            if (obj == null)
                throw new ArgumentNullException(paramName);
        }

        /// <summary>
        /// Throws an exception if the object called upon is null.
        /// </summary>
        /// <typeparam name="T">The calling class</typeparam>
        /// <param name="obj">The This object</param>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        /// /// <param name="message">A message that describes the error.</param>
        public static void ThrowIfArgIsNull<T>(this T obj, string paramName, string message) where T : class
        {
            if (obj == null)
                throw new ArgumentNullException(paramName, message);
        }

        /// <summary>
        /// Throws an exception if the IEnumerable is Empty
        /// </summary>
        /// <typeparam name="T">The calling class</typeparam>
        /// <param name="obj">The This object</param>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        public static void ThrowIfIsEmpty<T>(this IEnumerable<T> obj, string paramName) where T : class
        {
            obj.ThrowIfIsEmpty(paramName, "The argument must be a non-empty IEnumerable");
        }

        /// <summary>
        /// Throws an exception if the IEnumerable is Empty
        /// </summary>
        /// <typeparam name="T">The calling class</typeparam>
        /// <param name="obj">The This object</param>
        /// <param name="paramName">The name of the parameter that caused the exception.</param>
        public static void ThrowIfIsEmpty<T>(this IEnumerable<T> obj, string paramName, string message) where T : class
        {
            obj.ThrowIfArgIsNull(paramName);
            if (obj.Count() == 0)
                throw new ArgumentException(message, paramName);
        }
    }
}