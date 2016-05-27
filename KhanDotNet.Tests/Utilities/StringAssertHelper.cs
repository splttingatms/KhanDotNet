using KhanDotNet.Library.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace KhanDotNet.Tests.Utilities
{
    internal static class StringAssertHelper
    {
        public static void AreEqual(string expected, string actual, bool ignoreCase, string message = null)
        {
            Assert.AreEqual(expected, actual, ignoreCase, "IgnoreCase:<{0}>. {1}".F(ignoreCase, message));
        }

        public static void Contains(string value, string substring, bool ignoreCase, string message = null)
        {
            var comparisonType = (ignoreCase)
                ? StringComparison.OrdinalIgnoreCase
                : StringComparison.Ordinal;

            StringAssertHelper.Contains(value, substring, comparisonType, message);
        }

        public static void Contains(string value, string substring, StringComparison comparisonType, string message = null)
        {
            if (!value.Contains(substring, comparisonType))
            {
                var currentMethod = System.Reflection.MethodBase.GetCurrentMethod();
                var methodName = currentMethod.DeclaringType.Name + "." + currentMethod.Name;

                var completeMessage = 
                    "{0} failed. String \'{1}\' does not contain string \'{2}\'. ComparisonType:<{3}>. {4}"
                    .F(methodName, value, substring, comparisonType, message);
                throw new AssertFailedException(completeMessage);
            }
        }
    }
}
