using KellermanSoftware.CompareNetObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KhanDotNet.Tests.Utilities
{
    public static class TestExtensions
    {
        public static void AssertDeepEqual(this object expected, object actual)
        {
            var comparer = new CompareLogic(new ComparisonConfig() { MaxDifferences = 5 });
            var result = comparer.Compare(expected, actual);

            // TODO 3: throw AssertFailedException instead
            Assert.IsTrue(result.AreEqual, result.DifferencesString);
        }
    }
}
