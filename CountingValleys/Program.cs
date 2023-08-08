using System.Collections.Concurrent;

class Result
{

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        var step = new ConcurrentBag<int>();
        int valley = 0;

        //char[] letters = path.ToCharArray();

        //letters.ToList().ForEach(x =>
        //{
        //    if (x == 'U')
        //    {
        //        step.Add(1);

        //        if ((step.Sum() == 0))
        //        {
        //            valley++;
        //        }
        //    }
        //    else
        //    {
        //        step.Add(-1);
        //    }
        //});

        for (int i = 0; i < steps; i++)
        {
            if (path[i] == 'U')
            {
                step.Add(1);

                if ((step.Sum() == 0))
                {
                    valley++;
                }
            }
            else
            {
                step.Add(-1);
            }
        }

        return valley;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        Console.WriteLine(result);
    }
}