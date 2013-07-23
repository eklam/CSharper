using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharper
{
    public static class IDictionarySharper
    {
        /// <summary>
        /// Gets the value associated with the specified key, or default value, if key not present
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dict">The dictionary in wich the method is going to be executed on</param>
        /// <param name="key">The key whose value to get.</param>
        /// <param name="defValue">The value to be returne when the key is not found</param>
        /// <returns>the value associated with the specified key, if the key is found; otherwise, the default value passed as parameter</returns>
        public static TValue GetValueOrDefault<TKey, TValue>(
            this IDictionary<TKey, TValue> dict,
            TKey key,
            TValue defValue = default(TValue))
        {
            TValue outValue;
            if (dict.TryGetValue(key, out outValue))
            {
                return outValue;
            }

            return defValue;
        }
    }
}
