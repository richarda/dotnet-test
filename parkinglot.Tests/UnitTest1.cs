using NUnit.Framework;
using Parkinglot;
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
            var myLot = new Lot();
            Assert.AreEqual(12, myLot.Spaces);
        }
    }
}