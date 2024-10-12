using homework05;

namespace homework05Test
{
    public class homework01Tests
    {

        [TestCase("5", 500)]
        public void getDeliveryCostTest(string userInput, double expected)
        {
            double actual = homework01.getDeliveryCost(userInput);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("200", "100", 10)]
        public void getBonusAmountTest(string userInputTotalSells, string userInputPlannedSells, double expected)
        {
            double actual = homework01.getBonusAmount(userInputTotalSells, userInputPlannedSells);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("100", 115)]
        public void getInvestmentEarnAmountTest(string userInputDepositAmount, double expected)
        {
            double actual = homework01.getInvestmentEarnAmount(userInputDepositAmount);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}