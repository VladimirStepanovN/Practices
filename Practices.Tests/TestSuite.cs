using NUnit.Framework;

namespace Practices.Tests
{
    [TestFixture]
    public class TestSuite
    {

        private readonly Calculator _calculator = new();

        [TestCase(0, 1, 1)]
        [TestCase(0, -1, -1)]
        [TestCase(-1, -1, -2)]
        [TestCase(-1, 1, 0)]
        [TestCase(int.MinValue, -1, int.MaxValue)]
        [TestCase(int.MaxValue, 1, int.MinValue)]
        public void Additional_MustReturnCorrectValue(int oneNumber, int twoNumber, int expectedResult)
        {
            Assert.That(_calculator.Additional(oneNumber, twoNumber), Is.EqualTo(expectedResult));
        }

        [TestCase(0, 1, -1)]
        [TestCase(0, -1, 1)]
        [TestCase(-1, -1, 0)]
        [TestCase(-1, 1, -2)]
        [TestCase(int.MinValue, 1, int.MaxValue)]
        [TestCase(int.MaxValue, -1, int.MinValue)]
        public void Subtraction_MustReturnCorrectValue(int oneNumber, int twoNumber, int expectedResult)
        {
            Assert.That(_calculator.Subtraction(oneNumber, twoNumber), Is.EqualTo(expectedResult));
        }

        [TestCase(0, 1, 0)]
        [TestCase(1, -1, -1)]
        [TestCase(-1, -1, 1)]
        [TestCase(-1, 1, -1)]
        [TestCase(int.MinValue, 2, 0)]
        [TestCase(1, int.MaxValue, int.MaxValue)]
        public void Multiplication_MustReturnCorrectValue(int oneNumber, int twoNumber, int expectedResult)
        {
            Assert.That(_calculator.Miltiplication(oneNumber, twoNumber), Is.EqualTo(expectedResult));
        }

        [TestCase(0, 1, 0)]
        [TestCase(1, -1, -1)]
        [TestCase(-1, -1, 1)]
        [TestCase(-1, 1, -1)]
        [TestCase(int.MinValue, int.MaxValue, -1)]
        [TestCase(int.MaxValue, int.MinValue, 0)]
        [TestCase(int.MaxValue, int.MaxValue, 1)]
        [TestCase(int.MinValue, int.MinValue, 1)]
        public void Division_MustReturnCorrectValue(int oneNumber, int twoNumber, int expectedResult)
        {
            Assert.That(_calculator.Division(oneNumber, twoNumber), Is.EqualTo(expectedResult));
        }

        [TestCase(0, 0)]
        public void Division_MustReturnExceptionDivideByZero(int oneNumber, int twoNumber)
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Division(twoNumber, twoNumber));
        }
    }
}