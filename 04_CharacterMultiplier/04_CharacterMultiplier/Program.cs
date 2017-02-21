using System;
using System.Linq;

namespace _04_CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            string firstString = input[0];
            string secondString = input[1];
            long sum = 0;

            if (firstString.Length == secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    sum += (long)firstString[i] * (long)secondString[i];
                }
            }
            else
            {
                for (int i = 0; i < Math.Min(firstString.Length, secondString.Length); i++)
                {
                    sum += (long)firstString[i] * (long)secondString[i];
                }

                for (int i = Math.Min(firstString.Length, secondString.Length); i < Math.Max(firstString.Length, secondString.Length); i++)
                {
                    if (firstString.Length > secondString.Length)
                    {
                        sum += firstString[i];
                    }
                    else
                    {
                        sum += secondString[i];
                    }
                }

            }
            Console.WriteLine(sum);
        }
    }
}
