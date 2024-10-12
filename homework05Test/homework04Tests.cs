using homework05;

namespace homework05Test
{
    public class homework04Tests
    {
        [TestCase("22","11",11)]
        [TestCase("40", "16", 8)]
        public void getBiggestDividerWithEuclidTest(string userInputNumberOne, string userInputNumberTwo, double expected)
        {
            double actual = homework04.getBiggestDividerWithEuclid(userInputNumberOne, userInputNumberTwo);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
