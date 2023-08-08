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
     * Complete the 'repeatedString' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. LONG_INTEGER n
     */

    public static long repeatedString(string s, long n)
    {
        //var ls = s.Length;
        //var kali = n / ls;
        //var news = "";
        //var aa = 0;
        //for (int i = 0; i <= kali; i++)
        //{
        //    news += s;
        //}

        //news = news.Remove(news.Length - (news.Length - Convert.ToInt32(n)));
        //char[] loop = news.ToCharArray();

        //for (int i = 0; i < n; i++)
        //{
        //    if (loop[i] == 'a')
        //    {
        //        aa++;
        //    }
        //}

        var count_s = s.Split('a').Length - 1;
        var repeat_s = n / s.Length;

        return 0;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.repeatedString(s, n);

        Console.WriteLine(result);
    }
}