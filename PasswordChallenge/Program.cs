using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PasswordChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(check("5546 dds asdf667g "));
        }

        static int check(string s)
        {
            var afterSplit = s.Split(' ');
            int longest = 0;
            List<string> selected = new List<string>();
            foreach (var item in afterSplit)
            {
                if (!Regex.IsMatch(item, "^[a-zA-Z]*$") && !Regex.IsMatch(item, "^[0-9]*$"))
                {
                    continue;
                }

                selected.Add(item);
            }

            foreach (var a in selected)
            {
                if (longest < a.Length)
                {
                    longest = a.Length;
                }
            }

            return longest;
        }
    }
}
