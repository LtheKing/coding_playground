using System;
using System.Linq;

namespace GorillaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ValidatePIN("1234"));
            //Console.WriteLine(Convert.ToInt32("0101",2));

            // 13 = 1101b
            int value = 13;

            // 11 = 1011b
            int result = Convert.ToInt32(new String(
                    Convert.ToString(value, 2)
                    .Reverse()
                    .ToArray()), 2);

            Console.WriteLine(result);
        }

        public static string ValidatePIN(string a)
        {
            if (a.Length == 4 || a.Length == 6)
            {
                double r;
                var i = double.TryParse(a, out r);
                if (i)
                {
                    return "The ATM PIN is valid";
                }
                else
                {
                    return "The ATM PIN is invalid";
                }
            }
            else
            {
                return "The ATM PIN is invalid";
            }
        }
    }
}
