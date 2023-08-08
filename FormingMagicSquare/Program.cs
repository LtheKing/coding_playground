class Result
{

    /*
     * Complete the 'formingMagicSquare' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY s as parameter.
     */
    static int N = 3;

    public static int formingMagicSquare(List<List<int>> s)
    {
        int lowestCost = 0;
        // sumd1 and sumd2 are the sum of the two diagonals
        int sumd1 = 0, sumd2 = 0;

        for (int i = 0; i < N; i++)
        {
            // (i, i) is the diagonal from top-left -> bottom-right
            // (i, N - i - 1) is the diagonal from top-right -> bottom-left
            sumd1 = sumd1 + s[i][i];
            sumd2 = sumd2 + s[i][N - 1 - i];
        }
        // if the two diagonal sums are unequal then it is not a magic square
        if (sumd1 < 15)
        {
            lowestCost += 15 - sumd1;
        }

        if (sumd2 < 15)
        {
            lowestCost += 15 - sumd2;

            //if ((15 - sumd2) < lowestCost)
            //{
            //    lowestCost = 15 - sumd2;
            //}
        }

        // For sums of Rows
        for (int i = 0; i < N; i++)
        {

            int rowSum = 0, colSum = 0;

            for (int j = 0; j < N; j++)
            {
                rowSum += s[i][j];
                colSum += s[j][i];
            }

            if (rowSum < 15)
            {
                lowestCost += 15 - rowSum;

                //if ((15 - rowSum) < lowestCost)
                //{
                //    lowestCost = 15 - rowSum;
                //}
            }

            if (colSum < 15)
            {
                lowestCost += 15 - colSum;
                
                //if ((15 - colSum) < lowestCost)
                //{
                //    lowestCost = 15 - colSum;
                //}
            }
        }

        return lowestCost;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<List<int>> s = new List<List<int>>();

        for (int i = 0; i < 3; i++)
        {
            s.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
        }

        int result = Result.formingMagicSquare(s);

        Console.WriteLine(result);
        Console.WriteLine("finished");
    }
}
