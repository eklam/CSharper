using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharper
{
    public static class IListSharper
    {
        public static void AddRange<T>(this IList<T> source, IEnumerable<T> items)
        {
            if (source == null)
                throw new ArgumentNullException("Source list cannot be null.");

            foreach (var item in items)
            {
                source.Add(item);
            }
        }
    }
}
