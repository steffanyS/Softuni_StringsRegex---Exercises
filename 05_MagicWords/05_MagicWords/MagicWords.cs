using System;
using System.Linq;

namespace _05_MagicWords
{
    class MagicWords
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var firstString = input[0].Distinct().ToArray();
            var secondString = input[1].Distinct().ToArray();

            if (firstString.Length == secondString.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
