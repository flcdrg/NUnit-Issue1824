using System;
using System.Collections;
using NUnit.Framework;

namespace Second.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        static IEnumerable MyTestCaseSource()
        {
            for (int i = 0; i < 100; i++)
            {
                var directory = TestContext.CurrentContext.TestDirectory;

                yield return new TestCaseData(directory + Guid.NewGuid());
            }
        }

        [TestCaseSource(nameof(MyTestCaseSource))]
        public void TestMethod1(string name)
        {
            Assert.IsNotEmpty(name);
        }
    }
}
