using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest3
    {
        [Test]
        public void TestMethod3()
        {
            string a = "a";
            Assert.AreEqual("a", a);
        }
    }
}
