using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharper
{
    public static class IEnumerableSharper
    {
        public static IEnumerable<T> Safe<T>(this IEnumerable<T> enumerable)
        {
            return enumerable ?? new T[0];
        }

        public static bool IsEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable == null || enumerable.Count() == 0 ? true : false;
        }

        public static void SafeForEach<T>(this IEnumerable<T> enumerable, Action<T> act)
        {
            if (enumerable != null)
            {
                foreach (T item in enumerable)
                {
                    act(item);
                }
            }
        }
    }
}