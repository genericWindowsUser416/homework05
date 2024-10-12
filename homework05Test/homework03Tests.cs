using homework05;

namespace homework05Test
{
    public class homework03Tests
    {
        [TestCase("50", "2", 2500)]
        [TestCase("10", "3", 1000)]
        public void getAinpowerBTest(string userInputNumberOne, string userInputNumberTwo, double expected)
        {
            double actual = homework03.getAinpowerB(userInputNumberOne, userInputNumberTwo);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("100", "100, 200, 300, 400, 500, 600, 700, 800, 900, 1000")]
        [TestCase("125", "125, 250, 375, 500, 625, 750, 875, 1000")]
        public void getNumbersFrom1To1000Test(string userInputNumber, string expected)
        {
            string actual = homework03.getNumbersFrom1To1000(userInputNumber);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("500", 22)]
        [TestCase("16", 3)]
        public void getAmountOfPositiveNumbersTest(string userInputNumber, double expected)
        {
            double actual = homework03.getAmountOfPositiveNumbers(userInputNumber);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
