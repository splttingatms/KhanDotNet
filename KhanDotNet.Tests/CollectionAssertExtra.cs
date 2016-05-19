using KhanDotNet.Library.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace KhanDotNet.Tests
{
    static class CollectionAssertExtra
    {
        public static void AreEqual<T>(ICollection<T> expected, ICollection<T> actual)
        {
            if (expected == null)
            {
                Assert.IsNull(actual, "Actual collection is not null");
            }
            else
            {
                Assert.IsNotNull(actual, "Actual collection is null");
            }

            Assert.AreEqual(expected.Count, actual.Count, "The number of elements does not match");

            var exp = expected.ToList();
            var act = actual.ToList();

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(exp[i], act[i], "Element {0} does not match".F(i));
            }
        }
    }
}
