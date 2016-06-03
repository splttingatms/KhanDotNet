using System;
using System.Linq;
using System.Text;
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

        public static string SubstringFromEnd(this string value, int length)
        {
            return (value.Length > length)
                ? value.Substring(value.Length - length)
                : value;
        }

        public static string MaskToLast(this string value, int length)
        {
            // if value is too short, mask the whole thing to be safe
            if (value.Length < length)
                return string.Join("", value.Select(c => 'X'));

            var builder = new StringBuilder(value);
            for (int i = 0; i < value.Length - length; i++)
                builder[i] = 'X';
            return builder.ToString();
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