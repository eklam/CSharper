using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharper
{
    public static class RandomSharper
    {
        public static T OneOf<T>(this Random rng, params T[] things)
        {
            if (things == null || things.Length == 0)
                throw new ArgumentNullException("things");
            return things[rng.Next(things.Length)];
        }

        public static T Random<T>(this IEnumerable<T> things,  Random rng)
        {
            if (things == null || things.Count() == 0)
                throw new ArgumentNullException("things");

            int rIndex = rng.Next(things.Count());

            foreach (var item in things)
            {
                if (rIndex == 0)
                    return item;
                rIndex--;
            }

            return default(T);
        }
    }
}