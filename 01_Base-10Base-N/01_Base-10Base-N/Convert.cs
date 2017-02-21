using System;
using System.Linq;
using System.Text;

namespace _01_Base_10Base_N
{
    class Convert
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            var nBase = input[0];
            var number = input[1];
            var endResult = "";

            StringBuilder result = new StringBuilder();

            while (number > 0)
            {
                result.Append(number % nBase);
                number /= nBase;
            }

            for (int i = 0; i < result.Length; i++)
            {
                endResult += result[result.Length - 1 - i];
            }

            Console.WriteLine(endResult);
        }
    }
}
