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
    }
}
