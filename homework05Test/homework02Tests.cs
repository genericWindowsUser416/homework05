using homework05;

namespace homework05Test
{
    public class homework02Tests
    {
        [TestCase("Кирпич", 100, 6, true, 450)]
        [TestCase("Танк", 500000000, 1, false, 500000000)]
        public void getItemCostWithDiscountTest(string userInputItemName, double userInputCostPerOne, double userInputItemAmount, bool userInputItemIsInPromotion, double expected)
        {
            double actual = homework02.getItemCostWithDiscount(userInputItemName, userInputCostPerOne, userInputItemAmount, userInputItemIsInPromotion);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(4, "Предлагаем средний столик на 4 человек")]
        [TestCase(9, "Столько гостей мы разместить не сможем(")]
        public void getOptimalTableSizeTest(double userInputGuestAmount, string expected)
        {
            string actual = homework02.getOptimalTableSize(userInputGuestAmount);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("Андрей", 19, 5, 9000, true)]
        [TestCase("Евгений", 62, 1, 2000, true)]
        [TestCase("Антон", 22, 3, 4000, false)]
        public void getClientGetsDiscountTest(string userInputYourName, double userInputYourAge, double userInputOrderAmount, double userInputMoneySpent, bool expected)
        {
            bool actual = homework02.getClientGetsDiscount(userInputYourName, userInputYourAge, userInputOrderAmount, userInputMoneySpent);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(10, 20, 5, 2, 3, true)]
        [TestCase(200, 30, 50, 3, 4, false)]
        [TestCase(100, 25, 25, 10, 10, true)]
        public void getDeliverySizeIsSmallTest(double userInputItemLength, double userInputItemWidth, double userInputItemHeight, double userInputItemMass, double userInputDeliveryDistance, bool expected)
        {
            bool actual = homework02.getDeliverySizeIsSmall(userInputItemLength, userInputItemWidth, userInputItemHeight, userInputItemMass, userInputDeliveryDistance);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
