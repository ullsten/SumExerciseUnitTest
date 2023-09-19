using SumExercise;

namespace SumExerciseTest

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumTestPositive()
        {
            SumCalc calc = new SumCalc();

            int x= 11;
            int y = 107;
           

            var actual = calc.Sum(x, y);

            //Insert what to expect
            int expected =118;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumTestZero()
        {
            SumCalc calc = new SumCalc();

            int x= 0;
            int y = 0;

            var actual = calc.Sum(0, 0);

            //Insert what to expect
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEvenTest()
        {
            // Arrange
            SumCalc calc = new SumCalc();

            // Test for an even number
            int evenNumber = 6;
            var actual = calc.IsEvenOrOdd(evenNumber, out string evenOrOdd);

            // Assert
            Assert.AreEqual("Even", evenOrOdd);
        }

        [TestMethod]
        public void IsOddTest()
        {
            // Arrange
            SumCalc calc = new SumCalc();

            // Test for an odd number
            int oddNumber = 9;
            var actual = calc.IsEvenOrOdd(oddNumber, out string evenOrOdd);

            // Assert
            Assert.AreEqual("Odd", evenOrOdd);
        }
    }
}