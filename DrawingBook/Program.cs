class solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.pageCount(n, p);

        Console.WriteLine(result);
    }
}

class Result
{

    /*
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */

    public static int pageCount(int n, int p)
    {
        List<int> page = new List<int>();
        List<List<int>> book = new List<List<int>>();

        for (int i = 0; i <= n; i++)
        {
            page.Add(i);

            if (page.Count == 2)
            {
                book.Add(new List<int>
                    {
                        page[0], page[1]
                    });

                page.RemoveAt(0);
                page.RemoveAt(0);
            }
        }

        if (!book.LastOrDefault().Contains(n))
        {
            book.Add(new List<int>
                    {
                        n
                    });
        }

        int step1 = 0;
        int step2 = 0;

        if (n > p)
        {
            for (int i = (book.Count() - 1); i >= 0; i--)
            {
                if (book[i].Contains(p))
                {
                    break;
                }

                step1++;
            }
        } else if (n == p)
        {
            return 0;
        }

        int limit = book.Count() - 1;
        for (int i = 0; i <= limit; i++)
        {
            if (book[i].Contains(p))
            {
                break;
            }

            step2++;
        }

        return Math.Min(step1, step2);
    }

}