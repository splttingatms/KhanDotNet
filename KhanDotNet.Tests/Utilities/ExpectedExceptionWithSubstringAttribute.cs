using System;

namespace KhanDotNet.Tests.Utilities
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    internal class ExpectedExceptionWithSubstringAttribute : ExpectedExceptionWithMessageAttribute
    {
        public ExpectedExceptionWithSubstringAttribute(Type exceptionType, string expectedSubstring, bool ignoreCase = true)
            : base(exceptionType, expectedSubstring, match: false, ignoreCase: ignoreCase)
        {
        }
    }
}
