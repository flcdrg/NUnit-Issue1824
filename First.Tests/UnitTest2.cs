using System;
using System.Collections;
using System.Threading;
using NUnit.Framework;

namespace First.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class UnitTest2
    {
        static IEnumerable MyTestCaseSource()
        {
            for (int i = 0; i < 100; i++)
            {
                var directory = TestContext.CurrentContext.TestDirectory;

                yield return new TestCaseData(directory + Guid.NewGuid().ToString());
            }
        }

        [TestCaseSource(nameof(MyTestCaseSource))]
        public void TestMethod1(string name)
        {
            //Thread.Sleep(20);
            Assert.IsNotEmpty(name);
        }
    }
}