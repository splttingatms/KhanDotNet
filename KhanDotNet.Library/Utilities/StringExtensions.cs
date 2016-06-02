using System;
using System.Linq;
using System.Web;

namespace KhanDotNet.Library.Utilities
{
    public static class StringExtensions
    {
        public static string F(this string format, params object[] args)
        {
            return string.Format(format, args);
        }

        public static string FUrlEncoded(this string format, params object[] args)
        {
            return string.Format(format, args.Select(arg => HttpUtility.UrlEncode(arg.ToString())).ToArray());
        }
        
        public static bool ContainsIgnoreCase(this string value, string substring)
        {
            return Contains(value, substring, StringComparison.OrdinalIgnoreCase);
        }

        public static bool Contains(this string value, string substring, StringComparison comparisonType = StringComparison.Ordinal)
        {
            return value.IndexOf(substring, comparisonType) >= 0;
        }
    }
}