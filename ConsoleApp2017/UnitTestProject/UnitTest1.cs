﻿using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture(Category = "NoPR")]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            string a = "a";
            Assert.AreEqual("a", a);
        }
    }
}
