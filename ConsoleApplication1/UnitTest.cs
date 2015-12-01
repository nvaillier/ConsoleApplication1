using NUnit.Framework;

namespace ConsoleApplication1
{
    [TestFixture]
    public class UnitTest
    {
        [TestCase]
        public void Should_Create_A_Default_Valuated_Point()
        {
            var point = new Point();
            Assert.IsNotNull(point);
            Assert.AreEqual(point.X, 0);
            Assert.AreEqual(point.Y, 0);
            Assert.IsTrue(point.ToString().Contains("0"));
        }

        [TestCase(1, 3)]
        public void Should_Create_A_Point(int xToTest, int yTotest)
        {
            var point = new Point(xToTest, yTotest);
            Assert.IsNotNull(point);
            Assert.AreEqual(point.X, xToTest);
            Assert.AreEqual(point.Y, yTotest);
            Assert.IsTrue(point.ToString().Contains(xToTest.ToString()));
            Assert.IsTrue(point.ToString().Contains(yTotest.ToString()));
        }

        [TestCase(3, 4, 5)]
        [TestCase(3, -4, 5)]
        [TestCase(-3, -4, 5)]
        public void Should_Calculate_Right_Distance_When_A_Point_Is_Given(int xToTest, int yTotest, double result)
        {
            var point = new Point(xToTest, yTotest);
            Assert.IsNotNull(point);
            Assert.AreEqual(result, point.Dist);
        }

    }
}
