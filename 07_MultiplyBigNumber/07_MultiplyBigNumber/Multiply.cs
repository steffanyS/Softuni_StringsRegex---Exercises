using System;
using System.Text;

namespace _07_MultiplyBigNumber
{
    class Multiply
    {
        static void Main(string[] args)
        {
            var firstNumber = Console.ReadLine();
            var secondNumber = int.Parse(Console.ReadLine());
            StringBuilder number = new StringBuilder();
            StringBuilder result = new StringBuilder();
            int numToAdd = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                var currentNum = (int.Parse(firstNumber[i].ToString()) * secondNumber + numToAdd) % 10;

                numToAdd = (int.Parse(firstNumber[i].ToString()) * secondNumber + numToAdd) / 10;

                number.Append(currentNum);
            }
            if(numToAdd!=0)
            {
                number.Append(numToAdd);
            }
            for (int i = number.Length - 1; i >= 0; i--)
            {
                result.Append(number[i]);
            }

            Console.WriteLine(result);
        }
    }
}
