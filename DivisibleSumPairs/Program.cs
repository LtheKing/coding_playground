using System;
using System.Collections.Generic;
using System.Linq;

namespace DivisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Program.divisibleSumPairs(n, k, ar);

            Console.WriteLine("This is result : " + result);
        }

        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int result = 0;

            for (int i = 0; i < ar.Count(); i++)
            {
                for (int x = 1; x < n; x++)
                {
                    if (i < x && (ar[i] + ar[x]) % k == 0)
                    {
                        result++;
                    }
                }
            }

            return result;
        }

    }
}
