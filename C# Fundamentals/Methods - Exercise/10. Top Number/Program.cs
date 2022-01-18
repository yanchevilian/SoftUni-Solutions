//using System;

//namespace _10._Top_Number
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int number = int.Parse(Console.ReadLine());
//            PrinTopNumbers(number);
//        }

//        private static void PrinTopNumbers(int number)
//        {
//            for (int i = 1; i <= number; i++)
//            {
//                if (IsCurrentNumberDivisibleBy8(i) && HasEvenNumber(i))
//                {
//                    Console.WriteLine(i);
//                }
//            }
//        }

//        private static bool HasEvenNumber(int number)
//        {
//            while (number > 0)
//            {
//                if ((number % 10) % 2 == 1)
//                {
//                    return true;
//                }
//                number /= 10;
//            }
//            return false;
//        }

//        private static bool IsCurrentNumberDivisibleBy8(int number)
//        {
//            int digitSum = 0;
//            while (number > 0)
//            {
//                digitSum += number % 10;
//                number /= 10;
//            }
//            if (digitSum % 8 == 0)
//            {
//                return true;
//            }
//            return false;
//        }
//    }
//}
using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTopNumber(number);
        }

        private static void PrintTopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                string parsedNumber = i.ToString();
                bool isDigit = false;
                int sumOfDigits = 0;

                foreach (var curr in parsedNumber)
                {
                    int convertedNumber = int.Parse(curr.ToString());

                    if (convertedNumber % 2 == 1)
                    {
                        isDigit = true;
                    }
                    sumOfDigits += convertedNumber;
                }

                if (isDigit && sumOfDigits % 8 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}