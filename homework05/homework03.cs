namespace homework05
{
    public static class homework03
    {
        public static double getAinpowerB(string userInputNumberOne, string userInputNumberTwo)
        {
            // Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
            double numberOne = Convert.ToDouble(userInputNumberOne);
            double numberTwo = Convert.ToDouble(userInputNumberTwo);

            double result = 1;
            for (int i = 0; i < numberTwo; i++)
            {
                result = result * numberOne;
            }
            return result;
        }

        public static string getNumbersFrom1To1000(string userInputNumber)
        {
            // Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
            double inputtedNumber = Convert.ToDouble(userInputNumber);
            string result = "";
            for (double i = inputtedNumber; i <= 1000 && i > 0; i = i + inputtedNumber)
            {
                result += $"{i}, ";
            }
            result = result.Remove(result.Length - 2);
            return result;
        }

        public static double getAmountOfPositiveNumbers(string userInputNumber)
        {
            // Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
            double inputtedNumber = Convert.ToDouble(userInputNumber);

            int amountOfCorrrectNumbers = 0;
            for (int i = 1; i * i < inputtedNumber; i++)
            {
                amountOfCorrrectNumbers = amountOfCorrrectNumbers + 1;
            }
            double result = amountOfCorrrectNumbers;
            return result;
        }
        public static double getBiggestDivider(string userInputNumber)
        {
            // Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
            double inputtedNumber = Convert.ToDouble(userInputNumber);
            double result = 0;
            for (double i = inputtedNumber; i > 0; i = i - 1)
            {
                if (inputtedNumber % i == 0 && inputtedNumber != i)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
        public static double getSummaryFromRangeDividedEntirelyBySeven(string userInputNumberOne, string userInputNumberTwo)
        {
            // Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7 (Учтите, что при вводе B может оказаться меньше A).
            double firstInputtedNumber = Convert.ToDouble(userInputNumberOne);
            double secondInputtedNumber = Convert.ToDouble(userInputNumberTwo);

            double biggestNumber;
            double smallerNumber;

            if (firstInputtedNumber - secondInputtedNumber > 0)
            {
                biggestNumber = firstInputtedNumber;
                smallerNumber = secondInputtedNumber;
            }
            else
            {
                biggestNumber = secondInputtedNumber;
                smallerNumber = firstInputtedNumber;
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