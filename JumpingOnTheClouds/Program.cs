using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'jumpingOnClouds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY c as parameter.
     */

    public static int jumpingOnClouds(List<int> c)
    {
        int result = 0;
        int position = 0;
        foreach (var item in c.Select((value, i) => new { i, value }))
        {
            var value = item.value;
            var index = item.i;

            if (position < (c.Count() - 2) && (c[position] == c[position + 2]) && c[position] == 0)
            {
                result++;
                position += 2;
            } else if(position < (c.Count() - 2) && (c[position] == c[position + 1]) && c[position] == 0)
            {
                result++;
                position++;
            } else if ((position == c.Count() - 2) && c[position] == c[position + 1] && c[position] == 0)
            {
                result++;
                position++;
            }
        }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        //int n = 50;

        List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

        int result = Result.jumpingOnClouds(c);

        Console.WriteLine(result);
    }
}
