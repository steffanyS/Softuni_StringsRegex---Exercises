using System;
using System.Linq;
using System.Text;

namespace _06_SumBigNumbers
{
    class Sum
    {
        static void Main(string[] args)
        {
            var firstNumber = Console.ReadLine().TrimStart(new char[] { '0' }).ToList();
            var secondNumber = Console.ReadLine().TrimStart(new char[] { '0' }).ToList();
            StringBuilder result = new StringBuilder();
            int add = 0;

            while (firstNumber.Count != secondNumber.Count())
            {
                if (firstNumber.Count < secondNumber.Count)
                {
                    firstNumber.Insert(0, '0');
                }
                else
                {
                    secondNumber.Insert(0, '0');
                }
            }

            for (int i = firstNumber.Count - 1; i >= 0; i--)
            {
                int sum = int.Parse(firstNumber[i].ToString()) + int.Parse(secondNumber[i].ToString());

                if (sum + add < 10)
                {
                    result.Append(sum+add);
                    add = 0;
                }
                else if(sum+add==10)
                {
                    result.Append(sum + add - 10);
                    add = 1;
                }
                else
                {
                    result.Append(sum + add - 10);
                    add = 1;
                }

                if (add == 1 && i == 0)
                {
                    result.Append(add);
                }
            }

            var endResult = "";

            for (int i = 0; i < result.Length; i++)
            {
                endResult += result[result.Length - i - 1];
            }

            Console.WriteLine(endResult);
        }
    }
}
