using System;
using System.Linq;
using System.Text;

namespace _5._Multiply_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();

            string firstNumber = Console.ReadLine().TrimStart('0');
            int numberToMultiply = int.Parse(Console.ReadLine());
            int temp = 0;

            if (numberToMultiply == 0 || firstNumber == "")
            {
                Console.WriteLine(0);
                return;
            }

         
            foreach(var symbol in  firstNumber.Reverse())
            {
                int digit = int.Parse(symbol.ToString());
                int result = digit * numberToMultiply + temp;

                int restDigit = result % 10;
                temp = result / 10;

                sb.Insert(0, restDigit);
            }

            if (temp > 0)
            {
                sb.Insert(0, temp);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
