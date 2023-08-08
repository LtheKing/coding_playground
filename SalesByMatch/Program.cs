class solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);
        Console.WriteLine(result);
    }
}

class Result
{
    public static int sockMerchant(int n, List<int> ar)
    {
        var dict = new Dictionary<int, int>();
        foreach (var value in ar)
        {
            // When the key is not found, "count" will be initialized to 0
            int count = 1;
            dict.TryGetValue(value, out count);
            dict[value] = count + 1;
        }

        int result = 0;

        foreach (var item in dict)
        {
            if ((item.Value / 2) >= 1)
            {
                result += item.Value / 2;
            }
        }

        return result;
    }
}