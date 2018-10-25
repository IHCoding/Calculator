using NUnit.Framework;

namespace Calculator.Unit.Test
{

    [TestFixture]
    public class CalculatorUnitTest
    {
        private Calculator uut;

        [Test]
        public void GoodTest()
        {
            var x = 4;
            var y = 5;

            Assert.That(uut.Add(x, y), Is.EqualTo(9));
            Assert.That(uut.Subtract(x, y), Is.EqualTo(-1));


        }

        [Test] // Very important to add this Test tag, otherwise it won't be seen as test

        public void BadTest()
        {
            var x = 4;
            var y = 5;

            Assert.That(uut.Add(x, y), Is.EqualTo(9));
            Assert.That(uut.Subtract(x, y), Is.EqualTo(-1));

        }


        [SetUp]
        public void SetUp()
        {
            uut = new Calculator();
        }

        //[TestCase(3, 3, 6)]
        //[TestCase(-3, -3, -6)]
        //[TestCase(3, -3, 0)]
        //[TestCase(-3, 0, -3)]
        //[TestCase(0, 0, 0)]

        [TestCaseSource(typeof(TestCaseSource))]
        public void Add_NegPosNumbers_CorrectResult(int x, int y, int r)
        {
            Assert.That(uut.Add(x, y), Is.EqualTo(r));
        }


        [TestCase(1, 0, 1)]
        [TestCase(-3, -3, 0)]
        [TestCase(3, -3, 6)]
        [TestCase(0, 1, -1)]

        public void Subtract_NegPosNumbers_CorrectResult(int x, int y, int r)
        {
            Assert.That(uut.Subtract(x, y), Is.EqualTo(r));
        }


        [TestCase(2, 2, 4)]
        [TestCase(-4, -4, 16)]
        [TestCase(-3, 9, -27)]
        [TestCase(10, 0, 0)]
        public void Multiply_MultiplyNumber_CorrectResult(int x, int y, int r)
        {
            Assert.That(uut.Multiply(x, y), Is.EqualTo(r));
        }


        [TestCase(2, 2, 4)]
        [TestCase(-4, -4, 16)]
        [TestCase(-3, 3, -9)]
        [TestCase(10, 0, 0)]
        [TestCase(10, 2, 20)]
        [TestCase(10, 0, 0)]
        [TestCase(10, 0.5, 5)]

        public void Power_RaiseNumbers_CorrectResult(double x, double y, double r)
        {
            Assert.That(uut.Multiply(x, y), Is.EqualTo(r));
        }


        //public class CalculatorCombinatorialTests
        //{
        //    [Test]
        //    public void ShouldAddAndDivide(
        //        [Values(10, 20, 30)] int numToAdd,
        //        [Values(3, 5, 2)] int numToDivideBy)
        //    {
        //        var sut = new Calculator();
        //        sut.Add(numToAdd);
        //        sut.Divide(numToDivideBy);
        //    }

        //}


    }
}
