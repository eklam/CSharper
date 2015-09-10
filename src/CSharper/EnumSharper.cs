using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace CSharper
{
    public class EnumModel
    {
        public readonly int Value;
        public readonly string Name;
        public readonly string Description;

        public EnumModel(int value, string name, string description)
        {
            this.Value = value;
            this.Name = name;
            this.Description = description;
        }
    }

    public static class EnumSharper
    {
        /// <summary>
        /// Parses a string into an Enum
        /// </summary>
        /// <typeparam name="T">The type of the Enum</typeparam>
        /// <param name="value">String value to parse</param>
        /// <returns>The Enum corresponding to the stringExtensions</returns>
        /// <see cref="http://stackoverflow.com/a/271421/821054"/>
        public static T EnumParse<T>(this string value, bool ignorecase = false)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            value = value.Trim();

            if (value.Length == 0)
            {
                throw new ArgumentException("Must specify valid information for parsing in the string.", "value");
            }

            Type t = typeof(T);

            if (!t.IsEnum)
            {
                throw new ArgumentException("Type provided must be an Enum.", "T");
            }

            return (T)Enum.Parse(t, value, ignorecase);
        }

        /// <summary>
        /// Converts a given Enum type to an Enumerable containing the Value, Name and Description (if DescriptionAttribute is present)
        /// </summary>
        /// <typeparam name="T">The type of the Enum</typeparam>
        /// <returns>An Enumerable of converted values from the given Enum</returns>
        public static IEnumerable<EnumModel> ToEnumerable<T>()
        {
            var enumType = typeof(T);
            foreach (T value in Enum.GetValues(enumType))
            {
                var field = enumType.GetField(value.ToString());

                var atr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

                yield return new EnumModel((int)field.GetRawConstantValue(), value.ToString(), atr == null ? null : atr.Description);
            }
        }
    }
}