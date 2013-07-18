using System;

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
        public static void ThrowIfArgumentIsNull<T>(this T obj, string paramName) where T : class
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
        public static void ThrowIfArgumentIsNull<T>(this T obj, string paramName, string message) where T : class
        {
            if (obj == null)
                throw new ArgumentNullException(paramName, message);
        }
    }
}