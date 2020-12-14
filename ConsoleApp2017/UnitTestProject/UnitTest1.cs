using NUnit.Framework;

namespace UnitTestProject
{
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
