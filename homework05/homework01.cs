namespace homework05
{
    public static class homework01
    {
        public static double getDeliveryCost(string userInput)
        {
            // Курьерская служба выполняет доставки по единому тарифу: 150р. фиксировано + 70р. за каждый километр дороги. Напишите программу, которая получает длину пути в км и выводить на консоль цену доставки.
            double roadLength = Convert.ToDouble(userInput);
            double startingCost = 150;
            double costPerKilometer = 70;
            double result = startingCost + costPerKilometer * roadLength;
            return result;
        }

        public static double getBonusAmount(string userInputTotalSells, string userInputPlannedSells)
        {
            // Продавец сети магазинов получает премию составляющую процент от продаж: - 10% с продаж выше плана; Напишите программу, которая получает сумму продаж за месяц и план продаж и выведет на консоль размер премии сотрудника.
            double totalSells = Convert.ToDouble(userInputTotalSells);
            double plannedSells = Convert.ToDouble(userInputPlannedSells);
            double result = (totalSells - plannedSells) / 10;
            return result;
        }

        public static double getInvestmentEarnAmount(string userInputDepositAmount)
        {
            // Банк предоставляет вклад: - под 10% годовых длительностью в 18 месяцев. Напишите программу, которая получает сумму вклада и выведет на консоль его прибыль.
            double depositAmount = Convert.ToDouble(userInputDepositAmount);
            double yearCount = 1.5;
            double percentAYear = 0.1;
            double result = (depositAmount * yearCount * percentAYear) + depositAmount;
            return result;
        }
    }
}
