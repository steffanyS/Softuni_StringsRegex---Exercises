using System;
using System.Linq;

namespace _09_LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double totalSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var currentString = input[i];
                var before = currentString[0];
                var after = currentString[currentString.Length - 1];
                var number = double.Parse(currentString.Substring(1, currentString.Length - 2));


                if (char.IsLower(before))
                {
                    number *= (double)((int)before - 96);
                }
                else
                {
                    number /= (double)((int)before - 64);
                }

                if (char.IsLower(after))
                {
                    number += (double)((int)after - 96);
                }
                else
                {
                    number -= (double)((int)after - 64);
                }

                totalSum += number;
            }

            Console.WriteLine("{0:f2}", totalSum);
        }
    }
}

