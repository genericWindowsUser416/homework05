namespace homework05
{
    public static class homework02
    {
        public static double getItemCostWithDiscount(string userInputItemName, string userInputCostPerOne, string userInputItemAmount, string userInputItemIsInPromotion)
        {
            // Позиция товара в чеке интернет магазина описывается следующими значениями: -Название; -Цена за единицу; -Количество; -Участвует в акции(да/ нет). Напишите программу, которая получает перечисленные значения и вычисляет сумму по следующему правилу: Если количество товара в чеке больше либо равно 5, то к товару применяется скидка в 10 %.Если товар учавствует в акции -применяется скидка в 15 %. Скидки могут суммироваться.
            string itemName = userInputItemName;
            double costPerOne = Convert.ToDouble(userInputCostPerOne);
            double itemAmount = Convert.ToDouble(userInputItemAmount);
            bool itemIsInPromotionBool;

            if (userInputItemIsInPromotion == "да") itemIsInPromotionBool = true;
            else itemIsInPromotionBool = false;

            double promotionDiscount = 0.15;
            double manyItemsDiscount = 0.1;
            double totalDiscount = 0;
            string result;
            if (itemAmount >= 5) totalDiscount = totalDiscount + manyItemsDiscount;
            if (itemIsInPromotionBool == true) totalDiscount = totalDiscount + promotionDiscount;

            double finalCost = (itemAmount * costPerOne) - (itemAmount * costPerOne * totalDiscount);
            result = $"Итоговая стоимость {itemName}: {finalCost}";
            return finalCost;
        }
        public static string getOptimalTableSize(string userInputGuestAmount)
        {
            // В ресторане находится несколько видов посадочных мест: 1 Маленький стол - до 2-х человек; 2 Средний стол - до 4-х человек; 3 Большой стол - до 8-и человек. Компанию более 8-и человек ресторан разместить не сможет( Напишите программу, которая будет получать от пользователя количество гостей и предлагать наиболее подходящий стол.
            int guestAmount = Convert.ToInt32(userInputGuestAmount);
            int smallTableCapacity = 2;
            int mediumTableCapacity = 4;
            int largeTableCapacity = 8;
            string result = "";

            if (guestAmount > largeTableCapacity) result = "Столько гостей мы разместить не сможем(";
            if (guestAmount <= smallTableCapacity) result = "Предлагаем маленький столик на 2 человек";
            if (guestAmount > smallTableCapacity && guestAmount <= mediumTableCapacity) result = "Предлагаем средний столик на 4 человек";
            if (guestAmount > mediumTableCapacity && guestAmount <= largeTableCapacity) result = "Предлагаем большой столик на 8 человек";
            return result;
        }
        public static bool getClientGetsDiscount(string userInputYourName, string userInputYourAge, string userInputOrderAmount, string userInputMoneySpent)
        {
            // Магазин хранит о клиентах следующую информацию: - Имя; - Возраст; - Количество заказов; - Суммы потраченных средств. Магазин предлагает постоянным клиентам и клиентам старше 60 лет скидку. Клиент считается постоянным, если он произвел 4 или более заказов общей суммой от 5000 Напишите программу, которая будет получать на вход данные о клиенте и возвращать на консоль информацию о том получает ли клиент скидку или нет.
            string yourName = userInputYourName;
            double yourAge = Convert.ToDouble(userInputYourAge);
            double orderAmount = Convert.ToDouble(userInputOrderAmount);
            double moneySpent = Convert.ToDouble(userInputMoneySpent);
            bool result = false;

            if (yourAge > 60) result = true;
            if (orderAmount >= 4 && moneySpent >= 5000) result = true;

            return result;
        }
        public static bool getDeliverySizeIsSmall(string userInputItemLength, string userInputItemWidth, string userInputItemHeight, string userInputItemMass, string userInputDeliveryDistance)
        {
            // Курьерская служба принимает в работу в качестве малогабаритного отправления только заказы соответствующие следующим условиям: - Сумма длины, ширины и высоты отправления не превышает 150см; - Ни одно из измерений не превышает 100см; - Масса отправления не превышает 10кг; - Расстояние доставки находится в диапазоне от 3 до 10км. Напишите программу, которая будет получать от пользователя данные об отправлении и сообщать, является ли оно малогабаритным.
            double maximumLength = 100;
            double maximumWidth = 100;
            double maximumHeight = 100;
            double maximumDimensionSummary = 150;
            double maximumMass = 10;
            double deliveryDistanceMin = 3;
            double deliveryDistanceMax = 10;

            double itemLength = Convert.ToDouble(userInputItemLength);
            double itemWidth = Convert.ToDouble(userInputItemWidth);
            double itemHeight = Convert.ToDouble(userInputItemHeight);
            double itemMass = Convert.ToDouble(userInputItemMass);
            double deliveryDistance = Convert.ToDouble(userInputDeliveryDistance);

            bool result = false;
            if (itemLength + itemWidth + itemHeight <= maximumDimensionSummary && itemMass <= maximumMass)
            {
                if (itemLength <= maximumLength && itemWidth <= maximumWidth && itemHeight <= maximumHeight)
                {
                    if (deliveryDistanceMin <= deliveryDistance && deliveryDistance <= deliveryDistanceMax)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
