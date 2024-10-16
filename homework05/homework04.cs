namespace homework05
{
    public static class homework04
    {
        public static double getBiggestDividerWithEuclid(double userInputNumberOne, double userInputNumberTwo)
        {
            // Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
            double firstNumber = Convert.ToDouble(userInputNumberOne);
            double secondNumber = Convert.ToDouble(userInputNumberTwo);

            double tmp_firstNumber = firstNumber;
            double tmp_secondNumber = secondNumber;
            while (tmp_firstNumber != 0 && tmp_secondNumber != 0)
            {
                if (tmp_firstNumber > tmp_secondNumber) tmp_firstNumber = tmp_firstNumber % tmp_secondNumber;
                else tmp_secondNumber = tmp_secondNumber % tmp_firstNumber;
            }

            double result = tmp_firstNumber + tmp_secondNumber;
            return result;
        }

        public static double getUnevenNumbersAmount(int userInputNumberOne)
        {
            // Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
            int oddNumbersAmount = 0;
            int result;
            while (userInputNumberOne > 0)
            {
                if (userInputNumberOne % 2 != 0) oddNumbersAmount++;
                userInputNumberOne = userInputNumberOne / 10;
            }
            result = oddNumbersAmount;
            return result;
        }

        public static double getMirroredNumber(int userInputNumberOne)
        {
            // Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321
            long result = 0;
            while (userInputNumberOne > 0)
            {
                int current = userInputNumberOne % 10;
                userInputNumberOne = userInputNumberOne / 10;
                result = result * 10 + current;
            }
            return result;
        }
    }
}