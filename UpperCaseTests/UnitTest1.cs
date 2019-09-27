using NUnit.Framework;
using UpperCaseApp;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        public void TestUpperCaser()
        {
            var output = UpperCase.UpperCaseThis("hi there");
            Assert.AreEqual("HI THERE", output);

            Assert.AreNotEqual("hi there", output);
        }
    }
}