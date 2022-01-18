using System;
using System.Linq;

namespace _4._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            CheckIfPasswordIsValid(password);
        }

        private static void CheckIfPasswordIsValid(string password)
        {
            bool isPasswordInRange = CheckIfPasswordIsInRange(password);
            bool isPasswordConsistOnlyLetterAndDigits = CheckPasswordConsist(password);
            bool isPasswordHaveAtLeast2Digits = CheckIfPasswordHaveDigits(password);
            if (isPasswordInRange == true && isPasswordConsistOnlyLetterAndDigits == true && isPasswordHaveAtLeast2Digits == true)
            {
                Console.WriteLine("Password is valid");
            }
            if (isPasswordInRange == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (isPasswordConsistOnlyLetterAndDigits == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (isPasswordHaveAtLeast2Digits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
        private static bool CheckIfPasswordHaveDigits(string password)
        {
            bool isItTrue = false;
            int digitsCounter = 0;
            foreach (var digit in password)
            {
                if (char.IsDigit(digit))
                {
                    digitsCounter++;
                }
            }
            if (digitsCounter >= 2)
            {
                isItTrue = true;
            }
            return isItTrue;
        }

        private static bool CheckPasswordConsist(string password)
        {
            bool isPasswordConsistLetterAndDigits = false;
            foreach (var currentItems in password)
            {
                if (char.IsLetterOrDigit(currentItems))
                {
                    isPasswordConsistLetterAndDigits = true;
                }
                else
                {
                    isPasswordConsistLetterAndDigits = false;
                    break;
                }
            }
            return isPasswordConsistLetterAndDigits;
        }

        private static bool CheckIfPasswordIsInRange(string input)
        {
            bool isInRange = false;
            if (input.Length >= 6 && input.Length <= 10)
            {
                isInRange = true;
            }
            return isInRange;
        }
    }
}
