namespace homework05
{
    public static class homework04
    {
        public static double getBiggestDividerWithEuclid(string userInputNumberOne, string userInputNumberTwo)
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
        public static double getUnevenNumbersAmount(string userInputNumberOne)
        {
            // Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
            long inputtedNumber = Convert.ToInt64(userInputNumberOne);

            int oddNumbersAmount = 0;
            int result;
            while (inputtedNumber > 0)
            {
                if (inputtedNumber % 2 != 0) oddNumbersAmount++;
                inputtedNumber = inputtedNumber / 10;
            }
            result = oddNumbersAmount;
            return result;
        }
        //fix 
        //fix
        public static double getMirroredNumber(string userInputNumberOne) // fix
        {
            // Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321
            long inputtedNumber = Convert.ToInt64(userInputNumberOne);
            long result = 0;
            while (inputtedNumber > 0)
            {
                //Console.Write(inputtedNumber % 10);
                result = (result * 10) + (inputtedNumber % 10);
                inputtedNumber = inputtedNumber / 10;
            }
            //Console.WriteLine();
            return result;
        }
    }
}