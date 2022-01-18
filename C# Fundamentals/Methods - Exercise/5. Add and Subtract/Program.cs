using System;

namespace _5._Add_and_Subtract
{
    class Program
    { 
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int result = Sum(firstNum, secondNum, thirdNum);
            Console.WriteLine(result);
        }

        private static int Sum(int firstNum, int secondNum, int thirdNum)
        {
            int addResult = firstNum + secondNum;
            int SubtractResult = Subtract(addResult, thirdNum);
            return SubtractResult;

        }

        private static int Subtract(int addResult, int thirdNum)
        {
            int subtractResult = addResult - thirdNum;
            return subtractResult;
        }
    }
}
