//using System;

//namespace _9._Palindrome_Integers
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string command = Console.ReadLine();
//            command = CheckIfFirstNumberIsEqualToLast(command);
//        }

//        private static string CheckIfFirstNumberIsEqualToLast(string command)
//        {
//            while (command != "End" && command != "END" && command != "end")
//            {
//                int number = Convert.ToInt32(command);
//                string numberToString = number.ToString();
//                char firstNumber = numberToString[0];
//                char lastNumber = numberToString[numberToString.Length - 1];

//                if (firstNumber == lastNumber)
//                {
//                    Console.WriteLine("true");
//                }
//                else
//                {
//                    Console.WriteLine("false");
//                }

//                command = Console.ReadLine();
//            }

//            return command;
//        }
//    }
//}
using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                bool isIntegerPalindrome = ReturnsIsNumberPalindrome(input);
                if (isIntegerPalindrome)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        static bool ReturnsIsNumberPalindrome(string input)
        {
            int number = int.Parse(input);
            bool result = false;
            if (number >= 0 && number <= 9)
            {
                result = true;
            }
            else
            {
                for (int i = 0; i < input.Length / 2; i++)
                {
                    if (input[i] == input[input.Length - 1])
                    {
                        result = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return result;
        }
    }
}
