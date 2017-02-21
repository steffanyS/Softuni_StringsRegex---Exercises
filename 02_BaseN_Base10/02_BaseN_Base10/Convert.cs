using System;
using System.Linq;

namespace _02_BaseN_Base10
{
    class Convert
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var nBase = long.Parse(input[0]);
            var number = input[1];

            long endResult = 0;

            for (int i = 0; i < number.Length; i++)
            {
                var result = (long.Parse(number[i].ToString()) * (long)Math.Pow(nBase, number.Length - i - 1));
                endResult += result;
            }

            Console.WriteLine(endResult);
        }
    }
}
