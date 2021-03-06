﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharper
{
    public static class RandomSharper
    {
        private static Func<Random> randomCreator;

        public static void RegisterRandom(Func<Random> randomFunc)
        {
            randomCreator = randomFunc;
        }

        public static T OneOf<T>(this Random rnd, params T[] things)
        {
            if (things == null || things.Length == 0)
                throw new ArgumentNullException("things");

            rnd = rnd ?? randomCreator();

            return things[rnd.Next(things.Length)];
        }

        public static T Random<T>(this IEnumerable<T> things, Random rnd = null)
        {
            if (things == null || things.Count() == 0)
                throw new ArgumentNullException("things");

            rnd = rnd ?? randomCreator();

            int rIndex = rnd.Next(things.Count());

            foreach (var item in things)
            {
                if (rIndex == 0)
                    return item;
                rIndex--;
            }

            return default(T);
        }

        /// <summary>
        /// Shuffles the IEnumerable using Fisher-Yates 
        /// </summary>
        /// <typeparam name="T">Type of the IEnumerable</typeparam>
        /// <param name="rnd">Random to use in the Shuffling</param>
        /// <param name="source">IEnumerable that's going to be shuffled</param>
        /// <returns>return a shuffled IEnumerble with the contet of the original IEnumerable</returns>
        /// <see cref="http://stackoverflow.com/a/2016298/821054"/>
        public static IEnumerable<T> Shuffle<T>(this Random rnd, params T[] source)
        {
            rnd = rnd ?? randomCreator();

            return Shuffle(source, rnd);
        }

        /// <summary>
        /// Shuffles the IEnumerable using Fisher-Yates 
        /// </summary>
        /// <typeparam name="T">Type of the IEnumerable</typeparam>
        /// <param name="source">IEnumerable that's going to be shuffled</param>
        /// <param name="rnd">Random to use in the Shuffling</param>
        /// <returns>return a shuffled IEnumerble with the contet of the original IEnumerable</returns>
        /// <see cref="http://stackoverflow.com/a/2016298/821054"/>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source, Random rnd = null)
        {
            rnd = rnd ?? randomCreator();

            if (source == null) throw new ArgumentNullException("source");

            return ShuffleIterator(source, rnd);
        }

        public static IEnumerable<T> ShuffleIterator<T>(this IEnumerable<T> source, Random rnd = null)
        {
            rnd = rnd ?? randomCreator();

            T[] array = source.ToArray();

            for (int n = array.Length; n > 1; )
            {
                int k = rnd.Next(n--); // 0 <= k < n

                //Swap items
                if (n != k)
                {
                    T tmp = array[k];
                    array[k] = array[n];
                    array[n] = tmp;
                }
            }

            foreach (var item in array) yield return item;
        }
    }
}