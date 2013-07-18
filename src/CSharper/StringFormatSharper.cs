using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharper
{
    public static class StringFormatSharper
    {
        /// <summary>
        /// Formats a string with a list of literal placeholders.
        /// </summary>
        /// <param name="text">The extension text</param>
        /// <param name="args">The argument list</param>
        /// <returns>The formatted string</returns>
        public static string F(this string text, params object[] args)
        {
            return string.Format(text, args);
        }

        /// <summary>
        /// Formats a string with a list of literal placeholders.
        /// </summary>
        /// <param name="text">The extension text</param>
        /// <param name="provider">The format provider</param>
        /// <param name="args">The argument list</param>
        /// <returns>The formatted string</returns>
        public static string F(this string text, IFormatProvider provider, params object[] args)
        {
            return string.Format(provider, text, args);
        }
    }
}
