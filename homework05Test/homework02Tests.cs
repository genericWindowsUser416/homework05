using homework05;

namespace homework05Test
{
    public class homework02Tests
    {
        [TestCase("Кирпич", "100", "6", "да", 450)]
        [TestCase("Танк", "500000000", "1", "нет", 500000000)]
        public void getItemCostWithDiscountTest(string userInputItemName, string userInputCostPerOne, string userInputItemAmount, string userInputItemIsInPromotion, double expected)
        {
            double actual = homework02.getItemCostWithDiscount(userInputItemName, userInputCostPerOne, userInputItemAmount, userInputItemIsInPromotion);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("4", "Предлагаем средний столик на 4 человек")]
        [TestCase("9", "Столько гостей мы разместить не сможем(")]
        public void getOptimalTableSizeTest(string userInputGuestAmount, string expected)
        {
            string actual = homework02.getOptimalTableSize(userInputGuestAmount);
            Assert.That(actual, Is.EqualTo(expected));
        }

        public void getClientGetsDiscountTest(string userInputYourName, string userInputYourAge, string userInputOrderAmount, string userInputMoneySpent, string expected)
        {
            string actual = homework02.getClientGetsDiscount(userInputYourName, userInputYourAge, userInputOrderAmount, userInputMoneySpent);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
