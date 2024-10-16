namespace homework05
{
    public static class homework02
    {
        public static double getItemCostWithDiscount(string userInputItemName, double userInputCostPerOne, double userInputItemAmount, bool userInputItemIsInPromotion)
        {
            // Позиция товара в чеке интернет магазина описывается следующими значениями: -Название; -Цена за единицу; -Количество; -Участвует в акции(да/ нет). Напишите программу, которая получает перечисленные значения и вычисляет сумму по следующему правилу: Если количество товара в чеке больше либо равно 5, то к товару применяется скидка в 10 %.Если товар учавствует в акции -применяется скидка в 15 %. Скидки могут суммироваться.

            double promotionDiscount = 0.15;
            double manyItemsDiscount = 0.1;
            double totalDiscount = 0;
            if (userInputItemAmount >= 5) totalDiscount = totalDiscount + manyItemsDiscount;
            if (userInputItemIsInPromotion) totalDiscount = totalDiscount + promotionDiscount;

            double finalCost = (userInputItemAmount * userInputCostPerOne) - (userInputItemAmount * userInputCostPerOne * totalDiscount);
            return finalCost;
        }
        public static string getOptimalTableSize(double userInputGuestAmount)
        {
            // В ресторане находится несколько видов посадочных мест: 1 Маленький стол - до 2-х человек; 2 Средний стол - до 4-х человек; 3 Большой стол - до 8-и человек. Компанию более 8-и человек ресторан разместить не сможет( Напишите программу, которая будет получать от пользователя количество гостей и предлагать наиболее подходящий стол.
            int smallTableCapacity = 2;
            int mediumTableCapacity = 4;
            int largeTableCapacity = 8;
            string result = "";

            if (userInputGuestAmount > largeTableCapacity) result = "Столько гостей мы разместить не сможем(";
            if (userInputGuestAmount <= smallTableCapacity) result = "Предлагаем маленький столик на 2 человек";
            if (userInputGuestAmount > smallTableCapacity && userInputGuestAmount <= mediumTableCapacity) result = "Предлагаем средний столик на 4 человек";
            if (userInputGuestAmount > mediumTableCapacity && userInputGuestAmount <= largeTableCapacity) result = "Предлагаем большой столик на 8 человек";
            return result;
        }
        public static bool getClientGetsDiscount(string userInputYourName, double userInputYourAge, double userInputOrderAmount, double userInputMoneySpent)
        {
            // Магазин хранит о клиентах следующую информацию: - Имя; - Возраст; - Количество заказов; - Суммы потраченных средств. Магазин предлагает постоянным клиентам и клиентам старше 60 лет скидку. Клиент считается постоянным, если он произвел 4 или более заказов общей суммой от 5000 Напишите программу, которая будет получать на вход данные о клиенте и возвращать на консоль информацию о том получает ли клиент скидку или нет.
            bool result = false;

            result = (userInputOrderAmount >= 4 && userInputMoneySpent >= 5000) || userInputYourAge > 60;

            return result;
        }
        public static bool getDeliverySizeIsSmall(double userInputItemLength, double userInputItemWidth, double userInputItemHeight, double userInputItemMass, double userInputDeliveryDistance)
        {
            // Курьерская служба принимает в работу в качестве малогабаритного отправления только заказы соответствующие следующим условиям: - Сумма длины, ширины и высоты отправления не превышает 150см; - Ни одно из измерений не превышает 100см; - Масса отправления не превышает 10кг; - Расстояние доставки находится в диапазоне от 3 до 10км. Напишите программу, которая будет получать от пользователя данные об отправлении и сообщать, является ли оно малогабаритным.
            double maximumLength = 100;
            double maximumWidth = 100;
            double maximumHeight = 100;
            double maximumDimensionSummary = 150;
            double maximumMass = 10;
            double deliveryDistanceMin = 3;
            double deliveryDistanceMax = 10;

            bool result = false;
            if (userInputItemLength + userInputItemWidth + userInputItemHeight <= maximumDimensionSummary && userInputItemMass <= maximumMass)
            {
                if (userInputItemLength <= maximumLength && userInputItemWidth <= maximumWidth && userInputItemHeight <= maximumHeight)
                {
                    if (deliveryDistanceMin <= userInputDeliveryDistance && userInputDeliveryDistance <= deliveryDistanceMax)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
