using System;

namespace KhanDotNet.Library.Utilities
{
    public static class StringExtensions
    {
        public static string F(this string format, params object[] args)
        {
            return string.Format(format, args);
        }
        
        public static bool ContainsIgnoreCase(this string paragraph, string word)
        {
            return Contains(paragraph, word, StringComparison.OrdinalIgnoreCase);
        }

        public static bool Contains(this string paragraph, string word, StringComparison comparisonType = StringComparison.Ordinal)
        {
            return paragraph.IndexOf(word, comparisonType) >= 0;
        }
    }
}