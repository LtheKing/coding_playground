// C# program to check whether a given
// matrix is magic matrix or not
using System;

class GFG
{

    static int N = 3;

    // Returns true if mat[][] is magic
    // square, else returns false.
    static bool isMagicSquare(int[,] mat)
    {

        // sumd1 and sumd2 are the sum of the two diagonals
        int sumd1 = 0, sumd2 = 0;

        for (int i = 0; i < N; i++)
        {
            // (i, i) is the diagonal from top-left -> bottom-right
            // (i, N - i - 1) is the diagonal from top-right -> bottom-left
            sumd1 = sumd1 + mat[i, i];
            sumd2 = sumd2 + mat[i, N - 1 - i];
        }
        // if the two diagonal sums are unequal then it is not a magic square
        if (sumd1 != sumd2)
            return false;

        // For sums of Rows
        for (int i = 0; i < N; i++)
        {

            int rowSum = 0, colSum = 0;
            for (int j = 0; j < N; j++)
            {
                rowSum += mat[i, j];
                colSum += mat[j, i];
            }
            if (rowSum != colSum || colSum != sumd1)
                return false;
        }

        return true;
    }

    // Driver Code
    public static void Main()
    {
        int[,] mat = new int[,] {{ 2, 7, 6 },
                                { 9, 5, 1 },
                                { 4, 3, 8 }};

        if (isMagicSquare(mat))
            Console.WriteLine("Magic Square");
        else
            Console.WriteLine("Not a magic" +
                            " Square");
    }
}
