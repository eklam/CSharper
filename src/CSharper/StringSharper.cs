namespace CSharper
{
    public static partial class StringSharper
    {
        /// <summary>
        /// Indicates whether the specified string is null.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null; otherwise, false.</returns>
        public static bool IsNull(this string _this)
        {
            return _this == null;
        }

        /// <summary>
        /// Indicates whether the specified string is null or an System.String.Empty string.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or an empty string (""); otherwise, false.</returns>
        public static bool IsEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        /// <summary>
        /// Indicates whether a specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or System.String.Empty, or if value consists exclusively of white-space characters.</returns>
        public static bool IsWhiteSpaces(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }
}