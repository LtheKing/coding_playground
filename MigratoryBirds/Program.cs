using System;
using System.Collections.Generic;
using System.Linq;

namespace MigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);
            Console.WriteLine(result);
        }

        public static int migratoryBirds(List<int> arr)
        {
            var dict = new Dictionary<int, int>();
            foreach (var value in arr)
            {
                // When the key is not found, "count" will be initialized to 0
                dict.TryGetValue(value, out int count);
                dict[value] = count + 1;
            }

            List<int> biggest = new List<int>();
            var maxKey = dict.Keys.Max();
            var maxValue = dict.Values.Max();

            foreach (var item in dict)
            {
                if (item.Value == maxValue)
                {
                    biggest.Add(item.Key);
                }
            }

            return Convert.ToInt32(biggest.Min());
        }
    }
}
