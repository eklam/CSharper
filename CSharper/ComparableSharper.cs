using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharper
{
    public static class ComparableSharper
    {
        /// <see cref="http://stackoverflow.com/a/271444/821054"/>
        public static bool Between<T>(this T actual, T lower, T upper) where T : IComparable<T>
        {
            return actual.CompareTo(lower) >= 0 && actual.CompareTo(upper) < 0;
        }
    }
}
