using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture(Category = "L0")]
    public class UnitTest2
    {
        [Test]
        public void TestMethod2()
        {
            string a = "a";
            Assert.AreEqual("a", a);
        }
    }
}
