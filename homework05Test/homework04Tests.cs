using homework05;

namespace homework05Test
{
    public class homework04Tests
    {
        [TestCase(22, 11, 11)]
        [TestCase(40, 16, 8)]
        public void getBiggestDividerWithEuclidTest(double userInputNumberOne, double userInputNumberTwo, double expected)
        {
            double actual = homework04.getBiggestDividerWithEuclid(userInputNumberOne, userInputNumberTwo);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(112, 2)]
        [TestCase(12345678, 4)]
        public void getUnevenNumbersAmountTest(int userInputNumberOne, double expected)
        {
            double actual = homework04.getUnevenNumbersAmount(userInputNumberOne);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(123, 321)]
        [TestCase(20010670, 07601002)]
        public void getMirroredNumberTest(int userInputNumberOne, double expected)
        {
            double actual = homework04.getMirroredNumber(userInputNumberOne);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
