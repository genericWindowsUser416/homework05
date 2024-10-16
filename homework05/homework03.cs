using System.Text;

namespace homework05
{
    public static class homework03
    {
        public static double getAinpowerB(double userInputNumberOne, double userInputNumberTwo)
        {
            // Пользователь вводит 2 числа (A и B). Возвести число A в степень B.

            double result = 1;
            for (int i = 0; i < userInputNumberTwo; i++)
            {
                result = result * userInputNumberOne;
            }
            return result;
        }

        public static string getNumbersFrom1To1000(double userInputNumber)
        {
            // Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
            StringBuilder sb = new StringBuilder();
            for (double i = userInputNumber; i <= 1000 && i > 0; i = i + userInputNumber)
            {
                sb.Append($"{i}, ");
            }
            sb = sb.Remove(sb.Length - 2, 2);
            string result = sb.ToString();
            return result;
        }

        public static double getAmountOfPositiveNumbers(double userInputNumber)
        {
            // Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
            int amountOfCorrrectNumbers = 0;
            for (int i = 1; i * i < userInputNumber; i++)
            {
                amountOfCorrrectNumbers = amountOfCorrrectNumbers + 1;
            }
            double result = amountOfCorrrectNumbers;
            return result;
        }

        public static double getBiggestDivider(double userInputNumber)
        {
            // Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
            double result = 0;
            for (double i = userInputNumber; i > 0; i = i - 1)
            {
                if (userInputNumber % i == 0 && userInputNumber != i)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public static double getSummaryFromRangeDividedEntirelyBySeven(double userInputNumberOne, double userInputNumberTwo)
        {
            // Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7 (Учтите, что при вводе B может оказаться меньше A).
            double biggestNumber;
            double smallerNumber;

            if (userInputNumberOne - userInputNumberTwo > 0)
            {
                biggestNumber = userInputNumberOne;
                smallerNumber = userInputNumberTwo;
            }
            else
            {
                biggestNumber = userInputNumberTwo;
                smallerNumber = userInputNumberOne;
            }

            double summaryOfFittingNumbers = 0;
            for (double i = smallerNumber; i <= biggestNumber; i++)
            {
                if (i % 7 == 0) summaryOfFittingNumbers = summaryOfFittingNumbers + i;
            }

            double result = summaryOfFittingNumbers;
            return result;
        }
    }
}