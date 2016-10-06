using System;
using System.Collections;
using System.Threading;
using NUnit.Framework;

namespace First.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class UnitTest1
    {
        static IEnumerable MyTestCaseSource()
        {
            for (int i = 0; i < 100; i++)
            {
                yield return new TestCaseData(Guid.NewGuid().ToString());
            }
        }

        [TestCaseSource(nameof(MyTestCaseSource))]
        public void TestMethod1(string name)
        {
            Thread.Sleep(10);
            Assert.IsNotEmpty(name);
        }
    }
}
