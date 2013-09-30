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

        /// <summary>
        /// Adds an element with the provided key and value to the System.Collections.Generic.IDictionary<TKey,TValue>.
        /// If an element with same Key AND Value already exists, nothing is done, nor exception is thrown
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="key">The object to use as the key of the element to add.</param>
        /// <param name="value">The object to use as the value of the element to add.</param>
        /// <exception cref="System.ArgumentNullException">dict is null.</exception>
        /// <exception cref="System.ArgumentNullException">key is null.</exception>
        /// <exception cref="System.ArgumentException">Another value already exists for specified key</exception>
        public static void SafeAdd<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            if (dict == null)
                throw new ArgumentNullException("dict", "dict is null");

            if (dict.ContainsKey(key))
            {
                if (dict[key] == null && value == null)
                    return;
                if (value != null && !value.Equals(dict[key]))
                    throw new ArgumentException("Another value already exists for specified key");
            }
            else
            {
                dict.Add(key, value);
            }
        }
    }
}
