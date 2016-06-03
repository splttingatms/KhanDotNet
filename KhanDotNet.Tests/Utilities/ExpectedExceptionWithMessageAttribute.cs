using System;

namespace KhanDotNet.Tests.Utilities
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    internal class ExpectedExceptionWithMessageAttribute : ExpectedExceptionWrapperAttribute
    {
        private string ExpectedMessage { get; set; }

        private bool TestForExactMatch { get; set; }

        private bool IgnoreCase { get; set; }

        public ExpectedExceptionWithMessageAttribute(Type exceptionType, string expectedMessage, bool match = true, bool ignoreCase = false)
            : base(exceptionType)
        {
            ExpectedMessage = expectedMessage;
            TestForExactMatch = match;
            IgnoreCase = ignoreCase;
        }

        protected override void Verify(Exception exception)
        {
            var actualException = exception;
            base.Verify(actualException);

            if (TestForExactMatch)
            {
                StringAssertHelper.AreEqual(ExpectedMessage, actualException.Message, IgnoreCase, 
                    "Exception message did not match");
            }
            else
            {
                StringAssertHelper.Contains(exception.Message, ExpectedMessage, IgnoreCase, 
                    "Exception message did not contain expected message");
            }
        }
    }
}
