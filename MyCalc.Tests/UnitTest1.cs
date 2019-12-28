using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTest()
        {
            var sut = new MyCalcLib.MyCalc();

            Assert.That(10 == sut.Add(5,5));
        }
    }
}