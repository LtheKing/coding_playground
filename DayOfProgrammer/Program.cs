using System.Globalization;

class Solution
{
    public static void Main(string[] args)
    {
        int year = Convert.ToInt32(Console.ReadLine().Trim());
        string result = Result.dayOfProgrammer(year);
        Console.WriteLine(result);
    }
}

class Result
{

    /*
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {
        var isLeap = DateTime.IsLeapYear(year);
        var totalNotLeap = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
        var totalLeap = 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31;

        if (year >= 1919)
        {
            if (isLeap)
            {
                var result = 256 - totalLeap;
                return result.ToString() + "." + "09" + "." + year.ToString();
            }

            var result2 = 256 - totalNotLeap;
            return result2.ToString() + "." + "09" + "." + year.ToString();
        }

        JulianCalendar jc = new JulianCalendar();
        var jcLeap = jc.IsLeapYear(year);

        if (jcLeap)
        {
            var result = 256 - totalLeap;
            return result.ToString() + "." + "09" + "." + year.ToString();
        }

        var result2_jc = 256 - totalNotLeap;
        return result2_jc.ToString() + "." + "09" + "." + year.ToString();
    }

}