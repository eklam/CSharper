using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CSharper
{
    public static class ObjectSharper
    {
        /// <summary>
        /// Determines whether a sequence contains a specified element by using the default equality comparer. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value to locate in the sequence.</param>
        /// <param name="source">A sequence in which to locate a value.</param>
        /// <seealso cref="http://stackoverflow.com/a/833477/821054"/>
        /// <returns> true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
        public static bool In<T>(this T value, params T[] source)
        {
            if (null == value) throw new ArgumentNullException("value");
            return source.Contains(value);
        }

        /// <summary>
        /// Determines whether a sequence contains a specified element by using the default equality comparer. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value to locate in the sequence.</param>
        /// <param name="source">A sequence in which to locate a value.</param>
        /// <seealso cref="http://stackoverflow.com/a/833477/821054"/>
        /// <returns> true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
        public static bool In<T>(this T value, IEnumerable<T> source)
        {
            if (null == value) throw new ArgumentNullException("value");
            return source.Contains(value);
        }

        public static string PropertyName<TModel, T>(this TModel _this, Expression<Func<TModel, T>> property)
        {
            var memberExpression = property.Body as MemberExpression;
            return memberExpression.Member.Name;
        }

        /// <summary>
        /// Try to set the value of the property or field, if the property of field existis in the object
        /// </summary>
        /// <param name="obj">Object in wich the property of field value will be setted</param>
        /// <param name="memberName">Name of property of field</param>
        /// <param name="value">Value that will be setted if property of field exsists</param>
        /// <returns>Returns the original object</returns>
        /// <exception cref="Syste.ArgumentException">Value cannot be converted to property or field appropriate type</exception>
        public static object TrySet(this object obj, string memberName, object value)
        {
            var prop = obj.GetType().GetProperty(memberName);
            var field = obj.GetType().GetField(memberName);

            if (prop != null)
            {
                prop.SetValue(obj, value, null);
            }
            if (field != null)
            {
                field.SetValue(obj, value);
            }

            return obj;
        }

        public static T TryGet<T>(this object obj, string memberName)
        {
            var prop = obj.GetType().GetProperty(memberName);
            var field = obj.GetType().GetField(memberName);

            if (prop != null)
            {
                return (T)prop.GetValue(obj, null);
            }
            if (field != null)
            {
                return (T)field.GetValue(obj);
            }

            return default(T);
        }
    }
}
