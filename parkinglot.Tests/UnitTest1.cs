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
            var myLot = new Lot(12);
            Assert.AreEqual(12, myLot.Spaces);
        }

        [Test]
        public void Test2()
        {
            var myLot = new Lot(200);
            Assert.AreEqual(200, myLot.Spaces);
        }

        [Test]
        public void Test3()
        {
            var myLot = new Lot(300);
            Assert.AreEqual(200, myLot.Spaces);
        }
    }
}