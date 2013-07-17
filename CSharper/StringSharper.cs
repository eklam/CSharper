namespace CSharper
{
    public static class StringSharper
    {
        public static bool IsNull(this string _this)
        {
            return _this == null;
        }

        public static bool IsNullOrEmpty(this string _this)
        {
            return _this == null;
        }
    }
}