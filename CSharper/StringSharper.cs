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

        public static string F(this string _this, params object[] args)
        {
            if (_this == null)
                return null;
            return string.Format(_this, args);
        }
    }
}