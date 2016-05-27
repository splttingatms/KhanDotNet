using KhanDotNet.Library.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KhanDotNet.Tests.Utilities
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    internal class ExpectedExceptionWrapperAttribute : ExpectedExceptionBaseAttribute
    {
        public Type ExpectedExceptionType { get; private set; }

        public ExpectedExceptionWrapperAttribute(Type exceptionType)
        {
            ExpectedExceptionType = exceptionType;
        }

        protected override string NoExceptionMessage
        {
            get
            {
                var testMethodName = TestContext.TestName;
                var attributeName = GetType().FullName;
                return 
                    "Test method {0} did not throw an exception. An exception was expected by attribute {1} defined on the test method."
                    .F(testMethodName, attributeName);
            }
        }
        protected override void Verify(Exception exception)
        {
            RethrowIfAssertException(exception);

            if (exception.GetType() != ExpectedExceptionType)
            {
                // TestContext is null if exception was thrown so can't get test method name
                var actualExceptionType = exception.GetType().FullName;
                var expectedExceptionType = ExpectedExceptionType.FullName;
                var actualExceptionMessage = exception.Message;
                var message = 
                    "Test method threw exception {0}, but exception {1} was expected. Exception message: {2}"
                    .F(actualExceptionType, expectedExceptionType, actualExceptionMessage);
                throw new AssertFailedException(message);
            }
        }
    }
}
