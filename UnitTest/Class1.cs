using System;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class SuccessTests
    {
        [SetUp]
        public void Init()
        {  }

        [TearDown]
        public void Dispose()
        { /* ... */ }

        [Test]
        public void Test1()
        { Assert.True(true); }
    }
}
